# <a id="AslHelp_Collections_Extensions_ArrayPoolExtensions"></a> Class ArrayPoolExtensions

Namespace: [AslHelp.Collections.Extensions](AslHelp.Collections.Extensions.md)  
Assembly: AslHelp.Collections.dll  

The <xref href="AslHelp.Collections.Extensions.ArrayPoolExtensions" data-throw-if-not-resolved="false"></xref> class
provides useful extension methods for the <xref href="System.Buffers.ArrayPool%601" data-throw-if-not-resolved="false"></xref> type.

```csharp
public static class ArrayPoolExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ArrayPoolExtensions](AslHelp.Collections.Extensions.ArrayPoolExtensions.md)

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

## Methods

### <a id="AslHelp_Collections_Extensions_ArrayPoolExtensions_ReturnIfNotNull__1_System_Buffers_ArrayPool___0____0___"></a> ReturnIfNotNull<T\>\(ArrayPool<T\>, T\[\]?\)

If <code class="paramref">array</code> is not <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>,
returns it to the pool that it was previously obtained from using the <xref href="System.Buffers.ArrayPool%601.Rent(System.Int32)" data-throw-if-not-resolved="false"></xref>
method on the same <xref href="System.Buffers.ArrayPool%601" data-throw-if-not-resolved="false"></xref> instance.

```csharp
public static void ReturnIfNotNull<T>(this ArrayPool<T> pool, T[]? array)
```

#### Parameters

`pool` [ArrayPool](https://learn.microsoft.com/dotnet/api/system.buffers.arraypool\-1)<T\>

`array` T\[\]?

The buffer to return to the pool.

#### Type Parameters

`T` 

The type of the objects that are in the resource pool.

