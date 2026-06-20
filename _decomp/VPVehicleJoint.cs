using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class VPVehicleJoint : MonoBehaviour
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
			Il2CppClassPointerStore<UpdateMode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPVehicleJoint>.NativeClassPtr, "UpdateMode");
		}

	}

	[System.Serializable]
	public class JointMotion : Il2CppSystem.Object
	{
		public enum Mode
		{
			Locked,
			Free,
			DampedSpring,
			// error: nested types are not permitted in C#.
			[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Mode>.NativeClassPtr));
			,
			// error: nested types are not permitted in C#.
			static Mode()
			{
				Il2CppClassPointerStore<Mode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JointMotion>.NativeClassPtr, "Mode");
			}

		}

		private static readonly System.IntPtr NativeFieldInfoPtr_mode;

		private static readonly System.IntPtr NativeFieldInfoPtr_spring;

		private static readonly System.IntPtr NativeFieldInfoPtr_damper;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxForce;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetJointMotion_Public_ConfigurableJointMotion_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetJointDrive_Public_JointDrive_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<JointMotion>.NativeClassPtr));

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

		public unsafe float spring
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spring);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spring)) = num;
			}
		}

		public unsafe float damper
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damper);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damper)) = num;
			}
		}

		public unsafe float maxForce
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxForce);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxForce)) = num;
			}
		}

		[CallerCount(0)]
		public unsafe ConfigurableJointMotion GetJointMotion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetJointMotion_Public_ConfigurableJointMotion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(ConfigurableJointMotion*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public unsafe JointDrive GetJointDrive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetJointDrive_Public_JointDrive_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(JointDrive*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public unsafe JointMotion()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JointMotion>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static JointMotion()
		{
			Il2CppClassPointerStore<JointMotion>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPVehicleJoint>.NativeClassPtr, "JointMotion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JointMotion>.NativeClassPtr);
			NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JointMotion>.NativeClassPtr, "mode");
			NativeFieldInfoPtr_spring = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JointMotion>.NativeClassPtr, "spring");
			NativeFieldInfoPtr_damper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JointMotion>.NativeClassPtr, "damper");
			NativeFieldInfoPtr_maxForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JointMotion>.NativeClassPtr, "maxForce");
			NativeMethodInfoPtr_GetJointMotion_Public_ConfigurableJointMotion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JointMotion>.NativeClassPtr, 100670624);
			NativeMethodInfoPtr_GetJointDrive_Public_JointDrive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JointMotion>.NativeClassPtr, 100670625);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JointMotion>.NativeClassPtr, 100670626);
		}

		public JointMotion(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_thisAnchor;

	private static readonly System.IntPtr NativeFieldInfoPtr_otherAnchor;

	private static readonly System.IntPtr NativeFieldInfoPtr_updateMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr_xMotion;

	private static readonly System.IntPtr NativeFieldInfoPtr_yMotion;

	private static readonly System.IntPtr NativeFieldInfoPtr_zMotion;

	private static readonly System.IntPtr NativeFieldInfoPtr_angularXMotion;

	private static readonly System.IntPtr NativeFieldInfoPtr_angularYMotion;

	private static readonly System.IntPtr NativeFieldInfoPtr_angularZMotion;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_thisRigidbody;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_otherRigidbody;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_joint;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureJoint_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPVehicleJoint>.NativeClassPtr));

	public unsafe Transform thisAnchor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisAnchor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thisAnchor), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform otherAnchor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_otherAnchor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_otherAnchor), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

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

	public unsafe bool debugLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugLabel);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugLabel)) = flag;
		}
	}

	public unsafe JointMotion xMotion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xMotion);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new JointMotion(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xMotion), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe JointMotion yMotion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yMotion);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new JointMotion(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yMotion), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe JointMotion zMotion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zMotion);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new JointMotion(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zMotion), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe JointMotion angularXMotion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angularXMotion);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new JointMotion(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angularXMotion), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe JointMotion angularYMotion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angularYMotion);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new JointMotion(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angularYMotion), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe JointMotion angularZMotion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angularZMotion);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new JointMotion(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angularZMotion), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Rigidbody m_thisRigidbody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_thisRigidbody);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Rigidbody(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_thisRigidbody), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Rigidbody m_otherRigidbody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_otherRigidbody);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Rigidbody(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_otherRigidbody), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116053, XrefRangeEnd = 116132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116132, XrefRangeEnd = 116133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116133, XrefRangeEnd = 116137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 116200, RefRangeEnd = 116202, XrefRangeStart = 116137, XrefRangeEnd = 116200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureJoint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureJoint_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe VPVehicleJoint()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPVehicleJoint>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPVehicleJoint()
	{
		Il2CppClassPointerStore<VPVehicleJoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPVehicleJoint");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPVehicleJoint>.NativeClassPtr);
		NativeFieldInfoPtr_thisAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleJoint>.NativeClassPtr, "thisAnchor");
		NativeFieldInfoPtr_otherAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleJoint>.NativeClassPtr, "otherAnchor");
		NativeFieldInfoPtr_updateMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleJoint>.NativeClassPtr, "updateMode");
		NativeFieldInfoPtr_debugLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleJoint>.NativeClassPtr, "debugLabel");
		NativeFieldInfoPtr_xMotion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleJoint>.NativeClassPtr, "xMotion");
		NativeFieldInfoPtr_yMotion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleJoint>.NativeClassPtr, "yMotion");
		NativeFieldInfoPtr_zMotion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleJoint>.NativeClassPtr, "zMotion");
		NativeFieldInfoPtr_angularXMotion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleJoint>.NativeClassPtr, "angularXMotion");
		NativeFieldInfoPtr_angularYMotion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleJoint>.NativeClassPtr, "angularYMotion");
		NativeFieldInfoPtr_angularZMotion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleJoint>.NativeClassPtr, "angularZMotion");
		NativeFieldInfoPtr_m_thisRigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleJoint>.NativeClassPtr, "m_thisRigidbody");
		NativeFieldInfoPtr_m_otherRigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleJoint>.NativeClassPtr, "m_otherRigidbody");
		NativeFieldInfoPtr_m_joint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPVehicleJoint>.NativeClassPtr, "m_joint");
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVehicleJoint>.NativeClassPtr, 100670619);
		NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVehicleJoint>.NativeClassPtr, 100670620);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVehicleJoint>.NativeClassPtr, 100670621);
		NativeMethodInfoPtr_ConfigureJoint_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVehicleJoint>.NativeClassPtr, 100670622);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPVehicleJoint>.NativeClassPtr, 100670623);
	}

	public VPVehicleJoint(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
