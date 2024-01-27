using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

using AslHelp.Common.Extensions;
using AslHelp.Common.Results;

using LiveSplit.ASL;
using LiveSplit.Model;
using LiveSplit.UI.Components;
using LiveSplit.View;

namespace AslHelp.LiveSplit;

public sealed partial class AutoSplitter
{
    public static Result<AutoSplitter> Initialize()
    {
        return GetTimerData()
            .AndThen(state =>
            {
                return GetScriptData(state)
                    .Map(scriptData => (State: state, Component: scriptData.Component, Script: scriptData.Script, Methods: scriptData.Methods));
            })
            .AndThen(res =>
            {
                ASLSettings? settings = res.Script.GetFieldValue<ASLSettings>("_settings");
                if (settings?.Builder is not ASLSettingsBuilder builder)
                {
                    return LiveSplitInitializationError.ScriptSettings_Is_Null;
                }

                return ParseActions(res.Component, res.Methods)
                    .Map<AutoSplitter>(actions => new(res.State, res.Script, actions, builder));
            });
    }

    private static Result<LiveSplitState> GetTimerData()
    {
        if (Application.OpenForms[nameof(TimerForm)] is not TimerForm timerForm)
        {
            return LiveSplitInitializationError.TimerForm_NotFound;
        }

        if (timerForm.CurrentState is not LiveSplitState state)
        {
            return LiveSplitInitializationError.LiveSplitState_Is_Null;
        }

        return state;
    }

    private static Result<(ASLComponent Component, ASLScript Script, ASLScript.Methods Methods)> GetScriptData(LiveSplitState state)
    {
        Assembly? scriptAssembly = ReflectionExtensions.AssemblyTrace
            .FirstOrDefault(asm => asm.GetType("CompiledScript") is not null);

        if (scriptAssembly is null)
        {
            return LiveSplitInitializationError.ScriptAssembly_NotFound;
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
            return LiveSplitInitializationError.ScriptComponent_NotFound;
        }

        return (component, script, methods);
    }
}
