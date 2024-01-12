using AslHelp.Memory.StructReflection;
using AslHelp.Unity.Memory.Ipc;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class MonoOperatorV2_1 : MonoOperatorV2
{
    public MonoOperatorV2_1(IMonoProcessMemory memory, Reflection structs, MonoDefaults monoDefaults, nuint assemblies)
        : base(memory, structs, monoDefaults, assemblies) { }
}
