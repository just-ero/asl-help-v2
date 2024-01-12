using System;
using System.Diagnostics.CodeAnalysis;

namespace AslHelp.Memory.Ipc;

public interface IMemoryReader
{
    nuint Deref(uint baseOffset, params int[] offsets);
    nuint Deref(string moduleName, uint baseOffset, params int[] offsets);
    nuint Deref(Module module, uint baseOffset, params int[] offsets);
    nuint Deref(nuint baseAddress, params int[] offsets);

    bool TryDeref(out nuint result, uint baseOffset, params int[] offsets);
    bool TryDeref(out nuint result, [NotNullWhen(true)] string? moduleName, uint baseOffset, params int[] offsets);
    bool TryDeref(out nuint result, [NotNullWhen(true)] Module? module, uint baseOffset, params int[] offsets);
    bool TryDeref(out nuint result, nuint baseAddress, params int[] offsets);

    bool TryRead<T>(out T result, nuint baseAddress, params int[] offsets) where T : unmanaged;

    bool TryReadSpan<T>(Span<T> buffer, nuint baseAddress, params int[] offsets) where T : unmanaged;

    bool TryReadString([NotNullWhen(true)] out string? result, int maxLength, StringType stringType, nuint baseAddress, params int[] offsets);
}
