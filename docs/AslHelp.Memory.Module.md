# <a id="AslHelp_Memory_Module"></a> Class Module

Namespace: [AslHelp.Memory](AslHelp.Memory.md)  
Assembly: AslHelp.Memory.dll  

Represents an assembly loaded into a process.

```csharp
public sealed class Module
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Module](AslHelp.Memory.Module.md)

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

 [Module\(nuint, string, string, nuint, uint\)](AslHelp.Memory.Module.\-ctor.md\#AslHelp\_Memory\_Module\_\_ctor\_System\_UIntPtr\_System\_String\_System\_String\_System\_UIntPtr\_System\_UInt32\_)

Initializes a new instance of the <xref href="AslHelp.Memory.Module" data-throw-if-not-resolved="false"></xref> class
using the specified process handle, module name, file path, base address, and memory size.

## Properties

 [Base](AslHelp.Memory.Module.Base.md\#AslHelp\_Memory\_Module\_Base)

Gets the memory address where the <xref href="AslHelp.Memory.Module" data-throw-if-not-resolved="false"></xref> is loaded.

 [FileName](AslHelp.Memory.Module.FileName.md\#AslHelp\_Memory\_Module\_FileName)

Gets the fully qualified file path to the <xref href="AslHelp.Memory.Module" data-throw-if-not-resolved="false"></xref>.

 [MemorySize](AslHelp.Memory.Module.MemorySize.md\#AslHelp\_Memory\_Module\_MemorySize)

Gets the amount of memory required to load the <xref href="AslHelp.Memory.Module" data-throw-if-not-resolved="false"></xref>, in bytes.

 [Name](AslHelp.Memory.Module.Name.md\#AslHelp\_Memory\_Module\_Name)

Gets the name of the <xref href="AslHelp.Memory.Module" data-throw-if-not-resolved="false"></xref>.

 [Symbols](AslHelp.Memory.Module.Symbols.md\#AslHelp\_Memory\_Module\_Symbols)

Gets all debug symbols for the <xref href="AslHelp.Memory.Module" data-throw-if-not-resolved="false"></xref>.

 [VersionInfo](AslHelp.Memory.Module.VersionInfo.md\#AslHelp\_Memory\_Module\_VersionInfo)

Gets the version information for the <xref href="AslHelp.Memory.Module" data-throw-if-not-resolved="false"></xref>.

## Methods

 [ToString\(\)](AslHelp.Memory.Module.ToString.md\#AslHelp\_Memory\_Module\_ToString)

Converts the value of this instance to its <xref href="System.String" data-throw-if-not-resolved="false"></xref> representation.

