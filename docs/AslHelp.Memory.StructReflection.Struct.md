# <a id="AslHelp_Memory_StructReflection_Struct"></a> Class Struct

Namespace: [AslHelp.Memory.StructReflection](AslHelp.Memory.StructReflection.md)  
Assembly: AslHelp.Memory.dll  

```csharp
public sealed class Struct : OrderedDictionary<string, Field>, IDictionary<string, Field>, ICollection<KeyValuePair<string, Field>>, IReadOnlyDictionary<string, Field>, IReadOnlyCollection<KeyValuePair<string, Field>>, IEnumerable<KeyValuePair<string, Field>>, IList<Field>, ICollection<Field>, IReadOnlyList<Field>, IReadOnlyCollection<Field>, IEnumerable<Field>, IEnumerable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[OrderedDictionary<string, Field\>](AslHelp.Collections.OrderedDictionary\-2.md) ← 
[Struct](AslHelp.Memory.StructReflection.Struct.md)

#### Implements

[IDictionary<string, Field\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.idictionary\-2), 
[ICollection<KeyValuePair<string, Field\>\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1), 
[IReadOnlyDictionary<string, Field\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlydictionary\-2), 
[IReadOnlyCollection<KeyValuePair<string, Field\>\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection\-1), 
[IEnumerable<KeyValuePair<string, Field\>\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IList<Field\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist\-1), 
[ICollection<Field\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1), 
[IReadOnlyList<Field\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1), 
[IReadOnlyCollection<Field\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection\-1), 
[IEnumerable<Field\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable)

#### Inherited Members

[OrderedDictionary<string, Field\>.Keys](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Keys), 
[OrderedDictionary<string, Field\>.Values](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Values), 
[OrderedDictionary<string, Field\>.Count](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Count), 
[OrderedDictionary<string, Field\>.IsReadOnly](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_IsReadOnly), 
[OrderedDictionary<string, Field\>.this\[string\]](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Item\_\_0\_), 
[OrderedDictionary<string, Field\>.this\[int\]](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Item\_System\_Int32\_), 
[OrderedDictionary<string, Field\>.Add\(Field\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Add\_\_1\_), 
[OrderedDictionary<string, Field\>.Add\(string, Field\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Add\_\_0\_\_1\_), 
[OrderedDictionary<string, Field\>.Add\(KeyValuePair<string, Field\>\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Add\_System\_Collections\_Generic\_KeyValuePair\_\_0\_\_1\_\_), 
[OrderedDictionary<string, Field\>.Insert\(int, Field\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Insert\_System\_Int32\_\_1\_), 
[OrderedDictionary<string, Field\>.Remove\(Field\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Remove\_\_1\_), 
[OrderedDictionary<string, Field\>.Remove\(string\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Remove\_\_0\_), 
[OrderedDictionary<string, Field\>.Remove\(KeyValuePair<string, Field\>\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Remove\_System\_Collections\_Generic\_KeyValuePair\_\_0\_\_1\_\_), 
[OrderedDictionary<string, Field\>.RemoveAt\(int\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_RemoveAt\_System\_Int32\_), 
[OrderedDictionary<string, Field\>.ContainsKey\(string\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_ContainsKey\_\_0\_), 
[OrderedDictionary<string, Field\>.Contains\(Field\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Contains\_\_1\_), 
[OrderedDictionary<string, Field\>.Contains\(KeyValuePair<string, Field\>\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Contains\_System\_Collections\_Generic\_KeyValuePair\_\_0\_\_1\_\_), 
[OrderedDictionary<string, Field\>.IndexOf\(Field\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_IndexOf\_\_1\_), 
[OrderedDictionary<string, Field\>.TryGetValue\(string, out Field\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_TryGetValue\_\_0\_\_1\_\_), 
[OrderedDictionary<string, Field\>.Clear\(\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Clear), 
[OrderedDictionary<string, Field\>.CopyTo\(Field\[\], int\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_CopyTo\_\_1\_\_\_System\_Int32\_), 
[OrderedDictionary<string, Field\>.CopyTo\(KeyValuePair<string, Field\>\[\], int\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_CopyTo\_System\_Collections\_Generic\_KeyValuePair\_\_0\_\_1\_\_\_\_System\_Int32\_), 
[OrderedDictionary<string, Field\>.GetEnumerator\(\)](AslHelp.Collections.OrderedDictionary\-2.md\#AslHelp\_Collections\_OrderedDictionary\_2\_GetEnumerator), 
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

## Properties

### <a id="AslHelp_Memory_StructReflection_Struct_SelfAlignedSize"></a> SelfAlignedSize

```csharp
public uint SelfAlignedSize { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="AslHelp_Memory_StructReflection_Struct_GetKeyForItem_AslHelp_Memory_StructReflection_Field_"></a> GetKeyForItem\(Field\)

```csharp
protected override string GetKeyForItem(Field item)
```

#### Parameters

`item` [Field](AslHelp.Memory.StructReflection.Field.md)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="AslHelp_Memory_StructReflection_Struct_ToString"></a> ToString\(\)

```csharp
public override sealed string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

