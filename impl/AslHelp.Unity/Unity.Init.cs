using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

using AslHelp.Common;

public partial class Unity
{
    [MemberNotNull(nameof(Memory))]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void EnsureMemoryInitialized()
    {
        if (Memory is null)
        {
            const string Msg = "Attempted to access uninitialized memory.";
            ThrowHelper.ThrowInvalidOperationException(Msg);
        }
    }
}
