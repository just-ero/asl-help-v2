# <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_CreateSpan__1_System_Int32_System_UInt32_System_Int32___"></a> Method CreateSpan<T\>

Namespace: [AslHelp.Memory.Watch.Initialization](AslHelp.Memory.Watch.Initialization.md)  
Assembly: AslHelp.Memory.dll  

## <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_CreateSpan__1_System_Int32_System_UInt32_System_Int32___"></a> CreateSpan<T\>\(int, uint, params int\[\]\)

```csharp
public IWatcher<T[]> CreateSpan<T>(int length, uint baseOffset, params int[] offsets) where T : unmanaged
```

### Parameters

`length` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<T\[\]\>

### Type Parameters

`T` 

## <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_CreateSpan__1_System_Int32_System_String_System_UInt32_System_Int32___"></a> CreateSpan<T\>\(int, string, uint, params int\[\]\)

```csharp
public IWatcher<T[]> CreateSpan<T>(int length, string moduleName, uint baseOffset, params int[] offsets) where T : unmanaged
```

### Parameters

`length` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`moduleName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<T\[\]\>

### Type Parameters

`T` 

## <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_CreateSpan__1_System_Int32_AslHelp_Memory_Module_System_UInt32_System_Int32___"></a> CreateSpan<T\>\(int, Module, uint, params int\[\]\)

```csharp
public IWatcher<T[]> CreateSpan<T>(int length, Module module, uint baseOffset, params int[] offsets) where T : unmanaged
```

### Parameters

`length` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`module` [Module](AslHelp.Memory.Module.md)

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<T\[\]\>

### Type Parameters

`T` 

## <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_CreateSpan__1_System_Int32_System_UIntPtr_System_Int32___"></a> CreateSpan<T\>\(int, nuint, params int\[\]\)

```csharp
public IWatcher<T[]> CreateSpan<T>(int length, nuint baseAddress, params int[] offsets) where T : unmanaged
```

### Parameters

`length` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`baseAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<T\[\]\>

### Type Parameters

`T` 

