using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using AslHelp.Collections;
using AslHelp.Unity.Runtime.Interop;

namespace AslHelp.Unity.Runtime;

internal sealed class MonoFieldLookup : KeyedCollection<string, MonoField>
{
    private readonly nuint _klass;
    private readonly MonoOperator _mono;

    public MonoFieldLookup(nuint klass, MonoOperator mono)
    {
        _klass = klass;
        _mono = mono;
    }

    public override IEnumerator<MonoField> GetEnumerator()
    {
        foreach (nuint field in _mono.TryGetFields(_klass))
        {
            yield return new(field, _mono);
        }
    }

    protected override bool TryGetKey(MonoField value, [NotNullWhen(true)] out string? key)
    {
        if (value.Name is string name)
        {
            key = name;
            return true;
        }
        else
        {
            key = default;
            return false;
        }
    }

    protected override string KeyNotFoundMessage(string key)
    {
        if (_mono.TryGetClassName(_klass, out string? className))
        {
            return $"A field with the given name '{key}' was not present in class '{className}'.";
        }
        else
        {
            return $"A field with the given name '{key}' was not present in the class.";

        }
    }
}
