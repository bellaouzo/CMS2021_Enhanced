using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct PaintData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_metal;

	private static readonly System.IntPtr NativeFieldInfoPtr_roughness;

	private static readonly System.IntPtr NativeFieldInfoPtr_clearCoat;

	private static readonly System.IntPtr NativeFieldInfoPtr_normalStrength;

	private static readonly System.IntPtr NativeFieldInfoPtr_fresnel;

	private static readonly System.IntPtr NativeFieldInfoPtr_Chameleon;

	private static readonly System.IntPtr NativeFieldInfoPtr_Chrome;

	private static readonly System.IntPtr NativeFieldInfoPtr_Matt;

	private static readonly System.IntPtr NativeFieldInfoPtr_MattChameleon;

	private static readonly System.IntPtr NativeFieldInfoPtr_Gloss;

	private static readonly System.IntPtr NativeFieldInfoPtr_Metallic;

	private static readonly System.IntPtr NativeFieldInfoPtr_Solid;

	private static readonly System.IntPtr NativeFieldInfoPtr_Pearl;

	private static readonly System.IntPtr NativeFieldInfoPtr_Unpainted;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Metal_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Metal_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Roughness_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Roughness_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ClearCoat_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ClearCoat_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NormalStrength_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_NormalStrength_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Fresnel_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Fresnel_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PaintData_PaintData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PaintData_PaintData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_PaintData_0;

	[FieldOffset(0)]
	public float metal;

	[FieldOffset(4)]
	public float roughness;

	[FieldOffset(8)]
	public float clearCoat;

	[FieldOffset(12)]
	public float normalStrength;

	[FieldOffset(16)]
	public float fresnel;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PaintData>.NativeClassPtr));

	public unsafe static PaintData Chameleon
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out PaintData result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Chameleon, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Chameleon, &paintData);
		}
	}

	public unsafe static PaintData Chrome
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out PaintData result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Chrome, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Chrome, &paintData);
		}
	}

	public unsafe static PaintData Matt
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out PaintData result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Matt, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Matt, &paintData);
		}
	}

	public unsafe static PaintData MattChameleon
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out PaintData result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MattChameleon, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MattChameleon, &paintData);
		}
	}

	public unsafe static PaintData Gloss
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out PaintData result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Gloss, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Gloss, &paintData);
		}
	}

	public unsafe static PaintData Metallic
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out PaintData result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Metallic, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Metallic, &paintData);
		}
	}

	public unsafe static PaintData Solid
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out PaintData result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Solid, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Solid, &paintData);
		}
	}

	public unsafe static PaintData Pearl
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out PaintData result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Pearl, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Pearl, &paintData);
		}
	}

	public unsafe static PaintData Unpainted
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out PaintData result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Unpainted, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Unpainted, &paintData);
		}
	}

	public unsafe float Metal
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Metal_Public_get_Single_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Metal_Public_set_Void_Single_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float Roughness
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Roughness_Public_get_Single_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Roughness_Public_set_Void_Single_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float ClearCoat
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ClearCoat_Public_get_Single_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ClearCoat_Public_set_Void_Single_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float NormalStrength
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NormalStrength_Public_get_Single_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_NormalStrength_Public_set_Void_Single_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float Fresnel
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Fresnel_Public_get_Single_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Fresnel_Public_set_Void_Single_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93274, XrefRangeEnd = 93278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PaintData(float metal, float roughness, float clearCoat, float normalStrength, float fresnel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&metal);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &roughness;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &clearCoat;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &normalStrength;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fresnel;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe static bool operator ==(PaintData lhs, PaintData rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(PaintData**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PaintData_PaintData_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93278, XrefRangeEnd = 93281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator !=(PaintData lhs, PaintData rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(PaintData**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PaintData_PaintData_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93281, XrefRangeEnd = 93284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 93284, RefRangeEnd = 93286, XrefRangeStart = 93284, XrefRangeEnd = 93284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(PaintData other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Boolean_PaintData_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static PaintData()
	{
		Il2CppClassPointerStore<PaintData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "PaintData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PaintData>.NativeClassPtr);
		NativeFieldInfoPtr_metal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaintData>.NativeClassPtr, "metal");
		NativeFieldInfoPtr_roughness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaintData>.NativeClassPtr, "roughness");
		NativeFieldInfoPtr_clearCoat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaintData>.NativeClassPtr, "clearCoat");
		NativeFieldInfoPtr_normalStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaintData>.NativeClassPtr, "normalStrength");
		NativeFieldInfoPtr_fresnel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaintData>.NativeClassPtr, "fresnel");
		NativeFieldInfoPtr_Chameleon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaintData>.NativeClassPtr, "Chameleon");
		NativeFieldInfoPtr_Chrome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaintData>.NativeClassPtr, "Chrome");
		NativeFieldInfoPtr_Matt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaintData>.NativeClassPtr, "Matt");
		NativeFieldInfoPtr_MattChameleon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaintData>.NativeClassPtr, "MattChameleon");
		NativeFieldInfoPtr_Gloss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaintData>.NativeClassPtr, "Gloss");
		NativeFieldInfoPtr_Metallic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaintData>.NativeClassPtr, "Metallic");
		NativeFieldInfoPtr_Solid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaintData>.NativeClassPtr, "Solid");
		NativeFieldInfoPtr_Pearl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaintData>.NativeClassPtr, "Pearl");
		NativeFieldInfoPtr_Unpainted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaintData>.NativeClassPtr, "Unpainted");
		NativeMethodInfoPtr_get_Metal_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintData>.NativeClassPtr, 100668659);
		NativeMethodInfoPtr_set_Metal_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintData>.NativeClassPtr, 100668660);
		NativeMethodInfoPtr_get_Roughness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintData>.NativeClassPtr, 100668661);
		NativeMethodInfoPtr_set_Roughness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintData>.NativeClassPtr, 100668662);
		NativeMethodInfoPtr_get_ClearCoat_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintData>.NativeClassPtr, 100668663);
		NativeMethodInfoPtr_set_ClearCoat_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintData>.NativeClassPtr, 100668664);
		NativeMethodInfoPtr_get_NormalStrength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintData>.NativeClassPtr, 100668665);
		NativeMethodInfoPtr_set_NormalStrength_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintData>.NativeClassPtr, 100668666);
		NativeMethodInfoPtr_get_Fresnel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintData>.NativeClassPtr, 100668667);
		NativeMethodInfoPtr_set_Fresnel_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintData>.NativeClassPtr, 100668668);
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintData>.NativeClassPtr, 100668669);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PaintData_PaintData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintData>.NativeClassPtr, 100668670);
		NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PaintData_PaintData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintData>.NativeClassPtr, 100668671);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintData>.NativeClassPtr, 100668672);
		NativeMethodInfoPtr_Equals_Public_Boolean_PaintData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintData>.NativeClassPtr, 100668673);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PaintData>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
