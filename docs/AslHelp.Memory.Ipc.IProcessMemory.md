# <a id="AslHelp_Memory_Ipc_IProcessMemory"></a> Interface IProcessMemory

Namespace: [AslHelp.Memory.Ipc](AslHelp.Memory.Ipc.md)  
Assembly: AslHelp.Memory.dll  

```csharp
public interface IProcessMemory : IMemoryReader, IMemoryWriter, IMemoryScanner, IDisposable
```

#### Implements

[IMemoryReader](AslHelp.Memory.Ipc.IMemoryReader.md), 
[IMemoryWriter](AslHelp.Memory.Ipc.IMemoryWriter.md), 
[IMemoryScanner](AslHelp.Memory.Ipc.IMemoryScanner.md), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Extension Methods

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Properties

### <a id="AslHelp_Memory_Ipc_IProcessMemory_Is64Bit"></a> Is64Bit

```csharp
bool Is64Bit { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Memory_Ipc_IProcessMemory_MainModule"></a> MainModule

```csharp
Module MainModule { get; }
```

#### Property Value

 [Module](AslHelp.Memory.Module.md)

### <a id="AslHelp_Memory_Ipc_IProcessMemory_Modules"></a> Modules

```csharp
IReadOnlyKeyedCollection<string, Module> Modules { get; }
```

#### Property Value

 [IReadOnlyKeyedCollection](AslHelp.Collections.IReadOnlyKeyedCollection\-2.md)<[string](https://learn.microsoft.com/dotnet/api/system.string), [Module](AslHelp.Memory.Module.md)\>

### <a id="AslHelp_Memory_Ipc_IProcessMemory_PointerSize"></a> PointerSize

```csharp
byte PointerSize { get; }
```

#### Property Value

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)

### <a id="AslHelp_Memory_Ipc_IProcessMemory_Process"></a> Process

```csharp
Process Process { get; }
```

#### Property Value

 [Process](https://learn.microsoft.com/dotnet/api/system.diagnostics.process)

### <a id="AslHelp_Memory_Ipc_IProcessMemory_Tick"></a> Tick

```csharp
uint Tick { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="AslHelp_Memory_Ipc_IProcessMemory_GetMemoryPages_System_Boolean_"></a> GetMemoryPages\(bool\)

```csharp
IEnumerable<MemoryPage> GetMemoryPages(bool allPages = false)
```

#### Parameters

`allPages` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[MemoryPage](AslHelp.Memory.MemoryPage.md)\>

### <a id="AslHelp_Memory_Ipc_IProcessMemory_TryReadRelative_System_UIntPtr__System_UIntPtr_System_UInt32_"></a> TryReadRelative\(out nuint, nuint, uint\)

```csharp
bool TryReadRelative(out nuint result, nuint relativeAddress, uint instructionSize = 4)
```

#### Parameters

`result` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`relativeAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`instructionSize` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

