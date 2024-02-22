# <a id="AslHelp_Memory_Native_Enums_MemProtect"></a> Enum MemProtect

Namespace: [AslHelp.Memory.Native.Enums](AslHelp.Memory.Native.Enums.md)  
Assembly: AslHelp.Memory.dll  

Provides memory-protection constants.

```csharp
public enum MemProtect : uint
```

#### Extension Methods

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetFieldValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetMethod.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetPropertyValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.IsType.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.SetFieldValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.SetPropertyValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Fields

`PAGE_EXECUTE = 16` 

Enables execute access to the committed region of pages.



`PAGE_EXECUTE_READ = 32` 

Enables execute or read-only access to the committed region of pages.



`PAGE_EXECUTE_READWRITE = 64` 

Enables execute, read-only, or read/write access to the committed region of pages.



`PAGE_EXECUTE_WRITECOPY = 128` 

Enables execute, read-only, or copy-on-write access to a mapped view of a file mapping object.



`PAGE_GUARD = 256` 

Pages in the region become guard pages.



`PAGE_NOACCESS = 1` 

Disables all access to the committed region of pages.



`PAGE_NOCACHE = 512` 

Sets all pages to be non-cachable.



`PAGE_READONLY = 2` 

Enables read-only access to the committed region of pages.



`PAGE_READWRITE = 4` 

Enables read-only or read/write access to the committed region of pages.



`PAGE_WRITECOMBINE = 1024` 

Sets all pages to be write-combined.



`PAGE_WRITECOPY = 8` 

Enables read-only or copy-on-write access to a mapped view of a file mapping object.



## Remarks

For further information see:
<i><a href="https://docs.microsoft.com/windows/win32/memory/memory-protection-constants#constants">Memory Protection Constants</a></i>

