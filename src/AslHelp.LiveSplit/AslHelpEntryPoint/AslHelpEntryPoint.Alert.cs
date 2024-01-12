using System.Windows.Forms;

using LiveSplit.Model;

namespace AslHelp.LiveSplit;

public partial class AslHelpEntryPoint
{
    public AslHelpEntryPoint AlertRealTime(string? message = null)
    {
        EnsureInitialized();

        if (_asl.State.CurrentTimingMethod == TimingMethod.RealTime)
        {
            return this;
        }

        DialogResult mbox = MessageBox.Show(_asl.State.Form,
            message ??
            $"{_gameName ?? "This game"} uses real time as its timing method.\nWould you like to switch to it?",
            $"LiveSplit | {GameName}",
            MessageBoxButtons.YesNo);

        if (mbox == DialogResult.Yes)
        {
            _asl.State.CurrentTimingMethod = TimingMethod.RealTime;
        }

        return this;
    }

    public AslHelpEntryPoint AlertGameTime(string? message = null)
    {
        EnsureInitialized();

        if (_asl.State.CurrentTimingMethod == TimingMethod.GameTime)
        {
            return this;
        }

        DialogResult mbox = MessageBox.Show(_asl.State.Form,
            message ??
            $"{_gameName ?? "This game"} uses in-game time.\nWould you like to switch to it?",
            $"LiveSplit | {GameName}",
            MessageBoxButtons.YesNo);

        if (mbox == DialogResult.Yes)
        {
            _asl.State.CurrentTimingMethod = TimingMethod.GameTime;
        }

        return this;
    }

    public AslHelpEntryPoint AlertLoadless(string? message = null)
    {
        EnsureInitialized();

        if (_asl.State.CurrentTimingMethod == TimingMethod.GameTime)
        {
            return this;
        }

        DialogResult mbox = MessageBox.Show(_asl.State.Form,
            message ??
            $"Removing loads from {_gameName ?? "this game"} requires comparing against Game Time.\nWould you like to switch to it?",
            $"LiveSplit | {GameName}",
            MessageBoxButtons.YesNo);

        if (mbox == DialogResult.Yes)
        {
            _asl.State.CurrentTimingMethod = TimingMethod.GameTime;
        }

        return this;
    }
}
