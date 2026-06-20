using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class VPHeadMotion : MonoBehaviour
{
	public enum UpdateMode
	{
		OnEnable,
		OnFixedUpdate,
		OnFixedUpdateInEditorOnly,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UpdateMode>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static UpdateMode()
		{
			Il2CppClassPointerStore<UpdateMode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr, "UpdateMode");
		}

	}

	[System.Serializable]
	public class HorizontalMotion : Il2CppSystem.Object
	{
		public enum Mode
		{
			Disabled,
			Tilt,
			Slide,
			// error: nested types are not permitted in C#.
			[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Mode>.NativeClassPtr));
			,
			// error: nested types are not permitted in C#.
			static Mode()
			{
				Il2CppClassPointerStore<Mode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HorizontalMotion>.NativeClassPtr, "Mode");
			}

		}

		private static readonly System.IntPtr NativeFieldInfoPtr_mode;

		private static readonly System.IntPtr NativeFieldInfoPtr_springRate;

		private static readonly System.IntPtr NativeFieldInfoPtr_damperRate;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetLinealMotion_Public_ConfigurableJointMotion_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetAngularMotion_Public_ConfigurableJointMotion_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetLinealDrive_Public_JointDrive_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetAngularDrive_Public_JointDrive_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<HorizontalMotion>.NativeClassPtr));

		public unsafe Mode mode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode);
				return *(Mode*)num;
			}
			set
			{
				*(Mode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode)) = mode;
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

		public unsafe float damperRate
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damperRate);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damperRate)) = num;
			}
		}

		[CallerCount(0)]
		public unsafe ConfigurableJointMotion GetLinealMotion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLinealMotion_Public_ConfigurableJointMotion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(ConfigurableJointMotion*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public unsafe ConfigurableJointMotion GetAngularMotion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAngularMotion_Public_ConfigurableJointMotion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(ConfigurableJointMotion*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public unsafe JointDrive GetLinealDrive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLinealDrive_Public_JointDrive_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(JointDrive*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public unsafe JointDrive GetAngularDrive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAngularDrive_Public_JointDrive_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(JointDrive*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public unsafe HorizontalMotion()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HorizontalMotion>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static HorizontalMotion()
		{
			Il2CppClassPointerStore<HorizontalMotion>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr, "HorizontalMotion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HorizontalMotion>.NativeClassPtr);
			NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalMotion>.NativeClassPtr, "mode");
			NativeFieldInfoPtr_springRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalMotion>.NativeClassPtr, "springRate");
			NativeFieldInfoPtr_damperRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalMotion>.NativeClassPtr, "damperRate");
			NativeMethodInfoPtr_GetLinealMotion_Public_ConfigurableJointMotion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalMotion>.NativeClassPtr, 100670589);
			NativeMethodInfoPtr_GetAngularMotion_Public_ConfigurableJointMotion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalMotion>.NativeClassPtr, 100670590);
			NativeMethodInfoPtr_GetLinealDrive_Public_JointDrive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalMotion>.NativeClassPtr, 100670591);
			NativeMethodInfoPtr_GetAngularDrive_Public_JointDrive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalMotion>.NativeClassPtr, 100670592);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalMotion>.NativeClassPtr, 100670593);
		}

		public HorizontalMotion(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[System.Serializable]
	public class VerticalMotion : Il2CppSystem.Object
	{
		public enum Mode
		{
			Disabled,
			Slide,
			// error: nested types are not permitted in C#.
			[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Mode>.NativeClassPtr));
			,
			// error: nested types are not permitted in C#.
			static Mode()
			{
				Il2CppClassPointerStore<Mode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VerticalMotion>.NativeClassPtr, "Mode");
			}

		}

		private static readonly System.IntPtr NativeFieldInfoPtr_mode;

		private static readonly System.IntPtr NativeFieldInfoPtr_springRate;

		private static readonly System.IntPtr NativeFieldInfoPtr_damperRate;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetLinealMotion_Public_ConfigurableJointMotion_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetLinealDrive_Public_JointDrive_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VerticalMotion>.NativeClassPtr));

		public unsafe Mode mode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode);
				return *(Mode*)num;
			}
			set
			{
				*(Mode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode)) = mode;
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

		public unsafe float damperRate
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damperRate);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damperRate)) = num;
			}
		}

		[CallerCount(0)]
		public unsafe ConfigurableJointMotion GetLinealMotion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLinealMotion_Public_ConfigurableJointMotion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(ConfigurableJointMotion*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public unsafe JointDrive GetLinealDrive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLinealDrive_Public_JointDrive_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(JointDrive*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public unsafe VerticalMotion()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VerticalMotion>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static VerticalMotion()
		{
			Il2CppClassPointerStore<VerticalMotion>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr, "VerticalMotion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VerticalMotion>.NativeClassPtr);
			NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalMotion>.NativeClassPtr, "mode");
			NativeFieldInfoPtr_springRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalMotion>.NativeClassPtr, "springRate");
			NativeFieldInfoPtr_damperRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalMotion>.NativeClassPtr, "damperRate");
			NativeMethodInfoPtr_GetLinealMotion_Public_ConfigurableJointMotion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalMotion>.NativeClassPtr, 100670594);
			NativeMethodInfoPtr_GetLinealDrive_Public_JointDrive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalMotion>.NativeClassPtr, 100670595);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalMotion>.NativeClassPtr, 100670596);
		}

		public VerticalMotion(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_updateMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_longitudinal;

	private static readonly System.IntPtr NativeFieldInfoPtr_lateral;

	private static readonly System.IntPtr NativeFieldInfoPtr_vertical;

	private static readonly System.IntPtr NativeFieldInfoPtr_tiltRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxTiltAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_inertialMass;

	private static readonly System.IntPtr NativeFieldInfoPtr_useGravity;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_rigidbody;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_parentRigidbody;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_anchorPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_originalPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_originalRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_joint;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_limit;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_motionBody_Public_get_Rigidbody_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_localPosition_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_localPosition_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureJointAndBody_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr));

	public unsafe UpdateMode updateMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateMode);
			return *(UpdateMode*)num;
		}
		set
		{
			*(UpdateMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateMode)) = updateMode;
		}
	}

	public unsafe HorizontalMotion longitudinal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_longitudinal);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new HorizontalMotion(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_longitudinal), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe HorizontalMotion lateral
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lateral);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new HorizontalMotion(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lateral), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VerticalMotion vertical
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertical);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VerticalMotion(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertical), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float tiltRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tiltRadius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tiltRadius)) = num;
		}
	}

	public unsafe float maxDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDistance)) = num;
		}
	}

	public unsafe float maxTiltAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxTiltAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxTiltAngle)) = num;
		}
	}

	public unsafe float inertialMass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inertialMass);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inertialMass)) = num;
		}
	}

	public unsafe bool useGravity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useGravity);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useGravity)) = flag;
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

	public unsafe Rigidbody m_parentRigidbody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_parentRigidbody);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Rigidbody(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_parentRigidbody), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector3 m_anchorPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_anchorPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_anchorPosition)) = vector;
		}
	}

	public unsafe Vector3 m_originalPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_originalPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_originalPosition)) = vector;
		}
	}

	public unsafe Quaternion m_originalRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_originalRotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_originalRotation)) = quaternion;
		}
	}

	public unsafe ConfigurableJoint m_joint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_joint);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ConfigurableJoint(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_joint), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SoftJointLimit m_limit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_limit);
			return *(SoftJointLimit*)num;
		}
		set
		{
			*(SoftJointLimit*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_limit)) = softJointLimit;
		}
	}

	public unsafe Rigidbody motionBody
	{
		[CallerCount(1)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_motionBody_Public_get_Rigidbody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Rigidbody(intPtr) : null;
		}
	}

	public unsafe Vector3 localPosition
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_localPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115495, XrefRangeEnd = 115508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_localPosition_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115508, XrefRangeEnd = 115562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115562, XrefRangeEnd = 115578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115578, XrefRangeEnd = 115621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115621, XrefRangeEnd = 115641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 115731, RefRangeEnd = 115733, XrefRangeStart = 115641, XrefRangeEnd = 115731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureJointAndBody()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureJointAndBody_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115733, XrefRangeEnd = 115736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPHeadMotion()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPHeadMotion()
	{
		Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPHeadMotion");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr);
		NativeFieldInfoPtr_updateMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr, "updateMode");
		NativeFieldInfoPtr_longitudinal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr, "longitudinal");
		NativeFieldInfoPtr_lateral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr, "lateral");
		NativeFieldInfoPtr_vertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr, "vertical");
		NativeFieldInfoPtr_tiltRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr, "tiltRadius");
		NativeFieldInfoPtr_maxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr, "maxDistance");
		NativeFieldInfoPtr_maxTiltAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr, "maxTiltAngle");
		NativeFieldInfoPtr_inertialMass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr, "inertialMass");
		NativeFieldInfoPtr_useGravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr, "useGravity");
		NativeFieldInfoPtr_m_rigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr, "m_rigidbody");
		NativeFieldInfoPtr_m_parentRigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr, "m_parentRigidbody");
		NativeFieldInfoPtr_m_anchorPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr, "m_anchorPosition");
		NativeFieldInfoPtr_m_originalPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr, "m_originalPosition");
		NativeFieldInfoPtr_m_originalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr, "m_originalRotation");
		NativeFieldInfoPtr_m_joint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr, "m_joint");
		NativeFieldInfoPtr_m_limit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr, "m_limit");
		NativeMethodInfoPtr_get_motionBody_Public_get_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr, 100670580);
		NativeMethodInfoPtr_get_localPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr, 100670581);
		NativeMethodInfoPtr_set_localPosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr, 100670582);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr, 100670583);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr, 100670584);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr, 100670585);
		NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr, 100670586);
		NativeMethodInfoPtr_ConfigureJointAndBody_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr, 100670587);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPHeadMotion>.NativeClassPtr, 100670588);
	}

	public VPHeadMotion(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
