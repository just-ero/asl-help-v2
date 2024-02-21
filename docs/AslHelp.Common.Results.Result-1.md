# <a id="AslHelp_Common_Results_Result_1"></a> Struct Result<TValue\>

Namespace: [AslHelp.Common.Results](AslHelp.Common.Results.md)  
Assembly: AslHelp.Common.dll  

```csharp
public readonly struct Result<TValue> : IResult<TValue>, IResult
```

#### Type Parameters

`TValue` 

#### Implements

[IResult<TValue\>](AslHelp.Common.Results.IResult\-1.md), 
[IResult](AslHelp.Common.Results.IResult.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Properties

### <a id="AslHelp_Common_Results_Result_1_Error"></a> Error

```csharp
public IResultError? Error { get; }
```

#### Property Value

 [IResultError](AslHelp.Common.Results.Errors.IResultError.md)?

### <a id="AslHelp_Common_Results_Result_1_IsErr"></a> IsErr

```csharp
public bool IsErr { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Common_Results_Result_1_IsOk"></a> IsOk

```csharp
public bool IsOk { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Common_Results_Result_1_Value"></a> Value

```csharp
public TValue? Value { get; }
```

#### Property Value

 TValue?

## Methods

### <a id="AslHelp_Common_Results_Result_1_And_AslHelp_Common_Results_Result_"></a> And\(Result\)

```csharp
public Result And(Result res)
```

#### Parameters

`res` [Result](AslHelp.Common.Results.Result.md)

#### Returns

 [Result](AslHelp.Common.Results.Result.md)

### <a id="AslHelp_Common_Results_Result_1_And__1_AslHelp_Common_Results_Result___0__"></a> And<TOther\>\(Result<TOther\>\)

```csharp
public Result<TOther> And<TOther>(Result<TOther> res)
```

#### Parameters

`res` [Result](AslHelp.Common.Results.Result\-1.md)<TOther\>

#### Returns

 [Result](AslHelp.Common.Results.Result\-1.md)<TOther\>

#### Type Parameters

`TOther` 

### <a id="AslHelp_Common_Results_Result_1_AndThen_System_Action__0__"></a> AndThen\(Action<TValue\>\)

```csharp
public Result<TValue> AndThen(Action<TValue> op)
```

#### Parameters

`op` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<TValue\>

#### Returns

 [Result](AslHelp.Common.Results.Result\-1.md)<TValue\>

### <a id="AslHelp_Common_Results_Result_1_AndThen_System_Func__0_AslHelp_Common_Results_Result__"></a> AndThen\(Func<TValue, Result\>\)

```csharp
public Result AndThen(Func<TValue, Result> op)
```

#### Parameters

`op` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<TValue, [Result](AslHelp.Common.Results.Result.md)\>

#### Returns

 [Result](AslHelp.Common.Results.Result.md)

### <a id="AslHelp_Common_Results_Result_1_AndThen__1_System_Func__0_AslHelp_Common_Results_Result___0___"></a> AndThen<TOther\>\(Func<TValue, Result<TOther\>\>\)

```csharp
public Result<TOther> AndThen<TOther>(Func<TValue, Result<TOther>> op)
```

#### Parameters

`op` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<TValue, [Result](AslHelp.Common.Results.Result\-1.md)<TOther\>\>

#### Returns

 [Result](AslHelp.Common.Results.Result\-1.md)<TOther\>

#### Type Parameters

`TOther` 

### <a id="AslHelp_Common_Results_Result_1_Err_AslHelp_Common_Results_Errors_IResultError_"></a> Err\(IResultError\)

```csharp
public static Result<TValue> Err(IResultError error)
```

#### Parameters

`error` [IResultError](AslHelp.Common.Results.Errors.IResultError.md)

#### Returns

 [Result](AslHelp.Common.Results.Result\-1.md)<TValue\>

### <a id="AslHelp_Common_Results_Result_1_ExpectErr_System_String_"></a> ExpectErr\(string\)

```csharp
public IResultError ExpectErr(string message)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [IResultError](AslHelp.Common.Results.Errors.IResultError.md)

### <a id="AslHelp_Common_Results_Result_1_ExpectOk_System_String_"></a> ExpectOk\(string\)

```csharp
public TValue ExpectOk(string message)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 TValue

### <a id="AslHelp_Common_Results_Result_1_IsErrAnd_System_Func_AslHelp_Common_Results_Errors_IResultError_System_Boolean__"></a> IsErrAnd\(Func<IResultError, bool\>\)

```csharp
public bool IsErrAnd(Func<IResultError, bool> op)
```

#### Parameters

`op` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<[IResultError](AslHelp.Common.Results.Errors.IResultError.md), [bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Common_Results_Result_1_IsOkAnd_System_Func__0_System_Boolean__"></a> IsOkAnd\(Func<TValue, bool\>\)

```csharp
public bool IsOkAnd(Func<TValue, bool> op)
```

#### Parameters

`op` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<TValue, [bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Common_Results_Result_1_Map__1_System_Func__0___0__"></a> Map<TOther\>\(Func<TValue, TOther\>\)

```csharp
public Result<TOther> Map<TOther>(Func<TValue, TOther> op)
```

#### Parameters

`op` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<TValue, TOther\>

#### Returns

 [Result](AslHelp.Common.Results.Result\-1.md)<TOther\>

#### Type Parameters

`TOther` 

### <a id="AslHelp_Common_Results_Result_1_MapErr__1_System_Func_AslHelp_Common_Results_Errors_IResultError___0__"></a> MapErr<TOtherErr\>\(Func<IResultError, TOtherErr\>\)

```csharp
public Result<TValue> MapErr<TOtherErr>(Func<IResultError, TOtherErr> op) where TOtherErr : IResultError
```

#### Parameters

`op` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<[IResultError](AslHelp.Common.Results.Errors.IResultError.md), TOtherErr\>

#### Returns

 [Result](AslHelp.Common.Results.Result\-1.md)<TValue\>

#### Type Parameters

`TOtherErr` 

### <a id="AslHelp_Common_Results_Result_1_MapOr__1___0_System_Func__0___0__"></a> MapOr<TOther\>\(TOther, Func<TValue, TOther\>\)

```csharp
public TOther MapOr<TOther>(TOther @default, Func<TValue, TOther> op)
```

#### Parameters

`default` TOther

`op` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<TValue, TOther\>

#### Returns

 TOther

#### Type Parameters

`TOther` 

### <a id="AslHelp_Common_Results_Result_1_MapOrElse__1_System_Func__0___0__System_Func_AslHelp_Common_Results_Errors_IResultError___0__"></a> MapOrElse<TOther\>\(Func<TValue, TOther\>, Func<IResultError, TOther\>\)

```csharp
public TOther MapOrElse<TOther>(Func<TValue, TOther> op, Func<IResultError, TOther> @default)
```

#### Parameters

`op` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<TValue, TOther\>

`default` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<[IResultError](AslHelp.Common.Results.Errors.IResultError.md), TOther\>

#### Returns

 TOther

#### Type Parameters

`TOther` 

### <a id="AslHelp_Common_Results_Result_1_Ok__0_"></a> Ok\(TValue\)

```csharp
public static Result<TValue> Ok(TValue value)
```

#### Parameters

`value` TValue

#### Returns

 [Result](AslHelp.Common.Results.Result\-1.md)<TValue\>

### <a id="AslHelp_Common_Results_Result_1_Or_AslHelp_Common_Results_Result__0__"></a> Or\(Result<TValue\>\)

```csharp
public Result<TValue> Or(Result<TValue> res)
```

#### Parameters

`res` [Result](AslHelp.Common.Results.Result\-1.md)<TValue\>

#### Returns

 [Result](AslHelp.Common.Results.Result\-1.md)<TValue\>

### <a id="AslHelp_Common_Results_Result_1_OrElse_System_Func_AslHelp_Common_Results_Errors_IResultError_AslHelp_Common_Results_Result__0___"></a> OrElse\(Func<IResultError, Result<TValue\>\>\)

```csharp
public Result<TValue> OrElse(Func<IResultError, Result<TValue>> op)
```

#### Parameters

`op` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<[IResultError](AslHelp.Common.Results.Errors.IResultError.md), [Result](AslHelp.Common.Results.Result\-1.md)<TValue\>\>

#### Returns

 [Result](AslHelp.Common.Results.Result\-1.md)<TValue\>

### <a id="AslHelp_Common_Results_Result_1_OrElse_System_Action_AslHelp_Common_Results_Errors_IResultError__"></a> OrElse\(Action<IResultError\>\)

```csharp
public Result<TValue> OrElse(Action<IResultError> op)
```

#### Parameters

`op` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[IResultError](AslHelp.Common.Results.Errors.IResultError.md)\>

#### Returns

 [Result](AslHelp.Common.Results.Result\-1.md)<TValue\>

### <a id="AslHelp_Common_Results_Result_1_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="AslHelp_Common_Results_Result_1_Unwrap"></a> Unwrap\(\)

```csharp
public TValue Unwrap()
```

#### Returns

 TValue

### <a id="AslHelp_Common_Results_Result_1_UnwrapErr"></a> UnwrapErr\(\)

```csharp
public IResultError UnwrapErr()
```

#### Returns

 [IResultError](AslHelp.Common.Results.Errors.IResultError.md)

### <a id="AslHelp_Common_Results_Result_1_UnwrapOr__0_"></a> UnwrapOr\(TValue\)

```csharp
public TValue UnwrapOr(TValue @default)
```

#### Parameters

`default` TValue

#### Returns

 TValue

### <a id="AslHelp_Common_Results_Result_1_UnwrapOrDefault"></a> UnwrapOrDefault\(\)

```csharp
public TValue? UnwrapOrDefault()
```

#### Returns

 TValue?

### <a id="AslHelp_Common_Results_Result_1_UnwrapOrElse_System_Func_AslHelp_Common_Results_Errors_IResultError__0__"></a> UnwrapOrElse\(Func<IResultError, TValue\>\)

```csharp
public TValue UnwrapOrElse(Func<IResultError, TValue> op)
```

#### Parameters

`op` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<[IResultError](AslHelp.Common.Results.Errors.IResultError.md), TValue\>

#### Returns

 TValue

## Operators

### <a id="AslHelp_Common_Results_Result_1_op_Implicit__0__AslHelp_Common_Results_Result__0_"></a> implicit operator Result<TValue\>\(TValue\)

```csharp
public static implicit operator Result<TValue>(TValue value)
```

#### Parameters

`value` TValue

#### Returns

 [Result](AslHelp.Common.Results.Result\-1.md)<TValue\>

### <a id="AslHelp_Common_Results_Result_1_op_Implicit_AslHelp_Common_Results_Errors_ResultError__AslHelp_Common_Results_Result__0_"></a> implicit operator Result<TValue\>\(ResultError\)

```csharp
public static implicit operator Result<TValue>(ResultError error)
```

#### Parameters

`error` [ResultError](AslHelp.Common.Results.Errors.ResultError.md)

#### Returns

 [Result](AslHelp.Common.Results.Result\-1.md)<TValue\>

### <a id="AslHelp_Common_Results_Result_1_op_Implicit_System_Exception__AslHelp_Common_Results_Result__0_"></a> implicit operator Result<TValue\>\(Exception\)

```csharp
public static implicit operator Result<TValue>(Exception exception)
```

#### Parameters

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)

#### Returns

 [Result](AslHelp.Common.Results.Result\-1.md)<TValue\>

