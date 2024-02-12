using AslHelp.Memory.StructReflection;
using AslHelp.Unity.Memory.Ipc;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class MonoRuntimeV2 : MonoRuntimeV1
{
    public MonoRuntimeV2(IMonoProcessMemory memory, Reflection structs, MonoDefaults monoDefaults, nuint assemblies)
        : base(memory, structs, monoDefaults, assemblies) { }
}
