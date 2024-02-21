# <a id="AslHelp_Memory_Ipc_IMemoryReader"></a> Interface IMemoryReader

Namespace: [AslHelp.Memory.Ipc](AslHelp.Memory.Ipc.md)  
Assembly: AslHelp.Memory.dll  

```csharp
public interface IMemoryReader
```

#### Extension Methods

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Methods

### <a id="AslHelp_Memory_Ipc_IMemoryReader_Deref_System_UInt32_System_Int32___"></a> Deref\(uint, params int\[\]\)

```csharp
nuint Deref(uint baseOffset, params int[] offsets)
```

#### Parameters

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

### <a id="AslHelp_Memory_Ipc_IMemoryReader_Deref_System_String_System_UInt32_System_Int32___"></a> Deref\(string, uint, params int\[\]\)

```csharp
nuint Deref(string moduleName, uint baseOffset, params int[] offsets)
```

#### Parameters

`moduleName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

### <a id="AslHelp_Memory_Ipc_IMemoryReader_Deref_AslHelp_Memory_Module_System_UInt32_System_Int32___"></a> Deref\(Module, uint, params int\[\]\)

```csharp
nuint Deref(Module module, uint baseOffset, params int[] offsets)
```

#### Parameters

`module` [Module](AslHelp.Memory.Module.md)

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

### <a id="AslHelp_Memory_Ipc_IMemoryReader_Deref_System_UIntPtr_System_Int32___"></a> Deref\(nuint, params int\[\]\)

```csharp
nuint Deref(nuint baseAddress, params int[] offsets)
```

#### Parameters

`baseAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

### <a id="AslHelp_Memory_Ipc_IMemoryReader_TryDeref_System_UIntPtr__System_UInt32_System_Int32___"></a> TryDeref\(out nuint, uint, params int\[\]\)

```csharp
bool TryDeref(out nuint result, uint baseOffset, params int[] offsets)
```

#### Parameters

`result` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Memory_Ipc_IMemoryReader_TryDeref_System_UIntPtr__System_String_System_UInt32_System_Int32___"></a> TryDeref\(out nuint, string?, uint, params int\[\]\)

```csharp
bool TryDeref(out nuint result, string? moduleName, uint baseOffset, params int[] offsets)
```

#### Parameters

`result` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`moduleName` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Memory_Ipc_IMemoryReader_TryDeref_System_UIntPtr__AslHelp_Memory_Module_System_UInt32_System_Int32___"></a> TryDeref\(out nuint, Module?, uint, params int\[\]\)

```csharp
bool TryDeref(out nuint result, Module? module, uint baseOffset, params int[] offsets)
```

#### Parameters

`result` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`module` [Module](AslHelp.Memory.Module.md)?

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Memory_Ipc_IMemoryReader_TryDeref_System_UIntPtr__System_UIntPtr_System_Int32___"></a> TryDeref\(out nuint, nuint, params int\[\]\)

```csharp
bool TryDeref(out nuint result, nuint baseAddress, params int[] offsets)
```

#### Parameters

`result` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`baseAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Memory_Ipc_IMemoryReader_TryRead__1___0__System_UIntPtr_System_Int32___"></a> TryRead<T\>\(out T, nuint, params int\[\]\)

```csharp
bool TryRead<T>(out T result, nuint baseAddress, params int[] offsets) where T : unmanaged
```

#### Parameters

`result` T

`baseAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Type Parameters

`T` 

### <a id="AslHelp_Memory_Ipc_IMemoryReader_TryReadSpan__1_System_Span___0__System_UIntPtr_System_Int32___"></a> TryReadSpan<T\>\(Span<T\>, nuint, params int\[\]\)

```csharp
bool TryReadSpan<T>(Span<T> buffer, nuint baseAddress, params int[] offsets) where T : unmanaged
```

#### Parameters

`buffer` [Span](https://learn.microsoft.com/dotnet/api/system.span\-1)<T\>

`baseAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Type Parameters

`T` 

### <a id="AslHelp_Memory_Ipc_IMemoryReader_TryReadString_System_String__System_Int32_AslHelp_Memory_StringType_System_UIntPtr_System_Int32___"></a> TryReadString\(out string?, int, StringType, nuint, params int\[\]\)

```csharp
bool TryReadString(out string? result, int maxLength, StringType stringType, nuint baseAddress, params int[] offsets)
```

#### Parameters

`result` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`maxLength` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`stringType` [StringType](AslHelp.Memory.StringType.md)

`baseAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

