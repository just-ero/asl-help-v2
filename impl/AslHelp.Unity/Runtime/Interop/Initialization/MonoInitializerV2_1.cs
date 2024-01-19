using AslHelp.Common.Results;
using AslHelp.Memory;
using AslHelp.Memory.Scanning;
using AslHelp.Memory.StructReflection;
using AslHelp.Unity.Memory.Ipc;

namespace AslHelp.Unity.Runtime.Interop.Initialization;

public class MonoInitializerV2_1 : MonoInitializerV2
{
    protected override MonoOperator New(IMonoProcessMemory memory, Reflection structs, MonoDefaults defaults, nuint loadedAssemblies)
    {
        return new MonoOperatorV2_1(memory, structs, defaults, loadedAssemblies);
    }

    protected override Result<Reflection> GetStructs(IMonoProcessMemory memory)
    {
        const string Namespace = "AslHelp.Unity.Runtime.Structs";
        const string Runtime = "mono";
        const string Version = "2.1";

        return Reflection.Initialize(memory.Is64Bit, (Namespace, Runtime, Version));
    }

    protected override Result<nuint> GetLoadedAssemblies(IMonoProcessMemory memory, Module monoModule)
    {
        if (!monoModule.Symbols.TryGetValue("mono_assembly_foreach", out var symMonoAssemblyForeach)
            || symMonoAssemblyForeach.Address == 0)
        {
            return MonoInitError.Symbol_MonoAssemblyForeach_NotFound;
        }

        ScanPattern pattern = memory.Is64Bit
            ? new(3, "48 8B 0D")
            : new(2, "8B 35");

        return memory.Scan(pattern, symMonoAssemblyForeach.Address, 0x100)
            .AndThen(loadedAssembliesRelative => memory.ReadRelative(loadedAssembliesRelative))
            .MapErr(_ => MonoInitError.LoadedAssembliesNotResolved);
    }
}
