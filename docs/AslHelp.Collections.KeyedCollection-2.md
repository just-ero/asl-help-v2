# <a id="AslHelp_Collections_KeyedCollection_2"></a> Class KeyedCollection<TKey, TValue\>

Namespace: [AslHelp.Collections](AslHelp.Collections.md)  
Assembly: AslHelp.Collections.dll  

The <xref href="AslHelp.Collections.KeyedCollection%602" data-throw-if-not-resolved="false"></xref> class
provides an abstract interface for enumerable collections with an internal cache.<br />
The cache is populated during enumeration and can be accessed using a key corresponding to the value.

```csharp
public abstract class KeyedCollection<TKey, TValue> : IReadOnlyKeyedCollection<TKey, TValue>, IReadOnlyCollection<TValue>, IEnumerable<TValue>, IEnumerable where TKey : notnull
```

#### Type Parameters

`TKey` 

The type of the keys for the <xref href="AslHelp.Collections.KeyedCollection%602" data-throw-if-not-resolved="false"></xref>.

`TValue` 

The type of the values in the <xref href="AslHelp.Collections.KeyedCollection%602" data-throw-if-not-resolved="false"></xref>.

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[KeyedCollection<TKey, TValue\>](AslHelp.Collections.KeyedCollection\-2.md)

#### Implements

[IReadOnlyKeyedCollection<TKey, TValue\>](AslHelp.Collections.IReadOnlyKeyedCollection\-2.md), 
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

### <a id="AslHelp_Collections_KeyedCollection_2__ctor"></a> KeyedCollection\(\)

```csharp
protected KeyedCollection()
```

### <a id="AslHelp_Collections_KeyedCollection_2__ctor_System_Collections_Generic_IEqualityComparer__0__"></a> KeyedCollection\(IEqualityComparer<TKey\>\)

```csharp
protected KeyedCollection(IEqualityComparer<TKey> comparer)
```

#### Parameters

`comparer` [IEqualityComparer](https://learn.microsoft.com/dotnet/api/system.collections.generic.iequalitycomparer\-1)<TKey\>

## Properties

### <a id="AslHelp_Collections_KeyedCollection_2_Count"></a> Count

```csharp
public int Count { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="AslHelp_Collections_KeyedCollection_2_Keys"></a> Keys

```csharp
public IEnumerable<TKey> Keys { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<TKey\>

### <a id="AslHelp_Collections_KeyedCollection_2_Values"></a> Values

```csharp
public IEnumerable<TValue> Values { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<TValue\>

### <a id="AslHelp_Collections_KeyedCollection_2_Item__0_"></a> this\[TKey\]

```csharp
public TValue this[TKey key] { get; }
```

#### Property Value

 TValue

## Methods

### <a id="AslHelp_Collections_KeyedCollection_2_Clear"></a> Clear\(\)

```csharp
public void Clear()
```

### <a id="AslHelp_Collections_KeyedCollection_2_ContainsKey__0_"></a> ContainsKey\(TKey\)

```csharp
public bool ContainsKey(TKey key)
```

#### Parameters

`key` TKey

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Collections_KeyedCollection_2_GetEnumerator"></a> GetEnumerator\(\)

```csharp
public abstract IEnumerator<TValue> GetEnumerator()
```

#### Returns

 [IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerator\-1)<TValue\>

### <a id="AslHelp_Collections_KeyedCollection_2_KeyNotFoundMessage__0_"></a> KeyNotFoundMessage\(TKey\)

```csharp
protected virtual string KeyNotFoundMessage(TKey key)
```

#### Parameters

`key` TKey

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="AslHelp_Collections_KeyedCollection_2_OnFound__1_"></a> OnFound\(TValue\)

```csharp
protected virtual void OnFound(TValue value)
```

#### Parameters

`value` TValue

### <a id="AslHelp_Collections_KeyedCollection_2_OnNotFound__0_"></a> OnNotFound\(TKey\)

```csharp
protected virtual void OnNotFound(TKey key)
```

#### Parameters

`key` TKey

### <a id="AslHelp_Collections_KeyedCollection_2_OnSearch__0_"></a> OnSearch\(TKey\)

```csharp
protected virtual void OnSearch(TKey key)
```

#### Parameters

`key` TKey

### <a id="AslHelp_Collections_KeyedCollection_2_TryGetKey__1__0__"></a> TryGetKey\(TValue, out TKey?\)

```csharp
protected abstract bool TryGetKey(TValue value, out TKey? key)
```

#### Parameters

`value` TValue

`key` TKey?

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Collections_KeyedCollection_2_TryGetValue__0__1__"></a> TryGetValue\(TKey, out TValue\)

```csharp
public bool TryGetValue(TKey key, out TValue value)
```

#### Parameters

`key` TKey

`value` TValue

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

