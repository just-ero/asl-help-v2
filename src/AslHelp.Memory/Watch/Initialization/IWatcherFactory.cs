using System;

namespace AslHelp.Memory.Watch.Initialization;

public interface IWatcherFactory
{
    IWatcher<T> Create<T>(uint baseOffset, params int[] offsets) where T : unmanaged;
    IWatcher<T> Create<T>(string moduleName, uint baseOffset, params int[] offsets) where T : unmanaged;
    IWatcher<T> Create<T>(Module module, uint baseOffset, params int[] offsets) where T : unmanaged;
    IWatcher<T> Create<T>(nuint baseAddress, params int[] offsets) where T : unmanaged;

    IWatcher<T[]> CreateSpan<T>(int length, uint baseOffset, params int[] offsets) where T : unmanaged;
    IWatcher<T[]> CreateSpan<T>(int length, string moduleName, uint baseOffset, params int[] offsets) where T : unmanaged;
    IWatcher<T[]> CreateSpan<T>(int length, Module module, uint baseOffset, params int[] offsets) where T : unmanaged;
    IWatcher<T[]> CreateSpan<T>(int length, nuint baseAddress, params int[] offsets) where T : unmanaged;

    IWatcher<string> CreateString(int maxLength, uint baseOffset, params int[] offsets);
    IWatcher<string> CreateString(int maxLength, string moduleName, uint baseOffset, params int[] offsets);
    IWatcher<string> CreateString(int maxLength, Module module, uint baseOffset, params int[] offsets);
    IWatcher<string> CreateString(int maxLength, nuint baseAddress, params int[] offsets);

    IWatcher<string> CreateString(int maxLength, StringType stringType, uint baseOffset, params int[] offsets);
    IWatcher<string> CreateString(int maxLength, StringType stringType, string moduleName, uint baseOffset, params int[] offsets);
    IWatcher<string> CreateString(int maxLength, StringType stringType, Module module, uint baseOffset, params int[] offsets);
    IWatcher<string> CreateString(int maxLength, StringType stringType, nuint baseAddress, params int[] offsets);
}
