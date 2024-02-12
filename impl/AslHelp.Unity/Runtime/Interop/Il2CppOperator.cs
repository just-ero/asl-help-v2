using AslHelp.Memory.StructReflection;
using AslHelp.Unity.Memory.Ipc;

namespace AslHelp.Unity.Runtime.Interop;

internal abstract class Il2CppOperator : MonoOperator
{
    protected nuint _typeInfoDefinitions;

    protected Il2CppOperator(
        IMonoProcessMemory memory,
        Reflection structs,
        MonoDefaults il2CppDefaults,
        nuint assemblies,
        nuint typeInfoDefinitions)
        : base(memory, structs, il2CppDefaults, assemblies)
    {
        _typeInfoDefinitions = typeInfoDefinitions;
    }
}
