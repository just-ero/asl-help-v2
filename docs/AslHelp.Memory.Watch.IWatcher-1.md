# <a id="AslHelp_Memory_Watch_IWatcher_1"></a> Interface IWatcher<T\>

Namespace: [AslHelp.Memory.Watch](AslHelp.Memory.Watch.md)  
Assembly: AslHelp.Memory.dll  

```csharp
public interface IWatcher<T> : IWatcher
```

#### Type Parameters

`T` 

#### Implements

[IWatcher](AslHelp.Memory.Watch.IWatcher.md)

#### Extension Methods

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Properties

### <a id="AslHelp_Memory_Watch_IWatcher_1_Current"></a> Current

```csharp
T? Current { get; set; }
```

#### Property Value

 T?

### <a id="AslHelp_Memory_Watch_IWatcher_1_Old"></a> Old

```csharp
T? Old { get; set; }
```

#### Property Value

 T?

