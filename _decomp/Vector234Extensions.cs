using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public static class Vector234Extensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_SetX_Public_Static_Vector2_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetY_Public_Static_Vector2_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetX_Public_Static_Vector3_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetY_Public_Static_Vector3_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetZ_Public_Static_Vector3_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetX_Public_Static_Vector4_Vector4_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetY_Public_Static_Vector4_Vector4_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetZ_Public_Static_Vector4_Vector4_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetW_Public_Static_Vector4_Vector4_Single_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Vector234Extensions>.NativeClassPtr));

	[CallerCount(0)]
	public unsafe static Vector2 SetX(this Vector2 aVec, float aXValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&aVec);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &aXValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetX_Public_Static_Vector2_Vector2_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static Vector2 SetY(this Vector2 aVec, float aYValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&aVec);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &aYValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetY_Public_Static_Vector2_Vector2_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static Vector3 SetX(this Vector3 aVec, float aXValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&aVec);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &aXValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetX_Public_Static_Vector3_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static Vector3 SetY(this Vector3 aVec, float aYValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&aVec);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &aYValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetY_Public_Static_Vector3_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static Vector3 SetZ(this Vector3 aVec, float aZValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&aVec);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &aZValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetZ_Public_Static_Vector3_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static Vector4 SetX(this Vector4 aVec, float aXValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&aVec);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &aXValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetX_Public_Static_Vector4_Vector4_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static Vector4 SetY(this Vector4 aVec, float aYValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&aVec);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &aYValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetY_Public_Static_Vector4_Vector4_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static Vector4 SetZ(this Vector4 aVec, float aZValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&aVec);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &aZValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetZ_Public_Static_Vector4_Vector4_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static Vector4 SetW(this Vector4 aVec, float aWValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&aVec);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &aWValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetW_Public_Static_Vector4_Vector4_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static Vector234Extensions()
	{
		Il2CppClassPointerStore<Vector234Extensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "Vector234Extensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector234Extensions>.NativeClassPtr);
		NativeMethodInfoPtr_SetX_Public_Static_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector234Extensions>.NativeClassPtr, 100666672);
		NativeMethodInfoPtr_SetY_Public_Static_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector234Extensions>.NativeClassPtr, 100666673);
		NativeMethodInfoPtr_SetX_Public_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector234Extensions>.NativeClassPtr, 100666674);
		NativeMethodInfoPtr_SetY_Public_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector234Extensions>.NativeClassPtr, 100666675);
		NativeMethodInfoPtr_SetZ_Public_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector234Extensions>.NativeClassPtr, 100666676);
		NativeMethodInfoPtr_SetX_Public_Static_Vector4_Vector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector234Extensions>.NativeClassPtr, 100666677);
		NativeMethodInfoPtr_SetY_Public_Static_Vector4_Vector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector234Extensions>.NativeClassPtr, 100666678);
		NativeMethodInfoPtr_SetZ_Public_Static_Vector4_Vector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector234Extensions>.NativeClassPtr, 100666679);
		NativeMethodInfoPtr_SetW_Public_Static_Vector4_Vector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector234Extensions>.NativeClassPtr, 100666680);
	}

	public Vector234Extensions(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
