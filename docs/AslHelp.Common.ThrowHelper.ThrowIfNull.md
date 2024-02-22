# <a id="AslHelp_Common_ThrowHelper_ThrowIfNull_System_Object_System_String_System_String_"></a> Method ThrowIfNull

Namespace: [AslHelp.Common](AslHelp.Common.md)  
Assembly: AslHelp.Common.dll  

## <a id="AslHelp_Common_ThrowHelper_ThrowIfNull_System_Object_System_String_System_String_"></a> ThrowIfNull\(object?, string?, string\)

Throws an <xref href="System.ArgumentNullException" data-throw-if-not-resolved="false"></xref> if <code class="paramref">argument</code> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

```csharp
public static void ThrowIfNull(object? argument, string? message = null, string paramName = "")
```

### Parameters

`argument` [object](https://learn.microsoft.com/dotnet/api/system.object)?

The argument to validate as non-<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)?

An optional message to include in the exception.

`paramName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the parameter with which <code class="paramref">argument</code> corresponds.
If this parameter is omitted, the name of <code class="paramref">argument</code> is used.

