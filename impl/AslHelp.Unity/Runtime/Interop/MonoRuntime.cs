using System;
using System.Collections.Generic;

using AslHelp.Collections;
using AslHelp.Common.Results;
using AslHelp.Memory;
using AslHelp.Memory.StructReflection;
using AslHelp.Unity.Memory.Ipc;
using AslHelp.Unity.Runtime.Initialization;

namespace AslHelp.Unity.Runtime.Interop;

public abstract class MonoRuntime
{
    protected readonly IMonoProcessMemory _memory;
    protected readonly Reflection _structs;
    protected readonly MonoDefaults _defaults;
    protected readonly nuint _loadedAssemblies;

    protected MonoRuntime(IMonoProcessMemory memory, Reflection structs, MonoDefaults defaults, nuint assemblies)
    {
        _memory = memory;
        _structs = structs;
        _defaults = defaults;
        _loadedAssemblies = assemblies;

        Images = new MonoImageLookup(this);
    }

    public KeyedCollection<string, MonoImage> Images { get; }

    public static Result<MonoRuntime> Initialize(IMonoProcessMemory memory, Module monoModule, MonoRuntimeVersion version)
    {
        MonoRuntimeInitializer initializer = version switch
        {
            MonoRuntimeVersion.MonoV1 => new MonoRuntimeInitializerV1(),
            MonoRuntimeVersion.MonoV2 => new MonoRuntimeInitializerV2(),
            MonoRuntimeVersion.MonoV2_1 => new MonoRuntimeInitializerV2_1(),
            MonoRuntimeVersion.Il2CppV24 => new Il2CppRuntimeInitializerV24(),
            MonoRuntimeVersion.Il2CppV27 => throw new NotImplementedException("Il2Cpp 27 is not yet supported."),
            MonoRuntimeVersion.Il2CppV29 => throw new NotImplementedException("Il2Cpp 29 is not yet supported."),
            _ => throw new ArgumentException($"Invalid Mono runtime version ({version}).", nameof(version))
        };

        return initializer.Initialize(memory, monoModule);
    }

    public abstract Result<IEnumerable<Result<nuint>>> GetImages();
    public abstract Result<string> GetImageName(nuint image);
    public abstract Result<string> GetImageFileName(nuint image);

    public abstract Result<IEnumerable<Result<nuint>>> GetClasses(nuint image);
    public abstract Result<string> GetClassName(nuint klass);
    public abstract Result<string> GetClassNamespace(nuint klass);
    public abstract Result<nuint> GetClassParent(nuint klass);
    public abstract Result<nuint> GetClassStaticDataChunk(nuint klass);

    public abstract Result<IEnumerable<Result<nuint>>> GetFields(nuint klass);
    public abstract Result<string> GetFieldName(nuint field);
    public abstract Result<int> GetFieldOffset(nuint field);
    public abstract Result<nuint> GetFieldType(nuint field);

    public abstract Result<nuint> GetTypeData(nuint type);
    public abstract Result<MonoFieldAttribute> GetTypeAttributes(nuint type);
    public abstract Result<MonoElementType> GetTypeElementType(nuint type);
}
