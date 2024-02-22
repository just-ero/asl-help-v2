# <a id="AslHelp_Common_Extensions_CharExtensions_ToHexValue_System_Char_"></a> Method ToHexValue

Namespace: [AslHelp.Common.Extensions](AslHelp.Common.Extensions.md)  
Assembly: AslHelp.Common.dll  

## <a id="AslHelp_Common_Extensions_CharExtensions_ToHexValue_System_Char_"></a> ToHexValue\(char\)

Converts a hexadecimal character to its decimal value.

```csharp
public static byte ToHexValue(this char c)
```

### Parameters

`c` [char](https://learn.microsoft.com/dotnet/api/system.char)

The hexadecimal character to convert.

### Returns

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)

The decimal value of <code class="paramref">c</code> if it is a valid hexadecimal character;
otherwise, <code>0xFF</code>.

