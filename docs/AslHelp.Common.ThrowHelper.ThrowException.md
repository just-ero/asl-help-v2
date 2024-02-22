# <a id="AslHelp_Common_ThrowHelper_ThrowException_System_String_"></a> Method ThrowException

Namespace: [AslHelp.Common](AslHelp.Common.md)  
Assembly: AslHelp.Common.dll  

## <a id="AslHelp_Common_ThrowHelper_ThrowException_System_String_"></a> ThrowException\(string\)

Throws an <xref href="System.Exception" data-throw-if-not-resolved="false"></xref> with a specified error message.

```csharp
public static void ThrowException(string message)
```

### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

The error message that explains the reason for the exception.

### Remarks

This method does not return and is not inlined to improve codegen of cold paths.

### Exceptions

 [Exception](https://learn.microsoft.com/dotnet/api/system.exception)

