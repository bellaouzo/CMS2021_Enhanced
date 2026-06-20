using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using VehiclePhysics;

public class VPAeroSurface : VehicleBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_dragCoefficient;

	private static readonly System.IntPtr NativeFieldInfoPtr_downforceCoefficient;

	private static readonly System.IntPtr NativeFieldInfoPtr_showDebugLabel;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPAeroSurface>.NativeClassPtr));

	public unsafe float dragCoefficient
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dragCoefficient);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dragCoefficient)) = num;
		}
	}

	public unsafe float downforceCoefficient
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downforceCoefficient);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downforceCoefficient)) = num;
		}
	}

	public unsafe bool showDebugLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showDebugLabel);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showDebugLabel)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109996, XrefRangeEnd = 110019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void FixedUpdateVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110019, XrefRangeEnd = 110022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPAeroSurface()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPAeroSurface>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPAeroSurface()
	{
		Il2CppClassPointerStore<VPAeroSurface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPAeroSurface");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPAeroSurface>.NativeClassPtr);
		NativeFieldInfoPtr_dragCoefficient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAeroSurface>.NativeClassPtr, "dragCoefficient");
		NativeFieldInfoPtr_downforceCoefficient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAeroSurface>.NativeClassPtr, "downforceCoefficient");
		NativeFieldInfoPtr_showDebugLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPAeroSurface>.NativeClassPtr, "showDebugLabel");
		NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPAeroSurface>.NativeClassPtr, 100670253);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPAeroSurface>.NativeClassPtr, 100670254);
	}

	public VPAeroSurface(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
