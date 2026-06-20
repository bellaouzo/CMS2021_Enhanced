using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using VehiclePhysics;

public class VPRollingFriction : VehicleBehaviour
{
	public enum Model
	{
		Constant,
		Linear,
		Quadratic,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Model>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static Model()
		{
			Il2CppClassPointerStore<Model>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPRollingFriction>.NativeClassPtr, "Model");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_model;

	private static readonly System.IntPtr NativeFieldInfoPtr_coefficient;

	private static readonly System.IntPtr NativeFieldInfoPtr_showDebugLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr_frictionFactors;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyRollingFriction_Private_Void_WheelState_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPRollingFriction>.NativeClassPtr));

	public unsafe Model model
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_model);
			return *(Model*)num;
		}
		set
		{
			*(Model*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_model)) = model;
		}
	}

	public unsafe float coefficient
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coefficient);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coefficient)) = num;
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

	public unsafe Il2CppStructArray<float> frictionFactors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frictionFactors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frictionFactors), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110394, XrefRangeEnd = 110402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void FixedUpdateVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110402, XrefRangeEnd = 110408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyRollingFriction(VehicleBase.WheelState ws, float factor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ws);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &factor;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyRollingFriction_Private_Void_WheelState_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110408, XrefRangeEnd = 110414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPRollingFriction()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPRollingFriction>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPRollingFriction()
	{
		Il2CppClassPointerStore<VPRollingFriction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPRollingFriction");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPRollingFriction>.NativeClassPtr);
		NativeFieldInfoPtr_model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPRollingFriction>.NativeClassPtr, "model");
		NativeFieldInfoPtr_coefficient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPRollingFriction>.NativeClassPtr, "coefficient");
		NativeFieldInfoPtr_showDebugLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPRollingFriction>.NativeClassPtr, "showDebugLabel");
		NativeFieldInfoPtr_frictionFactors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPRollingFriction>.NativeClassPtr, "frictionFactors");
		NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPRollingFriction>.NativeClassPtr, 100670272);
		NativeMethodInfoPtr_ApplyRollingFriction_Private_Void_WheelState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPRollingFriction>.NativeClassPtr, 100670273);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPRollingFriction>.NativeClassPtr, 100670274);
	}

	public VPRollingFriction(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
