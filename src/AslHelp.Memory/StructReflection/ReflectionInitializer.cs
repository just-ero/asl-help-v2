using System;
using System.Collections.Generic;

using AslHelp.Common.Results;

using InputField = (string TypeName, string Name, uint Alignment);
using InputStruct = (string Name, string? Super, (string Type, string Name, uint Alignment)[] Fields);

namespace AslHelp.Memory.StructReflection;

internal sealed partial class ReflectionInitializer
{
    private readonly byte _ptrSize;

    private uint _offset, _bitOffset;
    private uint _pAlign;

    public ReflectionInitializer(bool is64Bit)
    {
        _ptrSize = (byte)(is64Bit ? 0x8 : 0x4);
    }

    public Result<Reflection> GenerateReflection(CollectedInput input)
    {
        Result<Reflection> reflection = new Reflection();

        foreach (InputStruct inStruct in input)
        {

            reflection = reflection
                .AndThen(r =>
                {
                    return
                        GenerateStruct(inStruct.Name, inStruct.Super, inStruct.Fields)
                        .Map(s =>
                        {
                            _structCache[s.Name] = s;
                            r[s.Name] = s;

                            return r;
                        });
                });
        }

        return reflection;
    }

    private Result<Struct> GenerateStruct(
        string name,
        string? super,
        InputField[] fields,
        IReadOnlyDictionary<string, string>? genericMap = default)
    {
        _pAlign = 0;
        _offset = 0;
        _bitOffset = uint.MaxValue;

        Result<Struct> @struct = new Struct(name, super);

        foreach (InputField inField in fields)
        {
            @struct = @struct
                .AndThen(@struct =>
                {
                    (string typeName, string name, uint forcedAlignment) = inField;

                    if (genericMap?.TryGetValue(typeName, out string? mappedType) is true)
                    {
                        typeName = mappedType;
                    }

                    return
                        GenerateField(typeName, name, forcedAlignment)
                        .Map(f =>
                        {
                            @struct[name] = f;

                            return @struct;
                        });
                });
        }

        return @struct;
    }

    private Result<Field> GenerateField(string type, string name, uint forcedAlign)
    {
        return
            GetTypeSize(type)
            .Map<Field>(r =>
            {
                uint offset = _offset, size = r.Size, align = forcedAlign > 0 ? forcedAlign : r.Align;
                uint bitfieldSize = r.BitfieldSize, bitOffset = _bitOffset;

                (uint, uint)? bitfield = default;

                if (bitfieldSize > 0)
                {
                    if (bitOffset == uint.MaxValue || align != _pAlign)
                    {
                        bitOffset = 0;
                        offset = Align(offset, Math.Max(align, _pAlign));
                    }

                    bitfield = new(bitfieldSize, bitOffset);

                    bitOffset += bitfieldSize;
                    size = bitOffset / 8;
                    bitOffset %= 8;
                }
                else
                {
                    bitOffset = uint.MaxValue;
                    offset = Align(offset, Math.Max(align, _pAlign));
                }

                _offset = offset + size;
                _pAlign = align;
                _bitOffset = bitOffset;

                return new(type, name, offset, size, align, bitfield);
            });
    }
}
