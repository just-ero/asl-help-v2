using AslHelp.Common.Results;
using AslHelp.Memory;

namespace AslHelp.Unity.Memory.Ipc;

internal partial class MonoProcessMemory
{
    public Result<T[]> ReadArray<T>(int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        return ReadArray<T>(MainModule, baseOffset, offsets);
    }

    public Result<T[]> ReadArray<T>(string? moduleName, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        if (moduleName is null)
        {
            return IpcError.ModuleName_MustNot_BeNull;
        }

        return ReadArray<T>(Modules[moduleName], baseOffset, offsets);
    }

    public Result<T[]> ReadArray<T>(Module? module, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        if (module is null)
        {
            return IpcError.Module_MustNot_BeNull;
        }

        return ReadArray<T>(module.Base + (nuint)baseOffset, offsets);
    }

    public Result<T[]> ReadArray<T>(nuint baseAddress, params int[] offsets)
        where T : unmanaged
    {
        return
            Read<nuint>(baseAddress, offsets)
            .AndThen(array =>
            {
                return
                    Read<int>(array + (PointerSize * 3U))
                    .AndThen(length => ReadSpan<T>(length, array + (PointerSize * 4U)));
            });
    }
}
