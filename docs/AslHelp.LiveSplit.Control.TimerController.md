# <a id="AslHelp_LiveSplit_Control_TimerController"></a> Class TimerController

Namespace: [AslHelp.LiveSplit.Control](AslHelp.LiveSplit.Control.md)  
Assembly: AslHelp.LiveSplit.dll  

```csharp
public sealed class TimerController
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TimerController](AslHelp.LiveSplit.Control.TimerController.md)

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

### <a id="AslHelp_LiveSplit_Control_TimerController__ctor_LiveSplit_Model_LiveSplitState_"></a> TimerController\(LiveSplitState\)

```csharp
public TimerController(LiveSplitState state)
```

#### Parameters

`state` LiveSplitState

## Methods

### <a id="AslHelp_LiveSplit_Control_TimerController_Pause_System_Func_System_Boolean__"></a> Pause\(Func<bool\>?\)

```csharp
public void Pause(Func<bool>? func = null)
```

#### Parameters

`func` [Func](https://learn.microsoft.com/dotnet/api/system.func\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>?

### <a id="AslHelp_LiveSplit_Control_TimerController_Reset_System_Func_System_Boolean__"></a> Reset\(Func<bool\>?\)

```csharp
public void Reset(Func<bool>? func = null)
```

#### Parameters

`func` [Func](https://learn.microsoft.com/dotnet/api/system.func\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>?

### <a id="AslHelp_LiveSplit_Control_TimerController_Skip_System_Func_System_Boolean__"></a> Skip\(Func<bool\>?\)

```csharp
public void Skip(Func<bool>? func = null)
```

#### Parameters

`func` [Func](https://learn.microsoft.com/dotnet/api/system.func\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>?

### <a id="AslHelp_LiveSplit_Control_TimerController_Split_System_Func_System_Boolean__"></a> Split\(Func<bool\>?\)

```csharp
public void Split(Func<bool>? func = null)
```

#### Parameters

`func` [Func](https://learn.microsoft.com/dotnet/api/system.func\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>?

### <a id="AslHelp_LiveSplit_Control_TimerController_Start_System_Func_System_Boolean__"></a> Start\(Func<bool\>?\)

```csharp
public void Start(Func<bool>? func = null)
```

#### Parameters

`func` [Func](https://learn.microsoft.com/dotnet/api/system.func\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>?

### <a id="AslHelp_LiveSplit_Control_TimerController_Undo_System_Func_System_Boolean__"></a> Undo\(Func<bool\>?\)

```csharp
public void Undo(Func<bool>? func = null)
```

#### Parameters

`func` [Func](https://learn.microsoft.com/dotnet/api/system.func\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>?

### <a id="AslHelp_LiveSplit_Control_TimerController_Unpause_System_Func_System_Boolean__"></a> Unpause\(Func<bool\>?\)

```csharp
public void Unpause(Func<bool>? func = null)
```

#### Parameters

`func` [Func](https://learn.microsoft.com/dotnet/api/system.func\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>?

