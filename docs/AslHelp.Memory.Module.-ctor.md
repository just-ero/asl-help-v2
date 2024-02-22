# <a id="AslHelp_Memory_Module__ctor_System_UIntPtr_System_String_System_String_System_UIntPtr_System_UInt32_"></a> Constructor Module

Namespace: [AslHelp.Memory](AslHelp.Memory.md)  
Assembly: AslHelp.Memory.dll  

## <a id="AslHelp_Memory_Module__ctor_System_UIntPtr_System_String_System_String_System_UIntPtr_System_UInt32_"></a> Module\(nuint, string, string, nuint, uint\)

Initializes a new instance of the <xref href="AslHelp.Memory.Module" data-throw-if-not-resolved="false"></xref> class
using the specified process handle, module name, file path, base address, and memory size.

```csharp
public Module(nuint processHandle, string name, string fileName, nuint @base, uint memorySize)
```

### Parameters

`processHandle` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

The handle of the <xref href="System.Diagnostics.Process" data-throw-if-not-resolved="false"></xref> containing the module.

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the module.

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The fully qualified file path to the module.

`base` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

The memory address where the module is loaded.

`memorySize` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

The amount of memory required to load the module, in bytes.

