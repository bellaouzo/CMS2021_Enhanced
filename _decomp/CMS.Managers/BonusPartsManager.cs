using System;
using System.Runtime.CompilerServices;
using CMS.Containers.BonusParts;
using INI;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.Managers;

[System.Serializable]
public class BonusPartsManager : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_bonusPartsData;

	private static readonly System.IntPtr NativeFieldInfoPtr_ListOfThumbnails;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBonusPart_Public_Void_String_INIContent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBonusPartsToPartPropertyList_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBonusPart_Public_GameObject_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryDeleteBonusParts_Public_Void_CarLoader_List_1_BonusPart_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryDeleteBonusPart_Public_Void_CarLoader_BonusPart_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckCanDelete_Private_Boolean_CarLoader_BonusPart_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BonusPartsManager>.NativeClassPtr));

	public unsafe List<BonusPartData> bonusPartsData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bonusPartsData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<BonusPartData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bonusPartsData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<string, Sprite> ListOfThumbnails
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListOfThumbnails);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Dictionary<string, Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListOfThumbnails), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 140488, RefRangeEnd = 140489, XrefRangeStart = 140414, XrefRangeEnd = 140488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddBonusPart(string directory, INIContent ini)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(directory);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(ini);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBonusPart_Public_Void_String_INIContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 140511, RefRangeEnd = 140512, XrefRangeStart = 140489, XrefRangeEnd = 140511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddBonusPartsToPartPropertyList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBonusPartsToPartPropertyList_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 140544, RefRangeEnd = 140547, XrefRangeStart = 140512, XrefRangeEnd = 140544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject GetBonusPart(string id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBonusPart_Public_GameObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140547, XrefRangeEnd = 140551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TryDeleteBonusParts(CarLoader carLoader, List<BonusPart> bonusParts, bool deleteCar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bonusParts);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &deleteCar;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryDeleteBonusParts_Public_Void_CarLoader_List_1_BonusPart_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 140569, RefRangeEnd = 140572, XrefRangeStart = 140551, XrefRangeEnd = 140569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TryDeleteBonusPart(CarLoader carLoader, BonusPart bonusPart, bool deleteCar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bonusPart);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &deleteCar;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryDeleteBonusPart_Public_Void_CarLoader_BonusPart_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 140606, RefRangeEnd = 140607, XrefRangeStart = 140572, XrefRangeEnd = 140606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckCanDelete(CarLoader currentCarLoader, BonusPart bonusPartToDelete, bool deleteCar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentCarLoader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bonusPartToDelete);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &deleteCar;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckCanDelete_Private_Boolean_CarLoader_BonusPart_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140607, XrefRangeEnd = 140617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BonusPartsManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BonusPartsManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static BonusPartsManager()
	{
		Il2CppClassPointerStore<BonusPartsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Managers", "BonusPartsManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BonusPartsManager>.NativeClassPtr);
		NativeFieldInfoPtr_bonusPartsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonusPartsManager>.NativeClassPtr, "bonusPartsData");
		NativeFieldInfoPtr_ListOfThumbnails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonusPartsManager>.NativeClassPtr, "ListOfThumbnails");
		NativeMethodInfoPtr_AddBonusPart_Public_Void_String_INIContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BonusPartsManager>.NativeClassPtr, 100672782);
		NativeMethodInfoPtr_AddBonusPartsToPartPropertyList_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BonusPartsManager>.NativeClassPtr, 100672783);
		NativeMethodInfoPtr_GetBonusPart_Public_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BonusPartsManager>.NativeClassPtr, 100672784);
		NativeMethodInfoPtr_TryDeleteBonusParts_Public_Void_CarLoader_List_1_BonusPart_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BonusPartsManager>.NativeClassPtr, 100672785);
		NativeMethodInfoPtr_TryDeleteBonusPart_Public_Void_CarLoader_BonusPart_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BonusPartsManager>.NativeClassPtr, 100672786);
		NativeMethodInfoPtr_CheckCanDelete_Private_Boolean_CarLoader_BonusPart_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BonusPartsManager>.NativeClassPtr, 100672787);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BonusPartsManager>.NativeClassPtr, 100672788);
	}

	public BonusPartsManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
