using System.Collections.Generic;
using System.Linq;

using AslHelp.Common;
using AslHelp.Common.Results;
using AslHelp.Memory.Errors;
using AslHelp.Memory.Scanning;

namespace AslHelp.Memory.Ipc;

public partial class ProcessMemory
{
    public Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern)
    {
        return ScanAll(pattern, MainModule);
    }

    public Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, int size)
    {
        return ScanAll(pattern, MainModule, size);
    }

    public Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, string? moduleName)
    {
        if (moduleName is null)
        {
            return IpcError.ModuleNameNull;
        }

        if (!Modules.TryGetValue(moduleName, out Module? module))
        {
            return IpcError.ModuleNotFound(moduleName);
        }

        return ScanAll(pattern, module);
    }

    public Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, string? moduleName, int size)
    {
        if (moduleName is null)
        {
            return IpcError.ModuleNameNull;
        }

        if (!Modules.TryGetValue(moduleName, out Module? module))
        {
            return IpcError.ModuleNotFound(moduleName);
        }

        return ScanAll(pattern, module, size);
    }

    public Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, Module? module)
    {
        if (module is null)
        {
            return IpcError.ModuleNull;
        }

        return ScanAll(pattern, module.Base, (int)module.MemorySize);
    }

    public Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, Module? module, int size)
    {
        if (module is null)
        {
            return IpcError.ModuleNull;
        }

        return ScanAll(pattern, module.Base, size);
    }

    public Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, nuint startAddress, nuint endAddress)
    {
        if (endAddress < startAddress)
        {
            return IpcError.ScanRegionEndLessThanRegionStart;
        }

        return ScanAll(pattern, startAddress, (int)(endAddress - startAddress));
    }

    public Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, nuint startAddress, int size)
    {
        if (size < 0)
        {
            return IpcError.ScanRegionSizeNegative;
        }

        return ReadArray<byte>(size, startAddress)
            .AndThen(memory => ScanAll(pattern, startAddress, memory));
    }

    public Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, nuint startAddress, byte[] memory)
    {
        ScanEnumerator scanner = new(pattern, memory);

        if (!scanner.MoveNext())
        {
            return IpcError.ScanNoMatch;
        }

        return Result<IEnumerable<nuint>>
            .Ok(ScanAll(scanner, startAddress + (nuint)pattern.Offset));
    }

    private IEnumerable<nuint> ScanAll(ScanEnumerator scanner, nuint startAddress)
    {
        do
        {
            yield return startAddress + scanner.Current;
        } while (scanner.MoveNext());
    }
}
