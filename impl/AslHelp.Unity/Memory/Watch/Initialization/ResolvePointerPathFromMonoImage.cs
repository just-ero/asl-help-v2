// using System.Diagnostics.CodeAnalysis;

// using AslHelp.Memory.Pointers.Initialization;
// using AslHelp.Unity.Memory.MonoInterop;

// using OneOf;

// namespace AslHelp.Unity.Memory.Pointers.Initialization;

// internal class ResolvePointerPathFromMonoImage : IPointerResolver
// {
//     private enum Step
//     {
//         FindClass,
//         FindFields,
//         FindStaticData,
//         Done
//     }

//     private readonly MonoImage _image;
//     private readonly string _className;
//     private readonly string _staticFieldName;
//     private readonly OneOf<string, int>[] _next;

//     private Step _step;
//     private int _index;

//     private MonoClass? _class;
//     private MonoClass? _nextClass;
//     private MonoField? _staticField;

//     private nuint _baseAddress;
//     private readonly int[] _offsets;

//     public ResolvePointerPathFromMonoImage(MonoImage image, string className, string staticFieldName, OneOf<string, int>[] next)
//     {
//         _image = image;
//         _className = className;
//         _staticFieldName = staticFieldName;
//         _next = next;

//         _offsets = new int[next.Length];
//     }

//     public bool TryResolve(out nuint baseAddress, out int[] offsets)
//     {
//         switch (_step)
//         {
//             case Step.FindClass:
//             {
//                 _step = Step.FindClass;

//                 if (TryFindClassData())
//                 {
//                     goto case Step.FindFields;
//                 }

//                 break;
//             }
//             case Step.FindFields:
//             {
//                 _step = Step.FindFields;

//                 if (TryFindFields())
//                 {
//                     goto case Step.FindStaticData;
//                 }

//                 break;
//             }
//             case Step.FindStaticData:
//             {
//                 _step = Step.FindStaticData;

//                 if (TryFindStaticData())
//                 {
//                     goto case Step.Done;
//                 }

//                 break;
//             }
//             case Step.Done:
//             {
//                 _step = Step.Done;

//                 baseAddress = _baseAddress;
//                 offsets = _offsets;

//                 return true;
//             }
//         }

//         baseAddress = 0;
//         offsets = [];

//         return false;
//     }

//     [MemberNotNullWhen(true, nameof(_class), nameof(_nextClass), nameof(_staticField))]
//     private bool TryFindClassData()
//     {
//         if (!_image.Classes.TryGetValue(_className, out var @class))
//         {
//             return false;
//         }

//         while (@class.Address != 0)
//         {
//             if (@class.Fields.TryGetValue(_staticFieldName, out MonoField? staticField)
//                 && staticField.TryGetType(out MonoType? staticFieldType)
//                 && staticFieldType.TryGetClass(out MonoClass? nextClass)
//                 && staticFieldType.TryGetAttributes(out MonoFieldAttribute attributes)
//                 && attributes.HasFlag(MonoFieldAttribute.STATIC))
//             {
//                 _staticField = staticField;
//                 _nextClass = nextClass;
//                 _class = @class;

//                 return true;
//             }

//             if (!@class.TryGetParent(out @class))
//             {
//                 break;
//             }
//         }

//         return false;
//     }

//     private bool TryFindFields()
//     {
//         if (_nextClass is null)
//         {
//             return false;
//         }

//         while (_index < _next.Length)
//         {
//             if (_next[_index] is { Value: int offset })
//             {
//                 _offsets[_index] = offset;
//             }
//             else if (_next[_index] is { Value: string fieldName })
//             {
//                 MonoClass? @class;

//                 int i = fieldName.LastIndexOf('.');

//                 if (i == -1)
//                 {
//                     @class = _nextClass;
//                 }
//                 else
//                 {
//                     if (!_image.Classes.TryGetValue(fieldName[..i], out @class))
//                     {
//                         return false;
//                     }

//                     fieldName = fieldName[(i + 1)..];
//                 }

//                 while (@class.Address != 0)
//                 {
//                     if (@class.Fields.TryGetValue(fieldName, out MonoField? field)
//                         && field.TryGetOffset(out int fieldOffset)
//                         && field.TryGetType(out MonoType? type)
//                         && type.TryGetClass(out MonoClass? nextClass))
//                     {
//                         _nextClass = nextClass;
//                         _offsets[_index] = fieldOffset;

//                         break;
//                     }

//                     if (!@class.TryGetParent(out @class))
//                     {
//                         return false;
//                     }
//                 }
//             }

//             _index++;
//         }

//         return true;
//     }

//     private bool TryFindStaticData()
//     {
//         if (_class is null
//             || _staticField is null)
//         {
//             return false;
//         }

//         if (!_class.TryGetStaticDataChunk(out nuint staticDataChunk)
//             || staticDataChunk == 0)
//         {
//             return false;
//         }

//         if (!_staticField.TryGetOffset(out int offset))
//         {
//             return false;
//         }

//         _baseAddress = staticDataChunk + (nuint)offset;

//         return true;
//     }
// }
