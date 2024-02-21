# <a id="AslHelp_Memory_MemoryPage"></a> Struct MemoryPage

Namespace: [AslHelp.Memory](AslHelp.Memory.md)  
Assembly: AslHelp.Memory.dll  

```csharp
public readonly record struct MemoryPage : IEquatable<MemoryPage>
```

#### Implements

[IEquatable<MemoryPage\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

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

### <a id="AslHelp_Memory_MemoryPage__ctor_System_UIntPtr_System_UInt32_AslHelp_Memory_Native_Enums_MemProtect_AslHelp_Memory_Native_Enums_MemState_AslHelp_Memory_Native_Enums_MemType_"></a> MemoryPage\(nuint, uint, MemProtect, MemState, MemType\)

```csharp
public MemoryPage(nuint @base, uint regionSize, MemProtect protect, MemState state, MemType type)
```

#### Parameters

`base` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`regionSize` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

`protect` [MemProtect](AslHelp.Memory.Native.Enums.MemProtect.md)

`state` [MemState](AslHelp.Memory.Native.Enums.MemState.md)

`type` [MemType](AslHelp.Memory.Native.Enums.MemType.md)

## Properties

### <a id="AslHelp_Memory_MemoryPage_Base"></a> Base

```csharp
public nuint Base { get; }
```

#### Property Value

 [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

### <a id="AslHelp_Memory_MemoryPage_Protect"></a> Protect

```csharp
public MemProtect Protect { get; }
```

#### Property Value

 [MemProtect](AslHelp.Memory.Native.Enums.MemProtect.md)

### <a id="AslHelp_Memory_MemoryPage_RegionSize"></a> RegionSize

```csharp
public uint RegionSize { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="AslHelp_Memory_MemoryPage_State"></a> State

```csharp
public MemState State { get; }
```

#### Property Value

 [MemState](AslHelp.Memory.Native.Enums.MemState.md)

### <a id="AslHelp_Memory_MemoryPage_Type"></a> Type

```csharp
public MemType Type { get; }
```

#### Property Value

 [MemType](AslHelp.Memory.Native.Enums.MemType.md)

## Methods

### <a id="AslHelp_Memory_MemoryPage_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

