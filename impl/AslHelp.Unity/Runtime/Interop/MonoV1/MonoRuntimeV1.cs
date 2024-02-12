using AslHelp.Memory.StructReflection;
using AslHelp.Unity.Memory.Ipc;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class MonoRuntimeV1 : MonoRuntime
{
    public MonoRuntimeV1(IMonoProcessMemory memory, Reflection structs, MonoDefaults defaults, nuint assemblies)
        : base(memory, structs, defaults, assemblies) { }
}
