using AslHelp.Memory.Native.Structs;

namespace AslHelp.Memory;

public readonly record struct DebugSymbol
{
    public DebugSymbol(string name, nuint address, uint size)
    {
        Name = name;
        Address = address;
        Size = size;
    }

    internal unsafe DebugSymbol(SYMBOL_INFOW symbol)
    {
        Name = new((char*)symbol.Name, 0, (int)symbol.NameLen - 1);
        Address = (nuint)symbol.Address;
        Size = symbol.Size;
    }

    public string Name { get; }
    public nuint Address { get; }
    public uint Size { get; }

    public override string ToString()
    {
        return
            $"{nameof(DebugSymbol)} {{ {nameof(Name)} = {Name}, {nameof(Address)} = 0x{(ulong)Address:X}, {nameof(Size)} = 0x{Size:X} }}";
    }
}
