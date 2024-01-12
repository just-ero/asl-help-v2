using System;
using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

using AslHelp.Collections.Extensions;

namespace AslHelp.Memory.Ipc;

public partial class ProcessMemory
{
    public bool TryReadString(
        [NotNullWhen(true)] out string? result,
        int maxLength,
        StringType stringType,
        nuint baseAddress,
        params int[] offsets)
    {
        result = default;

        if (maxLength < 0)
        {
            return false;
        }

        if (maxLength == 0)
        {
            result = "";
            return true;
        }

        return TryDeref(out nuint deref, baseAddress, offsets)
            && stringType switch
            {
                StringType.Ansi => ReadAnsiString(out result, maxLength, deref),
                StringType.Unicode => ReadUnicodeString(out result, maxLength, deref),
                _ => ReadAutoString(out result, maxLength, deref)
            };
    }

    private unsafe bool ReadAnsiString([NotNullWhen(true)] out string? result, int maxLength, nuint stringStart)
    {
        sbyte[]? rented = null;
        Span<sbyte> buffer = maxLength <= 1024
            ? stackalloc sbyte[1024]
            : (rented = ArrayPool<sbyte>.Shared.Rent(maxLength));

        if (!TryReadSpan(buffer, stringStart))
        {
            ArrayPool<sbyte>.Shared.ReturnIfNotNull(rented);

            result = default;
            return false;
        }

        result = GetStringFromSByteSpan(buffer, maxLength);

        ArrayPool<sbyte>.Shared.ReturnIfNotNull(rented);

        return true;
    }

    private unsafe bool ReadUnicodeString([NotNullWhen(true)] out string? result, int maxLength, nuint stringStart)
    {
        char[]? rented = null;
        Span<char> buffer = maxLength <= 512
            ? stackalloc char[512]
            : (rented = ArrayPool<char>.Shared.Rent(maxLength));

        if (!TryReadSpan(buffer, stringStart))
        {
            ArrayPool<char>.Shared.ReturnIfNotNull(rented);

            result = default;
            return false;
        }

        result = GetStringFromCharSpan(buffer, maxLength);

        ArrayPool<char>.Shared.ReturnIfNotNull(rented);

        return true;
    }

    private unsafe bool ReadAutoString([NotNullWhen(true)] out string? result, int maxLength, nuint stringStart)
    {
        // Assume unicode for the worst-case scenario and just allocate maxLength * 2.
        byte[]? rented = null;
        Span<byte> buffer = maxLength * 2 <= 1024
            ? stackalloc byte[1024]
            : (rented = ArrayPool<byte>.Shared.Rent(maxLength * 2));

        if (!TryReadSpan(buffer, stringStart))
        {
            ArrayPool<byte>.Shared.ReturnIfNotNull(rented);

            result = default;
            return false;
        }

        if (maxLength >= 2 && buffer[1] == (byte)'\0') // Bold assumption. It's the best guess we can make.
        {
            Span<char> charBuffer = MemoryMarshal.Cast<byte, char>(buffer);
            result = GetStringFromCharSpan(charBuffer, maxLength);
        }
        else
        {
            Span<sbyte> sbyteBuffer = MemoryMarshal.Cast<byte, sbyte>(buffer);
            result = GetStringFromSByteSpan(sbyteBuffer, maxLength);
        }

        ArrayPool<byte>.Shared.ReturnIfNotNull(rented);

        return true;
    }

    private static string GetStringFromCharSpan(Span<char> buffer, int maxLength)
    {
        int length = buffer.IndexOf('\0');
        if (length == -1)
        {
            length = maxLength;
        }

        return buffer[..length].ToString();
    }

    private static unsafe string GetStringFromSByteSpan(Span<sbyte> buffer, int maxLength)
    {
        int length = buffer.IndexOf((sbyte)'\0');
        if (length == -1)
        {
            length = maxLength;
        }

        fixed (sbyte* pBuffer = buffer)
        {
            return new(pBuffer, 0, length);
        }
    }
}
