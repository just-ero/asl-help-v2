using System;
using System.Runtime.CompilerServices;

using AslHelp.Common.Results;
using AslHelp.Memory.Scanning;
using AslHelp.Memory.StructReflection;
using AslHelp.Unity.Memory.Ipc;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class MonoOperatorV1 : MonoOperator
{
    public MonoOperatorV1(IMonoProcessMemory memory, Reflection structs, MonoDefaults defaults, nuint assemblies)
        : base(memory, structs, defaults, assemblies) { }

    public static Result<MonoOperator> Initialize(IMonoProcessMemory memory)
    {
        return GetStructs(memory)
            .AndThen(structs => GetDefaults(memory)
                .AndThen(defaults => GetAssemblies(memory)
                    .AndThen<MonoOperator>(assemblies => new MonoOperatorV1(memory, structs, defaults, assemblies))));
    }

    protected static Result<Reflection> GetStructs(IMonoProcessMemory memory)
    {
        const string Namespace = "AslHelp.Unity.Runtime.Structs";
        const string Runtime = "mono";
        const string Version = "1.0";

        return Reflection.Initialize(memory.Is64Bit, (Namespace, Runtime, Version));
    }

    protected static Result<MonoDefaults> GetDefaults(IMonoProcessMemory memory)
    {
        if (!memory.MonoModule.Symbols.TryGetValue("mono_get_corlib", out var symMonoGetCorLib)
            || symMonoGetCorLib.Address == 0)
        {
            return MonoInitError.SymbolMonoGetCorlibNotFound;
        }

        ScanPattern pattern = memory.Is64Bit
            ? new(3, "48 8B 05")
            : new(1, "A1");

        return
            memory.Scan(pattern, symMonoGetCorLib.Address, 0x10)
            .AndThen(defaultsRelative =>
                memory.ReadRelative(defaultsRelative)
                .AndThen(monoDefaults =>
                {
                    Span<nuint> defaults = stackalloc nuint[18];

                    return
                        memory.ReadSpan(defaults, monoDefaults)
                        .Map(Unsafe.As<nuint, MonoDefaults>(ref defaults[0]));
                }));
    }

    protected static Result<nuint> GetAssemblies(IMonoProcessMemory memory)
    {
        if (!memory.MonoModule.Symbols.TryGetValue("mono_assembly_foreach", out var symMonoAssemblyForeach)
            || symMonoAssemblyForeach.Address == 0)
        {
            return MonoInitError.SymbolMonoAssemblyForeachNotFound;
        }

        ScanPattern pattern = memory.Is64Bit
            ? new(3, "48 8B 0D")
            : new(2, "FF 35");

        return
            memory.Scan(pattern, symMonoAssemblyForeach.Address, 0x100)
            .AndThen(loadedAssembliesRelative =>
                memory.ReadRelative(loadedAssembliesRelative));
    }
}
