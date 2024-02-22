# <a id="AslHelp_Common_Results_Result_OrElse_System_Func_AslHelp_Common_Results_Errors_IResultError_AslHelp_Common_Results_Result__"></a> Method OrElse

Namespace: [AslHelp.Common.Results](AslHelp.Common.Results.md)  
Assembly: AslHelp.Common.dll  

## <a id="AslHelp_Common_Results_Result_OrElse_System_Func_AslHelp_Common_Results_Errors_IResultError_AslHelp_Common_Results_Result__"></a> OrElse\(Func<IResultError, Result\>\)

```csharp
public Result OrElse(Func<IResultError, Result> op)
```

### Parameters

`op` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<[IResultError](AslHelp.Common.Results.Errors.IResultError.md), [Result](AslHelp.Common.Results.Result.md)\>

### Returns

 [Result](AslHelp.Common.Results.Result.md)

## <a id="AslHelp_Common_Results_Result_OrElse_System_Action_AslHelp_Common_Results_Errors_IResultError__"></a> OrElse\(Action<IResultError\>\)

```csharp
public Result OrElse(Action<IResultError> op)
```

### Parameters

`op` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[IResultError](AslHelp.Common.Results.Errors.IResultError.md)\>

### Returns

 [Result](AslHelp.Common.Results.Result.md)

