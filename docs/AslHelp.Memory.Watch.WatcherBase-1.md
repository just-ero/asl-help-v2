# <a id="AslHelp_Memory_Watch_WatcherBase_1"></a> Class WatcherBase<T\>

Namespace: [AslHelp.Memory.Watch](AslHelp.Memory.Watch.md)  
Assembly: AslHelp.Memory.dll  

```csharp
public abstract class WatcherBase<T> : IWatcher<T>, IWatcher
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[WatcherBase<T\>](AslHelp.Memory.Watch.WatcherBase\-1.md)

#### Implements

[IWatcher<T\>](AslHelp.Memory.Watch.IWatcher\-1.md), 
[IWatcher](AslHelp.Memory.Watch.IWatcher.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Constructors

### <a id="AslHelp_Memory_Watch_WatcherBase_1__ctor_AslHelp_Memory_Ipc_IProcessMemory_System_UIntPtr_System_Int32___"></a> WatcherBase\(IProcessMemory, nuint, params int\[\]\)

```csharp
protected WatcherBase(IProcessMemory memory, nuint baseAddress, params int[] offsets)
```

#### Parameters

`memory` [IProcessMemory](AslHelp.Memory.Ipc.IProcessMemory.md)

`baseAddress` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`offsets` [int](https://learn.microsoft.com/dotnet/api/system.int32)\[\]

## Fields

### <a id="AslHelp_Memory_Watch_WatcherBase_1__memory"></a> \_memory

```csharp
protected readonly IProcessMemory _memory
```

#### Field Value

 [IProcessMemory](AslHelp.Memory.Ipc.IProcessMemory.md)

## Properties

### <a id="AslHelp_Memory_Watch_WatcherBase_1_Changed"></a> Changed

```csharp
public bool Changed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Memory_Watch_WatcherBase_1_Current"></a> Current

```csharp
public T? Current { get; set; }
```

#### Property Value

 T?

### <a id="AslHelp_Memory_Watch_WatcherBase_1_Enabled"></a> Enabled

```csharp
public bool Enabled { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Memory_Watch_WatcherBase_1_Old"></a> Old

```csharp
public T? Old { get; set; }
```

#### Property Value

 T?

### <a id="AslHelp_Memory_Watch_WatcherBase_1_UpdateOnFail"></a> UpdateOnFail

```csharp
public bool UpdateOnFail { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="AslHelp_Memory_Watch_WatcherBase_1_Equals__0__0_"></a> Equals\(T?, T?\)

```csharp
protected abstract bool Equals(T? old, T? current)
```

#### Parameters

`old` T?

`current` T?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Memory_Watch_WatcherBase_1_TryDeref_System_UIntPtr__"></a> TryDeref\(out nuint\)

```csharp
public virtual bool TryDeref(out nuint result)
```

#### Parameters

`result` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Memory_Watch_WatcherBase_1_TryRead_System_UIntPtr__0__"></a> TryRead\(nuint, out T?\)

```csharp
protected abstract bool TryRead(nuint address, out T? value)
```

#### Parameters

`address` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`value` T?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

