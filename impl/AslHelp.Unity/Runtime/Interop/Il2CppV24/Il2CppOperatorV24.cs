using System;
using System.Runtime.CompilerServices;

using AslHelp.Common.Results;
using AslHelp.Memory.Scanning;
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

    public static Result<Il2CppOperator> Initialize(IMonoProcessMemory memory)
    {
        return
            GetStructs(memory)
            .AndThen(structs =>
                GetDefaults(memory)
                .AndThen(defaults =>
                    GetAssemblies(memory)
                    .AndThen(assemblies =>
                        GetTypeInfoDefinitions(memory)
                        .AndThen<Il2CppOperator>(typeInfoDefinitions =>
                            new Il2CppOperatorV24(memory, structs, defaults, assemblies, typeInfoDefinitions)))));
    }

    protected static Result<Reflection> GetStructs(IMonoProcessMemory memory)
    {
        const string Namespace = "AslHelp.Unity.Runtime.Structs";
        const string Runtime = "il2cpp";
        const string Version = "24.0";

        return Reflection.Initialize(memory.Is64Bit, (Namespace, Runtime, Version));
    }

    protected static Result<MonoDefaults> GetDefaults(IMonoProcessMemory memory)
    {
        if (!memory.MonoModule.Symbols.TryGetValue("il2cpp_get_corlib", out var symIl2CppGetCorlib)
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

        return
            memory.Scan(callPattern, symIl2CppGetCorlib.Address, 0x10)
            .AndThen(il2CppGetCorlibRelative =>
                memory.ReadRelative(il2CppGetCorlibRelative)
                .AndThen(il2CppGetCorlib => memory.Scan(patternFromIl2CppGetCorlib, il2CppGetCorlib, 0x10))
                .OrElse(_ => memory.Scan(patternFromIl2CppGetCorlib, symIl2CppGetCorlib.Address, 0x10))
                .Or())
            .AndThen(il2CppDefaultsRelative =>
                memory.ReadRelative(il2CppDefaultsRelative)
                .Or())
            .AndThen(il2CppDefaults =>
            {
                Span<nuint> defaults = stackalloc nuint[18];

                return
                    memory.ReadSpan(defaults, il2CppDefaults)
                    .Or()
                    .Map(Unsafe.As<nuint, MonoDefaults>(ref defaults[0]));
            });
    }

    protected static Result<nuint> GetAssemblies(IMonoProcessMemory memory)
    {
        if (!memory.MonoModule.Symbols.TryGetValue("il2cpp_domain_get_assemblies", out var symIl2CppDomainGetAssemblies)
            || symIl2CppDomainGetAssemblies.Address == 0)
        {
            return MonoInitError.SymbolIl2CppDomainGetAssembliesNotFound;
        }

        ScanPattern callPattern = memory.Is64Bit
            ? new(1, "E8")
            : new(1, "E8");

        ScanPattern patternFromIl2CppDomainGetAssemblies = memory.Is64Bit
            ? new(3, "48 2B 05")
            : new(2, "2B 0D");

        ScanPattern patternFromGetAssemblies = memory.Is64Bit
            ? new(3, "48 8D 05")
            : new(1, "B8");

        return
            memory.Scan(callPattern, symIl2CppDomainGetAssemblies.Address, 0x20)
            .AndThen(getAssembliesRelative =>
                memory.ReadRelative(getAssembliesRelative)
                .AndThen(getAssemblies => memory.Scan(patternFromGetAssemblies, getAssemblies, 0x10))
                .OrElse(_ => memory.Scan(patternFromIl2CppDomainGetAssemblies, symIl2CppDomainGetAssemblies.Address, 0x20))
                .Or()
            .AndThen(sAssembliesRelative =>
                memory.ReadRelative(sAssembliesRelative)
                .Or(MonoInitError.SAssembliesNotResolved));
    }

    protected static Result<nuint> GetTypeInfoDefinitions(IMonoProcessMemory memory)
    {
        ScanPattern pattern = memory.Is64Bit
            ? new(3, "48 8B 05 ???????? 48 83 3C ?? 00")
            : new(1, "A1 ???????? 83 3C ?? 00");

        nuint sTypeInfoDefinitionsRelative = memory.Scan(pattern, memory.MonoModule.Base, (int)memory.MonoModule.MemorySize);
        if (!memory.TryReadRelative(out nuint sTypeInfoDefinitions, sTypeInfoDefinitionsRelative))
        {
            return MonoInitError.STypeInfoDefinitionTableNotResolved;
        }

        return sTypeInfoDefinitions;
    }
}
