# <a id="AslHelp_Memory_Ipc_ProcessMemory_TryDeref_System_UIntPtr__System_UInt32_System_Int32___"></a> Method TryDeref

Namespace: [AslHelp.Memory.Ipc](AslHelp.Memory.Ipc.md)  
Assembly: AslHelp.Memory.dll  

## <a id="AslHelp_Memory_Ipc_ProcessMemory_TryDeref_System_UIntPtr__System_UInt32_System_Int32___"></a> TryDeref\(out nuint, uint, params int\[\]\)

```csharp
public bool TryDeref(out nuint result, uint baseOffset, params int[] offsets)
```

### Parameters

`result` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## <a id="AslHelp_Memory_Ipc_ProcessMemory_TryDeref_System_UIntPtr__System_String_System_UInt32_System_Int32___"></a> TryDeref\(out nuint, string?, uint, params int\[\]\)

```csharp
public bool TryDeref(out nuint result, string? moduleName, uint baseOffset, params int[] offsets)
```

### Parameters

`result` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`moduleName` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## <a id="AslHelp_Memory_Ipc_ProcessMemory_TryDeref_System_UIntPtr__AslHelp_Memory_Module_System_UInt32_System_Int32___"></a> TryDeref\(out nuint, Module?, uint, params int\[\]\)

```csharp
public bool TryDeref(out nuint result, Module? module, uint baseOffset, params int[] offsets)
```

### Parameters

`result` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`module` [Module](AslHelp.Memory.Module.md)?

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## <a id="AslHelp_Memory_Ipc_ProcessMemory_TryDeref_System_UIntPtr__System_UIntPtr_System_Int32___"></a> TryDeref\(out nuint, nuint, params int\[\]\)

```csharp
public bool TryDeref(out nuint result, nuint baseAddress, params int[] offsets)
```

### Parameters

`result` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`baseAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

