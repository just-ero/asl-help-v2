using AslHelp.Diagnostics.Logging;
using AslHelp.LiveSplit;
using AslHelp.LiveSplit.Diagnostics;

internal delegate void Log(object? output);
internal delegate void LogFormat(string format, params object?[] args);

public partial class BasicPlugin
{
    protected override void InitializePlugin()
    {
        _logger.Add(new TraceLogger());
    }

    protected override void GenerateCode(string? helperName, AutoSplitter asl)
    {
        asl.Vars["Log"] = (Log)log;
        asl.Vars["LogFormat"] = (LogFormat)logFormat;

        if (helperName is not null)
        {
            asl.Actions.Exit.Prepend($"vars.{helperName}.{nameof(Exit)}();");
            asl.Actions.Shutdown.Prepend($"vars.{helperName}.{nameof(Shutdown)}();");
        }
        else
        {
            AslDebug.Warn($"Helper was not found as part of 'vars'.");
            AslDebug.Warn($"Make sure to call `{nameof(Exit)}` and `{nameof(Shutdown)}` in their respective actions manually.");
        }

        void log(object? output)
        {
            string msg = $"[{GameName}] {output}";
            _logger.Log(msg);
        }

        void logFormat(string format, params object?[] args)
        {
            string msg = $"[{GameName}] {string.Format(format, args)}";
            _logger.Log(msg);
        }
    }
}
