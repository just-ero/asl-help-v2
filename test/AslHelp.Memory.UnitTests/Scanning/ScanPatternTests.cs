using AslHelp.Memory.Scanning;

namespace AslHelp.Memory.UnitTests.Scanning;

internal sealed class ScanPatternTests
{
    public static readonly TheoryData<string[], ulong[], ulong[]> StringConstructorTestCases = new()
    {
        {
            ["48 8B 0D"],
            [0x00000000000D8B48],
            [0x0000000000FFFFFF]
        },
        {
            ["48 8B 05 12345678 48 83 3C FF 00"],
            [0x4878563412058B48, 0x0000000000FF3C83],
            [0xFFFFFFFFFFFFFFFF, 0x00000000FFFFFFFF]
        },
        {
            ["48 8B 05 ???????? 48 83 3C ?? 00"],
            [0x4800000000058B48, 0x0000000000003C83],
            [0xFF00000000FFFFFF, 0x00000000FF00FFFF]
        },
        {
            ["12 34 5? 78 90 0? 87 65 43 21 00 12 34 56 78 ???? 87 65 4? 2?"],
            [0x6587009078503412, 0x0078563412002143, 0x0000002040658700],
            [0xFFFFF0FFFFF0FFFF, 0x00FFFFFFFFFFFFFF, 0x000000F0F0FFFF00]
        }
    };

    [Theory]
    [MemberData(nameof(StringConstructorTestCases))]
    public void StringConstructor_ParsesPatternCorrectly(string[] pattern, ulong[] expectedValues, ulong[] expectedMasks)
    {
        // When
        ScanPattern scanPattern = new(pattern);

        // Then
        Assert.Equal(expectedValues, scanPattern.Values);
        Assert.Equal(expectedMasks, scanPattern.Masks);
    }

    public static readonly TheoryData<byte[], ulong[], ulong[]> ByteConstructorTestCases = new()
    {
        {
            [0x48, 0x8B, 0x0D],
            [0x00000000000D8B48],
            [0x0000000000FFFFFF]
        },
        {
            [0x48, 0x8B, 0x05, 0x12, 0x34, 0x56, 0x78, 0x48, 0x83, 0x3C, 0xFF, 0x00],
            [0x4878563412058B48, 0x0000000000FF3C83],
            [0xFFFFFFFFFFFFFFFF, 0x00000000FFFFFFFF]
        },
        {
            [0x12, 0x34, 0x56, 0x78, 0x90, 0x09, 0x87, 0x65, 0x43, 0x21, 0x00, 0x12, 0x34, 0x56, 0x78, 0x90, 0x09, 0x87, 0x65, 0x43, 0x21],
            [0x6587099078563412, 0x9078563412002143, 0x0000002143658709],
            [0xFFFFFFFFFFFFFFFF, 0xFFFFFFFFFFFFFFFF, 0x000000FFFFFFFFFF]
        }
    };

    [Theory]
    [MemberData(nameof(ByteConstructorTestCases))]
    public void ByteConstructor_ParsesPatternCorrectly(byte[] pattern, ulong[] expectedValues, ulong[] expectedMasks)
    {
        // When
        ScanPattern scanPattern = new(pattern);

        // Then
        Assert.Equal(expectedValues, scanPattern.Values);
        Assert.Equal(expectedMasks, scanPattern.Masks);
    }
}
