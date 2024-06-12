using System;
using System.Diagnostics.CodeAnalysis;

namespace AslHelp.Memory.Ipc;

public interface IMemoryWriter
{
    void Write<T>(T value, int baseOffset, params int[] offsets) where T : unmanaged;
    void Write<T>(T value, [NotNull] string? moduleName, int baseOffset, params int[] offsets) where T : unmanaged;
    void Write<T>(T value, [NotNull] Module? module, int baseOffset, params int[] offsets) where T : unmanaged;
    void Write<T>(T value, nuint baseAddress, params int[] offsets) where T : unmanaged;

    void WriteArray<T>(ReadOnlySpan<T> values, int baseOffset, params int[] offsets) where T : unmanaged;
    void WriteArray<T>(ReadOnlySpan<T> values, [NotNull] string? moduleName, int baseOffset, params int[] offsets) where T : unmanaged;
    void WriteArray<T>(ReadOnlySpan<T> values, [NotNull] Module? module, int baseOffset, params int[] offsets) where T : unmanaged;
    void WriteArray<T>(ReadOnlySpan<T> values, nuint baseAddress, params int[] offsets) where T : unmanaged;
}
