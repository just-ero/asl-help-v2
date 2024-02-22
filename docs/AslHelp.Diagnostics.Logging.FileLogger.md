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

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetFieldValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetMethod.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetPropertyValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.IsType.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.SetFieldValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.SetPropertyValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Constructors

 [FileLogger\(string, int, int\)](AslHelp.Diagnostics.Logging.FileLogger.\-ctor.md\#AslHelp\_Diagnostics\_Logging\_FileLogger\_\_ctor\_System\_String\_System\_Int32\_System\_Int32\_)

Initializes a new instance of the <xref href="AslHelp.Diagnostics.Logging.FileLogger" data-throw-if-not-resolved="false"></xref> class
with the specified file path, the maximum amount of lines to write to the file
and the amount of lines to erase when the maximum amount of lines is reached.

## Properties

 [FilePath](AslHelp.Diagnostics.Logging.FileLogger.FilePath.md\#AslHelp\_Diagnostics\_Logging\_FileLogger\_FilePath)

Gets the path of the file to write to.

## Methods

 [Log\(\)](AslHelp.Diagnostics.Logging.FileLogger.Log.md\#AslHelp\_Diagnostics\_Logging\_FileLogger\_Log)

Writes an empty line to the log.

 [Log\(object?\)](AslHelp.Diagnostics.Logging.FileLogger.Log.md\#AslHelp\_Diagnostics\_Logging\_FileLogger\_Log\_System\_Object\_)

Writes the string representation of the specified value to the log.

 [Start\(\)](AslHelp.Diagnostics.Logging.FileLogger.Start.md\#AslHelp\_Diagnostics\_Logging\_FileLogger\_Start)

Starts the <xref href="AslHelp.Diagnostics.Logging.FileLogger" data-throw-if-not-resolved="false"></xref>.

 [Stop\(\)](AslHelp.Diagnostics.Logging.FileLogger.Stop.md\#AslHelp\_Diagnostics\_Logging\_FileLogger\_Stop)

Terminates the <xref href="AslHelp.Diagnostics.Logging.FileLogger" data-throw-if-not-resolved="false"></xref>.

