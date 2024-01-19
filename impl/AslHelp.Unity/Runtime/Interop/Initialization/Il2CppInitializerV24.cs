using System;
using System.Runtime.CompilerServices;

using AslHelp.Common.Results;
using AslHelp.Memory;
using AslHelp.Memory.Scanning;
using AslHelp.Memory.StructReflection;
using AslHelp.Unity.Memory.Ipc;

namespace AslHelp.Unity.Runtime.Interop.Initialization;

public class Il2CppInitializerV24 : Il2CppInitializer
{
    protected override Il2CppOperator New(
        IMonoProcessMemory memory,
        Reflection structs,
        MonoDefaults defaults,
        nuint loadedAssemblies,
        nuint typeInfoDefinitions)
    {
        return new Il2CppOperatorV24(memory, structs, defaults, loadedAssemblies, typeInfoDefinitions);
    }

    protected override Result<Reflection> GetStructs(IMonoProcessMemory memory)
    {
        const string Namespace = "AslHelp.Unity.Runtime.Structs";
        const string Runtime = "il2cpp";
        const string Version = "24.0";

        return Reflection.Initialize(memory.Is64Bit, (Namespace, Runtime, Version));
    }

    protected override Result<MonoDefaults> GetDefaults(IMonoProcessMemory memory, Module il2CppModule)
    {
        if (!il2CppModule.Symbols.TryGetValue("il2cpp_get_corlib", out var symIl2CppGetCorlib)
            || symIl2CppGetCorlib.Address == 0)
        {
            return MonoInitError.SymbolIl2CppGetCorlibNotFound;
        }

        ScanPattern callPattern = memory.Is64Bit
            ? new(1, "E9")
            : new(1, "E9");

        ScanPattern patternFromIl2CppGetCorlib = memory.Is64Bit
            ? new(3, "48 8B 05")
            : new(1, "A1");

        return memory.Scan(callPattern, symIl2CppGetCorlib.Address, 0x10)
            .AndThen(il2CppGetCorlibRelative => memory.ReadRelative(il2CppGetCorlibRelative)
                .AndThen(il2CppGetCorlib => memory.Scan(patternFromIl2CppGetCorlib, il2CppGetCorlib, 0x10))
                .OrElse(_ => memory.Scan(patternFromIl2CppGetCorlib, symIl2CppGetCorlib.Address, 0x10)))
            .AndThen(il2CppDefaultsRelative => memory.ReadRelative(il2CppDefaultsRelative))
            .MapErr(_ => MonoInitError.Il2CppDefaultsNotResolved)
            .AndThen(il2CppDefaults =>
            {
                Span<nuint> defaults = stackalloc nuint[18];

                return memory.ReadSpan(defaults, il2CppDefaults)
                    .Map(Unsafe.As<nuint, MonoDefaults>(ref defaults[0]));
            })
            .MapErr(_ => MonoInitError.Il2CppDefaultsReadFailed);
    }

    protected override Result<nuint> GetLoadedAssemblies(IMonoProcessMemory memory, Module il2CppModule)
    {
        if (!il2CppModule.Symbols.TryGetValue("il2cpp_domain_get_assemblies", out var symIl2CppDomainGetAssemblies)
            || symIl2CppDomainGetAssemblies.Address == 0)
        {
            return MonoInitError.SymbolIl2CppDomainGetAssembliesNotFound;
        }

        ScanPattern callPattern = new(1, "E8");

        ScanPattern patternFromIl2CppDomainGetAssemblies = memory.Is64Bit
            ? new(3, "48 2B 05")
            : new(2, "2B 0D");

        ScanPattern patternFromGetAssemblies = memory.Is64Bit
            ? new(3, "48 8D 05")
            : new(1, "B8");

        return
            memory.Scan(callPattern, symIl2CppDomainGetAssemblies.Address, 0x20)
            .AndThen(getAssembliesRelative => memory.ReadRelative(getAssembliesRelative)
                .AndThen(getAssemblies => memory.Scan(patternFromGetAssemblies, getAssemblies, 0x10))
                .OrElse(_ => memory.Scan(patternFromIl2CppDomainGetAssemblies, symIl2CppDomainGetAssemblies.Address, 0x20)))
            .AndThen(sAssembliesRelative => memory.ReadRelative(sAssembliesRelative))
            .MapErr(_ => MonoInitError.SAssembliesNotResolved);
    }

    protected override Result<nuint> GetTypeInfoDefinitions(IMonoProcessMemory memory, Module il2CppModule)
    {
        ScanPattern pattern = memory.Is64Bit
            ? new(3, "48 8B 05 ???????? 48 83 3C ?? 00")
            : new(1, "A1 ???????? 83 3C ?? 00");

        return
            memory.Scan(pattern, il2CppModule.Base, (int)il2CppModule.MemorySize)
            .AndThen(sTypeInfoDefinitionsRelative => memory.ReadRelative(sTypeInfoDefinitionsRelative))
            .MapErr(_ => MonoInitError.STypeInfoDefinitionTableNotResolved);
    }
}
