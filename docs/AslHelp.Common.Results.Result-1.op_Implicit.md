# <a id="AslHelp_Common_Results_Result_1_op_Implicit__0__AslHelp_Common_Results_Result__0_"></a> Operator implicit operator

Namespace: [AslHelp.Common.Results](AslHelp.Common.Results.md)  
Assembly: AslHelp.Common.dll  

## <a id="AslHelp_Common_Results_Result_1_op_Implicit__0__AslHelp_Common_Results_Result__0_"></a> implicit operator Result<TValue\>\(TValue\)

```csharp
public static implicit operator Result<TValue>(TValue value)
```

### Parameters

`value` TValue

### Returns

 [Result](AslHelp.Common.Results.Result\-1.md)<TValue\>

## <a id="AslHelp_Common_Results_Result_1_op_Implicit_AslHelp_Common_Results_Errors_ResultError__AslHelp_Common_Results_Result__0_"></a> implicit operator Result<TValue\>\(ResultError\)

```csharp
public static implicit operator Result<TValue>(ResultError error)
```

### Parameters

`error` [ResultError](AslHelp.Common.Results.Errors.ResultError.md)

### Returns

 [Result](AslHelp.Common.Results.Result\-1.md)<TValue\>

## <a id="AslHelp_Common_Results_Result_1_op_Implicit_System_Exception__AslHelp_Common_Results_Result__0_"></a> implicit operator Result<TValue\>\(Exception\)

```csharp
public static implicit operator Result<TValue>(Exception exception)
```

### Parameters

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)

### Returns

 [Result](AslHelp.Common.Results.Result\-1.md)<TValue\>

