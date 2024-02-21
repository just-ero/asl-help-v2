# <a id="AslHelp_LiveSplit_ScriptAction"></a> Class ScriptAction

Namespace: [AslHelp.LiveSplit](AslHelp.LiveSplit.md)  
Assembly: AslHelp.LiveSplit.dll  

```csharp
[Obsolete("Do not use ASL-specific features.", true)]
public sealed class ScriptAction
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ScriptAction](AslHelp.LiveSplit.ScriptAction.md)

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

### <a id="AslHelp_LiveSplit_ScriptAction__ctor_LiveSplit_ASL_ASLScript_Methods_System_String_System_String_System_Int32_"></a> ScriptAction\(Methods, string, string, int\)

```csharp
public ScriptAction(ASLScript.Methods methods, string body, string name, int line)
```

#### Parameters

`methods` ASLScript.Methods

`body` [string](https://learn.microsoft.com/dotnet/api/system.string)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`line` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="AslHelp_LiveSplit_ScriptAction__ctor_LiveSplit_ASL_ASLScript_Methods_System_String_"></a> ScriptAction\(Methods, string\)

```csharp
public ScriptAction(ASLScript.Methods methods, string name)
```

#### Parameters

`methods` ASLScript.Methods

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

## Properties

### <a id="AslHelp_LiveSplit_ScriptAction_Body"></a> Body

```csharp
public string Body { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="AslHelp_LiveSplit_ScriptAction_Line"></a> Line

```csharp
public int Line { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="AslHelp_LiveSplit_ScriptAction_Name"></a> Name

```csharp
public string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="AslHelp_LiveSplit_ScriptAction_Append_System_String_"></a> Append\(string\)

```csharp
public void Append(string code)
```

#### Parameters

`code` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="AslHelp_LiveSplit_ScriptAction_Prepend_System_String_"></a> Prepend\(string\)

```csharp
public void Prepend(string code)
```

#### Parameters

`code` [string](https://learn.microsoft.com/dotnet/api/system.string)

