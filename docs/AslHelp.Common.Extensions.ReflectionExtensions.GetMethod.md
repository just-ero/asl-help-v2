# <a id="AslHelp_Common_Extensions_ReflectionExtensions_GetMethod_System_Object_System_String_"></a> Method GetMethod

Namespace: [AslHelp.Common.Extensions](AslHelp.Common.Extensions.md)  
Assembly: AslHelp.Common.dll  

## <a id="AslHelp_Common_Extensions_ReflectionExtensions_GetMethod_System_Object_System_String_"></a> GetMethod\(object, string\)

Gets the method with the specified <code class="paramref">methodName</code> from the specified object.

```csharp
public static MethodInfo? GetMethod(this object obj, string methodName)
```

### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)

The object to get the method from.

`methodName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the method to get.

### Returns

 [MethodInfo](https://learn.microsoft.com/dotnet/api/system.reflection.methodinfo)?

The method with the specified <code class="paramref">methodName</code> if the method exists;
otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

