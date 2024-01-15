using System.Diagnostics.CodeAnalysis;

using AslHelp.Common;
using AslHelp.Common.Results;
using AslHelp.Memory.Native;

namespace AslHelp.Memory.Ipc;

public partial class ProcessMemory
{
    public Result<nuint> Deref(uint baseOffset, params int[] offsets)
    {
        return Deref(MainModule, baseOffset, offsets);
    }

    public Result<nuint> Deref(string? moduleName, uint baseOffset, params int[] offsets)
    {
        if (moduleName is null)
        {
            return IpcError.ModuleNameMustNotBeNull;
        }

        return Deref(Modules[moduleName], baseOffset, offsets);
    }

    public Result<nuint> Deref(Module? module, uint baseOffset, params int[] offsets)
    {
        if (module is null)
        {
            return IpcError.ModuleMustNotBeNull;
        }

        return Deref(module.Base + baseOffset, offsets);
    }

    public unsafe Result<nuint> Deref(nuint baseAddress, params int[] offsets)
    {
        if (_disposed)
        {
            return IpcError.ProcessMemoryWasDisposed;
        }

        if (baseAddress == 0)
        {
            return IpcError.BaseAddressMustNotBeNull;
        }

        nuint result = baseAddress;

        for (int i = 0; i < offsets.Length; i++)
        {
            if (!WinInteropWrapper.ReadMemory(_handle, result, &result, PointerSize))
            {
                return IpcError.DerefFailure(result);
            }

            if (result == 0)
            {
                return IpcError.DerefFailureNullPointer;
            }

            result += (nuint)offsets[i];
        }

        return result;
    }
}
