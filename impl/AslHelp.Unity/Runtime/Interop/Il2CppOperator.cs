using AslHelp.Common.Results;
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

    public new static Result<Il2CppOperator> Create(IMonoProcessMemory memory)
    {
        return memory.RuntimeVersion switch
        {
            MonoRuntimeVersion.Il2CppV24 => Il2CppOperatorV24.Initialize(memory),
            _ => MonoInitError.RuntimeNotSupported
        };
    }
}
