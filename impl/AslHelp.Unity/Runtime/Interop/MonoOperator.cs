using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

using AslHelp.Collections;
using AslHelp.Common.Results;
using AslHelp.LiveSplit.Diagnostics;
using AslHelp.Memory.StructReflection;
using AslHelp.Unity.Memory.Ipc;

namespace AslHelp.Unity.Runtime.Interop;

public abstract class MonoOperator
{
    protected readonly IMonoProcessMemory _memory;
    protected readonly Reflection _structs;
    protected readonly MonoDefaults _defaults;
    protected readonly nuint _loadedAssemblies;

    protected MonoOperator(IMonoProcessMemory memory, Reflection structs, MonoDefaults defaults, nuint assemblies)
    {
        _memory = memory;
        _structs = structs;
        _defaults = defaults;
        _loadedAssemblies = assemblies;
        Images = new MonoImageLookup(this);
    }

    public KeyedCollection<string, MonoImage> Images { get; }

    public static Result<MonoOperator> Create(IMonoProcessMemory memory)
    {
        Initializer initializer = memory.RuntimeVersion switch
        {
            MonoRuntimeVersion.MonoV1 => new MonoOperatorV1.Initializer(),
            MonoRuntimeVersion.MonoV2 => new MonoOperatorV2.Initializer(),
            MonoRuntimeVersion.MonoV2_1 => new MonoOperatorV2_1.Initializer(),
            _ => throw new NotSupportedException("Unsupported runtime version. Use Il2CppOperator.TryCreate for IL2CPP.")
        };

        return
            initializer.GetStructs(memory)
            .AndThen(structs =>
            {
                return
                    initializer.GetDefaults(memory)
                    .Map(defaults => (Structs: structs, Defaults: defaults));
            })
            .AndThen(res =>
            {
                return
                    initializer.GetAssemblies(memory)
                    .Map(assemblies => (res.Structs, res.Defaults, assemblies));
            })
            .AndThen<MonoOperator>(res =>
            {
                var (structs, defaults, assemblies) = res;

#pragma warning disable CS8509 // The switch expression does not handle all possible values of its input type (it is not exhaustive).
                return memory.RuntimeVersion switch
#pragma warning restore CS8509
                {
                    MonoRuntimeVersion.MonoV1 => new MonoOperatorV1(memory, structs, defaults, assemblies),
                    MonoRuntimeVersion.MonoV2 => new MonoOperatorV2(memory, structs, defaults, assemblies),
                    MonoRuntimeVersion.MonoV2_1 => new MonoOperatorV2_1(memory, structs, defaults, assemblies)
                };
            });
    }

    public abstract IEnumerable<nuint> TryGetImages();
    public abstract bool TryGetImageName(nuint image, [NotNullWhen(true)] out string? name);
    public abstract bool TryGetImageFileName(nuint image, [NotNullWhen(true)] out string? fileName);

    public abstract IEnumerable<nuint> TryGetClasses(nuint image);
    public abstract bool TryGetClassName(nuint klass, [NotNullWhen(true)] out string? name);
    public abstract bool TryGetClassNamespace(nuint klass, [NotNullWhen(true)] out string? @namespace);
    public abstract bool TryGetClassParent(nuint klass, out nuint parent);
    public abstract bool TryGetClassStaticDataChunk(nuint klass, out nuint staticDataChunk);

    public abstract IEnumerable<nuint> TryGetFields(nuint klass);
    public abstract bool TryGetFieldName(nuint field, [NotNullWhen(true)] out string? name);
    public abstract bool TryGetFieldOffset(nuint field, out int offset);
    public abstract bool TryGetFieldType(nuint field, out nuint type);

    public abstract bool TryGetTypeData(nuint type, out nuint data);
    public abstract bool TryGetTypeAttributes(nuint type, out MonoFieldAttribute attributes);
    public abstract bool TryGetTypeElementType(nuint type, out MonoElementType elementType);

    public abstract class Initializer
    {
        public abstract Result<Reflection> GetStructs(IMonoProcessMemory memory);
        public abstract Result<MonoDefaults> GetDefaults(IMonoProcessMemory memory);
        public abstract Result<nuint> GetAssemblies(IMonoProcessMemory memory);
    }
}
