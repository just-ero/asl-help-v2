using System;

using AslHelp.Common.Results;
using AslHelp.Memory;
using AslHelp.Memory.StructReflection;
using AslHelp.Unity.Memory.Ipc;

namespace AslHelp.Unity.Runtime.Interop.Initialization;

internal abstract class Il2CppInitializer : MonoInitializer
{
    public override Result<MonoRuntime> Initialize(IMonoProcessMemory memory, Module il2CppModule)
    {
        var structs = GetStructs(memory);
        var defaults = GetDefaults(memory, il2CppModule);
        var loadedAssemblies = GetLoadedAssemblies(memory, il2CppModule);
        var typeInfoDefinitions = GetTypeInfoDefinitions(memory, il2CppModule);

        return Result.Combine(structs, defaults, loadedAssemblies, typeInfoDefinitions)
            .AndThen<MonoRuntime>(
                () => GetOperator(memory, structs.Unwrap(), defaults.Unwrap(), loadedAssemblies.Unwrap(), typeInfoDefinitions.Unwrap()));
    }

    protected sealed override MonoRuntime GetOperator(IMonoProcessMemory memory, Reflection structs, MonoDefaults defaults, nuint loadedAssemblies)
    {
        throw new NotImplementedException();
    }

    protected abstract Il2CppRuntime GetOperator(
        IMonoProcessMemory memory,
        Reflection structs,
        MonoDefaults defaults,
        nuint loadedAssemblies,
        nuint typeInfoDefinitions);

    protected abstract Result<nuint> GetTypeInfoDefinitions(IMonoProcessMemory memory, Module il2CppModule);
}
