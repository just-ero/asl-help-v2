# <a id="AslHelp_Common_Extensions_ReflectionExtensions_GetPropertyValue__1_System_Object_System_String_"></a> Method GetPropertyValue<T\>

Namespace: [AslHelp.Common.Extensions](AslHelp.Common.Extensions.md)  
Assembly: AslHelp.Common.dll  

## <a id="AslHelp_Common_Extensions_ReflectionExtensions_GetPropertyValue__1_System_Object_System_String_"></a> GetPropertyValue<T\>\(object, string\)

Gets the value of a property with the specified <code class="paramref">propertyName</code> from the specified object.

```csharp
public static T? GetPropertyValue<T>(this object obj, string propertyName)
```

### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)

The object to get the property value from.

`propertyName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the property to get the value of.

### Returns

 T?

The value of the property with the specified <code class="paramref">propertyName</code> if the property exists;
otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

### Type Parameters

`T` 

The target type of the property.

