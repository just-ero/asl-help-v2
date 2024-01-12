using System;
using System.Diagnostics;

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
        Initializer initializer = memory.RuntimeVersion switch
        {
            MonoRuntimeVersion.Il2CppV24 => new Il2CppOperatorV24.Initializer(),
            _ => throw new NotSupportedException("Unsupported runtime version. Use MonoOperator.TryCreate for Mono.")
        };

        return
            initializer.GetStructs(memory)
            .AndThen(structs =>
            {
                return
                    initializer.GetDefaults(memory)
                    .Map(defaults => (Structs: structs, Defaults: defaults));
            })
            .AndThen(res =>
            {
                return
                    initializer.GetAssemblies(memory)
                    .Map(assemblies => (res.Structs, res.Defaults, Assemblies: assemblies));
            })
            .AndThen(res =>
            {
                return
                    initializer.GetTypeInfoDefinitions(memory)
                    .Map(typeInfoDefinitions => (res.Structs, res.Defaults, res.Assemblies, typeInfoDefinitions));
            })
            .AndThen<Il2CppOperator>(res =>
            {
                var (structs, defaults, assemblies, typeInfoDefinitions) = res;

#pragma warning disable CS8509 // The switch expression does not handle all possible values of its input type (it is not exhaustive).
                return memory.RuntimeVersion switch
#pragma warning restore CS8509
                {
                    MonoRuntimeVersion.Il2CppV24 => new Il2CppOperatorV24(memory, structs, defaults, assemblies, typeInfoDefinitions)
                };
            });
    }

    public new abstract class Initializer : MonoOperator.Initializer
    {
        public abstract Result<nuint> GetTypeInfoDefinitions(IMonoProcessMemory memory);
    }
}
