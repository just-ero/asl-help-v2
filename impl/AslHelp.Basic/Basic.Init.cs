using System;

using AslHelp.Diagnostics.Logging;
using AslHelp.LiveSplit;
using AslHelp.LiveSplit.Diagnostics;

public partial class Basic
{
    protected override void InitImpl()
    {
        _logger.Add(new TraceLogger());
    }

    protected override void GenerateCodeImpl(string? helperName, AutoSplitter asl)
    {
        asl.Vars["Log"] = (Action<object>)(output => Logger.Log($"[{GameName}] {output}"));
        AslDebug.Info("Created the `Action<object>` `vars.Log`.");

        if (helperName is not null)
        {
            asl.Actions.Exit.Prepend($"vars.{helperName}.{nameof(OnExit)}();");
            asl.Actions.Shutdown.Prepend($"vars.{helperName}.{nameof(OnShutdown)}();");
        }
        else
        {
            AslDebug.Warn("Helper was not found as part of `vars`.");
            AslDebug.Warn("Make sure to call `OnExit` and `OnShutdown` in their respective actions manually.");
        }
    }
}
