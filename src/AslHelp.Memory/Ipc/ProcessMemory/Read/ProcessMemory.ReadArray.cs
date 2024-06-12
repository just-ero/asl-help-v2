using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

using AslHelp.Common;
using AslHelp.Memory.Native;

namespace AslHelp.Memory.Ipc;

public partial class ProcessMemory
{
    public T[] ReadArray<T>(int length, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        return ReadArray<T>(length, MainModule, baseOffset, offsets);
    }

    public T[] ReadArray<T>(int length, [NotNull] string? moduleName, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        ThrowHelper.ThrowIfNull(moduleName);

        return ReadArray<T>(length, Modules[moduleName], baseOffset, offsets);
    }

    public T[] ReadArray<T>(int length, [NotNull] Module? module, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        ThrowHelper.ThrowIfNull(module);

        return ReadArray<T>(length, module.Base + (nuint)baseOffset, offsets);
    }

    public T[] ReadArray<T>(int length, nuint baseAddress, params int[] offsets)
        where T : unmanaged
    {
        T[] results = new T[length];
        ReadArray<T>(results, baseAddress, offsets);

        return results;
    }

    public void ReadArray<T>(Span<T> buffer, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        ReadArray(buffer, MainModule, baseOffset, offsets);
    }

    public void ReadArray<T>(Span<T> buffer, [NotNull] string? moduleName, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        ThrowHelper.ThrowIfNull(moduleName);

        ReadArray(buffer, Modules[moduleName], baseOffset, offsets);
    }

    public void ReadArray<T>(Span<T> buffer, [NotNull] Module? module, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        ThrowHelper.ThrowIfNull(module);

        ReadArray(buffer, module.Base + (nuint)baseOffset, offsets);
    }

    public unsafe void ReadArray<T>(Span<T> buffer, nuint baseAddress, params int[] offsets)
        where T : unmanaged
    {
        if (buffer.Length == 0)
        {
            return;
        }

        if (!Is64Bit && IsNativeInt<T>())
        {
            // Need to read 32-bit integers for the pointers and then copy.

            Span<uint> buf32 = MemoryMarshal.Cast<T, uint>(buffer);
            Span<ulong> buf64 = MemoryMarshal.Cast<T, ulong>(buffer);

            ReadArray(buf32[buf64.Length..], baseAddress, offsets);

            for (int i = 0; i < buf64.Length; i++)
            {
                buf64[i] = buf32[buf64.Length + i];
            }

            return;
        }

        nuint deref = Deref(baseAddress, offsets);
        uint size = GetNativeSizeOf<T>() * (uint)buffer.Length;

        fixed (T* pBuffer = buffer)
        {
            if (!WinInteropWrapper.ReadMemory(_handle, deref, pBuffer, size))
            {
                string msg = $"Failed to read memory at {(ulong)deref:X}: {WinInteropWrapper.GetLastWin32ErrorMessage()}";
                ThrowHelper.ThrowException(msg);
            }
        }
    }
}
