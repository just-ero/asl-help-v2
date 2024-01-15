using System;
using System.Linq;

using AslHelp.LiveSplit.Diagnostics;

namespace AslHelp.LiveSplit;

[Obsolete("Do not use ASL-specific features.", true)]
public abstract partial class AslHelpEntryPoint
{
    public void OnExit()
    {
        EnsureInitialized();

        AslDebug.Info("Disposing...");

        DisposeGameData();

        using (AslDebug.Indent())
        {
            OnExitImpl();
            FreeMemory();
        }
    }

    protected abstract void OnExitImpl();

    public void OnShutdown()
    {
        EnsureInitialized();

        AslDebug.Info("Disposing...");

        AppDomain.CurrentDomain.AssemblyResolve -= AssemblyResolve;
        AppDomain.CurrentDomain.FirstChanceException -= FirstChanceHandler;

        DisposeGameData();

        bool closing = AslDebug.StackTraceMethodNames.Any(name =>
            name is "TimerForm.TimerForm_FormClosing"
            or "TimerForm.OpenLayoutFromFile"
            or "TimerForm.LoadDefaultLayout");

        using (AslDebug.Indent())
        {
            OnShutdownImpl(closing);
            FreeMemory();
        }

        Initialized = false;
    }

    protected abstract void OnShutdownImpl(bool closing);

    private static void FreeMemory()
    {
        long memoryBefore = GC.GetTotalMemory(false);
        GC.Collect();
        long memoryAfter = GC.GetTotalMemory(true);

        AslDebug.Info($"Freed {(memoryBefore - memoryAfter) / 1000:0,000} KB of memory.");
    }
}
