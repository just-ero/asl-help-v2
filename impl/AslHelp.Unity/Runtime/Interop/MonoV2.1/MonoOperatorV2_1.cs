using AslHelp.Common.Results;
using AslHelp.Memory.Scanning;
using AslHelp.Memory.StructReflection;
using AslHelp.Unity.Memory.Ipc;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class MonoOperatorV2_1 : MonoOperatorV2
{
    public MonoOperatorV2_1(IMonoProcessMemory memory, Reflection structs, MonoDefaults monoDefaults, nuint assemblies)
        : base(memory, structs, monoDefaults, assemblies) { }

    new public static Result<MonoOperator> Initialize(IMonoProcessMemory memory)
    {
        return
            GetStructs(memory)
            .AndThen(structs =>
                GetDefaults(memory)
                .AndThen(defaults =>
                    GetAssemblies(memory)
                    .AndThen<MonoOperator>(assemblies =>
                        new MonoOperatorV2_1(memory, structs, defaults, assemblies))));
    }

    new protected static Result<Reflection> GetStructs(IMonoProcessMemory memory)
    {
        const string Namespace = "AslHelp.Unity.Runtime.Structs";
        const string Runtime = "mono";
        const string Version = "2.1";

        return Reflection.Initialize(memory.Is64Bit, (Namespace, Runtime, Version));
    }

    new protected static Result<nuint> GetAssemblies(IMonoProcessMemory memory)
    {
        if (!memory.MonoModule.Symbols.TryGetValue("mono_assembly_foreach", out var symMonoAssemblyForeach)
            || symMonoAssemblyForeach.Address == 0)
        {
            return MonoInitError.SymbolMonoAssemblyForeachNotFound;
        }

        ScanPattern pattern = memory.Is64Bit
            ? new(3, "48 8B 0D")
            : new(2, "8B 35");

        return
            memory.Scan(pattern, symMonoAssemblyForeach.Address, 0x100)
            .AndThen(loadedAssembliesRelative =>
                memory.ReadRelative(loadedAssembliesRelative));
    }
}
