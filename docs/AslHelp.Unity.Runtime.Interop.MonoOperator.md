# <a id="AslHelp_Unity_Runtime_Interop_MonoOperator"></a> Class MonoOperator

Namespace: [AslHelp.Unity.Runtime.Interop](AslHelp.Unity.Runtime.Interop.md)  
Assembly: AslHelp.Unity.dll  

```csharp
public abstract class MonoOperator
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MonoOperator](AslHelp.Unity.Runtime.Interop.MonoOperator.md)

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

## Constructors

### <a id="AslHelp_Unity_Runtime_Interop_MonoOperator__ctor_AslHelp_Unity_Memory_Ipc_IMonoProcessMemory_AslHelp_Memory_StructReflection_Reflection_AslHelp_Unity_Runtime_Interop_MonoDefaults_System_UIntPtr_"></a> MonoOperator\(IMonoProcessMemory, Reflection, MonoDefaults, nuint\)

```csharp
protected MonoOperator(IMonoProcessMemory memory, Reflection structs, MonoDefaults defaults, nuint assemblies)
```

#### Parameters

`memory` [IMonoProcessMemory](AslHelp.Unity.Memory.Ipc.IMonoProcessMemory.md)

`structs` Reflection

`defaults` [MonoDefaults](AslHelp.Unity.Runtime.Interop.MonoDefaults.md)

`assemblies` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

## Fields

### <a id="AslHelp_Unity_Runtime_Interop_MonoOperator__defaults"></a> \_defaults

```csharp
protected readonly MonoDefaults _defaults
```

#### Field Value

 [MonoDefaults](AslHelp.Unity.Runtime.Interop.MonoDefaults.md)

### <a id="AslHelp_Unity_Runtime_Interop_MonoOperator__loadedAssemblies"></a> \_loadedAssemblies

```csharp
protected readonly nuint _loadedAssemblies
```

#### Field Value

 [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

### <a id="AslHelp_Unity_Runtime_Interop_MonoOperator__memory"></a> \_memory

```csharp
protected readonly IMonoProcessMemory _memory
```

#### Field Value

 [IMonoProcessMemory](AslHelp.Unity.Memory.Ipc.IMonoProcessMemory.md)

### <a id="AslHelp_Unity_Runtime_Interop_MonoOperator__structs"></a> \_structs

```csharp
protected readonly Reflection _structs
```

#### Field Value

 Reflection

## Properties

### <a id="AslHelp_Unity_Runtime_Interop_MonoOperator_Images"></a> Images

```csharp
public KeyedCollection<string, MonoImage> Images { get; }
```

#### Property Value

 KeyedCollection<[string](https://learn.microsoft.com/dotnet/api/system.string), [MonoImage](AslHelp.Unity.Runtime.MonoImage.md)\>

## Methods

### <a id="AslHelp_Unity_Runtime_Interop_MonoOperator_Create_AslHelp_Unity_Memory_Ipc_IMonoProcessMemory_"></a> Create\(IMonoProcessMemory\)

```csharp
public static Result<MonoOperator> Create(IMonoProcessMemory memory)
```

#### Parameters

`memory` [IMonoProcessMemory](AslHelp.Unity.Memory.Ipc.IMonoProcessMemory.md)

#### Returns

 Result<[MonoOperator](AslHelp.Unity.Runtime.Interop.MonoOperator.md)\>

### <a id="AslHelp_Unity_Runtime_Interop_MonoOperator_TryGetClassName_System_UIntPtr_System_String__"></a> TryGetClassName\(nuint, out string?\)

```csharp
public abstract bool TryGetClassName(nuint klass, out string? name)
```

#### Parameters

`klass` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Unity_Runtime_Interop_MonoOperator_TryGetClassNamespace_System_UIntPtr_System_String__"></a> TryGetClassNamespace\(nuint, out string?\)

```csharp
public abstract bool TryGetClassNamespace(nuint klass, out string? @namespace)
```

#### Parameters

`klass` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`namespace` [string](https://learn.microsoft.com/dotnet/api/system.string)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Unity_Runtime_Interop_MonoOperator_TryGetClassParent_System_UIntPtr_System_UIntPtr__"></a> TryGetClassParent\(nuint, out nuint\)

```csharp
public abstract bool TryGetClassParent(nuint klass, out nuint parent)
```

#### Parameters

`klass` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`parent` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Unity_Runtime_Interop_MonoOperator_TryGetClassStaticDataChunk_System_UIntPtr_System_UIntPtr__"></a> TryGetClassStaticDataChunk\(nuint, out nuint\)

```csharp
public abstract bool TryGetClassStaticDataChunk(nuint klass, out nuint staticDataChunk)
```

#### Parameters

`klass` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`staticDataChunk` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Unity_Runtime_Interop_MonoOperator_TryGetClasses_System_UIntPtr_"></a> TryGetClasses\(nuint\)

```csharp
public abstract IEnumerable<nuint> TryGetClasses(nuint image)
```

#### Parameters

`image` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)\>

### <a id="AslHelp_Unity_Runtime_Interop_MonoOperator_TryGetFieldName_System_UIntPtr_System_String__"></a> TryGetFieldName\(nuint, out string?\)

```csharp
public abstract bool TryGetFieldName(nuint field, out string? name)
```

#### Parameters

`field` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Unity_Runtime_Interop_MonoOperator_TryGetFieldOffset_System_UIntPtr_System_Int32__"></a> TryGetFieldOffset\(nuint, out int\)

```csharp
public abstract bool TryGetFieldOffset(nuint field, out int offset)
```

#### Parameters

`field` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`offset` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Unity_Runtime_Interop_MonoOperator_TryGetFieldType_System_UIntPtr_System_UIntPtr__"></a> TryGetFieldType\(nuint, out nuint\)

```csharp
public abstract bool TryGetFieldType(nuint field, out nuint type)
```

#### Parameters

`field` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`type` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Unity_Runtime_Interop_MonoOperator_TryGetFields_System_UIntPtr_"></a> TryGetFields\(nuint\)

```csharp
public abstract IEnumerable<nuint> TryGetFields(nuint klass)
```

#### Parameters

`klass` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)\>

### <a id="AslHelp_Unity_Runtime_Interop_MonoOperator_TryGetImageFileName_System_UIntPtr_System_String__"></a> TryGetImageFileName\(nuint, out string?\)

```csharp
public abstract bool TryGetImageFileName(nuint image, out string? fileName)
```

#### Parameters

`image` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Unity_Runtime_Interop_MonoOperator_TryGetImageName_System_UIntPtr_System_String__"></a> TryGetImageName\(nuint, out string?\)

```csharp
public abstract bool TryGetImageName(nuint image, out string? name)
```

#### Parameters

`image` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Unity_Runtime_Interop_MonoOperator_TryGetImages"></a> TryGetImages\(\)

```csharp
public abstract IEnumerable<nuint> TryGetImages()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)\>

### <a id="AslHelp_Unity_Runtime_Interop_MonoOperator_TryGetTypeAttributes_System_UIntPtr_AslHelp_Unity_Runtime_Interop_MonoFieldAttribute__"></a> TryGetTypeAttributes\(nuint, out MonoFieldAttribute\)

```csharp
public abstract bool TryGetTypeAttributes(nuint type, out MonoFieldAttribute attributes)
```

#### Parameters

`type` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`attributes` [MonoFieldAttribute](AslHelp.Unity.Runtime.Interop.MonoFieldAttribute.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Unity_Runtime_Interop_MonoOperator_TryGetTypeData_System_UIntPtr_System_UIntPtr__"></a> TryGetTypeData\(nuint, out nuint\)

```csharp
public abstract bool TryGetTypeData(nuint type, out nuint data)
```

#### Parameters

`type` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`data` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Unity_Runtime_Interop_MonoOperator_TryGetTypeElementType_System_UIntPtr_AslHelp_Unity_Runtime_Interop_MonoElementType__"></a> TryGetTypeElementType\(nuint, out MonoElementType\)

```csharp
public abstract bool TryGetTypeElementType(nuint type, out MonoElementType elementType)
```

#### Parameters

`type` [nuint](https://learn.microsoft.com/dotnet/api/system.uintptr)

`elementType` [MonoElementType](AslHelp.Unity.Runtime.Interop.MonoElementType.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

