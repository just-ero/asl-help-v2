# <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_CreateString_System_Int32_System_UInt32_System_Int32___"></a> Method CreateString

Namespace: [AslHelp.Memory.Watch.Initialization](AslHelp.Memory.Watch.Initialization.md)  
Assembly: AslHelp.Memory.dll  

## <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_CreateString_System_Int32_System_UInt32_System_Int32___"></a> CreateString\(int, uint, params int\[\]\)

```csharp
public IWatcher<string> CreateString(int maxLength, uint baseOffset, params int[] offsets)
```

### Parameters

`maxLength` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

## <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_CreateString_System_Int32_System_String_System_UInt32_System_Int32___"></a> CreateString\(int, string, uint, params int\[\]\)

```csharp
public IWatcher<string> CreateString(int maxLength, string moduleName, uint baseOffset, params int[] offsets)
```

### Parameters

`maxLength` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`moduleName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

## <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_CreateString_System_Int32_AslHelp_Memory_Module_System_UInt32_System_Int32___"></a> CreateString\(int, Module, uint, params int\[\]\)

```csharp
public IWatcher<string> CreateString(int maxLength, Module module, uint baseOffset, params int[] offsets)
```

### Parameters

`maxLength` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`module` [Module](AslHelp.Memory.Module.md)

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

## <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_CreateString_System_Int32_System_UIntPtr_System_Int32___"></a> CreateString\(int, nuint, params int\[\]\)

```csharp
public IWatcher<string> CreateString(int maxLength, nuint baseAddress, params int[] offsets)
```

### Parameters

`maxLength` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`baseAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

## <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_CreateString_System_Int32_AslHelp_Memory_StringType_System_UInt32_System_Int32___"></a> CreateString\(int, StringType, uint, params int\[\]\)

```csharp
public IWatcher<string> CreateString(int maxLength, StringType stringType, uint baseOffset, params int[] offsets)
```

### Parameters

`maxLength` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`stringType` [StringType](AslHelp.Memory.StringType.md)

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

## <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_CreateString_System_Int32_AslHelp_Memory_StringType_System_String_System_UInt32_System_Int32___"></a> CreateString\(int, StringType, string, uint, params int\[\]\)

```csharp
public IWatcher<string> CreateString(int maxLength, StringType stringType, string moduleName, uint baseOffset, params int[] offsets)
```

### Parameters

`maxLength` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`stringType` [StringType](AslHelp.Memory.StringType.md)

`moduleName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

## <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_CreateString_System_Int32_AslHelp_Memory_StringType_AslHelp_Memory_Module_System_UInt32_System_Int32___"></a> CreateString\(int, StringType, Module, uint, params int\[\]\)

```csharp
public IWatcher<string> CreateString(int maxLength, StringType stringType, Module module, uint baseOffset, params int[] offsets)
```

### Parameters

`maxLength` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`stringType` [StringType](AslHelp.Memory.StringType.md)

`module` [Module](AslHelp.Memory.Module.md)

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

## <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory_CreateString_System_Int32_AslHelp_Memory_StringType_System_UIntPtr_System_Int32___"></a> CreateString\(int, StringType, nuint, params int\[\]\)

```csharp
public IWatcher<string> CreateString(int maxLength, StringType stringType, nuint baseAddress, params int[] offsets)
```

### Parameters

`maxLength` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`stringType` [StringType](AslHelp.Memory.StringType.md)

`baseAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

### Returns

 [IWatcher](AslHelp.Memory.Watch.IWatcher\-1.md)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

