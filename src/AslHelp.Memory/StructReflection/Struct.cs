using System.Text;

using AslHelp.Collections;

namespace AslHelp.Memory.StructReflection;

public sealed class Struct : OrderedDictionary<string, Field>
{
    internal Struct(string name, string? super = default)
    {
        Name = name;
        Super = super;
    }

    public string Name { get; set; }
    public string? Super { get; set; }
    public uint Size => this[^1].Offset + this[^1].Size;
    public uint Alignment => this[0].Alignment;
    public uint SelfAlignedSize => ReflectionInitializer.Align(Size, Alignment);

    protected override string GetKeyForItem(Field item)
    {
        return item.Name;
    }

    public sealed override string ToString()
    {
        StringBuilder sb = new();

        if (Super is null)
        {
            sb.AppendLine($"{Name} (0x{SelfAlignedSize:X3})");
        }
        else
        {
            sb.AppendLine($"{Name} : {Super} (0x{SelfAlignedSize:X3})");
        }

        foreach (Field field in this)
        {
            sb.AppendLine($"    {field}");
        }

        return sb.ToString().TrimEnd();
    }
}
