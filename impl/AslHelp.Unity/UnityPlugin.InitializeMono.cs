using System;

using AslHelp.Common;
using AslHelp.Unity.Runtime.Interop;

public partial class UnityPlugin
{
    public IMonoInterop InitializeMono()
    {
        if (Memory is null)
        {
            const string Msg = "Memory is not initialized.";
            ThrowHelper.ThrowInvalidOperationException(Msg);
        }

        foreach (var m in Memory.Modules)
        {
            switch (m.Name)
            {
                case "mono.dll":
                    return MonoInteropV1.Initialize(m).Unwrap();
                case "mono-2.0-bdwgc.dll":
                    return MonoInteropV2.Initialize(m).Unwrap();
                case "GameAssembly.dll":
                    return Il2CppInterop.Initialize(m).Unwrap();
            }
        }

        const string Msg = "Mono runtime not found.";
        ThrowHelper.ThrowInvalidOperationException(Msg);
    }

    public IMonoInterop InitializeMono(string monoModule, string runtimeVersion)
    {
        if (!Enum.TryParse(runtimeVersion, out RuntimeVersion version))
        {
            string msg = $"{runtimeVersion} is not a valid runtime version.";
            ThrowHelper.ThrowArgumentException(nameof(runtimeVersion), msg);
        }


    }
}
