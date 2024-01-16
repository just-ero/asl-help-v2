using System.Collections.Generic;

using AslHelp.Common.Extensions;
using AslHelp.Common.Results;
using AslHelp.Memory.Scanning;

namespace AslHelp.Memory.Ipc;

public partial class ProcessMemory
{
    public Result<nuint> Scan(ScanPattern pattern, int alignment = 1)
    {
        return Scan(pattern, MainModule, alignment);
    }

    public Result<nuint> Scan(ScanPattern pattern, int size, int alignment = 1)
    {
        return Scan(pattern, MainModule, size, alignment);
    }

    public Result<nuint> Scan(ScanPattern pattern, string? moduleName, int alignment = 1)
    {
        if (moduleName is null)
        {
            return IpcError.ModuleName_MustNot_BeNull;
        }

        return Scan(pattern, Modules[moduleName], alignment);
    }

    public Result<nuint> Scan(ScanPattern pattern, string? moduleName, int size, int alignment = 1)
    {
        if (moduleName is null)
        {
            return IpcError.ModuleName_MustNot_BeNull;
        }

        return Scan(pattern, Modules[moduleName], size, alignment);
    }

    public Result<nuint> Scan(ScanPattern pattern, Module? module, int alignment = 1)
    {
        if (module is null)
        {
            return IpcError.Module_MustNot_BeNull;
        }

        return Scan(pattern, module.Base, module.MemorySize, alignment);
    }

    public Result<nuint> Scan(ScanPattern pattern, Module? module, int size, int alignment = 1)
    {
        if (module is null)
        {
            return IpcError.Module_MustNot_BeNull;
        }

        return Scan(pattern, module.Base, size, alignment);
    }

    public Result<nuint> Scan(ScanPattern pattern, nuint startAddress, nuint endAddress, int alignment = 1)
    {
        if (startAddress >= endAddress)
        {
            return IpcError.PatternScan_RegionStart_Must_BeLessThan_End;
        }

        return Scan(pattern, startAddress, (int)(endAddress - startAddress), alignment);
    }

    public Result<nuint> Scan(ScanPattern pattern, nuint startAddress, int size, int alignment = 1)
    {
        return
            ScanAll(pattern, startAddress, size, alignment)
            .AndThen<nuint>(results =>
            {
                IEnumerator<nuint> e = results.GetEnumerator();
                if (!e.MoveNext())
                {
                    return IpcError.PatternScanFailure_NoMatches;
                }

                return e.Current;
            });
    }

    public Result<nuint> Scan(ScanPattern pattern, nuint startAddress, byte[] memory, int alignment = 1)
    {
        return
            ScanAll(pattern, startAddress, memory, alignment)
            .AndThen<nuint>(results =>
            {
                IEnumerator<nuint> e = results.GetEnumerator();
                if (!e.MoveNext())
                {
                    return IpcError.PatternScanFailure_NoMatches;
                }

                return e.Current;
            });
    }

    public Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, int alignment = 1)
    {
        return ScanAll(pattern, MainModule, alignment);
    }

    public Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, int size, int alignment = 1)
    {
        return ScanAll(pattern, MainModule, size, alignment);
    }

    public Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, string? moduleName, int alignment = 1)
    {
        if (moduleName is null)
        {
            return IpcError.ModuleName_MustNot_BeNull;
        }

        return ScanAll(pattern, Modules[moduleName], alignment);
    }

    public Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, string? moduleName, int size, int alignment = 1)
    {
        if (moduleName is null)
        {
            return IpcError.ModuleName_MustNot_BeNull;
        }

        return ScanAll(pattern, Modules[moduleName], size, alignment);
    }

    public Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, Module? module, int alignment = 1)
    {
        if (module is null)
        {
            return IpcError.Module_MustNot_BeNull;
        }

        return ScanAll(pattern, module.Base, (int)module.MemorySize, alignment);
    }

    public Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, Module? module, int size, int alignment = 1)
    {
        if (module is null)
        {
            return IpcError.Module_MustNot_BeNull;
        }

        return ScanAll(pattern, module.Base, size, alignment);
    }

    public Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, nuint startAddress, nuint endAddress, int alignment = 1)
    {
        if (startAddress >= endAddress)
        {
            return IpcError.PatternScan_RegionStart_Must_BeLessThan_End;
        }

        return ScanAll(pattern, startAddress, (int)(endAddress - startAddress), alignment);
    }

    public Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, nuint startAddress, int size, int alignment = 1)
    {
        if (size < 0)
        {
            return IpcError.PatternScan_RegionSize_Must_BePositive;
        }

        return
            ReadSpan<byte>(size, startAddress)
            .AndThen(memory => ScanAll(pattern, startAddress, memory, alignment));
    }

    public Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, nuint startAddress, byte[] memory, int alignment = 1)
    {
        if (alignment <= 0)
        {
            return IpcError.PatternScan_Alignment_Must_BePositive;
        }

        return scanAll(pattern, startAddress, memory, alignment).AsOk();

        static IEnumerable<nuint> scanAll(ScanPattern pattern, nuint startAddress, byte[] memory, int alignment)
        {
            ScanEnumerator scanner = new(pattern, memory);

            foreach (uint scanOffset in scanner)
            {
                yield return startAddress + scanOffset + (nuint)pattern.Offset;
            }
        }
    }
}
