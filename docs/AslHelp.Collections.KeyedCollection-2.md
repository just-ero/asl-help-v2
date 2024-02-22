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

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetFieldValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetMethod.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetPropertyValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.IsType.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.SetFieldValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.SetPropertyValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Constructors

 [KeyedCollection\(\)](AslHelp.Collections.KeyedCollection\-2.\-ctor.md\#AslHelp\_Collections\_KeyedCollection\_2\_\_ctor)

 [KeyedCollection\(IEqualityComparer<TKey\>\)](AslHelp.Collections.KeyedCollection\-2.\-ctor.md\#AslHelp\_Collections\_KeyedCollection\_2\_\_ctor\_System\_Collections\_Generic\_IEqualityComparer\_\_0\_\_)

## Properties

 [Count](AslHelp.Collections.KeyedCollection\-2.Count.md\#AslHelp\_Collections\_KeyedCollection\_2\_Count)

 [Keys](AslHelp.Collections.KeyedCollection\-2.Keys.md\#AslHelp\_Collections\_KeyedCollection\_2\_Keys)

 [Values](AslHelp.Collections.KeyedCollection\-2.Values.md\#AslHelp\_Collections\_KeyedCollection\_2\_Values)

 [this\[TKey\]](AslHelp.Collections.KeyedCollection\-2.Item.md\#AslHelp\_Collections\_KeyedCollection\_2\_Item\_\_0\_)

## Methods

 [Clear\(\)](AslHelp.Collections.KeyedCollection\-2.Clear.md\#AslHelp\_Collections\_KeyedCollection\_2\_Clear)

 [ContainsKey\(TKey\)](AslHelp.Collections.KeyedCollection\-2.ContainsKey.md\#AslHelp\_Collections\_KeyedCollection\_2\_ContainsKey\_\_0\_)

 [GetEnumerator\(\)](AslHelp.Collections.KeyedCollection\-2.GetEnumerator.md\#AslHelp\_Collections\_KeyedCollection\_2\_GetEnumerator)

 [KeyNotFoundMessage\(TKey\)](AslHelp.Collections.KeyedCollection\-2.KeyNotFoundMessage.md\#AslHelp\_Collections\_KeyedCollection\_2\_KeyNotFoundMessage\_\_0\_)

 [OnFound\(TValue\)](AslHelp.Collections.KeyedCollection\-2.OnFound.md\#AslHelp\_Collections\_KeyedCollection\_2\_OnFound\_\_1\_)

 [OnNotFound\(TKey\)](AslHelp.Collections.KeyedCollection\-2.OnNotFound.md\#AslHelp\_Collections\_KeyedCollection\_2\_OnNotFound\_\_0\_)

 [OnSearch\(TKey\)](AslHelp.Collections.KeyedCollection\-2.OnSearch.md\#AslHelp\_Collections\_KeyedCollection\_2\_OnSearch\_\_0\_)

 [TryGetKey\(TValue, out TKey?\)](AslHelp.Collections.KeyedCollection\-2.TryGetKey.md\#AslHelp\_Collections\_KeyedCollection\_2\_TryGetKey\_\_1\_\_0\_\_)

 [TryGetValue\(TKey, out TValue\)](AslHelp.Collections.KeyedCollection\-2.TryGetValue.md\#AslHelp\_Collections\_KeyedCollection\_2\_TryGetValue\_\_0\_\_1\_\_)

