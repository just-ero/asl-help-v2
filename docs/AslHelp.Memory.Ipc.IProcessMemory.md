# <a id="AslHelp_Memory_Ipc_IProcessMemory"></a> Interface IProcessMemory

Namespace: [AslHelp.Memory.Ipc](AslHelp.Memory.Ipc.md)  
Assembly: AslHelp.Memory.dll  

```csharp
public interface IProcessMemory : IMemoryReader, IMemoryWriter, IMemoryScanner, IDisposable
```

#### Implements

[IMemoryReader](AslHelp.Memory.Ipc.IMemoryReader.md), 
[IMemoryWriter](AslHelp.Memory.Ipc.IMemoryWriter.md), 
[IMemoryScanner](AslHelp.Memory.Ipc.IMemoryScanner.md), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Extension Methods

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetFieldValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetMethod.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetPropertyValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.IsType.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.SetFieldValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.SetPropertyValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Properties

 [Is64Bit](AslHelp.Memory.Ipc.IProcessMemory.Is64Bit.md\#AslHelp\_Memory\_Ipc\_IProcessMemory\_Is64Bit)

 [MainModule](AslHelp.Memory.Ipc.IProcessMemory.MainModule.md\#AslHelp\_Memory\_Ipc\_IProcessMemory\_MainModule)

 [Modules](AslHelp.Memory.Ipc.IProcessMemory.Modules.md\#AslHelp\_Memory\_Ipc\_IProcessMemory\_Modules)

 [PointerSize](AslHelp.Memory.Ipc.IProcessMemory.PointerSize.md\#AslHelp\_Memory\_Ipc\_IProcessMemory\_PointerSize)

 [Process](AslHelp.Memory.Ipc.IProcessMemory.Process.md\#AslHelp\_Memory\_Ipc\_IProcessMemory\_Process)

 [Tick](AslHelp.Memory.Ipc.IProcessMemory.Tick.md\#AslHelp\_Memory\_Ipc\_IProcessMemory\_Tick)

## Methods

 [GetMemoryPages\(bool\)](AslHelp.Memory.Ipc.IProcessMemory.GetMemoryPages.md\#AslHelp\_Memory\_Ipc\_IProcessMemory\_GetMemoryPages\_System\_Boolean\_)

 [TryReadRelative\(out nuint, nuint, uint\)](AslHelp.Memory.Ipc.IProcessMemory.TryReadRelative.md\#AslHelp\_Memory\_Ipc\_IProcessMemory\_TryReadRelative\_System\_UIntPtr\_\_System\_UIntPtr\_System\_UInt32\_)

