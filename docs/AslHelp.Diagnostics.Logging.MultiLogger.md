# <a id="AslHelp_Diagnostics_Logging_MultiLogger"></a> Class MultiLogger

Namespace: [AslHelp.Diagnostics.Logging](AslHelp.Diagnostics.Logging.md)  
Assembly: AslHelp.Diagnostics.dll  

The <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref> class
represents a collection of <xref href="AslHelp.Diagnostics.Logging.ILogger" data-throw-if-not-resolved="false"></xref> instances that can be used as one.

```csharp
public sealed class MultiLogger : ILogger, IList<ILogger>, ICollection<ILogger>, IEnumerable<ILogger>, IEnumerable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MultiLogger](AslHelp.Diagnostics.Logging.MultiLogger.md)

#### Implements

[ILogger](AslHelp.Diagnostics.Logging.ILogger.md), 
[IList<ILogger\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist\-1), 
[ICollection<ILogger\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection\-1), 
[IEnumerable<ILogger\>](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1), 
[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.ienumerable)

#### Inherited Members

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

 [MultiLogger\(params ILogger\[\]\)](AslHelp.Diagnostics.Logging.MultiLogger.\-ctor.md\#AslHelp\_Diagnostics\_Logging\_MultiLogger\_\_ctor\_AslHelp\_Diagnostics\_Logging\_ILogger\_\_\_)

Initializes a new instance of the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref> class
with the specified <xref href="AslHelp.Diagnostics.Logging.ILogger" data-throw-if-not-resolved="false"></xref>s.

## Properties

 [Count](AslHelp.Diagnostics.Logging.MultiLogger.Count.md\#AslHelp\_Diagnostics\_Logging\_MultiLogger\_Count)

Gets the amount of loggers contained in the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref>.

 [IsReadOnly](AslHelp.Diagnostics.Logging.MultiLogger.IsReadOnly.md\#AslHelp\_Diagnostics\_Logging\_MultiLogger\_IsReadOnly)

Gets a value indicating whether the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref> is read-only.

 [this\[int\]](AslHelp.Diagnostics.Logging.MultiLogger.Item.md\#AslHelp\_Diagnostics\_Logging\_MultiLogger\_Item\_System\_Int32\_)

Gets or sets the <xref href="AslHelp.Diagnostics.Logging.ILogger" data-throw-if-not-resolved="false"></xref> at the specified index.

## Methods

 [Add\(ILogger\)](AslHelp.Diagnostics.Logging.MultiLogger.Add.md\#AslHelp\_Diagnostics\_Logging\_MultiLogger\_Add\_AslHelp\_Diagnostics\_Logging\_ILogger\_)

Adds an <xref href="AslHelp.Diagnostics.Logging.ILogger" data-throw-if-not-resolved="false"></xref> to the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref>.

 [Clear\(\)](AslHelp.Diagnostics.Logging.MultiLogger.Clear.md\#AslHelp\_Diagnostics\_Logging\_MultiLogger\_Clear)

Removes all <xref href="AslHelp.Diagnostics.Logging.ILogger" data-throw-if-not-resolved="false"></xref> instances from the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref>.

 [Contains\(ILogger\)](AslHelp.Diagnostics.Logging.MultiLogger.Contains.md\#AslHelp\_Diagnostics\_Logging\_MultiLogger\_Contains\_AslHelp\_Diagnostics\_Logging\_ILogger\_)

Determines whether the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref> contains a specified <xref href="AslHelp.Diagnostics.Logging.ILogger" data-throw-if-not-resolved="false"></xref>.

 [CopyTo\(ILogger\[\], int\)](AslHelp.Diagnostics.Logging.MultiLogger.CopyTo.md\#AslHelp\_Diagnostics\_Logging\_MultiLogger\_CopyTo\_AslHelp\_Diagnostics\_Logging\_ILogger\_\_\_System\_Int32\_)

Copies the elements of the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref> to an Array,
starting at a particular Array index.

 [GetEnumerator\(\)](AslHelp.Diagnostics.Logging.MultiLogger.GetEnumerator.md\#AslHelp\_Diagnostics\_Logging\_MultiLogger\_GetEnumerator)

Returns an enumerator that iterates through the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref>.

 [IndexOf\(ILogger\)](AslHelp.Diagnostics.Logging.MultiLogger.IndexOf.md\#AslHelp\_Diagnostics\_Logging\_MultiLogger\_IndexOf\_AslHelp\_Diagnostics\_Logging\_ILogger\_)

Determines the index of a specified <xref href="AslHelp.Diagnostics.Logging.ILogger" data-throw-if-not-resolved="false"></xref> in the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref>.

 [Insert\(int, ILogger\)](AslHelp.Diagnostics.Logging.MultiLogger.Insert.md\#AslHelp\_Diagnostics\_Logging\_MultiLogger\_Insert\_System\_Int32\_AslHelp\_Diagnostics\_Logging\_ILogger\_)

Inserts an <xref href="AslHelp.Diagnostics.Logging.ILogger" data-throw-if-not-resolved="false"></xref> into the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref> at the specified index.

 [Log\(\)](AslHelp.Diagnostics.Logging.MultiLogger.Log.md\#AslHelp\_Diagnostics\_Logging\_MultiLogger\_Log)

Writes an empty line to all loggers contained in the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref>.

 [Log\(object?\)](AslHelp.Diagnostics.Logging.MultiLogger.Log.md\#AslHelp\_Diagnostics\_Logging\_MultiLogger\_Log\_System\_Object\_)

Writes the string representation of the specified value to all loggers contained in the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref>.

 [Remove\(ILogger\)](AslHelp.Diagnostics.Logging.MultiLogger.Remove.md\#AslHelp\_Diagnostics\_Logging\_MultiLogger\_Remove\_AslHelp\_Diagnostics\_Logging\_ILogger\_)

Removes the first occurrence of a specific <xref href="AslHelp.Diagnostics.Logging.ILogger" data-throw-if-not-resolved="false"></xref> from the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref>.

 [RemoveAt\(int\)](AslHelp.Diagnostics.Logging.MultiLogger.RemoveAt.md\#AslHelp\_Diagnostics\_Logging\_MultiLogger\_RemoveAt\_System\_Int32\_)

Removes the <xref href="AslHelp.Diagnostics.Logging.ILogger" data-throw-if-not-resolved="false"></xref> at the specified index of the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref>.

 [Start\(\)](AslHelp.Diagnostics.Logging.MultiLogger.Start.md\#AslHelp\_Diagnostics\_Logging\_MultiLogger\_Start)

Starts all loggers contained in the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref>.

 [Stop\(\)](AslHelp.Diagnostics.Logging.MultiLogger.Stop.md\#AslHelp\_Diagnostics\_Logging\_MultiLogger\_Stop)

Stops all contained loggers.

