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

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetFieldValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetMethod.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetPropertyValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.IsType.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.SetFieldValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.SetPropertyValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Constructors

 [WatcherBase\(IProcessMemory, nuint, params int\[\]\)](AslHelp.Memory.Watch.WatcherBase\-1.\-ctor.md\#AslHelp\_Memory\_Watch\_WatcherBase\_1\_\_ctor\_AslHelp\_Memory\_Ipc\_IProcessMemory\_System\_UIntPtr\_System\_Int32\_\_\_)

## Fields

 [\_memory](AslHelp.Memory.Watch.WatcherBase\-1.\_memory.md\#AslHelp\_Memory\_Watch\_WatcherBase\_1\_\_memory)

## Properties

 [Changed](AslHelp.Memory.Watch.WatcherBase\-1.Changed.md\#AslHelp\_Memory\_Watch\_WatcherBase\_1\_Changed)

 [Current](AslHelp.Memory.Watch.WatcherBase\-1.Current.md\#AslHelp\_Memory\_Watch\_WatcherBase\_1\_Current)

 [Enabled](AslHelp.Memory.Watch.WatcherBase\-1.Enabled.md\#AslHelp\_Memory\_Watch\_WatcherBase\_1\_Enabled)

 [Old](AslHelp.Memory.Watch.WatcherBase\-1.Old.md\#AslHelp\_Memory\_Watch\_WatcherBase\_1\_Old)

 [UpdateOnFail](AslHelp.Memory.Watch.WatcherBase\-1.UpdateOnFail.md\#AslHelp\_Memory\_Watch\_WatcherBase\_1\_UpdateOnFail)

## Methods

 [Equals\(T?, T?\)](AslHelp.Memory.Watch.WatcherBase\-1.Equals.md\#AslHelp\_Memory\_Watch\_WatcherBase\_1\_Equals\_\_0\_\_0\_)

 [TryDeref\(out nuint\)](AslHelp.Memory.Watch.WatcherBase\-1.TryDeref.md\#AslHelp\_Memory\_Watch\_WatcherBase\_1\_TryDeref\_System\_UIntPtr\_\_)

 [TryRead\(nuint, out T?\)](AslHelp.Memory.Watch.WatcherBase\-1.TryRead.md\#AslHelp\_Memory\_Watch\_WatcherBase\_1\_TryRead\_System\_UIntPtr\_\_0\_\_)

