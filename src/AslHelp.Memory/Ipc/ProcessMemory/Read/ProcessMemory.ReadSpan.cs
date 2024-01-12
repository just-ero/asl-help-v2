using System;
using System.Runtime.InteropServices;

using AslHelp.Memory.Native;

namespace AslHelp.Memory.Ipc;

public partial class ProcessMemory
{
    public unsafe bool TryReadSpan<T>(Span<T> buffer, nuint baseAddress, params int[] offsets)
        where T : unmanaged
    {
        if (!Is64Bit && IsNativeInt<T>())
        {
            // Need to read 32-bit integers for the pointers and then copy.

            Span<uint> buf32 = MemoryMarshal.Cast<T, uint>(buffer);
            Span<ulong> buf64 = MemoryMarshal.Cast<T, ulong>(buffer);

            if (!TryReadSpan(buf32[..buf64.Length], baseAddress, offsets))
            {
                return false;
            }

            for (int i = 0; i < buf64.Length; i++)
            {
                buf64[i] = buf32[buf64.Length + i];
            }

            return true;
        }

        uint size = GetNativeSizeOf<T>() * (uint)buffer.Length;

        fixed (T* pBuffer = buffer)
        {
            return TryDeref(out nuint deref, baseAddress, offsets)
                && WinInteropWrapper.ReadMemory(_handle, deref, pBuffer, size);
        }
    }
}
