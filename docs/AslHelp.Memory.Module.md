# <a id="AslHelp_Memory_Module"></a> Class Module

Namespace: [AslHelp.Memory](AslHelp.Memory.md)  
Assembly: AslHelp.Memory.dll  

Represents an assembly loaded into a process.

```csharp
public sealed class Module
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Module](AslHelp.Memory.Module.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Constructors

### <a id="AslHelp_Memory_Module__ctor_System_UIntPtr_System_String_System_String_System_UIntPtr_System_UInt32_"></a> Module\(nuint, string, string, nuint, uint\)

Initializes a new instance of the <xref href="AslHelp.Memory.Module" data-throw-if-not-resolved="false"></xref> class
using the specified process handle, module name, file path, base address, and memory size.

```csharp
public Module(nuint processHandle, string name, string fileName, nuint @base, uint memorySize)
```

#### Parameters

`processHandle` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

The handle of the <xref href="System.Diagnostics.Process" data-throw-if-not-resolved="false"></xref> containing the module.

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the module.

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The fully qualified file path to the module.

`base` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

The memory address where the module is loaded.

`memorySize` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

The amount of memory required to load the module, in bytes.

## Properties

### <a id="AslHelp_Memory_Module_Base"></a> Base

Gets the memory address where the <xref href="AslHelp.Memory.Module" data-throw-if-not-resolved="false"></xref> is loaded.

```csharp
public nuint Base { get; }
```

#### Property Value

 [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

### <a id="AslHelp_Memory_Module_FileName"></a> FileName

Gets the fully qualified file path to the <xref href="AslHelp.Memory.Module" data-throw-if-not-resolved="false"></xref>.

```csharp
public string FileName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="AslHelp_Memory_Module_MemorySize"></a> MemorySize

Gets the amount of memory required to load the <xref href="AslHelp.Memory.Module" data-throw-if-not-resolved="false"></xref>, in bytes.

```csharp
public uint MemorySize { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="AslHelp_Memory_Module_Name"></a> Name

Gets the name of the <xref href="AslHelp.Memory.Module" data-throw-if-not-resolved="false"></xref>.

```csharp
public string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="AslHelp_Memory_Module_Symbols"></a> Symbols

Gets all debug symbols for the <xref href="AslHelp.Memory.Module" data-throw-if-not-resolved="false"></xref>.

```csharp
public Dictionary<string, DebugSymbol> Symbols { get; }
```

#### Property Value

 [Dictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2)<[string](https://learn.microsoft.com/dotnet/api/system.string), [DebugSymbol](AslHelp.Memory.DebugSymbol.md)\>

#### Remarks

The symbols are cached upon the first call to this property due to the non-trivial overhead.
Both embedded and PDB-contained symbols are queried, searching the module's directory for applicable PDB files.

### <a id="AslHelp_Memory_Module_VersionInfo"></a> VersionInfo

Gets the version information for the <xref href="AslHelp.Memory.Module" data-throw-if-not-resolved="false"></xref>.

```csharp
public FileVersionInfo VersionInfo { get; }
```

#### Property Value

 [FileVersionInfo](https://learn.microsoft.com/dotnet/api/system.diagnostics.fileversioninfo)

## Methods

### <a id="AslHelp_Memory_Module_ToString"></a> ToString\(\)

Converts the value of this instance to its <xref href="System.String" data-throw-if-not-resolved="false"></xref> representation.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the <xref href="AslHelp.Memory.Module" data-throw-if-not-resolved="false"></xref>.

