using AslHelp.Memory.StructReflection;
using AslHelp.Unity.Memory.Ipc;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class MonoOperatorV1 : MonoOperator
{
    public MonoOperatorV1(IMonoProcessMemory memory, Reflection structs, MonoDefaults defaults, nuint assemblies)
        : base(memory, structs, defaults, assemblies) { }
}
