using System;
using System.Runtime.CompilerServices;

using AslHelp.Common.Results;
using AslHelp.Memory;
using AslHelp.Memory.Scanning;
using AslHelp.Memory.StructReflection;
using AslHelp.Unity.Memory.Ipc;

namespace AslHelp.Unity.Runtime.Interop.Initialization;

internal class MonoInitializerV1 : MonoInitializer
{
    protected override string Runtime { get; } = "mono";
    protected override string Version { get; } = "1.0";

    protected override MonoOperator GetOperator(IMonoProcessMemory memory, Reflection structs, MonoDefaults defaults, nuint loadedAssemblies)
    {
        return new MonoOperatorV1(memory, structs, defaults, loadedAssemblies);
    }

    protected override Result<MonoDefaults> GetDefaults(IMonoProcessMemory memory, Module monoModule)
    {
        if (!monoModule.Symbols.TryGetValue("mono_get_corlib", out DebugSymbol symMonoGetCorlib)
            || symMonoGetCorlib.Address == 0)
        {
            return MonoInitError.Symbol_MonoGetCorlib_NotFound;
        }

        ScanPattern pattern = memory.Is64Bit
            ? new(3, "48 8B 05")
            : new(1, "A1");

        return memory.Scan(pattern, symMonoGetCorlib.Address, 0x10)
            .AndThen(defaultsRelative => memory.ReadRelative(defaultsRelative))
            .MapErr(_ => MonoInitError.MonoDefaults_FailedResolve)
            .AndThen(monoDefaults =>
            {
                // We can't read `MonoDefaults` directly because `nuint`s do not have the correct size when the target game is 32-bit.
                // `ReadSpan` handles this.
                Span<nuint> defaults = stackalloc nuint[18];

                return memory.ReadSpan(defaults, monoDefaults)
                    .Map(Unsafe.As<nuint, MonoDefaults>(ref defaults[0]));
            })
            .MapErr(_ => MonoInitError.MonoDefaults_FailedRead);
    }

    protected override Result<nuint> GetLoadedAssemblies(IMonoProcessMemory memory, Module monoModule)
    {
        if (!monoModule.Symbols.TryGetValue("mono_assembly_foreach", out var symMonoAssemblyForeach)
            || symMonoAssemblyForeach.Address == 0)
        {
            return MonoInitError.Symbol_MonoAssemblyForeach_NotFound;
        }

        ScanPattern pattern = memory.Is64Bit
            ? new(3, "48 8B 0D")
            : new(2, "FF 35");

        return memory.Scan(pattern, symMonoAssemblyForeach.Address, 0x100)
            .AndThen(loadedAssembliesRelative => memory.ReadRelative(loadedAssembliesRelative))
            .MapErr(_ => MonoInitError.LoadedAssemblies_FailedResolve);
    }
}
