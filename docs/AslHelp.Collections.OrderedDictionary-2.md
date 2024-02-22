# <a id="AslHelp_Collections_OrderedDictionary_2"></a> Class OrderedDictionary<TKey, TValue\>

Namespace: [AslHelp.Collections](AslHelp.Collections.md)  
Assembly: AslHelp.Collections.dll  

```csharp
public abstract class OrderedDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IList<TValue>, ICollection<TValue>, IReadOnlyList<TValue>, IReadOnlyCollection<TValue>, IEnumerable<TValue>, IEnumerable where TKey : notnull
```

#### Type Parameters

`TKey` 

`TValue` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[OrderedDictionary<TKey, TValue\>](AslHelp.Collections.OrderedDictionary\-2.md)

#### Implements

[IDictionary<TKey, TValue\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.idictionary\-2), 
[ICollection<KeyValuePair<TKey, TValue\>\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1), 
[IReadOnlyDictionary<TKey, TValue\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlydictionary\-2), 
[IReadOnlyCollection<KeyValuePair<TKey, TValue\>\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection\-1), 
[IEnumerable<KeyValuePair<TKey, TValue\>\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IList<TValue\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist\-1), 
[ICollection<TValue\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1), 
[IReadOnlyList<TValue\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1), 
[IReadOnlyCollection<TValue\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection\-1), 
[IEnumerable<TValue\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetFieldValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetMethod.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetPropertyValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.IsType.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.SetFieldValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.SetPropertyValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Constructors

 [OrderedDictionary\(IEqualityComparer<TKey\>?\)](AslHelp.Collections.OrderedDictionary\-2.\-ctor.md\#AslHelp\_Collections\_OrderedDictionary\_2\_\_ctor\_System\_Collections\_Generic\_IEqualityComparer\_\_0\_\_)

## Properties

 [Count](AslHelp.Collections.OrderedDictionary\-2.Count.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Count)

 [IsReadOnly](AslHelp.Collections.OrderedDictionary\-2.IsReadOnly.md\#AslHelp\_Collections\_OrderedDictionary\_2\_IsReadOnly)

 [Keys](AslHelp.Collections.OrderedDictionary\-2.Keys.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Keys)

 [Values](AslHelp.Collections.OrderedDictionary\-2.Values.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Values)

 [this\[TKey\]](AslHelp.Collections.OrderedDictionary\-2.Item.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Item\_\_0\_)

 [this\[int\]](AslHelp.Collections.OrderedDictionary\-2.Item.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Item\_System\_Int32\_)

## Methods

 [Add\(TValue\)](AslHelp.Collections.OrderedDictionary\-2.Add.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Add\_\_1\_)

 [Add\(TKey, TValue\)](AslHelp.Collections.OrderedDictionary\-2.Add.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Add\_\_0\_\_1\_)

 [Add\(KeyValuePair<TKey, TValue\>\)](AslHelp.Collections.OrderedDictionary\-2.Add.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Add\_System\_Collections\_Generic\_KeyValuePair\_\_0\_\_1\_\_)

 [Clear\(\)](AslHelp.Collections.OrderedDictionary\-2.Clear.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Clear)

 [Contains\(TValue\)](AslHelp.Collections.OrderedDictionary\-2.Contains.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Contains\_\_1\_)

 [Contains\(KeyValuePair<TKey, TValue\>\)](AslHelp.Collections.OrderedDictionary\-2.Contains.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Contains\_System\_Collections\_Generic\_KeyValuePair\_\_0\_\_1\_\_)

 [ContainsKey\(TKey\)](AslHelp.Collections.OrderedDictionary\-2.ContainsKey.md\#AslHelp\_Collections\_OrderedDictionary\_2\_ContainsKey\_\_0\_)

 [CopyTo\(TValue\[\], int\)](AslHelp.Collections.OrderedDictionary\-2.CopyTo.md\#AslHelp\_Collections\_OrderedDictionary\_2\_CopyTo\_\_1\_\_\_System\_Int32\_)

 [CopyTo\(KeyValuePair<TKey, TValue\>\[\], int\)](AslHelp.Collections.OrderedDictionary\-2.CopyTo.md\#AslHelp\_Collections\_OrderedDictionary\_2\_CopyTo\_System\_Collections\_Generic\_KeyValuePair\_\_0\_\_1\_\_\_\_System\_Int32\_)

 [GetEnumerator\(\)](AslHelp.Collections.OrderedDictionary\-2.GetEnumerator.md\#AslHelp\_Collections\_OrderedDictionary\_2\_GetEnumerator)

 [GetKeyForItem\(TValue\)](AslHelp.Collections.OrderedDictionary\-2.GetKeyForItem.md\#AslHelp\_Collections\_OrderedDictionary\_2\_GetKeyForItem\_\_1\_)

 [IndexOf\(TValue\)](AslHelp.Collections.OrderedDictionary\-2.IndexOf.md\#AslHelp\_Collections\_OrderedDictionary\_2\_IndexOf\_\_1\_)

 [Insert\(int, TValue\)](AslHelp.Collections.OrderedDictionary\-2.Insert.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Insert\_System\_Int32\_\_1\_)

 [Remove\(TValue\)](AslHelp.Collections.OrderedDictionary\-2.Remove.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Remove\_\_1\_)

 [Remove\(TKey\)](AslHelp.Collections.OrderedDictionary\-2.Remove.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Remove\_\_0\_)

 [Remove\(KeyValuePair<TKey, TValue\>\)](AslHelp.Collections.OrderedDictionary\-2.Remove.md\#AslHelp\_Collections\_OrderedDictionary\_2\_Remove\_System\_Collections\_Generic\_KeyValuePair\_\_0\_\_1\_\_)

 [RemoveAt\(int\)](AslHelp.Collections.OrderedDictionary\-2.RemoveAt.md\#AslHelp\_Collections\_OrderedDictionary\_2\_RemoveAt\_System\_Int32\_)

 [TryGetValue\(TKey, out TValue\)](AslHelp.Collections.OrderedDictionary\-2.TryGetValue.md\#AslHelp\_Collections\_OrderedDictionary\_2\_TryGetValue\_\_0\_\_1\_\_)

