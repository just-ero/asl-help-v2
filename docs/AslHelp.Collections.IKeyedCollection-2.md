# <a id="AslHelp_Collections_IKeyedCollection_2"></a> Interface IKeyedCollection<TKey, TValue\>

Namespace: [AslHelp.Collections](AslHelp.Collections.md)  
Assembly: AslHelp.Collections.dll  

```csharp
public interface IKeyedCollection<TKey, TValue> : ICollection<TValue>, IReadOnlyCollection<TValue>, IEnumerable<TValue>, IEnumerable
```

#### Type Parameters

`TKey` 

`TValue` 

#### Implements

[ICollection<TValue\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1), 
[IReadOnlyCollection<TValue\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection\-1), 
[IEnumerable<TValue\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable)

#### Extension Methods

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Properties

### <a id="AslHelp_Collections_IKeyedCollection_2_Keys"></a> Keys

```csharp
ICollection<TKey> Keys { get; }
```

#### Property Value

 [ICollection](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1)<TKey\>

### <a id="AslHelp_Collections_IKeyedCollection_2_Values"></a> Values

```csharp
ICollection<TValue> Values { get; }
```

#### Property Value

 [ICollection](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1)<TValue\>

### <a id="AslHelp_Collections_IKeyedCollection_2_Item__0_"></a> this\[TKey\]

```csharp
TValue this[TKey key] { get; set; }
```

#### Property Value

 TValue

## Methods

### <a id="AslHelp_Collections_IKeyedCollection_2_Add__0__1_"></a> Add\(TKey, TValue\)

```csharp
void Add(TKey key, TValue value)
```

#### Parameters

`key` TKey

`value` TValue

### <a id="AslHelp_Collections_IKeyedCollection_2_ContainsKey__0_"></a> ContainsKey\(TKey\)

```csharp
bool ContainsKey(TKey key)
```

#### Parameters

`key` TKey

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Collections_IKeyedCollection_2_Remove__0_"></a> Remove\(TKey\)

```csharp
bool Remove(TKey key)
```

#### Parameters

`key` TKey

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Collections_IKeyedCollection_2_TryGetValue__0__1__"></a> TryGetValue\(TKey, out TValue\)

```csharp
bool TryGetValue(TKey key, out TValue value)
```

#### Parameters

`key` TKey

`value` TValue

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

