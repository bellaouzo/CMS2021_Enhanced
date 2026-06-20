using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace INI;

[System.Serializable]
public class INIUnity : INIContent
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetColor_Public_Color_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColor_Public_Color_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColor_Public_Color_String_String_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVector2_Public_Vector2_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVector2_Public_Vector2_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVector2_Public_Vector2_String_String_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVector3_Public_Vector3_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVector3_Public_Vector3_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVector3_Public_Vector3_String_String_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetQuaternion_Public_Quaternion_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetQuaternion_Public_Quaternion_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetQuaternion_Public_Quaternion_String_String_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Change_Public_Void_String_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Change_Public_Void_String_Color_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Change_Public_Void_String_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Change_Public_Void_String_Vector2_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Change_Public_Void_String_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Change_Public_Void_String_Vector3_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Change_Public_Void_String_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Change_Public_Void_String_Quaternion_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToINIContent_Public_INIContent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<INIUnity>.NativeClassPtr));

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236670, XrefRangeEnd = 236673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color GetColor(string ID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColor_Public_Color_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236673, XrefRangeEnd = 236674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color GetColor(string ID, string section)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(section);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColor_Public_Color_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 236718, RefRangeEnd = 236721, XrefRangeStart = 236674, XrefRangeEnd = 236718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color GetColor(string ID, string section, Color defaultValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(section);
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColor_Public_Color_String_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236721, XrefRangeEnd = 236726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetVector2(string ID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVector2_Public_Vector2_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236726, XrefRangeEnd = 236729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetVector2(string ID, string section)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(section);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVector2_Public_Vector2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 236748, RefRangeEnd = 236757, XrefRangeStart = 236729, XrefRangeEnd = 236748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetVector2(string ID, string section, Vector2 defaultValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(section);
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVector2_Public_Vector2_String_String_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236757, XrefRangeEnd = 236762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetVector3(string ID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVector3_Public_Vector3_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 236765, RefRangeEnd = 236794, XrefRangeStart = 236762, XrefRangeEnd = 236765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetVector3(string ID, string section)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(section);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVector3_Public_Vector3_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(45)]
	[CachedScanResults(RefRangeStart = 236819, RefRangeEnd = 236864, XrefRangeStart = 236794, XrefRangeEnd = 236819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetVector3(string ID, string section, Vector3 defaultValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(section);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVector3_Public_Vector3_String_String_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236864, XrefRangeEnd = 236869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion GetQuaternion(string ID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetQuaternion_Public_Quaternion_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236869, XrefRangeEnd = 236872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion GetQuaternion(string ID, string section)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(section);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetQuaternion_Public_Quaternion_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 236916, RefRangeEnd = 236919, XrefRangeStart = 236872, XrefRangeEnd = 236916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion GetQuaternion(string ID, string section, Quaternion defaultValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(section);
		*(Quaternion**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetQuaternion_Public_Quaternion_String_String_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236919, XrefRangeEnd = 236922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Change(string ID, Color value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Change_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 236955, RefRangeEnd = 236957, XrefRangeStart = 236922, XrefRangeEnd = 236955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Change(string ID, Color value, string section)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(section);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Change_Public_Void_String_Color_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236957, XrefRangeEnd = 236960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Change(string ID, Vector2 value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Change_Public_Void_String_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 236969, RefRangeEnd = 236974, XrefRangeStart = 236960, XrefRangeEnd = 236969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Change(string ID, Vector2 value, string section)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(section);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Change_Public_Void_String_Vector2_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236974, XrefRangeEnd = 236977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Change(string ID, Vector3 value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Change_Public_Void_String_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 236988, RefRangeEnd = 237017, XrefRangeStart = 236977, XrefRangeEnd = 236988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Change(string ID, Vector3 value, string section)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(section);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Change_Public_Void_String_Vector3_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237017, XrefRangeEnd = 237020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Change(string ID, Quaternion value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Change_Public_Void_String_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 237053, RefRangeEnd = 237055, XrefRangeStart = 237020, XrefRangeEnd = 237053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Change(string ID, Quaternion value, string section)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(section);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Change_Public_Void_String_Quaternion_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 237059, RefRangeEnd = 237063, XrefRangeStart = 237055, XrefRangeEnd = 237059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe INIContent ToINIContent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToINIContent_Public_INIContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new INIContent(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237063, XrefRangeEnd = 237064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe INIUnity()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<INIUnity>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static INIUnity()
	{
		Il2CppClassPointerStore<INIUnity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "INI", "INIUnity");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<INIUnity>.NativeClassPtr);
		NativeMethodInfoPtr_GetColor_Public_Color_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INIUnity>.NativeClassPtr, 100681100);
		NativeMethodInfoPtr_GetColor_Public_Color_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INIUnity>.NativeClassPtr, 100681101);
		NativeMethodInfoPtr_GetColor_Public_Color_String_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INIUnity>.NativeClassPtr, 100681102);
		NativeMethodInfoPtr_GetVector2_Public_Vector2_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INIUnity>.NativeClassPtr, 100681103);
		NativeMethodInfoPtr_GetVector2_Public_Vector2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INIUnity>.NativeClassPtr, 100681104);
		NativeMethodInfoPtr_GetVector2_Public_Vector2_String_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INIUnity>.NativeClassPtr, 100681105);
		NativeMethodInfoPtr_GetVector3_Public_Vector3_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INIUnity>.NativeClassPtr, 100681106);
		NativeMethodInfoPtr_GetVector3_Public_Vector3_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INIUnity>.NativeClassPtr, 100681107);
		NativeMethodInfoPtr_GetVector3_Public_Vector3_String_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INIUnity>.NativeClassPtr, 100681108);
		NativeMethodInfoPtr_GetQuaternion_Public_Quaternion_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INIUnity>.NativeClassPtr, 100681109);
		NativeMethodInfoPtr_GetQuaternion_Public_Quaternion_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INIUnity>.NativeClassPtr, 100681110);
		NativeMethodInfoPtr_GetQuaternion_Public_Quaternion_String_String_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INIUnity>.NativeClassPtr, 100681111);
		NativeMethodInfoPtr_Change_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INIUnity>.NativeClassPtr, 100681112);
		NativeMethodInfoPtr_Change_Public_Void_String_Color_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INIUnity>.NativeClassPtr, 100681113);
		NativeMethodInfoPtr_Change_Public_Void_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INIUnity>.NativeClassPtr, 100681114);
		NativeMethodInfoPtr_Change_Public_Void_String_Vector2_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INIUnity>.NativeClassPtr, 100681115);
		NativeMethodInfoPtr_Change_Public_Void_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INIUnity>.NativeClassPtr, 100681116);
		NativeMethodInfoPtr_Change_Public_Void_String_Vector3_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INIUnity>.NativeClassPtr, 100681117);
		NativeMethodInfoPtr_Change_Public_Void_String_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INIUnity>.NativeClassPtr, 100681118);
		NativeMethodInfoPtr_Change_Public_Void_String_Quaternion_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INIUnity>.NativeClassPtr, 100681119);
		NativeMethodInfoPtr_ToINIContent_Public_INIContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INIUnity>.NativeClassPtr, 100681120);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INIUnity>.NativeClassPtr, 100681121);
	}

	public INIUnity(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
