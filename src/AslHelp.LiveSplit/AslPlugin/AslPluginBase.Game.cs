using System.Diagnostics;

using AslHelp.Memory.Ipc;

namespace AslHelp.LiveSplit;

public partial class AslPluginBase
{
    private Process? _game;

    public Process? Game
    {
        get
        {
            if (_game is null)
            {
                EnsureInitialized();

                _game = _asl.Game;
            }

            return _game;
        }
        set
        {
            EnsureInitialized();

            _game = value;
            _asl.Game = value;

            if (value is null)
            {
                DisposeGameAndMemory();
            }
        }
    }

    public abstract IProcessMemory? Memory { get; }

    protected abstract void DisposeGameAndMemory();
}
