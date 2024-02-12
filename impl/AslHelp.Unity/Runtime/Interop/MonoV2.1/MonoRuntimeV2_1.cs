using AslHelp.Memory.StructReflection;
using AslHelp.Unity.Memory.Ipc;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class MonoRuntimeV2_1 : MonoRuntimeV2
{
    public MonoRuntimeV2_1(IMonoProcessMemory memory, Reflection structs, MonoDefaults monoDefaults, nuint assemblies)
        : base(memory, structs, monoDefaults, assemblies) { }
}
