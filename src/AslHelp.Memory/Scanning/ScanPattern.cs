using System.Buffers.Binary;

using AslHelp.Common;
using AslHelp.Common.Extensions;

namespace AslHelp.Memory.Scanning;

public readonly struct ScanPattern
{
    private const byte ByteMask = 0b1111_1111;
    private const byte NibbleMask = 0b1111;

    private const int BitsPerByte = 8;
    private const int BitsPerNibble = BitsPerByte / 2;

    private const int BytesPerUlong = sizeof(ulong);
    private const int NibblesPerUlong = sizeof(ulong) * 2;

    private const int MaxByte = BytesPerUlong - 1;
    private const int MaxNibble = NibblesPerUlong - 1;

    public ScanPattern(params string[] pattern)
        : this(0, pattern) { }

    public ScanPattern(int scanOffset, params string[] pattern)
    {
        ThrowHelper.ThrowIfNullOrEmpty(pattern);

        string signature = pattern.Concat().RemoveWhiteSpace();
        if (signature.Length % 2 != 0)
        {
            const string Msg = "Signature was not in the expected format. All bytes must be fully specified.";
            ThrowHelper.ThrowArgumentException(nameof(signature), Msg);
        }

        int nibbles = signature.Length;
        int aligned = (nibbles + MaxNibble) & ~MaxNibble;
        int length = aligned / NibblesPerUlong;

        Values = new ulong[length];
        Masks = new ulong[length];

        ulong fullValue = 0, fullMask = 0;

        for (int i = 0, offset = 0; i < aligned; i++)
        {
            fullValue <<= BitsPerNibble;
            fullMask <<= BitsPerNibble;

            if (i < signature.Length)
            {
                byte value = signature[i].ToHexValue();

                if (value != CharExtensions.InvalidHexValue)
                {
                    fullValue |= value;
                    fullMask |= NibbleMask;
                }
            }

            if (i % NibblesPerUlong == MaxNibble)
            {
                Values[offset] = BinaryPrimitives.ReverseEndianness(fullValue);
                Masks[offset] = BinaryPrimitives.ReverseEndianness(fullMask);

                offset++;
            }
        }

        Offset = scanOffset;
    }

    public ScanPattern(params byte[] pattern)
        : this(0, pattern) { }

    public ScanPattern(int scanOffset, params byte[] pattern)
    {
        ThrowHelper.ThrowIfNullOrEmpty(pattern);

        int bytes = (pattern.Length + MaxByte) & ~MaxByte;
        int length = bytes / BytesPerUlong;

        Values = new ulong[length];
        Masks = new ulong[length];

        ulong fullValue = 0, fullMask = 0;

        for (int i = 0, offset = 0; i < bytes; i++)
        {
            fullValue <<= BitsPerByte;
            fullMask <<= BitsPerByte;

            if (i < pattern.Length)
            {
                fullValue |= pattern[i];
                fullMask |= ByteMask;
            }

            if (i % BytesPerUlong == MaxByte)
            {
                Values[offset] = BinaryPrimitives.ReverseEndianness(fullValue);
                Masks[offset] = BinaryPrimitives.ReverseEndianness(fullMask);

                offset++;
            }
        }

        Offset = scanOffset;
    }

    public int Offset { get; }

    public ulong[] Values { get; }
    public ulong[] Masks { get; }
}
