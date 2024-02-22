# <a id="AslHelp_Common_ThrowHelper_ThrowFileNotFoundException_System_String_"></a> Method ThrowFileNotFoundException

Namespace: [AslHelp.Common](AslHelp.Common.md)  
Assembly: AslHelp.Common.dll  

## <a id="AslHelp_Common_ThrowHelper_ThrowFileNotFoundException_System_String_"></a> ThrowFileNotFoundException\(string\)

Throws a <xref href="System.IO.FileNotFoundException" data-throw-if-not-resolved="false"></xref> with a specified error message.

```csharp
public static void ThrowFileNotFoundException(string message)
```

### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

The error message that explains the reason for the exception.

### Remarks

This method does not return and is not inlined to improve codegen of cold paths.

### Exceptions

 [FileNotFoundException](https://learn.microsoft.com/dotnet/api/system.io.filenotfoundexception)

