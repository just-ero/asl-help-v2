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

[OrderedDictionary<string, Struct\>.Keys](AslHelp.Collections.OrderedDictionary\-2.Keys.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Keys), 
[OrderedDictionary<string, Struct\>.Values](AslHelp.Collections.OrderedDictionary\-2.Values.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Values), 
[OrderedDictionary<string, Struct\>.Count](AslHelp.Collections.OrderedDictionary\-2.Count.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Count), 
[OrderedDictionary<string, Struct\>.IsReadOnly](AslHelp.Collections.OrderedDictionary\-2.IsReadOnly.md\#AslHelp\_Collections\_OrderedDictionary\_2\_IsReadOnly), 
[OrderedDictionary<string, Struct\>.this\[string\]](AslHelp.Collections.OrderedDictionary\-2.Item.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Item\_\_0\_), 
[OrderedDictionary<string, Struct\>.this\[int\]](AslHelp.Collections.OrderedDictionary\-2.Item.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Item\_System\_Int32\_), 
[OrderedDictionary<string, Struct\>.Add\(Struct\)](AslHelp.Collections.OrderedDictionary\-2.Add.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Add\_\_1\_), 
[OrderedDictionary<string, Struct\>.Add\(string, Struct\)](AslHelp.Collections.OrderedDictionary\-2.Add.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Add\_\_0\_\_1\_), 
[OrderedDictionary<string, Struct\>.Add\(KeyValuePair<string, Struct\>\)](AslHelp.Collections.OrderedDictionary\-2.Add.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Add\_System\_Collections\_Generic\_KeyValuePair\_\_0\_\_1\_\_), 
[OrderedDictionary<string, Struct\>.Insert\(int, Struct\)](AslHelp.Collections.OrderedDictionary\-2.Insert.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Insert\_System\_Int32\_\_1\_), 
[OrderedDictionary<string, Struct\>.Remove\(Struct\)](AslHelp.Collections.OrderedDictionary\-2.Remove.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Remove\_\_1\_), 
[OrderedDictionary<string, Struct\>.Remove\(string\)](AslHelp.Collections.OrderedDictionary\-2.Remove.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Remove\_\_0\_), 
[OrderedDictionary<string, Struct\>.Remove\(KeyValuePair<string, Struct\>\)](AslHelp.Collections.OrderedDictionary\-2.Remove.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Remove\_System\_Collections\_Generic\_KeyValuePair\_\_0\_\_1\_\_), 
[OrderedDictionary<string, Struct\>.RemoveAt\(int\)](AslHelp.Collections.OrderedDictionary\-2.RemoveAt.md\#AslHelp\_Collections\_OrderedDictionary\_2\_RemoveAt\_System\_Int32\_), 
[OrderedDictionary<string, Struct\>.ContainsKey\(string\)](AslHelp.Collections.OrderedDictionary\-2.ContainsKey.md\#AslHelp\_Collections\_OrderedDictionary\_2\_ContainsKey\_\_0\_), 
[OrderedDictionary<string, Struct\>.Contains\(Struct\)](AslHelp.Collections.OrderedDictionary\-2.Contains.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Contains\_\_1\_), 
[OrderedDictionary<string, Struct\>.Contains\(KeyValuePair<string, Struct\>\)](AslHelp.Collections.OrderedDictionary\-2.Contains.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Contains\_System\_Collections\_Generic\_KeyValuePair\_\_0\_\_1\_\_), 
[OrderedDictionary<string, Struct\>.IndexOf\(Struct\)](AslHelp.Collections.OrderedDictionary\-2.IndexOf.md\#AslHelp\_Collections\_OrderedDictionary\_2\_IndexOf\_\_1\_), 
[OrderedDictionary<string, Struct\>.TryGetValue\(string, out Struct\)](AslHelp.Collections.OrderedDictionary\-2.TryGetValue.md\#AslHelp\_Collections\_OrderedDictionary\_2\_TryGetValue\_\_0\_\_1\_\_), 
[OrderedDictionary<string, Struct\>.Clear\(\)](AslHelp.Collections.OrderedDictionary\-2.Clear.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Clear), 
[OrderedDictionary<string, Struct\>.CopyTo\(Struct\[\], int\)](AslHelp.Collections.OrderedDictionary\-2.CopyTo.md\#AslHelp\_Collections\_OrderedDictionary\_2\_CopyTo\_\_1\_\_\_System\_Int32\_), 
[OrderedDictionary<string, Struct\>.CopyTo\(KeyValuePair<string, Struct\>\[\], int\)](AslHelp.Collections.OrderedDictionary\-2.CopyTo.md\#AslHelp\_Collections\_OrderedDictionary\_2\_CopyTo\_System\_Collections\_Generic\_KeyValuePair\_\_0\_\_1\_\_\_\_System\_Int32\_), 
[OrderedDictionary<string, Struct\>.GetEnumerator\(\)](AslHelp.Collections.OrderedDictionary\-2.GetEnumerator.md\#AslHelp\_Collections\_OrderedDictionary\_2\_GetEnumerator), 
[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetFieldValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetMethod.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetPropertyValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.IsType.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.SetFieldValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.SetPropertyValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Methods

 [GetKeyForItem\(Struct\)](AslHelp.Memory.StructReflection.Reflection.GetKeyForItem.md\#AslHelp\_Memory\_StructReflection\_Reflection\_GetKeyForItem\_AslHelp\_Memory\_StructReflection\_Struct\_)

 [Initialize\(bool, \(string, string, string\)\)](AslHelp.Memory.StructReflection.Reflection.Initialize.md\#AslHelp\_Memory\_StructReflection\_Reflection\_Initialize\_System\_Boolean\_System\_ValueTuple\_System\_String\_System\_String\_System\_String\_\_)

 [Initialize\(bool, \(string, string, string\), Assembly\)](AslHelp.Memory.StructReflection.Reflection.Initialize.md\#AslHelp\_Memory\_StructReflection\_Reflection\_Initialize\_System\_Boolean\_System\_ValueTuple\_System\_String\_System\_String\_System\_String\_\_System\_Reflection\_Assembly\_)

 [ToString\(\)](AslHelp.Memory.StructReflection.Reflection.ToString.md\#AslHelp\_Memory\_StructReflection\_Reflection\_ToString)

