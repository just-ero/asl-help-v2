using System.Collections.Generic;
using System.Runtime.CompilerServices;

using AslHelp.Collections;
using AslHelp.Common.Results;
using AslHelp.Memory;
using AslHelp.Memory.StructReflection;
using AslHelp.Unity.Memory.Ipc;
using AslHelp.Unity.Runtime.Interop.Initialization;

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

    [SkipLocalsInit]
    public static Result<MonoOperator> Initialize<TInitializer>(IMonoProcessMemory memory, Module monoModule)
        where TInitializer : MonoInitializer, new()
    {
        var initializer = new TInitializer();
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
