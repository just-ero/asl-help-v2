using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace AslHelp.LiveSplit;

public partial class AslHelpEntryPoint
{
    private string? _gameName = null;
    public string GameName => (_gameName ??= Game?.ProcessName) ?? "Auto Splitter";

    [NotNullIfNotNull(nameof(Memory))]
    public abstract Process? Game { get; set; }
}
