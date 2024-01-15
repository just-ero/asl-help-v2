using System;
using System.Diagnostics.CodeAnalysis;

using AslHelp.Common.Results.Errors;

namespace AslHelp.Common.Results;

public readonly struct Result : IResult
{
    private Result(IResultError? error)
    {
        Error = error;

        IsOk = Error is null;
        IsErr = Error is not null;
    }

    [MemberNotNullWhen(false, nameof(Error))]
    public bool IsOk { get; }

    [MemberNotNullWhen(true, nameof(Error))]
    public bool IsErr { get; }

    public IResultError? Error { get; }

    // Construction
    public static Result Ok()
    {
        return new(null);
    }

    public static Result Err(IResultError error)
    {
        return new(error);
    }

    // Operators
    public static implicit operator Result(ResultError error)
    {
        return Err(error);
    }

    public static implicit operator Result(Exception exception)
    {
        ExceptionError error = exception;
        return Err(error);
    }

    // Rust impl
    public Result And(Result res)
    {
        return IsOk
            ? res
            : this;
    }

    public Result<TValue> And<TValue>(Result<TValue> res)
    {
        return IsOk
            ? res
            : Result<TValue>.Err(Error);
    }

    public Result AndThen(Action op)
    {
        if (IsOk)
        {
            op();
        }

        return this;
    }

    public Result AndThen(Func<Result> op)
    {
        return IsOk
            ? op()
            : this;
    }

    public Result<TValue> AndThen<TValue>(Func<Result<TValue>> op)
    {
        return IsOk
            ? op()
            : Result<TValue>.Err(Error);
    }

    public void ExpectOk(string message)
    {
        if (!IsOk)
        {
            ThrowHelper.ThrowInvalidOperationException(message);
        }
    }

    public IResultError ExpectErr(string message)
    {
        if (!IsErr)
        {
            ThrowHelper.ThrowInvalidOperationException(message);
        }

        return Error;
    }

    public Result<TValue> Map<TValue>(TValue value)
    {
        return IsOk
            ? Result<TValue>.Ok(value)
            : Result<TValue>.Err(Error);
    }

    public Result MapErr<TError>(Func<IResultError, TError> op)
        where TError : IResultError
    {
        return IsOk
            ? this
            : Result.Err(op(Error));
    }

    public TValue MapOrElse<TValue>(TValue @default, Func<IResultError, TValue> err)
    {
        return IsOk
            ? @default
            : err(Error);
    }

    public Result Or(Result res)
    {
        return IsOk
            ? this
            : res;
    }

    public Result OrElse(Func<IResultError, Result> op)
    {
        return IsOk
            ? this
            : op(Error);
    }

    public Result OrElse(Action<IResultError> op)
    {
        if (IsErr)
        {
            op(Error);
        }

        return this;
    }

    public IResultError UnwrapErr()
    {
        if (!IsErr)
        {
            string msg = $"Attempted to unwrap Err: {this}";
            ThrowHelper.ThrowInvalidOperationException(msg);
        }

        return Error;
    }

    public override string ToString()
    {
        if (IsOk)
        {
            return $"Result.Ok()";
        }
        else
        {
            return $"Result.Err({Error})";
        }
    }
}
