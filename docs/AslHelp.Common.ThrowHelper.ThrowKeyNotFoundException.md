# <a id="AslHelp_Common_ThrowHelper_ThrowKeyNotFoundException_System_String_"></a> Method ThrowKeyNotFoundException

Namespace: [AslHelp.Common](AslHelp.Common.md)  
Assembly: AslHelp.Common.dll  

## <a id="AslHelp_Common_ThrowHelper_ThrowKeyNotFoundException_System_String_"></a> ThrowKeyNotFoundException\(string\)

Throws a <xref href="System.Collections.Generic.KeyNotFoundException" data-throw-if-not-resolved="false"></xref> with a specified error message.

```csharp
public static void ThrowKeyNotFoundException(string message)
```

### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

The error message that explains the reason for the exception.

### Remarks

This method does not return and is not inlined to improve codegen of cold paths.

### Exceptions

 [KeyNotFoundException](https://learn.microsoft.com/dotnet/api/system.collections.generic.keynotfoundexception)

