using AslHelp.Memory.Native;

namespace AslHelp.Memory.Ipc;

public partial class ProcessMemory
{
    public unsafe bool TryRead<T>(out T result, nuint baseAddress, params int[] offsets)
        where T : unmanaged
    {
        result = default;

        fixed (T* pResult = &result)
        {
            return
                TryDeref(out nuint deref, baseAddress, offsets)
                && WinInteropWrapper.ReadMemory(_handle, deref, pResult, GetNativeSizeOf<T>());
        }
    }
}
