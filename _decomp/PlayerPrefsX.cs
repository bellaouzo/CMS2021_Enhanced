using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class PlayerPrefsX : MonoBehaviour
{
	public enum ArrayType
	{
		Float,
		Int32,
		Bool,
		String,
		Vector2,
		Vector3,
		Quaternion,
		Color,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ArrayType>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static ArrayType()
		{
			Il2CppClassPointerStore<ArrayType>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, "ArrayType");
		}

	}

	private sealed class MethodInfoStoreGeneric_SetValue_Private_Static_Boolean_String_T_ArrayType_Int32_Action_3_T_ArrayOf_Byte_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SetValue_Private_Static_Boolean_String_T_ArrayType_Int32_Action_3_T_ArrayOf_Byte_Int32_0, Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetValue_Private_Static_Void_String_T_ArrayType_Int32_Action_2_T_ArrayOf_Byte_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetValue_Private_Static_Void_String_T_ArrayType_Int32_Action_2_T_ArrayOf_Byte_0, Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_endianDiff1;

	private static readonly System.IntPtr NativeFieldInfoPtr_endianDiff2;

	private static readonly System.IntPtr NativeFieldInfoPtr_idx;

	private static readonly System.IntPtr NativeFieldInfoPtr_byteBlock;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBool_Public_Static_Boolean_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBool_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBool_Public_Static_Boolean_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVector2_Public_Static_Boolean_String_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVector2_Public_Static_Vector2_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVector2_Public_Static_Vector2_String_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVector3_Public_Static_Boolean_String_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVector3_Public_Static_Vector3_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVector3_Public_Static_Vector3_String_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetQuaternion_Public_Static_Boolean_String_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetQuaternion_Public_Static_Quaternion_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetQuaternion_Public_Static_Quaternion_String_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetColor_Public_Static_Boolean_String_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColor_Public_Static_Color_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColor_Public_Static_Color_String_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBoolArray_Public_Static_Boolean_String_ArrayOf_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBoolArray_Public_Static_ArrayOf_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBoolArray_Public_Static_ArrayOf_Boolean_String_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetStringArray_Public_Static_Boolean_String_ArrayOf_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStringArray_Public_Static_ArrayOf_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStringArray_Public_Static_ArrayOf_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetIntArray_Public_Static_Boolean_String_ArrayOf_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFloatArray_Public_Static_Boolean_String_ArrayOf_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVector2Array_Public_Static_Boolean_String_ArrayOf_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVector3Array_Public_Static_Boolean_String_ArrayOf_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetQuaternionArray_Public_Static_Boolean_String_ArrayOf_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetColorArray_Public_Static_Boolean_String_ArrayOf_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Private_Static_Boolean_String_T_ArrayType_Int32_Action_3_T_ArrayOf_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertFromInt_Private_Static_Void_ArrayOf_Int32_ArrayOf_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertFromFloat_Private_Static_Void_ArrayOf_Single_ArrayOf_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertFromVector2_Private_Static_Void_ArrayOf_Vector2_ArrayOf_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertFromVector3_Private_Static_Void_ArrayOf_Vector3_ArrayOf_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertFromQuaternion_Private_Static_Void_ArrayOf_Quaternion_ArrayOf_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertFromColor_Private_Static_Void_ArrayOf_Color_ArrayOf_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIntArray_Public_Static_ArrayOf_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIntArray_Public_Static_ArrayOf_Int32_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFloatArray_Public_Static_ArrayOf_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFloatArray_Public_Static_ArrayOf_Single_String_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVector2Array_Public_Static_ArrayOf_Vector2_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVector2Array_Public_Static_ArrayOf_Vector2_String_Vector2_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVector3Array_Public_Static_ArrayOf_Vector3_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVector3Array_Public_Static_ArrayOf_Vector3_String_Vector3_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetQuaternionArray_Public_Static_ArrayOf_Quaternion_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetQuaternionArray_Public_Static_ArrayOf_Quaternion_String_Quaternion_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColorArray_Public_Static_ArrayOf_Color_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColorArray_Public_Static_ArrayOf_Color_String_Color_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Private_Static_Void_String_T_ArrayType_Int32_Action_2_T_ArrayOf_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToInt_Private_Static_Void_List_1_Int32_ArrayOf_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToFloat_Private_Static_Void_List_1_Single_ArrayOf_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToVector2_Private_Static_Void_List_1_Vector2_ArrayOf_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToVector3_Private_Static_Void_List_1_Vector3_ArrayOf_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToQuaternion_Private_Static_Void_List_1_Quaternion_ArrayOf_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToColor_Private_Static_Void_List_1_Color_ArrayOf_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowArrayType_Private_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveBytes_Private_Static_Boolean_String_ArrayOf_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertFloatToBytes_Private_Static_Void_Single_ArrayOf_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertBytesToFloat_Private_Static_Single_ArrayOf_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertInt32ToBytes_Private_Static_Void_Int32_ArrayOf_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertBytesToInt32_Private_Static_Int32_ArrayOf_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertTo4Bytes_Private_Static_Void_ArrayOf_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertFrom4Bytes_Private_Static_Void_ArrayOf_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVector4_Public_Static_Boolean_String_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVector4_Public_Static_Vector4_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVector4_Public_Static_Vector4_String_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr));

	public unsafe static int endianDiff1
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_endianDiff1, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_endianDiff1, &num);
		}
	}

	public unsafe static int endianDiff2
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_endianDiff2, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_endianDiff2, &num);
		}
	}

	public unsafe static int idx
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_idx, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_idx, &num);
		}
	}

	public unsafe static Il2CppStructArray<byte> byteBlock
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_byteBlock, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Il2CppStructArray<byte>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_byteBlock, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 79868, RefRangeEnd = 79869, XrefRangeStart = 79867, XrefRangeEnd = 79868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetBool(string name, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBool_Public_Static_Boolean_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79869, XrefRangeEnd = 79871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetBool(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBool_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79871, XrefRangeEnd = 79873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetBool(string name, bool defaultValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBool_Public_Static_Boolean_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79873, XrefRangeEnd = 79882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetVector2(string key, Vector2 vector)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &vector;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVector2_Public_Static_Boolean_String_Vector2_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79882, XrefRangeEnd = 79883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 GetVector2(string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVector2_Public_Static_Vector2_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79883, XrefRangeEnd = 79885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 GetVector2(string key, Vector2 defaultValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVector2_Public_Static_Vector2_String_Vector2_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79885, XrefRangeEnd = 79896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetVector3(string key, Vector3 vector)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &vector;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVector3_Public_Static_Boolean_String_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79896, XrefRangeEnd = 79897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 GetVector3(string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVector3_Public_Static_Vector3_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79897, XrefRangeEnd = 79899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 GetVector3(string key, Vector3 defaultValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVector3_Public_Static_Vector3_String_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79899, XrefRangeEnd = 79912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetQuaternion(string key, Quaternion vector)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &vector;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetQuaternion_Public_Static_Boolean_String_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79912, XrefRangeEnd = 79913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Quaternion GetQuaternion(string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetQuaternion_Public_Static_Quaternion_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79913, XrefRangeEnd = 79915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Quaternion GetQuaternion(string key, Quaternion defaultValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetQuaternion_Public_Static_Quaternion_String_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79915, XrefRangeEnd = 79928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetColor(string key, Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColor_Public_Static_Boolean_String_Color_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79928, XrefRangeEnd = 79929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color GetColor(string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColor_Public_Static_Color_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79929, XrefRangeEnd = 79931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color GetColor(string key, Color defaultValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColor_Public_Static_Color_String_Color_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79931, XrefRangeEnd = 79951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetBoolArray(string key, Il2CppStructArray<bool> boolArray)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(boolArray);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBoolArray_Public_Static_Boolean_String_ArrayOf_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79951, XrefRangeEnd = 79982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<bool> GetBoolArray(string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBoolArray_Public_Static_ArrayOf_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<bool>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79982, XrefRangeEnd = 79987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<bool> GetBoolArray(string key, bool defaultValue, int defaultSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBoolArray_Public_Static_ArrayOf_Boolean_String_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<bool>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79987, XrefRangeEnd = 80025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetStringArray(string key, Il2CppStringArray stringArray)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(stringArray);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStringArray_Public_Static_Boolean_String_ArrayOf_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80025, XrefRangeEnd = 80055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetStringArray(string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStringArray_Public_Static_ArrayOf_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStringArray(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80055, XrefRangeEnd = 80064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetStringArray(string key, string defaultValue, int defaultSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStringArray_Public_Static_ArrayOf_String_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStringArray(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80064, XrefRangeEnd = 80073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetIntArray(string key, Il2CppStructArray<int> intArray)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(intArray);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetIntArray_Public_Static_Boolean_String_ArrayOf_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 80082, RefRangeEnd = 80087, XrefRangeStart = 80073, XrefRangeEnd = 80082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetFloatArray(string key, Il2CppStructArray<float> floatArray)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(floatArray);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFloatArray_Public_Static_Boolean_String_ArrayOf_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80087, XrefRangeEnd = 80096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetVector2Array(string key, Il2CppStructArray<Vector2> vector2Array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(vector2Array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVector2Array_Public_Static_Boolean_String_ArrayOf_Vector2_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80096, XrefRangeEnd = 80105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetVector3Array(string key, Il2CppStructArray<Vector3> vector3Array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(vector3Array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVector3Array_Public_Static_Boolean_String_ArrayOf_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80105, XrefRangeEnd = 80114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetQuaternionArray(string key, Il2CppStructArray<Quaternion> quaternionArray)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(quaternionArray);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetQuaternionArray_Public_Static_Boolean_String_ArrayOf_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80114, XrefRangeEnd = 80123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetColorArray(string key, Il2CppStructArray<Color> colorArray)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(colorArray);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColorArray_Public_Static_Boolean_String_ArrayOf_Color_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 80147, RefRangeEnd = 80153, XrefRangeStart = 80123, XrefRangeEnd = 80147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetValue<T>(string key, T array, ArrayType arrayType, int vectorNumber, Il2CppSystem.Action<T, Il2CppStructArray<byte>, int> convert)
	{
		//IL_0081->IL0086: Incompatible stack types: I vs Ref
		//IL_005d->IL0086: Incompatible stack types: I vs Ref
		//IL_006a->IL0086: Incompatible stack types: I vs Ref
		//IL_0074->IL0086: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = array;
			if (obj is string)
			{
				reference = ref *(_003F*)IL2CPP.ManagedStringToIl2Cpp(obj as string);
			}
			else
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(obj as Il2CppObjectBase);
				reference = ref *(_003F*)intPtr;
				if (intPtr != (System.IntPtr)0)
				{
					reference = ref *(_003F*)intPtr;
					if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr)))
					{
						reference = ref *(_003F*)IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}
			}
		}
		else
		{
			reference = ref array;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		*(ArrayType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &arrayType;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &vectorNumber;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(convert);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SetValue_Private_Static_Boolean_String_T_ArrayType_Int32_Action_3_T_ArrayOf_Byte_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80153, XrefRangeEnd = 80157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConvertFromInt(Il2CppStructArray<int> array, Il2CppStructArray<byte> bytes, int i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertFromInt_Private_Static_Void_ArrayOf_Int32_ArrayOf_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80157, XrefRangeEnd = 80161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConvertFromFloat(Il2CppStructArray<float> array, Il2CppStructArray<byte> bytes, int i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertFromFloat_Private_Static_Void_ArrayOf_Single_ArrayOf_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80161, XrefRangeEnd = 80168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConvertFromVector2(Il2CppStructArray<Vector2> array, Il2CppStructArray<byte> bytes, int i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertFromVector2_Private_Static_Void_ArrayOf_Vector2_ArrayOf_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80168, XrefRangeEnd = 80178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConvertFromVector3(Il2CppStructArray<Vector3> array, Il2CppStructArray<byte> bytes, int i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertFromVector3_Private_Static_Void_ArrayOf_Vector3_ArrayOf_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80178, XrefRangeEnd = 80191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConvertFromQuaternion(Il2CppStructArray<Quaternion> array, Il2CppStructArray<byte> bytes, int i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertFromQuaternion_Private_Static_Void_ArrayOf_Quaternion_ArrayOf_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe static void ConvertFromColor(Il2CppStructArray<Color> array, Il2CppStructArray<byte> bytes, int i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertFromColor_Private_Static_Void_ArrayOf_Color_ArrayOf_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80191, XrefRangeEnd = 80210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<int> GetIntArray(string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIntArray_Public_Static_ArrayOf_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<int>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80210, XrefRangeEnd = 80215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<int> GetIntArray(string key, int defaultValue, int defaultSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIntArray_Public_Static_ArrayOf_Int32_String_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<int>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 80234, RefRangeEnd = 80239, XrefRangeStart = 80215, XrefRangeEnd = 80234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<float> GetFloatArray(string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFloatArray_Public_Static_ArrayOf_Single_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80239, XrefRangeEnd = 80244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<float> GetFloatArray(string key, float defaultValue, int defaultSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFloatArray_Public_Static_ArrayOf_Single_String_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80244, XrefRangeEnd = 80263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector2> GetVector2Array(string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVector2Array_Public_Static_ArrayOf_Vector2_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Vector2>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80263, XrefRangeEnd = 80268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector2> GetVector2Array(string key, Vector2 defaultValue, int defaultSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVector2Array_Public_Static_ArrayOf_Vector2_String_Vector2_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Vector2>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80268, XrefRangeEnd = 80287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector3> GetVector3Array(string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVector3Array_Public_Static_ArrayOf_Vector3_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Vector3>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80287, XrefRangeEnd = 80292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector3> GetVector3Array(string key, Vector3 defaultValue, int defaultSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVector3Array_Public_Static_ArrayOf_Vector3_String_Vector3_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Vector3>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80292, XrefRangeEnd = 80316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Quaternion> GetQuaternionArray(string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetQuaternionArray_Public_Static_ArrayOf_Quaternion_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Quaternion>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80316, XrefRangeEnd = 80321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Quaternion> GetQuaternionArray(string key, Quaternion defaultValue, int defaultSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetQuaternionArray_Public_Static_ArrayOf_Quaternion_String_Quaternion_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Quaternion>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80321, XrefRangeEnd = 80345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Color> GetColorArray(string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColorArray_Public_Static_ArrayOf_Color_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Color>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80345, XrefRangeEnd = 80350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Color> GetColorArray(string key, Color defaultValue, int defaultSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColorArray_Public_Static_ArrayOf_Color_String_Color_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Color>(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 80367, RefRangeEnd = 80373, XrefRangeStart = 80350, XrefRangeEnd = 80367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetValue<T>(string key, T list, ArrayType arrayType, int vectorNumber, Il2CppSystem.Action<T, Il2CppStructArray<byte>> convert)
	{
		//IL_0081->IL0086: Incompatible stack types: I vs Ref
		//IL_005d->IL0086: Incompatible stack types: I vs Ref
		//IL_006a->IL0086: Incompatible stack types: I vs Ref
		//IL_0074->IL0086: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = list;
			if (obj is string)
			{
				reference = ref *(_003F*)IL2CPP.ManagedStringToIl2Cpp(obj as string);
			}
			else
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(obj as Il2CppObjectBase);
				reference = ref *(_003F*)intPtr;
				if (intPtr != (System.IntPtr)0)
				{
					reference = ref *(_003F*)intPtr;
					if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr)))
					{
						reference = ref *(_003F*)IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}
			}
		}
		else
		{
			reference = ref list;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		*(ArrayType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &arrayType;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &vectorNumber;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(convert);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetValue_Private_Static_Void_String_T_ArrayType_Int32_Action_2_T_ArrayOf_Byte_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80373, XrefRangeEnd = 80378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConvertToInt(List<int> list, Il2CppStructArray<byte> bytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToInt_Private_Static_Void_List_1_Int32_ArrayOf_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80378, XrefRangeEnd = 80382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConvertToFloat(List<float> list, Il2CppStructArray<byte> bytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToFloat_Private_Static_Void_List_1_Single_ArrayOf_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80382, XrefRangeEnd = 80387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConvertToVector2(List<Vector2> list, Il2CppStructArray<byte> bytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToVector2_Private_Static_Void_List_1_Vector2_ArrayOf_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80387, XrefRangeEnd = 80392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConvertToVector3(List<Vector3> list, Il2CppStructArray<byte> bytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToVector3_Private_Static_Void_List_1_Vector3_ArrayOf_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80392, XrefRangeEnd = 80398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConvertToQuaternion(List<Quaternion> list, Il2CppStructArray<byte> bytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToQuaternion_Private_Static_Void_List_1_Quaternion_ArrayOf_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80398, XrefRangeEnd = 80404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConvertToColor(List<Color> list, Il2CppStructArray<byte> bytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToColor_Private_Static_Void_List_1_Color_ArrayOf_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80404, XrefRangeEnd = 80425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowArrayType(string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowArrayType_Private_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 80440, RefRangeEnd = 80446, XrefRangeStart = 80425, XrefRangeEnd = 80440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Private_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 80455, RefRangeEnd = 80457, XrefRangeStart = 80446, XrefRangeEnd = 80455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SaveBytes(string key, Il2CppStructArray<byte> bytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveBytes_Private_Static_Boolean_String_ArrayOf_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 80471, RefRangeEnd = 80485, XrefRangeStart = 80457, XrefRangeEnd = 80471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConvertFloatToBytes(float f, Il2CppStructArray<byte> bytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&f);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertFloatToBytes_Private_Static_Void_Single_ArrayOf_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 80496, RefRangeEnd = 80510, XrefRangeStart = 80485, XrefRangeEnd = 80496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ConvertBytesToFloat(Il2CppStructArray<byte> bytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertBytesToFloat_Private_Static_Single_ArrayOf_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 80520, RefRangeEnd = 80522, XrefRangeStart = 80510, XrefRangeEnd = 80520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConvertInt32ToBytes(int i, Il2CppStructArray<byte> bytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&i);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertInt32ToBytes_Private_Static_Void_Int32_ArrayOf_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 80529, RefRangeEnd = 80531, XrefRangeStart = 80522, XrefRangeEnd = 80529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ConvertBytesToInt32(Il2CppStructArray<byte> bytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertBytesToInt32_Private_Static_Int32_ArrayOf_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 80537, RefRangeEnd = 80539, XrefRangeStart = 80531, XrefRangeEnd = 80537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConvertTo4Bytes(Il2CppStructArray<byte> bytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertTo4Bytes_Private_Static_Void_ArrayOf_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 80545, RefRangeEnd = 80547, XrefRangeStart = 80539, XrefRangeEnd = 80545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConvertFrom4Bytes(Il2CppStructArray<byte> bytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertFrom4Bytes_Private_Static_Void_ArrayOf_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80547, XrefRangeEnd = 80560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetVector4(string key, Vector4 vector)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(Vector4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &vector;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVector4_Public_Static_Boolean_String_Vector4_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80560, XrefRangeEnd = 80561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector4 GetVector4(string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVector4_Public_Static_Vector4_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80561, XrefRangeEnd = 80563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector4 GetVector4(string key, Vector4 defaultValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(Vector4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVector4_Public_Static_Vector4_String_Vector4_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe PlayerPrefsX()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PlayerPrefsX()
	{
		Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "PlayerPrefsX");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr);
		NativeFieldInfoPtr_endianDiff1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, "endianDiff1");
		NativeFieldInfoPtr_endianDiff2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, "endianDiff2");
		NativeFieldInfoPtr_idx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, "idx");
		NativeFieldInfoPtr_byteBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, "byteBlock");
		NativeMethodInfoPtr_SetBool_Public_Static_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667897);
		NativeMethodInfoPtr_GetBool_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667898);
		NativeMethodInfoPtr_GetBool_Public_Static_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667899);
		NativeMethodInfoPtr_SetVector2_Public_Static_Boolean_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667900);
		NativeMethodInfoPtr_GetVector2_Public_Static_Vector2_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667901);
		NativeMethodInfoPtr_GetVector2_Public_Static_Vector2_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667902);
		NativeMethodInfoPtr_SetVector3_Public_Static_Boolean_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667903);
		NativeMethodInfoPtr_GetVector3_Public_Static_Vector3_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667904);
		NativeMethodInfoPtr_GetVector3_Public_Static_Vector3_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667905);
		NativeMethodInfoPtr_SetQuaternion_Public_Static_Boolean_String_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667906);
		NativeMethodInfoPtr_GetQuaternion_Public_Static_Quaternion_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667907);
		NativeMethodInfoPtr_GetQuaternion_Public_Static_Quaternion_String_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667908);
		NativeMethodInfoPtr_SetColor_Public_Static_Boolean_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667909);
		NativeMethodInfoPtr_GetColor_Public_Static_Color_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667910);
		NativeMethodInfoPtr_GetColor_Public_Static_Color_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667911);
		NativeMethodInfoPtr_SetBoolArray_Public_Static_Boolean_String_ArrayOf_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667912);
		NativeMethodInfoPtr_GetBoolArray_Public_Static_ArrayOf_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667913);
		NativeMethodInfoPtr_GetBoolArray_Public_Static_ArrayOf_Boolean_String_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667914);
		NativeMethodInfoPtr_SetStringArray_Public_Static_Boolean_String_ArrayOf_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667915);
		NativeMethodInfoPtr_GetStringArray_Public_Static_ArrayOf_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667916);
		NativeMethodInfoPtr_GetStringArray_Public_Static_ArrayOf_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667917);
		NativeMethodInfoPtr_SetIntArray_Public_Static_Boolean_String_ArrayOf_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667918);
		NativeMethodInfoPtr_SetFloatArray_Public_Static_Boolean_String_ArrayOf_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667919);
		NativeMethodInfoPtr_SetVector2Array_Public_Static_Boolean_String_ArrayOf_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667920);
		NativeMethodInfoPtr_SetVector3Array_Public_Static_Boolean_String_ArrayOf_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667921);
		NativeMethodInfoPtr_SetQuaternionArray_Public_Static_Boolean_String_ArrayOf_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667922);
		NativeMethodInfoPtr_SetColorArray_Public_Static_Boolean_String_ArrayOf_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667923);
		NativeMethodInfoPtr_SetValue_Private_Static_Boolean_String_T_ArrayType_Int32_Action_3_T_ArrayOf_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667924);
		NativeMethodInfoPtr_ConvertFromInt_Private_Static_Void_ArrayOf_Int32_ArrayOf_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667925);
		NativeMethodInfoPtr_ConvertFromFloat_Private_Static_Void_ArrayOf_Single_ArrayOf_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667926);
		NativeMethodInfoPtr_ConvertFromVector2_Private_Static_Void_ArrayOf_Vector2_ArrayOf_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667927);
		NativeMethodInfoPtr_ConvertFromVector3_Private_Static_Void_ArrayOf_Vector3_ArrayOf_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667928);
		NativeMethodInfoPtr_ConvertFromQuaternion_Private_Static_Void_ArrayOf_Quaternion_ArrayOf_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667929);
		NativeMethodInfoPtr_ConvertFromColor_Private_Static_Void_ArrayOf_Color_ArrayOf_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667930);
		NativeMethodInfoPtr_GetIntArray_Public_Static_ArrayOf_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667931);
		NativeMethodInfoPtr_GetIntArray_Public_Static_ArrayOf_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667932);
		NativeMethodInfoPtr_GetFloatArray_Public_Static_ArrayOf_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667933);
		NativeMethodInfoPtr_GetFloatArray_Public_Static_ArrayOf_Single_String_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667934);
		NativeMethodInfoPtr_GetVector2Array_Public_Static_ArrayOf_Vector2_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667935);
		NativeMethodInfoPtr_GetVector2Array_Public_Static_ArrayOf_Vector2_String_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667936);
		NativeMethodInfoPtr_GetVector3Array_Public_Static_ArrayOf_Vector3_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667937);
		NativeMethodInfoPtr_GetVector3Array_Public_Static_ArrayOf_Vector3_String_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667938);
		NativeMethodInfoPtr_GetQuaternionArray_Public_Static_ArrayOf_Quaternion_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667939);
		NativeMethodInfoPtr_GetQuaternionArray_Public_Static_ArrayOf_Quaternion_String_Quaternion_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667940);
		NativeMethodInfoPtr_GetColorArray_Public_Static_ArrayOf_Color_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667941);
		NativeMethodInfoPtr_GetColorArray_Public_Static_ArrayOf_Color_String_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667942);
		NativeMethodInfoPtr_GetValue_Private_Static_Void_String_T_ArrayType_Int32_Action_2_T_ArrayOf_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667943);
		NativeMethodInfoPtr_ConvertToInt_Private_Static_Void_List_1_Int32_ArrayOf_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667944);
		NativeMethodInfoPtr_ConvertToFloat_Private_Static_Void_List_1_Single_ArrayOf_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667945);
		NativeMethodInfoPtr_ConvertToVector2_Private_Static_Void_List_1_Vector2_ArrayOf_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667946);
		NativeMethodInfoPtr_ConvertToVector3_Private_Static_Void_List_1_Vector3_ArrayOf_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667947);
		NativeMethodInfoPtr_ConvertToQuaternion_Private_Static_Void_List_1_Quaternion_ArrayOf_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667948);
		NativeMethodInfoPtr_ConvertToColor_Private_Static_Void_List_1_Color_ArrayOf_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667949);
		NativeMethodInfoPtr_ShowArrayType_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667950);
		NativeMethodInfoPtr_Initialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667951);
		NativeMethodInfoPtr_SaveBytes_Private_Static_Boolean_String_ArrayOf_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667952);
		NativeMethodInfoPtr_ConvertFloatToBytes_Private_Static_Void_Single_ArrayOf_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667953);
		NativeMethodInfoPtr_ConvertBytesToFloat_Private_Static_Single_ArrayOf_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667954);
		NativeMethodInfoPtr_ConvertInt32ToBytes_Private_Static_Void_Int32_ArrayOf_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667955);
		NativeMethodInfoPtr_ConvertBytesToInt32_Private_Static_Int32_ArrayOf_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667956);
		NativeMethodInfoPtr_ConvertTo4Bytes_Private_Static_Void_ArrayOf_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667957);
		NativeMethodInfoPtr_ConvertFrom4Bytes_Private_Static_Void_ArrayOf_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667958);
		NativeMethodInfoPtr_SetVector4_Public_Static_Boolean_String_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667959);
		NativeMethodInfoPtr_GetVector4_Public_Static_Vector4_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667960);
		NativeMethodInfoPtr_GetVector4_Public_Static_Vector4_String_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667961);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsX>.NativeClassPtr, 100667962);
	}

	public PlayerPrefsX(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
