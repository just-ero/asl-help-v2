# <a id="AslHelp_Memory_Ipc_ProcessMemory"></a> Class ProcessMemory

Namespace: [AslHelp.Memory.Ipc](AslHelp.Memory.Ipc.md)  
Assembly: AslHelp.Memory.dll  

```csharp
public class ProcessMemory : IProcessMemory, IMemoryReader, IMemoryWriter, IMemoryScanner, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ProcessMemory](AslHelp.Memory.Ipc.ProcessMemory.md)

#### Implements

[IProcessMemory](AslHelp.Memory.Ipc.IProcessMemory.md), 
[IMemoryReader](AslHelp.Memory.Ipc.IMemoryReader.md), 
[IMemoryWriter](AslHelp.Memory.Ipc.IMemoryWriter.md), 
[IMemoryScanner](AslHelp.Memory.Ipc.IMemoryScanner.md), 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
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

 [ProcessMemory\(Process\)](AslHelp.Memory.Ipc.ProcessMemory.\-ctor.md\#AslHelp\_Memory\_Ipc\_ProcessMemory\_\_ctor\_System\_Diagnostics\_Process\_)

## Fields

 [\_handle](AslHelp.Memory.Ipc.ProcessMemory.\_handle.md\#AslHelp\_Memory\_Ipc\_ProcessMemory\_\_handle)

## Properties

 [Is64Bit](AslHelp.Memory.Ipc.ProcessMemory.Is64Bit.md\#AslHelp\_Memory\_Ipc\_ProcessMemory\_Is64Bit)

 [MainModule](AslHelp.Memory.Ipc.ProcessMemory.MainModule.md\#AslHelp\_Memory\_Ipc\_ProcessMemory\_MainModule)

 [Modules](AslHelp.Memory.Ipc.ProcessMemory.Modules.md\#AslHelp\_Memory\_Ipc\_ProcessMemory\_Modules)

 [PointerSize](AslHelp.Memory.Ipc.ProcessMemory.PointerSize.md\#AslHelp\_Memory\_Ipc\_ProcessMemory\_PointerSize)

 [Process](AslHelp.Memory.Ipc.ProcessMemory.Process.md\#AslHelp\_Memory\_Ipc\_ProcessMemory\_Process)

 [Tick](AslHelp.Memory.Ipc.ProcessMemory.Tick.md\#AslHelp\_Memory\_Ipc\_ProcessMemory\_Tick)

## Methods

 [Deref\(uint, params int\[\]\)](AslHelp.Memory.Ipc.ProcessMemory.Deref.md\#AslHelp\_Memory\_Ipc\_ProcessMemory\_Deref\_System\_UInt32\_System\_Int32\_\_\_)

 [Deref\(string, uint, params int\[\]\)](AslHelp.Memory.Ipc.ProcessMemory.Deref.md\#AslHelp\_Memory\_Ipc\_ProcessMemory\_Deref\_System\_String\_System\_UInt32\_System\_Int32\_\_\_)

 [Deref\(Module, uint, params int\[\]\)](AslHelp.Memory.Ipc.ProcessMemory.Deref.md\#AslHelp\_Memory\_Ipc\_ProcessMemory\_Deref\_AslHelp\_Memory\_Module\_System\_UInt32\_System\_Int32\_\_\_)

 [Deref\(nuint, params int\[\]\)](AslHelp.Memory.Ipc.ProcessMemory.Deref.md\#AslHelp\_Memory\_Ipc\_ProcessMemory\_Deref\_System\_UIntPtr\_System\_Int32\_\_\_)

 [Dispose\(\)](AslHelp.Memory.Ipc.ProcessMemory.Dispose.md\#AslHelp\_Memory\_Ipc\_ProcessMemory\_Dispose)

 [GetMemoryPages\(bool\)](AslHelp.Memory.Ipc.ProcessMemory.GetMemoryPages.md\#AslHelp\_Memory\_Ipc\_ProcessMemory\_GetMemoryPages\_System\_Boolean\_)

 [Scan\(ScanPattern, nuint, nuint\)](AslHelp.Memory.Ipc.ProcessMemory.Scan.md\#AslHelp\_Memory\_Ipc\_ProcessMemory\_Scan\_AslHelp\_Memory\_Scanning\_ScanPattern\_System\_UIntPtr\_System\_UIntPtr\_)

 [Scan\(ScanPattern, nuint, int\)](AslHelp.Memory.Ipc.ProcessMemory.Scan.md\#AslHelp\_Memory\_Ipc\_ProcessMemory\_Scan\_AslHelp\_Memory\_Scanning\_ScanPattern\_System\_UIntPtr\_System\_Int32\_)

 [ScanAll\(ScanPattern, nuint, nuint\)](AslHelp.Memory.Ipc.ProcessMemory.ScanAll.md\#AslHelp\_Memory\_Ipc\_ProcessMemory\_ScanAll\_AslHelp\_Memory\_Scanning\_ScanPattern\_System\_UIntPtr\_System\_UIntPtr\_)

 [ScanAll\(ScanPattern, nuint, int\)](AslHelp.Memory.Ipc.ProcessMemory.ScanAll.md\#AslHelp\_Memory\_Ipc\_ProcessMemory\_ScanAll\_AslHelp\_Memory\_Scanning\_ScanPattern\_System\_UIntPtr\_System\_Int32\_)

 [TryDeref\(out nuint, uint, params int\[\]\)](AslHelp.Memory.Ipc.ProcessMemory.TryDeref.md\#AslHelp\_Memory\_Ipc\_ProcessMemory\_TryDeref\_System\_UIntPtr\_\_System\_UInt32\_System\_Int32\_\_\_)

 [TryDeref\(out nuint, string?, uint, params int\[\]\)](AslHelp.Memory.Ipc.ProcessMemory.TryDeref.md\#AslHelp\_Memory\_Ipc\_ProcessMemory\_TryDeref\_System\_UIntPtr\_\_System\_String\_System\_UInt32\_System\_Int32\_\_\_)

 [TryDeref\(out nuint, Module?, uint, params int\[\]\)](AslHelp.Memory.Ipc.ProcessMemory.TryDeref.md\#AslHelp\_Memory\_Ipc\_ProcessMemory\_TryDeref\_System\_UIntPtr\_\_AslHelp\_Memory\_Module\_System\_UInt32\_System\_Int32\_\_\_)

 [TryDeref\(out nuint, nuint, params int\[\]\)](AslHelp.Memory.Ipc.ProcessMemory.TryDeref.md\#AslHelp\_Memory\_Ipc\_ProcessMemory\_TryDeref\_System\_UIntPtr\_\_System\_UIntPtr\_System\_Int32\_\_\_)

 [TryRead<T\>\(out T, nuint, params int\[\]\)](AslHelp.Memory.Ipc.ProcessMemory.TryRead.md\#AslHelp\_Memory\_Ipc\_ProcessMemory\_TryRead\_\_1\_\_\_0\_\_System\_UIntPtr\_System\_Int32\_\_\_)

 [TryReadRelative\(out nuint, nuint, uint\)](AslHelp.Memory.Ipc.ProcessMemory.TryReadRelative.md\#AslHelp\_Memory\_Ipc\_ProcessMemory\_TryReadRelative\_System\_UIntPtr\_\_System\_UIntPtr\_System\_UInt32\_)

 [TryReadSpan<T\>\(Span<T\>, nuint, params int\[\]\)](AslHelp.Memory.Ipc.ProcessMemory.TryReadSpan.md\#AslHelp\_Memory\_Ipc\_ProcessMemory\_TryReadSpan\_\_1\_System\_Span\_\_\_0\_\_System\_UIntPtr\_System\_Int32\_\_\_)

 [TryReadString\(out string?, int, StringType, nuint, params int\[\]\)](AslHelp.Memory.Ipc.ProcessMemory.TryReadString.md\#AslHelp\_Memory\_Ipc\_ProcessMemory\_TryReadString\_System\_String\_\_System\_Int32\_AslHelp\_Memory\_StringType\_System\_UIntPtr\_System\_Int32\_\_\_)

 [Write<T\>\(T, nuint, params int\[\]\)](AslHelp.Memory.Ipc.ProcessMemory.Write.md\#AslHelp\_Memory\_Ipc\_ProcessMemory\_Write\_\_1\_\_\_0\_System\_UIntPtr\_System\_Int32\_\_\_)

 [WriteSpan<T\>\(ReadOnlySpan<T\>, nuint, params int\[\]\)](AslHelp.Memory.Ipc.ProcessMemory.WriteSpan.md\#AslHelp\_Memory\_Ipc\_ProcessMemory\_WriteSpan\_\_1\_System\_ReadOnlySpan\_\_\_0\_\_System\_UIntPtr\_System\_Int32\_\_\_)

