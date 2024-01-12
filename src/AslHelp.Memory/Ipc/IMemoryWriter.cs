using System;

namespace AslHelp.Memory.Ipc;

public interface IMemoryWriter
{
    bool Write<T>(T value, nuint baseAddress, params int[] offsets) where T : unmanaged;

    bool WriteSpan<T>(ReadOnlySpan<T> values, nuint baseAddress, params int[] offsets) where T : unmanaged;
}
