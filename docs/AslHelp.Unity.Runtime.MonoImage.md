# <a id="AslHelp_Unity_Runtime_MonoImage"></a> Class MonoImage

Namespace: [AslHelp.Unity.Runtime](AslHelp.Unity.Runtime.md)  
Assembly: AslHelp.Unity.dll  

```csharp
public sealed class MonoImage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MonoImage](AslHelp.Unity.Runtime.MonoImage.md)

#### Inherited Members

[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype)

#### Extension Methods

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Constructors

### <a id="AslHelp_Unity_Runtime_MonoImage__ctor_System_UIntPtr_AslHelp_Unity_Runtime_Interop_MonoOperator_"></a> MonoImage\(nuint, MonoOperator\)

```csharp
public MonoImage(nuint address, MonoOperator mono)
```

#### Parameters

`address` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`mono` [MonoOperator](AslHelp.Unity.Runtime.Interop.MonoOperator.md)

## Properties

### <a id="AslHelp_Unity_Runtime_MonoImage_Address"></a> Address

```csharp
public nuint Address { get; }
```

#### Property Value

 [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

### <a id="AslHelp_Unity_Runtime_MonoImage_Classes"></a> Classes

```csharp
public KeyedCollection<string, MonoClass> Classes { get; }
```

#### Property Value

 KeyedCollection<[string](https://learn.microsoft.com/dotnet/api/system.string), [MonoClass](AslHelp.Unity.Runtime.MonoClass.md)\>

### <a id="AslHelp_Unity_Runtime_MonoImage_FileName"></a> FileName

```csharp
public string? FileName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="AslHelp_Unity_Runtime_MonoImage_Name"></a> Name

```csharp
public string? Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

## Methods

### <a id="AslHelp_Unity_Runtime_MonoImage_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

