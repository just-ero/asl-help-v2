using System;
using System.Diagnostics.CodeAnalysis;

using AslHelp.Common.Results;

namespace AslHelp.Memory.Ipc;

public interface IMemoryReader
{
    Result<nuint> Deref(uint baseOffset, params int[] offsets);
    Result<nuint> Deref(string moduleName, uint baseOffset, params int[] offsets);
    Result<nuint> Deref(Module module, uint baseOffset, params int[] offsets);
    Result<nuint> Deref(nuint baseAddress, params int[] offsets);

    Result<T> Read<T>(uint baseOffset, params int[] offsets) where T : unmanaged;
    Result<T> Read<T>(string? moduleName, uint baseOffset, params int[] offsets) where T : unmanaged;
    Result<T> Read<T>(Module? module, uint baseOffset, params int[] offsets) where T : unmanaged;
    Result<T> Read<T>(nuint baseAddress, params int[] offsets) where T : unmanaged;

    Result<T[]> ReadSpan<T>(int length, uint baseOffset, params int[] offsets) where T : unmanaged;
    Result<T[]> ReadSpan<T>(int length, string? moduleName, uint baseOffset, params int[] offsets) where T : unmanaged;
    Result<T[]> ReadSpan<T>(int length, Module? module, uint baseOffset, params int[] offsets) where T : unmanaged;
    Result<T[]> ReadSpan<T>(int length, nuint baseAddress, params int[] offsets) where T : unmanaged;

    Result ReadSpan<T>(Span<T> buffer, uint baseOffset, params int[] offsets) where T : unmanaged;
    Result ReadSpan<T>(Span<T> buffer, string? moduleName, uint baseOffset, params int[] offsets) where T : unmanaged;
    Result ReadSpan<T>(Span<T> buffer, Module? module, uint baseOffset, params int[] offsets) where T : unmanaged;
    Result ReadSpan<T>(Span<T> buffer, nuint baseAddress, params int[] offsets) where T : unmanaged;

    bool TryReadString([NotNullWhen(true)] out string? result, int maxLength, StringType stringType, nuint baseAddress, params int[] offsets);
}
