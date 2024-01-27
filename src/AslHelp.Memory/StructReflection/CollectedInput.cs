using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

using AslHelp.Collections;
using AslHelp.Common.Results;
using AslHelp.IO;
using AslHelp.Memory.Scanning;

using InputField = (string TypeName, string Name, uint Alignment);
using InputStruct = (string Name, string? Super, System.Collections.Generic.IEnumerable<(string, string, uint)> Fields);

namespace AslHelp.Memory.StructReflection;

internal sealed class CollectedInput : OrderedDictionary<string, InputStruct>
{
    public Dictionary<string, ScanPattern> Patterns { get; } = [];

    public static Result<CollectedInput> GetFromEmbeddedResource(
        Assembly containingAssembly,
        string @namespace,
        string runtime,
        string version)
    {
        return EmbeddedResource.GetResourceStreamFromAssembly(containingAssembly, $"{@namespace}.{runtime}-{version}.json")
            .AndThen<JsonDefinition>(stream =>
            {
                DataContractJsonSerializer serializer = new(typeof(JsonDefinition));
                JsonDefinition definition = (JsonDefinition)serializer.ReadObject(stream);

                if (definition.Inheritance is null && definition.Structs is null)
                {
                    return ReflectionInitializationError.InheritanceOrStructs_NotProvided;
                }

                return definition;
            })
            .AndThen(definition =>
            {
                Result<CollectedInput> input = new CollectedInput();

                if (definition.Inheritance is { Runtime: { Length: > 0 } iRuntime, Version: { Length: > 0 } iVersion })
                {
                    input = GetFromEmbeddedResource(containingAssembly, @namespace, iRuntime, iVersion);
                }

                return input
                    .AndThenDo(input =>
                    {
                        if (definition.Structs is { Length: > 0 } structs)
                        {
                            foreach (JsonStruct @struct in structs)
                            {
                                string name = @struct.Name;
                                string? super = @struct.Super;
                                IEnumerable<InputField> fields = @struct.Fields.Select(f => (f.Type, f.Name, f.Alignment));

                                input[name] = (name, super, fields);
                            }
                        }

                        if (definition.Patterns is { Length: > 0 } patterns)
                        {
                            foreach (JsonScanPattern pattern in patterns)
                            {
                                input.Patterns[pattern.Name] = new(pattern.Offset, pattern.Pattern);
                            }
                        }
                    });
            });
    }

    protected override string GetKeyForItem(InputStruct item)
    {
        return item.Name;
    }

    [DataContract]
    private record JsonDefinition(
        [property: DataMember(Name = "inherits")] Inheritance? Inheritance,
        [property: DataMember(Name = "structs")] JsonStruct[]? Structs,
        [property: DataMember(Name = "signatures")] JsonScanPattern[]? Patterns);

    [DataContract]
    private record Inheritance(
        [property: DataMember(Name = "runtime")] string Runtime,
        [property: DataMember(Name = "version")] string Version);

    [DataContract]
    private record JsonScanPattern(
        [property: DataMember(Name = "name")] string Name,
        [property: DataMember(Name = "offset")] int Offset,
        [property: DataMember(Name = "pattern")] string Pattern);

    [DataContract]
    private record JsonStruct(
        [property: DataMember(Name = "name")] string Name,
        [property: DataMember(Name = "super")] string? Super,
        [property: DataMember(Name = "fields")] JsonField[] Fields);

    [DataContract]
    private record JsonField(
        [property: DataMember(Name = "type")] string Type,
        [property: DataMember(Name = "name")] string Name,
        [property: DataMember(Name = "align")] uint Alignment);
}
