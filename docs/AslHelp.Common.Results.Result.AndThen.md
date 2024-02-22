# <a id="AslHelp_Common_Results_Result_AndThen_System_Action_"></a> Method AndThen

Namespace: [AslHelp.Common.Results](AslHelp.Common.Results.md)  
Assembly: AslHelp.Common.dll  

## <a id="AslHelp_Common_Results_Result_AndThen_System_Action_"></a> AndThen\(Action\)

```csharp
public Result AndThen(Action op)
```

### Parameters

`op` [Action](https://learn.microsoft.com/dotnet/api/system.action)

### Returns

 [Result](AslHelp.Common.Results.Result.md)

## <a id="AslHelp_Common_Results_Result_AndThen_System_Func_AslHelp_Common_Results_Result__"></a> AndThen\(Func<Result\>\)

```csharp
public Result AndThen(Func<Result> op)
```

### Parameters

`op` [Func](https://learn.microsoft.com/dotnet/api/system.func\-1)<[Result](AslHelp.Common.Results.Result.md)\>

### Returns

 [Result](AslHelp.Common.Results.Result.md)

## <a id="AslHelp_Common_Results_Result_AndThen__1_System_Func_AslHelp_Common_Results_Result___0___"></a> AndThen<TValue\>\(Func<Result<TValue\>\>\)

```csharp
public Result<TValue> AndThen<TValue>(Func<Result<TValue>> op)
```

### Parameters

`op` [Func](https://learn.microsoft.com/dotnet/api/system.func\-1)<[Result](AslHelp.Common.Results.Result\-1.md)<TValue\>\>

### Returns

 [Result](AslHelp.Common.Results.Result\-1.md)<TValue\>

### Type Parameters

`TValue` 

