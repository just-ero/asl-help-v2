# <a id="AslHelp_Common_ThrowHelper_ThrowFormatException_System_String_"></a> Method ThrowFormatException

Namespace: [AslHelp.Common](AslHelp.Common.md)  
Assembly: AslHelp.Common.dll  

## <a id="AslHelp_Common_ThrowHelper_ThrowFormatException_System_String_"></a> ThrowFormatException\(string\)

Throws a <xref href="System.FormatException" data-throw-if-not-resolved="false"></xref> with a specified error message.

```csharp
public static void ThrowFormatException(string message)
```

### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

The error message that explains the reason for the exception.

### Remarks

This method does not return and is not inlined to improve codegen of cold paths.

### Exceptions

 [FormatException](https://learn.microsoft.com/dotnet/api/system.formatexception)

