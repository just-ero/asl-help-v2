using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using AslHelp.Collections;
using AslHelp.Common.Results;
using AslHelp.Unity.Runtime.Interop;

namespace AslHelp.Unity.Runtime;

internal sealed class MonoClassLookup : KeyedCollection<string, MonoClass>
{
    private readonly nuint _image;
    private readonly MonoOperator _mono;

    public MonoClassLookup(nuint image, MonoOperator mono)
    {
        _image = image;
        _mono = mono;
    }

    public override IEnumerator<MonoClass> GetEnumerator()
    {
        foreach (Result<nuint> klass in _mono.GetClasses(_image).UnwrapOr([]))
        {
            if (klass is { Value: { } addr } && addr > 0)
            {
                yield return new(addr, _mono);
            }
        }
    }

    protected override bool TryGetKey(MonoClass value, [NotNullWhen(true)] out string? key)
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
        // if (_mono.TryGetImageName(_image, out string? imageName))
        // {
        //     return $"A class with the given name '{key}' was not present in image '{imageName}'.";
        // }
        // else
        // {
        return $"A class with the given name '{key}' was not present in the image.";
        // }
    }
}
