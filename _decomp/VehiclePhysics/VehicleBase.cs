using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace VehiclePhysics;

public class VehicleBase : MonoBehaviour
{
	public enum VehicleSleepCriteria
	{
		Strict,
		Relaxed,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VehicleSleepCriteria>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static VehicleSleepCriteria()
		{
			Il2CppClassPointerStore<VehicleSleepCriteria>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "VehicleSleepCriteria");
		}

	}

	public class WheelState : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_wheelCol;

		private static readonly System.IntPtr NativeFieldInfoPtr_steerable;

		private static readonly System.IntPtr NativeFieldInfoPtr_steerAngle;

		private static readonly System.IntPtr NativeFieldInfoPtr_grounded;

		private static readonly System.IntPtr NativeFieldInfoPtr_hit;

		private static readonly System.IntPtr NativeFieldInfoPtr_groundMaterial;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastPhysicMaterial;

		private static readonly System.IntPtr NativeFieldInfoPtr_contactDepth;

		private static readonly System.IntPtr NativeFieldInfoPtr_suspensionCompression;

		private static readonly System.IntPtr NativeFieldInfoPtr_downforce;

		private static readonly System.IntPtr NativeFieldInfoPtr_weightRatio;

		private static readonly System.IntPtr NativeFieldInfoPtr_contactAngle;

		private static readonly System.IntPtr NativeFieldInfoPtr_contactSpeed;

		private static readonly System.IntPtr NativeFieldInfoPtr_damperForce;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastContactDepth;

		private static readonly System.IntPtr NativeFieldInfoPtr_wheelVelocity;

		private static readonly System.IntPtr NativeFieldInfoPtr_surfaceForce;

		private static readonly System.IntPtr NativeFieldInfoPtr_localWheelVelocity;

		private static readonly System.IntPtr NativeFieldInfoPtr_localSurfaceForce;

		private static readonly System.IntPtr NativeFieldInfoPtr_externalTireForce;

		private static readonly System.IntPtr NativeFieldInfoPtr_angularVelocity;

		private static readonly System.IntPtr NativeFieldInfoPtr_tireForce;

		private static readonly System.IntPtr NativeFieldInfoPtr_reactionTorque;

		private static readonly System.IntPtr NativeFieldInfoPtr_tireSlip;

		private static readonly System.IntPtr NativeFieldInfoPtr_combinedTireSlip;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastTireForce;

		private static readonly System.IntPtr NativeFieldInfoPtr_driveTorque;

		private static readonly System.IntPtr NativeFieldInfoPtr_brakeTorque;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WheelState>.NativeClassPtr));

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

		public unsafe bool steerable
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steerable);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steerable)) = flag;
			}
		}

		public unsafe float steerAngle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steerAngle);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steerAngle)) = num;
			}
		}

		public unsafe bool grounded
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_grounded);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_grounded)) = flag;
			}
		}

		public unsafe WheelHit hit
		{
			get
			{
				//IL_0020: Unknown result type (might be due to invalid IL or missing references)
				//IL_0026: Expected O, but got Unknown
				nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hit);
				return new WheelHit(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WheelHit>.NativeClassPtr, data));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hit), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WheelHit>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe GroundMaterial groundMaterial
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groundMaterial);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new GroundMaterial(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groundMaterial), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe PhysicMaterial lastPhysicMaterial
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastPhysicMaterial);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new PhysicMaterial(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastPhysicMaterial), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe float contactDepth
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contactDepth);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contactDepth)) = num;
			}
		}

		public unsafe float suspensionCompression
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspensionCompression);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspensionCompression)) = num;
			}
		}

		public unsafe float downforce
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downforce);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downforce)) = num;
			}
		}

		public unsafe float weightRatio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weightRatio);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weightRatio)) = num;
			}
		}

		public unsafe float contactAngle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contactAngle);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contactAngle)) = num;
			}
		}

		public unsafe float contactSpeed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contactSpeed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contactSpeed)) = num;
			}
		}

		public unsafe float damperForce
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damperForce);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damperForce)) = num;
			}
		}

		public unsafe float lastContactDepth
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastContactDepth);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastContactDepth)) = num;
			}
		}

		public unsafe Vector3 wheelVelocity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelVelocity);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelVelocity)) = vector;
			}
		}

		public unsafe Vector3 surfaceForce
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_surfaceForce);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_surfaceForce)) = vector;
			}
		}

		public unsafe Vector2 localWheelVelocity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localWheelVelocity);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localWheelVelocity)) = vector;
			}
		}

		public unsafe Vector2 localSurfaceForce
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localSurfaceForce);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localSurfaceForce)) = vector;
			}
		}

		public unsafe Vector2 externalTireForce
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_externalTireForce);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_externalTireForce)) = vector;
			}
		}

		public unsafe float angularVelocity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angularVelocity);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angularVelocity)) = num;
			}
		}

		public unsafe Vector2 tireForce
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tireForce);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tireForce)) = vector;
			}
		}

		public unsafe float reactionTorque
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactionTorque);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactionTorque)) = num;
			}
		}

		public unsafe Vector2 tireSlip
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tireSlip);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tireSlip)) = vector;
			}
		}

		public unsafe float combinedTireSlip
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combinedTireSlip);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_combinedTireSlip)) = num;
			}
		}

		public unsafe Vector2 lastTireForce
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastTireForce);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastTireForce)) = vector;
			}
		}

		public unsafe float driveTorque
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_driveTorque);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_driveTorque)) = num;
			}
		}

		public unsafe float brakeTorque
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeTorque);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brakeTorque)) = num;
			}
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123390, XrefRangeEnd = 123400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WheelState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WheelState>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static WheelState()
		{
			Il2CppClassPointerStore<WheelState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "WheelState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WheelState>.NativeClassPtr);
			NativeFieldInfoPtr_wheelCol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelState>.NativeClassPtr, "wheelCol");
			NativeFieldInfoPtr_steerable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelState>.NativeClassPtr, "steerable");
			NativeFieldInfoPtr_steerAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelState>.NativeClassPtr, "steerAngle");
			NativeFieldInfoPtr_grounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelState>.NativeClassPtr, "grounded");
			NativeFieldInfoPtr_hit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelState>.NativeClassPtr, "hit");
			NativeFieldInfoPtr_groundMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelState>.NativeClassPtr, "groundMaterial");
			NativeFieldInfoPtr_lastPhysicMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelState>.NativeClassPtr, "lastPhysicMaterial");
			NativeFieldInfoPtr_contactDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelState>.NativeClassPtr, "contactDepth");
			NativeFieldInfoPtr_suspensionCompression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelState>.NativeClassPtr, "suspensionCompression");
			NativeFieldInfoPtr_downforce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelState>.NativeClassPtr, "downforce");
			NativeFieldInfoPtr_weightRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelState>.NativeClassPtr, "weightRatio");
			NativeFieldInfoPtr_contactAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelState>.NativeClassPtr, "contactAngle");
			NativeFieldInfoPtr_contactSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelState>.NativeClassPtr, "contactSpeed");
			NativeFieldInfoPtr_damperForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelState>.NativeClassPtr, "damperForce");
			NativeFieldInfoPtr_lastContactDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelState>.NativeClassPtr, "lastContactDepth");
			NativeFieldInfoPtr_wheelVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelState>.NativeClassPtr, "wheelVelocity");
			NativeFieldInfoPtr_surfaceForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelState>.NativeClassPtr, "surfaceForce");
			NativeFieldInfoPtr_localWheelVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelState>.NativeClassPtr, "localWheelVelocity");
			NativeFieldInfoPtr_localSurfaceForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelState>.NativeClassPtr, "localSurfaceForce");
			NativeFieldInfoPtr_externalTireForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelState>.NativeClassPtr, "externalTireForce");
			NativeFieldInfoPtr_angularVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelState>.NativeClassPtr, "angularVelocity");
			NativeFieldInfoPtr_tireForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelState>.NativeClassPtr, "tireForce");
			NativeFieldInfoPtr_reactionTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelState>.NativeClassPtr, "reactionTorque");
			NativeFieldInfoPtr_tireSlip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelState>.NativeClassPtr, "tireSlip");
			NativeFieldInfoPtr_combinedTireSlip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelState>.NativeClassPtr, "combinedTireSlip");
			NativeFieldInfoPtr_lastTireForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelState>.NativeClassPtr, "lastTireForce");
			NativeFieldInfoPtr_driveTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelState>.NativeClassPtr, "driveTorque");
			NativeFieldInfoPtr_brakeTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelState>.NativeClassPtr, "brakeTorque");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelState>.NativeClassPtr, 100671365);
		}

		public WheelState(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	public enum WheelPos
	{
		Default = 0,
		Left = 0,
		Right = 99,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WheelPos>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static WheelPos()
		{
			Il2CppClassPointerStore<WheelPos>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "WheelPos");
		}

	}

	public sealed class OnImpact : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<OnImpact>.NativeClassPtr));

		[CallerCount(70)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe OnImpact(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnImpact>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(217)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe Il2CppSystem.IAsyncResult BeginInvoke(Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(@object);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.IAsyncResult(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static OnImpact()
		{
			Il2CppClassPointerStore<OnImpact>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "OnImpact");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnImpact>.NativeClassPtr, 100671366);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnImpact>.NativeClassPtr, 100671367);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnImpact>.NativeClassPtr, 100671368);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnImpact>.NativeClassPtr, 100671369);
		}

		public OnImpact(System.IntPtr P_0)
			: base(P_0)
		{
		}

		public static implicit operator OnImpact(System.Action P_0)
		{
			return DelegateSupport.ConvertDelegate<OnImpact>(P_0);
		}

		public static OnImpact operator +(OnImpact P_0, OnImpact P_1)
		{
			return Il2CppSystem.Delegate.Combine(P_0, P_1).Cast<OnImpact>();
		}

		public static OnImpact operator -(OnImpact P_0, OnImpact P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<OnImpact>();
			}
			return (OnImpact)obj;
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_tireSideDeflection;

	private static readonly System.IntPtr NativeFieldInfoPtr_tireSideDeflectionRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_tireImpulseRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_wheelSleepVelocity;

	private static readonly System.IntPtr NativeFieldInfoPtr_advancedSuspensionDamper;

	private static readonly System.IntPtr NativeFieldInfoPtr_suspensionDamperLimitFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_contactAngleAffectsTireForce;

	private static readonly System.IntPtr NativeFieldInfoPtr_integrationSteps;

	private static readonly System.IntPtr NativeFieldInfoPtr_integrationUseRK4;

	private static readonly System.IntPtr NativeFieldInfoPtr_centerOfMass;

	private static readonly System.IntPtr NativeFieldInfoPtr_accurateSuspensionForces;

	private static readonly System.IntPtr NativeFieldInfoPtr_scaleFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_vehicleSleepCriteria;

	private static readonly System.IntPtr NativeFieldInfoPtr_invertVisualWheelSpinDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_onPreDynamicsStep;

	private static readonly System.IntPtr NativeFieldInfoPtr_onBeforeUpdateBlocks;

	private static readonly System.IntPtr NativeFieldInfoPtr_onPreVisualUpdate;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_transform;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_rigidbody;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_solver;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_wheels;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_wheelState;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_localAcceleration;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_lastVelocity;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_speed;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_speedAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr__initialized_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__groundMaterialManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_data;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_colliders;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_colLayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_paused;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_singleFixedStep;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_singleUpdateStep;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_activeBehaviours;

	private static readonly System.IntPtr NativeFieldInfoPtr_showContactGizmos;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableContactProcessing;

	private static readonly System.IntPtr NativeFieldInfoPtr_onImpact;

	private static readonly System.IntPtr NativeFieldInfoPtr_vehicle;

	private static readonly System.IntPtr NativeFieldInfoPtr__lastContactedCollider_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_impactThreeshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_impactInterval;

	private static readonly System.IntPtr NativeFieldInfoPtr_impactIntervalRandom;

	private static readonly System.IntPtr NativeFieldInfoPtr_impactMinSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_sumImpactCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_sumImpactPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_sumImpactVelocity;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_sumImpactHardness;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_lastImpactTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_localDragPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_localDragVelocity;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_localDragHardness;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_lastImpactedMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_impactedGroundMaterial;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cachedTransform_Public_get_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cachedRigidbody_Public_get_Rigidbody_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_initialized_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_initialized_Private_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_groundMaterialManager_Public_get_GroundMaterialManagerBase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_groundMaterialManager_Public_set_Void_GroundMaterialManagerBase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_wheelCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_wheelState_Public_get_ArrayOf_WheelState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_speed_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_speedAngle_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_localAcceleration_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWheelLocalPosition_Public_Vector3_VPWheelCollider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTangentVelocity_Public_Vector3_Vector3_Vector3_Rigidbody_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NotifyCollidersChanged_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_paused_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_paused_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SingleStep_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reposition_Public_Void_Vector3_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWheelRadius_Public_Void_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWheelRadius_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWheelTireFriction_Public_Void_Int32_TireFriction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWheelTireFriction_Public_TireFriction_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWheelAngularVelocityForSlip_Public_Single_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWheelPeakSlip_Public_Vector2_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWheelAdherentSlip_Public_Vector2_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableCollidersRaycast_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableCollidersRaycast_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeVehicleSpeed_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeLocalAcceleration_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureCenterOfMass_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeCombinedSlip_Private_Static_Single_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_wheels_Protected_get_ArrayOf_Wheel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetNumberOfWheels_Protected_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnInitialize_Protected_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoUpdateBlocks_Protected_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoUpdateData_Protected_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInternalObject_Public_Virtual_New_Object_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWheelIndex_Public_Virtual_New_Int32_Int32_WheelPos_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateSuspensionTravel_Private_Void_WheelState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateSuspensionForces_Private_Void_WheelState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateDownforce_Private_Void_WheelState_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateLocalFrame_Private_Void_WheelState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyTireForce_Private_Void_WheelState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableVehicleBehaviours_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableVehicleBehaviours_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdateVehicleBehaviours_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVehicleBehaviours_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSuspensionBehaviours_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddVehicleBehaviour_Private_Void_VehicleBehaviour_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveVehicleBehaviour_Private_Void_VehicleBehaviour_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterVehicleBehaviour_Public_Void_VehicleBehaviour_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterVehicleBehaviour_Public_Void_VehicleBehaviour_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NotifyReposition_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NotifyEnterPause_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NotifyLeavePause_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_localImpactPosition_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_localImpactVelocity_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isHardImpact_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_localDragPosition_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_localDragVelocity_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isHardDrag_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lastContactedCollider_Public_get_Collider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_lastContactedCollider_Private_set_Void_Collider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearCollisionData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessImpacts_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnCollisionStay_Private_Void_Collision_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnCollision_Private_Void_Collision_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDragState_Private_Void_Vector3_Vector3_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr));

	public unsafe bool tireSideDeflection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tireSideDeflection);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tireSideDeflection)) = flag;
		}
	}

	public unsafe float tireSideDeflectionRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tireSideDeflectionRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tireSideDeflectionRate)) = num;
		}
	}

	public unsafe float tireImpulseRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tireImpulseRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tireImpulseRatio)) = num;
		}
	}

	public unsafe float wheelSleepVelocity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelSleepVelocity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelSleepVelocity)) = num;
		}
	}

	public unsafe bool advancedSuspensionDamper
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_advancedSuspensionDamper);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_advancedSuspensionDamper)) = flag;
		}
	}

	public unsafe float suspensionDamperLimitFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspensionDamperLimitFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suspensionDamperLimitFactor)) = num;
		}
	}

	public unsafe bool contactAngleAffectsTireForce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contactAngleAffectsTireForce);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contactAngleAffectsTireForce)) = flag;
		}
	}

	public unsafe int integrationSteps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_integrationSteps);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_integrationSteps)) = num;
		}
	}

	public unsafe bool integrationUseRK4
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_integrationUseRK4);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_integrationUseRK4)) = flag;
		}
	}

	public unsafe Transform centerOfMass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_centerOfMass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_centerOfMass), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool accurateSuspensionForces
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accurateSuspensionForces);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accurateSuspensionForces)) = flag;
		}
	}

	public unsafe float scaleFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scaleFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scaleFactor)) = num;
		}
	}

	public unsafe VehicleSleepCriteria vehicleSleepCriteria
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vehicleSleepCriteria);
			return *(VehicleSleepCriteria*)num;
		}
		set
		{
			*(VehicleSleepCriteria*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vehicleSleepCriteria)) = vehicleSleepCriteria;
		}
	}

	public unsafe bool invertVisualWheelSpinDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invertVisualWheelSpinDirection);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invertVisualWheelSpinDirection)) = flag;
		}
	}

	public unsafe Il2CppSystem.Action onPreDynamicsStep
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onPreDynamicsStep);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onPreDynamicsStep), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Action onBeforeUpdateBlocks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onBeforeUpdateBlocks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onBeforeUpdateBlocks), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Action onPreVisualUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onPreVisualUpdate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onPreVisualUpdate), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform m_transform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_transform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_transform), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Rigidbody m_rigidbody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rigidbody);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Rigidbody(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rigidbody), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Solver m_solver
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_solver);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Solver(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_solver), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<Wheel> m_wheels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_wheels);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Wheel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_wheels), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<WheelState> m_wheelState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_wheelState);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<WheelState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_wheelState), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector3 m_localAcceleration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_localAcceleration);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_localAcceleration)) = vector;
		}
	}

	public unsafe Vector3 m_lastVelocity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastVelocity);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastVelocity)) = vector;
		}
	}

	public unsafe float m_speed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_speed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_speed)) = num;
		}
	}

	public unsafe float m_speedAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_speedAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_speedAngle)) = num;
		}
	}

	public unsafe bool _initialized_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__initialized_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__initialized_k__BackingField)) = flag;
		}
	}

	public unsafe GroundMaterialManagerBase _groundMaterialManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__groundMaterialManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GroundMaterialManagerBase(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__groundMaterialManager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DataBus data
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DataBus(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<Collider> m_colliders
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_colliders);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Collider>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_colliders), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<int> m_colLayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_colLayers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<int>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_colLayers), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool m_paused
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_paused);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_paused)) = flag;
		}
	}

	public unsafe bool m_singleFixedStep
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_singleFixedStep);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_singleFixedStep)) = flag;
		}
	}

	public unsafe bool m_singleUpdateStep
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_singleUpdateStep);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_singleUpdateStep)) = flag;
		}
	}

	public unsafe List<VehicleBehaviour> m_activeBehaviours
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_activeBehaviours);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<VehicleBehaviour>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_activeBehaviours), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool showContactGizmos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showContactGizmos);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showContactGizmos)) = flag;
		}
	}

	public unsafe bool disableContactProcessing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableContactProcessing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableContactProcessing)) = flag;
		}
	}

	public unsafe OnImpact onImpact
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onImpact);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new OnImpact(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onImpact), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static VehicleBase vehicle
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vehicle, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new VehicleBase(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vehicle, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Collider _lastContactedCollider_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastContactedCollider_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Collider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastContactedCollider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float impactThreeshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_impactThreeshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_impactThreeshold)) = num;
		}
	}

	public unsafe float impactInterval
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_impactInterval);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_impactInterval)) = num;
		}
	}

	public unsafe float impactIntervalRandom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_impactIntervalRandom);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_impactIntervalRandom)) = num;
		}
	}

	public unsafe float impactMinSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_impactMinSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_impactMinSpeed)) = num;
		}
	}

	public unsafe int m_sumImpactCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sumImpactCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sumImpactCount)) = num;
		}
	}

	public unsafe Vector3 m_sumImpactPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sumImpactPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sumImpactPosition)) = vector;
		}
	}

	public unsafe Vector3 m_sumImpactVelocity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sumImpactVelocity);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sumImpactVelocity)) = vector;
		}
	}

	public unsafe int m_sumImpactHardness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sumImpactHardness);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sumImpactHardness)) = num;
		}
	}

	public unsafe float m_lastImpactTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastImpactTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastImpactTime)) = num;
		}
	}

	public unsafe Vector3 m_localDragPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_localDragPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_localDragPosition)) = vector;
		}
	}

	public unsafe Vector3 m_localDragVelocity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_localDragVelocity);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_localDragVelocity)) = vector;
		}
	}

	public unsafe int m_localDragHardness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_localDragHardness);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_localDragHardness)) = num;
		}
	}

	public unsafe PhysicMaterial m_lastImpactedMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastImpactedMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PhysicMaterial(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastImpactedMaterial), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GroundMaterial m_impactedGroundMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_impactedGroundMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GroundMaterial(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_impactedGroundMaterial), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform cachedTransform
	{
		[CallerCount(30)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cachedTransform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
	}

	public unsafe Rigidbody cachedRigidbody
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cachedRigidbody_Public_get_Rigidbody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Rigidbody(intPtr) : null;
		}
	}

	public unsafe bool initialized
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_initialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_initialized_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe GroundMaterialManagerBase groundMaterialManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_groundMaterialManager_Public_get_GroundMaterialManagerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new GroundMaterialManagerBase(intPtr) : null;
		}
		[CallerCount(3)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_groundMaterialManager_Public_set_Void_GroundMaterialManagerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe int wheelCount
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_wheelCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe Il2CppReferenceArray<WheelState> wheelState
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_wheelState_Public_get_ArrayOf_WheelState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<WheelState>(intPtr) : null;
		}
	}

	public unsafe float speed
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_speed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe float speedAngle
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_speedAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe Vector3 localAcceleration
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_localAcceleration_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe bool paused
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_paused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 123461, RefRangeEnd = 123463, XrefRangeStart = 123455, XrefRangeEnd = 123461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_paused_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Il2CppReferenceArray<Wheel> wheels
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_wheels_Protected_get_ArrayOf_Wheel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Wheel>(intPtr) : null;
		}
	}

	public unsafe Vector3 localImpactPosition
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_localImpactPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe Vector3 localImpactVelocity
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_localImpactVelocity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe bool isHardImpact
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isHardImpact_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe Vector3 localDragPosition
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_localDragPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe Vector3 localDragVelocity
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_localDragVelocity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe bool isHardDrag
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isHardDrag_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe Collider lastContactedCollider
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lastContactedCollider_Public_get_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Collider(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_lastContactedCollider_Private_set_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 123405, RefRangeEnd = 123407, XrefRangeStart = 123400, XrefRangeEnd = 123405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetWheelLocalPosition(VPWheelCollider wheelCol)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(wheelCol);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWheelLocalPosition_Public_Vector3_VPWheelCollider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 123425, RefRangeEnd = 123428, XrefRangeStart = 123407, XrefRangeEnd = 123425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetTangentVelocity(Vector3 surfacePoint, Vector3 surfaceNormal, Rigidbody surfaceRigidbody)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&surfacePoint);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &surfaceNormal;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(surfaceRigidbody);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTangentVelocity_Public_Vector3_Vector3_Vector3_Rigidbody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123428, XrefRangeEnd = 123455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NotifyCollidersChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NotifyCollidersChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SingleStep()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SingleStep_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123463, XrefRangeEnd = 123470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reposition(Vector3 position, Quaternion rotation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&position);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reposition_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 123470, RefRangeEnd = 123472, XrefRangeStart = 123470, XrefRangeEnd = 123470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetWheelRadius(int wheelIndex, float radius)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&wheelIndex);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWheelRadius_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe float GetWheelRadius(int wheelIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&wheelIndex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWheelRadius_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123472, XrefRangeEnd = 123473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetWheelTireFriction(int wheelIndex, TireFriction friction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&wheelIndex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(friction);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWheelTireFriction_Public_Void_Int32_TireFriction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe TireFriction GetWheelTireFriction(int wheelIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&wheelIndex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWheelTireFriction_Public_TireFriction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new TireFriction(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 123473, RefRangeEnd = 123475, XrefRangeStart = 123473, XrefRangeEnd = 123473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetWheelAngularVelocityForSlip(int wheelIndex, float slip)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&wheelIndex);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &slip;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWheelAngularVelocityForSlip_Public_Single_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 123475, RefRangeEnd = 123480, XrefRangeStart = 123475, XrefRangeEnd = 123475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetWheelPeakSlip(int wheelIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&wheelIndex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWheelPeakSlip_Public_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 123480, RefRangeEnd = 123485, XrefRangeStart = 123480, XrefRangeEnd = 123480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetWheelAdherentSlip(int wheelIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&wheelIndex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWheelAdherentSlip_Public_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 123517, RefRangeEnd = 123518, XrefRangeStart = 123485, XrefRangeEnd = 123517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisableCollidersRaycast()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableCollidersRaycast_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 123549, RefRangeEnd = 123550, XrefRangeStart = 123518, XrefRangeEnd = 123549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableCollidersRaycast()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableCollidersRaycast_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123550, XrefRangeEnd = 123556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ComputeVehicleSpeed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeVehicleSpeed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123556, XrefRangeEnd = 123562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ComputeLocalAcceleration()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeLocalAcceleration_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 123582, RefRangeEnd = 123583, XrefRangeStart = 123562, XrefRangeEnd = 123582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureCenterOfMass()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureCenterOfMass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 123587, RefRangeEnd = 123588, XrefRangeStart = 123583, XrefRangeEnd = 123587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ComputeCombinedSlip(Vector2 localVelocity, Vector2 tireSlip)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&localVelocity);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &tireSlip;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeCombinedSlip_Private_Static_Single_Vector2_Vector2_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 123627, RefRangeEnd = 123633, XrefRangeStart = 123588, XrefRangeEnd = 123627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetNumberOfWheels(int numberOfWheels)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&numberOfWheels);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetNumberOfWheels_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123633, XrefRangeEnd = 123634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInitialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnInitialize_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void DoUpdateBlocks()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_DoUpdateBlocks_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void DoUpdateData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_DoUpdateData_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void OnUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe Il2CppSystem.Object GetInternalObject(Il2CppSystem.Type type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetInternalObject_Public_Virtual_New_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123634, XrefRangeEnd = 123635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetWheelIndex(int axle, [Optional] WheelPos position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&axle);
		*(WheelPos**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetWheelIndex_Public_Virtual_New_Int32_Int32_WheelPos_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123635, XrefRangeEnd = 123636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalculateSuspensionTravel(WheelState wheel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(wheel);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateSuspensionTravel_Private_Void_WheelState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 123647, RefRangeEnd = 123648, XrefRangeStart = 123636, XrefRangeEnd = 123647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalculateSuspensionForces(WheelState wheel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(wheel);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateSuspensionForces_Private_Void_WheelState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void CalculateDownforce(WheelState wheel, float referenceDownforce)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(wheel);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &referenceDownforce;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateDownforce_Private_Void_WheelState_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 123685, RefRangeEnd = 123686, XrefRangeStart = 123648, XrefRangeEnd = 123685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalculateLocalFrame(WheelState wheel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(wheel);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateLocalFrame_Private_Void_WheelState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 123720, RefRangeEnd = 123721, XrefRangeStart = 123686, XrefRangeEnd = 123720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyTireForce(WheelState wheel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(wheel);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyTireForce_Private_Void_WheelState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123721, XrefRangeEnd = 123798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123798, XrefRangeEnd = 123816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123816, XrefRangeEnd = 123878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123878, XrefRangeEnd = 123900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123900, XrefRangeEnd = 123912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableVehicleBehaviours()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableVehicleBehaviours_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123912, XrefRangeEnd = 123916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisableVehicleBehaviours()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableVehicleBehaviours_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123916, XrefRangeEnd = 123919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdateVehicleBehaviours()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixedUpdateVehicleBehaviours_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123919, XrefRangeEnd = 123922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateVehicleBehaviours()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateVehicleBehaviours_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123922, XrefRangeEnd = 123925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSuspensionBehaviours()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateSuspensionBehaviours_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 123950, RefRangeEnd = 123953, XrefRangeStart = 123925, XrefRangeEnd = 123950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddVehicleBehaviour(VehicleBehaviour vb)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(vb);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddVehicleBehaviour_Private_Void_VehicleBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 123958, RefRangeEnd = 123963, XrefRangeStart = 123953, XrefRangeEnd = 123958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveVehicleBehaviour(VehicleBehaviour vb)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(vb);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveVehicleBehaviour_Private_Void_VehicleBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123963, XrefRangeEnd = 123964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterVehicleBehaviour(VehicleBehaviour vb)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(vb);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterVehicleBehaviour_Public_Void_VehicleBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123964, XrefRangeEnd = 123965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterVehicleBehaviour(VehicleBehaviour vb)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(vb);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterVehicleBehaviour_Public_Void_VehicleBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123965, XrefRangeEnd = 123968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NotifyReposition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NotifyReposition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123968, XrefRangeEnd = 123971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NotifyEnterPause()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NotifyEnterPause_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123971, XrefRangeEnd = 123974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NotifyLeavePause()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NotifyLeavePause_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123974, XrefRangeEnd = 123982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearCollisionData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearCollisionData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 124026, RefRangeEnd = 124027, XrefRangeStart = 123982, XrefRangeEnd = 124026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessImpacts()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessImpacts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124027, XrefRangeEnd = 124028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnCollisionEnter(UnityEngine.Collision collision)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124028, XrefRangeEnd = 124029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnCollisionStay(UnityEngine.Collision collision)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnCollisionStay_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 124109, RefRangeEnd = 124111, XrefRangeStart = 124029, XrefRangeEnd = 124109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnCollision(UnityEngine.Collision col, bool forceImpact)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(col);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceImpact;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnCollision_Private_Void_Collision_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 124153, RefRangeEnd = 124155, XrefRangeStart = 124111, XrefRangeEnd = 124153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateDragState(Vector3 dragPosition, Vector3 dragVelocity, int dragHardness)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&dragPosition);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dragVelocity;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dragHardness;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateDragState_Private_Void_Vector3_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 124191, RefRangeEnd = 124196, XrefRangeStart = 124155, XrefRangeEnd = 124191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VehicleBase()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VehicleBase()
	{
		Il2CppClassPointerStore<VehicleBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "VehicleBase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr);
		NativeFieldInfoPtr_tireSideDeflection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "tireSideDeflection");
		NativeFieldInfoPtr_tireSideDeflectionRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "tireSideDeflectionRate");
		NativeFieldInfoPtr_tireImpulseRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "tireImpulseRatio");
		NativeFieldInfoPtr_wheelSleepVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "wheelSleepVelocity");
		NativeFieldInfoPtr_advancedSuspensionDamper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "advancedSuspensionDamper");
		NativeFieldInfoPtr_suspensionDamperLimitFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "suspensionDamperLimitFactor");
		NativeFieldInfoPtr_contactAngleAffectsTireForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "contactAngleAffectsTireForce");
		NativeFieldInfoPtr_integrationSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "integrationSteps");
		NativeFieldInfoPtr_integrationUseRK4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "integrationUseRK4");
		NativeFieldInfoPtr_centerOfMass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "centerOfMass");
		NativeFieldInfoPtr_accurateSuspensionForces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "accurateSuspensionForces");
		NativeFieldInfoPtr_scaleFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "scaleFactor");
		NativeFieldInfoPtr_vehicleSleepCriteria = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "vehicleSleepCriteria");
		NativeFieldInfoPtr_invertVisualWheelSpinDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "invertVisualWheelSpinDirection");
		NativeFieldInfoPtr_onPreDynamicsStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "onPreDynamicsStep");
		NativeFieldInfoPtr_onBeforeUpdateBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "onBeforeUpdateBlocks");
		NativeFieldInfoPtr_onPreVisualUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "onPreVisualUpdate");
		NativeFieldInfoPtr_m_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "m_transform");
		NativeFieldInfoPtr_m_rigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "m_rigidbody");
		NativeFieldInfoPtr_m_solver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "m_solver");
		NativeFieldInfoPtr_m_wheels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "m_wheels");
		NativeFieldInfoPtr_m_wheelState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "m_wheelState");
		NativeFieldInfoPtr_m_localAcceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "m_localAcceleration");
		NativeFieldInfoPtr_m_lastVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "m_lastVelocity");
		NativeFieldInfoPtr_m_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "m_speed");
		NativeFieldInfoPtr_m_speedAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "m_speedAngle");
		NativeFieldInfoPtr__initialized_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "<initialized>k__BackingField");
		NativeFieldInfoPtr__groundMaterialManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "<groundMaterialManager>k__BackingField");
		NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "data");
		NativeFieldInfoPtr_m_colliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "m_colliders");
		NativeFieldInfoPtr_m_colLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "m_colLayers");
		NativeFieldInfoPtr_m_paused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "m_paused");
		NativeFieldInfoPtr_m_singleFixedStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "m_singleFixedStep");
		NativeFieldInfoPtr_m_singleUpdateStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "m_singleUpdateStep");
		NativeFieldInfoPtr_m_activeBehaviours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "m_activeBehaviours");
		NativeFieldInfoPtr_showContactGizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "showContactGizmos");
		NativeFieldInfoPtr_disableContactProcessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "disableContactProcessing");
		NativeFieldInfoPtr_onImpact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "onImpact");
		NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "vehicle");
		NativeFieldInfoPtr__lastContactedCollider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "<lastContactedCollider>k__BackingField");
		NativeFieldInfoPtr_impactThreeshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "impactThreeshold");
		NativeFieldInfoPtr_impactInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "impactInterval");
		NativeFieldInfoPtr_impactIntervalRandom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "impactIntervalRandom");
		NativeFieldInfoPtr_impactMinSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "impactMinSpeed");
		NativeFieldInfoPtr_m_sumImpactCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "m_sumImpactCount");
		NativeFieldInfoPtr_m_sumImpactPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "m_sumImpactPosition");
		NativeFieldInfoPtr_m_sumImpactVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "m_sumImpactVelocity");
		NativeFieldInfoPtr_m_sumImpactHardness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "m_sumImpactHardness");
		NativeFieldInfoPtr_m_lastImpactTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "m_lastImpactTime");
		NativeFieldInfoPtr_m_localDragPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "m_localDragPosition");
		NativeFieldInfoPtr_m_localDragVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "m_localDragVelocity");
		NativeFieldInfoPtr_m_localDragHardness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "m_localDragHardness");
		NativeFieldInfoPtr_m_lastImpactedMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "m_lastImpactedMaterial");
		NativeFieldInfoPtr_m_impactedGroundMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, "m_impactedGroundMaterial");
		NativeMethodInfoPtr_get_cachedTransform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671289);
		NativeMethodInfoPtr_get_cachedRigidbody_Public_get_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671290);
		NativeMethodInfoPtr_get_initialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671291);
		NativeMethodInfoPtr_set_initialized_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671292);
		NativeMethodInfoPtr_get_groundMaterialManager_Public_get_GroundMaterialManagerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671293);
		NativeMethodInfoPtr_set_groundMaterialManager_Public_set_Void_GroundMaterialManagerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671294);
		NativeMethodInfoPtr_get_wheelCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671295);
		NativeMethodInfoPtr_get_wheelState_Public_get_ArrayOf_WheelState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671296);
		NativeMethodInfoPtr_get_speed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671297);
		NativeMethodInfoPtr_get_speedAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671298);
		NativeMethodInfoPtr_get_localAcceleration_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671299);
		NativeMethodInfoPtr_GetWheelLocalPosition_Public_Vector3_VPWheelCollider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671300);
		NativeMethodInfoPtr_GetTangentVelocity_Public_Vector3_Vector3_Vector3_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671301);
		NativeMethodInfoPtr_NotifyCollidersChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671302);
		NativeMethodInfoPtr_get_paused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671303);
		NativeMethodInfoPtr_set_paused_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671304);
		NativeMethodInfoPtr_SingleStep_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671305);
		NativeMethodInfoPtr_Reposition_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671306);
		NativeMethodInfoPtr_SetWheelRadius_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671307);
		NativeMethodInfoPtr_GetWheelRadius_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671308);
		NativeMethodInfoPtr_SetWheelTireFriction_Public_Void_Int32_TireFriction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671309);
		NativeMethodInfoPtr_GetWheelTireFriction_Public_TireFriction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671310);
		NativeMethodInfoPtr_GetWheelAngularVelocityForSlip_Public_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671311);
		NativeMethodInfoPtr_GetWheelPeakSlip_Public_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671312);
		NativeMethodInfoPtr_GetWheelAdherentSlip_Public_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671313);
		NativeMethodInfoPtr_DisableCollidersRaycast_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671314);
		NativeMethodInfoPtr_EnableCollidersRaycast_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671315);
		NativeMethodInfoPtr_ComputeVehicleSpeed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671316);
		NativeMethodInfoPtr_ComputeLocalAcceleration_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671317);
		NativeMethodInfoPtr_ConfigureCenterOfMass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671318);
		NativeMethodInfoPtr_ComputeCombinedSlip_Private_Static_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671319);
		NativeMethodInfoPtr_get_wheels_Protected_get_ArrayOf_Wheel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671320);
		NativeMethodInfoPtr_SetNumberOfWheels_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671321);
		NativeMethodInfoPtr_OnInitialize_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671322);
		NativeMethodInfoPtr_DoUpdateBlocks_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671323);
		NativeMethodInfoPtr_DoUpdateData_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671324);
		NativeMethodInfoPtr_OnUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671325);
		NativeMethodInfoPtr_GetInternalObject_Public_Virtual_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671326);
		NativeMethodInfoPtr_GetWheelIndex_Public_Virtual_New_Int32_Int32_WheelPos_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671327);
		NativeMethodInfoPtr_CalculateSuspensionTravel_Private_Void_WheelState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671328);
		NativeMethodInfoPtr_CalculateSuspensionForces_Private_Void_WheelState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671329);
		NativeMethodInfoPtr_CalculateDownforce_Private_Void_WheelState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671330);
		NativeMethodInfoPtr_CalculateLocalFrame_Private_Void_WheelState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671331);
		NativeMethodInfoPtr_ApplyTireForce_Private_Void_WheelState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671332);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671333);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671334);
		NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671335);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671336);
		NativeMethodInfoPtr_EnableVehicleBehaviours_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671337);
		NativeMethodInfoPtr_DisableVehicleBehaviours_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671338);
		NativeMethodInfoPtr_FixedUpdateVehicleBehaviours_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671339);
		NativeMethodInfoPtr_UpdateVehicleBehaviours_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671340);
		NativeMethodInfoPtr_UpdateSuspensionBehaviours_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671341);
		NativeMethodInfoPtr_AddVehicleBehaviour_Private_Void_VehicleBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671342);
		NativeMethodInfoPtr_RemoveVehicleBehaviour_Private_Void_VehicleBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671343);
		NativeMethodInfoPtr_RegisterVehicleBehaviour_Public_Void_VehicleBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671344);
		NativeMethodInfoPtr_UnregisterVehicleBehaviour_Public_Void_VehicleBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671345);
		NativeMethodInfoPtr_NotifyReposition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671346);
		NativeMethodInfoPtr_NotifyEnterPause_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671347);
		NativeMethodInfoPtr_NotifyLeavePause_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671348);
		NativeMethodInfoPtr_get_localImpactPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671349);
		NativeMethodInfoPtr_get_localImpactVelocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671350);
		NativeMethodInfoPtr_get_isHardImpact_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671351);
		NativeMethodInfoPtr_get_localDragPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671352);
		NativeMethodInfoPtr_get_localDragVelocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671353);
		NativeMethodInfoPtr_get_isHardDrag_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671354);
		NativeMethodInfoPtr_get_lastContactedCollider_Public_get_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671355);
		NativeMethodInfoPtr_set_lastContactedCollider_Private_set_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671356);
		NativeMethodInfoPtr_ClearCollisionData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671357);
		NativeMethodInfoPtr_ProcessImpacts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671358);
		NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671359);
		NativeMethodInfoPtr_OnCollisionStay_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671360);
		NativeMethodInfoPtr_OnCollision_Private_Void_Collision_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671361);
		NativeMethodInfoPtr_UpdateDragState_Private_Void_Vector3_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671362);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleBase>.NativeClassPtr, 100671363);
	}

	public VehicleBase(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
