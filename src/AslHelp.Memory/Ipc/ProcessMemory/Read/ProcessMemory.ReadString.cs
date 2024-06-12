using System;
using System.Buffers;
using System.Runtime.InteropServices;

using AslHelp.Collections.Extensions;
using AslHelp.Common.Results;
using AslHelp.Memory.Errors;

namespace AslHelp.Memory.Ipc;

public partial class ProcessMemory
{
    public Result<string> ReadString(int maxLength, StringType stringType, int baseOffset, params int[] offsets)
    {
        return ReadString(maxLength, stringType, MainModule, baseOffset, offsets);
    }

    public Result<string> ReadString(int maxLength, StringType stringType, string? moduleName, int baseOffset, params int[] offsets)
    {
        if (moduleName is null)
        {
            return IpcError.ModuleNameNull;
        }

        if (!Modules.TryGetValue(moduleName, out Module? module))
        {
            return IpcError.ModuleNotFound(moduleName);
        }

        return ReadString(maxLength, stringType, module, baseOffset, offsets);
    }

    public Result<string> ReadString(int maxLength, StringType stringType, Module? module, int baseOffset, params int[] offsets)
    {
        if (module is null)
        {
            return IpcError.ModuleNull;
        }

        return ReadString(maxLength, stringType, module.Base + (nuint)baseOffset, offsets);
    }

    public Result<string> ReadString(int maxLength, StringType stringType, nuint baseAddress, params int[] offsets)
    {
        if (maxLength < 0)
        {
            return IpcError.ReadStringMaxLengthNegative;
        }

        if (maxLength == 0)
        {
            return "";
        }

        return Deref(baseAddress, offsets)
            .AndThen(deref => stringType switch
            {
                StringType.Ansi => ReadAnsiString(maxLength, deref),
                StringType.Unicode => ReadUnicodeString(maxLength, deref),
                _ => ReadAutoString(maxLength, deref)
            });
    }

    private unsafe Result<string> ReadAnsiString(int maxLength, nuint stringStart)
    {
        sbyte[]? rented = null;
        Span<sbyte> buffer = maxLength <= 1024
            ? stackalloc sbyte[1024]
            : (rented = ArrayPool<sbyte>.Shared.Rent(maxLength));

        if (ReadArray(buffer, stringStart)
            .TryUnwrapErr(out var err))
        {
            ArrayPool<sbyte>.Shared.ReturnIfNotNull(rented);

            return Result<string>.Err(err);
        }

        string result = GetStringFromSByteSpan(buffer, maxLength);

        ArrayPool<sbyte>.Shared.ReturnIfNotNull(rented);

        return result;
    }

    private unsafe Result<string> ReadUnicodeString(int maxLength, nuint stringStart)
    {
        char[]? rented = null;
        Span<char> buffer = maxLength <= 512
            ? stackalloc char[512]
            : (rented = ArrayPool<char>.Shared.Rent(maxLength));

        if (ReadArray(buffer, stringStart)
            .TryUnwrapErr(out var err))
        {
            ArrayPool<char>.Shared.ReturnIfNotNull(rented);

            return Result<string>.Err(err);
        }

        string result = GetStringFromCharSpan(buffer, maxLength);

        ArrayPool<char>.Shared.ReturnIfNotNull(rented);

        return result;
    }

    private unsafe Result<string> ReadAutoString(int maxLength, nuint stringStart)
    {
        // Assume unicode for the worst-case scenario and just allocate maxLength * 2.
        byte[]? rented = null;
        Span<byte> buffer = maxLength * 2 <= 1024
            ? stackalloc byte[1024]
            : (rented = ArrayPool<byte>.Shared.Rent(maxLength * 2));

        if (ReadArray(buffer, stringStart)
            .TryUnwrapErr(out var err))
        {
            ArrayPool<byte>.Shared.ReturnIfNotNull(rented);

            return Result<string>.Err(err);
        }

        string result;
        if (maxLength >= 2 && buffer is [> 0, 0, > 0, 0, ..]) // Best assumption we can make.
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

        return result;
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
