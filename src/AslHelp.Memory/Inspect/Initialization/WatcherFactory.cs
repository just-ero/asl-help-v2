using System.Collections.Generic;

using AslHelp.Memory.Ipc;

namespace AslHelp.Memory.Inspect.Initialization;

public sealed class WatcherFactory : Dictionary<string, IWatcher>
{
    private readonly IProcessMemory _memory;

    public WatcherFactory(IProcessMemory memory)
    {
        _memory = memory;
    }

    public void MapTo(IDictionary<string, object?> destination)
    {
        foreach (var entry in this)
        {
            destination[entry.Key] = entry.Value.Current;
        }
    }

    public IWatcher<T> Create<T>(uint baseOffset, params int[] offsets)
        where T : unmanaged
    {
        Module module = _memory.MainModule;
        return Create<T>(module, baseOffset, offsets);
    }

    public IWatcher<T> Create<T>(string moduleName, uint baseOffset, params int[] offsets)
        where T : unmanaged
    {
        Module module = _memory.Modules[moduleName];
        return Create<T>(module, baseOffset, offsets);
    }

    public IWatcher<T> Create<T>(Module module, uint baseOffset, params int[] offsets)
        where T : unmanaged
    {
        return Create<T>(module.Base + baseOffset, offsets);
    }

    public IWatcher<T> Create<T>(nuint baseAddress, params int[] offsets)
        where T : unmanaged
    {
        return new Watcher<T>(_memory, baseAddress, offsets);
    }

    public IWatcher<T[]> CreateSpan<T>(int length, uint baseOffset, params int[] offsets)
        where T : unmanaged
    {
        Module module = _memory.MainModule;
        return CreateSpan<T>(length, module, baseOffset, offsets);
    }

    public IWatcher<T[]> CreateSpan<T>(int length, string moduleName, uint baseOffset, params int[] offsets)
        where T : unmanaged
    {
        Module module = _memory.Modules[moduleName];
        return CreateSpan<T>(length, module, baseOffset, offsets);
    }

    public IWatcher<T[]> CreateSpan<T>(int length, Module module, uint baseOffset, params int[] offsets)
        where T : unmanaged
    {
        return CreateSpan<T>(length, module.Base + baseOffset, offsets);
    }

    public IWatcher<T[]> CreateSpan<T>(int length, nuint baseAddress, params int[] offsets)
        where T : unmanaged
    {
        return new SpanWatcher<T>(_memory, length, baseAddress, offsets);
    }

    public IWatcher<string> CreateString(int maxLength, uint baseOffset, params int[] offsets)
    {
        Module module = _memory.MainModule;
        return CreateString(maxLength, StringType.Auto, module, baseOffset, offsets);
    }

    public IWatcher<string> CreateString(int maxLength, string moduleName, uint baseOffset, params int[] offsets)
    {
        Module module = _memory.Modules[moduleName];
        return CreateString(maxLength, StringType.Auto, module, baseOffset, offsets);
    }

    public IWatcher<string> CreateString(int maxLength, Module module, uint baseOffset, params int[] offsets)
    {
        return CreateString(maxLength, StringType.Auto, module, baseOffset, offsets);
    }

    public IWatcher<string> CreateString(int maxLength, nuint baseAddress, params int[] offsets)
    {
        return CreateString(maxLength, StringType.Auto, baseAddress, offsets);
    }

    public IWatcher<string> CreateString(int maxLength, StringType stringType, uint baseOffset, params int[] offsets)
    {
        Module module = _memory.MainModule;
        return CreateString(maxLength, stringType, module, baseOffset, offsets);
    }

    public IWatcher<string> CreateString(int maxLength, StringType stringType, string moduleName, uint baseOffset, params int[] offsets)
    {
        Module module = _memory.Modules[moduleName];
        return CreateString(maxLength, stringType, module, baseOffset, offsets);
    }

    public IWatcher<string> CreateString(int maxLength, StringType stringType, Module module, uint baseOffset, params int[] offsets)
    {
        return CreateString(maxLength, stringType, module.Base + baseOffset, offsets);
    }

    public IWatcher<string> CreateString(int maxLength, StringType stringType, nuint baseAddress, params int[] offsets)
    {
        return new StringWatcher(_memory, maxLength, stringType, baseAddress, offsets);
    }
}
