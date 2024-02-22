# <a id="AslHelp_Collections_Extensions_ArrayPoolExtensions_ReturnIfNotNull__1_System_Buffers_ArrayPool___0____0___"></a> Method ReturnIfNotNull<T\>

Namespace: [AslHelp.Collections.Extensions](AslHelp.Collections.Extensions.md)  
Assembly: AslHelp.Collections.dll  

## <a id="AslHelp_Collections_Extensions_ArrayPoolExtensions_ReturnIfNotNull__1_System_Buffers_ArrayPool___0____0___"></a> ReturnIfNotNull<T\>\(ArrayPool<T\>, T\[\]?\)

If <code class="paramref">array</code> is not <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>,
returns it to the pool that it was previously obtained from using the <xref href="System.Buffers.ArrayPool%601.Rent(System.Int32)" data-throw-if-not-resolved="false"></xref>
method on the same <xref href="System.Buffers.ArrayPool%601" data-throw-if-not-resolved="false"></xref> instance.

```csharp
public static void ReturnIfNotNull<T>(this ArrayPool<T> pool, T[]? array)
```

### Parameters

`pool` [ArrayPool](https://learn.microsoft.com/dotnet/api/system.buffers.arraypool\-1)<T\>

`array` T\[\]?

The buffer to return to the pool.

### Type Parameters

`T` 

The type of the objects that are in the resource pool.

