# <a id="AslHelp_LiveSplit_Control_TextComponentController"></a> Class TextComponentController

Namespace: [AslHelp.LiveSplit.Control](AslHelp.LiveSplit.Control.md)  
Assembly: AslHelp.LiveSplit.dll  

```csharp
public sealed class TextComponentController
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TextComponentController](AslHelp.LiveSplit.Control.TextComponentController.md)

#### Inherited Members

[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype)

#### Extension Methods

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Constructors

### <a id="AslHelp_LiveSplit_Control_TextComponentController__ctor_LiveSplit_Model_LiveSplitState_"></a> TextComponentController\(LiveSplitState\)

```csharp
public TextComponentController(LiveSplitState state)
```

#### Parameters

`state` LiveSplitState

## Properties

### <a id="AslHelp_LiveSplit_Control_TextComponentController_Item_System_String_"></a> this\[string\]

```csharp
public TextComponentWrapper this[string key] { get; set; }
```

#### Property Value

 [TextComponentWrapper](AslHelp.LiveSplit.Control.TextComponentWrapper.md)

## Methods

### <a id="AslHelp_LiveSplit_Control_TextComponentController_Remove_System_String_"></a> Remove\(string\)

```csharp
public void Remove(string id)
```

#### Parameters

`id` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="AslHelp_LiveSplit_Control_TextComponentController_RemoveAll"></a> RemoveAll\(\)

```csharp
public void RemoveAll()
```

