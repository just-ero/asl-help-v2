using AslHelp.Common.Results;
using AslHelp.Memory;
using AslHelp.Memory.StructReflection;
using AslHelp.Unity.Memory.Ipc;

namespace AslHelp.Unity.Runtime.Interop.Initialization;

public abstract class Il2CppInitializer
{
    public Result<Il2CppOperator> Initialize(IMonoProcessMemory memory, Module il2CppModule)
    {
        var structs = GetStructs(memory);
        var defaults = GetDefaults(memory, il2CppModule);
        var loadedAssemblies = GetLoadedAssemblies(memory, il2CppModule);
        var typeInfoDefinitions = GetTypeInfoDefinitions(memory, il2CppModule);

        return Result.Combine(structs, defaults, loadedAssemblies, typeInfoDefinitions)
            .Map(New(memory, structs.Unwrap(), defaults.Unwrap(), loadedAssemblies.Unwrap(), typeInfoDefinitions.Unwrap()));
    }

    protected abstract Il2CppOperator New(
        IMonoProcessMemory memory,
        Reflection structs,
        MonoDefaults defaults,
        nuint loadedAssemblies,
        nuint typeInfoDefinitions);

    protected abstract Result<Reflection> GetStructs(IMonoProcessMemory memory);
    protected abstract Result<MonoDefaults> GetDefaults(IMonoProcessMemory memory, Module monoModule);
    protected abstract Result<nuint> GetLoadedAssemblies(IMonoProcessMemory memory, Module monoModule);
    protected abstract Result<nuint> GetTypeInfoDefinitions(IMonoProcessMemory memory, Module il2CppModule);
}
