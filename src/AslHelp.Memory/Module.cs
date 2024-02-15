using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

using AslHelp.Memory.Native;
using AslHelp.Memory.Native.Structs;

namespace AslHelp.Memory;

/// <summary>
///     Represents an assembly loaded into a process.
/// </summary>
public sealed class Module
{
    private readonly nuint _processHandle;

    private Dictionary<string, DebugSymbol>? _symbols;

    /// <summary>
    ///     Initializes a new instance of the <see cref="Module"/> class
    ///     using the specified process handle, module name, file path, base address, and memory size.
    /// </summary>
    /// <param name="processHandle">
    ///     The handle of the <see cref="Process"/> containing the module.
    /// </param>
    /// <param name="name">
    ///     The name of the module.
    /// </param>
    /// <param name="fileName">
    ///     The fully qualified file path to the module.
    /// </param>
    /// <param name="base">
    ///     The memory address where the module is loaded.
    /// </param>
    /// <param name="memorySize">
    ///     The amount of memory required to load the module, in bytes.
    /// </param>
    public Module(nuint processHandle, string name, string fileName, nuint @base, uint memorySize)
    {
        _processHandle = processHandle;

        Name = name;
        FileName = fileName;
        Base = @base;
        MemorySize = memorySize;
    }

    internal unsafe Module(nuint processHandle, MODULEENTRY32W me)
    {
        _processHandle = processHandle;

        Name = new((char*)me.szModule);
        FileName = new((char*)me.szExePath);
        Base = (nuint)me.modBaseAddr;
        MemorySize = me.modBaseSize;
    }

    /// <summary>
    ///     Gets the name of the <see cref="Module"/>.
    /// </summary>
    public string Name { get; }

    /// <summary>
    ///     Gets the fully qualified file path to the <see cref="Module"/>.
    /// </summary>
    public string FileName { get; }

    /// <summary>
    ///     Gets the memory address where the <see cref="Module"/> is loaded.
    /// </summary>
    public nuint Base { get; }

    /// <summary>
    ///     Gets the amount of memory required to load the <see cref="Module"/>, in bytes.
    /// </summary>
    public uint MemorySize { get; }

    /// <summary>
    ///     Gets all debug symbols for the <see cref="Module"/>.
    /// </summary>
    /// <value>
    ///     A <see cref="Dictionary{TKey, TValue}"/> mapping the debug symbol's name to a corresponding <see cref="DebugSymbol"/>.
    /// </value>
    /// <remarks>
    ///     The symbols are cached upon the first call to this property due to the non-trivial overhead.
    ///     Both embedded and PDB-contained symbols are queried, searching the module's directory for applicable PDB files.
    /// </remarks>
    public Dictionary<string, DebugSymbol> Symbols
    {
        get
        {
            if (_symbols is not null)
            {
                return _symbols;
            }

            List<SYMBOL_INFOW> nonPdbSymbols = this.GetSymbols(_processHandle, "*", null);
            List<SYMBOL_INFOW> pdbSymbols = this.GetSymbols(_processHandle, "*", Path.GetDirectoryName(FileName));

            _symbols = new(nonPdbSymbols.Count + pdbSymbols.Count, StringComparer.OrdinalIgnoreCase);

            for (int i = 0; i < nonPdbSymbols.Count; i++)
            {
                DebugSymbol symbol = new(nonPdbSymbols[i]);
                _symbols[symbol.Name] = symbol;
            }

            for (int i = 0; i < pdbSymbols.Count; i++)
            {
                DebugSymbol symbol = new(pdbSymbols[i]);
                _symbols[symbol.Name] = symbol;
            }

            return _symbols;
        }
    }

    /// <summary>
    ///     Gets the version information for the <see cref="Module"/>.
    /// </summary>
    public FileVersionInfo VersionInfo => FileVersionInfo.GetVersionInfo(FileName);

    /// <summary>
    ///     Converts the value of this instance to a <see cref="string"/>.
    /// </summary>
    /// <returns>
    ///     The name of the <see cref="Module"/>.
    /// </returns>
    public override string ToString()
    {
        return Name;
    }
}
