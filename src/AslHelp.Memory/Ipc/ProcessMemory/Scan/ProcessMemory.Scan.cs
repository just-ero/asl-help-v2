using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using AslHelp.Memory.Native;
using AslHelp.Memory.Scanning;

namespace AslHelp.Memory.Ipc;

public partial class ProcessMemory
{
    public nuint Scan(ScanPattern pattern, nuint startAddress, nuint endAddress)
    {
        return ScanAll(pattern, startAddress, endAddress).FirstOrDefault();
    }

    public nuint Scan(ScanPattern pattern, nuint startAddress, int size)
    {
        return ScanAll(pattern, startAddress, size).FirstOrDefault();
    }

    public IEnumerable<nuint> ScanAll(ScanPattern pattern, nuint startAddress, nuint endAddress)
    {
        return ScanAll(pattern, startAddress, (int)(endAddress - startAddress));
    }

    public IEnumerable<nuint> ScanAll(ScanPattern pattern, nuint startAddress, int size)
    {
        if (size < 0)
        {
            yield break;
        }

        byte[] memory = new byte[size];
        if (!TryReadSpan<byte>(memory, startAddress))
        {
            yield break;
        }

        ScanEnumerator scanner = new(memory, pattern);

        foreach (uint result in scanner)
        {
            yield return startAddress + result + (nuint)pattern.Offset;
        }
    }
}
