# <a id="AslHelp_Memory_Native_Enums_MemState"></a> Enum MemState

Namespace: [AslHelp.Memory.Native.Enums](AslHelp.Memory.Native.Enums.md)  
Assembly: AslHelp.Memory.dll  

Provides memory page state constants.

```csharp
public enum MemState : uint
```

#### Extension Methods

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetFieldValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetMethod.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetPropertyValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.IsType.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.SetFieldValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.SetPropertyValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Fields

`MEM_COMMIT = 4096` 

Allocates memory charges for the specified reserved memory pages.



`MEM_DECOMMIT = 16384` 

Decommits a range of the process' virtual address space.



`MEM_LARGE_PAGES = 536870912` 

Allocates memory using large page support.



`MEM_PHYSICAL = 4194304` 

Reserves an address range that can be used to map Address Windowing Extensions pages.



`MEM_RELEASE = 32768` 

Releases a range of the process' virtual address space.



`MEM_RESERVE = 8192` 

Reserves a range of the process' virtual address space.



`MEM_RESET = 524288` 

Indicates that data in the memory range is no longer of interest.



`MEM_RESET_UNDO = 16777216` 

Indicates that the data in the specified memory range is of interest to the caller and attempts to reverse the effects of <xref href="AslHelp.Memory.Native.Enums.MemState.MEM_RESET" data-throw-if-not-resolved="false"></xref>.



`MEM_TOP_DOWN = 1048576` 

Allocates memory at the highest possible address.



`MEM_WRITE_WATCH = 2097152` 

Causes the system to track pages that are written to in the allocated region.



## Remarks

For further information see:
<i><a href="https://docs.microsoft.com/windows/win32/memory/memory-protection-constants#constants">Memory Protection Constants</a></i>

