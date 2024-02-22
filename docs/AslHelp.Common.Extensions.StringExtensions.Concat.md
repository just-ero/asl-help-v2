# <a id="AslHelp_Common_Extensions_StringExtensions_Concat_System_String___"></a> Method Concat

Namespace: [AslHelp.Common.Extensions](AslHelp.Common.Extensions.md)  
Assembly: AslHelp.Common.dll  

## <a id="AslHelp_Common_Extensions_StringExtensions_Concat_System_String___"></a> Concat\(string\[\]\)

Provides an optimized method to concatenate the elements of a specified <xref href="System.String" data-throw-if-not-resolved="false"></xref> array.

```csharp
public static string Concat(this string[] values)
```

### Parameters

`values` [string](https://learn.microsoft.com/dotnet/api/system.string)\[\]

The collection of strings to concatenate.

### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The concatenated elements of <code class="paramref">values</code>.

### Exceptions

 [ArgumentNullException](https://learn.microsoft.com/dotnet/api/system.argumentnullexception)

Thrown when <code class="paramref">values</code> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

