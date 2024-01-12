using System;
using System.Buffers;
using System.Diagnostics.CodeAnalysis;

using AslHelp.Collections.Extensions;

namespace AslHelp.Unity.Memory.Ipc;

internal partial class MonoProcessMemory
{
    public bool TryReadString([NotNullWhen(true)] out string? result, nuint address, params int[] offsets)
    {
        result = default;

        if (!TryRead(out nuint str, address, offsets))
        {
            return false;
        }

        if (!TryRead(out int length, str + (PointerSize * 2U)))
        {
            return false;
        }

        char[]? rented = null;
        Span<char> chars = length <= 512
            ? stackalloc char[length]
            : (rented = ArrayPool<char>.Shared.Rent(length));

        if (!TryReadSpan(chars, str + (PointerSize * 2U) + sizeof(int)))
        {
            ArrayPool<char>.Shared.ReturnIfNotNull(rented);

            return false;
        }

        result = chars.ToString();

        ArrayPool<char>.Shared.ReturnIfNotNull(rented);

        return true;
    }
}
