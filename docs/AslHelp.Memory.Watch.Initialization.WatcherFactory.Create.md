# <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_Create__1_System_UInt32_System_Int32___"></a> Method Create<T\>

Namespace: [AslHelp.Memory.Watch.Initialization](AslHelp.Memory.Watch.Initialization.md)  
Assembly: AslHelp.Memory.dll  

## <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_Create__1_System_UInt32_System_Int32___"></a> Create<T\>\(uint, params int\[\]\)

```csharp
public IWatcher<T> Create<T>(uint baseOffset, params int[] offsets) where T : unmanaged
```

### Parameters

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<T\>

### Type Parameters

`T` 

## <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_Create__1_System_String_System_UInt32_System_Int32___"></a> Create<T\>\(string, uint, params int\[\]\)

```csharp
public IWatcher<T> Create<T>(string moduleName, uint baseOffset, params int[] offsets) where T : unmanaged
```

### Parameters

`moduleName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<T\>

### Type Parameters

`T` 

## <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_Create__1_AslHelp_Memory_Module_System_UInt32_System_Int32___"></a> Create<T\>\(Module, uint, params int\[\]\)

```csharp
public IWatcher<T> Create<T>(Module module, uint baseOffset, params int[] offsets) where T : unmanaged
```

### Parameters

`module` [Module](AslHelp.Memory.Module.md)

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<T\>

### Type Parameters

`T` 

## <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_Create__1_System_UIntPtr_System_Int32___"></a> Create<T\>\(nuint, params int\[\]\)

```csharp
public IWatcher<T> Create<T>(nuint baseAddress, params int[] offsets) where T : unmanaged
```

### Parameters

`baseAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<T\>

### Type Parameters

`T` 

