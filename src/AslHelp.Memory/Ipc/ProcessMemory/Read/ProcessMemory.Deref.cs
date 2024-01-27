using AslHelp.Common.Results;
using AslHelp.Memory.Native;

namespace AslHelp.Memory.Ipc;

public partial class ProcessMemory
{
    public Result<nuint> Deref(int baseOffset, params int[] offsets)
    {
        return Deref(MainModule, baseOffset, offsets);
    }

    public Result<nuint> Deref(string? moduleName, int baseOffset, params int[] offsets)
    {
        if (moduleName is null)
        {
            return IpcError.ModuleName_Is_Null;
        }

        return Deref(Modules[moduleName], baseOffset, offsets);
    }

    public Result<nuint> Deref(Module? module, int baseOffset, params int[] offsets)
    {
        if (module is null)
        {
            return IpcError.Module_Is_Null;
        }

        return Deref(module.Base + (nuint)baseOffset, offsets);
    }

    public unsafe Result<nuint> Deref(nuint baseAddress, params int[] offsets)
    {
        if (_disposed)
        {
            return IpcError.ProcessMemory_Is_Disposed;
        }

        if (baseAddress == 0)
        {
            return IpcError.BaseAddress_Is_Null;
        }

        nuint result = baseAddress;

        for (int i = 0; i < offsets.Length; i++)
        {
            if (!WinInteropWrapper.ReadMemory(_handle, result, &result, PointerSize))
            {
                return IpcError.DerefFailure_Win32Error(result);
            }

            if (result == 0)
            {
                return IpcError.Deref_Is_Null;
            }

            result += (nuint)offsets[i];
        }

        return result;
    }
}
