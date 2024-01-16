using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using AslHelp.Collections;
using AslHelp.Common.Results;
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
        return memory.RuntimeVersion switch
        {
            MonoRuntimeVersion.MonoV1 => MonoOperatorV1.Initialize(memory),
            MonoRuntimeVersion.MonoV2 => MonoOperatorV2.Initialize(memory),
            MonoRuntimeVersion.MonoV2_1 => MonoOperatorV2_1.Initialize(memory),
            _ => MonoInitError.RuntimeNotSupported
        };
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
}
