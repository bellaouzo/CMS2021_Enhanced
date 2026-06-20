using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using VehiclePhysics;

public class VPVisualEffects2 : VehicleBehaviour
{
	[ObfuscatedName("VPVisualEffects2/<>c__DisplayClass21_0")]
	public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_mat;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_Single_PDM_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass21_0>.NativeClassPtr));

		public unsafe Material mat
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mat);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Material(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mat), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass21_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass21_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116369, XrefRangeEnd = 116378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Internal_Void_Single_PDM_0(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&val);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Void_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass21_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr, "<>c__DisplayClass21_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass21_0>.NativeClassPtr);
			NativeFieldInfoPtr_mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass21_0>.NativeClassPtr, "mat");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass21_0>.NativeClassPtr, 100670640);
			NativeMethodInfoPtr_Method_Internal_Void_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass21_0>.NativeClassPtr, 100670641);
		}

		public __c__DisplayClass21_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_steeringWheel;

	private static readonly System.IntPtr NativeFieldInfoPtr_degreesOfRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_rpmGauge;

	private static readonly System.IntPtr NativeFieldInfoPtr_rpmMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_rpmMinAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_rpmMaxAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_rpmMaxAngleUnderScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_rpmToScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_useWithScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_speedGauge;

	private static readonly System.IntPtr NativeFieldInfoPtr_speedMaxKph;

	private static readonly System.IntPtr NativeFieldInfoPtr_speedMinAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_speedMaxAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_model;

	private static readonly System.IntPtr NativeFieldInfoPtr_materials;

	private static readonly System.IntPtr NativeFieldInfoPtr_steerInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_speedMs;

	private static readonly System.IntPtr NativeFieldInfoPtr_engineRpm;

	private static readonly System.IntPtr NativeFieldInfoPtr_disabledColor;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMaterials_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBrakeLights_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AnimateLights_Private_Void_Material_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSteeringWheel_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSpeedGauge_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateRpmGauge_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr));

	public unsafe Transform steeringWheel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steeringWheel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steeringWheel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float degreesOfRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_degreesOfRotation);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_degreesOfRotation)) = num;
		}
	}

	public unsafe Transform rpmGauge
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmGauge);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmGauge), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float rpmMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmMax);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmMax)) = num;
		}
	}

	public unsafe float rpmMinAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmMinAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmMinAngle)) = num;
		}
	}

	public unsafe float rpmMaxAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmMaxAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmMaxAngle)) = num;
		}
	}

	public unsafe float rpmMaxAngleUnderScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmMaxAngleUnderScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmMaxAngleUnderScale)) = num;
		}
	}

	public unsafe float rpmToScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmToScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmToScale)) = num;
		}
	}

	public unsafe bool useWithScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useWithScale);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useWithScale)) = flag;
		}
	}

	public unsafe Transform speedGauge
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedGauge);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedGauge), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float speedMaxKph
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedMaxKph);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedMaxKph)) = num;
		}
	}

	public unsafe float speedMinAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedMinAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedMinAngle)) = num;
		}
	}

	public unsafe float speedMaxAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedMaxAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedMaxAngle)) = num;
		}
	}

	public unsafe GameObject model
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_model);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_model), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<Material> materials
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materials);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materials), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InterpolatedFloat steerInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steerInput);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InterpolatedFloat(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steerInput), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InterpolatedFloat speedMs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedMs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InterpolatedFloat(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedMs), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InterpolatedFloat engineRpm
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineRpm);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InterpolatedFloat(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineRpm), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Color disabledColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disabledColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disabledColor)) = color;
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 116460, RefRangeEnd = 116462, XrefRangeStart = 116378, XrefRangeEnd = 116460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateMaterials()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateMaterials_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 116477, RefRangeEnd = 116479, XrefRangeStart = 116462, XrefRangeEnd = 116477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBrakeLights(bool enable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBrakeLights_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116513, RefRangeEnd = 116514, XrefRangeStart = 116479, XrefRangeEnd = 116513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AnimateLights(Material mat, bool on)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &on;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AnimateLights_Private_Void_Material_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe void FixedUpdateVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116514, XrefRangeEnd = 116518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void UpdateVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_UpdateVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116535, RefRangeEnd = 116536, XrefRangeStart = 116518, XrefRangeEnd = 116535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSteeringWheel(float frameRatio)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&frameRatio);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateSteeringWheel_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116555, RefRangeEnd = 116556, XrefRangeStart = 116536, XrefRangeEnd = 116555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSpeedGauge(float frameRatio)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&frameRatio);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateSpeedGauge_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116579, RefRangeEnd = 116580, XrefRangeStart = 116556, XrefRangeEnd = 116579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateRpmGauge(float frameRatio)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&frameRatio);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateRpmGauge_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116580, XrefRangeEnd = 116590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPVisualEffects2()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPVisualEffects2()
	{
		Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPVisualEffects2");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr);
		NativeFieldInfoPtr_steeringWheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr, "steeringWheel");
		NativeFieldInfoPtr_degreesOfRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr, "degreesOfRotation");
		NativeFieldInfoPtr_rpmGauge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr, "rpmGauge");
		NativeFieldInfoPtr_rpmMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr, "rpmMax");
		NativeFieldInfoPtr_rpmMinAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr, "rpmMinAngle");
		NativeFieldInfoPtr_rpmMaxAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr, "rpmMaxAngle");
		NativeFieldInfoPtr_rpmMaxAngleUnderScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr, "rpmMaxAngleUnderScale");
		NativeFieldInfoPtr_rpmToScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr, "rpmToScale");
		NativeFieldInfoPtr_useWithScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr, "useWithScale");
		NativeFieldInfoPtr_speedGauge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr, "speedGauge");
		NativeFieldInfoPtr_speedMaxKph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr, "speedMaxKph");
		NativeFieldInfoPtr_speedMinAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr, "speedMinAngle");
		NativeFieldInfoPtr_speedMaxAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr, "speedMaxAngle");
		NativeFieldInfoPtr_model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr, "model");
		NativeFieldInfoPtr_materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr, "materials");
		NativeFieldInfoPtr_steerInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr, "steerInput");
		NativeFieldInfoPtr_speedMs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr, "speedMs");
		NativeFieldInfoPtr_engineRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr, "engineRpm");
		NativeFieldInfoPtr_disabledColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr, "disabledColor");
		NativeMethodInfoPtr_UpdateMaterials_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr, 100670631);
		NativeMethodInfoPtr_SetBrakeLights_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr, 100670632);
		NativeMethodInfoPtr_AnimateLights_Private_Void_Material_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr, 100670633);
		NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr, 100670634);
		NativeMethodInfoPtr_UpdateVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr, 100670635);
		NativeMethodInfoPtr_UpdateSteeringWheel_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr, 100670636);
		NativeMethodInfoPtr_UpdateSpeedGauge_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr, 100670637);
		NativeMethodInfoPtr_UpdateRpmGauge_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr, 100670638);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVisualEffects2>.NativeClassPtr, 100670639);
	}

	public VPVisualEffects2(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
