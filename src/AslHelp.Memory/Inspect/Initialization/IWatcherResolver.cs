using AslHelp.Common.Results;

namespace AslHelp.Memory.Inspect.Initialization;

public interface IWatcherResolver
{
    Result<(nuint BaseAddress, int[] Offsets)> Resolve();
    Result<nuint> Validate();
}
