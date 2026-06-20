using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct HeadlampAlignment
{
	private static readonly System.IntPtr NativeFieldInfoPtr_horizontal;

	private static readonly System.IntPtr NativeFieldInfoPtr_vertical;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Horizontal_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Horizontal_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Vertical_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Vertical_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCorrect_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_HeadlampAlignmentData_0;

	[FieldOffset(0)]
	public float horizontal;

	[FieldOffset(4)]
	public float vertical;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<HeadlampAlignment>.NativeClassPtr));

	public unsafe float Horizontal
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Horizontal_Public_get_Single_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65061, XrefRangeEnd = 65062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Horizontal_Public_set_Void_Single_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float Vertical
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Vertical_Public_get_Single_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65062, XrefRangeEnd = 65063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Vertical_Public_set_Void_Single_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 65063, RefRangeEnd = 65067, XrefRangeStart = 65063, XrefRangeEnd = 65063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsCorrect()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCorrect_Public_Boolean_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe HeadlampAlignment(HeadlampAlignmentData headlampAlignmentData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&headlampAlignmentData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_HeadlampAlignmentData_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static HeadlampAlignment()
	{
		Il2CppClassPointerStore<HeadlampAlignment>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "HeadlampAlignment");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeadlampAlignment>.NativeClassPtr);
		NativeFieldInfoPtr_horizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadlampAlignment>.NativeClassPtr, "horizontal");
		NativeFieldInfoPtr_vertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadlampAlignment>.NativeClassPtr, "vertical");
		NativeMethodInfoPtr_get_Horizontal_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeadlampAlignment>.NativeClassPtr, 100667254);
		NativeMethodInfoPtr_set_Horizontal_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeadlampAlignment>.NativeClassPtr, 100667255);
		NativeMethodInfoPtr_get_Vertical_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeadlampAlignment>.NativeClassPtr, 100667256);
		NativeMethodInfoPtr_set_Vertical_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeadlampAlignment>.NativeClassPtr, 100667257);
		NativeMethodInfoPtr_IsCorrect_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeadlampAlignment>.NativeClassPtr, 100667258);
		NativeMethodInfoPtr__ctor_Public_Void_HeadlampAlignmentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeadlampAlignment>.NativeClassPtr, 100667259);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HeadlampAlignment>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
