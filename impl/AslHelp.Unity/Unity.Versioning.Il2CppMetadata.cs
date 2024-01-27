using System.IO;

using AslHelp.Common.Extensions;
using AslHelp.Common.Results;
using AslHelp.Memory;
using AslHelp.Memory.Scanning;
using AslHelp.Unity;
using AslHelp.Unity.Memory.Ipc;

public partial class Unity
{
    private Il2CppMetadataHeader? _il2CppMetadata;
    public Il2CppMetadataHeader Il2CppMetadata
    {
        get
        {
            if (_il2CppMetadata.HasValue)
            {
                return _il2CppMetadata.Value;
            }

            EnsureMemoryInitialized();

            _il2CppMetadata = GetIl2CppMetadataFromMemory(Memory)
                .Or(GetIl2CppMetadataFromFile(DataDirectory))
                .Unwrap();

            return _il2CppMetadata.Value;
        }
    }

    private Result<Il2CppMetadataHeader> GetIl2CppMetadataFromMemory(IMonoProcessMemory memory)
    {
        ScanPattern pattern = new("AF1BB1FA ??000000");

        foreach (MemoryPage page in memory.GetMemoryPages(true))
        {
            var metadata = memory.Scan(pattern, page.Base, (int)page.RegionSize)
                .AndThen(relative => memory.ReadRelative(relative))
                .AndThen(globalMetadataHeader => memory.Read<Il2CppMetadataHeader>(globalMetadataHeader));

            if (metadata is { IsOk: true, Value: { } result })
            {
                return metadata.Unwrap();
            }
        }

        return UnityInitError.Il2CppMetadata_NotFound;
    }

    private static Result<Il2CppMetadataHeader> GetIl2CppMetadataFromFile(string data)
    {
        string il2CppMetadataPath = Path.Combine(data, "il2cpp_data", "Metadata", "global-metadata.dat");

        using FileStream fileStream = File.OpenRead(il2CppMetadataPath);

        return fileStream.Read<Il2CppMetadataHeader>();
    }
}
