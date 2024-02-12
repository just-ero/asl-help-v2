using System;
using System.Runtime.CompilerServices;

using AslHelp.Common.Results;
using AslHelp.Memory;
using AslHelp.Memory.Scanning;
using AslHelp.Memory.StructReflection;
using AslHelp.Unity.Memory.Ipc;

namespace AslHelp.Unity.Runtime.Interop.Initialization;

internal class Il2CppInitializerV24 : Il2CppInitializer
{
    protected override string Runtime { get; } = "il2cpp";
    protected override string Version { get; } = "24.0";

    protected override Il2CppRuntime GetOperator(
        IMonoProcessMemory memory,
        Reflection structs,
        MonoDefaults defaults,
        nuint loadedAssemblies,
        nuint typeInfoDefinitions)
    {
        return new Il2CppRuntimeV24(memory, structs, defaults, loadedAssemblies, typeInfoDefinitions);
    }

    protected override Result<MonoDefaults> GetDefaults(IMonoProcessMemory memory, Module il2CppModule)
    {
        if (!il2CppModule.Symbols.TryGetValue("il2cpp_get_corlib", out var symIl2CppGetCorlib)
            || symIl2CppGetCorlib.Address == 0)
        {
            return MonoInitError.Symbol_Il2CppGetCorlib_NotFound;
        }

        ScanPattern callPattern = new(1, "E9");

        ScanPattern patternFromIl2CppGetCorlib = memory.Is64Bit
            ? new(3, "48 8B 05")
            : new(1, "A1");

        return memory.Scan(callPattern, symIl2CppGetCorlib.Address, 0x10)
            .AndThen(il2CppGetCorlibRelative => memory.ReadRelative(il2CppGetCorlibRelative)
                .AndThen(il2CppGetCorlib => memory.Scan(patternFromIl2CppGetCorlib, il2CppGetCorlib, 0x10))
                .OrElse(_ => memory.Scan(patternFromIl2CppGetCorlib, symIl2CppGetCorlib.Address, 0x10)))
            .AndThen(il2CppDefaultsRelative => memory.ReadRelative(il2CppDefaultsRelative))
            .MapErr(_ => MonoInitError.Il2CppDefaults_FailedResolve)
            .AndThen(il2CppDefaults =>
            {
                Span<nuint> defaults = stackalloc nuint[18];

                return memory.ReadSpan(defaults, il2CppDefaults)
                    .Map(Unsafe.As<nuint, MonoDefaults>(ref defaults[0]));
            })
            .MapErr(_ => MonoInitError.Il2CppDefaults_FailedRead);
    }

    protected override Result<nuint> GetLoadedAssemblies(IMonoProcessMemory memory, Module il2CppModule)
    {
        if (!il2CppModule.Symbols.TryGetValue("il2cpp_domain_get_assemblies", out var symIl2CppDomainGetAssemblies)
            || symIl2CppDomainGetAssemblies.Address == 0)
        {
            return MonoInitError.Symbol_Il2CppDomainGetAssemblies_NotFound;
        }

        ScanPattern callPattern = new(1, "E8");

        ScanPattern patternFromIl2CppDomainGetAssemblies = memory.Is64Bit
            ? new(3, "48 2B 05")
            : new(2, "2B 0D");

        ScanPattern patternFromGetAssemblies = memory.Is64Bit
            ? new(3, "48 8D 05")
            : new(1, "B8");

        return memory.Scan(callPattern, symIl2CppDomainGetAssemblies.Address, 0x20)
            .AndThen(getAssembliesRelative => memory.ReadRelative(getAssembliesRelative)
                .AndThen(getAssemblies => memory.Scan(patternFromGetAssemblies, getAssemblies, 0x10))
                .OrElse(_ => memory.Scan(patternFromIl2CppDomainGetAssemblies, symIl2CppDomainGetAssemblies.Address, 0x20)))
            .AndThen(sAssembliesRelative => memory.ReadRelative(sAssembliesRelative))
            .MapErr(_ => MonoInitError.SAssemblies_FailedResolve);
    }

    protected override Result<nuint> GetTypeInfoDefinitions(IMonoProcessMemory memory, Module il2CppModule)
    {
        ScanPattern pattern = memory.Is64Bit
            ? new(3, "48 8B 05 ???????? 48 83 3C ?? 00")
            : new(1, "A1 ???????? 83 3C ?? 00");

        return memory.Scan(pattern, il2CppModule.Base, (int)il2CppModule.MemorySize)
            .AndThen(sTypeInfoDefinitionsRelative => memory.ReadRelative(sTypeInfoDefinitionsRelative))
            .MapErr(_ => MonoInitError.STypeInfoDefinitionTable_FailedResolve);
    }
}
