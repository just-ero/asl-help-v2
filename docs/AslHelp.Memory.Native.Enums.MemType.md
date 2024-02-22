# <a id="AslHelp_Memory_Native_Enums_MemType"></a> Enum MemType

Namespace: [AslHelp.Memory.Native.Enums](AslHelp.Memory.Native.Enums.md)  
Assembly: AslHelp.Memory.dll  

Provides memory page type constants.

```csharp
public enum MemType : uint
```

#### Extension Methods

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetFieldValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetMethod.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetPropertyValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.IsType.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.SetFieldValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.SetPropertyValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Fields

`MEM_IMAGE = 16777216` 

Indicates that the memory pages within the region are mapped into the view of an image section.



`MEM_MAPPED = 262144` 

Indicates that the memory pages within the region are mapped into the view of a section.



`MEM_PRIVATE = 131072` 

Indicates that the memory pages within the region are private.



## Remarks

For further information see:
<i><a href="https://docs.microsoft.com/windows/win32/api/winnt/ns-winnt-memory_basic_information#members">MEMORY_BASIC_INFORMATION structure (winnt.h)</a></i>

