using AslHelp.Memory.Native;

namespace AslHelp.Memory.Ipc;

public partial class ProcessMemory
{
    public unsafe bool Write<T>(T value, nuint baseAddress, params int[] offsets)
        where T : unmanaged
    {
        return
            TryDeref(out nuint deref, baseAddress, offsets)
            && WinInteropWrapper.WriteMemory(_handle, deref, &value, GetNativeSizeOf<T>());
    }
}
