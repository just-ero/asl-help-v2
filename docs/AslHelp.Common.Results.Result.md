# <a id="AslHelp_Common_Results_Result"></a> Struct Result

Namespace: [AslHelp.Common.Results](AslHelp.Common.Results.md)  
Assembly: AslHelp.Common.dll  

```csharp
public readonly struct Result : IResult
```

#### Implements

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

### <a id="AslHelp_Common_Results_Result_Error"></a> Error

```csharp
public IResultError? Error { get; }
```

#### Property Value

 [IResultError](AslHelp.Common.Results.Errors.IResultError.md)?

### <a id="AslHelp_Common_Results_Result_IsErr"></a> IsErr

```csharp
public bool IsErr { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Common_Results_Result_IsOk"></a> IsOk

```csharp
public bool IsOk { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="AslHelp_Common_Results_Result_And_AslHelp_Common_Results_Result_"></a> And\(Result\)

```csharp
public Result And(Result res)
```

#### Parameters

`res` [Result](AslHelp.Common.Results.Result.md)

#### Returns

 [Result](AslHelp.Common.Results.Result.md)

### <a id="AslHelp_Common_Results_Result_And__1_AslHelp_Common_Results_Result___0__"></a> And<TValue\>\(Result<TValue\>\)

```csharp
public Result<TValue> And<TValue>(Result<TValue> res)
```

#### Parameters

`res` [Result](AslHelp.Common.Results.Result\-1.md)<TValue\>

#### Returns

 [Result](AslHelp.Common.Results.Result\-1.md)<TValue\>

#### Type Parameters

`TValue` 

### <a id="AslHelp_Common_Results_Result_AndThen_System_Action_"></a> AndThen\(Action\)

```csharp
public Result AndThen(Action op)
```

#### Parameters

`op` [Action](https://learn.microsoft.com/dotnet/api/system.action)

#### Returns

 [Result](AslHelp.Common.Results.Result.md)

### <a id="AslHelp_Common_Results_Result_AndThen_System_Func_AslHelp_Common_Results_Result__"></a> AndThen\(Func<Result\>\)

```csharp
public Result AndThen(Func<Result> op)
```

#### Parameters

`op` [Func](https://learn.microsoft.com/dotnet/api/system.func\-1)<[Result](AslHelp.Common.Results.Result.md)\>

#### Returns

 [Result](AslHelp.Common.Results.Result.md)

### <a id="AslHelp_Common_Results_Result_AndThen__1_System_Func_AslHelp_Common_Results_Result___0___"></a> AndThen<TValue\>\(Func<Result<TValue\>\>\)

```csharp
public Result<TValue> AndThen<TValue>(Func<Result<TValue>> op)
```

#### Parameters

`op` [Func](https://learn.microsoft.com/dotnet/api/system.func\-1)<[Result](AslHelp.Common.Results.Result\-1.md)<TValue\>\>

#### Returns

 [Result](AslHelp.Common.Results.Result\-1.md)<TValue\>

#### Type Parameters

`TValue` 

### <a id="AslHelp_Common_Results_Result_Err_AslHelp_Common_Results_Errors_IResultError_"></a> Err\(IResultError\)

```csharp
public static Result Err(IResultError error)
```

#### Parameters

`error` [IResultError](AslHelp.Common.Results.Errors.IResultError.md)

#### Returns

 [Result](AslHelp.Common.Results.Result.md)

### <a id="AslHelp_Common_Results_Result_ExpectErr_System_String_"></a> ExpectErr\(string\)

```csharp
public IResultError ExpectErr(string message)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [IResultError](AslHelp.Common.Results.Errors.IResultError.md)

### <a id="AslHelp_Common_Results_Result_ExpectOk_System_String_"></a> ExpectOk\(string\)

```csharp
public void ExpectOk(string message)
```

#### Parameters

`message` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="AslHelp_Common_Results_Result_IsErrAnd_System_Func_AslHelp_Common_Results_Errors_IResultError_System_Boolean__"></a> IsErrAnd\(Func<IResultError, bool\>\)

```csharp
public bool IsErrAnd(Func<IResultError, bool> op)
```

#### Parameters

`op` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<[IResultError](AslHelp.Common.Results.Errors.IResultError.md), [bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Common_Results_Result_IsOkAnd_System_Func_System_Boolean__"></a> IsOkAnd\(Func<bool\>\)

```csharp
public bool IsOkAnd(Func<bool> op)
```

#### Parameters

`op` [Func](https://learn.microsoft.com/dotnet/api/system.func\-1)<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="AslHelp_Common_Results_Result_Map__1___0_"></a> Map<TValue\>\(TValue\)

```csharp
public Result<TValue> Map<TValue>(TValue value)
```

#### Parameters

`value` TValue

#### Returns

 [Result](AslHelp.Common.Results.Result\-1.md)<TValue\>

#### Type Parameters

`TValue` 

### <a id="AslHelp_Common_Results_Result_MapErr__1_System_Func_AslHelp_Common_Results_Errors_IResultError___0__"></a> MapErr<TError\>\(Func<IResultError, TError\>\)

```csharp
public Result MapErr<TError>(Func<IResultError, TError> op) where TError : IResultError
```

#### Parameters

`op` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<[IResultError](AslHelp.Common.Results.Errors.IResultError.md), TError\>

#### Returns

 [Result](AslHelp.Common.Results.Result.md)

#### Type Parameters

`TError` 

### <a id="AslHelp_Common_Results_Result_MapOrElse__1___0_System_Func_AslHelp_Common_Results_Errors_IResultError___0__"></a> MapOrElse<TValue\>\(TValue, Func<IResultError, TValue\>\)

```csharp
public TValue MapOrElse<TValue>(TValue @default, Func<IResultError, TValue> err)
```

#### Parameters

`default` TValue

`err` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<[IResultError](AslHelp.Common.Results.Errors.IResultError.md), TValue\>

#### Returns

 TValue

#### Type Parameters

`TValue` 

### <a id="AslHelp_Common_Results_Result_Ok"></a> Ok\(\)

```csharp
public static Result Ok()
```

#### Returns

 [Result](AslHelp.Common.Results.Result.md)

### <a id="AslHelp_Common_Results_Result_Or_AslHelp_Common_Results_Result_"></a> Or\(Result\)

```csharp
public Result Or(Result res)
```

#### Parameters

`res` [Result](AslHelp.Common.Results.Result.md)

#### Returns

 [Result](AslHelp.Common.Results.Result.md)

### <a id="AslHelp_Common_Results_Result_OrElse_System_Func_AslHelp_Common_Results_Errors_IResultError_AslHelp_Common_Results_Result__"></a> OrElse\(Func<IResultError, Result\>\)

```csharp
public Result OrElse(Func<IResultError, Result> op)
```

#### Parameters

`op` [Func](https://learn.microsoft.com/dotnet/api/system.func\-2)<[IResultError](AslHelp.Common.Results.Errors.IResultError.md), [Result](AslHelp.Common.Results.Result.md)\>

#### Returns

 [Result](AslHelp.Common.Results.Result.md)

### <a id="AslHelp_Common_Results_Result_OrElse_System_Action_AslHelp_Common_Results_Errors_IResultError__"></a> OrElse\(Action<IResultError\>\)

```csharp
public Result OrElse(Action<IResultError> op)
```

#### Parameters

`op` [Action](https://learn.microsoft.com/dotnet/api/system.action\-1)<[IResultError](AslHelp.Common.Results.Errors.IResultError.md)\>

#### Returns

 [Result](AslHelp.Common.Results.Result.md)

### <a id="AslHelp_Common_Results_Result_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="AslHelp_Common_Results_Result_UnwrapErr"></a> UnwrapErr\(\)

```csharp
public IResultError UnwrapErr()
```

#### Returns

 [IResultError](AslHelp.Common.Results.Errors.IResultError.md)

## Operators

### <a id="AslHelp_Common_Results_Result_op_Implicit_AslHelp_Common_Results_Errors_ResultError__AslHelp_Common_Results_Result"></a> implicit operator Result\(ResultError\)

```csharp
public static implicit operator Result(ResultError error)
```

#### Parameters

`error` [ResultError](AslHelp.Common.Results.Errors.ResultError.md)

#### Returns

 [Result](AslHelp.Common.Results.Result.md)

### <a id="AslHelp_Common_Results_Result_op_Implicit_System_Exception__AslHelp_Common_Results_Result"></a> implicit operator Result\(Exception\)

```csharp
public static implicit operator Result(Exception exception)
```

#### Parameters

`exception` [Exception](https://learn.microsoft.com/dotnet/api/system.exception)

#### Returns

 [Result](AslHelp.Common.Results.Result.md)

