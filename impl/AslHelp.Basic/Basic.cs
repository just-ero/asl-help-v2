using System;
using System.Diagnostics;

using AslHelp.LiveSplit;
using AslHelp.LiveSplit.Control;
using AslHelp.LiveSplit.Settings;
using AslHelp.Memory.Ipc;
using AslHelp.Memory.Watch.Initialization;

[Obsolete("Do not use ASL-specific features.", true)]
public class Basic : AslPluginBase
{
    public override Process? Game { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override IProcessMemory? Memory => throw new NotImplementedException();

    public override WatcherFactory? Watchers => throw new NotImplementedException();

    public override SettingsBuilder? Settings => throw new NotImplementedException();

    public override TimerController? Timer => throw new NotImplementedException();

    public override TextComponentController? Texts => throw new NotImplementedException();

    public override AslPluginBase Exit()
    {
        throw new NotImplementedException();
    }

    public override AslPluginBase Shutdown()
    {
        throw new NotImplementedException();
    }
}
