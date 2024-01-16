using AslHelp.Common.Results;

namespace AslHelp.Common.Extensions;

public static class ResultExtensions
{
    public static Result<T> AsOk<T>(this T value)
    {
        return Result<T>.Ok(value);
    }
}
