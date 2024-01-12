using System;
using System.Diagnostics;
using System.Linq;

using AslHelp.Memory;
using AslHelp.Memory.Ipc;

namespace AslHelp.Unity.Memory.Ipc;

internal sealed partial class MonoProcessMemory : ProcessMemory, IMonoProcessMemory
{
    public MonoProcessMemory(Process process)
        : base(process)
    {
        MonoModule = Modules.First(module => module.Name.ToLowerInvariant() is "mono.dll" or "mono-2.0-bdwgc.dll" or "gameassembly.dll");
        UnityPlayerModule = Modules.FirstOrDefault(module => module.Name.ToLowerInvariant() is "unityplayer.dll") ?? MainModule;

        (int, int) version = (UnityPlayerModule.VersionInfo.FileMajorPart, UnityPlayerModule.VersionInfo.FileMinorPart);

        RuntimeVersion = MonoModule.Name.ToLowerInvariant() switch
        {
            "mono.dll" => MonoRuntimeVersion.MonoV1,
            "mono-2.0-bdwgc.dll" => version switch
            {
                (2021, >= 2) or ( > 2021, _) => MonoRuntimeVersion.MonoV2_1,
                _ => MonoRuntimeVersion.MonoV2
            },
            "gameassembly.dll" => version switch
            {
                ( < 2020, _) or (2020, < 2) => MonoRuntimeVersion.Il2CppV24,
                ( < 2021, _) or (2021, < 2) => MonoRuntimeVersion.Il2CppV27,
                _ => MonoRuntimeVersion.Il2CppV29
            },
            _ => throw new NotSupportedException($"Unsupported Mono module: {MonoModule.Name}")
        };
    }

    public MonoRuntimeVersion RuntimeVersion { get; }

    public Module MonoModule { get; }
    public Module UnityPlayerModule { get; }
}
