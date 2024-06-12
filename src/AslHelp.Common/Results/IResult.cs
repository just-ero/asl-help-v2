using AslHelp.Common.Results.Errors;

namespace AslHelp.Common.Results;

public interface IResult
{
    bool IsOk { get; }
    bool IsErr { get; }

    IResultError? Error { get; }
    IResult? InnerResult { get; }
}

public interface IResult<out TValue> : IResult
{
    TValue? Value { get; }
}
