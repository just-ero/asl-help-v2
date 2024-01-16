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
    public string? Name => _name ??= _mono.GetImageName(Address).UnwrapOrDefault();

    private string? _fileName;
    public string? FileName => _fileName ??= _mono.GetImageFileName(Address).UnwrapOrDefault();

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
