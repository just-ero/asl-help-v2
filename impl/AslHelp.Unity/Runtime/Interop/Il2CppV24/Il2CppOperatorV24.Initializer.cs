using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

using AslHelp.Common.Results;
using AslHelp.Memory.Scanning;
using AslHelp.Memory.StructReflection;
using AslHelp.Unity.Memory.Ipc;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class Il2CppOperatorV24
{
    public new class Initializer : Il2CppOperator.Initializer
    {
        public override Result<Reflection> GetStructs(IMonoProcessMemory memory)
        {
            const string Namespace = "AslHelp.Unity.Runtime.Structs";
            const string Runtime = "il2cpp";
            const string Version = "24.0";

            return Reflection.Initialize(memory.Is64Bit, (Namespace, Runtime, Version));
        }

        public override Result<MonoDefaults> GetDefaults(IMonoProcessMemory memory)
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

            nuint il2CppGetCorlibRelative = memory.Scan(callPattern, symIl2CppGetCorlib.Address, 0x10);
            nuint il2CppDefaultsRelative = memory.TryReadRelative(out nuint il2CppGetCorlib, il2CppGetCorlibRelative)
                ? memory.Scan(patternFromIl2CppGetCorlib, il2CppGetCorlib, 0x10)
                : memory.Scan(patternFromIl2CppGetCorlib, symIl2CppGetCorlib.Address, 0x10);

            if (!memory.TryReadRelative(out nuint il2CppDefaults, il2CppDefaultsRelative))
            {
                return MonoInitError.Il2CppDefaultsNotResolved;
            }

            Span<nuint> defaults = stackalloc nuint[18];
            if (!memory.TryReadSpan(defaults, il2CppDefaults))
            {
                return MonoInitError.Il2CppDefaultsReadFailed;
            }

            return Unsafe.As<nuint, MonoDefaults>(ref defaults[0]);
        }

        public override Result<nuint> GetAssemblies(IMonoProcessMemory memory)
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

            nuint getAssembliesRelative = memory.Scan(callPattern, symIl2CppDomainGetAssemblies.Address, 0x20);
            nuint sAssembliesRelative = memory.TryReadRelative(out nuint getAssemblies, getAssembliesRelative)
                ? memory.Scan(patternFromGetAssemblies, getAssemblies, 0x10)
                : memory.Scan(patternFromIl2CppDomainGetAssemblies, symIl2CppDomainGetAssemblies.Address, 0x20);

            if (!memory.TryReadRelative(out nuint sAssemblies, sAssembliesRelative))
            {
                return MonoInitError.SAssembliesNotResolved;
            }

            return sAssemblies;
        }

        public override Result<nuint> GetTypeInfoDefinitions(IMonoProcessMemory memory)
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
}
