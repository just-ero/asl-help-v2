using System.IO;
using System.Linq;
using System.Security.Cryptography;

using AslHelp.Common;
using AslHelp.Memory;

namespace AslHelp.LiveSplit;

public partial class AslPluginBase
{
    public string GetMD5Hash()
    {
        if (Memory is null)
        {
            ThrowHelper.ThrowInvalidOperationException("Memory is not initialized.");
        }

        return GetMD5Hash(Memory.MainModule);
    }

    public string GetMD5Hash(string moduleName)
    {
        if (Memory is null)
        {
            ThrowHelper.ThrowInvalidOperationException("Memory is not initialized.");
        }

        return GetMD5Hash(Memory.Modules[moduleName]);
    }

    public string GetMD5Hash(Module module)
    {
        using MD5 md5 = MD5.Create();
        return GetHash(module, md5);
    }

    public string GetSHA1Hash()
    {
        if (Memory is null)
        {
            ThrowHelper.ThrowInvalidOperationException("Memory is not initialized.");
        }

        return GetSHA1Hash(Memory.MainModule);
    }

    public string GetSHA1Hash(string moduleName)
    {
        if (Memory is null)
        {
            ThrowHelper.ThrowInvalidOperationException("Memory is not initialized.");
        }

        return GetSHA1Hash(Memory.Modules[moduleName]);
    }

    public string GetSHA1Hash(Module module)
    {
        using SHA1 sha1 = SHA1.Create();
        return GetHash(module, sha1);
    }

    public string GetSHA256Hash()
    {
        if (Memory is null)
        {
            ThrowHelper.ThrowInvalidOperationException("Memory is not initialized.");
        }

        return GetSHA256Hash(Memory.MainModule);
    }

    public string GetSHA256Hash(string moduleName)
    {
        if (Memory is null)
        {
            ThrowHelper.ThrowInvalidOperationException("Memory is not initialized.");
        }

        return GetSHA256Hash(Memory.Modules[moduleName]);
    }

    public string GetSHA256Hash(Module module)
    {
        using SHA256 sha256 = SHA256.Create();
        return GetHash(module, sha256);
    }

    public string GetSHA512Hash()
    {
        if (Memory is null)
        {
            ThrowHelper.ThrowInvalidOperationException("Memory is not initialized.");
        }

        return GetSHA512Hash(Memory.MainModule);
    }

    public string GetSHA512Hash(string moduleName)
    {
        if (Memory is null)
        {
            ThrowHelper.ThrowInvalidOperationException("Memory is not initialized.");
        }

        return GetSHA512Hash(Memory.Modules[moduleName]);
    }

    public string GetSHA512Hash(Module module)
    {
        using SHA512 sha512 = SHA512.Create();
        return GetHash(module, sha512);
    }

    private static string GetHash(Module module, HashAlgorithm algorithm)
    {
        using FileStream reader = File.OpenRead(module.FileName);
        return string.Concat(algorithm.ComputeHash(reader).Select(b => $"{b:X2}"));
    }
}
