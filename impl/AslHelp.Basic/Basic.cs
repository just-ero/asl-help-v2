using System;

using AslHelp.LiveSplit;

[Obsolete("Do not use ASL-specific features.", true)]
public partial class Basic : AslHelpEntryPoint
{
    protected override void OnExitImpl()
    {
        for (int i = 0; i < _fileWatchers.Count; i++)
        {
            _fileWatchers[i].Dispose();
        }

        _fileWatchers.Clear();
    }

    protected override void OnShutdownImpl(bool closing)
    {
        _logger.Stop();
        _logger.Clear();

        for (int i = 0; i < _fileWatchers.Count; i++)
        {
            _fileWatchers[i].Dispose();
        }

        _fileWatchers.Clear();

        if (!closing)
        {
            Texts?.RemoveAll();
        }
    }
}
