using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class Junk : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ItemsInTrash;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSpecialCase_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSpecialMap_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddRandomItems_Public_Void_byref_List_1_String_byref_List_1_PartProperty_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddGoodItems_Private_Void_byref_List_1_String_byref_List_1_PartProperty_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBadItem_Private_Void_byref_List_1_PartProperty_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Junk>.NativeClassPtr));

	public unsafe List<BaseItem> ItemsInTrash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemsInTrash);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<BaseItem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemsInTrash), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 60543, RefRangeEnd = 60544, XrefRangeStart = 60523, XrefRangeEnd = 60543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddSpecialCase()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSpecialCase_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60544, XrefRangeEnd = 60564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddSpecialMap()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSpecialMap_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 60612, RefRangeEnd = 60614, XrefRangeStart = 60564, XrefRangeEnd = 60612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddRandomItems(ref List<string> cachedList, ref List<PartProperty> cachedPartPropertyList, float conditionFrom, float conditionTo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(cachedList);
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(cachedPartPropertyList);
		*(System.IntPtr**)num = &intPtr2;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &conditionFrom;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &conditionTo;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddRandomItems_Public_Void_byref_List_1_String_byref_List_1_PartProperty_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr4 = intPtr;
		cachedList = (List<string>)(object)((intPtr4 == (System.IntPtr)0) ? null : new List<T>(intPtr4));
		System.IntPtr intPtr5 = intPtr2;
		cachedPartPropertyList = (List<PartProperty>)(object)((intPtr5 == (System.IntPtr)0) ? null : new List<T>(intPtr5));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 60652, RefRangeEnd = 60653, XrefRangeStart = 60614, XrefRangeEnd = 60652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddGoodItems(ref List<string> cachedList, ref List<PartProperty> cachedPartPropertyList, float condition, bool barn)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(cachedList);
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(cachedPartPropertyList);
		*(System.IntPtr**)num = &intPtr2;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &condition;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &barn;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddGoodItems_Private_Void_byref_List_1_String_byref_List_1_PartProperty_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr4 = intPtr;
		cachedList = (List<string>)(object)((intPtr4 == (System.IntPtr)0) ? null : new List<T>(intPtr4));
		System.IntPtr intPtr5 = intPtr2;
		cachedPartPropertyList = (List<PartProperty>)(object)((intPtr5 == (System.IntPtr)0) ? null : new List<T>(intPtr5));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 60686, RefRangeEnd = 60687, XrefRangeStart = 60653, XrefRangeEnd = 60686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddBadItem(ref List<PartProperty> cachedPartPropertyList, float condition, bool barn)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(cachedPartPropertyList);
		*ptr = (nint)(&intPtr);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &condition;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &barn;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBadItem_Private_Void_byref_List_1_PartProperty_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		cachedPartPropertyList = (List<PartProperty>)(object)((intPtr3 == (System.IntPtr)0) ? null : new List<T>(intPtr3));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60687, XrefRangeEnd = 60696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Junk()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Junk>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Junk()
	{
		Il2CppClassPointerStore<Junk>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "Junk");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Junk>.NativeClassPtr);
		NativeFieldInfoPtr_ItemsInTrash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Junk>.NativeClassPtr, "ItemsInTrash");
		NativeMethodInfoPtr_AddSpecialCase_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Junk>.NativeClassPtr, 100666928);
		NativeMethodInfoPtr_AddSpecialMap_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Junk>.NativeClassPtr, 100666929);
		NativeMethodInfoPtr_AddRandomItems_Public_Void_byref_List_1_String_byref_List_1_PartProperty_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Junk>.NativeClassPtr, 100666930);
		NativeMethodInfoPtr_AddGoodItems_Private_Void_byref_List_1_String_byref_List_1_PartProperty_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Junk>.NativeClassPtr, 100666931);
		NativeMethodInfoPtr_AddBadItem_Private_Void_byref_List_1_PartProperty_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Junk>.NativeClassPtr, 100666932);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Junk>.NativeClassPtr, 100666933);
	}

	public Junk(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
