using System.Diagnostics;

public partial class Basic
{
    private Process? _game;
    public override Process? Game
    {
        get
        {
            EnsureInitialized();

            return _game ??= _asl.Game;
        }
        set
        {
            EnsureInitialized();

            _game = value;
            _asl.Game = value;

            if (value is null)
            {
                DisposeProcessInstanceData();
            }
        }
    }
}
