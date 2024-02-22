# <a id="AslHelp_Memory_Watch_Initialization_WatcherFactory"></a> Class WatcherFactory

Namespace: [AslHelp.Memory.Watch.Initialization](AslHelp.Memory.Watch.Initialization.md)  
Assembly: AslHelp.Memory.dll  

```csharp
public sealed class WatcherFactory : Dictionary<string, IWatcher>, IDictionary<string, IWatcher>, ICollection<KeyValuePair<string, IWatcher>>, IReadOnlyDictionary<string, IWatcher>, IReadOnlyCollection<KeyValuePair<string, IWatcher>>, IEnumerable<KeyValuePair<string, IWatcher>>, IDictionary, ICollection, IEnumerable, IDeserializationCallback, ISerializable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Dictionary<string, IWatcher\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2) ← 
[WatcherFactory](AslHelp.Memory.Watch.Initialization.WatcherFactory.md)

#### Implements

[IDictionary<string, IWatcher\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.idictionary\-2), 
[ICollection<KeyValuePair<string, IWatcher\>\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1), 
[IReadOnlyDictionary<string, IWatcher\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlydictionary\-2), 
[IReadOnlyCollection<KeyValuePair<string, IWatcher\>\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection\-1), 
[IEnumerable<KeyValuePair<string, IWatcher\>\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IDictionary](https://learn.microsoft.com/dotnet/api/system.collections.idictionary), 
[ICollection](https://learn.microsoft.com/dotnet/api/system.collections.icollection), 
[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable), 
[IDeserializationCallback](https://learn.microsoft.com/dotnet/api/system.runtime.serialization.ideserializationcallback), 
[ISerializable](https://learn.microsoft.com/dotnet/api/system.runtime.serialization.iserializable)

#### Inherited Members

[Dictionary<string, IWatcher\>.Add\(string, IWatcher\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.add), 
[Dictionary<string, IWatcher\>.Clear\(\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.clear), 
[Dictionary<string, IWatcher\>.ContainsKey\(string\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.containskey), 
[Dictionary<string, IWatcher\>.ContainsValue\(IWatcher\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.containsvalue), 
[Dictionary<string, IWatcher\>.GetEnumerator\(\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.getenumerator), 
[Dictionary<string, IWatcher\>.GetObjectData\(SerializationInfo, StreamingContext\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.getobjectdata), 
[Dictionary<string, IWatcher\>.OnDeserialization\(object\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.ondeserialization), 
[Dictionary<string, IWatcher\>.Remove\(string\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.remove), 
[Dictionary<string, IWatcher\>.TryGetValue\(string, out IWatcher\)](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.trygetvalue), 
[Dictionary<string, IWatcher\>.Comparer](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.comparer), 
[Dictionary<string, IWatcher\>.Count](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.count), 
[Dictionary<string, IWatcher\>.this\[string\]](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.item), 
[Dictionary<string, IWatcher\>.Keys](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.keys), 
[Dictionary<string, IWatcher\>.Values](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2.values), 
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

## Constructors

 [WatcherFactory\(IProcessMemory\)](AslHelp.Memory.Watch.Initialization.WatcherFactory.\-ctor.md\#AslHelp\_Memory\_Watch\_Initialization\_WatcherFactory\_\_ctor\_AslHelp\_Memory\_Ipc\_IProcessMemory\_)

## Methods

 [Create<T\>\(uint, params int\[\]\)](AslHelp.Memory.Watch.Initialization.WatcherFactory.Create.md\#AslHelp\_Memory\_Watch\_Initialization\_WatcherFactory\_Create\_\_1\_System\_UInt32\_System\_Int32\_\_\_)

 [Create<T\>\(string, uint, params int\[\]\)](AslHelp.Memory.Watch.Initialization.WatcherFactory.Create.md\#AslHelp\_Memory\_Watch\_Initialization\_WatcherFactory\_Create\_\_1\_System\_String\_System\_UInt32\_System\_Int32\_\_\_)

 [Create<T\>\(Module, uint, params int\[\]\)](AslHelp.Memory.Watch.Initialization.WatcherFactory.Create.md\#AslHelp\_Memory\_Watch\_Initialization\_WatcherFactory\_Create\_\_1\_AslHelp\_Memory\_Module\_System\_UInt32\_System\_Int32\_\_\_)

 [Create<T\>\(nuint, params int\[\]\)](AslHelp.Memory.Watch.Initialization.WatcherFactory.Create.md\#AslHelp\_Memory\_Watch\_Initialization\_WatcherFactory\_Create\_\_1\_System\_UIntPtr\_System\_Int32\_\_\_)

 [CreateSpan<T\>\(int, uint, params int\[\]\)](AslHelp.Memory.Watch.Initialization.WatcherFactory.CreateSpan.md\#AslHelp\_Memory\_Watch\_Initialization\_WatcherFactory\_CreateSpan\_\_1\_System\_Int32\_System\_UInt32\_System\_Int32\_\_\_)

 [CreateSpan<T\>\(int, string, uint, params int\[\]\)](AslHelp.Memory.Watch.Initialization.WatcherFactory.CreateSpan.md\#AslHelp\_Memory\_Watch\_Initialization\_WatcherFactory\_CreateSpan\_\_1\_System\_Int32\_System\_String\_System\_UInt32\_System\_Int32\_\_\_)

 [CreateSpan<T\>\(int, Module, uint, params int\[\]\)](AslHelp.Memory.Watch.Initialization.WatcherFactory.CreateSpan.md\#AslHelp\_Memory\_Watch\_Initialization\_WatcherFactory\_CreateSpan\_\_1\_System\_Int32\_AslHelp\_Memory\_Module\_System\_UInt32\_System\_Int32\_\_\_)

 [CreateSpan<T\>\(int, nuint, params int\[\]\)](AslHelp.Memory.Watch.Initialization.WatcherFactory.CreateSpan.md\#AslHelp\_Memory\_Watch\_Initialization\_WatcherFactory\_CreateSpan\_\_1\_System\_Int32\_System\_UIntPtr\_System\_Int32\_\_\_)

 [CreateString\(int, uint, params int\[\]\)](AslHelp.Memory.Watch.Initialization.WatcherFactory.CreateString.md\#AslHelp\_Memory\_Watch\_Initialization\_WatcherFactory\_CreateString\_System\_Int32\_System\_UInt32\_System\_Int32\_\_\_)

 [CreateString\(int, string, uint, params int\[\]\)](AslHelp.Memory.Watch.Initialization.WatcherFactory.CreateString.md\#AslHelp\_Memory\_Watch\_Initialization\_WatcherFactory\_CreateString\_System\_Int32\_System\_String\_System\_UInt32\_System\_Int32\_\_\_)

 [CreateString\(int, Module, uint, params int\[\]\)](AslHelp.Memory.Watch.Initialization.WatcherFactory.CreateString.md\#AslHelp\_Memory\_Watch\_Initialization\_WatcherFactory\_CreateString\_System\_Int32\_AslHelp\_Memory\_Module\_System\_UInt32\_System\_Int32\_\_\_)

 [CreateString\(int, nuint, params int\[\]\)](AslHelp.Memory.Watch.Initialization.WatcherFactory.CreateString.md\#AslHelp\_Memory\_Watch\_Initialization\_WatcherFactory\_CreateString\_System\_Int32\_System\_UIntPtr\_System\_Int32\_\_\_)

 [CreateString\(int, StringType, uint, params int\[\]\)](AslHelp.Memory.Watch.Initialization.WatcherFactory.CreateString.md\#AslHelp\_Memory\_Watch\_Initialization\_WatcherFactory\_CreateString\_System\_Int32\_AslHelp\_Memory\_StringType\_System\_UInt32\_System\_Int32\_\_\_)

 [CreateString\(int, StringType, string, uint, params int\[\]\)](AslHelp.Memory.Watch.Initialization.WatcherFactory.CreateString.md\#AslHelp\_Memory\_Watch\_Initialization\_WatcherFactory\_CreateString\_System\_Int32\_AslHelp\_Memory\_StringType\_System\_String\_System\_UInt32\_System\_Int32\_\_\_)

 [CreateString\(int, StringType, Module, uint, params int\[\]\)](AslHelp.Memory.Watch.Initialization.WatcherFactory.CreateString.md\#AslHelp\_Memory\_Watch\_Initialization\_WatcherFactory\_CreateString\_System\_Int32\_AslHelp\_Memory\_StringType\_AslHelp\_Memory\_Module\_System\_UInt32\_System\_Int32\_\_\_)

 [CreateString\(int, StringType, nuint, params int\[\]\)](AslHelp.Memory.Watch.Initialization.WatcherFactory.CreateString.md\#AslHelp\_Memory\_Watch\_Initialization\_WatcherFactory\_CreateString\_System\_Int32\_AslHelp\_Memory\_StringType\_System\_UIntPtr\_System\_Int32\_\_\_)

 [MapTo\(IDictionary<string, object?\>\)](AslHelp.Memory.Watch.Initialization.WatcherFactory.MapTo.md\#AslHelp\_Memory\_Watch\_Initialization\_WatcherFactory\_MapTo\_System\_Collections\_Generic\_IDictionary\_System\_String\_System\_Object\_\_)

