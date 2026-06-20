using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using VehiclePhysics;

public class VPDynamicSuspension : VehicleBehaviour
{
	public class SuspensionData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_wheelState;

		private static readonly System.IntPtr NativeFieldInfoPtr_wheelCol;

		private static readonly System.IntPtr NativeFieldInfoPtr_ratio;

		private static readonly System.IntPtr NativeFieldInfoPtr_springRate;

		private static readonly System.IntPtr NativeFieldInfoPtr_targetSpringRate;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SuspensionData>.NativeClassPtr));

		public unsafe VehicleBase.WheelState wheelState
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelState);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new VehicleBase.WheelState(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelState), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe VPWheelCollider wheelCol
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelCol);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new VPWheelCollider(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelCol), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe float ratio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ratio);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ratio)) = num;
			}
		}

		public unsafe float springRate
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_springRate);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_springRate)) = num;
			}
		}

		public unsafe float targetSpringRate
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetSpringRate);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetSpringRate)) = num;
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe SuspensionData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SuspensionData>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static SuspensionData()
		{
			Il2CppClassPointerStore<SuspensionData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPDynamicSuspension>.NativeClassPtr, "SuspensionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SuspensionData>.NativeClassPtr);
			NativeFieldInfoPtr_wheelState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuspensionData>.NativeClassPtr, "wheelState");
			NativeFieldInfoPtr_wheelCol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuspensionData>.NativeClassPtr, "wheelCol");
			NativeFieldInfoPtr_ratio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuspensionData>.NativeClassPtr, "ratio");
			NativeFieldInfoPtr_springRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuspensionData>.NativeClassPtr, "springRate");
			NativeFieldInfoPtr_targetSpringRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuspensionData>.NativeClassPtr, "targetSpringRate");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SuspensionData>.NativeClassPtr, 100670579);
		}

		public SuspensionData(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_axles;

	private static readonly System.IntPtr NativeFieldInfoPtr_suspensionDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetCompression;

	private static readonly System.IntPtr NativeFieldInfoPtr_changeRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_ignoreEngineState;

	private static readonly System.IntPtr NativeFieldInfoPtr_minSpringRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxSpringRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_fastUpdateInterval;

	private static readonly System.IntPtr NativeFieldInfoPtr_slowUpdateInterval;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_sumForce;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_numValues;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_lastAdjustTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_suspension;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableSuspensionUpdates;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUpdateOrder_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVehicleSuspension_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AdjustNow_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddWheel_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AdjustSuspension_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPDynamicSuspension>.NativeClassPtr));

	public unsafe Il2CppStructArray<int> axles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_axles);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<int>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_axles), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float suspensionDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspensionDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspensionDistance)) = num;
		}
	}

	public unsafe float targetCompression
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetCompression);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetCompression)) = num;
		}
	}

	public unsafe float changeRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeRate)) = num;
		}
	}

	public unsafe bool ignoreEngineState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignoreEngineState);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignoreEngineState)) = flag;
		}
	}

	public unsafe float minSpringRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSpringRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSpringRate)) = num;
		}
	}

	public unsafe float maxSpringRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSpringRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSpringRate)) = num;
		}
	}

	public unsafe float fastUpdateInterval
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastUpdateInterval);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastUpdateInterval)) = num;
		}
	}

	public unsafe float slowUpdateInterval
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slowUpdateInterval);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slowUpdateInterval)) = num;
		}
	}

	public unsafe float m_sumForce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sumForce);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sumForce)) = num;
		}
	}

	public unsafe int m_numValues
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_numValues);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_numValues)) = num;
		}
	}

	public unsafe float m_lastAdjustTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastAdjustTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastAdjustTime)) = num;
		}
	}

	public unsafe List<SuspensionData> m_suspension
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_suspension);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<SuspensionData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_suspension), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool disableSuspensionUpdates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableSuspensionUpdates);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableSuspensionUpdates)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115441, XrefRangeEnd = 115450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnEnableVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe int GetUpdateOrder()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetUpdateOrder_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115450, XrefRangeEnd = 115454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void UpdateVehicleSuspension()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_UpdateVehicleSuspension_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115454, XrefRangeEnd = 115469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AdjustNow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdjustNow_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 115478, RefRangeEnd = 115480, XrefRangeStart = 115469, XrefRangeEnd = 115478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddWheel(int wheelIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&wheelIndex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddWheel_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115482, RefRangeEnd = 115483, XrefRangeStart = 115480, XrefRangeEnd = 115482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AdjustSuspension()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdjustSuspension_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115483, XrefRangeEnd = 115495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPDynamicSuspension()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPDynamicSuspension>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPDynamicSuspension()
	{
		Il2CppClassPointerStore<VPDynamicSuspension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPDynamicSuspension");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPDynamicSuspension>.NativeClassPtr);
		NativeFieldInfoPtr_axles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDynamicSuspension>.NativeClassPtr, "axles");
		NativeFieldInfoPtr_suspensionDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDynamicSuspension>.NativeClassPtr, "suspensionDistance");
		NativeFieldInfoPtr_targetCompression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDynamicSuspension>.NativeClassPtr, "targetCompression");
		NativeFieldInfoPtr_changeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDynamicSuspension>.NativeClassPtr, "changeRate");
		NativeFieldInfoPtr_ignoreEngineState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDynamicSuspension>.NativeClassPtr, "ignoreEngineState");
		NativeFieldInfoPtr_minSpringRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDynamicSuspension>.NativeClassPtr, "minSpringRate");
		NativeFieldInfoPtr_maxSpringRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDynamicSuspension>.NativeClassPtr, "maxSpringRate");
		NativeFieldInfoPtr_fastUpdateInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDynamicSuspension>.NativeClassPtr, "fastUpdateInterval");
		NativeFieldInfoPtr_slowUpdateInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDynamicSuspension>.NativeClassPtr, "slowUpdateInterval");
		NativeFieldInfoPtr_m_sumForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDynamicSuspension>.NativeClassPtr, "m_sumForce");
		NativeFieldInfoPtr_m_numValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDynamicSuspension>.NativeClassPtr, "m_numValues");
		NativeFieldInfoPtr_m_lastAdjustTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDynamicSuspension>.NativeClassPtr, "m_lastAdjustTime");
		NativeFieldInfoPtr_m_suspension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDynamicSuspension>.NativeClassPtr, "m_suspension");
		NativeFieldInfoPtr_disableSuspensionUpdates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPDynamicSuspension>.NativeClassPtr, "disableSuspensionUpdates");
		NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDynamicSuspension>.NativeClassPtr, 100670572);
		NativeMethodInfoPtr_GetUpdateOrder_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDynamicSuspension>.NativeClassPtr, 100670573);
		NativeMethodInfoPtr_UpdateVehicleSuspension_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDynamicSuspension>.NativeClassPtr, 100670574);
		NativeMethodInfoPtr_AdjustNow_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDynamicSuspension>.NativeClassPtr, 100670575);
		NativeMethodInfoPtr_AddWheel_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDynamicSuspension>.NativeClassPtr, 100670576);
		NativeMethodInfoPtr_AdjustSuspension_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDynamicSuspension>.NativeClassPtr, 100670577);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPDynamicSuspension>.NativeClassPtr, 100670578);
	}

	public VPDynamicSuspension(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
