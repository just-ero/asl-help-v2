using AslHelp.Memory.StructReflection;
using AslHelp.Unity.Memory.Ipc;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class Il2CppRuntimeV24 : Il2CppRuntime
{
    public Il2CppRuntimeV24(
        IMonoProcessMemory memory,
        Reflection structs,
        MonoDefaults monoDefaults,
        nuint assemblies,
        nuint typeInfoDefinitions)
        : base(memory, structs, monoDefaults, assemblies, typeInfoDefinitions) { }
}
