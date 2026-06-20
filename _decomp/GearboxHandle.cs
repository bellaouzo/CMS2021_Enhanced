using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class GearboxHandle : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_gearRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_finalDriveRatio;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetThumbName_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGearsAmount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGearRatios_Public_ArrayOf_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGearsFinalRatio_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOriginalGearRatios_Public_ArrayOf_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOriginalFinalRatio_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGearChangeTime_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GearboxHandle>.NativeClassPtr));

	public unsafe Il2CppStructArray<float> gearRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearRatio);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearRatio), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float finalDriveRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finalDriveRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finalDriveRatio)) = num;
		}
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 51380, RefRangeEnd = 51394, XrefRangeStart = 51360, XrefRangeEnd = 51380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51394, XrefRangeEnd = 51410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetThumbName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetThumbName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51410, XrefRangeEnd = 51413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetGearsAmount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGearsAmount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51413, XrefRangeEnd = 51416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<float> GetGearRatios()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGearRatios_Public_ArrayOf_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 51417, RefRangeEnd = 51421, XrefRangeStart = 51416, XrefRangeEnd = 51417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetGearsFinalRatio()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGearsFinalRatio_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51421, XrefRangeEnd = 51425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<float> GetOriginalGearRatios()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOriginalGearRatios_Public_ArrayOf_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51425, XrefRangeEnd = 51431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetOriginalFinalRatio()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOriginalFinalRatio_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 51432, RefRangeEnd = 51433, XrefRangeStart = 51431, XrefRangeEnd = 51432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetGearChangeTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGearChangeTime_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe GearboxHandle()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GearboxHandle>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static GearboxHandle()
	{
		Il2CppClassPointerStore<GearboxHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GearboxHandle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GearboxHandle>.NativeClassPtr);
		NativeFieldInfoPtr_gearRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GearboxHandle>.NativeClassPtr, "gearRatio");
		NativeFieldInfoPtr_finalDriveRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GearboxHandle>.NativeClassPtr, "finalDriveRatio");
		NativeMethodInfoPtr_GetName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GearboxHandle>.NativeClassPtr, 100666313);
		NativeMethodInfoPtr_GetThumbName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GearboxHandle>.NativeClassPtr, 100666314);
		NativeMethodInfoPtr_GetGearsAmount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GearboxHandle>.NativeClassPtr, 100666315);
		NativeMethodInfoPtr_GetGearRatios_Public_ArrayOf_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GearboxHandle>.NativeClassPtr, 100666316);
		NativeMethodInfoPtr_GetGearsFinalRatio_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GearboxHandle>.NativeClassPtr, 100666317);
		NativeMethodInfoPtr_GetOriginalGearRatios_Public_ArrayOf_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GearboxHandle>.NativeClassPtr, 100666318);
		NativeMethodInfoPtr_GetOriginalFinalRatio_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GearboxHandle>.NativeClassPtr, 100666319);
		NativeMethodInfoPtr_GetGearChangeTime_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GearboxHandle>.NativeClassPtr, 100666320);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GearboxHandle>.NativeClassPtr, 100666321);
	}

	public GearboxHandle(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
