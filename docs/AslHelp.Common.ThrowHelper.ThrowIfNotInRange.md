# <a id="AslHelp_Common_ThrowHelper_ThrowIfNotInRange__1___0___0___0_System_String_System_String_"></a> Method ThrowIfNotInRange<T\>

Namespace: [AslHelp.Common](AslHelp.Common.md)  
Assembly: AslHelp.Common.dll  

## <a id="AslHelp_Common_ThrowHelper_ThrowIfNotInRange__1___0___0___0_System_String_System_String_"></a> ThrowIfNotInRange<T\>\(T, T, T, string?, string\)

Throws an <xref href="System.ArgumentOutOfRangeException" data-throw-if-not-resolved="false"></xref> if <code class="paramref">value</code> is
not in the range of <code class="paramref">min</code> and <code class="paramref">max</code>.

```csharp
public static void ThrowIfNotInRange<T>(T value, T min, T max, string? message = null, string paramName = "") where T : unmanaged, IComparable<T>
```

### Parameters

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

### Type Parameters

`T` 

The type of the value to be validated.

