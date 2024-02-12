using AslHelp.Common.Results;
using AslHelp.Memory;
using AslHelp.Memory.StructReflection;
using AslHelp.Unity.Memory.Ipc;
using AslHelp.Unity.Runtime.Interop;

namespace AslHelp.Unity.Runtime.Initialization;

internal abstract class MonoRuntimeInitializer
{
    protected abstract string Runtime { get; }
    protected abstract string Version { get; }

    public virtual Result<MonoRuntime> Initialize(IMonoProcessMemory memory, Module monoModule)
    {
        var structs = GetStructs(memory);
        var defaults = GetDefaults(memory, monoModule);
        var loadedAssemblies = GetLoadedAssemblies(memory, monoModule);

        return Result.Combine(structs, defaults, loadedAssemblies)
            .AndThen<MonoRuntime>(
                () => GetOperator(memory, structs.Unwrap(), defaults.Unwrap(), loadedAssemblies.Unwrap()));
    }

    protected abstract MonoRuntime GetOperator(
        IMonoProcessMemory memory,
        Reflection structs,
        MonoDefaults defaults,
        nuint loadedAssemblies);

    protected abstract Result<MonoDefaults> GetDefaults(IMonoProcessMemory memory, Module monoModule);
    protected abstract Result<nuint> GetLoadedAssemblies(IMonoProcessMemory memory, Module monoModule);

    protected Result<Reflection> GetStructs(IMonoProcessMemory memory)
    {
        const string Namespace = "AslHelp.Unity.Runtime.Structs";

        return Reflection.Initialize(memory.Is64Bit, (Namespace, Runtime, Version));
    }
}
