using System.Collections.Generic;

using LiveSplit.Model;
using LiveSplit.UI.Components;

namespace AslHelp.LiveSplit.Control;

public sealed class TextComponentController
{
    private readonly Dictionary<string, TextComponentWrapper> _textCache = [];
    private readonly LiveSplitState _state;

    public TextComponentController(LiveSplitState state)
    {
        _state = state;
    }

    public TextComponentWrapper this[string key]
    {
        get
        {
            if (!_textCache.TryGetValue(key, out TextComponentWrapper wrapper))
            {
                _textCache[key] = wrapper = new(_state);
            }

            ILayoutComponent lc = wrapper.LayoutComponent;
            IList<ILayoutComponent> components = _state.Layout.LayoutComponents;

            for (int i = components.Count - 1; i >= 0; i--)
            {
                if (components[i] == lc)
                {
                    return wrapper;
                }
            }

            _state.Layout.LayoutComponents.Add(lc);

            return wrapper;
        }
        set
        {
            if (value is null)
            {
                Remove(key);
                return;
            }

            _textCache[key] = value;
        }
    }

    public void Remove(string id)
    {
        if (!_textCache.TryGetValue(id, out TextComponentWrapper wrapper))
        {
            return;
        }

        _ = _state.Layout.LayoutComponents.Remove(wrapper.LayoutComponent);
        _ = _textCache.Remove(id);
    }

    public void RemoveAll()
    {
        foreach (TextComponentWrapper wrapper in _textCache.Values)
        {
            _ = _state.Layout.LayoutComponents.Remove(wrapper.LayoutComponent);
        }

        _textCache.Clear();
    }
}
