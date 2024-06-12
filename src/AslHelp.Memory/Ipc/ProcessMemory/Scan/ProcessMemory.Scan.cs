using System.Diagnostics.CodeAnalysis;
using System.Linq;

using AslHelp.Memory.Scanning;

namespace AslHelp.Memory.Ipc;

public partial class ProcessMemory
{
    public nuint Scan(ScanPattern pattern)
    {
        return ScanAll(pattern).First();
    }

    public nuint Scan(ScanPattern pattern, int size)
    {
        return ScanAll(pattern, size).First();
    }

    public nuint Scan(ScanPattern pattern, [NotNull] string? moduleName)
    {
        return ScanAll(pattern, moduleName).First();
    }

    public nuint Scan(ScanPattern pattern, [NotNull] string? moduleName, int size)
    {
        return ScanAll(pattern, moduleName, size).First();
    }

    public nuint Scan(ScanPattern pattern, [NotNull] Module? module)
    {
        return ScanAll(pattern, module).First();
    }

    public nuint Scan(ScanPattern pattern, [NotNull] Module? module, int size)
    {
        return ScanAll(pattern, module, size).First();
    }

    public nuint Scan(ScanPattern pattern, nuint startAddress, nuint endAddress)
    {
        return ScanAll(pattern, startAddress, endAddress).First();
    }

    public nuint Scan(ScanPattern pattern, nuint startAddress, int size)
    {
        return ScanAll(pattern, startAddress, size).First();
    }

    public nuint Scan(ScanPattern pattern, nuint startAddress, byte[] memory)
    {
        return ScanAll(pattern, startAddress, memory).First();
    }
}
