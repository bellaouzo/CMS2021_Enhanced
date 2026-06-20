using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class WheelBolts : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_boltPrefab;

	private static readonly System.IntPtr NativeFieldInfoPtr_depth;

	private static readonly System.IntPtr NativeFieldInfoPtr_angle;

	private static readonly System.IntPtr NativeFieldInfoPtr_radius;

	private static readonly System.IntPtr NativeFieldInfoPtr_boltsNumber;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_boltScaleMod;

	private static readonly System.IntPtr NativeFieldInfoPtr_boltsGO;

	private static readonly System.IntPtr NativeMethodInfoPtr_RepositionDepth_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBolts_Public_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBolts_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WheelBolts>.NativeClassPtr));

	public unsafe GameObject boltPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boltPrefab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boltPrefab), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float depth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_depth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_depth)) = num;
		}
	}

	public unsafe float angle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angle)) = num;
		}
	}

	public unsafe float radius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_radius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_radius)) = num;
		}
	}

	public unsafe int boltsNumber
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boltsNumber);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boltsNumber)) = num;
		}
	}

	public unsafe float startingAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingAngle)) = num;
		}
	}

	public unsafe float boltScaleMod
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boltScaleMod);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boltScaleMod)) = num;
		}
	}

	public unsafe GameObject boltsGO
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boltsGO);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boltsGO), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 89497, RefRangeEnd = 89501, XrefRangeStart = 89462, XrefRangeEnd = 89497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RepositionDepth()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RepositionDepth_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(70)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe GameObject GetBolts()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBolts_Public_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89501, XrefRangeEnd = 89613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddBolts()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBolts_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89613, XrefRangeEnd = 89616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WheelBolts()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WheelBolts>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static WheelBolts()
	{
		Il2CppClassPointerStore<WheelBolts>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "WheelBolts");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WheelBolts>.NativeClassPtr);
		NativeFieldInfoPtr_boltPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelBolts>.NativeClassPtr, "boltPrefab");
		NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelBolts>.NativeClassPtr, "depth");
		NativeFieldInfoPtr_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelBolts>.NativeClassPtr, "angle");
		NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelBolts>.NativeClassPtr, "radius");
		NativeFieldInfoPtr_boltsNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelBolts>.NativeClassPtr, "boltsNumber");
		NativeFieldInfoPtr_startingAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelBolts>.NativeClassPtr, "startingAngle");
		NativeFieldInfoPtr_boltScaleMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelBolts>.NativeClassPtr, "boltScaleMod");
		NativeFieldInfoPtr_boltsGO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelBolts>.NativeClassPtr, "boltsGO");
		NativeMethodInfoPtr_RepositionDepth_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBolts>.NativeClassPtr, 100668430);
		NativeMethodInfoPtr_GetBolts_Public_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBolts>.NativeClassPtr, 100668431);
		NativeMethodInfoPtr_AddBolts_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBolts>.NativeClassPtr, 100668432);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBolts>.NativeClassPtr, 100668433);
	}

	public WheelBolts(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
