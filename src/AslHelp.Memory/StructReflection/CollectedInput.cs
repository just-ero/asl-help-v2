using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

using AslHelp.Collections;
using AslHelp.Common.Results;
using AslHelp.Memory.Scanning;

using InputField = (string TypeName, string Name, uint Alignment);
using InputStruct = (string Name, string? Super, (string Type, string Name, uint Alignment)[] Fields);

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
        string resourceName = $"{@namespace}.{runtime}-{version}.json";
        using Stream? resource = containingAssembly.GetManifestResourceStream(resourceName);
        if (resource is null)
        {
            return ReflectionInitializationError.EmbeddedResourceNotFound(resourceName);
        }

        JsonDefinition definition;

        try
        {
            DataContractJsonSerializer serializer = new(typeof(JsonDefinition));
            definition = (JsonDefinition)serializer.ReadObject(resource);
        }
        catch (Exception ex)
        {
            return ex;
        }

        if (definition.Inheritance is null && definition.Structs is null)
        {
            return ReflectionInitializationError.InheritanceOrStructsMustBeProvided;
        }

        Result<CollectedInput> res =
            definition.Inheritance is { Runtime: { Length: > 0 } iRuntime, Version: { Length: > 0 } iVersion }
            ? GetFromEmbeddedResource(containingAssembly, @namespace, iRuntime, iVersion)
            : new CollectedInput();

        return res
            .AndThenDo(input =>
            {
                if (definition.Structs is { Length: > 0 } structs)
                {
                    foreach (JsonStruct @struct in structs)
                    {
                        string name = @struct.Name;
                        string? super = @struct.Super;
                        InputField[] fields = @struct.Fields.Select(f => (f.Type, f.Name, f.Alignment)).ToArray();

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
