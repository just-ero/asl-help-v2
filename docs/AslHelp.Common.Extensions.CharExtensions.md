# <a id="AslHelp_Common_Extensions_CharExtensions"></a> Class CharExtensions

Namespace: [AslHelp.Common.Extensions](AslHelp.Common.Extensions.md)  
Assembly: AslHelp.Common.dll  

The <xref href="AslHelp.Common.Extensions.CharExtensions" data-throw-if-not-resolved="false"></xref> class
provides useful extension methods for the <xref href="System.Char" data-throw-if-not-resolved="false"></xref> type.

```csharp
public static class CharExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CharExtensions](AslHelp.Common.Extensions.CharExtensions.md)

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

## Fields

### <a id="AslHelp_Common_Extensions_CharExtensions_InvalidHexValue"></a> InvalidHexValue

```csharp
public const byte InvalidHexValue = 255
```

#### Field Value

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)

## Methods

### <a id="AslHelp_Common_Extensions_CharExtensions_ToHexValue_System_Char_"></a> ToHexValue\(char\)

Converts a hexadecimal character to its decimal value.

```csharp
public static byte ToHexValue(this char c)
```

#### Parameters

`c` [char](https://learn.microsoft.com/dotnet/api/system.char)

The hexadecimal character to convert.

#### Returns

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)

The decimal value of <code class="paramref">c</code> if it is a valid hexadecimal character;
otherwise, <code>0xFF</code>.

