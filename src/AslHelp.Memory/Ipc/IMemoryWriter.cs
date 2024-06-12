using System;
using System.Diagnostics.CodeAnalysis;

using AslHelp.Common.Results;

namespace AslHelp.Memory.Ipc;

public interface IMemoryWriter
{
    Result Write<T>(T value, int baseOffset, params int[] offsets) where T : unmanaged;
    Result Write<T>(T value, string? moduleName, int baseOffset, params int[] offsets) where T : unmanaged;
    Result Write<T>(T value, Module? module, int baseOffset, params int[] offsets) where T : unmanaged;
    Result Write<T>(T value, nuint baseAddress, params int[] offsets) where T : unmanaged;

    Result WriteArray<T>(ReadOnlySpan<T> values, int baseOffset, params int[] offsets) where T : unmanaged;
    Result WriteArray<T>(ReadOnlySpan<T> values, string? moduleName, int baseOffset, params int[] offsets) where T : unmanaged;
    Result WriteArray<T>(ReadOnlySpan<T> values, Module? module, int baseOffset, params int[] offsets) where T : unmanaged;
    Result WriteArray<T>(ReadOnlySpan<T> values, nuint baseAddress, params int[] offsets) where T : unmanaged;
}
