using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace AslHelp.Collections.Extensions;

public static class ListExtensions
{
    private static object? _getBackingArray;

    public static Span<T> AsSpan<T>(this List<T> source)
    {
        if (_getBackingArray is not Func<List<T>, (T[], int)> getBackingArray)
        {
            DynamicMethod dm = new(nameof(_getBackingArray), typeof((T[], int)), [typeof(List<T>)], true);

            FieldInfo fiItems = typeof(List<T>).GetField("_items", BindingFlags.Instance | BindingFlags.NonPublic);
            FieldInfo fiSize = typeof(List<T>).GetField("_size", BindingFlags.Instance | BindingFlags.NonPublic);

            ConstructorInfo ctor = typeof((T[], int)).GetConstructor([typeof(T[]), typeof(int)]);

            ILGenerator il = dm.GetILGenerator();
            il.Emit(OpCodes.Ldarg_0);
            il.Emit(OpCodes.Ldfld, fiItems);
            il.Emit(OpCodes.Ldarg_0);
            il.Emit(OpCodes.Ldfld, fiSize);
            il.Emit(OpCodes.Newobj, ctor);
            il.Emit(OpCodes.Ret);

            getBackingArray = (Func<List<T>, (T[], int)>)dm.CreateDelegate(typeof(Func<List<T>, (T[], int)>));
            _getBackingArray = getBackingArray;
        }

        (T[] items, int size) = getBackingArray(source);
        return new(items, 0, size);
    }
}
