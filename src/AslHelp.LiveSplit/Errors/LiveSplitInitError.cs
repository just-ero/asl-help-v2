using AslHelp.Common.Results.Errors;

using LiveSplit.ASL;
using LiveSplit.Model;
using LiveSplit.UI.Components;
using LiveSplit.View;

namespace AslHelp.LiveSplit.Errors;

internal sealed record LiveSplitInitError : ResultError
{
    private LiveSplitInitError(string message)
        : base(message) { }

    public static LiveSplitInitError Other(string message)
    {
        return new(message);
    }

    public static LiveSplitInitError TimerFormNotFound
        => new($"An instance of type '{nameof(TimerForm)}' could not be found within the open forms of the application.");

    public static LiveSplitInitError LiveSplitStateNull
        => new($"The '{nameof(TimerForm)}' did not contain a valid instance of '{nameof(LiveSplitState)}'.");

    public static LiveSplitInitError ScriptAssemblyNotFound
        => new($"The compiled assembly for the executing script could not be found.");

    public static LiveSplitInitError ScriptComponentNotFound
        => new($"The '{nameof(ASLComponent)}' containing the executing script could not be found.");

    public static LiveSplitInitError ScriptSettingsNull
        => new($"The '{nameof(ASLScript)}' did not contain a valid instance of '{nameof(ASLSettingsBuilder)}'.");
}
