using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Containers.BonusParts;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class CarBonusPartsData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_BonusPartsIds;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HaveBonusParts_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNewPartId_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIdsToString_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarBonusPartsData>.NativeClassPtr));

	public unsafe List<int> BonusPartsIds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BonusPartsIds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<int>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BonusPartsIds), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool HaveBonusParts
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218560, XrefRangeEnd = 218561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HaveBonusParts_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218561, XrefRangeEnd = 218563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetNewPartId()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNewPartId_Public_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 218578, RefRangeEnd = 218579, XrefRangeStart = 218563, XrefRangeEnd = 218578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetIdsToString()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIdsToString_Public_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 218583, RefRangeEnd = 218584, XrefRangeStart = 218579, XrefRangeEnd = 218583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CarBonusPartsData()
	{
		Il2CppClassPointerStore<CarBonusPartsData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers.BonusParts", "CarBonusPartsData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarBonusPartsData>.NativeClassPtr);
		NativeFieldInfoPtr_BonusPartsIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarBonusPartsData>.NativeClassPtr, "BonusPartsIds");
		NativeMethodInfoPtr_get_HaveBonusParts_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBonusPartsData>.NativeClassPtr, 100679832);
		NativeMethodInfoPtr_GetNewPartId_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBonusPartsData>.NativeClassPtr, 100679833);
		NativeMethodInfoPtr_GetIdsToString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBonusPartsData>.NativeClassPtr, 100679834);
		NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBonusPartsData>.NativeClassPtr, 100679835);
	}

	public CarBonusPartsData(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe CarBonusPartsData()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CarBonusPartsData>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<CarBonusPartsData>.NativeClassPtr))
	{
	}
}
