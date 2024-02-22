# <a id="AslHelp_Common_ThrowHelper_ThrowIfNullOrEmpty__1_System_Collections_Generic_IEnumerable___0__System_String_System_String_"></a> Method ThrowIfNullOrEmpty<T\>

Namespace: [AslHelp.Common](AslHelp.Common.md)  
Assembly: AslHelp.Common.dll  

## <a id="AslHelp_Common_ThrowHelper_ThrowIfNullOrEmpty__1_System_Collections_Generic_IEnumerable___0__System_String_System_String_"></a> ThrowIfNullOrEmpty<T\>\(IEnumerable<T\>?, string?, string\)

Throws an <xref href="System.ArgumentNullException" data-throw-if-not-resolved="false"></xref> if <code class="paramref">collection</code> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>,
or an <xref href="System.ArgumentException" data-throw-if-not-resolved="false"></xref> if <code class="paramref">collection</code> is empty.

```csharp
public static void ThrowIfNullOrEmpty<T>(IEnumerable<T>? collection, string? message = null, string paramName = "")
```

### Parameters

`collection` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<T\>?

The collection to validate as non-<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a> and non-empty.

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

An optional message to include in the exception.

`paramName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the parameter with which <code class="paramref">collection</code> corresponds.
If this parameter is omitted, the name of <code class="paramref">collection</code> is used.

### Type Parameters

`T` 

The type of elements in the collection.

