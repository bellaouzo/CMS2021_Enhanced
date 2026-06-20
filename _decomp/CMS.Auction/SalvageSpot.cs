using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.Auction;

public class SalvageSpot : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_playerPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_carPosition;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerPosition_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerRotation_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CarPosition_Public_get_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SalvageSpot>.NativeClassPtr));

	public unsafe Transform playerPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerPosition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerPosition), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform carPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carPosition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carPosition), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector3 PlayerPosition
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218609, XrefRangeEnd = 218611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe Vector3 PlayerRotation
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218611, XrefRangeEnd = 218614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerRotation_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe Transform CarPosition
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CarPosition_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe SalvageSpot()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SalvageSpot>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SalvageSpot()
	{
		Il2CppClassPointerStore<SalvageSpot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Auction", "SalvageSpot");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SalvageSpot>.NativeClassPtr);
		NativeFieldInfoPtr_playerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvageSpot>.NativeClassPtr, "playerPosition");
		NativeFieldInfoPtr_carPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalvageSpot>.NativeClassPtr, "carPosition");
		NativeMethodInfoPtr_get_PlayerPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SalvageSpot>.NativeClassPtr, 100679850);
		NativeMethodInfoPtr_get_PlayerRotation_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SalvageSpot>.NativeClassPtr, 100679851);
		NativeMethodInfoPtr_get_CarPosition_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SalvageSpot>.NativeClassPtr, 100679852);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SalvageSpot>.NativeClassPtr, 100679853);
	}

	public SalvageSpot(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
