using System.Reflection;
using System.Text;

using AslHelp.Collections;
using AslHelp.Common.Results;

namespace AslHelp.Memory.StructReflection;

public sealed class Reflection : OrderedDictionary<string, Struct>
{
    internal Reflection() { }

    public static Result<Reflection> Initialize(bool is64Bit, (string, string, string) resourceData)
    {
        return Initialize(is64Bit, resourceData, Assembly.GetCallingAssembly());
    }

    public static Result<Reflection> Initialize(bool is64Bit, (string, string, string) resourceData, Assembly containingAssembly)
    {
        (string @namespace, string runtime, string version) = resourceData;

        return
            CollectedInput.GetFromEmbeddedResource(containingAssembly, @namespace, runtime, version)
            .AndThen(input =>
            {
                ReflectionInitializer initializer = new(is64Bit);
                return initializer.GenerateReflection(input);
            });
    }

    protected override string GetKeyForItem(Struct item)
    {
        return item.Name;
    }

    public sealed override string ToString()
    {
        StringBuilder sb = new();

        foreach (Struct s in this)
        {
            sb.AppendLine(s.ToString());
        }

        return sb.ToString().TrimEnd();
    }
}
