using System;

using AslHelp.Diagnostics.Logging;
using AslHelp.IO;
using AslHelp.LiveSplit;
using AslHelp.LiveSplit.Diagnostics;
using AslHelp.Memory.Ipc;
using AslHelp.Memory.Watch.Initialization;

public partial class BasicPlugin
{
    private readonly MultiLogger _logger = [];

    public override AslPluginBase LogToFile(string fileName, int maxLines = 4096, int linesToErase = 512)
    {
        throw new NotImplementedException();
    }

    public override FileReader CreateFileReader(string fileName)
    {
        throw new NotImplementedException();
    }
}
