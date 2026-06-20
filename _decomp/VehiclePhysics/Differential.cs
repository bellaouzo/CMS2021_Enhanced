using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace VehiclePhysics;

public class Differential : Block
{
	public enum Type
	{
		Open,
		Locked,
		Viscous,
		ClutchPack,
		TorqueBias,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Type>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static Type()
		{
			Il2CppClassPointerStore<Type>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Differential>.NativeClassPtr, "Type");
		}

	}

	[System.Serializable]
	public class Settings : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_type;

		private static readonly System.IntPtr NativeFieldInfoPtr_gearRatio;

		private static readonly System.IntPtr NativeFieldInfoPtr_preload;

		private static readonly System.IntPtr NativeFieldInfoPtr_powerStiffness;

		private static readonly System.IntPtr NativeFieldInfoPtr_coastStiffness;

		private static readonly System.IntPtr NativeFieldInfoPtr_clutchPreload;

		private static readonly System.IntPtr NativeFieldInfoPtr_clutchPackFriction;

		private static readonly System.IntPtr NativeFieldInfoPtr_powerAngle;

		private static readonly System.IntPtr NativeFieldInfoPtr_coastAngle;

		private static readonly System.IntPtr NativeFieldInfoPtr_torquePreload;

		private static readonly System.IntPtr NativeFieldInfoPtr_powerRatio;

		private static readonly System.IntPtr NativeFieldInfoPtr_coastRatio;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Settings>.NativeClassPtr));

		public unsafe Type type
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
				return *(Type*)num;
			}
			set
			{
				*(Type*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = type;
			}
		}

		public unsafe float gearRatio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearRatio);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearRatio)) = num;
			}
		}

		public unsafe float preload
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preload);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preload)) = num;
			}
		}

		public unsafe float powerStiffness
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_powerStiffness);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_powerStiffness)) = num;
			}
		}

		public unsafe float coastStiffness
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coastStiffness);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coastStiffness)) = num;
			}
		}

		public unsafe float clutchPreload
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clutchPreload);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clutchPreload)) = num;
			}
		}

		public unsafe float clutchPackFriction
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clutchPackFriction);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clutchPackFriction)) = num;
			}
		}

		public unsafe float powerAngle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_powerAngle);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_powerAngle)) = num;
			}
		}

		public unsafe float coastAngle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coastAngle);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coastAngle)) = num;
			}
		}

		public unsafe float torquePreload
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_torquePreload);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_torquePreload)) = num;
			}
		}

		public unsafe float powerRatio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_powerRatio);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_powerRatio)) = num;
			}
		}

		public unsafe float coastRatio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coastRatio);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coastRatio)) = num;
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
			Il2CppClassPointerStore<Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Differential>.NativeClassPtr, "Settings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Settings>.NativeClassPtr);
			NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "type");
			NativeFieldInfoPtr_gearRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "gearRatio");
			NativeFieldInfoPtr_preload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "preload");
			NativeFieldInfoPtr_powerStiffness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "powerStiffness");
			NativeFieldInfoPtr_coastStiffness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "coastStiffness");
			NativeFieldInfoPtr_clutchPreload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "clutchPreload");
			NativeFieldInfoPtr_clutchPackFriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "clutchPackFriction");
			NativeFieldInfoPtr_powerAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "powerAngle");
			NativeFieldInfoPtr_coastAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "coastAngle");
			NativeFieldInfoPtr_torquePreload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "torquePreload");
			NativeFieldInfoPtr_powerRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "powerRatio");
			NativeFieldInfoPtr_coastRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "coastRatio");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100671416);
		}

		public Settings(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_settings;

	private static readonly System.IntPtr NativeFieldInfoPtr_damping;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_input;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_output1;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_output2;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckConnections_Public_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeStateUpstream_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateTorqueDownstream_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeLockingTorque_Private_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Differential>.NativeClassPtr));

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

	public unsafe Connection m_input
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_input);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Connection(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_input), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Connection m_output1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_output1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Connection(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_output1), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Connection m_output2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_output2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Connection(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_output2), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124349, XrefRangeEnd = 124355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public new unsafe void ComputeStateUpstream()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_ComputeStateUpstream_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124355, XrefRangeEnd = 124381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void EvaluateTorqueDownstream()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_EvaluateTorqueDownstream_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 124381, RefRangeEnd = 124385, XrefRangeStart = 124381, XrefRangeEnd = 124381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float ComputeLockingTorque(float dt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeLockingTorque_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 124391, RefRangeEnd = 124409, XrefRangeStart = 124385, XrefRangeEnd = 124391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Differential()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Differential>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Differential()
	{
		Il2CppClassPointerStore<Differential>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "Differential");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Differential>.NativeClassPtr);
		NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Differential>.NativeClassPtr, "settings");
		NativeFieldInfoPtr_damping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Differential>.NativeClassPtr, "damping");
		NativeFieldInfoPtr_m_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Differential>.NativeClassPtr, "m_input");
		NativeFieldInfoPtr_m_output1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Differential>.NativeClassPtr, "m_output1");
		NativeFieldInfoPtr_m_output2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Differential>.NativeClassPtr, "m_output2");
		NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Differential>.NativeClassPtr, 100671410);
		NativeMethodInfoPtr_CheckConnections_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Differential>.NativeClassPtr, 100671411);
		NativeMethodInfoPtr_ComputeStateUpstream_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Differential>.NativeClassPtr, 100671412);
		NativeMethodInfoPtr_EvaluateTorqueDownstream_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Differential>.NativeClassPtr, 100671413);
		NativeMethodInfoPtr_ComputeLockingTorque_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Differential>.NativeClassPtr, 100671414);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Differential>.NativeClassPtr, 100671415);
	}

	public Differential(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
