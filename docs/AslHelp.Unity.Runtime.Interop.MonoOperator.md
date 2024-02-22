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

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetFieldValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetMethod.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetPropertyValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.IsType.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.SetFieldValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.SetPropertyValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Constructors

 [MonoOperator\(IMonoProcessMemory, Reflection, MonoDefaults, nuint\)](AslHelp.Unity.Runtime.Interop.MonoOperator.\-ctor.md\#AslHelp\_Unity\_Runtime\_Interop\_MonoOperator\_\_ctor\_AslHelp\_Unity\_Memory\_Ipc\_IMonoProcessMemory\_AslHelp\_Memory\_StructReflection\_Reflection\_AslHelp\_Unity\_Runtime\_Interop\_MonoDefaults\_System\_UIntPtr\_)

## Fields

 [\_defaults](AslHelp.Unity.Runtime.Interop.MonoOperator.\_defaults.md\#AslHelp\_Unity\_Runtime\_Interop\_MonoOperator\_\_defaults)

 [\_loadedAssemblies](AslHelp.Unity.Runtime.Interop.MonoOperator.\_loadedAssemblies.md\#AslHelp\_Unity\_Runtime\_Interop\_MonoOperator\_\_loadedAssemblies)

 [\_memory](AslHelp.Unity.Runtime.Interop.MonoOperator.\_memory.md\#AslHelp\_Unity\_Runtime\_Interop\_MonoOperator\_\_memory)

 [\_structs](AslHelp.Unity.Runtime.Interop.MonoOperator.\_structs.md\#AslHelp\_Unity\_Runtime\_Interop\_MonoOperator\_\_structs)

## Properties

 [Images](AslHelp.Unity.Runtime.Interop.MonoOperator.Images.md\#AslHelp\_Unity\_Runtime\_Interop\_MonoOperator\_Images)

## Methods

 [Create\(IMonoProcessMemory\)](AslHelp.Unity.Runtime.Interop.MonoOperator.Create.md\#AslHelp\_Unity\_Runtime\_Interop\_MonoOperator\_Create\_AslHelp\_Unity\_Memory\_Ipc\_IMonoProcessMemory\_)

 [TryGetClassName\(nuint, out string?\)](AslHelp.Unity.Runtime.Interop.MonoOperator.TryGetClassName.md\#AslHelp\_Unity\_Runtime\_Interop\_MonoOperator\_TryGetClassName\_System\_UIntPtr\_System\_String\_\_)

 [TryGetClassNamespace\(nuint, out string?\)](AslHelp.Unity.Runtime.Interop.MonoOperator.TryGetClassNamespace.md\#AslHelp\_Unity\_Runtime\_Interop\_MonoOperator\_TryGetClassNamespace\_System\_UIntPtr\_System\_String\_\_)

 [TryGetClassParent\(nuint, out nuint\)](AslHelp.Unity.Runtime.Interop.MonoOperator.TryGetClassParent.md\#AslHelp\_Unity\_Runtime\_Interop\_MonoOperator\_TryGetClassParent\_System\_UIntPtr\_System\_UIntPtr\_\_)

 [TryGetClassStaticDataChunk\(nuint, out nuint\)](AslHelp.Unity.Runtime.Interop.MonoOperator.TryGetClassStaticDataChunk.md\#AslHelp\_Unity\_Runtime\_Interop\_MonoOperator\_TryGetClassStaticDataChunk\_System\_UIntPtr\_System\_UIntPtr\_\_)

 [TryGetClasses\(nuint\)](AslHelp.Unity.Runtime.Interop.MonoOperator.TryGetClasses.md\#AslHelp\_Unity\_Runtime\_Interop\_MonoOperator\_TryGetClasses\_System\_UIntPtr\_)

 [TryGetFieldName\(nuint, out string?\)](AslHelp.Unity.Runtime.Interop.MonoOperator.TryGetFieldName.md\#AslHelp\_Unity\_Runtime\_Interop\_MonoOperator\_TryGetFieldName\_System\_UIntPtr\_System\_String\_\_)

 [TryGetFieldOffset\(nuint, out int\)](AslHelp.Unity.Runtime.Interop.MonoOperator.TryGetFieldOffset.md\#AslHelp\_Unity\_Runtime\_Interop\_MonoOperator\_TryGetFieldOffset\_System\_UIntPtr\_System\_Int32\_\_)

 [TryGetFieldType\(nuint, out nuint\)](AslHelp.Unity.Runtime.Interop.MonoOperator.TryGetFieldType.md\#AslHelp\_Unity\_Runtime\_Interop\_MonoOperator\_TryGetFieldType\_System\_UIntPtr\_System\_UIntPtr\_\_)

 [TryGetFields\(nuint\)](AslHelp.Unity.Runtime.Interop.MonoOperator.TryGetFields.md\#AslHelp\_Unity\_Runtime\_Interop\_MonoOperator\_TryGetFields\_System\_UIntPtr\_)

 [TryGetImageFileName\(nuint, out string?\)](AslHelp.Unity.Runtime.Interop.MonoOperator.TryGetImageFileName.md\#AslHelp\_Unity\_Runtime\_Interop\_MonoOperator\_TryGetImageFileName\_System\_UIntPtr\_System\_String\_\_)

 [TryGetImageName\(nuint, out string?\)](AslHelp.Unity.Runtime.Interop.MonoOperator.TryGetImageName.md\#AslHelp\_Unity\_Runtime\_Interop\_MonoOperator\_TryGetImageName\_System\_UIntPtr\_System\_String\_\_)

 [TryGetImages\(\)](AslHelp.Unity.Runtime.Interop.MonoOperator.TryGetImages.md\#AslHelp\_Unity\_Runtime\_Interop\_MonoOperator\_TryGetImages)

 [TryGetTypeAttributes\(nuint, out MonoFieldAttribute\)](AslHelp.Unity.Runtime.Interop.MonoOperator.TryGetTypeAttributes.md\#AslHelp\_Unity\_Runtime\_Interop\_MonoOperator\_TryGetTypeAttributes\_System\_UIntPtr\_AslHelp\_Unity\_Runtime\_Interop\_MonoFieldAttribute\_\_)

 [TryGetTypeData\(nuint, out nuint\)](AslHelp.Unity.Runtime.Interop.MonoOperator.TryGetTypeData.md\#AslHelp\_Unity\_Runtime\_Interop\_MonoOperator\_TryGetTypeData\_System\_UIntPtr\_System\_UIntPtr\_\_)

 [TryGetTypeElementType\(nuint, out MonoElementType\)](AslHelp.Unity.Runtime.Interop.MonoOperator.TryGetTypeElementType.md\#AslHelp\_Unity\_Runtime\_Interop\_MonoOperator\_TryGetTypeElementType\_System\_UIntPtr\_AslHelp\_Unity\_Runtime\_Interop\_MonoElementType\_\_)

