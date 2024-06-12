using AslHelp.Common.Results;
using AslHelp.Memory.Errors;
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
            return IpcError.ModuleNameNull;
        }

        if (!Modules.TryGetValue(moduleName, out Module? module))
        {
            return IpcError.ModuleNotFound(moduleName);
        }

        return Deref(module, baseOffset, offsets);
    }

    public Result<nuint> Deref(Module? module, int baseOffset, params int[] offsets)
    {
        if (module is null)
        {
            return IpcError.ModuleNull;
        }

        return Deref(module.Base + (nuint)baseOffset, offsets);
    }

    public unsafe Result<nuint> Deref(nuint baseAddress, params int[] offsets)
    {
        if (_disposed)
        {
            return IpcError.ProcessMemoryDisposed;
        }

        if (baseAddress == 0)
        {
            return IpcError.BaseAddressNull;
        }

        nuint result = baseAddress;
        uint size = PointerSize;

        for (int i = 0; i < offsets.Length; i++)
        {
            if (!WinInteropWrapper.ReadMemory(_handle, result, &result, size))
            {
                return IpcError.DerefFailure(result);
            }

            if (result == 0)
            {
                return IpcError.DerefNull;
            }

            result += (nuint)offsets[i];
        }

        return result;
    }
}
