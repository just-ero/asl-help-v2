using System;
using System.Buffers.Binary;
using System.IO;

using AslHelp.Common;
using AslHelp.Common.Extensions;
using AslHelp.Memory;
using AslHelp.Memory.Ipc;

public partial class Unity
{
    private Version? _unityVersion;
    public Version UnityVersion
    {
        get
        {
            if (_unityVersion is not null)
            {
                return _unityVersion;
            }

            EnsureInitialized();
            EnsureMemoryInitialized();

            // CS8600: Converting possible null value to non-nullable type
            // `EnsureHasMemory` already asserted that this isn't the case.
            IProcessMemory memory = Memory!;

            string? versionString = default;

            string dataDirectory = $"{memory.MainModule.FileName[..^4]}_Data";

            string ggmPath = Path.Combine(dataDirectory, "globalgamemanagers");
            string mdPath = Path.Combine(dataDirectory, "mainData");
            string du3dPath = Path.Combine(dataDirectory, "data.unity3d");

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
                if (memory.Modules.TryGetValue("UnityPlayer.dll", out Module? unityPlayer))
                {
                    versionString = unityPlayer.VersionInfo.FileVersion;
                }
            }

            if (versionString is null)
            {
                const string Msg = "Failed to find Unity version.";
                ThrowHelper.ThrowInvalidOperationException(Msg);
            }

            if (!Version.TryParse(versionString.Replace('f', '.'), out _unityVersion))
            {
                string msg = $"Failed to parse Unity version ({versionString}).";
                ThrowHelper.ThrowInvalidOperationException(msg);
            }

            return _unityVersion;
        }
    }
}
