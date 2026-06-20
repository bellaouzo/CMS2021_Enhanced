using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.FileSupport.INI;

public class IniData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Entries;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Private_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetString_Public_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetString_Public_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetString_Public_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFloat_Public_Single_String_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFloat_Public_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFloat_Public_Single_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInt_Public_Int32_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInt_Public_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInt_Public_Int32_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBool_Public_Boolean_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBool_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBool_Public_Boolean_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColor_Public_Color_String_String_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColor_Public_Color_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColor_Public_Color_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVector2_Public_Vector2_String_String_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVector2_Public_Vector2_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVector2_Public_Vector2_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVector3_Public_Vector3_String_String_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVector3WithZeroDefault_Public_Vector3_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVector3_Public_Vector3_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVector3_Public_Vector3_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetQuaternion_Public_Quaternion_String_String_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetQuaternion_Public_Quaternion_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetQuaternion_Public_Quaternion_String_String_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<IniData>.NativeClassPtr));

	public unsafe List<IniEntry> Entries
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Entries);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<IniEntry>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 216040, RefRangeEnd = 216041, XrefRangeStart = 216026, XrefRangeEnd = 216040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IniData(int count)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IniData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&count);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(48)]
	[CachedScanResults(RefRangeStart = 216044, RefRangeEnd = 216092, XrefRangeStart = 216041, XrefRangeEnd = 216044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string Get(string id, string section)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(section);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Private_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216092, XrefRangeEnd = 216095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetString(string id, string section, string defaultValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(section);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetString_Public_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216095, XrefRangeEnd = 216100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetString(string id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetString_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(30)]
	[CachedScanResults(RefRangeStart = 216105, RefRangeEnd = 216135, XrefRangeStart = 216100, XrefRangeEnd = 216105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetString(string id, string section)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(section);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetString_Public_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(62)]
	[CachedScanResults(RefRangeStart = 216138, RefRangeEnd = 216200, XrefRangeStart = 216135, XrefRangeEnd = 216138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetFloat(string id, string section, float defaultValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(section);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFloat_Public_Single_String_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216200, XrefRangeEnd = 216205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetFloat(string id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFloat_Public_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 216208, RefRangeEnd = 216209, XrefRangeStart = 216205, XrefRangeEnd = 216208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetFloat(string id, string section)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(section);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFloat_Public_Single_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216209, XrefRangeEnd = 216212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetInt(string id, string section, int defaultValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(section);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInt_Public_Int32_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216212, XrefRangeEnd = 216217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetInt(string id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInt_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216217, XrefRangeEnd = 216220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetInt(string id, string section)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(section);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInt_Public_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(52)]
	[CachedScanResults(RefRangeStart = 216225, RefRangeEnd = 216277, XrefRangeStart = 216220, XrefRangeEnd = 216225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetBool(string id, string section, bool defaultValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(section);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBool_Public_Boolean_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216277, XrefRangeEnd = 216280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetBool(string id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBool_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216280, XrefRangeEnd = 216281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetBool(string id, string section)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(section);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBool_Public_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 216326, RefRangeEnd = 216328, XrefRangeStart = 216281, XrefRangeEnd = 216326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color GetColor(string id, string section, Color defaultValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(section);
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColor_Public_Color_String_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216328, XrefRangeEnd = 216331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color GetColor(string id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColor_Public_Color_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216331, XrefRangeEnd = 216332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color GetColor(string id, string section)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(section);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColor_Public_Color_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 216352, RefRangeEnd = 216354, XrefRangeStart = 216332, XrefRangeEnd = 216352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetVector2(string id, string section, Vector2 defaultValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(section);
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVector2_Public_Vector2_String_String_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216354, XrefRangeEnd = 216359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetVector2(string id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVector2_Public_Vector2_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 216362, RefRangeEnd = 216366, XrefRangeStart = 216359, XrefRangeEnd = 216362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetVector2(string id, string section)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(section);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVector2_Public_Vector2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 216395, RefRangeEnd = 216397, XrefRangeStart = 216366, XrefRangeEnd = 216395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetVector3(string id, string section, Vector3 defaultValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(section);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVector3_Public_Vector3_String_String_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 216418, RefRangeEnd = 216429, XrefRangeStart = 216397, XrefRangeEnd = 216418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetVector3WithZeroDefault(string id, string section)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(section);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVector3WithZeroDefault_Public_Vector3_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216429, XrefRangeEnd = 216432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetVector3(string id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVector3_Public_Vector3_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216432, XrefRangeEnd = 216433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetVector3(string id, string section)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(section);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVector3_Public_Vector3_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 216478, RefRangeEnd = 216480, XrefRangeStart = 216433, XrefRangeEnd = 216478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion GetQuaternion(string id, string section, Quaternion defaultValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(section);
		*(Quaternion**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetQuaternion_Public_Quaternion_String_String_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216480, XrefRangeEnd = 216485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion GetQuaternion(string id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetQuaternion_Public_Quaternion_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216485, XrefRangeEnd = 216488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion GetQuaternion(string id, string section)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(section);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetQuaternion_Public_Quaternion_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static IniData()
	{
		Il2CppClassPointerStore<IniData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.FileSupport.INI", "IniData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IniData>.NativeClassPtr);
		NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IniData>.NativeClassPtr, "Entries");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniData>.NativeClassPtr, 100679613);
		NativeMethodInfoPtr_Get_Private_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniData>.NativeClassPtr, 100679614);
		NativeMethodInfoPtr_GetString_Public_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniData>.NativeClassPtr, 100679615);
		NativeMethodInfoPtr_GetString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniData>.NativeClassPtr, 100679616);
		NativeMethodInfoPtr_GetString_Public_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniData>.NativeClassPtr, 100679617);
		NativeMethodInfoPtr_GetFloat_Public_Single_String_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniData>.NativeClassPtr, 100679618);
		NativeMethodInfoPtr_GetFloat_Public_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniData>.NativeClassPtr, 100679619);
		NativeMethodInfoPtr_GetFloat_Public_Single_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniData>.NativeClassPtr, 100679620);
		NativeMethodInfoPtr_GetInt_Public_Int32_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniData>.NativeClassPtr, 100679621);
		NativeMethodInfoPtr_GetInt_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniData>.NativeClassPtr, 100679622);
		NativeMethodInfoPtr_GetInt_Public_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniData>.NativeClassPtr, 100679623);
		NativeMethodInfoPtr_GetBool_Public_Boolean_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniData>.NativeClassPtr, 100679624);
		NativeMethodInfoPtr_GetBool_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniData>.NativeClassPtr, 100679625);
		NativeMethodInfoPtr_GetBool_Public_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniData>.NativeClassPtr, 100679626);
		NativeMethodInfoPtr_GetColor_Public_Color_String_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniData>.NativeClassPtr, 100679627);
		NativeMethodInfoPtr_GetColor_Public_Color_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniData>.NativeClassPtr, 100679628);
		NativeMethodInfoPtr_GetColor_Public_Color_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniData>.NativeClassPtr, 100679629);
		NativeMethodInfoPtr_GetVector2_Public_Vector2_String_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniData>.NativeClassPtr, 100679630);
		NativeMethodInfoPtr_GetVector2_Public_Vector2_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniData>.NativeClassPtr, 100679631);
		NativeMethodInfoPtr_GetVector2_Public_Vector2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniData>.NativeClassPtr, 100679632);
		NativeMethodInfoPtr_GetVector3_Public_Vector3_String_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniData>.NativeClassPtr, 100679633);
		NativeMethodInfoPtr_GetVector3WithZeroDefault_Public_Vector3_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniData>.NativeClassPtr, 100679634);
		NativeMethodInfoPtr_GetVector3_Public_Vector3_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniData>.NativeClassPtr, 100679635);
		NativeMethodInfoPtr_GetVector3_Public_Vector3_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniData>.NativeClassPtr, 100679636);
		NativeMethodInfoPtr_GetQuaternion_Public_Quaternion_String_String_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniData>.NativeClassPtr, 100679637);
		NativeMethodInfoPtr_GetQuaternion_Public_Quaternion_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniData>.NativeClassPtr, 100679638);
		NativeMethodInfoPtr_GetQuaternion_Public_Quaternion_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IniData>.NativeClassPtr, 100679639);
	}

	public IniData(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
