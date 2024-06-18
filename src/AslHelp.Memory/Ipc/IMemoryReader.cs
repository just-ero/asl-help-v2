using System;
using System.Diagnostics.CodeAnalysis;

namespace AslHelp.Memory.Ipc;

public interface IMemoryReader
{
    nuint Deref(int baseOffset, params ReadOnlySpan<int> offsets);
    nuint Deref([NotNull] string? moduleName, int baseOffset, params ReadOnlySpan<int> offsets);
    nuint Deref([NotNull] Module? module, int baseOffset, params ReadOnlySpan<int> offsets);
    nuint Deref(nuint baseAddress, params ReadOnlySpan<int> offsets);

    T Read<T>(int baseOffset, params ReadOnlySpan<int> offsets) where T : unmanaged;
    T Read<T>([NotNull] string? moduleName, int baseOffset, params ReadOnlySpan<int> offsets) where T : unmanaged;
    T Read<T>([NotNull] Module? module, int baseOffset, params ReadOnlySpan<int> offsets) where T : unmanaged;
    T Read<T>(nuint baseAddress, params ReadOnlySpan<int> offsets) where T : unmanaged;

    T[] ReadArray<T>(int length, int baseOffset, params ReadOnlySpan<int> offsets) where T : unmanaged;
    T[] ReadArray<T>(int length, [NotNull] string? moduleName, int baseOffset, params ReadOnlySpan<int> offsets) where T : unmanaged;
    T[] ReadArray<T>(int length, [NotNull] Module? module, int baseOffset, params ReadOnlySpan<int> offsets) where T : unmanaged;
    T[] ReadArray<T>(int length, nuint baseAddress, params ReadOnlySpan<int> offsets) where T : unmanaged;

    void ReadArray<T>(Span<T> buffer, int baseOffset, params ReadOnlySpan<int> offsets) where T : unmanaged;
    void ReadArray<T>(Span<T> buffer, [NotNull] string? moduleName, int baseOffset, params ReadOnlySpan<int> offsets) where T : unmanaged;
    void ReadArray<T>(Span<T> buffer, [NotNull] Module? module, int baseOffset, params ReadOnlySpan<int> offsets) where T : unmanaged;
    void ReadArray<T>(Span<T> buffer, nuint baseAddress, params ReadOnlySpan<int> offsets) where T : unmanaged;

    string ReadString(int maxLength, StringType stringType, int baseOffset, params ReadOnlySpan<int> offsets);
    string ReadString(int maxLength, StringType stringType, [NotNull] string? moduleName, int baseOffset, params ReadOnlySpan<int> offsets);
    string ReadString(int maxLength, StringType stringType, [NotNull] Module? module, int baseOffset, params ReadOnlySpan<int> offsets);
    string ReadString(int maxLength, StringType stringType, nuint baseAddress, params ReadOnlySpan<int> offsets);
}
