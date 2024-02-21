# <a id="AslHelp_Unity_Runtime_MonoType"></a> Class MonoType

Namespace: [AslHelp.Unity.Runtime](AslHelp.Unity.Runtime.md)  
Assembly: AslHelp.Unity.dll  

```csharp
public sealed class MonoType
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MonoType](AslHelp.Unity.Runtime.MonoType.md)

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

### <a id="AslHelp_Unity_Runtime_MonoType__ctor_System_UIntPtr_AslHelp_Unity_Runtime_Interop_MonoOperator_"></a> MonoType\(nuint, MonoOperator\)

```csharp
public MonoType(nuint address, MonoOperator mono)
```

#### Parameters

`address` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`mono` [MonoOperator](AslHelp.Unity.Runtime.Interop.MonoOperator.md)

## Properties

### <a id="AslHelp_Unity_Runtime_MonoType_Address"></a> Address

```csharp
public nuint Address { get; }
```

#### Property Value

 [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

### <a id="AslHelp_Unity_Runtime_MonoType_Attributes"></a> Attributes

```csharp
public MonoFieldAttribute? Attributes { get; }
```

#### Property Value

 [MonoFieldAttribute](AslHelp.Unity.Runtime.Interop.MonoFieldAttribute.md)?

### <a id="AslHelp_Unity_Runtime_MonoType_Class"></a> Class

```csharp
public MonoClass? Class { get; }
```

#### Property Value

 [MonoClass](AslHelp.Unity.Runtime.MonoClass.md)?

### <a id="AslHelp_Unity_Runtime_MonoType_ElementType"></a> ElementType

```csharp
public MonoElementType? ElementType { get; }
```

#### Property Value

 [MonoElementType](AslHelp.Unity.Runtime.Interop.MonoElementType.md)?

## Methods

### <a id="AslHelp_Unity_Runtime_MonoType_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

