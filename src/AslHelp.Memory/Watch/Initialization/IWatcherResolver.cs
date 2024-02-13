using AslHelp.Common.Results;

namespace AslHelp.Memory.Watch.Initialization;

public interface IWatcherResolver
{
    Result<(nuint BaseAddress, int[] Offsets)> Resolve();
    Result<nuint> Validate();
}
