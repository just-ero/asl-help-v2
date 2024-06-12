using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace AslHelp.Collections;

public interface IReadOnlyKeyedCollection<TKey, TValue> : IReadOnlyCollection<TValue>
{
    TValue this[TKey key] { get; }

    IEnumerable<TKey> Keys { get; }
    IEnumerable<TValue> Values { get; }

    bool ContainsKey(TKey key);
    bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value);
}
