# <a id="AslHelp_Common_ThrowHelper_ThrowInvalidOperationException_System_String_"></a> Method ThrowInvalidOperationException

Namespace: [AslHelp.Common](AslHelp.Common.md)  
Assembly: AslHelp.Common.dll  

## <a id="AslHelp_Common_ThrowHelper_ThrowInvalidOperationException_System_String_"></a> ThrowInvalidOperationException\(string\)

Throws an <xref href="System.InvalidOperationException" data-throw-if-not-resolved="false"></xref> with a specified error message.

```csharp
public static void ThrowInvalidOperationException(string message)
```

### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

The error message that explains the reason for the exception.

### Remarks

This method does not return and is not inlined to improve codegen of cold paths.

### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

