# <a id="AslHelp_LiveSplit_AslHelpEntryPoint"></a> Class AslHelpEntryPoint

Namespace: [AslHelp.LiveSplit](AslHelp.LiveSplit.md)  
Assembly: AslHelp.LiveSplit.dll  

```csharp
[Obsolete("Do not use ASL-specific features.", true)]
public abstract class AslHelpEntryPoint
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AslHelpEntryPoint](AslHelp.LiveSplit.AslHelpEntryPoint.md)

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

## Fields

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint__asl"></a> \_asl

```csharp
protected AutoSplitter? _asl
```

#### Field Value

 [AutoSplitter](AslHelp.LiveSplit.AutoSplitter.md)?

## Properties

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_Game"></a> Game

```csharp
public abstract Process? Game { get; set; }
```

#### Property Value

 [Process](https://learn.microsoft.com/dotnet/api/system.diagnostics.process)?

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_GameName"></a> GameName

```csharp
public string GameName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_Initialized"></a> Initialized

```csharp
public bool Initialized { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_Logger"></a> Logger

```csharp
public abstract ILogger Logger { get; }
```

#### Property Value

 ILogger

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_Memory"></a> Memory

```csharp
public abstract IProcessMemory? Memory { get; }
```

#### Property Value

 IProcessMemory?

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_Settings"></a> Settings

```csharp
public SettingsBuilder? Settings { get; }
```

#### Property Value

 [SettingsBuilder](AslHelp.LiveSplit.Settings.SettingsBuilder.md)?

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_Texts"></a> Texts

```csharp
public TextComponentController? Texts { get; }
```

#### Property Value

 [TextComponentController](AslHelp.LiveSplit.Control.TextComponentController.md)?

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_Timer"></a> Timer

```csharp
public TimerController? Timer { get; }
```

#### Property Value

 [TimerController](AslHelp.LiveSplit.Control.TimerController.md)?

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_Watchers"></a> Watchers

```csharp
public abstract WatcherFactory? Watchers { get; }
```

#### Property Value

 WatcherFactory?

## Methods

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_AlertGameTime_System_String_"></a> AlertGameTime\(string?\)

```csharp
public AslHelpEntryPoint AlertGameTime(string? message = null)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

#### Returns

 [AslHelpEntryPoint](AslHelp.LiveSplit.AslHelpEntryPoint.md)

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_AlertLoadless_System_String_"></a> AlertLoadless\(string?\)

```csharp
public AslHelpEntryPoint AlertLoadless(string? message = null)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

#### Returns

 [AslHelpEntryPoint](AslHelp.LiveSplit.AslHelpEntryPoint.md)

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_AlertRealTime_System_String_"></a> AlertRealTime\(string?\)

```csharp
public AslHelpEntryPoint AlertRealTime(string? message = null)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

#### Returns

 [AslHelpEntryPoint](AslHelp.LiveSplit.AslHelpEntryPoint.md)

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_DisposeProcessInstanceData"></a> DisposeProcessInstanceData\(\)

```csharp
protected abstract void DisposeProcessInstanceData()
```

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_EnsureHasMemory"></a> EnsureHasMemory\(\)

```csharp
protected void EnsureHasMemory()
```

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_EnsureInitialized"></a> EnsureInitialized\(\)

```csharp
protected void EnsureInitialized()
```

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_GenerateCodeImpl_System_String_AslHelp_LiveSplit_AutoSplitter_"></a> GenerateCodeImpl\(string?, AutoSplitter\)

```csharp
protected abstract void GenerateCodeImpl(string? helperName, AutoSplitter asl)
```

#### Parameters

`helperName` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`asl` [AutoSplitter](AslHelp.LiveSplit.AutoSplitter.md)

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_GetMD5Hash"></a> GetMD5Hash\(\)

```csharp
public string GetMD5Hash()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_GetMD5Hash_System_String_"></a> GetMD5Hash\(string\)

```csharp
public string GetMD5Hash(string moduleName)
```

#### Parameters

`moduleName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_GetMD5Hash_AslHelp_Memory_Module_"></a> GetMD5Hash\(Module\)

```csharp
public string GetMD5Hash(Module module)
```

#### Parameters

`module` Module

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_GetMemorySize"></a> GetMemorySize\(\)

```csharp
public uint GetMemorySize()
```

#### Returns

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_GetMemorySize_System_String_"></a> GetMemorySize\(string\)

```csharp
public uint GetMemorySize(string moduleName)
```

#### Parameters

`moduleName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_GetMemorySize_AslHelp_Memory_Module_"></a> GetMemorySize\(Module\)

```csharp
public uint GetMemorySize(Module module)
```

#### Parameters

`module` Module

#### Returns

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_GetSHA1Hash"></a> GetSHA1Hash\(\)

```csharp
public string GetSHA1Hash()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_GetSHA1Hash_System_String_"></a> GetSHA1Hash\(string\)

```csharp
public string GetSHA1Hash(string moduleName)
```

#### Parameters

`moduleName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_GetSHA1Hash_AslHelp_Memory_Module_"></a> GetSHA1Hash\(Module\)

```csharp
public string GetSHA1Hash(Module module)
```

#### Parameters

`module` Module

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_GetSHA256Hash"></a> GetSHA256Hash\(\)

```csharp
public string GetSHA256Hash()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_GetSHA256Hash_System_String_"></a> GetSHA256Hash\(string\)

```csharp
public string GetSHA256Hash(string moduleName)
```

#### Parameters

`moduleName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_GetSHA256Hash_AslHelp_Memory_Module_"></a> GetSHA256Hash\(Module\)

```csharp
public string GetSHA256Hash(Module module)
```

#### Parameters

`module` Module

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_GetSHA512Hash"></a> GetSHA512Hash\(\)

```csharp
public string GetSHA512Hash()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_GetSHA512Hash_System_String_"></a> GetSHA512Hash\(string\)

```csharp
public string GetSHA512Hash(string moduleName)
```

#### Parameters

`moduleName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_GetSHA512Hash_AslHelp_Memory_Module_"></a> GetSHA512Hash\(Module\)

```csharp
public string GetSHA512Hash(Module module)
```

#### Parameters

`module` Module

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_Init_System_String_System_Boolean_"></a> Init\(string?, bool\)

```csharp
public AslHelpEntryPoint Init(string? gameName = null, bool generateCode = false)
```

#### Parameters

`gameName` [string](https://learn.microsoft.com/dotnet/api/system.string)?

`generateCode` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [AslHelpEntryPoint](AslHelp.LiveSplit.AslHelpEntryPoint.md)

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_InitImpl"></a> InitImpl\(\)

```csharp
protected abstract void InitImpl()
```

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_OnExit"></a> OnExit\(\)

```csharp
public void OnExit()
```

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_OnExitImpl"></a> OnExitImpl\(\)

```csharp
protected abstract void OnExitImpl()
```

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_OnShutdown"></a> OnShutdown\(\)

```csharp
public void OnShutdown()
```

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_OnShutdownImpl_System_Boolean_"></a> OnShutdownImpl\(bool\)

```csharp
protected abstract void OnShutdownImpl(bool closing)
```

#### Parameters

`closing` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_Reject_System_UInt32___"></a> Reject\(params uint\[\]\)

```csharp
public bool Reject(params uint[] moduleMemorySizes)
```

#### Parameters

`moduleMemorySizes` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)\[\]

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_Reject_System_String_System_UInt32___"></a> Reject\(string, params uint\[\]\)

```csharp
public bool Reject(string moduleName, params uint[] moduleMemorySizes)
```

#### Parameters

`moduleName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`moduleMemorySizes` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)\[\]

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_LiveSplit_AslHelpEntryPoint_Reject_AslHelp_Memory_Module_System_UInt32___"></a> Reject\(Module, params uint\[\]\)

```csharp
public bool Reject(Module module, params uint[] moduleMemorySizes)
```

#### Parameters

`module` Module

`moduleMemorySizes` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)\[\]

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

