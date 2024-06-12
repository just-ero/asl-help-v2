using System.Linq;

using AslHelp.Common.Results;
using AslHelp.Memory.Scanning;

namespace AslHelp.Memory.Ipc;

public partial class ProcessMemory
{
    public Result<nuint> Scan(ScanPattern pattern)
    {
        return ScanAll(pattern)
            .Map(results => results.First());
    }

    public Result<nuint> Scan(ScanPattern pattern, int size)
    {
        return ScanAll(pattern, size)
            .Map(results => results.First());
    }

    public Result<nuint> Scan(ScanPattern pattern, string? moduleName)
    {
        return ScanAll(pattern, moduleName)
            .Map(results => results.First());
    }

    public Result<nuint> Scan(ScanPattern pattern, string? moduleName, int size)
    {
        return ScanAll(pattern, moduleName, size)
            .Map(results => results.First());
    }

    public Result<nuint> Scan(ScanPattern pattern, Module? module)
    {
        return ScanAll(pattern, module)
            .Map(results => results.First());
    }

    public Result<nuint> Scan(ScanPattern pattern, Module? module, int size)
    {
        return ScanAll(pattern, module, size)
            .Map(results => results.First());
    }

    public Result<nuint> Scan(ScanPattern pattern, nuint startAddress, nuint endAddress)
    {
        return ScanAll(pattern, startAddress, endAddress)
            .Map(results => results.First());
    }

    public Result<nuint> Scan(ScanPattern pattern, nuint startAddress, int size)
    {
        return ScanAll(pattern, startAddress, size)
            .Map(results => results.First());
    }

    public Result<nuint> Scan(ScanPattern pattern, nuint startAddress, byte[] memory)
    {
        return ScanAll(pattern, startAddress, memory)
            .Map(results => results.First());
    }
}
