# <a id="AslHelp_Common_Results_Result_MapErr__1_System_Func_AslHelp_Common_Results_Errors_IResultError___0__"></a> Method MapErr<TError\>

Namespace: [AslHelp.Common.Results](AslHelp.Common.Results.md)  
Assembly: AslHelp.Common.dll  

## <a id="AslHelp_Common_Results_Result_MapErr__1_System_Func_AslHelp_Common_Results_Errors_IResultError___0__"></a> MapErr<TError\>\(Func<IResultError, TError\>\)

```csharp
public Result MapErr<TError>(Func<IResultError, TError> op) where TError : IResultError
```

### Parameters

`op` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<[IResultError](AslHelp.Common.Results.Errors.IResultError.md), TError\>

### Returns

 [Result](AslHelp.Common.Results.Result.md)

### Type Parameters

`TError` 

