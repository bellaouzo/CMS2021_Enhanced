using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VehiclePhysics;

public static class Gravity : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_gravityCached;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_gravityMagnitude;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_gravityUp;

	private static readonly System.IntPtr NativeFieldInfoPtr_reference;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceToMass;

	private static readonly System.IntPtr NativeFieldInfoPtr_massToForce;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_value_Public_Static_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_value_Public_Static_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_magnitude_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_up_Public_Static_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Refresh_Public_Static_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Gravity>.NativeClassPtr));

	public unsafe static bool s_gravityCached
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_gravityCached, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_gravityCached, &flag);
		}
	}

	public unsafe static float s_gravityMagnitude
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_gravityMagnitude, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_gravityMagnitude, &num);
		}
	}

	public unsafe static Vector3 s_gravityUp
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector3 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_gravityUp, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_gravityUp, &vector);
		}
	}

	public unsafe static float reference
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_reference, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_reference, &num);
		}
	}

	public unsafe static float forceToMass
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_forceToMass, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_forceToMass, &num);
		}
	}

	public unsafe static float massToForce
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_massToForce, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_massToForce, &num);
		}
	}

	public unsafe static Vector3 value
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122971, XrefRangeEnd = 122973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_value_Public_Static_get_Vector3_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122973, XrefRangeEnd = 122981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_value_Public_Static_set_Void_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe static float magnitude
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122981, XrefRangeEnd = 122990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_magnitude_Public_Static_get_Single_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe static Vector3 up
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 122999, RefRangeEnd = 123002, XrefRangeStart = 122990, XrefRangeEnd = 122999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_up_Public_Static_get_Vector3_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 123017, RefRangeEnd = 123022, XrefRangeStart = 123002, XrefRangeEnd = 123017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Refresh()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Refresh_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Gravity()
	{
		Il2CppClassPointerStore<Gravity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "Gravity");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Gravity>.NativeClassPtr);
		NativeFieldInfoPtr_s_gravityCached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gravity>.NativeClassPtr, "s_gravityCached");
		NativeFieldInfoPtr_s_gravityMagnitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gravity>.NativeClassPtr, "s_gravityMagnitude");
		NativeFieldInfoPtr_s_gravityUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gravity>.NativeClassPtr, "s_gravityUp");
		NativeFieldInfoPtr_reference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gravity>.NativeClassPtr, "reference");
		NativeFieldInfoPtr_forceToMass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gravity>.NativeClassPtr, "forceToMass");
		NativeFieldInfoPtr_massToForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gravity>.NativeClassPtr, "massToForce");
		NativeMethodInfoPtr_get_value_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gravity>.NativeClassPtr, 100671203);
		NativeMethodInfoPtr_set_value_Public_Static_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gravity>.NativeClassPtr, 100671204);
		NativeMethodInfoPtr_get_magnitude_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gravity>.NativeClassPtr, 100671205);
		NativeMethodInfoPtr_get_up_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gravity>.NativeClassPtr, 100671206);
		NativeMethodInfoPtr_Refresh_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gravity>.NativeClassPtr, 100671207);
	}

	public Gravity(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
