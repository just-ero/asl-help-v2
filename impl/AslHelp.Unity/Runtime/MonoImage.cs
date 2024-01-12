using AslHelp.Collections;
using AslHelp.Unity.Runtime.Interop;

namespace AslHelp.Unity.Runtime;

public sealed partial class MonoImage(
    nuint address,
    MonoOperator mono)
{
    private readonly MonoOperator _mono = mono;

    public nuint Address { get; } = address;

    private string? _name;
    public string? Name
    {
        get
        {
            if (_name is null)
            {
                if (_mono.TryGetImageName(Address, out string? name))
                {
                    _name = name;
                }
            }

            return _name;
        }
    }

    private string? _fileName;
    public string? FileName
    {
        get
        {
            if (_fileName is null)
            {
                if (_mono.TryGetImageFileName(Address, out string? fileName))
                {
                    _fileName = fileName;
                }
            }

            return _fileName;
        }
    }

    public KeyedCollection<string, MonoClass> Classes { get; } = new MonoClassLookup(address, mono);

    public override string ToString()
    {
        if (Name is string name)
        {
            return name;
        }

        return $"{nameof(MonoImage)}@{(ulong)Address:X}";
    }
}

public partial class MonoImage
{

}
