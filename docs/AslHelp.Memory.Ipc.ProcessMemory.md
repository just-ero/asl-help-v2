# <a id="AslHelp_Memory_Ipc_ProcessMemory"></a> Class ProcessMemory

Namespace: [AslHelp.Memory.Ipc](AslHelp.Memory.Ipc.md)  
Assembly: AslHelp.Memory.dll  

```csharp
public class ProcessMemory : IProcessMemory, IMemoryReader, IMemoryWriter, IMemoryScanner, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ProcessMemory](AslHelp.Memory.Ipc.ProcessMemory.md)

#### Implements

[IProcessMemory](AslHelp.Memory.Ipc.IProcessMemory.md), 
[IMemoryReader](AslHelp.Memory.Ipc.IMemoryReader.md), 
[IMemoryWriter](AslHelp.Memory.Ipc.IMemoryWriter.md), 
[IMemoryScanner](AslHelp.Memory.Ipc.IMemoryScanner.md), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
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

### <a id="AslHelp_Memory_Ipc_ProcessMemory__ctor_System_Diagnostics_Process_"></a> ProcessMemory\(Process\)

```csharp
public ProcessMemory(Process process)
```

#### Parameters

`process` [Process](https://learn.microsoft.com/dotnet/api/system.diagnostics.process)

## Fields

### <a id="AslHelp_Memory_Ipc_ProcessMemory__handle"></a> \_handle

```csharp
protected readonly nuint _handle
```

#### Field Value

 [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

## Properties

### <a id="AslHelp_Memory_Ipc_ProcessMemory_Is64Bit"></a> Is64Bit

```csharp
public bool Is64Bit { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Memory_Ipc_ProcessMemory_MainModule"></a> MainModule

```csharp
public Module MainModule { get; }
```

#### Property Value

 [Module](AslHelp.Memory.Module.md)

### <a id="AslHelp_Memory_Ipc_ProcessMemory_Modules"></a> Modules

```csharp
public IReadOnlyKeyedCollection<string, Module> Modules { get; }
```

#### Property Value

 [IReadOnlyKeyedCollection](AslHelp.Collections.IReadOnlyKeyedCollection\-2.md)<[string](https://learn.microsoft.com/dotnet/api/system.string), [Module](AslHelp.Memory.Module.md)\>

### <a id="AslHelp_Memory_Ipc_ProcessMemory_PointerSize"></a> PointerSize

```csharp
public byte PointerSize { get; }
```

#### Property Value

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)

### <a id="AslHelp_Memory_Ipc_ProcessMemory_Process"></a> Process

```csharp
public Process Process { get; }
```

#### Property Value

 [Process](https://learn.microsoft.com/dotnet/api/system.diagnostics.process)

### <a id="AslHelp_Memory_Ipc_ProcessMemory_Tick"></a> Tick

```csharp
public uint Tick { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="AslHelp_Memory_Ipc_ProcessMemory_Deref_System_UInt32_System_Int32___"></a> Deref\(uint, params int\[\]\)

```csharp
public nuint Deref(uint baseOffset, params int[] offsets)
```

#### Parameters

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

### <a id="AslHelp_Memory_Ipc_ProcessMemory_Deref_System_String_System_UInt32_System_Int32___"></a> Deref\(string, uint, params int\[\]\)

```csharp
public nuint Deref(string moduleName, uint baseOffset, params int[] offsets)
```

#### Parameters

`moduleName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

### <a id="AslHelp_Memory_Ipc_ProcessMemory_Deref_AslHelp_Memory_Module_System_UInt32_System_Int32___"></a> Deref\(Module, uint, params int\[\]\)

```csharp
public nuint Deref(Module module, uint baseOffset, params int[] offsets)
```

#### Parameters

`module` [Module](AslHelp.Memory.Module.md)

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

### <a id="AslHelp_Memory_Ipc_ProcessMemory_Deref_System_UIntPtr_System_Int32___"></a> Deref\(nuint, params int\[\]\)

```csharp
public nuint Deref(nuint baseAddress, params int[] offsets)
```

#### Parameters

`baseAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

### <a id="AslHelp_Memory_Ipc_ProcessMemory_Dispose"></a> Dispose\(\)

```csharp
public void Dispose()
```

### <a id="AslHelp_Memory_Ipc_ProcessMemory_GetMemoryPages_System_Boolean_"></a> GetMemoryPages\(bool\)

```csharp
public IEnumerable<MemoryPage> GetMemoryPages(bool allPages = false)
```

#### Parameters

`allPages` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[MemoryPage](AslHelp.Memory.MemoryPage.md)\>

### <a id="AslHelp_Memory_Ipc_ProcessMemory_Scan_AslHelp_Memory_Scanning_ScanPattern_System_UIntPtr_System_UIntPtr_"></a> Scan\(ScanPattern, nuint, nuint\)

```csharp
public nuint Scan(ScanPattern pattern, nuint startAddress, nuint endAddress)
```

#### Parameters

`pattern` [ScanPattern](AslHelp.Memory.Scanning.ScanPattern.md)

`startAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`endAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

#### Returns

 [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

### <a id="AslHelp_Memory_Ipc_ProcessMemory_Scan_AslHelp_Memory_Scanning_ScanPattern_System_UIntPtr_System_Int32_"></a> Scan\(ScanPattern, nuint, int\)

```csharp
public nuint Scan(ScanPattern pattern, nuint startAddress, int size)
```

#### Parameters

`pattern` [ScanPattern](AslHelp.Memory.Scanning.ScanPattern.md)

`startAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`size` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

### <a id="AslHelp_Memory_Ipc_ProcessMemory_ScanAll_AslHelp_Memory_Scanning_ScanPattern_System_UIntPtr_System_UIntPtr_"></a> ScanAll\(ScanPattern, nuint, nuint\)

```csharp
public IEnumerable<nuint> ScanAll(ScanPattern pattern, nuint startAddress, nuint endAddress)
```

#### Parameters

`pattern` [ScanPattern](AslHelp.Memory.Scanning.ScanPattern.md)

`startAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`endAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)\>

### <a id="AslHelp_Memory_Ipc_ProcessMemory_ScanAll_AslHelp_Memory_Scanning_ScanPattern_System_UIntPtr_System_Int32_"></a> ScanAll\(ScanPattern, nuint, int\)

```csharp
public IEnumerable<nuint> ScanAll(ScanPattern pattern, nuint startAddress, int size)
```

#### Parameters

`pattern` [ScanPattern](AslHelp.Memory.Scanning.ScanPattern.md)

`startAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`size` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)\>

### <a id="AslHelp_Memory_Ipc_ProcessMemory_TryDeref_System_UIntPtr__System_UInt32_System_Int32___"></a> TryDeref\(out nuint, uint, params int\[\]\)

```csharp
public bool TryDeref(out nuint result, uint baseOffset, params int[] offsets)
```

#### Parameters

`result` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Memory_Ipc_ProcessMemory_TryDeref_System_UIntPtr__System_String_System_UInt32_System_Int32___"></a> TryDeref\(out nuint, string?, uint, params int\[\]\)

```csharp
public bool TryDeref(out nuint result, string? moduleName, uint baseOffset, params int[] offsets)
```

#### Parameters

`result` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`moduleName` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Memory_Ipc_ProcessMemory_TryDeref_System_UIntPtr__AslHelp_Memory_Module_System_UInt32_System_Int32___"></a> TryDeref\(out nuint, Module?, uint, params int\[\]\)

```csharp
public bool TryDeref(out nuint result, Module? module, uint baseOffset, params int[] offsets)
```

#### Parameters

`result` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`module` [Module](AslHelp.Memory.Module.md)?

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Memory_Ipc_ProcessMemory_TryDeref_System_UIntPtr__System_UIntPtr_System_Int32___"></a> TryDeref\(out nuint, nuint, params int\[\]\)

```csharp
public bool TryDeref(out nuint result, nuint baseAddress, params int[] offsets)
```

#### Parameters

`result` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`baseAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Memory_Ipc_ProcessMemory_TryRead__1___0__System_UIntPtr_System_Int32___"></a> TryRead<T\>\(out T, nuint, params int\[\]\)

```csharp
public bool TryRead<T>(out T result, nuint baseAddress, params int[] offsets) where T : unmanaged
```

#### Parameters

`result` T

`baseAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Type Parameters

`T` 

### <a id="AslHelp_Memory_Ipc_ProcessMemory_TryReadRelative_System_UIntPtr__System_UIntPtr_System_UInt32_"></a> TryReadRelative\(out nuint, nuint, uint\)

```csharp
public bool TryReadRelative(out nuint result, nuint relativeAddress, uint instructionSize = 4)
```

#### Parameters

`result` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`relativeAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`instructionSize` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Memory_Ipc_ProcessMemory_TryReadSpan__1_System_Span___0__System_UIntPtr_System_Int32___"></a> TryReadSpan<T\>\(Span<T\>, nuint, params int\[\]\)

```csharp
public bool TryReadSpan<T>(Span<T> buffer, nuint baseAddress, params int[] offsets) where T : unmanaged
```

#### Parameters

`buffer` [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<T\>

`baseAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Type Parameters

`T` 

### <a id="AslHelp_Memory_Ipc_ProcessMemory_TryReadString_System_String__System_Int32_AslHelp_Memory_StringType_System_UIntPtr_System_Int32___"></a> TryReadString\(out string?, int, StringType, nuint, params int\[\]\)

```csharp
public bool TryReadString(out string? result, int maxLength, StringType stringType, nuint baseAddress, params int[] offsets)
```

#### Parameters

`result` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`maxLength` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`stringType` [StringType](AslHelp.Memory.StringType.md)

`baseAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Memory_Ipc_ProcessMemory_Write__1___0_System_UIntPtr_System_Int32___"></a> Write<T\>\(T, nuint, params int\[\]\)

```csharp
public bool Write<T>(T value, nuint baseAddress, params int[] offsets) where T : unmanaged
```

#### Parameters

`value` T

`baseAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Type Parameters

`T` 

### <a id="AslHelp_Memory_Ipc_ProcessMemory_WriteSpan__1_System_ReadOnlySpan___0__System_UIntPtr_System_Int32___"></a> WriteSpan<T\>\(ReadOnlySpan<T\>, nuint, params int\[\]\)

```csharp
public bool WriteSpan<T>(ReadOnlySpan<T> values, nuint baseAddress, params int[] offsets) where T : unmanaged
```

#### Parameters

`values` [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<T\>

`baseAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Type Parameters

`T` 

