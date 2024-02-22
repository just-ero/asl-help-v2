# <a id="AslHelp_Common_Results_Result_1_AndThen_System_Action__0__"></a> Method AndThen

Namespace: [AslHelp.Common.Results](AslHelp.Common.Results.md)  
Assembly: AslHelp.Common.dll  

## <a id="AslHelp_Common_Results_Result_1_AndThen_System_Action__0__"></a> AndThen\(Action<TValue\>\)

```csharp
public Result<TValue> AndThen(Action<TValue> op)
```

### Parameters

`op` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<TValue\>

### Returns

 [Result](AslHelp.Common.Results.Result\-1.md)<TValue\>

## <a id="AslHelp_Common_Results_Result_1_AndThen_System_Func__0_AslHelp_Common_Results_Result__"></a> AndThen\(Func<TValue, Result\>\)

```csharp
public Result AndThen(Func<TValue, Result> op)
```

### Parameters

`op` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<TValue, [Result](AslHelp.Common.Results.Result.md)\>

### Returns

 [Result](AslHelp.Common.Results.Result.md)

## <a id="AslHelp_Common_Results_Result_1_AndThen__1_System_Func__0_AslHelp_Common_Results_Result___0___"></a> AndThen<TOther\>\(Func<TValue, Result<TOther\>\>\)

```csharp
public Result<TOther> AndThen<TOther>(Func<TValue, Result<TOther>> op)
```

### Parameters

`op` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<TValue, [Result](AslHelp.Common.Results.Result\-1.md)<TOther\>\>

### Returns

 [Result](AslHelp.Common.Results.Result\-1.md)<TOther\>

### Type Parameters

`TOther` 

