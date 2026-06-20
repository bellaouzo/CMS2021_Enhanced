using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VehiclePhysics;

[System.Serializable]
public class TireFriction : Il2CppSystem.Object
{
	public enum Model
	{
		Flat,
		Lineal,
		Smooth,
		Parametric,
		Pacejka,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Model>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static Model()
		{
			Il2CppClassPointerStore<Model>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TireFriction>.NativeClassPtr, "Model");
		}

	}

	[System.Serializable]
	public class Settings : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_adherent;

		private static readonly System.IntPtr NativeFieldInfoPtr_peak;

		private static readonly System.IntPtr NativeFieldInfoPtr_limit;

		private static readonly System.IntPtr NativeFieldInfoPtr_a;

		private static readonly System.IntPtr NativeFieldInfoPtr_b;

		private static readonly System.IntPtr NativeFieldInfoPtr_c;

		private static readonly System.IntPtr NativeFieldInfoPtr_d;

		private static readonly System.IntPtr NativeFieldInfoPtr_A;

		private static readonly System.IntPtr NativeFieldInfoPtr_B;

		private static readonly System.IntPtr NativeFieldInfoPtr_C;

		private static readonly System.IntPtr NativeFieldInfoPtr_D;

		private static readonly System.IntPtr NativeFieldInfoPtr_E;

		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyAPLConstraints_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Settings>.NativeClassPtr));

		public unsafe Vector2 adherent
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adherent);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adherent)) = vector;
			}
		}

		public unsafe Vector2 peak
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_peak);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_peak)) = vector;
			}
		}

		public unsafe Vector2 limit
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limit);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limit)) = vector;
			}
		}

		public unsafe float a
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_a);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_a)) = num;
			}
		}

		public unsafe float b
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_b);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_b)) = num;
			}
		}

		public unsafe float c
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_c);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_c)) = num;
			}
		}

		public unsafe float d
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_d);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_d)) = num;
			}
		}

		public unsafe float A
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_A);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_A)) = num;
			}
		}

		public unsafe float B
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_B);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_B)) = num;
			}
		}

		public unsafe float C
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_C);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_C)) = num;
			}
		}

		public unsafe float D
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_D);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_D)) = num;
			}
		}

		public unsafe float E
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_E);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_E)) = num;
			}
		}

		[CallerCount(0)]
		public unsafe void ApplyAPLConstraints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyAPLConstraints_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
			Il2CppClassPointerStore<Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TireFriction>.NativeClassPtr, "Settings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Settings>.NativeClassPtr);
			NativeFieldInfoPtr_adherent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "adherent");
			NativeFieldInfoPtr_peak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "peak");
			NativeFieldInfoPtr_limit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "limit");
			NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "a");
			NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "b");
			NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "c");
			NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "d");
			NativeFieldInfoPtr_A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "A");
			NativeFieldInfoPtr_B = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "B");
			NativeFieldInfoPtr_C = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "C");
			NativeFieldInfoPtr_D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "D");
			NativeFieldInfoPtr_E = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "E");
			NativeMethodInfoPtr_ApplyAPLConstraints_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100671251);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100671252);
		}

		public Settings(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	public class ContactPatch : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_slip;

		private static readonly System.IntPtr NativeFieldInfoPtr_load;

		private static readonly System.IntPtr NativeFieldInfoPtr_groundGrip;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ContactPatch>.NativeClassPtr));

		public unsafe Vector2 slip
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slip);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slip)) = vector;
			}
		}

		public unsafe float load
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_load);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_load)) = num;
			}
		}

		public unsafe float groundGrip
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groundGrip);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groundGrip)) = num;
			}
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123304, XrefRangeEnd = 123306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContactPatch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactPatch>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static ContactPatch()
		{
			Il2CppClassPointerStore<ContactPatch>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TireFriction>.NativeClassPtr, "ContactPatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactPatch>.NativeClassPtr);
			NativeFieldInfoPtr_slip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPatch>.NativeClassPtr, "slip");
			NativeFieldInfoPtr_load = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPatch>.NativeClassPtr, "load");
			NativeFieldInfoPtr_groundGrip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPatch>.NativeClassPtr, "groundGrip");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPatch>.NativeClassPtr, 100671253);
		}

		public ContactPatch(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	public class CurveBase : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_params;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Settings_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateForce_Public_Virtual_New_Single_Single_ContactPatch_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetAdherentSlip_Public_Virtual_New_Single_ContactPatch_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetPeakSlip_Public_Virtual_New_Single_ContactPatch_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetLimitSlip_Public_Virtual_New_Single_ContactPatch_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CurveBase>.NativeClassPtr));

		public unsafe Settings m_params
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_params);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Settings(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_params), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(77)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe CurveBase(Settings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurveBase>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public unsafe float EvaluateForce(float slip, ContactPatch cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&slip);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(cp);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_EvaluateForce_Public_Virtual_New_Single_Single_ContactPatch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public unsafe float GetAdherentSlip(ContactPatch cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cp);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetAdherentSlip_Public_Virtual_New_Single_ContactPatch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public unsafe float GetPeakSlip(ContactPatch cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cp);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetPeakSlip_Public_Virtual_New_Single_ContactPatch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public unsafe float GetLimitSlip(ContactPatch cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cp);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetLimitSlip_Public_Virtual_New_Single_ContactPatch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static CurveBase()
		{
			Il2CppClassPointerStore<CurveBase>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TireFriction>.NativeClassPtr, "CurveBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurveBase>.NativeClassPtr);
			NativeFieldInfoPtr_m_params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveBase>.NativeClassPtr, "m_params");
			NativeMethodInfoPtr__ctor_Public_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveBase>.NativeClassPtr, 100671254);
			NativeMethodInfoPtr_EvaluateForce_Public_Virtual_New_Single_Single_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveBase>.NativeClassPtr, 100671255);
			NativeMethodInfoPtr_GetAdherentSlip_Public_Virtual_New_Single_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveBase>.NativeClassPtr, 100671256);
			NativeMethodInfoPtr_GetPeakSlip_Public_Virtual_New_Single_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveBase>.NativeClassPtr, 100671257);
			NativeMethodInfoPtr_GetLimitSlip_Public_Virtual_New_Single_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveBase>.NativeClassPtr, 100671258);
		}

		public CurveBase(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	public class FlatFriction : CurveBase
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Settings_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateForce_Public_Virtual_Single_Single_ContactPatch_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetAdherentSlip_Public_Virtual_Single_ContactPatch_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetPeakSlip_Public_Virtual_Single_ContactPatch_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetLimitSlip_Public_Virtual_Single_ContactPatch_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<FlatFriction>.NativeClassPtr));

		[CallerCount(0)]
		public unsafe FlatFriction(Settings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlatFriction>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public new unsafe float EvaluateForce(float s, ContactPatch cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&s);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(cp);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_EvaluateForce_Public_Virtual_Single_Single_ContactPatch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public new unsafe float GetAdherentSlip(ContactPatch cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cp);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetAdherentSlip_Public_Virtual_Single_ContactPatch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public new unsafe float GetPeakSlip(ContactPatch cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cp);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetPeakSlip_Public_Virtual_Single_ContactPatch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public new unsafe float GetLimitSlip(ContactPatch cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cp);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetLimitSlip_Public_Virtual_Single_ContactPatch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static FlatFriction()
		{
			Il2CppClassPointerStore<FlatFriction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TireFriction>.NativeClassPtr, "FlatFriction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlatFriction>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlatFriction>.NativeClassPtr, 100671259);
			NativeMethodInfoPtr_EvaluateForce_Public_Virtual_Single_Single_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlatFriction>.NativeClassPtr, 100671260);
			NativeMethodInfoPtr_GetAdherentSlip_Public_Virtual_Single_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlatFriction>.NativeClassPtr, 100671261);
			NativeMethodInfoPtr_GetPeakSlip_Public_Virtual_Single_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlatFriction>.NativeClassPtr, 100671262);
			NativeMethodInfoPtr_GetLimitSlip_Public_Virtual_Single_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlatFriction>.NativeClassPtr, 100671263);
		}

		public FlatFriction(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	public class LinealFriction : CurveBase
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Settings_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_FastLerp_Private_Static_Single_Vector2_Vector2_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateForce_Public_Virtual_Single_Single_ContactPatch_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetAdherentSlip_Public_Virtual_Single_ContactPatch_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetPeakSlip_Public_Virtual_Single_ContactPatch_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetLimitSlip_Public_Virtual_Single_ContactPatch_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LinealFriction>.NativeClassPtr));

		[CallerCount(0)]
		public unsafe LinealFriction(Settings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinealFriction>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public unsafe static float FastLerp(Vector2 P0, Vector2 P1, float x)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&P0);
			*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &P1;
			*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FastLerp_Private_Static_Single_Vector2_Vector2_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public new unsafe float EvaluateForce(float s, ContactPatch cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&s);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(cp);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_EvaluateForce_Public_Virtual_Single_Single_ContactPatch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public new unsafe float GetAdherentSlip(ContactPatch cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cp);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetAdherentSlip_Public_Virtual_Single_ContactPatch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public new unsafe float GetPeakSlip(ContactPatch cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cp);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetPeakSlip_Public_Virtual_Single_ContactPatch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public new unsafe float GetLimitSlip(ContactPatch cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cp);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetLimitSlip_Public_Virtual_Single_ContactPatch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static LinealFriction()
		{
			Il2CppClassPointerStore<LinealFriction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TireFriction>.NativeClassPtr, "LinealFriction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinealFriction>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinealFriction>.NativeClassPtr, 100671264);
			NativeMethodInfoPtr_FastLerp_Private_Static_Single_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinealFriction>.NativeClassPtr, 100671265);
			NativeMethodInfoPtr_EvaluateForce_Public_Virtual_Single_Single_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinealFriction>.NativeClassPtr, 100671266);
			NativeMethodInfoPtr_GetAdherentSlip_Public_Virtual_Single_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinealFriction>.NativeClassPtr, 100671267);
			NativeMethodInfoPtr_GetPeakSlip_Public_Virtual_Single_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinealFriction>.NativeClassPtr, 100671268);
			NativeMethodInfoPtr_GetLimitSlip_Public_Virtual_Single_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinealFriction>.NativeClassPtr, 100671269);
		}

		public LinealFriction(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	public class SmoothFriction : CurveBase
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Settings_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CubicLerp_Private_Static_Single_Single_Vector2_Vector2_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateForce_Public_Virtual_Single_Single_ContactPatch_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetAdherentSlip_Public_Virtual_Single_ContactPatch_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetPeakSlip_Public_Virtual_Single_ContactPatch_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetLimitSlip_Public_Virtual_Single_ContactPatch_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SmoothFriction>.NativeClassPtr));

		[CallerCount(0)]
		public unsafe SmoothFriction(Settings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmoothFriction>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public unsafe static float CubicLerp(float x, Vector2 P0, Vector2 P1)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&x);
			*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &P0;
			*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &P1;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CubicLerp_Private_Static_Single_Single_Vector2_Vector2_0, (System.IntPtr)0, (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public new unsafe float EvaluateForce(float s, ContactPatch cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&s);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(cp);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_EvaluateForce_Public_Virtual_Single_Single_ContactPatch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public new unsafe float GetAdherentSlip(ContactPatch cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cp);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetAdherentSlip_Public_Virtual_Single_ContactPatch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public new unsafe float GetPeakSlip(ContactPatch cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cp);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetPeakSlip_Public_Virtual_Single_ContactPatch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public new unsafe float GetLimitSlip(ContactPatch cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cp);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetLimitSlip_Public_Virtual_Single_ContactPatch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static SmoothFriction()
		{
			Il2CppClassPointerStore<SmoothFriction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TireFriction>.NativeClassPtr, "SmoothFriction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmoothFriction>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothFriction>.NativeClassPtr, 100671270);
			NativeMethodInfoPtr_CubicLerp_Private_Static_Single_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothFriction>.NativeClassPtr, 100671271);
			NativeMethodInfoPtr_EvaluateForce_Public_Virtual_Single_Single_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothFriction>.NativeClassPtr, 100671272);
			NativeMethodInfoPtr_GetAdherentSlip_Public_Virtual_Single_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothFriction>.NativeClassPtr, 100671273);
			NativeMethodInfoPtr_GetPeakSlip_Public_Virtual_Single_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothFriction>.NativeClassPtr, 100671274);
			NativeMethodInfoPtr_GetLimitSlip_Public_Virtual_Single_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothFriction>.NativeClassPtr, 100671275);
		}

		public SmoothFriction(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	public class ParametricFriction : CurveBase
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Settings_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_TangentLerp_Private_Static_Single_Single_Vector2_Vector2_Single_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateForce_Public_Virtual_Single_Single_ContactPatch_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetAdherentSlip_Public_Virtual_Single_ContactPatch_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetPeakSlip_Public_Virtual_Single_ContactPatch_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetLimitSlip_Public_Virtual_Single_ContactPatch_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ParametricFriction>.NativeClassPtr));

		[CallerCount(0)]
		public unsafe ParametricFriction(Settings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParametricFriction>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123306, RefRangeEnd = 123307, XrefRangeStart = 123306, XrefRangeEnd = 123306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float TangentLerp(float x, Vector2 P0, Vector2 P1, float a, float b)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = (nint)(&x);
			*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &P0;
			*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &P1;
			*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &a;
			*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TangentLerp_Private_Static_Single_Single_Vector2_Vector2_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123307, XrefRangeEnd = 123309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe float EvaluateForce(float s, ContactPatch cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&s);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(cp);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_EvaluateForce_Public_Virtual_Single_Single_ContactPatch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public new unsafe float GetAdherentSlip(ContactPatch cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cp);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetAdherentSlip_Public_Virtual_Single_ContactPatch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public new unsafe float GetPeakSlip(ContactPatch cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cp);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetPeakSlip_Public_Virtual_Single_ContactPatch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public new unsafe float GetLimitSlip(ContactPatch cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cp);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetLimitSlip_Public_Virtual_Single_ContactPatch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static ParametricFriction()
		{
			Il2CppClassPointerStore<ParametricFriction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TireFriction>.NativeClassPtr, "ParametricFriction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParametricFriction>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParametricFriction>.NativeClassPtr, 100671276);
			NativeMethodInfoPtr_TangentLerp_Private_Static_Single_Single_Vector2_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParametricFriction>.NativeClassPtr, 100671277);
			NativeMethodInfoPtr_EvaluateForce_Public_Virtual_Single_Single_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParametricFriction>.NativeClassPtr, 100671278);
			NativeMethodInfoPtr_GetAdherentSlip_Public_Virtual_Single_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParametricFriction>.NativeClassPtr, 100671279);
			NativeMethodInfoPtr_GetPeakSlip_Public_Virtual_Single_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParametricFriction>.NativeClassPtr, 100671280);
			NativeMethodInfoPtr_GetLimitSlip_Public_Virtual_Single_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParametricFriction>.NativeClassPtr, 100671281);
		}

		public ParametricFriction(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	public class PacejkaFriction : CurveBase
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_adherent;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_peak;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_limit;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Settings_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetPacejkaPoints_Public_Static_Void_Single_Single_Single_Single_Single_byref_Vector2_byref_Vector2_byref_Vector2_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Pacejka_Public_Static_Single_Single_Single_Single_Single_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateForce_Public_Virtual_Single_Single_ContactPatch_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetAdherentSlip_Public_Virtual_Single_ContactPatch_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetPeakSlip_Public_Virtual_Single_ContactPatch_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetLimitSlip_Public_Virtual_Single_ContactPatch_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PacejkaFriction>.NativeClassPtr));

		public unsafe Vector2 m_adherent
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_adherent);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_adherent)) = vector;
			}
		}

		public unsafe Vector2 m_peak
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_peak);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_peak)) = vector;
			}
		}

		public unsafe Vector2 m_limit
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_limit);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_limit)) = vector;
			}
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123317, RefRangeEnd = 123318, XrefRangeStart = 123309, XrefRangeEnd = 123317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PacejkaFriction(Settings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PacejkaFriction>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123337, RefRangeEnd = 123338, XrefRangeStart = 123318, XrefRangeEnd = 123337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetPacejkaPoints(float A, float B, float C, float D, float E, ref Vector2 adherent, ref Vector2 peak, ref Vector2 limit)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[8];
			*ptr = (nint)(&A);
			*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &B;
			*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &C;
			*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &D;
			*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &E;
			*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref adherent);
			*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref peak);
			*(void**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref limit);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPacejkaPoints_Public_Static_Void_Single_Single_Single_Single_Single_byref_Vector2_byref_Vector2_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123338, XrefRangeEnd = 123341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Pacejka(float slip, float B, float C, float D, float E)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = (nint)(&slip);
			*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &B;
			*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &C;
			*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &D;
			*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &E;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pacejka_Public_Static_Single_Single_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123341, XrefRangeEnd = 123344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe float EvaluateForce(float s, ContactPatch cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&s);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(cp);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_EvaluateForce_Public_Virtual_Single_Single_ContactPatch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public new unsafe float GetAdherentSlip(ContactPatch cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cp);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetAdherentSlip_Public_Virtual_Single_ContactPatch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public new unsafe float GetPeakSlip(ContactPatch cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cp);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetPeakSlip_Public_Virtual_Single_ContactPatch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public new unsafe float GetLimitSlip(ContactPatch cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cp);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetLimitSlip_Public_Virtual_Single_ContactPatch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static PacejkaFriction()
		{
			Il2CppClassPointerStore<PacejkaFriction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TireFriction>.NativeClassPtr, "PacejkaFriction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PacejkaFriction>.NativeClassPtr);
			NativeFieldInfoPtr_m_adherent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacejkaFriction>.NativeClassPtr, "m_adherent");
			NativeFieldInfoPtr_m_peak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacejkaFriction>.NativeClassPtr, "m_peak");
			NativeFieldInfoPtr_m_limit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacejkaFriction>.NativeClassPtr, "m_limit");
			NativeMethodInfoPtr__ctor_Public_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacejkaFriction>.NativeClassPtr, 100671282);
			NativeMethodInfoPtr_GetPacejkaPoints_Public_Static_Void_Single_Single_Single_Single_Single_byref_Vector2_byref_Vector2_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacejkaFriction>.NativeClassPtr, 100671283);
			NativeMethodInfoPtr_Pacejka_Public_Static_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacejkaFriction>.NativeClassPtr, 100671284);
			NativeMethodInfoPtr_EvaluateForce_Public_Virtual_Single_Single_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacejkaFriction>.NativeClassPtr, 100671285);
			NativeMethodInfoPtr_GetAdherentSlip_Public_Virtual_Single_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacejkaFriction>.NativeClassPtr, 100671286);
			NativeMethodInfoPtr_GetPeakSlip_Public_Virtual_Single_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacejkaFriction>.NativeClassPtr, 100671287);
			NativeMethodInfoPtr_GetLimitSlip_Public_Virtual_Single_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacejkaFriction>.NativeClassPtr, 100671288);
		}

		public PacejkaFriction(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_model;

	private static readonly System.IntPtr NativeFieldInfoPtr_settings;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_curve;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupFrictionCurves_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetForce_Public_Vector2_ContactPatch_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAdherentSlip_Public_Boolean_ContactPatch_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAdherentSlipForward_Public_Single_ContactPatch_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAdherentSlipSideways_Public_Single_ContactPatch_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAdherentSlipBounds_Public_Vector2_ContactPatch_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPeakSlipBounds_Public_Vector2_ContactPatch_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLimitSlipBounds_Public_Vector2_ContactPatch_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAdherentForce_Public_Vector2_ContactPatch_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TireFriction>.NativeClassPtr));

	public unsafe Model model
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_model);
			return *(Model*)num;
		}
		set
		{
			*(Model*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_model)) = model;
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

	public unsafe CurveBase m_curve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_curve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CurveBase(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_curve), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123344, XrefRangeEnd = 123345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAfterDeserialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 123363, RefRangeEnd = 123365, XrefRangeStart = 123345, XrefRangeEnd = 123363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupFrictionCurves()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupFrictionCurves_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 123369, RefRangeEnd = 123376, XrefRangeStart = 123365, XrefRangeEnd = 123369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TireFriction()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TireFriction>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123376, XrefRangeEnd = 123381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetForce(ContactPatch cp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cp);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetForce_Public_Vector2_ContactPatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123381, XrefRangeEnd = 123382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsAdherentSlip(ContactPatch cp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cp);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAdherentSlip_Public_Boolean_ContactPatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123382, XrefRangeEnd = 123385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetAdherentSlipForward(ContactPatch cp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cp);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAdherentSlipForward_Public_Single_ContactPatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123385, XrefRangeEnd = 123388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetAdherentSlipSideways(ContactPatch cp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cp);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAdherentSlipSideways_Public_Single_ContactPatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe Vector2 GetAdherentSlipBounds(ContactPatch cp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cp);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAdherentSlipBounds_Public_Vector2_ContactPatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe Vector2 GetPeakSlipBounds(ContactPatch cp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cp);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPeakSlipBounds_Public_Vector2_ContactPatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe Vector2 GetLimitSlipBounds(ContactPatch cp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cp);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLimitSlipBounds_Public_Vector2_ContactPatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 123388, RefRangeEnd = 123390, XrefRangeStart = 123388, XrefRangeEnd = 123388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetAdherentForce(ContactPatch cp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cp);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAdherentForce_Public_Vector2_ContactPatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static TireFriction()
	{
		Il2CppClassPointerStore<TireFriction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "TireFriction");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TireFriction>.NativeClassPtr);
		NativeFieldInfoPtr_model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TireFriction>.NativeClassPtr, "model");
		NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TireFriction>.NativeClassPtr, "settings");
		NativeFieldInfoPtr_m_curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TireFriction>.NativeClassPtr, "m_curve");
		NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TireFriction>.NativeClassPtr, 100671239);
		NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TireFriction>.NativeClassPtr, 100671240);
		NativeMethodInfoPtr_SetupFrictionCurves_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TireFriction>.NativeClassPtr, 100671241);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TireFriction>.NativeClassPtr, 100671242);
		NativeMethodInfoPtr_GetForce_Public_Vector2_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TireFriction>.NativeClassPtr, 100671243);
		NativeMethodInfoPtr_IsAdherentSlip_Public_Boolean_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TireFriction>.NativeClassPtr, 100671244);
		NativeMethodInfoPtr_GetAdherentSlipForward_Public_Single_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TireFriction>.NativeClassPtr, 100671245);
		NativeMethodInfoPtr_GetAdherentSlipSideways_Public_Single_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TireFriction>.NativeClassPtr, 100671246);
		NativeMethodInfoPtr_GetAdherentSlipBounds_Public_Vector2_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TireFriction>.NativeClassPtr, 100671247);
		NativeMethodInfoPtr_GetPeakSlipBounds_Public_Vector2_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TireFriction>.NativeClassPtr, 100671248);
		NativeMethodInfoPtr_GetLimitSlipBounds_Public_Vector2_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TireFriction>.NativeClassPtr, 100671249);
		NativeMethodInfoPtr_GetAdherentForce_Public_Vector2_ContactPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TireFriction>.NativeClassPtr, 100671250);
	}

	public TireFriction(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
