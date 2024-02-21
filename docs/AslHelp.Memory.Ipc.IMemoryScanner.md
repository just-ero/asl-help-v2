# <a id="AslHelp_Memory_Ipc_IMemoryScanner"></a> Interface IMemoryScanner

Namespace: [AslHelp.Memory.Ipc](AslHelp.Memory.Ipc.md)  
Assembly: AslHelp.Memory.dll  

```csharp
public interface IMemoryScanner
```

#### Extension Methods

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Methods

### <a id="AslHelp_Memory_Ipc_IMemoryScanner_Scan_AslHelp_Memory_Scanning_ScanPattern_System_UIntPtr_System_UIntPtr_"></a> Scan\(ScanPattern, nuint, nuint\)

```csharp
nuint Scan(ScanPattern pattern, nuint startAddress, nuint endAddress)
```

#### Parameters

`pattern` [ScanPattern](AslHelp.Memory.Scanning.ScanPattern.md)

`startAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`endAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

#### Returns

 [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

### <a id="AslHelp_Memory_Ipc_IMemoryScanner_Scan_AslHelp_Memory_Scanning_ScanPattern_System_UIntPtr_System_Int32_"></a> Scan\(ScanPattern, nuint, int\)

```csharp
nuint Scan(ScanPattern pattern, nuint startAddress, int size)
```

#### Parameters

`pattern` [ScanPattern](AslHelp.Memory.Scanning.ScanPattern.md)

`startAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`size` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

### <a id="AslHelp_Memory_Ipc_IMemoryScanner_ScanAll_AslHelp_Memory_Scanning_ScanPattern_System_UIntPtr_System_UIntPtr_"></a> ScanAll\(ScanPattern, nuint, nuint\)

```csharp
IEnumerable<nuint> ScanAll(ScanPattern pattern, nuint startAddress, nuint endAddress)
```

#### Parameters

`pattern` [ScanPattern](AslHelp.Memory.Scanning.ScanPattern.md)

`startAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`endAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)\>

### <a id="AslHelp_Memory_Ipc_IMemoryScanner_ScanAll_AslHelp_Memory_Scanning_ScanPattern_System_UIntPtr_System_Int32_"></a> ScanAll\(ScanPattern, nuint, int\)

```csharp
IEnumerable<nuint> ScanAll(ScanPattern pattern, nuint startAddress, int size)
```

#### Parameters

`pattern` [ScanPattern](AslHelp.Memory.Scanning.ScanPattern.md)

`startAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`size` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)\>

