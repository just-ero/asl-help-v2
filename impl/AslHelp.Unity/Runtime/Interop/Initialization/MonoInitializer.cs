using AslHelp.Common.Results;
using AslHelp.Memory;
using AslHelp.Memory.StructReflection;
using AslHelp.Unity.Memory.Ipc;

namespace AslHelp.Unity.Runtime.Interop.Initialization;

public abstract class MonoInitializer
{
    public Result<MonoOperator> Initialize(IMonoProcessMemory memory, Module monoModule)
    {
        var structs = GetStructs(memory);
        var defaults = GetDefaults(memory, monoModule);
        var loadedAssemblies = GetLoadedAssemblies(memory, monoModule);

        return Result.Combine(structs, defaults, loadedAssemblies)
            .Map(New(memory, structs.Unwrap(), defaults.Unwrap(), loadedAssemblies.Unwrap()));
    }

    protected abstract MonoOperator New(
        IMonoProcessMemory memory,
        Reflection structs,
        MonoDefaults defaults,
        nuint loadedAssemblies);

    protected abstract Result<Reflection> GetStructs(IMonoProcessMemory memory);
    protected abstract Result<MonoDefaults> GetDefaults(IMonoProcessMemory memory, Module monoModule);
    protected abstract Result<nuint> GetLoadedAssemblies(IMonoProcessMemory memory, Module monoModule);
}
