using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Save;

public static class SaveFeatureLevels : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_EcuDataSupport;

	private static readonly System.IntPtr NativeFieldInfoPtr_CarbDataSupport;

	private static readonly System.IntPtr NativeFieldInfoPtr_MeasuredDragIndexSupport;

	private static readonly System.IntPtr NativeFieldInfoPtr_OptimizedSpace;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveSupportsEcuData_Public_Static_Boolean_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveSupportsCarbData_Public_Static_Boolean_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveSupportsMeasuredDragIndex_Public_Static_Boolean_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsOptimized_Public_Static_Boolean_Byte_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SaveFeatureLevels>.NativeClassPtr));

	public unsafe static byte EcuDataSupport
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EcuDataSupport, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EcuDataSupport, &b);
		}
	}

	public unsafe static byte CarbDataSupport
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CarbDataSupport, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CarbDataSupport, &b);
		}
	}

	public unsafe static byte MeasuredDragIndexSupport
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MeasuredDragIndexSupport, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MeasuredDragIndexSupport, &b);
		}
	}

	public unsafe static byte OptimizedSpace
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OptimizedSpace, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OptimizedSpace, &b);
		}
	}

	[CallerCount(0)]
	public unsafe static bool SaveSupportsEcuData(byte saveVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&saveVersion);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveSupportsEcuData_Public_Static_Boolean_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static bool SaveSupportsCarbData(byte saveVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&saveVersion);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveSupportsCarbData_Public_Static_Boolean_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static bool SaveSupportsMeasuredDragIndex(byte saveVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&saveVersion);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveSupportsMeasuredDragIndex_Public_Static_Boolean_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static bool IsOptimized(byte saveVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&saveVersion);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsOptimized_Public_Static_Boolean_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static SaveFeatureLevels()
	{
		Il2CppClassPointerStore<SaveFeatureLevels>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Save", "SaveFeatureLevels");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveFeatureLevels>.NativeClassPtr);
		NativeFieldInfoPtr_EcuDataSupport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveFeatureLevels>.NativeClassPtr, "EcuDataSupport");
		NativeFieldInfoPtr_CarbDataSupport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveFeatureLevels>.NativeClassPtr, "CarbDataSupport");
		NativeFieldInfoPtr_MeasuredDragIndexSupport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveFeatureLevels>.NativeClassPtr, "MeasuredDragIndexSupport");
		NativeFieldInfoPtr_OptimizedSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveFeatureLevels>.NativeClassPtr, "OptimizedSpace");
		NativeMethodInfoPtr_SaveSupportsEcuData_Public_Static_Boolean_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveFeatureLevels>.NativeClassPtr, 100672559);
		NativeMethodInfoPtr_SaveSupportsCarbData_Public_Static_Boolean_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveFeatureLevels>.NativeClassPtr, 100672560);
		NativeMethodInfoPtr_SaveSupportsMeasuredDragIndex_Public_Static_Boolean_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveFeatureLevels>.NativeClassPtr, 100672561);
		NativeMethodInfoPtr_IsOptimized_Public_Static_Boolean_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveFeatureLevels>.NativeClassPtr, 100672562);
	}

	public SaveFeatureLevels(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
