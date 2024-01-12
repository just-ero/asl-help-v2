using System.Collections.Generic;

using AslHelp.Memory.Scanning;

namespace AslHelp.Memory.Ipc;

public interface IMemoryScanner
{
    nuint Scan(ScanPattern pattern, nuint startAddress, nuint endAddress);
    nuint Scan(ScanPattern pattern, nuint startAddress, int size);

    IEnumerable<nuint> ScanAll(ScanPattern pattern, nuint startAddress, nuint endAddress);
    IEnumerable<nuint> ScanAll(ScanPattern pattern, nuint startAddress, int size);
}
