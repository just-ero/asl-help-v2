using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using AslHelp.Common;
using AslHelp.Memory.Native.Enums;
using AslHelp.Memory.Native.Structs;

namespace AslHelp.Memory.Native;

internal static unsafe partial class WinInteropWrapper
{
    private const int ERROR_INSUFFICIENT_BUFFER = 0x7A;

    public static string GetLastWin32ErrorMessage(this Module module)
    {
        return GetLastWin32ErrorMessage(module.Base);
    }

    public static string GetLastWin32ErrorMessage(nuint moduleHandle = 0)
    {
        int errorCode = Marshal.GetLastWin32Error();
        if (errorCode == 0)
        {
            return string.Empty;
        }

        FormatMessageFlags flags = FormatMessageFlags.IGNORE_INSERTS | FormatMessageFlags.FROM_SYSTEM | FormatMessageFlags.ARGUMENT_ARRAY;
        if (moduleHandle != 0)
        {
            flags |= FormatMessageFlags.FROM_HMODULE;
        }

        Span<char> buffer = stackalloc char[256];

        fixed (char* pBuffer = buffer)
        {
            int length = WinInterop.FormatMessage(flags, moduleHandle, (uint)errorCode, 0, pBuffer, (uint)buffer.Length, null);
            if (length > 0)
            {
                return $"{getAndTrimString(buffer[..length])} (0x{errorCode:X})";
            }
        }

        if (Marshal.GetLastWin32Error() == ERROR_INSUFFICIENT_BUFFER)
        {
            flags |= FormatMessageFlags.ALLOCATE_BUFFER;

            nint nativeMsgPtr = 0;
            try
            {
                int length = WinInterop.FormatMessage(flags, moduleHandle, (uint)errorCode, 0, (char*)&nativeMsgPtr, 0, null);
                if (length > 0)
                {
                    return $"{getAndTrimString(new((char*)nativeMsgPtr, length))} (0x{errorCode:X})";
                }
            }
            finally
            {
                Marshal.FreeHGlobal(nativeMsgPtr);
            }
        }

        return $"Unknown error (0x{errorCode:X})";

        static string getAndTrimString(Span<char> buffer)
        {
            int length = buffer.Length;
            while (length > 0 && buffer[length - 1] <= ' ')
            {
                length--;
            }

            return buffer[..length].ToString();
        }
    }

    public static bool ProcessIs64Bit(this Process process)
    {
        return ProcessIs64Bit((nuint)(nint)process.Handle);
    }

    public static bool ProcessIs64Bit(nuint processHandle)
    {
        if (!WinInterop.IsWow64Process(processHandle, out bool isWow64))
        {
            ThrowHelper.ThrowWin32Exception();
        }

        return Environment.Is64BitOperatingSystem && !isWow64;
    }

    public static bool ReadMemory(this Process process, nuint address, void* buffer, uint bufferSize)
    {
        return ReadMemory((nuint)(nint)process.Handle, address, buffer, bufferSize);
    }

    public static bool ReadMemory(nuint processHandle, nuint address, void* buffer, uint bufferSize)
    {
        return WinInterop.ReadProcessMemory(processHandle, address, buffer, bufferSize, out nuint nRead)
            && nRead == bufferSize;
    }

    public static bool WriteMemory(this Process process, nuint address, void* data, uint dataSize)
    {
        return WriteMemory((nuint)(nint)process.Handle, address, data, dataSize);
    }

    public static bool WriteMemory(nuint processHandle, nuint address, void* data, uint dataSize)
    {
        return WinInterop.WriteProcessMemory(processHandle, address, data, dataSize, out nuint nWritten)
            && nWritten == dataSize;
    }

    public static IEnumerable<MODULEENTRY32W> EnumerateModulesTh32(this Process process)
    {
        return EnumerateModulesTh32((uint)process.Id);
    }

    public static IEnumerable<MODULEENTRY32W> EnumerateModulesTh32(uint processId)
    {
        nuint snapshot = WinInterop.CreateToolhelp32Snapshot(processId, ThFlags.TH32CS_SNAPMODULE | ThFlags.TH32CS_SNAPMODULE32);

        try
        {
            MODULEENTRY32W me = new() { dwSize = MODULEENTRY32W.Size };
            if (!WinInterop.Module32First(snapshot, ref me))
            {
                yield break;
            }

            do
            {
                yield return me;
            } while (WinInterop.Module32Next(snapshot, ref me));
        }
        finally
        {
            WinInterop.CloseHandle(snapshot);
        }
    }

    public static IEnumerable<MemoryPage> EnumerateMemoryPages(this Process process, bool allPages)
    {
        return EnumerateMemoryPages((nuint)(nint)process.Handle, process.ProcessIs64Bit(), allPages);
    }

    public static IEnumerable<MemoryPage> EnumerateMemoryPages(nuint processHandle, bool is64Bit, bool allPages)
    {
        nuint address = 0x10000, max = (nuint)(is64Bit ? 0x7FFFFFFEFFFF : 0x7FFEFFFF);

        do
        {
            if (WinInterop.VirtualQuery(processHandle, address, out MEMORY_BASIC_INFORMATION mbi) == 0)
            {
                break;
            }

            address += mbi.RegionSize;

            if (mbi.State != MemState.MEM_COMMIT)
            {
                continue;
            }

            if (!allPages && (mbi.Protect & MemProtect.PAGE_GUARD) != 0)
            {
                continue;
            }

            if (!allPages && mbi.Type != MemType.MEM_PRIVATE)
            {
                continue;
            }

            yield return new(mbi);
        } while (address < max);
    }

    public static List<SYMBOL_INFOW> GetSymbols(this Module module, nuint processHandle, string? mask = "*", string? pdbDirectory = null)
    {
        var callback =
            (delegate* unmanaged[Stdcall]<SYMBOL_INFOW*, uint, void*, int>)Marshal.GetFunctionPointerForDelegate(enumSymbolsCallback);

        List<SYMBOL_INFOW> symbols = [];
        void* pSymbols = Unsafe.AsPointer(ref symbols);

        if (!WinInterop.SymInitialize(processHandle, pdbDirectory, false))
        {
            ThrowHelper.ThrowWin32Exception();
        }

        try
        {
            nuint symLoadBase = WinInterop.SymLoadModule(processHandle, 0, module.FileName, null, module.Base, module.MemorySize, null, 0);

            if (symLoadBase == 0)
            {
                ThrowHelper.ThrowWin32Exception();
            }

            if (!WinInterop.SymEnumSymbols(processHandle, symLoadBase, mask, callback, pSymbols))
            {
                ThrowHelper.ThrowWin32Exception();
            }
        }
        finally
        {
            _ = WinInterop.SymCleanup(processHandle);
        }

        return symbols;

        static int enumSymbolsCallback(SYMBOL_INFOW* pSymInfo, uint symbolSize, void* userContext)
        {
            Unsafe.AsRef<List<SYMBOL_INFOW>>(userContext).Add(*pSymInfo);

            return 1;
        }
    }
}
