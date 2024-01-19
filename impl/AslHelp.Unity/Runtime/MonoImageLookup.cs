using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using AslHelp.Collections;
using AslHelp.Unity.Runtime.Interop;

namespace AslHelp.Unity.Runtime;

internal sealed class MonoImageLookup : KeyedCollection<string, MonoImage>
{
    private readonly MonoOperator _mono;

    public MonoImageLookup(MonoOperator mono)
    {
        _mono = mono;
    }

    public override IEnumerator<MonoImage> GetEnumerator()
    {
        foreach (var image in _mono.GetImages().UnwrapOr([]))
        {
            if (image is { Value: { } addr } && addr > 0)
            {
                yield return new(addr, _mono);
            }
        }
    }

    protected override bool TryGetKey(MonoImage value, [NotNullWhen(true)] out string? key)
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
        return $"An image with the given name '{key}' was not present.";
    }
}
