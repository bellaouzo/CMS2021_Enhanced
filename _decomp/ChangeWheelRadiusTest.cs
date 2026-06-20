using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using VehiclePhysics;

public class ChangeWheelRadiusTest : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_axle;

	private static readonly System.IntPtr NativeFieldInfoPtr_pos;

	private static readonly System.IntPtr NativeFieldInfoPtr_newRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_vehicle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_wheelIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_originalRadius;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ChangeWheelRadiusTest>.NativeClassPtr));

	public unsafe int axle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_axle);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_axle)) = num;
		}
	}

	public unsafe VehicleBase.WheelPos pos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos);
			return *(VehicleBase.WheelPos*)num;
		}
		set
		{
			*(VehicleBase.WheelPos*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos)) = wheelPos;
		}
	}

	public unsafe float newRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newRadius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newRadius)) = num;
		}
	}

	public unsafe VehicleBase m_vehicle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_vehicle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VehicleBase(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_vehicle), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int m_wheelIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_wheelIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_wheelIndex)) = num;
		}
	}

	public unsafe float m_originalRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_originalRadius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_originalRadius)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117133, XrefRangeEnd = 117141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117141, XrefRangeEnd = 117143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117143, XrefRangeEnd = 117146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChangeWheelRadiusTest()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangeWheelRadiusTest>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ChangeWheelRadiusTest()
	{
		Il2CppClassPointerStore<ChangeWheelRadiusTest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "ChangeWheelRadiusTest");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeWheelRadiusTest>.NativeClassPtr);
		NativeFieldInfoPtr_axle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeWheelRadiusTest>.NativeClassPtr, "axle");
		NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeWheelRadiusTest>.NativeClassPtr, "pos");
		NativeFieldInfoPtr_newRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeWheelRadiusTest>.NativeClassPtr, "newRadius");
		NativeFieldInfoPtr_m_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeWheelRadiusTest>.NativeClassPtr, "m_vehicle");
		NativeFieldInfoPtr_m_wheelIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeWheelRadiusTest>.NativeClassPtr, "m_wheelIndex");
		NativeFieldInfoPtr_m_originalRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeWheelRadiusTest>.NativeClassPtr, "m_originalRadius");
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeWheelRadiusTest>.NativeClassPtr, 100670700);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeWheelRadiusTest>.NativeClassPtr, 100670701);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeWheelRadiusTest>.NativeClassPtr, 100670702);
	}

	public ChangeWheelRadiusTest(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
