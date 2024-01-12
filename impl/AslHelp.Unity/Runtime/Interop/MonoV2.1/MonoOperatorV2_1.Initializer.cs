using AslHelp.Common.Results;
using AslHelp.Memory.StructReflection;
using AslHelp.Unity.Memory.Ipc;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class MonoOperatorV2_1
{
    public new class Initializer : MonoOperatorV2.Initializer
    {
        public override Result<Reflection> GetStructs(IMonoProcessMemory memory)
        {
            const string Namespace = "AslHelp.Unity.Runtime.Structs";
            const string Runtime = "mono";
            const string Version = "2.1";

            return Reflection.Initialize(memory.Is64Bit, (Namespace, Runtime, Version));
        }
    }
}
