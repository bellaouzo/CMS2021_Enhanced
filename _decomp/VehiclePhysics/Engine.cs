using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace VehiclePhysics;

public class Engine : Block
{
	public enum IdleControlType
	{
		Passive,
		Active,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<IdleControlType>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static IdleControlType()
		{
			Il2CppClassPointerStore<IdleControlType>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Engine>.NativeClassPtr, "IdleControlType");
		}

	}

	public enum ClutchType
	{
		LockRatio,
		DiskFriction,
		TorqueConverter,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ClutchType>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static ClutchType()
		{
			Il2CppClassPointerStore<ClutchType>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Engine>.NativeClassPtr, "ClutchType");
		}

	}

	[System.Serializable]
	public class Settings : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_idleRpm;

		private static readonly System.IntPtr NativeFieldInfoPtr_peakRpm;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxRpm;

		private static readonly System.IntPtr NativeFieldInfoPtr_idleRpmTorque;

		private static readonly System.IntPtr NativeFieldInfoPtr_peakRpmTorque;

		private static readonly System.IntPtr NativeFieldInfoPtr_idleRpmCurveBias;

		private static readonly System.IntPtr NativeFieldInfoPtr_peakRpmCurveBias;

		private static readonly System.IntPtr NativeFieldInfoPtr_inertia;

		private static readonly System.IntPtr NativeFieldInfoPtr_frictionTorque;

		private static readonly System.IntPtr NativeFieldInfoPtr_rotationalFriction;

		private static readonly System.IntPtr NativeFieldInfoPtr_viscousFriction;

		private static readonly System.IntPtr NativeFieldInfoPtr_rpmLimiter;

		private static readonly System.IntPtr NativeFieldInfoPtr_rpmLimiterMax;

		private static readonly System.IntPtr NativeFieldInfoPtr_rpmLimiterCutoffTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_idleControl;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxIdleThrottle;

		private static readonly System.IntPtr NativeFieldInfoPtr_electricEngine;

		private static readonly System.IntPtr NativeFieldInfoPtr_canStall;

		private static readonly System.IntPtr NativeFieldInfoPtr_stallBias;

		private static readonly System.IntPtr NativeFieldInfoPtr_stalledFrictionTorque;

		private static readonly System.IntPtr NativeFieldInfoPtr_starterMotorBias;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxFuelPerRev;

		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyConstraints_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Settings>.NativeClassPtr));

		public unsafe float idleRpm
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleRpm);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleRpm)) = num;
			}
		}

		public unsafe float peakRpm
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_peakRpm);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_peakRpm)) = num;
			}
		}

		public unsafe float maxRpm
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRpm);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRpm)) = num;
			}
		}

		public unsafe float idleRpmTorque
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleRpmTorque);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleRpmTorque)) = num;
			}
		}

		public unsafe float peakRpmTorque
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_peakRpmTorque);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_peakRpmTorque)) = num;
			}
		}

		public unsafe float idleRpmCurveBias
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleRpmCurveBias);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleRpmCurveBias)) = num;
			}
		}

		public unsafe float peakRpmCurveBias
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_peakRpmCurveBias);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_peakRpmCurveBias)) = num;
			}
		}

		public unsafe float inertia
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inertia);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inertia)) = num;
			}
		}

		public unsafe float frictionTorque
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frictionTorque);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frictionTorque)) = num;
			}
		}

		public unsafe float rotationalFriction
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationalFriction);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationalFriction)) = num;
			}
		}

		public unsafe float viscousFriction
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viscousFriction);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viscousFriction)) = num;
			}
		}

		public unsafe bool rpmLimiter
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmLimiter);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmLimiter)) = flag;
			}
		}

		public unsafe float rpmLimiterMax
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmLimiterMax);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmLimiterMax)) = num;
			}
		}

		public unsafe float rpmLimiterCutoffTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmLimiterCutoffTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmLimiterCutoffTime)) = num;
			}
		}

		public unsafe IdleControlType idleControl
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleControl);
				return *(IdleControlType*)num;
			}
			set
			{
				*(IdleControlType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleControl)) = idleControlType;
			}
		}

		public unsafe float maxIdleThrottle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxIdleThrottle);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxIdleThrottle)) = num;
			}
		}

		public unsafe bool electricEngine
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_electricEngine);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_electricEngine)) = flag;
			}
		}

		public unsafe bool canStall
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canStall);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canStall)) = flag;
			}
		}

		public unsafe float stallBias
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stallBias);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stallBias)) = num;
			}
		}

		public unsafe float stalledFrictionTorque
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stalledFrictionTorque);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stalledFrictionTorque)) = num;
			}
		}

		public unsafe float starterMotorBias
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_starterMotorBias);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_starterMotorBias)) = num;
			}
		}

		public unsafe float maxFuelPerRev
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxFuelPerRev);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxFuelPerRev)) = num;
			}
		}

		[CallerCount(0)]
		public unsafe void ApplyConstraints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyConstraints_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public unsafe void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
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
			Il2CppClassPointerStore<Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Engine>.NativeClassPtr, "Settings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Settings>.NativeClassPtr);
			NativeFieldInfoPtr_idleRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "idleRpm");
			NativeFieldInfoPtr_peakRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "peakRpm");
			NativeFieldInfoPtr_maxRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "maxRpm");
			NativeFieldInfoPtr_idleRpmTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "idleRpmTorque");
			NativeFieldInfoPtr_peakRpmTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "peakRpmTorque");
			NativeFieldInfoPtr_idleRpmCurveBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "idleRpmCurveBias");
			NativeFieldInfoPtr_peakRpmCurveBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "peakRpmCurveBias");
			NativeFieldInfoPtr_inertia = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "inertia");
			NativeFieldInfoPtr_frictionTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "frictionTorque");
			NativeFieldInfoPtr_rotationalFriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "rotationalFriction");
			NativeFieldInfoPtr_viscousFriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "viscousFriction");
			NativeFieldInfoPtr_rpmLimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "rpmLimiter");
			NativeFieldInfoPtr_rpmLimiterMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "rpmLimiterMax");
			NativeFieldInfoPtr_rpmLimiterCutoffTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "rpmLimiterCutoffTime");
			NativeFieldInfoPtr_idleControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "idleControl");
			NativeFieldInfoPtr_maxIdleThrottle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "maxIdleThrottle");
			NativeFieldInfoPtr_electricEngine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "electricEngine");
			NativeFieldInfoPtr_canStall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "canStall");
			NativeFieldInfoPtr_stallBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "stallBias");
			NativeFieldInfoPtr_stalledFrictionTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "stalledFrictionTorque");
			NativeFieldInfoPtr_starterMotorBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "starterMotorBias");
			NativeFieldInfoPtr_maxFuelPerRev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "maxFuelPerRev");
			NativeMethodInfoPtr_ApplyConstraints_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100671489);
			NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100671490);
			NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100671491);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100671492);
		}

		public Settings(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[System.Serializable]
	public class ClutchSettings : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_type;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxTorqueTransfer;

		private static readonly System.IntPtr NativeFieldInfoPtr_lockRpm;

		private static readonly System.IntPtr NativeFieldInfoPtr_lockRatioBias;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ClutchSettings>.NativeClassPtr));

		public unsafe ClutchType type
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
				return *(ClutchType*)num;
			}
			set
			{
				*(ClutchType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = clutchType;
			}
		}

		public unsafe float maxTorqueTransfer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxTorqueTransfer);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxTorqueTransfer)) = num;
			}
		}

		public unsafe float lockRpm
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockRpm);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockRpm)) = num;
			}
		}

		public unsafe float lockRatioBias
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockRatioBias);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockRatioBias)) = num;
			}
		}

		[CallerCount(0)]
		public unsafe ClutchSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClutchSettings>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static ClutchSettings()
		{
			Il2CppClassPointerStore<ClutchSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Engine>.NativeClassPtr, "ClutchSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClutchSettings>.NativeClassPtr);
			NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClutchSettings>.NativeClassPtr, "type");
			NativeFieldInfoPtr_maxTorqueTransfer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClutchSettings>.NativeClassPtr, "maxTorqueTransfer");
			NativeFieldInfoPtr_lockRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClutchSettings>.NativeClassPtr, "lockRpm");
			NativeFieldInfoPtr_lockRatioBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClutchSettings>.NativeClassPtr, "lockRatioBias");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClutchSettings>.NativeClassPtr, 100671493);
		}

		public ClutchSettings(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct EngineSpecs
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_idleRpm;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxTorqueAtIdle;

		private static readonly System.IntPtr NativeFieldInfoPtr_frictionTorqueAtIdle;

		private static readonly System.IntPtr NativeFieldInfoPtr_peakRpm;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxTorqueAtPeak;

		private static readonly System.IntPtr NativeFieldInfoPtr_frictionTorqueAtPeak;

		private static readonly System.IntPtr NativeFieldInfoPtr_specificFuelConsumption;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxPowerRpm;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxPowerInKw;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxPowerInHp;

		private static readonly System.IntPtr NativeFieldInfoPtr_limitRpm;

		private static readonly System.IntPtr NativeFieldInfoPtr_frictionTorqueAtLimit;

		private static readonly System.IntPtr NativeFieldInfoPtr_stallRpm;

		private static readonly System.IntPtr NativeFieldInfoPtr_frictionTorqueAtStall;

		private static readonly System.IntPtr NativeFieldInfoPtr_malformedTorque;

		private static readonly System.IntPtr NativeFieldInfoPtr_malformedRawPower;

		[FieldOffset(0)]
		public float idleRpm;

		[FieldOffset(4)]
		public float maxTorqueAtIdle;

		[FieldOffset(8)]
		public float frictionTorqueAtIdle;

		[FieldOffset(12)]
		public float peakRpm;

		[FieldOffset(16)]
		public float maxTorqueAtPeak;

		[FieldOffset(20)]
		public float frictionTorqueAtPeak;

		[FieldOffset(24)]
		public float specificFuelConsumption;

		[FieldOffset(28)]
		public float maxPowerRpm;

		[FieldOffset(32)]
		public float maxPowerInKw;

		[FieldOffset(36)]
		public float maxPowerInHp;

		[FieldOffset(40)]
		public float limitRpm;

		[FieldOffset(44)]
		public float frictionTorqueAtLimit;

		[FieldOffset(48)]
		public float stallRpm;

		[FieldOffset(52)]
		public float frictionTorqueAtStall;

		[FieldOffset(56)]
		public bool malformedTorque;

		[FieldOffset(57)]
		public bool malformedRawPower;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<EngineSpecs>.NativeClassPtr));

		static EngineSpecs()
		{
			Il2CppClassPointerStore<EngineSpecs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Engine>.NativeClassPtr, "EngineSpecs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EngineSpecs>.NativeClassPtr);
			NativeFieldInfoPtr_idleRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineSpecs>.NativeClassPtr, "idleRpm");
			NativeFieldInfoPtr_maxTorqueAtIdle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineSpecs>.NativeClassPtr, "maxTorqueAtIdle");
			NativeFieldInfoPtr_frictionTorqueAtIdle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineSpecs>.NativeClassPtr, "frictionTorqueAtIdle");
			NativeFieldInfoPtr_peakRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineSpecs>.NativeClassPtr, "peakRpm");
			NativeFieldInfoPtr_maxTorqueAtPeak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineSpecs>.NativeClassPtr, "maxTorqueAtPeak");
			NativeFieldInfoPtr_frictionTorqueAtPeak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineSpecs>.NativeClassPtr, "frictionTorqueAtPeak");
			NativeFieldInfoPtr_specificFuelConsumption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineSpecs>.NativeClassPtr, "specificFuelConsumption");
			NativeFieldInfoPtr_maxPowerRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineSpecs>.NativeClassPtr, "maxPowerRpm");
			NativeFieldInfoPtr_maxPowerInKw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineSpecs>.NativeClassPtr, "maxPowerInKw");
			NativeFieldInfoPtr_maxPowerInHp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineSpecs>.NativeClassPtr, "maxPowerInHp");
			NativeFieldInfoPtr_limitRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineSpecs>.NativeClassPtr, "limitRpm");
			NativeFieldInfoPtr_frictionTorqueAtLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineSpecs>.NativeClassPtr, "frictionTorqueAtLimit");
			NativeFieldInfoPtr_stallRpm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineSpecs>.NativeClassPtr, "stallRpm");
			NativeFieldInfoPtr_frictionTorqueAtStall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineSpecs>.NativeClassPtr, "frictionTorqueAtStall");
			NativeFieldInfoPtr_malformedTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineSpecs>.NativeClassPtr, "malformedTorque");
			NativeFieldInfoPtr_malformedRawPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EngineSpecs>.NativeClassPtr, "malformedRawPower");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EngineSpecs>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_throttleInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_clutchInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_ignitionInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowedFuelRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_tcsRpms;

	private static readonly System.IntPtr NativeFieldInfoPtr_tcsRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_settings;

	private static readonly System.IntPtr NativeFieldInfoPtr_clutchSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_KwToHp;

	private static readonly System.IntPtr NativeFieldInfoPtr_L;

	private static readonly System.IntPtr NativeFieldInfoPtr_T;

	private static readonly System.IntPtr NativeFieldInfoPtr_Tr;

	private static readonly System.IntPtr NativeFieldInfoPtr_Treaction;

	private static readonly System.IntPtr NativeFieldInfoPtr_damping;

	private static readonly System.IntPtr NativeFieldInfoPtr_biasCtx;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_output;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_sensorStalled;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_sensorFlywheelTorque;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_sensorLoad;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_sensorPower;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_sensorClutchLock;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_sensorFuelRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_sensorTcsEngaged;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_tcsActivationTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_throttle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_rpmLimiterActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_rpmLimiterTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_tempDebug1;

	private static readonly System.IntPtr NativeFieldInfoPtr_tempDebug2;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEngineSpecifications_Public_Void_byref_EngineSpecs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateTorque_Public_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculatePowerInKw_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxPowerTorque_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFrictionTorque_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxFuelRate_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sensorRpm_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sensorStalled_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sensorWorking_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sensorFlywheelTorque_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sensorOutputTorque_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sensorPower_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sensorRpmLimiter_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sensorTcsEngaged_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sensorFuelRate_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sensorLoad_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sensorClutchLock_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckConnections_Public_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreStep_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetState_Public_Virtual_Void_byref_State_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSubstepState_Public_Virtual_Void_State_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateTorqueDownstream_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSubstepDerivative_Public_Virtual_Void_byref_Derivative_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetState_Public_Virtual_Void_State_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeLockingTorque_Private_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Engine>.NativeClassPtr));

	public unsafe float throttleInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throttleInput);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throttleInput)) = num;
		}
	}

	public unsafe float clutchInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clutchInput);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clutchInput)) = num;
		}
	}

	public unsafe int ignitionInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignitionInput);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignitionInput)) = num;
		}
	}

	public unsafe float allowedFuelRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedFuelRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedFuelRatio)) = num;
		}
	}

	public unsafe float tcsRpms
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tcsRpms);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tcsRpms)) = num;
		}
	}

	public unsafe float tcsRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tcsRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tcsRatio)) = num;
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

	public unsafe ClutchSettings clutchSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clutchSettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ClutchSettings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clutchSettings), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static float KwToHp
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KwToHp, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KwToHp, &num);
		}
	}

	public unsafe float L
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_L);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_L)) = num;
		}
	}

	public unsafe float T
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_T);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_T)) = num;
		}
	}

	public unsafe float Tr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Tr);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Tr)) = num;
		}
	}

	public unsafe float Treaction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Treaction);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Treaction)) = num;
		}
	}

	public unsafe float damping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damping);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damping)) = num;
		}
	}

	public unsafe CommonTools.BiasLerpContext biasCtx
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_biasCtx);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CommonTools.BiasLerpContext(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_biasCtx), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Connection m_output
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_output);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Connection(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_output), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool m_sensorStalled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sensorStalled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sensorStalled)) = flag;
		}
	}

	public unsafe float m_sensorFlywheelTorque
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sensorFlywheelTorque);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sensorFlywheelTorque)) = num;
		}
	}

	public unsafe float m_sensorLoad
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sensorLoad);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sensorLoad)) = num;
		}
	}

	public unsafe float m_sensorPower
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sensorPower);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sensorPower)) = num;
		}
	}

	public unsafe float m_sensorClutchLock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sensorClutchLock);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sensorClutchLock)) = num;
		}
	}

	public unsafe float m_sensorFuelRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sensorFuelRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sensorFuelRate)) = num;
		}
	}

	public unsafe bool m_sensorTcsEngaged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sensorTcsEngaged);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sensorTcsEngaged)) = flag;
		}
	}

	public unsafe float m_tcsActivationTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_tcsActivationTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_tcsActivationTime)) = num;
		}
	}

	public unsafe float m_throttle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_throttle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_throttle)) = num;
		}
	}

	public unsafe bool m_rpmLimiterActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rpmLimiterActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rpmLimiterActive)) = flag;
		}
	}

	public unsafe float m_rpmLimiterTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rpmLimiterTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rpmLimiterTime)) = num;
		}
	}

	public unsafe float tempDebug1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tempDebug1);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tempDebug1)) = num;
		}
	}

	public unsafe float tempDebug2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tempDebug2);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tempDebug2)) = num;
		}
	}

	public unsafe float sensorRpm
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 124561, RefRangeEnd = 124563, XrefRangeStart = 124557, XrefRangeEnd = 124561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sensorRpm_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe bool sensorStalled
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sensorStalled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe bool sensorWorking
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sensorWorking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe float sensorFlywheelTorque
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sensorFlywheelTorque_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe float sensorOutputTorque
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sensorOutputTorque_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe float sensorPower
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sensorPower_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe bool sensorRpmLimiter
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sensorRpmLimiter_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe bool sensorTcsEngaged
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sensorTcsEngaged_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe float sensorFuelRate
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sensorFuelRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe float sensorLoad
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sensorLoad_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe float sensorClutchLock
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sensorClutchLock_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 124477, RefRangeEnd = 124480, XrefRangeStart = 124452, XrefRangeEnd = 124477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetEngineSpecifications(ref EngineSpecs data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref data);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEngineSpecifications_Public_Void_byref_EngineSpecs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 124484, RefRangeEnd = 124490, XrefRangeStart = 124480, XrefRangeEnd = 124484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CalculateTorque(float rpm, [Optional] float throttle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&rpm);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &throttle;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateTorque_Public_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 124496, RefRangeEnd = 124501, XrefRangeStart = 124490, XrefRangeEnd = 124496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CalculatePowerInKw(float rpm)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rpm);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculatePowerInKw_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 124519, RefRangeEnd = 124533, XrefRangeStart = 124501, XrefRangeEnd = 124519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetMaxPowerTorque(float rpm)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rpm);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxPowerTorque_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 124540, RefRangeEnd = 124557, XrefRangeStart = 124533, XrefRangeEnd = 124540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetFrictionTorque(float rpm)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rpm);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFrictionTorque_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe float GetMaxFuelRate(float rpm)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rpm);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxFuelRate_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public new unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe bool CheckConnections()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_CheckConnections_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124563, XrefRangeEnd = 124596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void PreStep()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_PreStep_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe void GetState(ref State S)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref S);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetState_Public_Virtual_Void_byref_State_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe void SetSubstepState(State S)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&S);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SetSubstepState_Public_Virtual_Void_State_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124596, XrefRangeEnd = 124652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void EvaluateTorqueDownstream()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_EvaluateTorqueDownstream_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe void GetSubstepDerivative(ref Derivative D)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetSubstepDerivative_Public_Virtual_Void_byref_Derivative_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124652, XrefRangeEnd = 124656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void SetState(State S)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&S);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SetState_Public_Virtual_Void_State_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 124656, RefRangeEnd = 124659, XrefRangeStart = 124656, XrefRangeEnd = 124656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float ComputeLockingTorque(float flywheelTorque, float dt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&flywheelTorque);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dt;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeLockingTorque_Private_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 124673, RefRangeEnd = 124677, XrefRangeStart = 124659, XrefRangeEnd = 124673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Engine()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Engine>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Engine()
	{
		Il2CppClassPointerStore<Engine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "Engine");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Engine>.NativeClassPtr);
		NativeFieldInfoPtr_throttleInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "throttleInput");
		NativeFieldInfoPtr_clutchInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "clutchInput");
		NativeFieldInfoPtr_ignitionInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "ignitionInput");
		NativeFieldInfoPtr_allowedFuelRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "allowedFuelRatio");
		NativeFieldInfoPtr_tcsRpms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "tcsRpms");
		NativeFieldInfoPtr_tcsRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "tcsRatio");
		NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "settings");
		NativeFieldInfoPtr_clutchSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "clutchSettings");
		NativeFieldInfoPtr_KwToHp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "KwToHp");
		NativeFieldInfoPtr_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "L");
		NativeFieldInfoPtr_T = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "T");
		NativeFieldInfoPtr_Tr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "Tr");
		NativeFieldInfoPtr_Treaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "Treaction");
		NativeFieldInfoPtr_damping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "damping");
		NativeFieldInfoPtr_biasCtx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "biasCtx");
		NativeFieldInfoPtr_m_output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "m_output");
		NativeFieldInfoPtr_m_sensorStalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "m_sensorStalled");
		NativeFieldInfoPtr_m_sensorFlywheelTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "m_sensorFlywheelTorque");
		NativeFieldInfoPtr_m_sensorLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "m_sensorLoad");
		NativeFieldInfoPtr_m_sensorPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "m_sensorPower");
		NativeFieldInfoPtr_m_sensorClutchLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "m_sensorClutchLock");
		NativeFieldInfoPtr_m_sensorFuelRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "m_sensorFuelRate");
		NativeFieldInfoPtr_m_sensorTcsEngaged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "m_sensorTcsEngaged");
		NativeFieldInfoPtr_m_tcsActivationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "m_tcsActivationTime");
		NativeFieldInfoPtr_m_throttle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "m_throttle");
		NativeFieldInfoPtr_m_rpmLimiterActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "m_rpmLimiterActive");
		NativeFieldInfoPtr_m_rpmLimiterTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "m_rpmLimiterTime");
		NativeFieldInfoPtr_tempDebug1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "tempDebug1");
		NativeFieldInfoPtr_tempDebug2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Engine>.NativeClassPtr, "tempDebug2");
		NativeMethodInfoPtr_GetEngineSpecifications_Public_Void_byref_EngineSpecs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Engine>.NativeClassPtr, 100671461);
		NativeMethodInfoPtr_CalculateTorque_Public_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Engine>.NativeClassPtr, 100671462);
		NativeMethodInfoPtr_CalculatePowerInKw_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Engine>.NativeClassPtr, 100671463);
		NativeMethodInfoPtr_GetMaxPowerTorque_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Engine>.NativeClassPtr, 100671464);
		NativeMethodInfoPtr_GetFrictionTorque_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Engine>.NativeClassPtr, 100671465);
		NativeMethodInfoPtr_GetMaxFuelRate_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Engine>.NativeClassPtr, 100671466);
		NativeMethodInfoPtr_get_sensorRpm_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Engine>.NativeClassPtr, 100671467);
		NativeMethodInfoPtr_get_sensorStalled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Engine>.NativeClassPtr, 100671468);
		NativeMethodInfoPtr_get_sensorWorking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Engine>.NativeClassPtr, 100671469);
		NativeMethodInfoPtr_get_sensorFlywheelTorque_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Engine>.NativeClassPtr, 100671470);
		NativeMethodInfoPtr_get_sensorOutputTorque_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Engine>.NativeClassPtr, 100671471);
		NativeMethodInfoPtr_get_sensorPower_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Engine>.NativeClassPtr, 100671472);
		NativeMethodInfoPtr_get_sensorRpmLimiter_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Engine>.NativeClassPtr, 100671473);
		NativeMethodInfoPtr_get_sensorTcsEngaged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Engine>.NativeClassPtr, 100671474);
		NativeMethodInfoPtr_get_sensorFuelRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Engine>.NativeClassPtr, 100671475);
		NativeMethodInfoPtr_get_sensorLoad_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Engine>.NativeClassPtr, 100671476);
		NativeMethodInfoPtr_get_sensorClutchLock_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Engine>.NativeClassPtr, 100671477);
		NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Engine>.NativeClassPtr, 100671478);
		NativeMethodInfoPtr_CheckConnections_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Engine>.NativeClassPtr, 100671479);
		NativeMethodInfoPtr_PreStep_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Engine>.NativeClassPtr, 100671480);
		NativeMethodInfoPtr_GetState_Public_Virtual_Void_byref_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Engine>.NativeClassPtr, 100671481);
		NativeMethodInfoPtr_SetSubstepState_Public_Virtual_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Engine>.NativeClassPtr, 100671482);
		NativeMethodInfoPtr_EvaluateTorqueDownstream_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Engine>.NativeClassPtr, 100671483);
		NativeMethodInfoPtr_GetSubstepDerivative_Public_Virtual_Void_byref_Derivative_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Engine>.NativeClassPtr, 100671484);
		NativeMethodInfoPtr_SetState_Public_Virtual_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Engine>.NativeClassPtr, 100671485);
		NativeMethodInfoPtr_ComputeLockingTorque_Private_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Engine>.NativeClassPtr, 100671486);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Engine>.NativeClassPtr, 100671487);
	}

	public Engine(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
