using System.Collections.Generic;

using AslHelp.Collections.Extensions;
using AslHelp.Common.Results;
using AslHelp.Memory;

namespace AslHelp.Unity.Memory.Ipc;

internal partial class MonoProcessMemory
{
    public Result<List<T>> ReadList<T>(int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        return ReadList<T>(MainModule, baseOffset, offsets);
    }

    public Result<List<T>> ReadList<T>(string? moduleName, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        if (moduleName is null)
        {
            return IpcError.ModuleName_MustNot_BeNull;
        }

        return ReadList<T>(Modules[moduleName], baseOffset, offsets);
    }

    public Result<List<T>> ReadList<T>(Module? module, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        if (module is null)
        {
            return IpcError.Module_MustNot_BeNull;
        }

        return ReadList<T>(module.Base + (nuint)baseOffset, offsets);
    }

    public Result<List<T>> ReadList<T>(nuint baseAddress, params int[] offsets)
        where T : unmanaged
    {
        return
            Read<nuint>(baseAddress, offsets)
            .AndThen(list =>
                Read<int>(list + (PointerSize * 3U))
                .AndThen(count =>
                {
                    List<T> values = new(count);

                    return
                        ReadSpan(values.AsSpan(), list + (PointerSize * 2U), PointerSize * 4)
                        .And<List<T>>(values);
                }));
    }
}
