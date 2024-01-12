using System;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;

using LiveSplit.ASL;

namespace AslHelp.LiveSplit.Extensions;

internal static class ASLScriptExtensions
{
    private static object? _getScriptGame;
    private static object? _setScriptGame;

    public static Process? GetGame(this ASLScript script)
    {
        if (_getScriptGame is not Func<ASLScript, Process?> getScriptGame)
        {
            DynamicMethod dm = new(nameof(getScriptGame), typeof(Process), [typeof(ASLScript)], true);

            FieldInfo fiGame = typeof(ASLScript).GetField("_game", BindingFlags.Instance | BindingFlags.NonPublic);

            ILGenerator il = dm.GetILGenerator();
            il.Emit(OpCodes.Ldarg_0);
            il.Emit(OpCodes.Ldfld, fiGame);
            il.Emit(OpCodes.Ret);

            getScriptGame = (Func<ASLScript, Process?>)dm.CreateDelegate(typeof(Func<ASLScript, Process?>));
            _getScriptGame = getScriptGame;
        }

        return getScriptGame(script);
    }

    public static void SetGame(this ASLScript script, Process? game)
    {
        if (_setScriptGame is not Action<ASLScript, Process?> setScriptGame)
        {
            DynamicMethod dm = new(nameof(setScriptGame), null, [typeof(ASLScript), typeof(Process)], true);

            FieldInfo fiGame = typeof(ASLScript).GetField("_game", BindingFlags.Instance | BindingFlags.NonPublic);

            ILGenerator il = dm.GetILGenerator();
            il.Emit(OpCodes.Ldarg_0);
            il.Emit(OpCodes.Ldarg_1);
            il.Emit(OpCodes.Stfld, fiGame);
            il.Emit(OpCodes.Ret);

            setScriptGame = (Action<ASLScript, Process?>)dm.CreateDelegate(typeof(Action<ASLScript, Process?>));
            _setScriptGame = setScriptGame;
        }

        setScriptGame(script, game);
    }
}
