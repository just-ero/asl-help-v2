using System;
using System.Runtime.CompilerServices;

using AslHelp.LiveSplit;
using AslHelp.LiveSplit.Diagnostics;

[Obsolete]
public class Basic : AslHelper
{
    public void Test()
    {
        var asl = AutoSplitter.Initialize().Unwrap();
        asl.Vars["Log"] = (string msg, params object[] args) => AslDebug.Info(string.Format(msg, args));
    }
}
