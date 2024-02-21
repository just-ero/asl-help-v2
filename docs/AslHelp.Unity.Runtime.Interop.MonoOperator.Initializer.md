# <a id="AslHelp_Unity_Runtime_Interop_MonoOperator_Initializer"></a> Class MonoOperator.Initializer

Namespace: [AslHelp.Unity.Runtime.Interop](AslHelp.Unity.Runtime.Interop.md)  
Assembly: AslHelp.Unity.dll  

```csharp
public abstract class MonoOperator.Initializer
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MonoOperator.Initializer](AslHelp.Unity.Runtime.Interop.MonoOperator.Initializer.md)

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

## Methods

### <a id="AslHelp_Unity_Runtime_Interop_MonoOperator_Initializer_GetAssemblies_AslHelp_Unity_Memory_Ipc_IMonoProcessMemory_"></a> GetAssemblies\(IMonoProcessMemory\)

```csharp
public abstract Result<nuint> GetAssemblies(IMonoProcessMemory memory)
```

#### Parameters

`memory` [IMonoProcessMemory](AslHelp.Unity.Memory.Ipc.IMonoProcessMemory.md)

#### Returns

 Result<[nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)\>

### <a id="AslHelp_Unity_Runtime_Interop_MonoOperator_Initializer_GetDefaults_AslHelp_Unity_Memory_Ipc_IMonoProcessMemory_"></a> GetDefaults\(IMonoProcessMemory\)

```csharp
public abstract Result<MonoDefaults> GetDefaults(IMonoProcessMemory memory)
```

#### Parameters

`memory` [IMonoProcessMemory](AslHelp.Unity.Memory.Ipc.IMonoProcessMemory.md)

#### Returns

 Result<[MonoDefaults](AslHelp.Unity.Runtime.Interop.MonoDefaults.md)\>

### <a id="AslHelp_Unity_Runtime_Interop_MonoOperator_Initializer_GetStructs_AslHelp_Unity_Memory_Ipc_IMonoProcessMemory_"></a> GetStructs\(IMonoProcessMemory\)

```csharp
public abstract Result<Reflection> GetStructs(IMonoProcessMemory memory)
```

#### Parameters

`memory` [IMonoProcessMemory](AslHelp.Unity.Memory.Ipc.IMonoProcessMemory.md)

#### Returns

 Result<Reflection\>

