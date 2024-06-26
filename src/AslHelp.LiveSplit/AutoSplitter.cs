using System;
using System.Collections.Generic;
using System.Diagnostics;

using AslHelp.LiveSplit.Extensions;

using LiveSplit.ASL;
using LiveSplit.Model;

namespace AslHelp.LiveSplit;

[Obsolete("Do not use ASL-specific features.", true)]
public sealed partial class AutoSplitter
{
    private readonly ASLScript _script;

    private AutoSplitter(LiveSplitState state, ASLScript script, ScriptActions actions, ASLSettingsBuilder settingsBuilder)
    {
        _script = script;

        State = state;
        Actions = actions;
        Vars = script.Vars;
        SettingsBuilder = settingsBuilder;
    }

    public LiveSplitState State { get; }

    public ScriptActions Actions { get; }
    public IDictionary<string, object?> Vars { get; }
    public ASLSettingsBuilder SettingsBuilder { get; }

    public Process? Game
    {
        get => _script.GetGame();
        set => _script.SetGame(value);
    }
}
