# <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory"></a> Class WatcherFactory

Namespace: [AslHelp.Memory.Watch.Initialization](AslHelp.Memory.Watch.Initialization.md)  
Assembly: AslHelp.Memory.dll  

```csharp
public sealed class WatcherFactory : Dictionary<string, IWatcher>, IDictionary<string, IWatcher>, ICollection<KeyValuePair<string, IWatcher>>, IReadOnlyDictionary<string, IWatcher>, IReadOnlyCollection<KeyValuePair<string, IWatcher>>, IEnumerable<KeyValuePair<string, IWatcher>>, IDictionary, ICollection, IEnumerable, IDeserializationCallback, ISerializable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Dictionary<string, IWatcher\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2) ← 
[WatcherFactory](AslHelp.Memory.Watch.Initialization.WatcherFactory.md)

#### Implements

[IDictionary<string, IWatcher\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.idictionary\-2), 
[ICollection<KeyValuePair<string, IWatcher\>\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1), 
[IReadOnlyDictionary<string, IWatcher\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlydictionary\-2), 
[IReadOnlyCollection<KeyValuePair<string, IWatcher\>\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection\-1), 
[IEnumerable<KeyValuePair<string, IWatcher\>\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IDictionary](https://learn.microsoft.com/dotnet/api/system.collections.idictionary), 
[ICollection](https://learn.microsoft.com/dotnet/api/system.collections.icollection), 
[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable), 
[IDeserializationCallback](https://learn.microsoft.com/dotnet/api/system.runtime.serialization.ideserializationcallback), 
[ISerializable](https://learn.microsoft.com/dotnet/api/system.runtime.serialization.iserializable)

#### Inherited Members

[Dictionary<string, IWatcher\>.Add\(string, IWatcher\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.add), 
[Dictionary<string, IWatcher\>.Clear\(\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.clear), 
[Dictionary<string, IWatcher\>.ContainsKey\(string\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.containskey), 
[Dictionary<string, IWatcher\>.ContainsValue\(IWatcher\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.containsvalue), 
[Dictionary<string, IWatcher\>.GetEnumerator\(\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.getenumerator), 
[Dictionary<string, IWatcher\>.GetObjectData\(SerializationInfo, StreamingContext\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.getobjectdata), 
[Dictionary<string, IWatcher\>.OnDeserialization\(object\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.ondeserialization), 
[Dictionary<string, IWatcher\>.Remove\(string\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.remove), 
[Dictionary<string, IWatcher\>.TryGetValue\(string, out IWatcher\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.trygetvalue), 
[Dictionary<string, IWatcher\>.Comparer](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.comparer), 
[Dictionary<string, IWatcher\>.Count](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.count), 
[Dictionary<string, IWatcher\>.this\[string\]](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.item), 
[Dictionary<string, IWatcher\>.Keys](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.keys), 
[Dictionary<string, IWatcher\>.Values](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.values), 
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

### <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory__ctor_AslHelp_Memory_Ipc_IProcessMemory_"></a> WatcherFactory\(IProcessMemory\)

```csharp
public WatcherFactory(IProcessMemory memory)
```

#### Parameters

`memory` [IProcessMemory](AslHelp.Memory.Ipc.IProcessMemory.md)

## Methods

### <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_Create__1_System_UInt32_System_Int32___"></a> Create<T\>\(uint, params int\[\]\)

```csharp
public IWatcher<T> Create<T>(uint baseOffset, params int[] offsets) where T : unmanaged
```

#### Parameters

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<T\>

#### Type Parameters

`T` 

### <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_Create__1_System_String_System_UInt32_System_Int32___"></a> Create<T\>\(string, uint, params int\[\]\)

```csharp
public IWatcher<T> Create<T>(string moduleName, uint baseOffset, params int[] offsets) where T : unmanaged
```

#### Parameters

`moduleName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<T\>

#### Type Parameters

`T` 

### <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_Create__1_AslHelp_Memory_Module_System_UInt32_System_Int32___"></a> Create<T\>\(Module, uint, params int\[\]\)

```csharp
public IWatcher<T> Create<T>(Module module, uint baseOffset, params int[] offsets) where T : unmanaged
```

#### Parameters

`module` [Module](AslHelp.Memory.Module.md)

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<T\>

#### Type Parameters

`T` 

### <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_Create__1_System_UIntPtr_System_Int32___"></a> Create<T\>\(nuint, params int\[\]\)

```csharp
public IWatcher<T> Create<T>(nuint baseAddress, params int[] offsets) where T : unmanaged
```

#### Parameters

`baseAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<T\>

#### Type Parameters

`T` 

### <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_CreateSpan__1_System_Int32_System_UInt32_System_Int32___"></a> CreateSpan<T\>\(int, uint, params int\[\]\)

```csharp
public IWatcher<T[]> CreateSpan<T>(int length, uint baseOffset, params int[] offsets) where T : unmanaged
```

#### Parameters

`length` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<T\[\]\>

#### Type Parameters

`T` 

### <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_CreateSpan__1_System_Int32_System_String_System_UInt32_System_Int32___"></a> CreateSpan<T\>\(int, string, uint, params int\[\]\)

```csharp
public IWatcher<T[]> CreateSpan<T>(int length, string moduleName, uint baseOffset, params int[] offsets) where T : unmanaged
```

#### Parameters

`length` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`moduleName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<T\[\]\>

#### Type Parameters

`T` 

### <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_CreateSpan__1_System_Int32_AslHelp_Memory_Module_System_UInt32_System_Int32___"></a> CreateSpan<T\>\(int, Module, uint, params int\[\]\)

```csharp
public IWatcher<T[]> CreateSpan<T>(int length, Module module, uint baseOffset, params int[] offsets) where T : unmanaged
```

#### Parameters

`length` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`module` [Module](AslHelp.Memory.Module.md)

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<T\[\]\>

#### Type Parameters

`T` 

### <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_CreateSpan__1_System_Int32_System_UIntPtr_System_Int32___"></a> CreateSpan<T\>\(int, nuint, params int\[\]\)

```csharp
public IWatcher<T[]> CreateSpan<T>(int length, nuint baseAddress, params int[] offsets) where T : unmanaged
```

#### Parameters

`length` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`baseAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<T\[\]\>

#### Type Parameters

`T` 

### <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_CreateString_System_Int32_System_UInt32_System_Int32___"></a> CreateString\(int, uint, params int\[\]\)

```csharp
public IWatcher<string> CreateString(int maxLength, uint baseOffset, params int[] offsets)
```

#### Parameters

`maxLength` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_CreateString_System_Int32_System_String_System_UInt32_System_Int32___"></a> CreateString\(int, string, uint, params int\[\]\)

```csharp
public IWatcher<string> CreateString(int maxLength, string moduleName, uint baseOffset, params int[] offsets)
```

#### Parameters

`maxLength` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`moduleName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_CreateString_System_Int32_AslHelp_Memory_Module_System_UInt32_System_Int32___"></a> CreateString\(int, Module, uint, params int\[\]\)

```csharp
public IWatcher<string> CreateString(int maxLength, Module module, uint baseOffset, params int[] offsets)
```

#### Parameters

`maxLength` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`module` [Module](AslHelp.Memory.Module.md)

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_CreateString_System_Int32_System_UIntPtr_System_Int32___"></a> CreateString\(int, nuint, params int\[\]\)

```csharp
public IWatcher<string> CreateString(int maxLength, nuint baseAddress, params int[] offsets)
```

#### Parameters

`maxLength` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`baseAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_CreateString_System_Int32_AslHelp_Memory_StringType_System_UInt32_System_Int32___"></a> CreateString\(int, StringType, uint, params int\[\]\)

```csharp
public IWatcher<string> CreateString(int maxLength, StringType stringType, uint baseOffset, params int[] offsets)
```

#### Parameters

`maxLength` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`stringType` [StringType](AslHelp.Memory.StringType.md)

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_CreateString_System_Int32_AslHelp_Memory_StringType_System_String_System_UInt32_System_Int32___"></a> CreateString\(int, StringType, string, uint, params int\[\]\)

```csharp
public IWatcher<string> CreateString(int maxLength, StringType stringType, string moduleName, uint baseOffset, params int[] offsets)
```

#### Parameters

`maxLength` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`stringType` [StringType](AslHelp.Memory.StringType.md)

`moduleName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_CreateString_System_Int32_AslHelp_Memory_StringType_AslHelp_Memory_Module_System_UInt32_System_Int32___"></a> CreateString\(int, StringType, Module, uint, params int\[\]\)

```csharp
public IWatcher<string> CreateString(int maxLength, StringType stringType, Module module, uint baseOffset, params int[] offsets)
```

#### Parameters

`maxLength` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`stringType` [StringType](AslHelp.Memory.StringType.md)

`module` [Module](AslHelp.Memory.Module.md)

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_CreateString_System_Int32_AslHelp_Memory_StringType_System_UIntPtr_System_Int32___"></a> CreateString\(int, StringType, nuint, params int\[\]\)

```csharp
public IWatcher<string> CreateString(int maxLength, StringType stringType, nuint baseAddress, params int[] offsets)
```

#### Parameters

`maxLength` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`stringType` [StringType](AslHelp.Memory.StringType.md)

`baseAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

#### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_MapTo_System_Collections_Generic_IDictionary_System_String_System_Object__"></a> MapTo\(IDictionary<string, object?\>\)

```csharp
public void MapTo(IDictionary<string, object?> destination)
```

#### Parameters

`destination` [IDictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.idictionary\-2)<[string](https://learn.microsoft.com/dotnet/api/system.string), [object](https://learn.microsoft.com/dotnet/api/system.object)?\>

