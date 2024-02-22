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

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetFieldValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetMethod.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetPropertyValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.IsType.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.SetFieldValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.SetPropertyValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Methods

 [ThrowArgumentException\(string, string\)](AslHelp.Common.ThrowHelper.ThrowArgumentException.md\#AslHelp\_Common\_ThrowHelper\_ThrowArgumentException\_System\_String\_System\_String\_)

Throws an <xref href="System.ArgumentException" data-throw-if-not-resolved="false"></xref> with a specified error message
and the name of the parameter that causes this exception.

 [ThrowArgumentNullException\(string, string\)](AslHelp.Common.ThrowHelper.ThrowArgumentNullException.md\#AslHelp\_Common\_ThrowHelper\_ThrowArgumentNullException\_System\_String\_System\_String\_)

Throws an <xref href="System.ArgumentNullException" data-throw-if-not-resolved="false"></xref> with a specified error message
and the name of the parameter that causes this exception.

 [ThrowArgumentOutOfRangeException\(string, string\)](AslHelp.Common.ThrowHelper.ThrowArgumentOutOfRangeException.md\#AslHelp\_Common\_ThrowHelper\_ThrowArgumentOutOfRangeException\_System\_String\_System\_String\_)

Throws an <xref href="System.ArgumentOutOfRangeException" data-throw-if-not-resolved="false"></xref> with a specified error message
and the name of the parameter that causes this exception.

 [ThrowDirectoryNotFoundException\(string\)](AslHelp.Common.ThrowHelper.ThrowDirectoryNotFoundException.md\#AslHelp\_Common\_ThrowHelper\_ThrowDirectoryNotFoundException\_System\_String\_)

Throws a <xref href="System.IO.DirectoryNotFoundException" data-throw-if-not-resolved="false"></xref> with a specified error message.

 [ThrowException\(string\)](AslHelp.Common.ThrowHelper.ThrowException.md\#AslHelp\_Common\_ThrowHelper\_ThrowException\_System\_String\_)

Throws an <xref href="System.Exception" data-throw-if-not-resolved="false"></xref> with a specified error message.

 [ThrowFileNotFoundException\(string\)](AslHelp.Common.ThrowHelper.ThrowFileNotFoundException.md\#AslHelp\_Common\_ThrowHelper\_ThrowFileNotFoundException\_System\_String\_)

Throws a <xref href="System.IO.FileNotFoundException" data-throw-if-not-resolved="false"></xref> with a specified error message.

 [ThrowFormatException\(string\)](AslHelp.Common.ThrowHelper.ThrowFormatException.md\#AslHelp\_Common\_ThrowHelper\_ThrowFormatException\_System\_String\_)

Throws a <xref href="System.FormatException" data-throw-if-not-resolved="false"></xref> with a specified error message.

 [ThrowIfLargerThan<T\>\(T, T, string?, string\)](AslHelp.Common.ThrowHelper.ThrowIfLargerThan.md\#AslHelp\_Common\_ThrowHelper\_ThrowIfLargerThan\_\_1\_\_\_0\_\_\_0\_System\_String\_System\_String\_)

Throws an <xref href="System.ArgumentOutOfRangeException" data-throw-if-not-resolved="false"></xref> if <code class="paramref">value</code> is larger than <code class="paramref">max</code>.

 [ThrowIfLessThan<T\>\(T, T, string?, string\)](AslHelp.Common.ThrowHelper.ThrowIfLessThan.md\#AslHelp\_Common\_ThrowHelper\_ThrowIfLessThan\_\_1\_\_\_0\_\_\_0\_System\_String\_System\_String\_)

Throws an <xref href="System.ArgumentOutOfRangeException" data-throw-if-not-resolved="false"></xref> if <code class="paramref">value</code> is less than <code class="paramref">min</code>.

 [ThrowIfNotInRange<T\>\(T, T, T, string?, string\)](AslHelp.Common.ThrowHelper.ThrowIfNotInRange.md\#AslHelp\_Common\_ThrowHelper\_ThrowIfNotInRange\_\_1\_\_\_0\_\_\_0\_\_\_0\_System\_String\_System\_String\_)

Throws an <xref href="System.ArgumentOutOfRangeException" data-throw-if-not-resolved="false"></xref> if <code class="paramref">value</code> is
not in the range of <code class="paramref">min</code> and <code class="paramref">max</code>.

 [ThrowIfNull\(object?, string?, string\)](AslHelp.Common.ThrowHelper.ThrowIfNull.md\#AslHelp\_Common\_ThrowHelper\_ThrowIfNull\_System\_Object\_System\_String\_System\_String\_)

Throws an <xref href="System.ArgumentNullException" data-throw-if-not-resolved="false"></xref> if <code class="paramref">argument</code> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

 [ThrowIfNullOrEmpty<T\>\(IEnumerable<T\>?, string?, string\)](AslHelp.Common.ThrowHelper.ThrowIfNullOrEmpty.md\#AslHelp\_Common\_ThrowHelper\_ThrowIfNullOrEmpty\_\_1\_System\_Collections\_Generic\_IEnumerable\_\_\_0\_\_System\_String\_System\_String\_)

Throws an <xref href="System.ArgumentNullException" data-throw-if-not-resolved="false"></xref> if <code class="paramref">collection</code> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>,
or an <xref href="System.ArgumentException" data-throw-if-not-resolved="false"></xref> if <code class="paramref">collection</code> is empty.

 [ThrowInvalidDataException\(string\)](AslHelp.Common.ThrowHelper.ThrowInvalidDataException.md\#AslHelp\_Common\_ThrowHelper\_ThrowInvalidDataException\_System\_String\_)

Throws an <xref href="System.IO.InvalidDataException" data-throw-if-not-resolved="false"></xref> with a specified error message.

 [ThrowInvalidOperationException\(string\)](AslHelp.Common.ThrowHelper.ThrowInvalidOperationException.md\#AslHelp\_Common\_ThrowHelper\_ThrowInvalidOperationException\_System\_String\_)

Throws an <xref href="System.InvalidOperationException" data-throw-if-not-resolved="false"></xref> with a specified error message.

 [ThrowKeyNotFoundException\(string\)](AslHelp.Common.ThrowHelper.ThrowKeyNotFoundException.md\#AslHelp\_Common\_ThrowHelper\_ThrowKeyNotFoundException\_System\_String\_)

Throws a <xref href="System.Collections.Generic.KeyNotFoundException" data-throw-if-not-resolved="false"></xref> with a specified error message.

 [ThrowNotImplementedException\(string\)](AslHelp.Common.ThrowHelper.ThrowNotImplementedException.md\#AslHelp\_Common\_ThrowHelper\_ThrowNotImplementedException\_System\_String\_)

Throws a <xref href="System.NotImplementedException" data-throw-if-not-resolved="false"></xref> with a specified error message.

 [ThrowNotSupportedException\(string\)](AslHelp.Common.ThrowHelper.ThrowNotSupportedException.md\#AslHelp\_Common\_ThrowHelper\_ThrowNotSupportedException\_System\_String\_)

Throws a <xref href="System.NotSupportedException" data-throw-if-not-resolved="false"></xref> with a specified error message.

 [ThrowObjectDisposedException\(string\)](AslHelp.Common.ThrowHelper.ThrowObjectDisposedException.md\#AslHelp\_Common\_ThrowHelper\_ThrowObjectDisposedException\_System\_String\_)

Throws an <xref href="System.ObjectDisposedException" data-throw-if-not-resolved="false"></xref> for a specified object.

 [ThrowWin32Exception\(\)](AslHelp.Common.ThrowHelper.ThrowWin32Exception.md\#AslHelp\_Common\_ThrowHelper\_ThrowWin32Exception)

Throws a <xref href="System.ComponentModel.Win32Exception" data-throw-if-not-resolved="false"></xref>.

