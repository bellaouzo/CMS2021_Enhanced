using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VehiclePhysics;

public class Steering : Il2CppSystem.Object
{
	public enum SteeringMode
	{
		Disabled,
		Steerable,
		Ratio,
		Reference,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SteeringMode>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static SteeringMode()
		{
			Il2CppClassPointerStore<SteeringMode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Steering>.NativeClassPtr, "SteeringMode");
		}

	}

	[System.Serializable]
	public class Settings : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_maxSteerAngle;

		private static readonly System.IntPtr NativeFieldInfoPtr_toeAngle;

		private static readonly System.IntPtr NativeFieldInfoPtr_ackerman;

		private static readonly System.IntPtr NativeFieldInfoPtr_ackermanReference;

		private static readonly System.IntPtr NativeFieldInfoPtr_ratioReference;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Settings>.NativeClassPtr));

		public unsafe float maxSteerAngle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSteerAngle);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSteerAngle)) = num;
			}
		}

		public unsafe float toeAngle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toeAngle);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toeAngle)) = num;
			}
		}

		public unsafe bool ackerman
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ackerman);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ackerman)) = flag;
			}
		}

		public unsafe Transform ackermanReference
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ackermanReference);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ackermanReference), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Transform ratioReference
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ratioReference);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ratioReference), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(0)]
		public unsafe Settings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Settings>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static Settings()
		{
			Il2CppClassPointerStore<Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Steering>.NativeClassPtr, "Settings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Settings>.NativeClassPtr);
			NativeFieldInfoPtr_maxSteerAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "maxSteerAngle");
			NativeFieldInfoPtr_toeAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "toeAngle");
			NativeFieldInfoPtr_ackerman = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "ackerman");
			NativeFieldInfoPtr_ackermanReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "ackermanReference");
			NativeFieldInfoPtr_ratioReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "ratioReference");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100671626);
		}

		public Settings(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	public class WheelData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_wheelState;

		private static readonly System.IntPtr NativeFieldInfoPtr_position;

		private static readonly System.IntPtr NativeFieldInfoPtr_mode;

		private static readonly System.IntPtr NativeFieldInfoPtr_ratio;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WheelData>.NativeClassPtr));

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

		public unsafe Vector3 position
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_position);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_position)) = vector;
			}
		}

		public unsafe SteeringMode mode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode);
				return *(SteeringMode*)num;
			}
			set
			{
				*(SteeringMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode)) = steeringMode;
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

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe WheelData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WheelData>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static WheelData()
		{
			Il2CppClassPointerStore<WheelData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Steering>.NativeClassPtr, "WheelData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WheelData>.NativeClassPtr);
			NativeFieldInfoPtr_wheelState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelData>.NativeClassPtr, "wheelState");
			NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelData>.NativeClassPtr, "position");
			NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelData>.NativeClassPtr, "mode");
			NativeFieldInfoPtr_ratio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelData>.NativeClassPtr, "ratio");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelData>.NativeClassPtr, 100671627);
		}

		public WheelData(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_steerInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_settings;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_wheels;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddWheel_Public_Void_WheelState_Vector3_SteeringMode_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddWheel_Public_Void_WheelState_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecalculateRelativeSteerRatios_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSteeringAngle_Private_Void_WheelData_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Steering>.NativeClassPtr));

	public unsafe float steerInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steerInput);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steerInput)) = num;
		}
	}

	public unsafe Settings settings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_settings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Settings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<WheelData> m_wheels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_wheels);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<WheelData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_wheels), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 125136, RefRangeEnd = 125138, XrefRangeStart = 125129, XrefRangeEnd = 125136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddWheel(VehicleBase.WheelState wheelState, Vector3 localPosition, SteeringMode steeringMode, [Optional] float steerRatio)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(wheelState);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &localPosition;
		*(SteeringMode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &steeringMode;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &steerRatio;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddWheel_Public_Void_WheelState_Vector3_SteeringMode_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125138, XrefRangeEnd = 125144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddWheel(VehicleBase.WheelState wheelState, Vector3 localPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(wheelState);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &localPosition;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddWheel_Public_Void_WheelState_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 125160, RefRangeEnd = 125161, XrefRangeStart = 125144, XrefRangeEnd = 125160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RecalculateRelativeSteerRatios()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecalculateRelativeSteerRatios_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 125180, RefRangeEnd = 125181, XrefRangeStart = 125161, XrefRangeEnd = 125180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125181, XrefRangeEnd = 125182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSteeringAngle(WheelData wd, float steerAngle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(wd);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &steerAngle;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSteeringAngle_Private_Void_WheelData_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125182, XrefRangeEnd = 125191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Steering()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Steering>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Steering()
	{
		Il2CppClassPointerStore<Steering>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "Steering");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Steering>.NativeClassPtr);
		NativeFieldInfoPtr_steerInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Steering>.NativeClassPtr, "steerInput");
		NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Steering>.NativeClassPtr, "settings");
		NativeFieldInfoPtr_m_wheels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Steering>.NativeClassPtr, "m_wheels");
		NativeMethodInfoPtr_AddWheel_Public_Void_WheelState_Vector3_SteeringMode_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Steering>.NativeClassPtr, 100671620);
		NativeMethodInfoPtr_AddWheel_Public_Void_WheelState_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Steering>.NativeClassPtr, 100671621);
		NativeMethodInfoPtr_RecalculateRelativeSteerRatios_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Steering>.NativeClassPtr, 100671622);
		NativeMethodInfoPtr_DoUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Steering>.NativeClassPtr, 100671623);
		NativeMethodInfoPtr_SetSteeringAngle_Private_Void_WheelData_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Steering>.NativeClassPtr, 100671624);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Steering>.NativeClassPtr, 100671625);
	}

	public Steering(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
