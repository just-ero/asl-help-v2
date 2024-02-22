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

[ReflectionExtensions.GetFieldValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetFieldValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetFieldValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetMethod\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetMethod.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetMethod\_System\_Object\_System\_String\_), 
[ReflectionExtensions.GetPropertyValue<T\>\(object, string\)](AslHelp.Common.Extensions.ReflectionExtensions.GetPropertyValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_GetPropertyValue\_\_1\_System\_Object\_System\_String\_), 
[ReflectionExtensions.IsType<T\>\(object\)](AslHelp.Common.Extensions.ReflectionExtensions.IsType.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_IsType\_\_1\_System\_Object\_), 
[ReflectionExtensions.SetFieldValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.SetFieldValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetFieldValue\_\_1\_System\_Object\_System\_String\_\_\_0\_), 
[ReflectionExtensions.SetPropertyValue<T\>\(object, string, T\)](AslHelp.Common.Extensions.ReflectionExtensions.SetPropertyValue.md\#AslHelp\_Common\_Extensions\_ReflectionExtensions\_SetPropertyValue\_\_1\_System\_Object\_System\_String\_\_\_0\_)

## Properties

 [Error](AslHelp.Common.Results.Result.Error.md\#AslHelp\_Common\_Results\_Result\_Error)

 [IsErr](AslHelp.Common.Results.Result.IsErr.md\#AslHelp\_Common\_Results\_Result\_IsErr)

 [IsOk](AslHelp.Common.Results.Result.IsOk.md\#AslHelp\_Common\_Results\_Result\_IsOk)

## Methods

 [And\(Result\)](AslHelp.Common.Results.Result.And.md\#AslHelp\_Common\_Results\_Result\_And\_AslHelp\_Common\_Results\_Result\_)

 [And<TValue\>\(Result<TValue\>\)](AslHelp.Common.Results.Result.And.md\#AslHelp\_Common\_Results\_Result\_And\_\_1\_AslHelp\_Common\_Results\_Result\_\_\_0\_\_)

 [AndThen\(Action\)](AslHelp.Common.Results.Result.AndThen.md\#AslHelp\_Common\_Results\_Result\_AndThen\_System\_Action\_)

 [AndThen\(Func<Result\>\)](AslHelp.Common.Results.Result.AndThen.md\#AslHelp\_Common\_Results\_Result\_AndThen\_System\_Func\_AslHelp\_Common\_Results\_Result\_\_)

 [AndThen<TValue\>\(Func<Result<TValue\>\>\)](AslHelp.Common.Results.Result.AndThen.md\#AslHelp\_Common\_Results\_Result\_AndThen\_\_1\_System\_Func\_AslHelp\_Common\_Results\_Result\_\_\_0\_\_\_)

 [Err\(IResultError\)](AslHelp.Common.Results.Result.Err.md\#AslHelp\_Common\_Results\_Result\_Err\_AslHelp\_Common\_Results\_Errors\_IResultError\_)

 [ExpectErr\(string\)](AslHelp.Common.Results.Result.ExpectErr.md\#AslHelp\_Common\_Results\_Result\_ExpectErr\_System\_String\_)

 [ExpectOk\(string\)](AslHelp.Common.Results.Result.ExpectOk.md\#AslHelp\_Common\_Results\_Result\_ExpectOk\_System\_String\_)

 [IsErrAnd\(Func<IResultError, bool\>\)](AslHelp.Common.Results.Result.IsErrAnd.md\#AslHelp\_Common\_Results\_Result\_IsErrAnd\_System\_Func\_AslHelp\_Common\_Results\_Errors\_IResultError\_System\_Boolean\_\_)

 [IsOkAnd\(Func<bool\>\)](AslHelp.Common.Results.Result.IsOkAnd.md\#AslHelp\_Common\_Results\_Result\_IsOkAnd\_System\_Func\_System\_Boolean\_\_)

 [Map<TValue\>\(TValue\)](AslHelp.Common.Results.Result.Map.md\#AslHelp\_Common\_Results\_Result\_Map\_\_1\_\_\_0\_)

 [MapErr<TError\>\(Func<IResultError, TError\>\)](AslHelp.Common.Results.Result.MapErr.md\#AslHelp\_Common\_Results\_Result\_MapErr\_\_1\_System\_Func\_AslHelp\_Common\_Results\_Errors\_IResultError\_\_\_0\_\_)

 [MapOrElse<TValue\>\(TValue, Func<IResultError, TValue\>\)](AslHelp.Common.Results.Result.MapOrElse.md\#AslHelp\_Common\_Results\_Result\_MapOrElse\_\_1\_\_\_0\_System\_Func\_AslHelp\_Common\_Results\_Errors\_IResultError\_\_\_0\_\_)

 [Ok\(\)](AslHelp.Common.Results.Result.Ok.md\#AslHelp\_Common\_Results\_Result\_Ok)

 [Or\(Result\)](AslHelp.Common.Results.Result.Or.md\#AslHelp\_Common\_Results\_Result\_Or\_AslHelp\_Common\_Results\_Result\_)

 [OrElse\(Func<IResultError, Result\>\)](AslHelp.Common.Results.Result.OrElse.md\#AslHelp\_Common\_Results\_Result\_OrElse\_System\_Func\_AslHelp\_Common\_Results\_Errors\_IResultError\_AslHelp\_Common\_Results\_Result\_\_)

 [OrElse\(Action<IResultError\>\)](AslHelp.Common.Results.Result.OrElse.md\#AslHelp\_Common\_Results\_Result\_OrElse\_System\_Action\_AslHelp\_Common\_Results\_Errors\_IResultError\_\_)

 [ToString\(\)](AslHelp.Common.Results.Result.ToString.md\#AslHelp\_Common\_Results\_Result\_ToString)

 [UnwrapErr\(\)](AslHelp.Common.Results.Result.UnwrapErr.md\#AslHelp\_Common\_Results\_Result\_UnwrapErr)

## Operators

 [implicit operator Result\(ResultError\)](AslHelp.Common.Results.Result.op\_Implicit.md\#AslHelp\_Common\_Results\_Result\_op\_Implicit\_AslHelp\_Common\_Results\_Errors\_ResultError\_\_AslHelp\_Common\_Results\_Result)

 [implicit operator Result\(Exception\)](AslHelp.Common.Results.Result.op\_Implicit.md\#AslHelp\_Common\_Results\_Result\_op\_Implicit\_System\_Exception\_\_AslHelp\_Common\_Results\_Result)

