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

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Constructors

### <a id="AslHelp_Diagnostics_Logging_MultiLogger__ctor_AslHelp_Diagnostics_Logging_ILogger___"></a> MultiLogger\(params ILogger\[\]\)

Initializes a new instance of the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref> class
with the specified <xref href="AslHelp.Diagnostics.Logging.ILogger" data-throw-if-not-resolved="false"></xref>s.

```csharp
public MultiLogger(params ILogger[] loggers)
```

#### Parameters

`loggers` [ILogger](AslHelp.Diagnostics.Logging.ILogger.md)\[\]

## Properties

### <a id="AslHelp_Diagnostics_Logging_MultiLogger_Count"></a> Count

Gets the amount of loggers contained in the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref>.

```csharp
public int Count { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="AslHelp_Diagnostics_Logging_MultiLogger_IsReadOnly"></a> IsReadOnly

Gets a value indicating whether the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref> is read-only.

```csharp
public bool IsReadOnly { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Diagnostics_Logging_MultiLogger_Item_System_Int32_"></a> this\[int\]

Gets or sets the <xref href="AslHelp.Diagnostics.Logging.ILogger" data-throw-if-not-resolved="false"></xref> at the specified index.

```csharp
public ILogger this[int index] { get; set; }
```

#### Property Value

 [ILogger](AslHelp.Diagnostics.Logging.ILogger.md)

## Methods

### <a id="AslHelp_Diagnostics_Logging_MultiLogger_Add_AslHelp_Diagnostics_Logging_ILogger_"></a> Add\(ILogger\)

Adds an <xref href="AslHelp.Diagnostics.Logging.ILogger" data-throw-if-not-resolved="false"></xref> to the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref>.

```csharp
public void Add(ILogger item)
```

#### Parameters

`item` [ILogger](AslHelp.Diagnostics.Logging.ILogger.md)

The <xref href="AslHelp.Diagnostics.Logging.ILogger" data-throw-if-not-resolved="false"></xref> to add.

### <a id="AslHelp_Diagnostics_Logging_MultiLogger_Clear"></a> Clear\(\)

Removes all <xref href="AslHelp.Diagnostics.Logging.ILogger" data-throw-if-not-resolved="false"></xref> instances from the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref>.

```csharp
public void Clear()
```

### <a id="AslHelp_Diagnostics_Logging_MultiLogger_Contains_AslHelp_Diagnostics_Logging_ILogger_"></a> Contains\(ILogger\)

Determines whether the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref> contains a specified <xref href="AslHelp.Diagnostics.Logging.ILogger" data-throw-if-not-resolved="false"></xref>.

```csharp
public bool Contains(ILogger item)
```

#### Parameters

`item` [ILogger](AslHelp.Diagnostics.Logging.ILogger.md)

The <xref href="AslHelp.Diagnostics.Logging.ILogger" data-throw-if-not-resolved="false"></xref> to locate in the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if <code class="paramref">item</code> is found in the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref>;
otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="AslHelp_Diagnostics_Logging_MultiLogger_CopyTo_AslHelp_Diagnostics_Logging_ILogger___System_Int32_"></a> CopyTo\(ILogger\[\], int\)

Copies the elements of the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref> to an Array,
starting at a particular Array index.

```csharp
public void CopyTo(ILogger[] array, int arrayIndex)
```

#### Parameters

`array` [ILogger](AslHelp.Diagnostics.Logging.ILogger.md)\[\]

The Array that is the destination of the elements copied from the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref>.

`arrayIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The index in <code class="paramref">array</code> at which copying begins.

### <a id="AslHelp_Diagnostics_Logging_MultiLogger_GetEnumerator"></a> GetEnumerator\(\)

Returns an enumerator that iterates through the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref>.

```csharp
public IEnumerator<ILogger> GetEnumerator()
```

#### Returns

 [IEnumerator](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerator\-1)<[ILogger](AslHelp.Diagnostics.Logging.ILogger.md)\>

### <a id="AslHelp_Diagnostics_Logging_MultiLogger_IndexOf_AslHelp_Diagnostics_Logging_ILogger_"></a> IndexOf\(ILogger\)

Determines the index of a specified <xref href="AslHelp.Diagnostics.Logging.ILogger" data-throw-if-not-resolved="false"></xref> in the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref>.

```csharp
public int IndexOf(ILogger item)
```

#### Parameters

`item` [ILogger](AslHelp.Diagnostics.Logging.ILogger.md)

The <xref href="AslHelp.Diagnostics.Logging.ILogger" data-throw-if-not-resolved="false"></xref> to locate in the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

The index of <code class="paramref">item</code> if found in the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref>;
otherwise, <code>-1</code>.

### <a id="AslHelp_Diagnostics_Logging_MultiLogger_Insert_System_Int32_AslHelp_Diagnostics_Logging_ILogger_"></a> Insert\(int, ILogger\)

Inserts an <xref href="AslHelp.Diagnostics.Logging.ILogger" data-throw-if-not-resolved="false"></xref> into the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref> at the specified index.

```csharp
public void Insert(int index, ILogger item)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The index at which to insert the logger.

`item` [ILogger](AslHelp.Diagnostics.Logging.ILogger.md)

The logger to insert.

### <a id="AslHelp_Diagnostics_Logging_MultiLogger_Log"></a> Log\(\)

Writes an empty line to all loggers contained in the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref>.

```csharp
public void Log()
```

### <a id="AslHelp_Diagnostics_Logging_MultiLogger_Log_System_Object_"></a> Log\(object?\)

Writes the string representation of the specified value to all loggers contained in the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref>.

```csharp
public void Log(object? output)
```

#### Parameters

`output` [object](https://learn.microsoft.com/dotnet/api/system.object)?

The value to log.

### <a id="AslHelp_Diagnostics_Logging_MultiLogger_Remove_AslHelp_Diagnostics_Logging_ILogger_"></a> Remove\(ILogger\)

Removes the first occurrence of a specific <xref href="AslHelp.Diagnostics.Logging.ILogger" data-throw-if-not-resolved="false"></xref> from the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref>.

```csharp
public bool Remove(ILogger item)
```

#### Parameters

`item` [ILogger](AslHelp.Diagnostics.Logging.ILogger.md)

The logger to remove.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if <code class="paramref">item</code> was successfully removed from the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref>;
otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="AslHelp_Diagnostics_Logging_MultiLogger_RemoveAt_System_Int32_"></a> RemoveAt\(int\)

Removes the <xref href="AslHelp.Diagnostics.Logging.ILogger" data-throw-if-not-resolved="false"></xref> at the specified index of the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref>.

```csharp
public void RemoveAt(int index)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The index of the logger to remove.

### <a id="AslHelp_Diagnostics_Logging_MultiLogger_Start"></a> Start\(\)

Starts all loggers contained in the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref>.

```csharp
public void Start()
```

### <a id="AslHelp_Diagnostics_Logging_MultiLogger_Stop"></a> Stop\(\)

Stops all contained loggers.

```csharp
public void Stop()
```

