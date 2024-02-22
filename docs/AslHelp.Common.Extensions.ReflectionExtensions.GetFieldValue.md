# <a id="AslHelp_Common_Extensions_ReflectionExtensions_GetFieldValue__1_System_Object_System_String_"></a> Method GetFieldValue<T\>

Namespace: [AslHelp.Common.Extensions](AslHelp.Common.Extensions.md)  
Assembly: AslHelp.Common.dll  

## <a id="AslHelp_Common_Extensions_ReflectionExtensions_GetFieldValue__1_System_Object_System_String_"></a> GetFieldValue<T\>\(object, string\)

Gets the value of a field with the specified <code class="paramref">fieldName</code> from the specified object.

```csharp
public static T? GetFieldValue<T>(this object obj, string fieldName)
```

### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)

The instance to get the field value from.

`fieldName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the field to get the value of.

### Returns

 T?

The value of the field with the specified <code class="paramref">fieldName</code> if the field exists;
otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

### Type Parameters

`T` 

The target type of the field.

