# <a id="AslHelp_Common_ThrowHelper_ThrowObjectDisposedException_System_String_"></a> Method ThrowObjectDisposedException

Namespace: [AslHelp.Common](AslHelp.Common.md)  
Assembly: AslHelp.Common.dll  

## <a id="AslHelp_Common_ThrowHelper_ThrowObjectDisposedException_System_String_"></a> ThrowObjectDisposedException\(string\)

Throws an <xref href="System.ObjectDisposedException" data-throw-if-not-resolved="false"></xref> for a specified object.

```csharp
public static void ThrowObjectDisposedException(string objectName)
```

### Parameters

`objectName` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the disposed object.

### Remarks

This method does not return and is not inlined to improve codegen of cold paths.

### Exceptions

 [ObjectDisposedException](https://learn.microsoft.com/dotnet/api/system.objectdisposedexception)

