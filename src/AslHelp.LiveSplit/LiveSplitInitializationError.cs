using AslHelp.Common.Results.Errors;

using LiveSplit.ASL;
using LiveSplit.Model;
using LiveSplit.UI.Components;
using LiveSplit.View;

namespace AslHelp.LiveSplit;

internal sealed record LiveSplitInitializationError : ResultError
{
    private LiveSplitInitializationError(string message)
        : base(message) { }

    public static LiveSplitInitializationError Other(string message)
    {
        return new(message);
    }

    public static LiveSplitInitializationError TimerForm_NotFound
        => new($"An instance of type '{nameof(TimerForm)}' could not be found within the open forms of the application.");

    public static LiveSplitInitializationError LiveSplitState_Is_Null
        => new($"The '{nameof(TimerForm)}' did not contain a valid instance of '{nameof(LiveSplitState)}'.");

    public static LiveSplitInitializationError ScriptAssembly_NotFound
        => new($"The compiled assembly for the executing script could not be found.");

    public static LiveSplitInitializationError ScriptComponent_NotFound
        => new($"The '{nameof(ASLComponent)}' containing the executing script could not be found.");

    public static LiveSplitInitializationError ScriptSettings_Is_Null
        => new($"The '{nameof(ASLScript)}' did not contain a valid instance of '{nameof(ASLSettingsBuilder)}'.");
}
