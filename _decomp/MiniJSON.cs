using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

public class MiniJSON : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_TOKEN_NONE;

	private static readonly System.IntPtr NativeFieldInfoPtr_TOKEN_CURLY_OPEN;

	private static readonly System.IntPtr NativeFieldInfoPtr_TOKEN_CURLY_CLOSE;

	private static readonly System.IntPtr NativeFieldInfoPtr_TOKEN_SQUARED_OPEN;

	private static readonly System.IntPtr NativeFieldInfoPtr_TOKEN_SQUARED_CLOSE;

	private static readonly System.IntPtr NativeFieldInfoPtr_TOKEN_COLON;

	private static readonly System.IntPtr NativeFieldInfoPtr_TOKEN_COMMA;

	private static readonly System.IntPtr NativeFieldInfoPtr_TOKEN_STRING;

	private static readonly System.IntPtr NativeFieldInfoPtr_TOKEN_NUMBER;

	private static readonly System.IntPtr NativeFieldInfoPtr_TOKEN_TRUE;

	private static readonly System.IntPtr NativeFieldInfoPtr_TOKEN_FALSE;

	private static readonly System.IntPtr NativeFieldInfoPtr_TOKEN_NULL;

	private static readonly System.IntPtr NativeFieldInfoPtr_BUILDER_CAPACITY;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastErrorIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastDecode;

	private static readonly System.IntPtr NativeMethodInfoPtr_jsonDecode_Public_Static_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_jsonEncode_Public_Static_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_lastDecodeSuccessful_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getLastErrorIndex_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getLastErrorSnippet_Public_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_parseObject_Protected_Static_Hashtable_ArrayOf_Char_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_parseArray_Protected_Static_ArrayList_ArrayOf_Char_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_parseValue_Protected_Static_Object_ArrayOf_Char_byref_Int32_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_parseString_Protected_Static_String_ArrayOf_Char_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_parseNumber_Protected_Static_Double_ArrayOf_Char_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getLastIndexOfNumber_Protected_Static_Int32_ArrayOf_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_eatWhitespace_Protected_Static_Void_ArrayOf_Char_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_lookAhead_Protected_Static_Int32_ArrayOf_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_nextToken_Protected_Static_Int32_ArrayOf_Char_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_serializeObjectOrArray_Protected_Static_Boolean_Object_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_serializeObject_Protected_Static_Boolean_Hashtable_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_serializeDictionary_Protected_Static_Boolean_Dictionary_2_String_String_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_serializeArray_Protected_Static_Boolean_ArrayList_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_serializeValue_Protected_Static_Boolean_Object_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_serializeString_Protected_Static_Void_String_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_serializeNumber_Protected_Static_Void_Double_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr));

	public unsafe static int TOKEN_NONE
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TOKEN_NONE, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TOKEN_NONE, &num);
		}
	}

	public unsafe static int TOKEN_CURLY_OPEN
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TOKEN_CURLY_OPEN, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TOKEN_CURLY_OPEN, &num);
		}
	}

	public unsafe static int TOKEN_CURLY_CLOSE
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TOKEN_CURLY_CLOSE, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TOKEN_CURLY_CLOSE, &num);
		}
	}

	public unsafe static int TOKEN_SQUARED_OPEN
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TOKEN_SQUARED_OPEN, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TOKEN_SQUARED_OPEN, &num);
		}
	}

	public unsafe static int TOKEN_SQUARED_CLOSE
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TOKEN_SQUARED_CLOSE, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TOKEN_SQUARED_CLOSE, &num);
		}
	}

	public unsafe static int TOKEN_COLON
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TOKEN_COLON, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TOKEN_COLON, &num);
		}
	}

	public unsafe static int TOKEN_COMMA
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TOKEN_COMMA, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TOKEN_COMMA, &num);
		}
	}

	public unsafe static int TOKEN_STRING
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TOKEN_STRING, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TOKEN_STRING, &num);
		}
	}

	public unsafe static int TOKEN_NUMBER
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TOKEN_NUMBER, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TOKEN_NUMBER, &num);
		}
	}

	public unsafe static int TOKEN_TRUE
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TOKEN_TRUE, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TOKEN_TRUE, &num);
		}
	}

	public unsafe static int TOKEN_FALSE
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TOKEN_FALSE, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TOKEN_FALSE, &num);
		}
	}

	public unsafe static int TOKEN_NULL
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TOKEN_NULL, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TOKEN_NULL, &num);
		}
	}

	public unsafe static int BUILDER_CAPACITY
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BUILDER_CAPACITY, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BUILDER_CAPACITY, &num);
		}
	}

	public unsafe static int lastErrorIndex
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastErrorIndex, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastErrorIndex, &num);
		}
	}

	public unsafe static string lastDecode
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastDecode, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastDecode, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 107992, RefRangeEnd = 107994, XrefRangeStart = 107988, XrefRangeEnd = 107992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Object jsonDecode(string json)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_jsonDecode_Public_Static_Object_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 108005, RefRangeEnd = 108007, XrefRangeStart = 107994, XrefRangeEnd = 108005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string jsonEncode(Il2CppSystem.Object json)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(json);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_jsonEncode_Public_Static_String_Object_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108007, XrefRangeEnd = 108011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool lastDecodeSuccessful()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_lastDecodeSuccessful_Public_Static_Boolean_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108011, XrefRangeEnd = 108015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getLastErrorIndex()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getLastErrorIndex_Public_Static_Int32_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108015, XrefRangeEnd = 108030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string getLastErrorSnippet()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getLastErrorSnippet_Public_Static_String_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 108054, RefRangeEnd = 108055, XrefRangeStart = 108030, XrefRangeEnd = 108054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Hashtable parseObject(Il2CppStructArray<char> json, ref int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(json);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_parseObject_Protected_Static_Hashtable_ArrayOf_Char_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Hashtable(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 108073, RefRangeEnd = 108074, XrefRangeStart = 108055, XrefRangeEnd = 108073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ArrayList parseArray(Il2CppStructArray<char> json, ref int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(json);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_parseArray_Protected_Static_ArrayList_ArrayOf_Char_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new ArrayList(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 108121, RefRangeEnd = 108123, XrefRangeStart = 108074, XrefRangeEnd = 108121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Object parseValue(Il2CppStructArray<char> json, ref int index, ref bool success)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(json);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref index);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref success);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_parseValue_Protected_Static_Object_ArrayOf_Char_byref_Int32_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 108178, RefRangeEnd = 108180, XrefRangeStart = 108123, XrefRangeEnd = 108178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string parseString(Il2CppStructArray<char> json, ref int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(json);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_parseString_Protected_Static_String_ArrayOf_Char_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 108200, RefRangeEnd = 108201, XrefRangeStart = 108180, XrefRangeEnd = 108200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double parseNumber(Il2CppStructArray<char> json, ref int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(json);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_parseNumber_Protected_Static_Double_ArrayOf_Char_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(double*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108201, XrefRangeEnd = 108205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getLastIndexOfNumber(Il2CppStructArray<char> json, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(json);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getLastIndexOfNumber_Protected_Static_Int32_ArrayOf_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 108209, RefRangeEnd = 108212, XrefRangeStart = 108205, XrefRangeEnd = 108209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void eatWhitespace(Il2CppStructArray<char> json, ref int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(json);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_eatWhitespace_Protected_Static_Void_ArrayOf_Char_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 108216, RefRangeEnd = 108219, XrefRangeStart = 108212, XrefRangeEnd = 108216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int lookAhead(Il2CppStructArray<char> json, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(json);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_lookAhead_Protected_Static_Int32_ArrayOf_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 108223, RefRangeEnd = 108232, XrefRangeStart = 108219, XrefRangeEnd = 108223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int nextToken(Il2CppStructArray<char> json, ref int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(json);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_nextToken_Protected_Static_Int32_ArrayOf_Char_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108232, XrefRangeEnd = 108249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool serializeObjectOrArray(Il2CppSystem.Object objectOrArray, StringBuilder builder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectOrArray);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(builder);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_serializeObjectOrArray_Protected_Static_Boolean_Object_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 108273, RefRangeEnd = 108274, XrefRangeStart = 108249, XrefRangeEnd = 108273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool serializeObject(Hashtable anObject, StringBuilder builder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(anObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(builder);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_serializeObject_Protected_Static_Boolean_Hashtable_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108274, XrefRangeEnd = 108301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool serializeDictionary(Dictionary<string, string> dict, StringBuilder builder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(dict);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(builder);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_serializeDictionary_Protected_Static_Boolean_Dictionary_2_String_String_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 108313, RefRangeEnd = 108314, XrefRangeStart = 108301, XrefRangeEnd = 108313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool serializeArray(ArrayList anArray, StringBuilder builder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(anArray);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(builder);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_serializeArray_Protected_Static_Boolean_ArrayList_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 108343, RefRangeEnd = 108346, XrefRangeStart = 108314, XrefRangeEnd = 108343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool serializeValue(Il2CppSystem.Object value, StringBuilder builder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(builder);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_serializeValue_Protected_Static_Boolean_Object_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 108397, RefRangeEnd = 108400, XrefRangeStart = 108346, XrefRangeEnd = 108397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void serializeString(string aString, StringBuilder builder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(aString);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(builder);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_serializeString_Protected_Static_Void_String_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108400, XrefRangeEnd = 108420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void serializeNumber(double number, StringBuilder builder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&number);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(builder);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_serializeNumber_Protected_Static_Void_Double_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe MiniJSON()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MiniJSON()
	{
		Il2CppClassPointerStore<MiniJSON>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "MiniJSON");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr);
		NativeFieldInfoPtr_TOKEN_NONE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, "TOKEN_NONE");
		NativeFieldInfoPtr_TOKEN_CURLY_OPEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, "TOKEN_CURLY_OPEN");
		NativeFieldInfoPtr_TOKEN_CURLY_CLOSE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, "TOKEN_CURLY_CLOSE");
		NativeFieldInfoPtr_TOKEN_SQUARED_OPEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, "TOKEN_SQUARED_OPEN");
		NativeFieldInfoPtr_TOKEN_SQUARED_CLOSE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, "TOKEN_SQUARED_CLOSE");
		NativeFieldInfoPtr_TOKEN_COLON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, "TOKEN_COLON");
		NativeFieldInfoPtr_TOKEN_COMMA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, "TOKEN_COMMA");
		NativeFieldInfoPtr_TOKEN_STRING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, "TOKEN_STRING");
		NativeFieldInfoPtr_TOKEN_NUMBER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, "TOKEN_NUMBER");
		NativeFieldInfoPtr_TOKEN_TRUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, "TOKEN_TRUE");
		NativeFieldInfoPtr_TOKEN_FALSE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, "TOKEN_FALSE");
		NativeFieldInfoPtr_TOKEN_NULL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, "TOKEN_NULL");
		NativeFieldInfoPtr_BUILDER_CAPACITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, "BUILDER_CAPACITY");
		NativeFieldInfoPtr_lastErrorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, "lastErrorIndex");
		NativeFieldInfoPtr_lastDecode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, "lastDecode");
		NativeMethodInfoPtr_jsonDecode_Public_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, 100670001);
		NativeMethodInfoPtr_jsonEncode_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, 100670002);
		NativeMethodInfoPtr_lastDecodeSuccessful_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, 100670003);
		NativeMethodInfoPtr_getLastErrorIndex_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, 100670004);
		NativeMethodInfoPtr_getLastErrorSnippet_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, 100670005);
		NativeMethodInfoPtr_parseObject_Protected_Static_Hashtable_ArrayOf_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, 100670006);
		NativeMethodInfoPtr_parseArray_Protected_Static_ArrayList_ArrayOf_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, 100670007);
		NativeMethodInfoPtr_parseValue_Protected_Static_Object_ArrayOf_Char_byref_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, 100670008);
		NativeMethodInfoPtr_parseString_Protected_Static_String_ArrayOf_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, 100670009);
		NativeMethodInfoPtr_parseNumber_Protected_Static_Double_ArrayOf_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, 100670010);
		NativeMethodInfoPtr_getLastIndexOfNumber_Protected_Static_Int32_ArrayOf_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, 100670011);
		NativeMethodInfoPtr_eatWhitespace_Protected_Static_Void_ArrayOf_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, 100670012);
		NativeMethodInfoPtr_lookAhead_Protected_Static_Int32_ArrayOf_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, 100670013);
		NativeMethodInfoPtr_nextToken_Protected_Static_Int32_ArrayOf_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, 100670014);
		NativeMethodInfoPtr_serializeObjectOrArray_Protected_Static_Boolean_Object_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, 100670015);
		NativeMethodInfoPtr_serializeObject_Protected_Static_Boolean_Hashtable_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, 100670016);
		NativeMethodInfoPtr_serializeDictionary_Protected_Static_Boolean_Dictionary_2_String_String_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, 100670017);
		NativeMethodInfoPtr_serializeArray_Protected_Static_Boolean_ArrayList_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, 100670018);
		NativeMethodInfoPtr_serializeValue_Protected_Static_Boolean_Object_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, 100670019);
		NativeMethodInfoPtr_serializeString_Protected_Static_Void_String_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, 100670020);
		NativeMethodInfoPtr_serializeNumber_Protected_Static_Void_Double_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, 100670021);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJSON>.NativeClassPtr, 100670022);
	}

	public MiniJSON(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
