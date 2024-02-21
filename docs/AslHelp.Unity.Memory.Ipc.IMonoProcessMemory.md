# <a id="AslHelp_Unity_Memory_Ipc_IMonoProcessMemory"></a> Interface IMonoProcessMemory

Namespace: [AslHelp.Unity.Memory.Ipc](AslHelp.Unity.Memory.Ipc.md)  
Assembly: AslHelp.Unity.dll  

```csharp
public interface IMonoProcessMemory : IProcessMemory, IMemoryScanner, IDisposable, IMonoMemoryReader, IMemoryReader, IMonoMemoryWriter, IMemoryWriter
```

#### Implements

IProcessMemory, 
IMemoryScanner, 
[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable), 
[IMonoMemoryReader](AslHelp.Unity.Memory.Ipc.IMonoMemoryReader.md), 
IMemoryReader, 
[IMonoMemoryWriter](AslHelp.Unity.Memory.Ipc.IMonoMemoryWriter.md), 
IMemoryWriter

#### Extension Methods

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Properties

### <a id="AslHelp_Unity_Memory_Ipc_IMonoProcessMemory_MonoModule"></a> MonoModule

```csharp
Module MonoModule { get; }
```

#### Property Value

 Module

### <a id="AslHelp_Unity_Memory_Ipc_IMonoProcessMemory_RuntimeVersion"></a> RuntimeVersion

```csharp
MonoRuntimeVersion RuntimeVersion { get; }
```

#### Property Value

 [MonoRuntimeVersion](AslHelp.Unity.Memory.Ipc.MonoRuntimeVersion.md)

### <a id="AslHelp_Unity_Memory_Ipc_IMonoProcessMemory_UnityPlayerModule"></a> UnityPlayerModule

```csharp
Module UnityPlayerModule { get; }
```

#### Property Value

 Module

