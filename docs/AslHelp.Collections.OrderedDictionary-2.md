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

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Constructors

### <a id="AslHelp_Collections_OrderedDictionary_2__ctor_System_Collections_Generic_IEqualityComparer__0__"></a> OrderedDictionary\(IEqualityComparer<TKey\>?\)

```csharp
protected OrderedDictionary(IEqualityComparer<TKey>? comparer = null)
```

#### Parameters

`comparer` [IEqualityComparer](https://learn.microsoft.com/dotnet/api/system.collections.generic.iequalitycomparer\-1)<TKey\>?

## Properties

### <a id="AslHelp_Collections_OrderedDictionary_2_Count"></a> Count

```csharp
public int Count { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="AslHelp_Collections_OrderedDictionary_2_IsReadOnly"></a> IsReadOnly

```csharp
public bool IsReadOnly { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Collections_OrderedDictionary_2_Keys"></a> Keys

```csharp
public ICollection<TKey> Keys { get; }
```

#### Property Value

 [ICollection](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1)<TKey\>

### <a id="AslHelp_Collections_OrderedDictionary_2_Values"></a> Values

```csharp
public ICollection<TValue> Values { get; }
```

#### Property Value

 [ICollection](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1)<TValue\>

### <a id="AslHelp_Collections_OrderedDictionary_2_Item__0_"></a> this\[TKey\]

```csharp
public TValue this[TKey key] { get; set; }
```

#### Property Value

 TValue

### <a id="AslHelp_Collections_OrderedDictionary_2_Item_System_Int32_"></a> this\[int\]

```csharp
public TValue this[int index] { get; set; }
```

#### Property Value

 TValue

## Methods

### <a id="AslHelp_Collections_OrderedDictionary_2_Add__1_"></a> Add\(TValue\)

```csharp
public void Add(TValue item)
```

#### Parameters

`item` TValue

### <a id="AslHelp_Collections_OrderedDictionary_2_Add__0__1_"></a> Add\(TKey, TValue\)

```csharp
public void Add(TKey key, TValue value)
```

#### Parameters

`key` TKey

`value` TValue

### <a id="AslHelp_Collections_OrderedDictionary_2_Add_System_Collections_Generic_KeyValuePair__0__1__"></a> Add\(KeyValuePair<TKey, TValue\>\)

```csharp
public void Add(KeyValuePair<TKey, TValue> item)
```

#### Parameters

`item` [KeyValuePair](https://learn.microsoft.com/dotnet/api/system.collections.generic.keyvaluepair\-2)<TKey, TValue\>

### <a id="AslHelp_Collections_OrderedDictionary_2_Clear"></a> Clear\(\)

```csharp
public void Clear()
```

### <a id="AslHelp_Collections_OrderedDictionary_2_Contains__1_"></a> Contains\(TValue\)

```csharp
public bool Contains(TValue item)
```

#### Parameters

`item` TValue

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Collections_OrderedDictionary_2_Contains_System_Collections_Generic_KeyValuePair__0__1__"></a> Contains\(KeyValuePair<TKey, TValue\>\)

```csharp
public bool Contains(KeyValuePair<TKey, TValue> item)
```

#### Parameters

`item` [KeyValuePair](https://learn.microsoft.com/dotnet/api/system.collections.generic.keyvaluepair\-2)<TKey, TValue\>

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Collections_OrderedDictionary_2_ContainsKey__0_"></a> ContainsKey\(TKey\)

```csharp
public bool ContainsKey(TKey key)
```

#### Parameters

`key` TKey

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Collections_OrderedDictionary_2_CopyTo__1___System_Int32_"></a> CopyTo\(TValue\[\], int\)

```csharp
public void CopyTo(TValue[] array, int arrayIndex)
```

#### Parameters

`array` TValue\[\]

`arrayIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="AslHelp_Collections_OrderedDictionary_2_CopyTo_System_Collections_Generic_KeyValuePair__0__1____System_Int32_"></a> CopyTo\(KeyValuePair<TKey, TValue\>\[\], int\)

```csharp
public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
```

#### Parameters

`array` [KeyValuePair](https://learn.microsoft.com/dotnet/api/system.collections.generic.keyvaluepair\-2)<TKey, TValue\>\[\]

`arrayIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="AslHelp_Collections_OrderedDictionary_2_GetEnumerator"></a> GetEnumerator\(\)

```csharp
public IEnumerator<TValue> GetEnumerator()
```

#### Returns

 [IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerator\-1)<TValue\>

### <a id="AslHelp_Collections_OrderedDictionary_2_GetKeyForItem__1_"></a> GetKeyForItem\(TValue\)

```csharp
protected abstract TKey GetKeyForItem(TValue item)
```

#### Parameters

`item` TValue

#### Returns

 TKey

### <a id="AslHelp_Collections_OrderedDictionary_2_IndexOf__1_"></a> IndexOf\(TValue\)

```csharp
public int IndexOf(TValue item)
```

#### Parameters

`item` TValue

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="AslHelp_Collections_OrderedDictionary_2_Insert_System_Int32__1_"></a> Insert\(int, TValue\)

```csharp
public void Insert(int index, TValue item)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`item` TValue

### <a id="AslHelp_Collections_OrderedDictionary_2_Remove__1_"></a> Remove\(TValue\)

```csharp
public bool Remove(TValue item)
```

#### Parameters

`item` TValue

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Collections_OrderedDictionary_2_Remove__0_"></a> Remove\(TKey\)

```csharp
public bool Remove(TKey key)
```

#### Parameters

`key` TKey

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Collections_OrderedDictionary_2_Remove_System_Collections_Generic_KeyValuePair__0__1__"></a> Remove\(KeyValuePair<TKey, TValue\>\)

```csharp
public bool Remove(KeyValuePair<TKey, TValue> item)
```

#### Parameters

`item` [KeyValuePair](https://learn.microsoft.com/dotnet/api/system.collections.generic.keyvaluepair\-2)<TKey, TValue\>

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Collections_OrderedDictionary_2_RemoveAt_System_Int32_"></a> RemoveAt\(int\)

```csharp
public void RemoveAt(int index)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="AslHelp_Collections_OrderedDictionary_2_TryGetValue__0__1__"></a> TryGetValue\(TKey, out TValue\)

```csharp
public bool TryGetValue(TKey key, out TValue value)
```

#### Parameters

`key` TKey

`value` TValue

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

