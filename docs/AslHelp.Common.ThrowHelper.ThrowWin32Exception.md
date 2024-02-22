# <a id="AslHelp_Common_ThrowHelper_ThrowWin32Exception"></a> Method ThrowWin32Exception

Namespace: [AslHelp.Common](AslHelp.Common.md)  
Assembly: AslHelp.Common.dll  

## <a id="AslHelp_Common_ThrowHelper_ThrowWin32Exception"></a> ThrowWin32Exception\(\)

Throws a <xref href="System.ComponentModel.Win32Exception" data-throw-if-not-resolved="false"></xref>.

```csharp
public static void ThrowWin32Exception()
```

### Remarks

This method does not return and is not inlined to improve codegen of cold paths.

### Exceptions

 [Win32Exception](https://learn.microsoft.com/dotnet/api/system.componentmodel.win32exception)

