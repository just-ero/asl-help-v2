# <a id="AslHelp_Memory_StructReflection_Reflection"></a> Class Reflection

Namespace: [AslHelp.Memory.StructReflection](AslHelp.Memory.StructReflection.md)  
Assembly: AslHelp.Memory.dll  

```csharp
public sealed class Reflection : OrderedDictionary<string, Struct>, IDictionary<string, Struct>, ICollection<KeyValuePair<string, Struct>>, IReadOnlyDictionary<string, Struct>, IReadOnlyCollection<KeyValuePair<string, Struct>>, IEnumerable<KeyValuePair<string, Struct>>, IList<Struct>, ICollection<Struct>, IReadOnlyList<Struct>, IReadOnlyCollection<Struct>, IEnumerable<Struct>, IEnumerable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[OrderedDictionary<string, Struct\>](AslHelp.Collections.OrderedDictionary\-2.md) ← 
[Reflection](AslHelp.Memory.StructReflection.Reflection.md)

#### Implements

[IDictionary<string, Struct\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.idictionary\-2), 
[ICollection<KeyValuePair<string, Struct\>\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1), 
[IReadOnlyDictionary<string, Struct\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlydictionary\-2), 
[IReadOnlyCollection<KeyValuePair<string, Struct\>\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection\-1), 
[IEnumerable<KeyValuePair<string, Struct\>\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IList<Struct\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist\-1), 
[ICollection<Struct\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1), 
[IReadOnlyList<Struct\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1), 
[IReadOnlyCollection<Struct\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection\-1), 
[IEnumerable<Struct\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable)

#### Inherited Members

[OrderedDictionary<string, Struct\>.Keys](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Keys), 
[OrderedDictionary<string, Struct\>.Values](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Values), 
[OrderedDictionary<string, Struct\>.Count](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Count), 
[OrderedDictionary<string, Struct\>.IsReadOnly](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_IsReadOnly), 
[OrderedDictionary<string, Struct\>.this\[string\]](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Item\_\_0\_), 
[OrderedDictionary<string, Struct\>.this\[int\]](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Item\_System\_Int32\_), 
[OrderedDictionary<string, Struct\>.Add\(Struct\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Add\_\_1\_), 
[OrderedDictionary<string, Struct\>.Add\(string, Struct\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Add\_\_0\_\_1\_), 
[OrderedDictionary<string, Struct\>.Add\(KeyValuePair<string, Struct\>\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Add\_System\_Collections\_Generic\_KeyValuePair\_\_0\_\_1\_\_), 
[OrderedDictionary<string, Struct\>.Insert\(int, Struct\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Insert\_System\_Int32\_\_1\_), 
[OrderedDictionary<string, Struct\>.Remove\(Struct\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Remove\_\_1\_), 
[OrderedDictionary<string, Struct\>.Remove\(string\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Remove\_\_0\_), 
[OrderedDictionary<string, Struct\>.Remove\(KeyValuePair<string, Struct\>\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Remove\_System\_Collections\_Generic\_KeyValuePair\_\_0\_\_1\_\_), 
[OrderedDictionary<string, Struct\>.RemoveAt\(int\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_RemoveAt\_System\_Int32\_), 
[OrderedDictionary<string, Struct\>.ContainsKey\(string\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_ContainsKey\_\_0\_), 
[OrderedDictionary<string, Struct\>.Contains\(Struct\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Contains\_\_1\_), 
[OrderedDictionary<string, Struct\>.Contains\(KeyValuePair<string, Struct\>\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Contains\_System\_Collections\_Generic\_KeyValuePair\_\_0\_\_1\_\_), 
[OrderedDictionary<string, Struct\>.IndexOf\(Struct\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_IndexOf\_\_1\_), 
[OrderedDictionary<string, Struct\>.TryGetValue\(string, out Struct\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_TryGetValue\_\_0\_\_1\_\_), 
[OrderedDictionary<string, Struct\>.Clear\(\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Clear), 
[OrderedDictionary<string, Struct\>.CopyTo\(Struct\[\], int\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_CopyTo\_\_1\_\_\_System\_Int32\_), 
[OrderedDictionary<string, Struct\>.CopyTo\(KeyValuePair<string, Struct\>\[\], int\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_CopyTo\_System\_Collections\_Generic\_KeyValuePair\_\_0\_\_1\_\_\_\_System\_Int32\_), 
[OrderedDictionary<string, Struct\>.GetEnumerator\(\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_GetEnumerator), 
[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Methods

### <a id="AslHelp_Memory_StructReflection_Reflection_GetKeyForItem_AslHelp_Memory_StructReflection_Struct_"></a> GetKeyForItem\(Struct\)

```csharp
protected override string GetKeyForItem(Struct item)
```

#### Parameters

`item` [Struct](AslHelp.Memory.StructReflection.Struct.md)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="AslHelp_Memory_StructReflection_Reflection_Initialize_System_Boolean_System_ValueTuple_System_String_System_String_System_String__"></a> Initialize\(bool, \(string, string, string\)\)

```csharp
public static Result<Reflection> Initialize(bool is64Bit, (string, string, string) resourceData)
```

#### Parameters

`is64Bit` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`resourceData` \([string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)\)

#### Returns

 [Result](AslHelp.Common.Results.Result\-1.md)<[Reflection](AslHelp.Memory.StructReflection.Reflection.md)\>

### <a id="AslHelp_Memory_StructReflection_Reflection_Initialize_System_Boolean_System_ValueTuple_System_String_System_String_System_String__System_Reflection_Assembly_"></a> Initialize\(bool, \(string, string, string\), Assembly\)

```csharp
public static Result<Reflection> Initialize(bool is64Bit, (string, string, string) resourceData, Assembly containingAssembly)
```

#### Parameters

`is64Bit` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`resourceData` \([string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)\)

`containingAssembly` [Assembly](https://learn.microsoft.com/dotnet/api/system.reflection.assembly)

#### Returns

 [Result](AslHelp.Common.Results.Result\-1.md)<[Reflection](AslHelp.Memory.StructReflection.Reflection.md)\>

### <a id="AslHelp_Memory_StructReflection_Reflection_ToString"></a> ToString\(\)

```csharp
public override sealed string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

