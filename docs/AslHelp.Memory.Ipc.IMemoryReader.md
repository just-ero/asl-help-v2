# <a id="AslHelp_Memory_Ipc_IMemoryReader"></a> Interface IMemoryReader

Namespace: [AslHelp.Memory.Ipc](AslHelp.Memory.Ipc.md)  
Assembly: AslHelp.Memory.dll  

```csharp
public interface IMemoryReader
```

#### Extension Methods

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetFieldValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetMethod.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetPropertyValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.IsType.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.SetFieldValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.SetPropertyValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Methods

 [Deref\(uint, params int\[\]\)](AslHelp.Memory.Ipc.IMemoryReader.Deref.md\#AslHelp\_Memory\_Ipc\_IMemoryReader\_Deref\_System\_UInt32\_System\_Int32\_\_\_)

 [Deref\(string, uint, params int\[\]\)](AslHelp.Memory.Ipc.IMemoryReader.Deref.md\#AslHelp\_Memory\_Ipc\_IMemoryReader\_Deref\_System\_String\_System\_UInt32\_System\_Int32\_\_\_)

 [Deref\(Module, uint, params int\[\]\)](AslHelp.Memory.Ipc.IMemoryReader.Deref.md\#AslHelp\_Memory\_Ipc\_IMemoryReader\_Deref\_AslHelp\_Memory\_Module\_System\_UInt32\_System\_Int32\_\_\_)

 [Deref\(nuint, params int\[\]\)](AslHelp.Memory.Ipc.IMemoryReader.Deref.md\#AslHelp\_Memory\_Ipc\_IMemoryReader\_Deref\_System\_UIntPtr\_System\_Int32\_\_\_)

 [TryDeref\(out nuint, uint, params int\[\]\)](AslHelp.Memory.Ipc.IMemoryReader.TryDeref.md\#AslHelp\_Memory\_Ipc\_IMemoryReader\_TryDeref\_System\_UIntPtr\_\_System\_UInt32\_System\_Int32\_\_\_)

 [TryDeref\(out nuint, string?, uint, params int\[\]\)](AslHelp.Memory.Ipc.IMemoryReader.TryDeref.md\#AslHelp\_Memory\_Ipc\_IMemoryReader\_TryDeref\_System\_UIntPtr\_\_System\_String\_System\_UInt32\_System\_Int32\_\_\_)

 [TryDeref\(out nuint, Module?, uint, params int\[\]\)](AslHelp.Memory.Ipc.IMemoryReader.TryDeref.md\#AslHelp\_Memory\_Ipc\_IMemoryReader\_TryDeref\_System\_UIntPtr\_\_AslHelp\_Memory\_Module\_System\_UInt32\_System\_Int32\_\_\_)

 [TryDeref\(out nuint, nuint, params int\[\]\)](AslHelp.Memory.Ipc.IMemoryReader.TryDeref.md\#AslHelp\_Memory\_Ipc\_IMemoryReader\_TryDeref\_System\_UIntPtr\_\_System\_UIntPtr\_System\_Int32\_\_\_)

 [TryRead<T\>\(out T, nuint, params int\[\]\)](AslHelp.Memory.Ipc.IMemoryReader.TryRead.md\#AslHelp\_Memory\_Ipc\_IMemoryReader\_TryRead\_\_1\_\_\_0\_\_System\_UIntPtr\_System\_Int32\_\_\_)

 [TryReadSpan<T\>\(Span<T\>, nuint, params int\[\]\)](AslHelp.Memory.Ipc.IMemoryReader.TryReadSpan.md\#AslHelp\_Memory\_Ipc\_IMemoryReader\_TryReadSpan\_\_1\_System\_Span\_\_\_0\_\_System\_UIntPtr\_System\_Int32\_\_\_)

 [TryReadString\(out string?, int, StringType, nuint, params int\[\]\)](AslHelp.Memory.Ipc.IMemoryReader.TryReadString.md\#AslHelp\_Memory\_Ipc\_IMemoryReader\_TryReadString\_System\_String\_\_System\_Int32\_AslHelp\_Memory\_StringType\_System\_UIntPtr\_System\_Int32\_\_\_)

