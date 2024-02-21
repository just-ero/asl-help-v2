# <a id="AslHelp_LiveSplit_Settings_SettingsBuilder"></a> Class SettingsBuilder

Namespace: [AslHelp.LiveSplit.Settings](AslHelp.LiveSplit.Settings.md)  
Assembly: AslHelp.LiveSplit.dll  

```csharp
[Obsolete("Do not use ASL-specific features.", true)]
public sealed class SettingsBuilder
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SettingsBuilder](AslHelp.LiveSplit.Settings.SettingsBuilder.md)

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

### <a id="AslHelp_LiveSplit_Settings_SettingsBuilder__ctor_LiveSplit_ASL_ASLSettingsBuilder_"></a> SettingsBuilder\(ASLSettingsBuilder\)

```csharp
public SettingsBuilder(ASLSettingsBuilder builder)
```

#### Parameters

`builder` ASLSettingsBuilder

## Methods

### <a id="AslHelp_LiveSplit_Settings_SettingsBuilder_Add_System_Collections_Generic_Dictionary_System_String_System_String__"></a> Add\(Dictionary<string, string\>\)

```csharp
public void Add(Dictionary<string, string> settings)
```

#### Parameters

`settings` [Dictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2)<[string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="AslHelp_LiveSplit_Settings_SettingsBuilder_Add_System_Object_0__0___"></a> Add\(dynamic?\[,\]\)

```csharp
public void Add(dynamic?[,] settings)
```

#### Parameters

`settings` dynamic?\[,\]

### <a id="AslHelp_LiveSplit_Settings_SettingsBuilder_FromJson_System_String_"></a> FromJson\(string\)

```csharp
public void FromJson(string path)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="AslHelp_LiveSplit_Settings_SettingsBuilder_FromXml_System_String_"></a> FromXml\(string\)

```csharp
public void FromXml(string path)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

