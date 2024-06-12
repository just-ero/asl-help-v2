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

    public string ReadString(int maxLength, StringType stringType, [NotNull] string? moduleName, int baseOffset, params int[] offsets)
    {
        ThrowHelper.ThrowIfNull(moduleName);

        return ReadString(maxLength, stringType, Modules[moduleName], baseOffset, offsets);
    }

    public string ReadString(int maxLength, StringType stringType, [NotNull] Module? module, int baseOffset, params int[] offsets)
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

        nuint deref = Deref(baseAddress, offsets);
        return stringType switch
        {
            StringType.Ansi => ReadAnsiString(maxLength, deref),
            StringType.Unicode => ReadUnicodeString(maxLength, deref),
            _ => ReadAutoString(maxLength, deref)
        };
    }

    private unsafe string ReadAnsiString(int maxLength, nuint stringStart)
    {
        sbyte[]? rented = null;
        Span<sbyte> buffer = maxLength <= 1024
            ? stackalloc sbyte[1024]
            : (rented = ArrayPool<sbyte>.Shared.Rent(maxLength));

        try
        {
            ReadArray(buffer, stringStart);

            return GetStringFromSByteSpan(buffer, maxLength);
        }
        finally
        {
            ArrayPool<sbyte>.Shared.ReturnIfNotNull(rented);
        }
    }

    private unsafe string ReadUnicodeString(int maxLength, nuint stringStart)
    {
        char[]? rented = null;
        Span<char> buffer = maxLength <= 512
            ? stackalloc char[512]
            : (rented = ArrayPool<char>.Shared.Rent(maxLength));

        try
        {
            ReadArray(buffer, stringStart);

            return GetStringFromCharSpan(buffer, maxLength);
        }
        finally
        {
            ArrayPool<char>.Shared.ReturnIfNotNull(rented);
        }
    }

    private unsafe string ReadAutoString(int maxLength, nuint stringStart)
    {
        // Assume unicode for the worst-case scenario and just allocate maxLength * 2.
        byte[]? rented = null;
        Span<byte> buffer = maxLength * 2 <= 1024
            ? stackalloc byte[1024]
            : (rented = ArrayPool<byte>.Shared.Rent(maxLength * 2));

        try
        {
            ReadArray(buffer, stringStart);

            if (maxLength >= 2 && buffer is [> 0, 0, > 0, 0, ..]) // Best assumption we can make.
            {
                Span<char> charBuffer = MemoryMarshal.Cast<byte, char>(buffer);
                return GetStringFromCharSpan(charBuffer, maxLength);
            }
            else
            {
                Span<sbyte> sbyteBuffer = MemoryMarshal.Cast<byte, sbyte>(buffer);
                return GetStringFromSByteSpan(sbyteBuffer, maxLength);
            }
        }
        finally
        {
            ArrayPool<byte>.Shared.ReturnIfNotNull(rented);
        }
    }

    private static string GetStringFromCharSpan(Span<char> buffer, int maxLength)
    {
        int length = buffer.IndexOf('\0');
        if (length == -1)
        {
            maxLength = length;
        }

        return buffer[..maxLength].ToString();
    }

    private static unsafe string GetStringFromSByteSpan(Span<sbyte> buffer, int maxLength)
    {
        int length = buffer.IndexOf((sbyte)'\0');
        if (length == -1)
        {
            maxLength = length;
        }

        fixed (sbyte* pBuffer = buffer)
        {
            return new(pBuffer, 0, maxLength);
        }
    }
}
