using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using AslHelp.Common.Results;
using AslHelp.Memory.Scanning;

namespace AslHelp.Memory.Ipc;

public interface IMemoryScanner
{
    Result<nuint> Scan(ScanPattern pattern);
    Result<nuint> Scan(ScanPattern pattern, int size);
    Result<nuint> Scan(ScanPattern pattern, string? moduleName);
    Result<nuint> Scan(ScanPattern pattern, string? moduleName, int size);
    Result<nuint> Scan(ScanPattern pattern, Module? module);
    Result<nuint> Scan(ScanPattern pattern, Module? module, int size);

    Result<nuint> Scan(ScanPattern pattern, nuint startAddress, nuint endAddress);
    Result<nuint> Scan(ScanPattern pattern, nuint startAddress, int size);
    Result<nuint> Scan(ScanPattern pattern, nuint startAddress, byte[] memory);

    Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern);
    Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, int size);
    Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, string? moduleName);
    Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, string? moduleName, int size);
    Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, Module? module);
    Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, Module? module, int size);

    Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, nuint startAddress, nuint endAddress);
    Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, nuint startAddress, int size);
    Result<IEnumerable<nuint>> ScanAll(ScanPattern pattern, nuint startAddress, byte[] memory);
}
