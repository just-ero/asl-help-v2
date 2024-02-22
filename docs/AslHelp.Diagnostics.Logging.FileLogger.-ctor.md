# <a id="AslHelp_Diagnostics_Logging_FileLogger__ctor_System_String_System_Int32_System_Int32_"></a> Constructor FileLogger

Namespace: [AslHelp.Diagnostics.Logging](AslHelp.Diagnostics.Logging.md)  
Assembly: AslHelp.Diagnostics.dll  

## <a id="AslHelp_Diagnostics_Logging_FileLogger__ctor_System_String_System_Int32_System_Int32_"></a> FileLogger\(string, int, int\)

Initializes a new instance of the <xref href="AslHelp.Diagnostics.Logging.FileLogger" data-throw-if-not-resolved="false"></xref> class
with the specified file path, the maximum amount of lines to write to the file
and the amount of lines to erase when the maximum amount of lines is reached.

```csharp
public FileLogger(string fileName, int maximumLines, int linesToErase)
```

### Parameters

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The path of the file to write to.

`maximumLines` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The maximum amount of lines to write to the file.

`linesToErase` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The amount of lines to erase when the maximum amount of lines is reached.

