# <a id="AslHelp_Diagnostics_Logging_FileLogger"></a> Class FileLogger

Namespace: [AslHelp.Diagnostics.Logging](AslHelp.Diagnostics.Logging.md)  
Assembly: AslHelp.Diagnostics.dll  

The <xref href="AslHelp.Diagnostics.Logging.FileLogger" data-throw-if-not-resolved="false"></xref> class
provides a logger that writes to a specified file.

```csharp
public sealed class FileLogger : ILogger
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[FileLogger](AslHelp.Diagnostics.Logging.FileLogger.md)

#### Implements

[ILogger](AslHelp.Diagnostics.Logging.ILogger.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Constructors

### <a id="AslHelp_Diagnostics_Logging_FileLogger__ctor_System_String_System_Int32_System_Int32_"></a> FileLogger\(string, int, int\)

Initializes a new instance of the <xref href="AslHelp.Diagnostics.Logging.FileLogger" data-throw-if-not-resolved="false"></xref> class
with the specified file path, the maximum amount of lines to write to the file
and the amount of lines to erase when the maximum amount of lines is reached.

```csharp
public FileLogger(string fileName, int maximumLines, int linesToErase)
```

#### Parameters

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The path of the file to write to.

`maximumLines` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The maximum amount of lines to write to the file.

`linesToErase` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The amount of lines to erase when the maximum amount of lines is reached.

## Properties

### <a id="AslHelp_Diagnostics_Logging_FileLogger_FilePath"></a> FilePath

Gets the path of the file to write to.

```csharp
public string FilePath { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="AslHelp_Diagnostics_Logging_FileLogger_Log"></a> Log\(\)

Writes an empty line to the log.

```csharp
public void Log()
```

### <a id="AslHelp_Diagnostics_Logging_FileLogger_Log_System_Object_"></a> Log\(object?\)

Writes the string representation of the specified value to the log.

```csharp
public void Log(object? output)
```

#### Parameters

`output` [object](https://learn.microsoft.com/dotnet/api/system.object)?

The value to log.

### <a id="AslHelp_Diagnostics_Logging_FileLogger_Start"></a> Start\(\)

Starts the <xref href="AslHelp.Diagnostics.Logging.FileLogger" data-throw-if-not-resolved="false"></xref>.

```csharp
public void Start()
```

### <a id="AslHelp_Diagnostics_Logging_FileLogger_Stop"></a> Stop\(\)

Terminates the <xref href="AslHelp.Diagnostics.Logging.FileLogger" data-throw-if-not-resolved="false"></xref>.

```csharp
public void Stop()
```

