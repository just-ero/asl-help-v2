# <a id="AslHelp_Diagnostics_Logging_MultiLogger_Remove_AslHelp_Diagnostics_Logging_ILogger_"></a> Method Remove

Namespace: [AslHelp.Diagnostics.Logging](AslHelp.Diagnostics.Logging.md)  
Assembly: AslHelp.Diagnostics.dll  

## <a id="AslHelp_Diagnostics_Logging_MultiLogger_Remove_AslHelp_Diagnostics_Logging_ILogger_"></a> Remove\(ILogger\)

Removes the first occurrence of a specific <xref href="AslHelp.Diagnostics.Logging.ILogger" data-throw-if-not-resolved="false"></xref> from the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref>.

```csharp
public bool Remove(ILogger item)
```

### Parameters

`item` [ILogger](AslHelp.Diagnostics.Logging.ILogger.md)

The logger to remove.

### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if <code class="paramref">item</code> was successfully removed from the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref>;
otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

