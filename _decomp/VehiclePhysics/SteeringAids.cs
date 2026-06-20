using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace VehiclePhysics;

public class SteeringAids : Il2CppSystem.Object
{
	public enum HelpMode
	{
		Disabled,
		AssistedSteerAngle,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<HelpMode>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static HelpMode()
		{
			Il2CppClassPointerStore<HelpMode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteeringAids>.NativeClassPtr, "HelpMode");
		}

	}

	public enum LimitMode
	{
		Disabled,
		Street,
		Sport,
		CustomSlip,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LimitMode>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static LimitMode()
		{
			Il2CppClassPointerStore<LimitMode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteeringAids>.NativeClassPtr, "LimitMode");
		}

	}

	public enum Priority
	{
		HelpFirst,
		LimitFirst,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Priority>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static Priority()
		{
			Il2CppClassPointerStore<Priority>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteeringAids>.NativeClassPtr, "Priority");
		}

	}

	[System.Serializable]
	public class Settings : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_priority;

		private static readonly System.IntPtr NativeFieldInfoPtr_helpMode;

		private static readonly System.IntPtr NativeFieldInfoPtr_helpRatio;

		private static readonly System.IntPtr NativeFieldInfoPtr_helpGravity;

		private static readonly System.IntPtr NativeFieldInfoPtr_limitMode;

		private static readonly System.IntPtr NativeFieldInfoPtr_limitRatio;

		private static readonly System.IntPtr NativeFieldInfoPtr_limitProportionality;

		private static readonly System.IntPtr NativeFieldInfoPtr_limitCustomSlip;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Settings>.NativeClassPtr));

		public unsafe Priority priority
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priority);
				return *(Priority*)num;
			}
			set
			{
				*(Priority*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priority)) = priority;
			}
		}

		public unsafe HelpMode helpMode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_helpMode);
				return *(HelpMode*)num;
			}
			set
			{
				*(HelpMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_helpMode)) = helpMode;
			}
		}

		public unsafe float helpRatio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_helpRatio);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_helpRatio)) = num;
			}
		}

		public unsafe float helpGravity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_helpGravity);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_helpGravity)) = num;
			}
		}

		public unsafe LimitMode limitMode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitMode);
				return *(LimitMode*)num;
			}
			set
			{
				*(LimitMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitMode)) = limitMode;
			}
		}

		public unsafe float limitRatio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitRatio);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitRatio)) = num;
			}
		}

		public unsafe float limitProportionality
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitProportionality);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitProportionality)) = num;
			}
		}

		public unsafe float limitCustomSlip
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitCustomSlip);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitCustomSlip)) = num;
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
			Il2CppClassPointerStore<Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteeringAids>.NativeClassPtr, "Settings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Settings>.NativeClassPtr);
			NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "priority");
			NativeFieldInfoPtr_helpMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "helpMode");
			NativeFieldInfoPtr_helpRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "helpRatio");
			NativeFieldInfoPtr_helpGravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "helpGravity");
			NativeFieldInfoPtr_limitMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "limitMode");
			NativeFieldInfoPtr_limitRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "limitRatio");
			NativeFieldInfoPtr_limitProportionality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "limitProportionality");
			NativeFieldInfoPtr_limitCustomSlip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "limitCustomSlip");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100671433);
		}

		public Settings(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SteeringAids>.NativeClassPtr));

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe SteeringAids()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteeringAids>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SteeringAids()
	{
		Il2CppClassPointerStore<SteeringAids>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "SteeringAids");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteeringAids>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteeringAids>.NativeClassPtr, 100671432);
	}

	public SteeringAids(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
