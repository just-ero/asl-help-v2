# <a id="AslHelp_Common_Results_Result_1_OrElse_System_Func_AslHelp_Common_Results_Errors_IResultError_AslHelp_Common_Results_Result__0___"></a> Method OrElse

Namespace: [AslHelp.Common.Results](AslHelp.Common.Results.md)  
Assembly: AslHelp.Common.dll  

## <a id="AslHelp_Common_Results_Result_1_OrElse_System_Func_AslHelp_Common_Results_Errors_IResultError_AslHelp_Common_Results_Result__0___"></a> OrElse\(Func<IResultError, Result<TValue\>\>\)

```csharp
public Result<TValue> OrElse(Func<IResultError, Result<TValue>> op)
```

### Parameters

`op` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<[IResultError](AslHelp.Common.Results.Errors.IResultError.md), [Result](AslHelp.Common.Results.Result\-1.md)<TValue\>\>

### Returns

 [Result](AslHelp.Common.Results.Result\-1.md)<TValue\>

## <a id="AslHelp_Common_Results_Result_1_OrElse_System_Action_AslHelp_Common_Results_Errors_IResultError__"></a> OrElse\(Action<IResultError\>\)

```csharp
public Result<TValue> OrElse(Action<IResultError> op)
```

### Parameters

`op` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[IResultError](AslHelp.Common.Results.Errors.IResultError.md)\>

### Returns

 [Result](AslHelp.Common.Results.Result\-1.md)<TValue\>

