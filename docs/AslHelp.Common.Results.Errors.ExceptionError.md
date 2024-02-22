# <a id="AslHelp_Common_Results_Errors_ExceptionError"></a> Class ExceptionError

Namespace: [AslHelp.Common.Results.Errors](AslHelp.Common.Results.Errors.md)  
Assembly: AslHelp.Common.dll  

```csharp
public sealed record ExceptionError : ResultError, IResultError, IEquatable<ResultError>, IEquatable<ExceptionError>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ResultError](AslHelp.Common.Results.Errors.ResultError.md) ← 
[ExceptionError](AslHelp.Common.Results.Errors.ExceptionError.md)

#### Implements

[IResultError](AslHelp.Common.Results.Errors.IResultError.md), 
[IEquatable<ResultError\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
[IEquatable<ExceptionError\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[ResultError.Message](AslHelp.Common.Results.Errors.ResultError.Message.md\#AslHelp\_Common\_Results\_Errors\_ResultError\_Message), 
[ResultError.ToString\(\)](AslHelp.Common.Results.Errors.ResultError.ToString.md\#AslHelp\_Common\_Results\_Errors\_ResultError\_ToString), 
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

## Constructors

 [ExceptionError\(Exception\)](AslHelp.Common.Results.Errors.ExceptionError.\-ctor.md\#AslHelp\_Common\_Results\_Errors\_ExceptionError\_\_ctor\_System\_Exception\_)

 [ExceptionError\(Exception, string\)](AslHelp.Common.Results.Errors.ExceptionError.\-ctor.md\#AslHelp\_Common\_Results\_Errors\_ExceptionError\_\_ctor\_System\_Exception\_System\_String\_)

## Properties

 [Exception](AslHelp.Common.Results.Errors.ExceptionError.Exception.md\#AslHelp\_Common\_Results\_Errors\_ExceptionError\_Exception)

## Operators

 [implicit operator ExceptionError\(Exception\)](AslHelp.Common.Results.Errors.ExceptionError.op\_Implicit.md\#AslHelp\_Common\_Results\_Errors\_ExceptionError\_op\_Implicit\_System\_Exception\_\_AslHelp\_Common\_Results\_Errors\_ExceptionError)

