using System.Diagnostics;

namespace AslHelp.Diagnostics.Logging;

public sealed class TraceLogger : ILogger
{
    public void Start() { }

    public void Log()
    {
        Trace.WriteLine("");
    }

    public void Log(object? output)
    {
        Trace.WriteLine(output);
    }

    public void Stop() { }
}
