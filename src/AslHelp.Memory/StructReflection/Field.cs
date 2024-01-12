using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace AslHelp.Memory.StructReflection;

public sealed class Field
{
    private readonly int _trailingZeroCount;

    internal Field(string type, string name, uint offset, uint size, uint alignment, (uint, uint)? bitField)
    {
        Type = type;
        Name = name;
        Offset = offset;
        Size = size;
        Alignment = alignment;

        if (bitField is (uint bfSize, uint bfOffset))
        {
            BitMask = ((1u << (int)bfSize) - 1) << (int)bfOffset;
            _trailingZeroCount = TrailingZeroCount(BitMask);
        }
    }

    internal string Name { get; }
    internal string Type { get; }
    internal uint Offset { get; }
    internal uint Size { get; }
    internal uint Alignment { get; }

    internal uint BitMask { get; }

    public static byte operator +(byte value, Field field)
    {
        return (byte)(value + field.Offset);
    }

    public static sbyte operator +(sbyte value, Field field)
    {
        return (sbyte)(value + field.Offset);
    }

    public static ushort operator +(ushort value, Field field)
    {
        return (ushort)(value + field.Offset);
    }

    public static short operator +(short value, Field field)
    {
        return (short)(value + field.Offset);
    }

    public static uint operator +(uint value, Field field)
    {
        return value + field.Offset;
    }

    public static int operator +(int value, Field field)
    {
        return (int)(value + field.Offset);
    }

    public static ulong operator +(ulong value, Field field)
    {
        return value + field.Offset;
    }

    public static long operator +(long value, Field field)
    {
        return value + field.Offset;
    }

    public static nuint operator +(nuint value, Field field)
    {
        return value + field.Offset;
    }

    public static nint operator +(nint value, Field field)
    {
        return (nint)(value + field.Offset);
    }

    public static byte operator -(byte value, Field field)
    {
        return (byte)(value - field.Offset);
    }

    public static sbyte operator -(sbyte value, Field field)
    {
        return (sbyte)(value - field.Offset);
    }

    public static ushort operator -(ushort value, Field field)
    {
        return (ushort)(value - field.Offset);
    }

    public static short operator -(short value, Field field)
    {
        return (short)(value - field.Offset);
    }

    public static uint operator -(uint value, Field field)
    {
        return value - field.Offset;
    }

    public static int operator -(int value, Field field)
    {
        return (int)(value - field.Offset);
    }

    public static ulong operator -(ulong value, Field field)
    {
        return value - field.Offset;
    }

    public static long operator -(long value, Field field)
    {
        return value - field.Offset;
    }

    public static nuint operator -(nuint value, Field field)
    {
        return value - field.Offset;
    }

    public static nint operator -(nint value, Field field)
    {
        return (nint)(value - field.Offset);
    }

    public static byte operator &(byte value, Field field)
    {
        return (byte)((value & field.BitMask) >> field._trailingZeroCount);
    }

    public static sbyte operator &(sbyte value, Field field)
    {
        return (sbyte)((value & field.BitMask) >> field._trailingZeroCount);
    }

    public static ushort operator &(ushort value, Field field)
    {
        return (ushort)((value & field.BitMask) >> field._trailingZeroCount);
    }

    public static short operator &(short value, Field field)
    {
        return (short)((value & field.BitMask) >> field._trailingZeroCount);
    }

    public static uint operator &(uint value, Field field)
    {
        return (value & field.BitMask) >> field._trailingZeroCount;
    }

    public static int operator &(int value, Field field)
    {
        return (int)((value & field.BitMask) >> field._trailingZeroCount);
    }

    public static ulong operator &(ulong value, Field field)
    {
        return (value & field.BitMask) >> field._trailingZeroCount;
    }

    public static long operator &(long value, Field field)
    {
        return (value & field.BitMask) >> field._trailingZeroCount;
    }

    // https://learn.microsoft.com/en-us/dotnet/api/System.Numerics.BitOperations.TrailingZeroCount
    private static int TrailingZeroCount(uint mask)
    {
        return Unsafe.AddByteOffset(
            ref MemoryMarshal.GetReference(TrailingZeroCountDeBruijn),
            (nint)(((mask & (uint)-(int)mask) * 0x077CB531u) >> 27));
    }

    private static ReadOnlySpan<byte> TrailingZeroCountDeBruijn
        => [
            00, 01, 28, 02, 29, 14, 24, 03,
            30, 22, 20, 15, 25, 17, 04, 08,
            31, 27, 13, 23, 21, 19, 16, 07,
            26, 12, 18, 06, 11, 05, 10, 09
        ];

    public override string ToString()
    {
        StringBuilder sb = new();

        sb.Append($"{Type,-32} {Name,-32} // 0x{Offset:X3}");

        if (BitMask > 0)
        {
            sb.Append($" (0x{Size:X3}, 0b{Convert.ToString(BitMask, 2).PadLeft(8, '0')})");
        }
        else
        {
            sb.Append($" (0x{Size:X3})");
        }

        return sb.ToString();
    }
}
