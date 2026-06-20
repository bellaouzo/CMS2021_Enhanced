using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace VehiclePhysics;

public class Driveline : Il2CppSystem.Object
{
	public enum DrivenAxles
	{
		None,
		SingleAxle,
		TwoAxles,
		ThreeAxles,
		FourAxles,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DrivenAxles>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static DrivenAxles()
		{
			Il2CppClassPointerStore<DrivenAxles>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Driveline>.NativeClassPtr, "DrivenAxles");
		}

	}

	public enum TwoAxlesConfig
	{
		CenterDifferential,
		TorqueSplitter,
		LinkedSides,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TwoAxlesConfig>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static TwoAxlesConfig()
		{
			Il2CppClassPointerStore<TwoAxlesConfig>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Driveline>.NativeClassPtr, "TwoAxlesConfig");
		}

	}

	public enum ThreeAxlesConfig
	{
		SideLinkedAndCenterDifferential,
		SideLinkedAndTorqueSplitterAtLinkedAxles,
		SideLinkedAndTorqueSplitterAtIndependentAxle,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ThreeAxlesConfig>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static ThreeAxlesConfig()
		{
			Il2CppClassPointerStore<ThreeAxlesConfig>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Driveline>.NativeClassPtr, "ThreeAxlesConfig");
		}

	}

	public enum FourAxlesConfig
	{
		DualInterAxleAndCenterDifferential,
		DualInterAxleDifferentialAndTorqueSplitter,
		DualLinkedSidesAndCenterDifferential,
		DualLinkedSidesAndTorqueSplitter,
		FullLinkedSides,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<FourAxlesConfig>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static FourAxlesConfig()
		{
			Il2CppClassPointerStore<FourAxlesConfig>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Driveline>.NativeClassPtr, "FourAxlesConfig");
		}

	}

	public enum Override
	{
		None,
		ForceLocked,
		ForceUnlocked,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Override>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static Override()
		{
			Il2CppClassPointerStore<Override>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Driveline>.NativeClassPtr, "Override");
		}

	}

	[System.Serializable]
	public class Settings : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_drivenAxles;

		private static readonly System.IntPtr NativeFieldInfoPtr_firstDrivenAxle;

		private static readonly System.IntPtr NativeFieldInfoPtr_secondDrivenAxle;

		private static readonly System.IntPtr NativeFieldInfoPtr_thirdDrivenAxle;

		private static readonly System.IntPtr NativeFieldInfoPtr_fourthDrivenAxle;

		private static readonly System.IntPtr NativeFieldInfoPtr_twoDrivenAxlesConfig;

		private static readonly System.IntPtr NativeFieldInfoPtr_threeDrivenAxlesConfig;

		private static readonly System.IntPtr NativeFieldInfoPtr_fourDrivenAxlesConfig;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_hasInterAxleDifferential_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_hasCenterDifferential_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_hasTorqueSplitter_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Settings>.NativeClassPtr));

		public unsafe DrivenAxles drivenAxles
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drivenAxles);
				return *(DrivenAxles*)num;
			}
			set
			{
				*(DrivenAxles*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drivenAxles)) = drivenAxles;
			}
		}

		public unsafe int firstDrivenAxle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstDrivenAxle);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstDrivenAxle)) = num;
			}
		}

		public unsafe int secondDrivenAxle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondDrivenAxle);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondDrivenAxle)) = num;
			}
		}

		public unsafe int thirdDrivenAxle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thirdDrivenAxle);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thirdDrivenAxle)) = num;
			}
		}

		public unsafe int fourthDrivenAxle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fourthDrivenAxle);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fourthDrivenAxle)) = num;
			}
		}

		public unsafe TwoAxlesConfig twoDrivenAxlesConfig
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_twoDrivenAxlesConfig);
				return *(TwoAxlesConfig*)num;
			}
			set
			{
				*(TwoAxlesConfig*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_twoDrivenAxlesConfig)) = twoAxlesConfig;
			}
		}

		public unsafe ThreeAxlesConfig threeDrivenAxlesConfig
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_threeDrivenAxlesConfig);
				return *(ThreeAxlesConfig*)num;
			}
			set
			{
				*(ThreeAxlesConfig*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_threeDrivenAxlesConfig)) = threeAxlesConfig;
			}
		}

		public unsafe FourAxlesConfig fourDrivenAxlesConfig
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fourDrivenAxlesConfig);
				return *(FourAxlesConfig*)num;
			}
			set
			{
				*(FourAxlesConfig*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fourDrivenAxlesConfig)) = fourAxlesConfig;
			}
		}

		public unsafe bool hasInterAxleDifferential
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasInterAxleDifferential_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		public unsafe bool hasCenterDifferential
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasCenterDifferential_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		public unsafe bool hasTorqueSplitter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasTorqueSplitter_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
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
			Il2CppClassPointerStore<Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Driveline>.NativeClassPtr, "Settings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Settings>.NativeClassPtr);
			NativeFieldInfoPtr_drivenAxles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "drivenAxles");
			NativeFieldInfoPtr_firstDrivenAxle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "firstDrivenAxle");
			NativeFieldInfoPtr_secondDrivenAxle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "secondDrivenAxle");
			NativeFieldInfoPtr_thirdDrivenAxle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "thirdDrivenAxle");
			NativeFieldInfoPtr_fourthDrivenAxle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "fourthDrivenAxle");
			NativeFieldInfoPtr_twoDrivenAxlesConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "twoDrivenAxlesConfig");
			NativeFieldInfoPtr_threeDrivenAxlesConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "threeDrivenAxlesConfig");
			NativeFieldInfoPtr_fourDrivenAxlesConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "fourDrivenAxlesConfig");
			NativeMethodInfoPtr_get_hasInterAxleDifferential_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100671616);
			NativeMethodInfoPtr_get_hasCenterDifferential_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100671617);
			NativeMethodInfoPtr_get_hasTorqueSplitter_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100671618);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100671619);
		}

		public Settings(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_settings;

	private static readonly System.IntPtr NativeFieldInfoPtr_axleDifferential;

	private static readonly System.IntPtr NativeFieldInfoPtr_centerDifferential;

	private static readonly System.IntPtr NativeFieldInfoPtr_interAxleDifferential;

	private static readonly System.IntPtr NativeFieldInfoPtr_torqueSplitter;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_differentialOverride;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_differentialType;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_drivelineOverride;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_drivelineDifferentialType;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_torqueSplitterStiffness;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_differentialOverride_Public_get_Override_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_differentialOverride_Public_set_Void_Override_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_drivelineOverride_Public_get_Override_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_drivelineOverride_Public_set_Void_Override_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAxleFinalRatio_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSingleAxleFinalRatio_Private_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTwoAxlesFinalRatio_Private_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetThreeAxlesFinalRatio_Private_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFourAxlesFinalRatio_Private_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupDriveline_Public_Void_ArrayOf_Wheel_Block_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupSingleAxleDriveline_Private_Void_ArrayOf_Wheel_Block_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupTwoAxlesDriveline_Private_Void_ArrayOf_Wheel_Block_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupThreeAxlesDriveline_Private_Void_ArrayOf_Wheel_Block_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupFourAxlesDriveline_Private_Void_ArrayOf_Wheel_Block_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Driveline>.NativeClassPtr));

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

	public unsafe Differential.Settings axleDifferential
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_axleDifferential);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Differential.Settings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_axleDifferential), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Differential.Settings centerDifferential
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_centerDifferential);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Differential.Settings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_centerDifferential), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Differential.Settings interAxleDifferential
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interAxleDifferential);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Differential.Settings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interAxleDifferential), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TorqueSplitter.Settings torqueSplitter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_torqueSplitter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new TorqueSplitter.Settings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_torqueSplitter), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Override m_differentialOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_differentialOverride);
			return *(Override*)num;
		}
		set
		{
			*(Override*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_differentialOverride)) = obj;
		}
	}

	public unsafe Differential.Type m_differentialType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_differentialType);
			return *(Differential.Type*)num;
		}
		set
		{
			*(Differential.Type*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_differentialType)) = type;
		}
	}

	public unsafe Override m_drivelineOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_drivelineOverride);
			return *(Override*)num;
		}
		set
		{
			*(Override*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_drivelineOverride)) = obj;
		}
	}

	public unsafe Differential.Type m_drivelineDifferentialType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_drivelineDifferentialType);
			return *(Differential.Type*)num;
		}
		set
		{
			*(Differential.Type*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_drivelineDifferentialType)) = type;
		}
	}

	public unsafe float m_torqueSplitterStiffness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_torqueSplitterStiffness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_torqueSplitterStiffness)) = num;
		}
	}

	public unsafe Override differentialOverride
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_differentialOverride_Public_get_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Override*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_differentialOverride_Public_set_Void_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Override drivelineOverride
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124965, RefRangeEnd = 124966, XrefRangeStart = 124965, XrefRangeEnd = 124965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_drivelineOverride_Public_get_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Override*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124966, RefRangeEnd = 124967, XrefRangeStart = 124966, XrefRangeEnd = 124966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_drivelineOverride_Public_set_Void_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 124967, RefRangeEnd = 124969, XrefRangeStart = 124967, XrefRangeEnd = 124967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetAxleFinalRatio(int axle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&axle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAxleFinalRatio_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe float GetSingleAxleFinalRatio(int axle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&axle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSingleAxleFinalRatio_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe float GetTwoAxlesFinalRatio(int axle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&axle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTwoAxlesFinalRatio_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe float GetThreeAxlesFinalRatio(int axle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&axle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetThreeAxlesFinalRatio_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe float GetFourAxlesFinalRatio(int axle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&axle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFourAxlesFinalRatio_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124969, XrefRangeEnd = 124970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupDriveline(Il2CppReferenceArray<Wheel> wheels, Block powerTrainOutput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(wheels);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(powerTrainOutput);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupDriveline_Public_Void_ArrayOf_Wheel_Block_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124970, XrefRangeEnd = 124982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupSingleAxleDriveline(Il2CppReferenceArray<Wheel> wheels, Block powerTrainOutput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(wheels);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(powerTrainOutput);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupSingleAxleDriveline_Private_Void_ArrayOf_Wheel_Block_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124982, XrefRangeEnd = 125006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupTwoAxlesDriveline(Il2CppReferenceArray<Wheel> wheels, Block powerTrainOutput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(wheels);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(powerTrainOutput);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupTwoAxlesDriveline_Private_Void_ArrayOf_Wheel_Block_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125006, XrefRangeEnd = 125057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupThreeAxlesDriveline(Il2CppReferenceArray<Wheel> wheels, Block powerTrainOutput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(wheels);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(powerTrainOutput);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupThreeAxlesDriveline_Private_Void_ArrayOf_Wheel_Block_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 125114, RefRangeEnd = 125115, XrefRangeStart = 125057, XrefRangeEnd = 125114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupFourAxlesDriveline(Il2CppReferenceArray<Wheel> wheels, Block powerTrainOutput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(wheels);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(powerTrainOutput);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupFourAxlesDriveline_Private_Void_ArrayOf_Wheel_Block_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 125128, RefRangeEnd = 125129, XrefRangeStart = 125115, XrefRangeEnd = 125128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Driveline()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Driveline>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Driveline()
	{
		Il2CppClassPointerStore<Driveline>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "Driveline");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Driveline>.NativeClassPtr);
		NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Driveline>.NativeClassPtr, "settings");
		NativeFieldInfoPtr_axleDifferential = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Driveline>.NativeClassPtr, "axleDifferential");
		NativeFieldInfoPtr_centerDifferential = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Driveline>.NativeClassPtr, "centerDifferential");
		NativeFieldInfoPtr_interAxleDifferential = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Driveline>.NativeClassPtr, "interAxleDifferential");
		NativeFieldInfoPtr_torqueSplitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Driveline>.NativeClassPtr, "torqueSplitter");
		NativeFieldInfoPtr_m_differentialOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Driveline>.NativeClassPtr, "m_differentialOverride");
		NativeFieldInfoPtr_m_differentialType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Driveline>.NativeClassPtr, "m_differentialType");
		NativeFieldInfoPtr_m_drivelineOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Driveline>.NativeClassPtr, "m_drivelineOverride");
		NativeFieldInfoPtr_m_drivelineDifferentialType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Driveline>.NativeClassPtr, "m_drivelineDifferentialType");
		NativeFieldInfoPtr_m_torqueSplitterStiffness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Driveline>.NativeClassPtr, "m_torqueSplitterStiffness");
		NativeMethodInfoPtr_get_differentialOverride_Public_get_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Driveline>.NativeClassPtr, 100671601);
		NativeMethodInfoPtr_set_differentialOverride_Public_set_Void_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Driveline>.NativeClassPtr, 100671602);
		NativeMethodInfoPtr_get_drivelineOverride_Public_get_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Driveline>.NativeClassPtr, 100671603);
		NativeMethodInfoPtr_set_drivelineOverride_Public_set_Void_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Driveline>.NativeClassPtr, 100671604);
		NativeMethodInfoPtr_GetAxleFinalRatio_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Driveline>.NativeClassPtr, 100671605);
		NativeMethodInfoPtr_GetSingleAxleFinalRatio_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Driveline>.NativeClassPtr, 100671606);
		NativeMethodInfoPtr_GetTwoAxlesFinalRatio_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Driveline>.NativeClassPtr, 100671607);
		NativeMethodInfoPtr_GetThreeAxlesFinalRatio_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Driveline>.NativeClassPtr, 100671608);
		NativeMethodInfoPtr_GetFourAxlesFinalRatio_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Driveline>.NativeClassPtr, 100671609);
		NativeMethodInfoPtr_SetupDriveline_Public_Void_ArrayOf_Wheel_Block_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Driveline>.NativeClassPtr, 100671610);
		NativeMethodInfoPtr_SetupSingleAxleDriveline_Private_Void_ArrayOf_Wheel_Block_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Driveline>.NativeClassPtr, 100671611);
		NativeMethodInfoPtr_SetupTwoAxlesDriveline_Private_Void_ArrayOf_Wheel_Block_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Driveline>.NativeClassPtr, 100671612);
		NativeMethodInfoPtr_SetupThreeAxlesDriveline_Private_Void_ArrayOf_Wheel_Block_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Driveline>.NativeClassPtr, 100671613);
		NativeMethodInfoPtr_SetupFourAxlesDriveline_Private_Void_ArrayOf_Wheel_Block_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Driveline>.NativeClassPtr, 100671614);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Driveline>.NativeClassPtr, 100671615);
	}

	public Driveline(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
