using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using VehiclePhysics;

public class VPTireEffects : VehicleBehaviour
{
	public class TireFxData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_lastRenderer;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastMarksIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_marksDelta;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastEmitter;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastParticleTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_slipTime;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TireFxData>.NativeClassPtr));

		public unsafe VPGroundMarksRenderer lastRenderer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastRenderer);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new VPGroundMarksRenderer(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastRenderer), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe int lastMarksIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastMarksIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastMarksIndex)) = num;
			}
		}

		public unsafe float marksDelta
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_marksDelta);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_marksDelta)) = num;
			}
		}

		public unsafe VPGroundParticleEmitter lastEmitter
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastEmitter);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new VPGroundParticleEmitter(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastEmitter), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe float lastParticleTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastParticleTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastParticleTime)) = num;
			}
		}

		public unsafe float slipTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slipTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slipTime)) = num;
			}
		}

		[CallerCount(0)]
		public unsafe TireFxData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TireFxData>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static TireFxData()
		{
			Il2CppClassPointerStore<TireFxData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPTireEffects>.NativeClassPtr, "TireFxData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TireFxData>.NativeClassPtr);
			NativeFieldInfoPtr_lastRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TireFxData>.NativeClassPtr, "lastRenderer");
			NativeFieldInfoPtr_lastMarksIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TireFxData>.NativeClassPtr, "lastMarksIndex");
			NativeFieldInfoPtr_marksDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TireFxData>.NativeClassPtr, "marksDelta");
			NativeFieldInfoPtr_lastEmitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TireFxData>.NativeClassPtr, "lastEmitter");
			NativeFieldInfoPtr_lastParticleTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TireFxData>.NativeClassPtr, "lastParticleTime");
			NativeFieldInfoPtr_slipTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TireFxData>.NativeClassPtr, "slipTime");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TireFxData>.NativeClassPtr, 100670603);
		}

		public TireFxData(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_tireWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_minSlip;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxSlip;

	private static readonly System.IntPtr NativeFieldInfoPtr_intensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_updateInterval;

	private static readonly System.IntPtr NativeFieldInfoPtr_minIntensityTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxIntensityTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitIntensityTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_tireData;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnReposition_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTireMarks_Private_Void_WheelState_TireFxData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTireParticles_Private_Void_WheelState_TireFxData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPTireEffects>.NativeClassPtr));

	public unsafe float tireWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tireWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tireWidth)) = num;
		}
	}

	public unsafe float minSlip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSlip);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSlip)) = num;
		}
	}

	public unsafe float maxSlip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSlip);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSlip)) = num;
		}
	}

	public unsafe float intensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intensity)) = num;
		}
	}

	public unsafe float updateInterval
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateInterval);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateInterval)) = num;
		}
	}

	public unsafe float minIntensityTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minIntensityTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minIntensityTime)) = num;
		}
	}

	public unsafe float maxIntensityTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxIntensityTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxIntensityTime)) = num;
		}
	}

	public unsafe float limitIntensityTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitIntensityTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitIntensityTime)) = num;
		}
	}

	public unsafe Il2CppReferenceArray<TireFxData> m_tireData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_tireData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<TireFxData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_tireData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115736, XrefRangeEnd = 115747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnEnableVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115747, XrefRangeEnd = 115749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void UpdateVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_UpdateVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe void OnReposition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnReposition_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115751, RefRangeEnd = 115752, XrefRangeStart = 115749, XrefRangeEnd = 115751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateTireMarks(VehicleBase.WheelState wheelState, TireFxData fxData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(wheelState);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(fxData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateTireMarks_Private_Void_WheelState_TireFxData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115797, RefRangeEnd = 115798, XrefRangeStart = 115752, XrefRangeEnd = 115797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateTireParticles(VehicleBase.WheelState wheelState, TireFxData fxData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(wheelState);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(fxData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateTireParticles_Private_Void_WheelState_TireFxData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115798, XrefRangeEnd = 115804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPTireEffects()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPTireEffects>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPTireEffects()
	{
		Il2CppClassPointerStore<VPTireEffects>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPTireEffects");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPTireEffects>.NativeClassPtr);
		NativeFieldInfoPtr_tireWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTireEffects>.NativeClassPtr, "tireWidth");
		NativeFieldInfoPtr_minSlip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTireEffects>.NativeClassPtr, "minSlip");
		NativeFieldInfoPtr_maxSlip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTireEffects>.NativeClassPtr, "maxSlip");
		NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTireEffects>.NativeClassPtr, "intensity");
		NativeFieldInfoPtr_updateInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTireEffects>.NativeClassPtr, "updateInterval");
		NativeFieldInfoPtr_minIntensityTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTireEffects>.NativeClassPtr, "minIntensityTime");
		NativeFieldInfoPtr_maxIntensityTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTireEffects>.NativeClassPtr, "maxIntensityTime");
		NativeFieldInfoPtr_limitIntensityTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTireEffects>.NativeClassPtr, "limitIntensityTime");
		NativeFieldInfoPtr_m_tireData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPTireEffects>.NativeClassPtr, "m_tireData");
		NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTireEffects>.NativeClassPtr, 100670597);
		NativeMethodInfoPtr_UpdateVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTireEffects>.NativeClassPtr, 100670598);
		NativeMethodInfoPtr_OnReposition_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTireEffects>.NativeClassPtr, 100670599);
		NativeMethodInfoPtr_UpdateTireMarks_Private_Void_WheelState_TireFxData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTireEffects>.NativeClassPtr, 100670600);
		NativeMethodInfoPtr_UpdateTireParticles_Private_Void_WheelState_TireFxData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTireEffects>.NativeClassPtr, 100670601);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPTireEffects>.NativeClassPtr, 100670602);
	}

	public VPTireEffects(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
