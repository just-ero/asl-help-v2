using System;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Text;

using AslHelp.Common;
using AslHelp.LiveSplit.Diagnostics;

using LiveSplit.ASL;

namespace AslHelp.LiveSplit;

public partial class AslPluginBase
{
    public bool Initialized { get; private set; }

    public AslPluginBase Initialize(string? gameName = null, bool generateCode = false)
    {
        if (Initialized)
        {
            const string Msg = "asl-help is already initialized.";
            ThrowHelper.ThrowInvalidOperationException(Msg);
        }

        AslDebug.Info("Initializing asl-help...");
        using (AslDebug.Indent())
        {
            AppDomain.CurrentDomain.AssemblyResolve += AssemblyResolve;
            AppDomain.CurrentDomain.FirstChanceException += FirstChanceHandler;

            AslDebug.Info("Initializing timer and script data...");
            using (AslDebug.Indent())
            {
                _asl = AutoSplitter.Initialize().Unwrap();

                AslDebug.Info("Success.");
            }
        }

        _gameName = gameName;
        // _asl = new AutoSplitter(GameName, generateCode);
        Initialized = true;

        return this;
    }

    private static Assembly? AssemblyResolve(object? sender, ResolveEventArgs e)
    {
        string name = e.Name;

        int i = name.IndexOf(',');
        if (i == -1)
        {
            return default;
        }

        try
        {
            string file = $"Components/{name[..i]}.dll";
            return Assembly.LoadFrom(file);
        }
        catch
        {
            // If the file is not found or could not be loaded, ignore.
            return default;
        }
    }

    private const string CallSite_Target
        = "   at CallSite.Target(Closure , CallSite , Object , ";

    private const string UpdateDelegates_UpdateAndExecuteVoid2
        = "   at System.Dynamic.UpdateDelegates.UpdateAndExecuteVoid2[T0,T1](CallSite site, T0 arg0, T1 arg1)";

    private const string UpdateDelegates_UpdateAndExecute2
        = "   at System.Dynamic.UpdateDelegates.UpdateAndExecute2[T0,T1,TRet](CallSite site, T0 arg0, T1 arg1)";

    private const string CompiledScript_Execute
        = "   at CompiledScript.Execute(LiveSplitState timer, Object old, Object current, Object vars, Process game, Object settings)";

    private static readonly string[] _newLines = ["\r\n", "\n"];
    private static readonly FieldInfo _messageField = typeof(Exception).GetField("_message", BindingFlags.Instance | BindingFlags.NonPublic)!;

    private static void FirstChanceHandler(object? sender, FirstChanceExceptionEventArgs e)
    {
        if (e.Exception is not ASLRuntimeException ex)
        {
            return;
        }

        if (ex.Message is not string message)
        {
            return;
        }

        if (ex.InnerException?.StackTrace is not string stackTrace)
        {
            return;
        }

        string[] messageLines = message.Split(_newLines, StringSplitOptions.None);
        string[] stackTraceLines = stackTrace.Split(_newLines, StringSplitOptions.None);

        StringBuilder sb = new(message.Length + stackTrace.Length);

        for (int i = 0; i < messageLines.Length - 2; i++)
        {
            sb.AppendLine(messageLines[i]);
        }

        foreach (string line in stackTraceLines)
        {
            bool lastLine = line.Length switch
            {
                >= 122 => line[28] == '(' && line.StartsWith(CompiledScript_Execute, StringComparison.Ordinal),
                >= 99 => line[66] == '(' && line.StartsWith(UpdateDelegates_UpdateAndExecute2, StringComparison.Ordinal),
                >= 98 => line[65] == '(' && line.StartsWith(UpdateDelegates_UpdateAndExecuteVoid2, StringComparison.Ordinal),
                >= 52 => line[21] == '(' && line.StartsWith(CallSite_Target, StringComparison.Ordinal),
                _ => false
            };

            if (lastLine)
            {
                break;
            }

            sb.AppendLine(line);
        }

        sb.AppendLine();
        sb.Append(messageLines[^1]);

        _messageField.SetValue(ex, sb.ToString());
    }
}

public class Class1
{
    protected void M1(string foo = "") { }
    public void M1() { }
}

public class Class2 : Class1
{
    public void M2()
    {
        M1();
    }
}
