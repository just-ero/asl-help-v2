# <a id="AslHelp_Common_Results_Result_1_MapErr__1_System_Func_AslHelp_Common_Results_Errors_IResultError___0__"></a> Method MapErr<TOtherErr\>

Namespace: [AslHelp.Common.Results](AslHelp.Common.Results.md)  
Assembly: AslHelp.Common.dll  

## <a id="AslHelp_Common_Results_Result_1_MapErr__1_System_Func_AslHelp_Common_Results_Errors_IResultError___0__"></a> MapErr<TOtherErr\>\(Func<IResultError, TOtherErr\>\)

```csharp
public Result<TValue> MapErr<TOtherErr>(Func<IResultError, TOtherErr> op) where TOtherErr : IResultError
```

### Parameters

`op` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<[IResultError](AslHelp.Common.Results.Errors.IResultError.md), TOtherErr\>

### Returns

 [Result](AslHelp.Common.Results.Result\-1.md)<TValue\>

### Type Parameters

`TOtherErr` 

