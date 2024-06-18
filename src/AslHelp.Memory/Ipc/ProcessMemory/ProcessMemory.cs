using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

using AslHelp.Collections;
using AslHelp.Memory.Native;
using AslHelp.Memory.Native.Enums;

namespace AslHelp.Memory.Ipc;

public partial class ProcessMemory : IProcessMemory
{
    private const ProcessAccess VmAccess = ProcessAccess.VM_OPERATION | ProcessAccess.VM_READ | ProcessAccess.VM_WRITE;

    protected readonly nuint _handle;

    private bool _disposed;

    public ProcessMemory(Process process)
    {
        _handle = WinInterop.OpenProcess((uint)process.Id, VmAccess, false);

        Process = process;
        Is64Bit = WinInteropWrapper.ProcessIs64Bit(_handle);
        PointerSize = (byte)(Is64Bit ? 0x8 : 0x4);

        Modules = new ModuleLookup(process);
        MainModule = Modules.First();
    }

    public Process Process { get; }
    public bool Is64Bit { get; }
    public byte PointerSize { get; }

    public uint Tick { get; set; }
    public Module MainModule { get; }

    public IReadOnlyKeyedCollection<string, Module> Modules { get; }

    public IEnumerable<MemoryPage> GetMemoryPages(bool allPages = false)
    {
        return WinInteropWrapper.EnumerateMemoryPages(_handle, Is64Bit, allPages);
    }

    public void Dispose()
    {
        if (_disposed)
        {
            return;
        }

        WinInterop.CloseHandle(_handle);
        Process.Dispose();

        _disposed = true;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool IsNativeInt<T>()
    {
        return typeof(T) == typeof(nint) || typeof(T) == typeof(nuint);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private unsafe uint GetNativeSizeOf<T>()
        where T : unmanaged
    {
        return (uint)(IsNativeInt<T>() ? PointerSize : sizeof(T));
    }

    public nuint ReadRelative(nuint relativeAddress, uint instructionSize = 0x4U)
    {
        if (Is64Bit)
        {
            return relativeAddress + instructionSize + (nuint)Read<int>(relativeAddress);
        }
        else
        {
            return Read<nuint>(relativeAddress);
        }
    }
}
