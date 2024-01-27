using System;
using System.Buffers;

using AslHelp.Collections.Extensions;
using AslHelp.Common.Results;
using AslHelp.Memory;

namespace AslHelp.Unity.Memory.Ipc;

public partial class MonoProcessMemory
{
    public Result<string> ReadString(int baseOffset, params int[] offsets)
    {
        return ReadString(MainModule, baseOffset, offsets);
    }

    public Result<string> ReadString(string? moduleName, int baseOffset, params int[] offsets)
    {
        if (moduleName is null)
        {
            return IpcError.ModuleName_Is_Null;
        }

        return ReadString(Modules[moduleName], baseOffset, offsets);
    }

    public Result<string> ReadString(Module? module, int baseOffset, params int[] offsets)
    {
        if (module is null)
        {
            return IpcError.Module_Is_Null;
        }

        return ReadString(module.Base + (nuint)baseOffset, offsets);
    }

    public Result<string> ReadString(nuint baseAddress, params int[] offsets)
    {
        return Read<nuint>(baseAddress, offsets)
            .AndThen(str => Read<int>(str + (PointerSize * 2U)) // String.m_stringLength
                .AndThen(length =>
                {
                    char[]? rented = null;
                    Span<char> chars = length <= 512
                        ? stackalloc char[length]
                        : (rented = ArrayPool<char>.Shared.Rent(length));

                    return ReadSpan(chars, str + (PointerSize * 2U) + sizeof(int)) // String.m_firstChar
                        .And<string>(chars.ToString())
                        .Finally(() => ArrayPool<char>.Shared.ReturnIfNotNull(rented));
                }));
    }
}
