using System.Diagnostics.CodeAnalysis;

using AslHelp.Common;
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
            return IpcError.ModuleName_MustNot_BeNull;
        }

        return Deref(Modules[moduleName], baseOffset, offsets);
    }

    public Result<nuint> Deref(Module? module, int baseOffset, params int[] offsets)
    {
        if (module is null)
        {
            return IpcError.Module_MustNot_BeNull;
        }

        return Deref(module.Base + (nuint)baseOffset, offsets);
    }

    public unsafe Result<nuint> Deref(nuint baseAddress, params int[] offsets)
    {
        if (_disposed)
        {
            return IpcError.ProcessMemory_MustNot_BeDisposed;
        }

        if (baseAddress == 0)
        {
            return IpcError.BaseAddress_MustNot_BeNull;
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
                return IpcError.DerefFailure_ReadNull;
            }

            result += (nuint)offsets[i];
        }

        return result;
    }
}
