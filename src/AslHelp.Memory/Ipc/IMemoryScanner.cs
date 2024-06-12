using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using AslHelp.Memory.Scanning;

namespace AslHelp.Memory.Ipc;

public interface IMemoryScanner
{
    nuint Scan(ScanPattern pattern);
    nuint Scan(ScanPattern pattern, int size);
    nuint Scan(ScanPattern pattern, [NotNull] string? moduleName);
    nuint Scan(ScanPattern pattern, [NotNull] string? moduleName, int size);
    nuint Scan(ScanPattern pattern, [NotNull] Module? module);
    nuint Scan(ScanPattern pattern, [NotNull] Module? module, int size);

    nuint Scan(ScanPattern pattern, nuint startAddress, nuint endAddress);
    nuint Scan(ScanPattern pattern, nuint startAddress, int size);
    nuint Scan(ScanPattern pattern, nuint startAddress, byte[] memory);

    IEnumerable<nuint> ScanAll(ScanPattern pattern);
    IEnumerable<nuint> ScanAll(ScanPattern pattern, int size);
    IEnumerable<nuint> ScanAll(ScanPattern pattern, [NotNull] string? moduleName);
    IEnumerable<nuint> ScanAll(ScanPattern pattern, [NotNull] string? moduleName, int size);
    IEnumerable<nuint> ScanAll(ScanPattern pattern, [NotNull] Module? module);
    IEnumerable<nuint> ScanAll(ScanPattern pattern, [NotNull] Module? module, int size);

    IEnumerable<nuint> ScanAll(ScanPattern pattern, nuint startAddress, nuint endAddress);
    IEnumerable<nuint> ScanAll(ScanPattern pattern, nuint startAddress, int size);
    IEnumerable<nuint> ScanAll(ScanPattern pattern, nuint startAddress, byte[] memory);
}
