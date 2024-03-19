using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

using AslHelp.Common;
using AslHelp.LiveSplit.Abstractions;
using AslHelp.LiveSplit.Control;
using AslHelp.LiveSplit.Settings;
using AslHelp.Memory.Ipc;
using AslHelp.Memory.Watch.Initialization;

namespace AslHelp.LiveSplit;

[Obsolete("Do not use ASL-specific features.", true)]
public abstract partial class AslPluginBase : IAslPlugin<AslPluginBase>
{
    private readonly AutoSplitter? _asl;
    private readonly string? _gameName;

    protected AslPluginBase() { }

    public string GameName => _gameName ?? Game?.ProcessName ?? "Auto Splitter";
    public abstract Process? Game { get; set; }

    public abstract IProcessMemory? Memory { get; }
    public abstract WatcherFactory? Watchers { get; }

    public abstract SettingsBuilder? Settings { get; }
    public abstract TimerController? Timer { get; }
    public abstract TextComponentController? Texts { get; }

    [MemberNotNull(nameof(_asl))]
    protected void EnsureInitialized()
    {
        if (_asl is null)
        {
            ThrowHelper.ThrowInvalidOperationException("ASL is not initialized.");
        }
    }
}
