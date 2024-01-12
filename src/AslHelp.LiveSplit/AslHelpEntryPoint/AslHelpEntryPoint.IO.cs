using AslHelp.Diagnostics.Logging;
using AslHelp.LiveSplit.Control;
using AslHelp.LiveSplit.Settings;

namespace AslHelp.LiveSplit;

public partial class AslHelpEntryPoint
{
    public abstract ILogger Logger { get; }

    public SettingsBuilder? Settings { get; private set; }
    public TimerController? Timer { get; private set; }
    public TextComponentController? Texts { get; private set; }
}
