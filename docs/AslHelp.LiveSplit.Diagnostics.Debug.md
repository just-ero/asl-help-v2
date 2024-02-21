# <a id="AslHelp_LiveSplit_Diagnostics_Debug"></a> Class Debug

Namespace: [AslHelp.LiveSplit.Diagnostics](AslHelp.LiveSplit.Diagnostics.md)  
Assembly: AslHelp.LiveSplit.dll  

```csharp
[Obsolete("Do not use ASL-specific features.", true)]
public static class Debug
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Debug](AslHelp.LiveSplit.Diagnostics.Debug.md)

#### Inherited Members

[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone)

#### Extension Methods

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Properties

### <a id="AslHelp_LiveSplit_Diagnostics_Debug_StackTraceMethodNames"></a> StackTraceMethodNames

```csharp
public static IEnumerable<string> StackTraceMethodNames { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

## Methods

### <a id="AslHelp_LiveSplit_Diagnostics_Debug_Error_System_Object_"></a> Error\(object?\)

```csharp
public static void Error(object? output)
```

#### Parameters

`output` [object](https://learn.microsoft.com/dotnet/api/system.object)?

### <a id="AslHelp_LiveSplit_Diagnostics_Debug_Indent"></a> Indent\(\)

```csharp
public static IDisposable Indent()
```

#### Returns

 [IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

### <a id="AslHelp_LiveSplit_Diagnostics_Debug_Info_System_Object_"></a> Info\(object?\)

```csharp
public static void Info(object? output)
```

#### Parameters

`output` [object](https://learn.microsoft.com/dotnet/api/system.object)?

### <a id="AslHelp_LiveSplit_Diagnostics_Debug_Warn_System_Object_"></a> Warn\(object?\)

```csharp
public static void Warn(object? output)
```

#### Parameters

`output` [object](https://learn.microsoft.com/dotnet/api/system.object)?

