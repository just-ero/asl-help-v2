using System;
using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

using AslHelp.Collections.Extensions;
using AslHelp.Common;

namespace AslHelp.Memory.Ipc;

public partial class ProcessMemory
{
    public string ReadString(int maxLength, StringType stringType, int baseOffset, params int[] offsets)
    {
        return ReadString(maxLength, stringType, MainModule, baseOffset, offsets);
    }

    public string ReadString(
        int maxLength,
        StringType stringType,
        [NotNull] string? moduleName,
        int baseOffset,
        params int[] offsets)
    {
        ThrowHelper.ThrowIfNull(moduleName);

        return ReadString(maxLength, stringType, Modules[moduleName], baseOffset, offsets);
    }

    public string ReadString(
        int maxLength,
        StringType stringType,
        [NotNull] Module? module,
        int baseOffset,
        params int[] offsets)
    {
        ThrowHelper.ThrowIfNull(module);

        return ReadString(maxLength, stringType, module.Base + (nuint)baseOffset, offsets);
    }

    public string ReadString(int maxLength, StringType stringType, nuint baseAddress, params int[] offsets)
    {
        if (maxLength < 0)
        {
            const string Msg = "The maximum string length must not be a negative integer.";
            ThrowHelper.ThrowArgumentOutOfRangeException(nameof(maxLength), Msg);
        }

        if (maxLength == 0)
        {
            return "";
        }

        return stringType switch
        {
            StringType.Utf8 => ReadUtf8String(maxLength, baseAddress, offsets),
            StringType.Utf16 => ReadUtf16String(maxLength, baseAddress, offsets),
            _ => ReadAutoString(maxLength, baseAddress, offsets)
        };
    }

    private unsafe string ReadUtf8String(int maxLength, nuint baseAddress, int[] offsets)
    {
        sbyte[]? rented = null;
        Span<sbyte> buffer = maxLength <= 1024
            ? stackalloc sbyte[1024]
            : (rented = ArrayPool<sbyte>.Shared.Rent(maxLength));

        ReadArray(buffer[..maxLength], baseAddress, offsets);

        string result = GetStringFromSByteSpan(buffer[..maxLength]);

        ArrayPool<sbyte>.Shared.ReturnIfNotNull(rented);

        return result;
    }

    private unsafe string ReadUtf16String(int maxLength, nuint baseAddress, int[] offsets)
    {
        char[]? rented = null;
        Span<char> buffer = maxLength <= 512
            ? stackalloc char[512]
            : (rented = ArrayPool<char>.Shared.Rent(maxLength));

        ReadArray(buffer[..maxLength], baseAddress, offsets);

        string result = GetStringFromCharSpan(buffer[..maxLength]);

        ArrayPool<char>.Shared.ReturnIfNotNull(rented);

        return result;
    }

    private unsafe string ReadAutoString(int maxLength, nuint baseAddress, int[] offsets)
    {
        // Assume unicode for the worst-case scenario and just allocate maxLength * 2.
        byte[]? rented = null;
        Span<byte> buffer = maxLength * 2 <= 1024
            ? stackalloc byte[1024]
            : (rented = ArrayPool<byte>.Shared.Rent(maxLength * 2));

        ReadArray(buffer[..(maxLength * 2)], baseAddress, offsets);

        string result;
        if (maxLength >= 2 && buffer is [> 0, 0, > 0, 0, ..]) // Best assumption we can make.
        {
            Span<char> charBuffer = MemoryMarshal.Cast<byte, char>(buffer);
            result = GetStringFromCharSpan(charBuffer[..maxLength]);
        }
        else
        {
            Span<sbyte> sbyteBuffer = MemoryMarshal.Cast<byte, sbyte>(buffer);
            result = GetStringFromSByteSpan(sbyteBuffer[..maxLength]);
        }

        ArrayPool<byte>.Shared.ReturnIfNotNull(rented);

        return result;
    }

    private static string GetStringFromCharSpan(Span<char> buffer)
    {
        int length = buffer.IndexOf('\0');
        if (length != -1)
        {
            return buffer[..length].ToString();
        }
        else
        {
            return buffer.ToString();
        }
    }

    private static unsafe string GetStringFromSByteSpan(Span<sbyte> buffer)
    {
        int length = buffer.IndexOf((sbyte)'\0');
        if (length != -1)
        {
            fixed (sbyte* pBuffer = buffer)
            {
                return new(pBuffer, 0, length);
            }
        }
        else
        {
            fixed (sbyte* pBuffer = buffer)
            {
                return new(pBuffer, 0, buffer.Length);
            }
        }
    }
}
