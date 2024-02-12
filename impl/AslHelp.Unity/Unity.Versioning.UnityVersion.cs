using System;
using System.Buffers.Binary;
using System.IO;
using System.Linq;

using AslHelp.Common.Extensions;
using AslHelp.Common.Results;
using AslHelp.Unity;
using AslHelp.Unity.Memory.Ipc;

public partial class Unity
{
    private string? _dataDirectory;
    public string DataDirectory
    {
        get
        {
            if (_dataDirectory is not null)
            {
                return _dataDirectory;
            }

            EnsureMemoryInitialized();

            string gameDirectory = Path.GetDirectoryName(Memory.MainModule.FileName);
            _dataDirectory = Directory.GetDirectories(gameDirectory, "*_Data").Single();

            return _dataDirectory;
        }
        set => _dataDirectory = value;
    }

    private Version? _unityVersion;
    public Version UnityVersion
    {
        get
        {
            if (_unityVersion is not null)
            {
                return _unityVersion;
            }

            EnsureMemoryInitialized();

            _unityVersion = GetUnityVersionFromMetadataFile(DataDirectory).Unwrap();

            return _unityVersion;
        }
    }

    private static Result<Version> GetUnityVersionFromMetadataFile(string data)
    {
        string versionString;

        string ggmPath = Path.Combine(data, "globalgamemanagers");
        string mdPath = Path.Combine(data, "mainData");
        string du3dPath = Path.Combine(data, "data.unity3d");

        bool ggmExists = File.Exists(ggmPath), mdExists = File.Exists(mdPath), du3dExists = File.Exists(du3dPath);

        if (ggmExists || mdExists)
        {
            using FileStream fs = File.OpenRead(ggmExists ? ggmPath : mdPath);

            Span<byte> buffer = stackalloc byte[sizeof(uint)];

            fs.ReadExactly(buffer);
            uint metaDataSize = BinaryPrimitives.ReadUInt32BigEndian(buffer);

            fs.ReadExactly(buffer);
            uint fileSize = BinaryPrimitives.ReadUInt32BigEndian(buffer);

            fs.ReadExactly(buffer);
            uint fileVersion = BinaryPrimitives.ReadUInt32BigEndian(buffer);

            if (fileVersion >= 9)
            {
                fs.Position += 8;
            }
            else
            {
                fs.Position = fileSize - metaDataSize + 1;
            }

            if (fileVersion >= 22)
            {
                fs.Position += 28;
            }

            if (fileVersion >= 7)
            {
                using BinaryReader br = new(fs);
                versionString = br.ReadNullTerminatedString();
            }
            else
            {
                return UnityInitError.VersionMetadata_Invalid;
            }
        }
        else if (du3dExists)
        {
            using FileStream fs = File.OpenRead(du3dPath);
            using BinaryReader br = new(fs);

            _ = br.ReadNullTerminatedString();
            fs.Position += 4;
            _ = br.ReadNullTerminatedString();

            versionString = br.ReadNullTerminatedString();
        }
        else
        {
            return UnityInitError.VersionMetadata_NotFound;
        }

        if (!Version.TryParse(versionString.Replace('f', '.'), out Version? unityVersion))
        {
            return UnityInitError.VersionString_Invalid;
        }

        return unityVersion;
    }
}
