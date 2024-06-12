using System.Collections.Generic;

using AslHelp.Diagnostics.Logging;
using AslHelp.IO;
using AslHelp.LiveSplit;

public partial class BasicPlugin
{
    private readonly MultiLogger _logger = [];
    private readonly List<FileReader> _readers = [];

    public override AslPluginBase LogToFile(string fileName, int maxLines = 4096, int linesToErase = 512)
    {
        FileLogger logger = new(fileName, maxLines, linesToErase);
        _logger.Add(logger);

        return this;
    }

    public override FileReader CreateFileReader(string fileName)
    {
        FileReader reader = new(fileName);
        _readers.Add(reader);

        return reader;
    }
}
