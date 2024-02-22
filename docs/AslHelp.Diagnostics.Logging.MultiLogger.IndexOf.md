# <a id="AslHelp_Diagnostics_Logging_MultiLogger_IndexOf_AslHelp_Diagnostics_Logging_ILogger_"></a> Method IndexOf

Namespace: [AslHelp.Diagnostics.Logging](AslHelp.Diagnostics.Logging.md)  
Assembly: AslHelp.Diagnostics.dll  

## <a id="AslHelp_Diagnostics_Logging_MultiLogger_IndexOf_AslHelp_Diagnostics_Logging_ILogger_"></a> IndexOf\(ILogger\)

Determines the index of a specified <xref href="AslHelp.Diagnostics.Logging.ILogger" data-throw-if-not-resolved="false"></xref> in the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref>.

```csharp
public int IndexOf(ILogger item)
```

### Parameters

`item` [ILogger](AslHelp.Diagnostics.Logging.ILogger.md)

The <xref href="AslHelp.Diagnostics.Logging.ILogger" data-throw-if-not-resolved="false"></xref> to locate in the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref>.

### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

The index of <code class="paramref">item</code> if found in the <xref href="AslHelp.Diagnostics.Logging.MultiLogger" data-throw-if-not-resolved="false"></xref>;
otherwise, <code>-1</code>.

