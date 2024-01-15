using System.Collections.Generic;

using AslHelp.Common.Results;
using AslHelp.Memory.Scanning;

namespace AslHelp.Memory.Ipc;

public interface IMemoryScanner
{
    Result<nuint> Scan(ScanPattern pattern, int alignment = 1);
    Result<nuint> Scan(ScanPattern pattern, int size, int alignment = 1);
    Result<nuint> Scan(ScanPattern pattern, string? moduleName, int alignment = 1);
    Result<nuint> Scan(ScanPattern pattern, string? moduleName, int size, int alignment = 1);
    Result<nuint> Scan(ScanPattern pattern, Module? module, int alignment = 1);
    Result<nuint> Scan(ScanPattern pattern, Module? module, int size, int alignment = 1);

    Result<nuint> Scan(ScanPattern pattern, nuint startAddress, nuint endAddress, int alignment = 1);
    Result<nuint> Scan(ScanPattern pattern, nuint startAddress, int size, int alignment = 1);
    Result<nuint> Scan(ScanPattern pattern, nuint startAddress, byte[] memory, int alignment = 1);

    Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, int alignment = 1);
    Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, int size, int alignment = 1);
    Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, string? moduleName, int alignment = 1);
    Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, string? moduleName, int size, int alignment = 1);
    Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, Module? module, int alignment = 1);
    Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, Module? module, int size, int alignment = 1);

    Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, nuint startAddress, nuint endAddress, int alignment = 1);
    Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, nuint startAddress, int size, int alignment = 1);
    Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, nuint startAddress, byte[] memory, int alignment = 1);
}
