# <a id="AslHelp_Common_ThrowHelper"></a> Class ThrowHelper

Namespace: [AslHelp.Common](AslHelp.Common.md)  
Assembly: AslHelp.Common.dll  

The <xref href="AslHelp.Common.ThrowHelper" data-throw-if-not-resolved="false"></xref> class
provides helper methods for throwing exceptions.

```csharp
public static class ThrowHelper
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ThrowHelper](AslHelp.Common.ThrowHelper.md)

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

## Methods

### <a id="AslHelp_Common_ThrowHelper_ThrowArgumentException_System_String_System_String_"></a> ThrowArgumentException\(string, string\)

Throws an <xref href="System.ArgumentException" data-throw-if-not-resolved="false"></xref> with a specified error message
and the name of the parameter that causes this exception.

```csharp
public static void ThrowArgumentException(string paramName, string message)
```

#### Parameters

`paramName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the parameter that caused the exception.

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

The error message that explains the reason for the exception.

#### Remarks

This method does not return and is not inlined to improve codegen of cold paths.

#### Exceptions

 [ArgumentException](https://learn.microsoft.com/dotnet/api/system.argumentexception)

### <a id="AslHelp_Common_ThrowHelper_ThrowArgumentNullException_System_String_System_String_"></a> ThrowArgumentNullException\(string, string\)

Throws an <xref href="System.ArgumentNullException" data-throw-if-not-resolved="false"></xref> with a specified error message
and the name of the parameter that causes this exception.

```csharp
public static void ThrowArgumentNullException(string paramName, string message)
```

#### Parameters

`paramName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the parameter that caused the exception.

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

The error message that explains the reason for the exception.

#### Remarks

This method does not return and is not inlined to improve codegen of cold paths.

#### Exceptions

 [ArgumentNullException](https://learn.microsoft.com/dotnet/api/system.argumentnullexception)

### <a id="AslHelp_Common_ThrowHelper_ThrowArgumentOutOfRangeException_System_String_System_String_"></a> ThrowArgumentOutOfRangeException\(string, string\)

Throws an <xref href="System.ArgumentOutOfRangeException" data-throw-if-not-resolved="false"></xref> with a specified error message
and the name of the parameter that causes this exception.

```csharp
public static void ThrowArgumentOutOfRangeException(string paramName, string message)
```

#### Parameters

`paramName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the parameter that caused the exception.

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

The error message that explains the reason for the exception.

#### Remarks

This method does not return and is not inlined to improve codegen of cold paths.

#### Exceptions

 [ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception)

### <a id="AslHelp_Common_ThrowHelper_ThrowDirectoryNotFoundException_System_String_"></a> ThrowDirectoryNotFoundException\(string\)

Throws a <xref href="System.IO.DirectoryNotFoundException" data-throw-if-not-resolved="false"></xref> with a specified error message.

```csharp
public static void ThrowDirectoryNotFoundException(string message)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

The error message that explains the reason for the exception.

#### Remarks

This method does not return and is not inlined to improve codegen of cold paths.

#### Exceptions

 [DirectoryNotFoundException](https://learn.microsoft.com/dotnet/api/system.io.directorynotfoundexception)

### <a id="AslHelp_Common_ThrowHelper_ThrowException_System_String_"></a> ThrowException\(string\)

Throws an <xref href="System.Exception" data-throw-if-not-resolved="false"></xref> with a specified error message.

```csharp
public static void ThrowException(string message)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

The error message that explains the reason for the exception.

#### Remarks

This method does not return and is not inlined to improve codegen of cold paths.

#### Exceptions

 [Exception](https://learn.microsoft.com/dotnet/api/system.exception)

### <a id="AslHelp_Common_ThrowHelper_ThrowFileNotFoundException_System_String_"></a> ThrowFileNotFoundException\(string\)

Throws a <xref href="System.IO.FileNotFoundException" data-throw-if-not-resolved="false"></xref> with a specified error message.

```csharp
public static void ThrowFileNotFoundException(string message)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

The error message that explains the reason for the exception.

#### Remarks

This method does not return and is not inlined to improve codegen of cold paths.

#### Exceptions

 [FileNotFoundException](https://learn.microsoft.com/dotnet/api/system.io.filenotfoundexception)

### <a id="AslHelp_Common_ThrowHelper_ThrowFormatException_System_String_"></a> ThrowFormatException\(string\)

Throws a <xref href="System.FormatException" data-throw-if-not-resolved="false"></xref> with a specified error message.

```csharp
public static void ThrowFormatException(string message)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

The error message that explains the reason for the exception.

#### Remarks

This method does not return and is not inlined to improve codegen of cold paths.

#### Exceptions

 [FormatException](https://learn.microsoft.com/dotnet/api/system.formatexception)

### <a id="AslHelp_Common_ThrowHelper_ThrowIfLargerThan__1___0___0_System_String_System_String_"></a> ThrowIfLargerThan<T\>\(T, T, string?, string\)

Throws an <xref href="System.ArgumentOutOfRangeException" data-throw-if-not-resolved="false"></xref> if <code class="paramref">value</code> is larger than <code class="paramref">max</code>.

```csharp
public static void ThrowIfLargerThan<T>(T value, T max, string? message = null, string paramName = "") where T : unmanaged, IComparable<T>
```

#### Parameters

`value` T

The value to be validated.

`max` T

The maximum value <code class="paramref">value</code> can be.

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

An optional message to include in the exception.

`paramName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the parameter with which <code class="paramref">value</code> corresponds.
If this parameter is omitted, the name of <code class="paramref">value</code> is used.

#### Type Parameters

`T` 

The type of the value to be validated.

### <a id="AslHelp_Common_ThrowHelper_ThrowIfLessThan__1___0___0_System_String_System_String_"></a> ThrowIfLessThan<T\>\(T, T, string?, string\)

Throws an <xref href="System.ArgumentOutOfRangeException" data-throw-if-not-resolved="false"></xref> if <code class="paramref">value</code> is less than <code class="paramref">min</code>.

```csharp
public static void ThrowIfLessThan<T>(T value, T min, string? message = null, string paramName = "") where T : unmanaged, IComparable<T>
```

#### Parameters

`value` T

The value to be validated.

`min` T

The minimum value <code class="paramref">value</code> can be.

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

An optional message to include in the exception.

`paramName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the parameter with which <code class="paramref">value</code> corresponds.
If this parameter is omitted, the name of <code class="paramref">value</code> is used.

#### Type Parameters

`T` 

The type of the value to be validated.

### <a id="AslHelp_Common_ThrowHelper_ThrowIfNotInRange__1___0___0___0_System_String_System_String_"></a> ThrowIfNotInRange<T\>\(T, T, T, string?, string\)

Throws an <xref href="System.ArgumentOutOfRangeException" data-throw-if-not-resolved="false"></xref> if <code class="paramref">value</code> is
not in the range of <code class="paramref">min</code> and <code class="paramref">max</code>.

```csharp
public static void ThrowIfNotInRange<T>(T value, T min, T max, string? message = null, string paramName = "") where T : unmanaged, IComparable<T>
```

#### Parameters

`value` T

The value to be validated.

`min` T

The minimum value <code class="paramref">value</code> can be.

`max` T

The maximum value <code class="paramref">value</code> can be.

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

An optional message to include in the exception.

`paramName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the parameter with which <code class="paramref">value</code> corresponds.
If this parameter is omitted, the name of <code class="paramref">value</code> is used.

#### Type Parameters

`T` 

The type of the value to be validated.

### <a id="AslHelp_Common_ThrowHelper_ThrowIfNull_System_Object_System_String_System_String_"></a> ThrowIfNull\(object?, string?, string\)

Throws an <xref href="System.ArgumentNullException" data-throw-if-not-resolved="false"></xref> if <code class="paramref">argument</code> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

```csharp
public static void ThrowIfNull(object? argument, string? message = null, string paramName = "")
```

#### Parameters

`argument` [object](https://learn.microsoft.com/dotnet/api/system.object)?

The argument to validate as non-<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

An optional message to include in the exception.

`paramName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the parameter with which <code class="paramref">argument</code> corresponds.
If this parameter is omitted, the name of <code class="paramref">argument</code> is used.

### <a id="AslHelp_Common_ThrowHelper_ThrowIfNullOrEmpty__1_System_Collections_Generic_IEnumerable___0__System_String_System_String_"></a> ThrowIfNullOrEmpty<T\>\(IEnumerable<T\>?, string?, string\)

Throws an <xref href="System.ArgumentNullException" data-throw-if-not-resolved="false"></xref> if <code class="paramref">collection</code> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>,
or an <xref href="System.ArgumentException" data-throw-if-not-resolved="false"></xref> if <code class="paramref">collection</code> is empty.

```csharp
public static void ThrowIfNullOrEmpty<T>(IEnumerable<T>? collection, string? message = null, string paramName = "")
```

#### Parameters

`collection` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<T\>?

The collection to validate as non-<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a> and non-empty.

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

An optional message to include in the exception.

`paramName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the parameter with which <code class="paramref">collection</code> corresponds.
If this parameter is omitted, the name of <code class="paramref">collection</code> is used.

#### Type Parameters

`T` 

The type of elements in the collection.

### <a id="AslHelp_Common_ThrowHelper_ThrowInvalidDataException_System_String_"></a> ThrowInvalidDataException\(string\)

Throws an <xref href="System.IO.InvalidDataException" data-throw-if-not-resolved="false"></xref> with a specified error message.

```csharp
public static void ThrowInvalidDataException(string message)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

The error message that explains the reason for the exception.

#### Remarks

This method does not return and is not inlined to improve codegen of cold paths.

#### Exceptions

 [InvalidDataException](https://learn.microsoft.com/dotnet/api/system.io.invaliddataexception)

### <a id="AslHelp_Common_ThrowHelper_ThrowInvalidOperationException_System_String_"></a> ThrowInvalidOperationException\(string\)

Throws an <xref href="System.InvalidOperationException" data-throw-if-not-resolved="false"></xref> with a specified error message.

```csharp
public static void ThrowInvalidOperationException(string message)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

The error message that explains the reason for the exception.

#### Remarks

This method does not return and is not inlined to improve codegen of cold paths.

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

### <a id="AslHelp_Common_ThrowHelper_ThrowKeyNotFoundException_System_String_"></a> ThrowKeyNotFoundException\(string\)

Throws a <xref href="System.Collections.Generic.KeyNotFoundException" data-throw-if-not-resolved="false"></xref> with a specified error message.

```csharp
public static void ThrowKeyNotFoundException(string message)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

The error message that explains the reason for the exception.

#### Remarks

This method does not return and is not inlined to improve codegen of cold paths.

#### Exceptions

 [KeyNotFoundException](https://learn.microsoft.com/dotnet/api/system.collections.generic.keynotfoundexception)

### <a id="AslHelp_Common_ThrowHelper_ThrowNotImplementedException_System_String_"></a> ThrowNotImplementedException\(string\)

Throws a <xref href="System.NotImplementedException" data-throw-if-not-resolved="false"></xref> with a specified error message.

```csharp
public static void ThrowNotImplementedException(string message)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

The error message that explains the reason for the exception.

#### Remarks

This method does not return and is not inlined to improve codegen of cold paths.

#### Exceptions

 [NotImplementedException](https://learn.microsoft.com/dotnet/api/system.notimplementedexception)

### <a id="AslHelp_Common_ThrowHelper_ThrowNotSupportedException_System_String_"></a> ThrowNotSupportedException\(string\)

Throws a <xref href="System.NotSupportedException" data-throw-if-not-resolved="false"></xref> with a specified error message.

```csharp
public static void ThrowNotSupportedException(string message)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

The error message that explains the reason for the exception.

#### Remarks

This method does not return and is not inlined to improve codegen of cold paths.

#### Exceptions

 [NotSupportedException](https://learn.microsoft.com/dotnet/api/system.notsupportedexception)

### <a id="AslHelp_Common_ThrowHelper_ThrowObjectDisposedException_System_String_"></a> ThrowObjectDisposedException\(string\)

Throws an <xref href="System.ObjectDisposedException" data-throw-if-not-resolved="false"></xref> for a specified object.

```csharp
public static void ThrowObjectDisposedException(string objectName)
```

#### Parameters

`objectName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the disposed object.

#### Remarks

This method does not return and is not inlined to improve codegen of cold paths.

#### Exceptions

 [ObjectDisposedException](https://learn.microsoft.com/dotnet/api/system.objectdisposedexception)

### <a id="AslHelp_Common_ThrowHelper_ThrowWin32Exception"></a> ThrowWin32Exception\(\)

Throws a <xref href="System.ComponentModel.Win32Exception" data-throw-if-not-resolved="false"></xref>.

```csharp
public static void ThrowWin32Exception()
```

#### Remarks

This method does not return and is not inlined to improve codegen of cold paths.

#### Exceptions

 [Win32Exception](https://learn.microsoft.com/dotnet/api/system.componentmodel.win32exception)

