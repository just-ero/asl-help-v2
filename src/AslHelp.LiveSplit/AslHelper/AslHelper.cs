using System;
using System.Diagnostics.CodeAnalysis;

using AslHelp.Common;

namespace AslHelp.LiveSplit;

[Obsolete("Do not use ASL-specific features.", true)]
public abstract partial class AslHelper
{
    private readonly AutoSplitter? _asl;

    protected AslHelper() { }

    [MemberNotNull(nameof(_asl))]
    protected void EnsureInitialized()
    {
        if (_asl is null)
        {
            ThrowHelper.ThrowInvalidOperationException("ASL is not initialized.");
        }
    }
}
