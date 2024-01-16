using AslHelp.Common.Results;
using AslHelp.Memory.StructReflection;
using AslHelp.Unity.Memory.Ipc;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class MonoOperatorV2 : MonoOperatorV1
{
    public MonoOperatorV2(IMonoProcessMemory memory, Reflection structs, MonoDefaults monoDefaults, nuint assemblies)
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
                        new MonoOperatorV2(memory, structs, defaults, assemblies))));
    }

    new protected static Result<Reflection> GetStructs(IMonoProcessMemory memory)
    {
        const string Namespace = "AslHelp.Unity.Runtime.Structs";
        const string Runtime = "mono";
        const string Version = "2.0";

        return Reflection.Initialize(memory.Is64Bit, (Namespace, Runtime, Version));
    }
}
