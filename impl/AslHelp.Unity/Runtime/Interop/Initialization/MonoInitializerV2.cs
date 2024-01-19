using AslHelp.Common.Results;
using AslHelp.Memory.StructReflection;
using AslHelp.Unity.Memory.Ipc;

namespace AslHelp.Unity.Runtime.Interop.Initialization;

public class MonoInitializerV2 : MonoInitializerV1
{
    protected override MonoOperator New(IMonoProcessMemory memory, Reflection structs, MonoDefaults defaults, nuint loadedAssemblies)
    {
        return new MonoOperatorV2(memory, structs, defaults, loadedAssemblies);
    }

    protected override Result<Reflection> GetStructs(IMonoProcessMemory memory)
    {
        const string Namespace = "AslHelp.Unity.Runtime.Structs";
        const string Runtime = "mono";
        const string Version = "2.0";

        return Reflection.Initialize(memory.Is64Bit, (Namespace, Runtime, Version));
    }
}
