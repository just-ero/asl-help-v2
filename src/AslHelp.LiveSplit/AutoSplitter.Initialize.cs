using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

using AslHelp.Common.Extensions;
using AslHelp.Common.Results;
using AslHelp.LiveSplit.Errors;

using LiveSplit.ASL;
using LiveSplit.Model;
using LiveSplit.UI.Components;
using LiveSplit.View;

namespace AslHelp.LiveSplit;

public sealed partial class AutoSplitter
{
    public static Result<AutoSplitter> Initialize()
    {
        if (!GetTimerData()
            .TryUnwrap(out LiveSplitState? state, out var err))
        {
            return Result<AutoSplitter>.Err(err);
        }

        if (!GetScriptData(state)
            .TryUnwrap(out (ASLComponent, ASLScript, ASLScript.Methods) scriptData, out var error))
        {
            return Result<AutoSplitter>.Err(error);
        }

        (ASLComponent component, ASLScript script, ASLScript.Methods methods) = scriptData;

        if (!ParseActions(component, methods)
            .TryUnwrap(out ScriptActions? actions, out err))
        {
            return Result<AutoSplitter>.Err(err);
        }

        ASLSettings? settings = script.GetFieldValue<ASLSettings>("_settings");
        if (settings?.Builder is not ASLSettingsBuilder builder)
        {
            return LiveSplitInitError.ScriptSettingsNull;
        }

        return new AutoSplitter(state, script, actions, builder);
    }

    private static Result<LiveSplitState> GetTimerData()
    {
        if (Application.OpenForms[nameof(TimerForm)] is not TimerForm timerForm)
        {
            return LiveSplitInitError.TimerFormNotFound;
        }

        if (timerForm.CurrentState is not LiveSplitState state)
        {
            return LiveSplitInitError.LiveSplitStateNull;
        }

        return state;
    }

    private static Result<(ASLComponent, ASLScript, ASLScript.Methods)> GetScriptData(LiveSplitState state)
    {
        Assembly? scriptAssembly = ReflectionExtensions.AssemblyTrace
            .FirstOrDefault(asm => asm.GetType("CompiledScript") is not null);

        if (scriptAssembly is null)
        {
            return LiveSplitInitError.ScriptAssemblyNotFound;
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
            return LiveSplitInitError.ScriptComponentNotFound;
        }

        return (component, script, methods);
    }
}
