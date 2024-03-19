namespace AslHelp.LiveSplit;

public partial class AslPluginBase
{
    protected bool IsInitialized => _asl is not null;

    public AslPluginBase Initialize(
        string? gameName = null,
        bool generateCode = false)
    {

    }
}
