using System;
using System.Collections.Generic;
using System.Diagnostics;

using AslHelp.Collections;
using AslHelp.Common.Results;

namespace AslHelp.Memory.Ipc;

public interface IProcessMemory : IMemoryReader, IMemoryWriter, IMemoryScanner, IDisposable
{
    Process Process { get; }
    bool Is64Bit { get; }
    byte PointerSize { get; }

    Module MainModule { get; }
    uint Tick { get; set; }

    IReadOnlyKeyedCollection<string, Module> Modules { get; }

    IEnumerable<MemoryPage> GetMemoryPages(bool allPages = false);

    Result<nuint> ReadRelative(nuint relativeAddress, uint instructionSize = 0x4U);
}
