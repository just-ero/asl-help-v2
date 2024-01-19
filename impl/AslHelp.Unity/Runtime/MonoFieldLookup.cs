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
        foreach (Common.Results.Result<nuint> field in _mono.GetFields(_klass).UnwrapOr([]))
        {
            if (field is { Value: { } addr } && addr > 0)
            {
                yield return new(addr, _mono);
            }
        }
    }

    protected override bool TryGetKey(MonoField value, [NotNullWhen(true)] out string? key)
    {
        if (value.Name is { Value: { } name })
        {
            key = name;
            return true;
        }
        else
        {
            key = null;
            return false;
        }
    }

    protected override string KeyNotFoundMessage(string key)
    {
        return _mono.GetClassName(_klass)
            .Map(name => $"A field with the given name '{key}' was not present in class '{name}'.")
            .Or($"A field with the given name '{key}' was not present in the class.")
            .Unwrap();
    }
}
