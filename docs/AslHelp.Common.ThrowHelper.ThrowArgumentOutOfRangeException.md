# <a id="AslHelp_Common_ThrowHelper_ThrowArgumentOutOfRangeException_System_String_System_String_"></a> Method ThrowArgumentOutOfRangeException

Namespace: [AslHelp.Common](AslHelp.Common.md)  
Assembly: AslHelp.Common.dll  

## <a id="AslHelp_Common_ThrowHelper_ThrowArgumentOutOfRangeException_System_String_System_String_"></a> ThrowArgumentOutOfRangeException\(string, string\)

Throws an <xref href="System.ArgumentOutOfRangeException" data-throw-if-not-resolved="false"></xref> with a specified error message
and the name of the parameter that causes this exception.

```csharp
public static void ThrowArgumentOutOfRangeException(string paramName, string message)
```

### Parameters

`paramName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the parameter that caused the exception.

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

The error message that explains the reason for the exception.

### Remarks

This method does not return and is not inlined to improve codegen of cold paths.

### Exceptions

 [ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception)

