public partial class BasicPlugin
{
    protected override void ExitPlugin()
    {
    }

    protected override void ShutdownPlugin(bool closing)
    {
        _logger.Stop();
        _logger.Clear();

        _readers.ForEach(reader => reader.Dispose());
        _readers.Clear();

        if (!closing)
        {
            Texts?.RemoveAll();
        }
    }
}
