# <a id="AslHelp_Common_Extensions_ReflectionExtensions"></a> Class ReflectionExtensions

Namespace: [AslHelp.Common.Extensions](AslHelp.Common.Extensions.md)  
Assembly: AslHelp.Common.dll  

The <xref href="AslHelp.Common.Extensions.ReflectionExtensions" data-throw-if-not-resolved="false"></xref> class
provides extension methods for reflection.

```csharp
public static class ReflectionExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ReflectionExtensions](AslHelp.Common.Extensions.ReflectionExtensions.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Properties

### <a id="AslHelp_Common_Extensions_ReflectionExtensions_AssemblyTrace"></a> AssemblyTrace

Gets the assembly that contains the code that called this method.

```csharp
public static IEnumerable<Assembly> AssemblyTrace { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Assembly](https://learn.microsoft.com/dotnet/api/system.reflection.assembly)\>

### <a id="AslHelp_Common_Extensions_ReflectionExtensions_ExecutingAssembly"></a> ExecutingAssembly

Gets the assembly that contains the code that is currently executing.

```csharp
public static Assembly ExecutingAssembly { get; }
```

#### Property Value

 [Assembly](https://learn.microsoft.com/dotnet/api/system.reflection.assembly)

## Methods

### <a id="AslHelp_Common_Extensions_ReflectionExtensions_GetFieldValue__1_System_Object_System_String_"></a> GetFieldValue<T\>\(object, string\)

Gets the value of a field with the specified <code class="paramref">fieldName</code> from the specified object.

```csharp
public static T? GetFieldValue<T>(this object obj, string fieldName)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)

The instance to get the field value from.

`fieldName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the field to get the value of.

#### Returns

 T?

The value of the field with the specified <code class="paramref">fieldName</code> if the field exists;
otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

#### Type Parameters

`T` 

The target type of the field.

### <a id="AslHelp_Common_Extensions_ReflectionExtensions_GetMethod_System_Object_System_String_"></a> GetMethod\(object, string\)

Gets the method with the specified <code class="paramref">methodName</code> from the specified object.

```csharp
public static MethodInfo? GetMethod(this object obj, string methodName)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)

The object to get the method from.

`methodName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the method to get.

#### Returns

 [MethodInfo](https://learn.microsoft.com/dotnet/api/system.reflection.methodinfo)?

The method with the specified <code class="paramref">methodName</code> if the method exists;
otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

### <a id="AslHelp_Common_Extensions_ReflectionExtensions_GetPropertyValue__1_System_Object_System_String_"></a> GetPropertyValue<T\>\(object, string\)

Gets the value of a property with the specified <code class="paramref">propertyName</code> from the specified object.

```csharp
public static T? GetPropertyValue<T>(this object obj, string propertyName)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)

The object to get the property value from.

`propertyName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the property to get the value of.

#### Returns

 T?

The value of the property with the specified <code class="paramref">propertyName</code> if the property exists;
otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

#### Type Parameters

`T` 

The target type of the property.

### <a id="AslHelp_Common_Extensions_ReflectionExtensions_IsType__1_System_Object_"></a> IsType<T\>\(object\)

Determines whether the specified object is of the specified type.

```csharp
public static bool IsType<T>(this object obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)

The object to compare.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the object is of the specified type;
otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

#### Type Parameters

`T` 

The type to compare the object to.

### <a id="AslHelp_Common_Extensions_ReflectionExtensions_SetFieldValue__1_System_Object_System_String___0_"></a> SetFieldValue<T\>\(object, string, T\)

Sets the value of a field with the specified name on the specified object.

```csharp
public static void SetFieldValue<T>(this object obj, string fieldName, T value)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)

The object to set the field value on.

`fieldName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the field to set the value of.

`value` T

The value to set the field to.

#### Type Parameters

`T` 

The target type of the field.

### <a id="AslHelp_Common_Extensions_ReflectionExtensions_SetPropertyValue__1_System_Object_System_String___0_"></a> SetPropertyValue<T\>\(object, string, T\)

Sets the value of a property with the specified <code class="paramref">propertyName</code> on the specified object.

```csharp
public static void SetPropertyValue<T>(this object obj, string propertyName, T value)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)

The object to set the property value on.

`propertyName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the property to set the value of.

`value` T

The value to set the property to.

#### Type Parameters

`T` 

The target type of the property.

