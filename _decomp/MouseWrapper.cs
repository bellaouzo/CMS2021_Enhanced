using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public static class MouseWrapper : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct POINT
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_X;

		private static readonly System.IntPtr NativeFieldInfoPtr_Y;

		[FieldOffset(0)]
		public int X;

		[FieldOffset(4)]
		public int Y;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<POINT>.NativeClassPtr));

		static POINT()
		{
			Il2CppClassPointerStore<POINT>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MouseWrapper>.NativeClassPtr, "POINT");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<POINT>.NativeClassPtr);
			NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POINT>.NativeClassPtr, "X");
			NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POINT>.NativeClassPtr, "Y");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<POINT>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCursorPos_Private_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCursorPos_Private_Static_Boolean_byref_POINT_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveCursorToPoint_Public_Static_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGlobalMousePosition_Public_Static_Vector2_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MouseWrapper>.NativeClassPtr));

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10204, XrefRangeEnd = 10206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int SetCursorPos(int x, int y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCursorPos_Private_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10206, XrefRangeEnd = 10208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetCursorPos(out POINT mousePos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref mousePos);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCursorPos_Private_Static_Boolean_byref_POINT_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10208, XrefRangeEnd = 10214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MoveCursorToPoint(int x, int y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveCursorToPoint_Public_Static_Void_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 10220, RefRangeEnd = 10226, XrefRangeStart = 10214, XrefRangeEnd = 10220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 GetGlobalMousePosition()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGlobalMousePosition_Public_Static_Vector2_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static MouseWrapper()
	{
		Il2CppClassPointerStore<MouseWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "MouseWrapper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseWrapper>.NativeClassPtr);
		NativeMethodInfoPtr_SetCursorPos_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseWrapper>.NativeClassPtr, 100664163);
		NativeMethodInfoPtr_GetCursorPos_Private_Static_Boolean_byref_POINT_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseWrapper>.NativeClassPtr, 100664164);
		NativeMethodInfoPtr_MoveCursorToPoint_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseWrapper>.NativeClassPtr, 100664165);
		NativeMethodInfoPtr_GetGlobalMousePosition_Public_Static_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseWrapper>.NativeClassPtr, 100664166);
	}

	public MouseWrapper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
