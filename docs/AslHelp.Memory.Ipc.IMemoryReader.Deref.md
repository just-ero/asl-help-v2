# <a id="AslHelp_Memory_Ipc_IMemoryReader_Deref_System_UInt32_System_Int32___"></a> Method Deref

Namespace: [AslHelp.Memory.Ipc](AslHelp.Memory.Ipc.md)  
Assembly: AslHelp.Memory.dll  

## <a id="AslHelp_Memory_Ipc_IMemoryReader_Deref_System_UInt32_System_Int32___"></a> Deref\(uint, params int\[\]\)

```csharp
nuint Deref(uint baseOffset, params int[] offsets)
```

### Parameters

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

### Returns

 [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

## <a id="AslHelp_Memory_Ipc_IMemoryReader_Deref_System_String_System_UInt32_System_Int32___"></a> Deref\(string, uint, params int\[\]\)

```csharp
nuint Deref(string moduleName, uint baseOffset, params int[] offsets)
```

### Parameters

`moduleName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

### Returns

 [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

## <a id="AslHelp_Memory_Ipc_IMemoryReader_Deref_AslHelp_Memory_Module_System_UInt32_System_Int32___"></a> Deref\(Module, uint, params int\[\]\)

```csharp
nuint Deref(Module module, uint baseOffset, params int[] offsets)
```

### Parameters

`module` [Module](AslHelp.Memory.Module.md)

`baseOffset` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

### Returns

 [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

## <a id="AslHelp_Memory_Ipc_IMemoryReader_Deref_System_UIntPtr_System_Int32___"></a> Deref\(nuint, params int\[\]\)

```csharp
nuint Deref(nuint baseAddress, params int[] offsets)
```

### Parameters

`baseAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

### Returns

 [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

