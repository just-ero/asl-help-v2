using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using AslHelp.Common;
using AslHelp.Memory.Scanning;

namespace AslHelp.Memory.Ipc;

public partial class ProcessMemory
{
    public IEnumerable<nuint> ScanAll(ScanPattern pattern)
    {
        return ScanAll(pattern, MainModule);
    }

    public IEnumerable<nuint> ScanAll(ScanPattern pattern, int size)
    {
        return ScanAll(pattern, MainModule, size);
    }

    public IEnumerable<nuint> ScanAll(ScanPattern pattern, [NotNull] string? moduleName)
    {
        ThrowHelper.ThrowIfNull(moduleName);

        return ScanAll(pattern, Modules[moduleName]);
    }

    public IEnumerable<nuint> ScanAll(ScanPattern pattern, [NotNull] string? moduleName, int size)
    {
        ThrowHelper.ThrowIfNull(moduleName);

        return ScanAll(pattern, Modules[moduleName], size);
    }

    public IEnumerable<nuint> ScanAll(ScanPattern pattern, [NotNull] Module? module)
    {
        ThrowHelper.ThrowIfNull(module);

        return ScanAll(pattern, module.Base, (int)module.MemorySize);
    }

    public IEnumerable<nuint> ScanAll(ScanPattern pattern, [NotNull] Module? module, int size)
    {
        ThrowHelper.ThrowIfNull(module);

        return ScanAll(pattern, module.Base, size);
    }

    public IEnumerable<nuint> ScanAll(ScanPattern pattern, nuint startAddress, nuint endAddress)
    {
        if (endAddress < startAddress)
        {
            const string Msg = "The pattern scan region end address must be greater than the start address.";
            ThrowHelper.ThrowArgumentOutOfRangeException(nameof(endAddress), Msg);
        }

        return ScanAll(pattern, startAddress, (int)(endAddress - startAddress));
    }

    public IEnumerable<nuint> ScanAll(ScanPattern pattern, nuint startAddress, int size)
    {
        if (size < 0)
        {
            const string Msg = "The pattern scan region size must be a positive integer.";
            ThrowHelper.ThrowArgumentOutOfRangeException(nameof(size), Msg);
        }

        byte[] memory = ReadArray<byte>(size, startAddress);
        return ScanAll(pattern, startAddress, memory);
    }

    public IEnumerable<nuint> ScanAll(ScanPattern pattern, nuint startAddress, byte[] memory)
    {
        ScanEnumerator scanner = new(pattern, memory);

        foreach (uint scanOffset in scanner)
        {
            yield return startAddress + scanOffset + (nuint)pattern.Offset;
        }
    }
}
