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

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetFieldValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetMethod.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetPropertyValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.IsType.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.SetFieldValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.SetPropertyValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Properties

 [Error](AslHelp.Common.Results.Result\-1.Error.md\#AslHelp\_Common\_Results\_Result\_1\_Error)

 [IsErr](AslHelp.Common.Results.Result\-1.IsErr.md\#AslHelp\_Common\_Results\_Result\_1\_IsErr)

 [IsOk](AslHelp.Common.Results.Result\-1.IsOk.md\#AslHelp\_Common\_Results\_Result\_1\_IsOk)

 [Value](AslHelp.Common.Results.Result\-1.Value.md\#AslHelp\_Common\_Results\_Result\_1\_Value)

## Methods

 [And\(Result\)](AslHelp.Common.Results.Result\-1.And.md\#AslHelp\_Common\_Results\_Result\_1\_And\_AslHelp\_Common\_Results\_Result\_)

 [And<TOther\>\(Result<TOther\>\)](AslHelp.Common.Results.Result\-1.And.md\#AslHelp\_Common\_Results\_Result\_1\_And\_\_1\_AslHelp\_Common\_Results\_Result\_\_\_0\_\_)

 [AndThen\(Action<TValue\>\)](AslHelp.Common.Results.Result\-1.AndThen.md\#AslHelp\_Common\_Results\_Result\_1\_AndThen\_System\_Action\_\_0\_\_)

 [AndThen\(Func<TValue, Result\>\)](AslHelp.Common.Results.Result\-1.AndThen.md\#AslHelp\_Common\_Results\_Result\_1\_AndThen\_System\_Func\_\_0\_AslHelp\_Common\_Results\_Result\_\_)

 [AndThen<TOther\>\(Func<TValue, Result<TOther\>\>\)](AslHelp.Common.Results.Result\-1.AndThen.md\#AslHelp\_Common\_Results\_Result\_1\_AndThen\_\_1\_System\_Func\_\_0\_AslHelp\_Common\_Results\_Result\_\_\_0\_\_\_)

 [Err\(IResultError\)](AslHelp.Common.Results.Result\-1.Err.md\#AslHelp\_Common\_Results\_Result\_1\_Err\_AslHelp\_Common\_Results\_Errors\_IResultError\_)

 [ExpectErr\(string\)](AslHelp.Common.Results.Result\-1.ExpectErr.md\#AslHelp\_Common\_Results\_Result\_1\_ExpectErr\_System\_String\_)

 [ExpectOk\(string\)](AslHelp.Common.Results.Result\-1.ExpectOk.md\#AslHelp\_Common\_Results\_Result\_1\_ExpectOk\_System\_String\_)

 [IsErrAnd\(Func<IResultError, bool\>\)](AslHelp.Common.Results.Result\-1.IsErrAnd.md\#AslHelp\_Common\_Results\_Result\_1\_IsErrAnd\_System\_Func\_AslHelp\_Common\_Results\_Errors\_IResultError\_System\_Boolean\_\_)

 [IsOkAnd\(Func<TValue, bool\>\)](AslHelp.Common.Results.Result\-1.IsOkAnd.md\#AslHelp\_Common\_Results\_Result\_1\_IsOkAnd\_System\_Func\_\_0\_System\_Boolean\_\_)

 [Map<TOther\>\(Func<TValue, TOther\>\)](AslHelp.Common.Results.Result\-1.Map.md\#AslHelp\_Common\_Results\_Result\_1\_Map\_\_1\_System\_Func\_\_0\_\_\_0\_\_)

 [MapErr<TOtherErr\>\(Func<IResultError, TOtherErr\>\)](AslHelp.Common.Results.Result\-1.MapErr.md\#AslHelp\_Common\_Results\_Result\_1\_MapErr\_\_1\_System\_Func\_AslHelp\_Common\_Results\_Errors\_IResultError\_\_\_0\_\_)

 [MapOr<TOther\>\(TOther, Func<TValue, TOther\>\)](AslHelp.Common.Results.Result\-1.MapOr.md\#AslHelp\_Common\_Results\_Result\_1\_MapOr\_\_1\_\_\_0\_System\_Func\_\_0\_\_\_0\_\_)

 [MapOrElse<TOther\>\(Func<TValue, TOther\>, Func<IResultError, TOther\>\)](AslHelp.Common.Results.Result\-1.MapOrElse.md\#AslHelp\_Common\_Results\_Result\_1\_MapOrElse\_\_1\_System\_Func\_\_0\_\_\_0\_\_System\_Func\_AslHelp\_Common\_Results\_Errors\_IResultError\_\_\_0\_\_)

 [Ok\(TValue\)](AslHelp.Common.Results.Result\-1.Ok.md\#AslHelp\_Common\_Results\_Result\_1\_Ok\_\_0\_)

 [Or\(Result<TValue\>\)](AslHelp.Common.Results.Result\-1.Or.md\#AslHelp\_Common\_Results\_Result\_1\_Or\_AslHelp\_Common\_Results\_Result\_\_0\_\_)

 [OrElse\(Func<IResultError, Result<TValue\>\>\)](AslHelp.Common.Results.Result\-1.OrElse.md\#AslHelp\_Common\_Results\_Result\_1\_OrElse\_System\_Func\_AslHelp\_Common\_Results\_Errors\_IResultError\_AslHelp\_Common\_Results\_Result\_\_0\_\_\_)

 [OrElse\(Action<IResultError\>\)](AslHelp.Common.Results.Result\-1.OrElse.md\#AslHelp\_Common\_Results\_Result\_1\_OrElse\_System\_Action\_AslHelp\_Common\_Results\_Errors\_IResultError\_\_)

 [ToString\(\)](AslHelp.Common.Results.Result\-1.ToString.md\#AslHelp\_Common\_Results\_Result\_1\_ToString)

 [Unwrap\(\)](AslHelp.Common.Results.Result\-1.Unwrap.md\#AslHelp\_Common\_Results\_Result\_1\_Unwrap)

 [UnwrapErr\(\)](AslHelp.Common.Results.Result\-1.UnwrapErr.md\#AslHelp\_Common\_Results\_Result\_1\_UnwrapErr)

 [UnwrapOr\(TValue\)](AslHelp.Common.Results.Result\-1.UnwrapOr.md\#AslHelp\_Common\_Results\_Result\_1\_UnwrapOr\_\_0\_)

 [UnwrapOrDefault\(\)](AslHelp.Common.Results.Result\-1.UnwrapOrDefault.md\#AslHelp\_Common\_Results\_Result\_1\_UnwrapOrDefault)

 [UnwrapOrElse\(Func<IResultError, TValue\>\)](AslHelp.Common.Results.Result\-1.UnwrapOrElse.md\#AslHelp\_Common\_Results\_Result\_1\_UnwrapOrElse\_System\_Func\_AslHelp\_Common\_Results\_Errors\_IResultError\_\_0\_\_)

## Operators

 [implicit operator Result<TValue\>\(TValue\)](AslHelp.Common.Results.Result\-1.op\_Implicit.md\#AslHelp\_Common\_Results\_Result\_1\_op\_Implicit\_\_0\_\_AslHelp\_Common\_Results\_Result\_\_0\_)

 [implicit operator Result<TValue\>\(ResultError\)](AslHelp.Common.Results.Result\-1.op\_Implicit.md\#AslHelp\_Common\_Results\_Result\_1\_op\_Implicit\_AslHelp\_Common\_Results\_Errors\_ResultError\_\_AslHelp\_Common\_Results\_Result\_\_0\_)

 [implicit operator Result<TValue\>\(Exception\)](AslHelp.Common.Results.Result\-1.op\_Implicit.md\#AslHelp\_Common\_Results\_Result\_1\_op\_Implicit\_System\_Exception\_\_AslHelp\_Common\_Results\_Result\_\_0\_)

