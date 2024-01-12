using System.Collections.Generic;

using AslHelp.Diagnostics.Logging;
using AslHelp.IO;

public partial class Basic
{
    private readonly MultiLogger _logger = [];
    private readonly List<FileWatcher> _fileWatchers = [];

    public override ILogger Logger => _logger;

    public Basic LogToFile(string fileName, int maxLines, int linesToErase)
    {
        FileLogger logger = new(fileName, maxLines, linesToErase);
        logger.Start();

        _logger.Add(logger);

        return this;
    }

    public FileWatcher CreateFileWatcher(string fileName)
    {
        FileWatcher watcher = new(fileName);
        _fileWatchers.Add(watcher);

        return watcher;
    }
}
