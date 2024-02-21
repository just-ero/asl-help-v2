# <a id="AslHelp_Memory_Scanning_ScanPattern"></a> Struct ScanPattern

Namespace: [AslHelp.Memory.Scanning](AslHelp.Memory.Scanning.md)  
Assembly: AslHelp.Memory.dll  

```csharp
public readonly struct ScanPattern
```

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

### <a id="AslHelp_Memory_Scanning_ScanPattern__ctor_System_String___"></a> ScanPattern\(params string\[\]\)

```csharp
public ScanPattern(params string[] pattern)
```

#### Parameters

`pattern` [string](https://learn.microsoft.com/dotnet/api/system.string)\[\]

### <a id="AslHelp_Memory_Scanning_ScanPattern__ctor_System_Int32_System_String___"></a> ScanPattern\(int, params string\[\]\)

```csharp
public ScanPattern(int scanOffset, params string[] pattern)
```

#### Parameters

`scanOffset` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`pattern` [string](https://learn.microsoft.com/dotnet/api/system.string)\[\]

### <a id="AslHelp_Memory_Scanning_ScanPattern__ctor_System_Byte___"></a> ScanPattern\(params byte\[\]\)

```csharp
public ScanPattern(params byte[] pattern)
```

#### Parameters

`pattern` [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

### <a id="AslHelp_Memory_Scanning_ScanPattern__ctor_System_Int32_System_Byte___"></a> ScanPattern\(int, params byte\[\]\)

```csharp
public ScanPattern(int scanOffset, params byte[] pattern)
```

#### Parameters

`scanOffset` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`pattern` [byte](https://learn.microsoft.com/dotnet/api/system.byte)\[\]

## Properties

### <a id="AslHelp_Memory_Scanning_ScanPattern_Masks"></a> Masks

```csharp
public ulong[] Masks { get; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\[\]

### <a id="AslHelp_Memory_Scanning_ScanPattern_Offset"></a> Offset

```csharp
public int Offset { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="AslHelp_Memory_Scanning_ScanPattern_Values"></a> Values

```csharp
public ulong[] Values { get; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\[\]

