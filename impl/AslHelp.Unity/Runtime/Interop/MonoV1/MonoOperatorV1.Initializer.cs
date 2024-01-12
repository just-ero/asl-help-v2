using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

using AslHelp.Common.Results;
using AslHelp.Memory.Scanning;
using AslHelp.Memory.StructReflection;
using AslHelp.Unity.Memory.Ipc;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class MonoOperatorV1
{
    public new class Initializer : MonoOperator.Initializer
    {
        public override Result<Reflection> GetStructs(IMonoProcessMemory memory)
        {
            const string Namespace = "AslHelp.Unity.Runtime.Structs";
            const string Runtime = "mono";
            const string Version = "1.0";

            return Reflection.Initialize(memory.Is64Bit, (Namespace, Runtime, Version));
        }

        public override Result<MonoDefaults> GetDefaults(IMonoProcessMemory memory)
        {
            if (!memory.MonoModule.Symbols.TryGetValue("mono_get_corlib", out var symMonoGetCorLib)
                || symMonoGetCorLib.Address == 0)
            {
                return MonoInitError.SymbolMonoGetCorlibNotFound;
            }

            ScanPattern pattern = memory.Is64Bit
                ? new(3, "48 8B 05")
                : new(1, "A1");

            nuint monoDefaultsRelative = memory.Scan(pattern, symMonoGetCorLib.Address, 0x10);
            if (!memory.TryReadRelative(out nuint monoDefaults, monoDefaultsRelative))
            {
                return MonoInitError.MonoDefaultsNotResolved;
            }

            Span<nuint> defaults = stackalloc nuint[18];
            if (!memory.TryReadSpan(defaults, monoDefaults))
            {
                return MonoInitError.MonoDefaultsReadFailed;
            }

            return Unsafe.As<nuint, MonoDefaults>(ref defaults[0]);
        }

        public override Result<nuint> GetAssemblies(IMonoProcessMemory memory)
        {
            if (!memory.MonoModule.Symbols.TryGetValue("mono_assembly_foreach", out var symMonoAssemblyForeach)
                || symMonoAssemblyForeach.Address == 0)
            {
                return MonoInitError.SymbolMonoAssemblyForeachNotFound;
            }

            ScanPattern pattern = memory.Is64Bit
                ? new(3, "48 8B 0D")
                : new(-4, "85 f6");

            nuint loadedAssembliesRelative = memory.Scan(pattern, symMonoAssemblyForeach.Address, 0x100);
            if (!memory.TryReadRelative(out nuint loadedAssemblies, loadedAssembliesRelative))
            {
                return MonoInitError.LoadedAssembliesNotResolved;
            }

            return loadedAssemblies;
        }
    }
}
