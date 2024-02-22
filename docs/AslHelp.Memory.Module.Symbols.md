# <a id="AslHelp_Memory_Module_Symbols"></a> Property Symbols

Namespace: [AslHelp.Memory](AslHelp.Memory.md)  
Assembly: AslHelp.Memory.dll  

## <a id="AslHelp_Memory_Module_Symbols"></a> Symbols

Gets all debug symbols for the <xref href="AslHelp.Memory.Module" data-throw-if-not-resolved="false"></xref>.

```csharp
public Dictionary<string, DebugSymbol> Symbols { get; }
```

### Property Value

 [Dictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2)<[string](https://learn.microsoft.com/dotnet/api/system.string), [DebugSymbol](AslHelp.Memory.DebugSymbol.md)\>

### Remarks

The symbols are cached upon the first call to this property due to the non-trivial overhead.
Both embedded and PDB-contained symbols are queried, searching the module's directory for applicable PDB files.

