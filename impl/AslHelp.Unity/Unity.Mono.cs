using System;

using AslHelp.Common;
using AslHelp.Unity.Memory.Ipc;
using AslHelp.Unity.Runtime.Interop;

public partial class Unity
{
    private MonoOperator? _mono;

    public MonoOperator InitializeMono()
    {
        if (_mono is not null)
        {
            return _mono;
        }

        EnsureMemoryInitialized();

        MonoRuntimeVersion version = MonoRuntimeVersion.Unknown;

        if (Memory.Modules.TryGetValue("mono.dll", out var monoModule))
        {
            version = MonoRuntimeVersion.MonoV1;
        }
        else if (Memory.Modules.TryGetValue("mono-2.0-bdwgc.dll", out monoModule))
        {
            version = (UnityVersion.Major, UnityVersion.Minor) switch
            {
                (2021, >= 2) or ( > 2021, _) => MonoRuntimeVersion.MonoV2_1,
                _ => MonoRuntimeVersion.MonoV2
            };
        }
        else if (Memory.Modules.TryGetValue("GameAssembly.dll", out monoModule))
        {
            if (Il2CppMetadata.Version is not 24)
            {
                string msg = $"Unsupported Il2Cpp version ({Il2CppMetadata.Version}).";
                ThrowHelper.ThrowNotSupportedException(msg);
            }

#pragma warning disable CS8509 // The switch expression does not handle all possible values of its input type (it is not exhaustive).
            version = Il2CppMetadata.Version switch
#pragma warning restore CS8509
            {
                24 => MonoRuntimeVersion.Il2CppV24
            };
        }
        else
        {
            const string Msg = "Could not find a supported Mono module.";
            ThrowHelper.ThrowInvalidOperationException(Msg);
        }

        _mono = MonoOperator.Initialize(Memory, monoModule, version).Unwrap();

        return _mono;
    }

    public MonoOperator InitializeMono(string monoModule, string runtimeVersion)
    {
        if (_mono is not null)
        {
            return _mono;
        }

        if (!Enum.TryParse(runtimeVersion, out MonoRuntimeVersion version)
            || version == MonoRuntimeVersion.Unknown)
        {
            string msg = $"Provided an invalid runtime version ('{runtimeVersion}').";
            ThrowHelper.ThrowArgumentException(nameof(runtimeVersion), msg);
        }

        EnsureMemoryInitialized();

        _mono = MonoOperator.Initialize(Memory, Memory.Modules[monoModule], version).Unwrap();

        return _mono;
    }
}
