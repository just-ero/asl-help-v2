using AslHelp.Memory.StructReflection;
using AslHelp.Unity.Memory.Ipc;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class Il2CppOperatorV24 : Il2CppOperator
{
    public Il2CppOperatorV24(
        IMonoProcessMemory memory,
        Reflection structs,
        MonoDefaults monoDefaults,
        nuint assemblies,
        nuint typeInfoDefinitions)
        : base(memory, structs, monoDefaults, assemblies, typeInfoDefinitions) { }
}
