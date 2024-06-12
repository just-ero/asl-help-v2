using System;
using System.Diagnostics.CodeAnalysis;

using AslHelp.Common.Results;

namespace AslHelp.Memory.Ipc;

public interface IMemoryReader
{
    Result<nuint> Deref(int baseOffset, params int[] offsets);
    Result<nuint> Deref(string? moduleName, int baseOffset, params int[] offsets);
    Result<nuint> Deref(Module? module, int baseOffset, params int[] offsets);
    Result<nuint> Deref(nuint baseAddress, params int[] offsets);

    Result<T> Read<T>(int baseOffset, params int[] offsets) where T : unmanaged;
    Result<T> Read<T>(string? moduleName, int baseOffset, params int[] offsets) where T : unmanaged;
    Result<T> Read<T>(Module? module, int baseOffset, params int[] offsets) where T : unmanaged;
    Result<T> Read<T>(nuint baseAddress, params int[] offsets) where T : unmanaged;

    Result<T[]> ReadArray<T>(int length, int baseOffset, params int[] offsets) where T : unmanaged;
    Result<T[]> ReadArray<T>(int length, string? moduleName, int baseOffset, params int[] offsets) where T : unmanaged;
    Result<T[]> ReadArray<T>(int length, Module? module, int baseOffset, params int[] offsets) where T : unmanaged;
    Result<T[]> ReadArray<T>(int length, nuint baseAddress, params int[] offsets) where T : unmanaged;

    Result ReadArray<T>(Span<T> buffer, int baseOffset, params int[] offsets) where T : unmanaged;
    Result ReadArray<T>(Span<T> buffer, string? moduleName, int baseOffset, params int[] offsets) where T : unmanaged;
    Result ReadArray<T>(Span<T> buffer, Module? module, int baseOffset, params int[] offsets) where T : unmanaged;
    Result ReadArray<T>(Span<T> buffer, nuint baseAddress, params int[] offsets) where T : unmanaged;

    Result<string> ReadString(int maxLength, StringType stringType, int baseOffset, params int[] offsets);
    Result<string> ReadString(int maxLength, StringType stringType, string? moduleName, int baseOffset, params int[] offsets);
    Result<string> ReadString(int maxLength, StringType stringType, Module? module, int baseOffset, params int[] offsets);
    Result<string> ReadString(int maxLength, StringType stringType, nuint baseAddress, params int[] offsets);
}
