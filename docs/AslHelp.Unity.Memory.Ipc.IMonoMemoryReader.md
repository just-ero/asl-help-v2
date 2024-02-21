# <a id="AslHelp_Unity_Memory_Ipc_IMonoMemoryReader"></a> Interface IMonoMemoryReader

Namespace: [AslHelp.Unity.Memory.Ipc](AslHelp.Unity.Memory.Ipc.md)  
Assembly: AslHelp.Unity.dll  

```csharp
public interface IMonoMemoryReader : IMemoryReader
```

#### Implements

IMemoryReader

#### Extension Methods

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Methods

### <a id="AslHelp_Unity_Memory_Ipc_IMonoMemoryReader_TryReadArray__1___0____System_UIntPtr_System_Int32___"></a> TryReadArray<T\>\(out T\[\]?, nuint, params int\[\]\)

```csharp
bool TryReadArray<T>(out T[]? results, nuint address, params int[] offsets) where T : unmanaged
```

#### Parameters

`results` T\[\]?

`address` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Type Parameters

`T` 

### <a id="AslHelp_Unity_Memory_Ipc_IMonoMemoryReader_TryReadList__1_System_Collections_Generic_List___0___System_UIntPtr_System_Int32___"></a> TryReadList<T\>\(out List<T\>?, nuint, params int\[\]\)

```csharp
bool TryReadList<T>(out List<T>? results, nuint address, params int[] offsets) where T : unmanaged
```

#### Parameters

`results` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<T\>?

`address` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Type Parameters

`T` 

### <a id="AslHelp_Unity_Memory_Ipc_IMonoMemoryReader_TryReadString_System_String__System_UIntPtr_System_Int32___"></a> TryReadString\(out string?, nuint, params int\[\]\)

```csharp
bool TryReadString(out string? result, nuint address, params int[] offsets)
```

#### Parameters

`result` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`address` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

