using System;

using AslHelp.Common;
using AslHelp.Memory;
using AslHelp.Unity.Memory.Ipc;
using AslHelp.Unity.Runtime.Interop;
using AslHelp.Unity.Runtime.Interop.Initialization;

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

        if (Memory.Modules.TryGetValue("mono.dll", out Module? monoModule))
        {
            _mono = MonoOperator.Initialize<MonoInitializerV1>(Memory, monoModule).Unwrap();
        }
        else if (Memory.Modules.TryGetValue("mono-2.0-bdwgc.dll", out monoModule))
        {
            _mono = (UnityVersion.Major, UnityVersion.Minor) switch
            {
                (2021, >= 2) or ( > 2021, _) => MonoOperator.Initialize<MonoInitializerV2_1>(Memory, monoModule).Unwrap(),
                _ => MonoOperator.Initialize<MonoInitializerV2>(Memory, monoModule).Unwrap()
            };
        }
        else if (Memory.Modules.TryGetValue("GameAssembly.dll", out monoModule))
        {
            _mono = Il2CppMetadata.Version switch
            {
                24 => MonoOperator.Initialize<Il2CppInitializerV24>(Memory, monoModule).Unwrap(),
                _ => throw new NotSupportedException()
            };
        }
        else
        {
            const string Msg = "Could not find a supported Mono module.";
            ThrowHelper.ThrowInvalidOperationException(Msg);
        }

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

        Module module = Memory.Modules[monoModule];

        _mono = version switch
        {
            MonoRuntimeVersion.MonoV1 => MonoOperator.Initialize<MonoInitializerV1>(Memory, module).Unwrap(),
            MonoRuntimeVersion.MonoV2 => MonoOperator.Initialize<MonoInitializerV2>(Memory, module).Unwrap(),
            MonoRuntimeVersion.MonoV2_1 => MonoOperator.Initialize<MonoInitializerV2_1>(Memory, module).Unwrap(),
            MonoRuntimeVersion.Il2CppV24 => MonoOperator.Initialize<Il2CppInitializerV24>(Memory, module).Unwrap(),
            _ => throw new NotSupportedException()
        };

        return _mono;
    }
}
