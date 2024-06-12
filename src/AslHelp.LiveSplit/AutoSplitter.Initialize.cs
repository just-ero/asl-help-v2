using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

using AslHelp.Common;
using AslHelp.Common.Extensions;

using LiveSplit.ASL;
using LiveSplit.Model;
using LiveSplit.UI.Components;
using LiveSplit.View;

namespace AslHelp.LiveSplit;

public sealed partial class AutoSplitter
{
    public static AutoSplitter Initialize()
    {
        LiveSplitState state = GetTimerData();
        (ASLComponent component, ASLScript script, ASLScript.Methods methods) = GetScriptData(state);
        ScriptActions actions = ParseActions(component, methods);

        ASLSettings? settings = script.GetFieldValue<ASLSettings>("_settings");
        if (settings?.Builder is not ASLSettingsBuilder builder)
        {
            const string Msg = $"The '{nameof(ASLScript)}' did not contain a valid instance of '{nameof(ASLSettingsBuilder)}'.";
            ThrowHelper.ThrowException(Msg);

            return default;
        }

        return new AutoSplitter(state, script, actions, builder);
    }

    private static LiveSplitState GetTimerData()
    {
        if (Application.OpenForms[nameof(TimerForm)] is not TimerForm timerForm)
        {
            const string Msg = $"An instance of type '{nameof(TimerForm)}' could not be found within the open forms of the application.";
            ThrowHelper.ThrowException(Msg);

            return default;
        }

        return timerForm.CurrentState;
    }

    private static (ASLComponent Component, ASLScript Script, ASLScript.Methods Methods) GetScriptData(LiveSplitState state)
    {
        Assembly? scriptAssembly = ReflectionExtensions.AssemblyTrace
            .FirstOrDefault(asm => asm.GetType("CompiledScript") is not null);

        if (scriptAssembly is null)
        {
            const string Msg = $"The compiled assembly for the executing script could not be found.";
            ThrowHelper.ThrowException(Msg);
        }

        IEnumerable<IComponent?> components = state.Layout.Components.Prepend(state.Run.AutoSplitter?.Component);

        ASLComponent? component = default;
        ASLScript? script = default;
        ASLScript.Methods? methods = default;

        foreach (ASLComponent c in components.OfType<ASLComponent>())
        {
            script = c.Script;
            methods = script?.GetFieldValue<ASLScript.Methods>("_methods");

            if (methods?.startup is not { IsEmpty: false } startup)
            {
                continue;
            }

            object? cc = startup.GetFieldValue<object>("_compiled_code");
            if (cc?.GetType().Assembly == scriptAssembly)
            {
                component = c;
                break;
            }
        }

        if (component is null || script is null || methods is null)
        {
            const string Msg = $"The '{nameof(ASLComponent)}' containing the executing script could not be found.";
            ThrowHelper.ThrowException(Msg);
        }

        return (component, script, methods);
    }
}
