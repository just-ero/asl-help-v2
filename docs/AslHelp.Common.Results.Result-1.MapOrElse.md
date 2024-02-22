# <a id="AslHelp_Common_Results_Result_1_MapOrElse__1_System_Func__0___0__System_Func_AslHelp_Common_Results_Errors_IResultError___0__"></a> Method MapOrElse<TOther\>

Namespace: [AslHelp.Common.Results](AslHelp.Common.Results.md)  
Assembly: AslHelp.Common.dll  

## <a id="AslHelp_Common_Results_Result_1_MapOrElse__1_System_Func__0___0__System_Func_AslHelp_Common_Results_Errors_IResultError___0__"></a> MapOrElse<TOther\>\(Func<TValue, TOther\>, Func<IResultError, TOther\>\)

```csharp
public TOther MapOrElse<TOther>(Func<TValue, TOther> op, Func<IResultError, TOther> @default)
```

### Parameters

`op` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<TValue, TOther\>

`default` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<[IResultError](AslHelp.Common.Results.Errors.IResultError.md), TOther\>

### Returns

 TOther

### Type Parameters

`TOther` 

