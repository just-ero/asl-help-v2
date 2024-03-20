public partial class BasicPlugin
{
    protected override void ExitPlugin()
    {
    }

    protected override void ShutdownPlugin(bool closing)
    {
        _logger.Stop();
        _logger.Clear();

        if (!closing)
        {
            Texts?.RemoveAll();
        }
    }
}
