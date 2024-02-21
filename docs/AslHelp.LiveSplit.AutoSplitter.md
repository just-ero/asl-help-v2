# <a id="AslHelp_LiveSplit_AutoSplitter"></a> Class AutoSplitter

Namespace: [AslHelp.LiveSplit](AslHelp.LiveSplit.md)  
Assembly: AslHelp.LiveSplit.dll  

```csharp
[Obsolete("Do not use ASL-specific features.", true)]
public sealed class AutoSplitter
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AutoSplitter](AslHelp.LiveSplit.AutoSplitter.md)

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

## Properties

### <a id="AslHelp_LiveSplit_AutoSplitter_Actions"></a> Actions

```csharp
public AutoSplitter.ScriptActions Actions { get; }
```

#### Property Value

 [AutoSplitter](AslHelp.LiveSplit.AutoSplitter.md).[ScriptActions](AslHelp.LiveSplit.AutoSplitter.ScriptActions.md)

### <a id="AslHelp_LiveSplit_AutoSplitter_Current"></a> Current

```csharp
public IDictionary<string, object>? Current { get; }
```

#### Property Value

 [IDictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.idictionary\-2)<[string](https://learn.microsoft.com/dotnet/api/system.string), [object](https://learn.microsoft.com/dotnet/api/system.object)\>?

### <a id="AslHelp_LiveSplit_AutoSplitter_Game"></a> Game

```csharp
public Process? Game { get; set; }
```

#### Property Value

 [Process](https://learn.microsoft.com/dotnet/api/system.diagnostics.process)?

### <a id="AslHelp_LiveSplit_AutoSplitter_SettingsBuilder"></a> SettingsBuilder

```csharp
public ASLSettingsBuilder SettingsBuilder { get; }
```

#### Property Value

 ASLSettingsBuilder

### <a id="AslHelp_LiveSplit_AutoSplitter_State"></a> State

```csharp
public LiveSplitState State { get; }
```

#### Property Value

 LiveSplitState

### <a id="AslHelp_LiveSplit_AutoSplitter_Vars"></a> Vars

```csharp
public IDictionary<string, object> Vars { get; }
```

#### Property Value

 [IDictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.idictionary\-2)<[string](https://learn.microsoft.com/dotnet/api/system.string), [object](https://learn.microsoft.com/dotnet/api/system.object)\>

## Methods

### <a id="AslHelp_LiveSplit_AutoSplitter_TryInitialize"></a> TryInitialize\(\)

```csharp
public static Result<AutoSplitter> TryInitialize()
```

#### Returns

 Result<[AutoSplitter](AslHelp.LiveSplit.AutoSplitter.md)\>

