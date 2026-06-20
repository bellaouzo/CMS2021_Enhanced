using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace OrbCreationExtensions;

public static class FloatExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_MakeString_Public_Static_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeString_Public_Static_String_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_To180Angle_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_To360Angle_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RadToCompassAngle_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DegreesToCompassAngle_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Distance_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RelativePositionBetweenAngles_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Round_Public_Static_Single_Single_Int32_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<FloatExtensions>.NativeClassPtr));

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230418, XrefRangeEnd = 230425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string MakeString(this float aFloat)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&aFloat);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeString_Public_Static_String_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230425, XrefRangeEnd = 230441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string MakeString(this float aFloat, int decimals)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&aFloat);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &decimals;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeString_Public_Static_String_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	public unsafe static float To180Angle(this float f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&f);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_To180Angle_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float To360Angle(this float f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&f);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_To360Angle_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float RadToCompassAngle(this float rad)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rad);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RadToCompassAngle_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float DegreesToCompassAngle(this float angle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&angle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DegreesToCompassAngle_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float Distance(this float f1, float f2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&f1);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &f2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Distance_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float RelativePositionBetweenAngles(this float angle, float from, float to)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&angle);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RelativePositionBetweenAngles_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230441, XrefRangeEnd = 230443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Round(this float f, int decimals)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&f);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &decimals;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Round_Public_Static_Single_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static FloatExtensions()
	{
		Il2CppClassPointerStore<FloatExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "OrbCreationExtensions", "FloatExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_MakeString_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatExtensions>.NativeClassPtr, 100680766);
		NativeMethodInfoPtr_MakeString_Public_Static_String_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatExtensions>.NativeClassPtr, 100680767);
		NativeMethodInfoPtr_To180Angle_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatExtensions>.NativeClassPtr, 100680768);
		NativeMethodInfoPtr_To360Angle_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatExtensions>.NativeClassPtr, 100680769);
		NativeMethodInfoPtr_RadToCompassAngle_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatExtensions>.NativeClassPtr, 100680770);
		NativeMethodInfoPtr_DegreesToCompassAngle_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatExtensions>.NativeClassPtr, 100680771);
		NativeMethodInfoPtr_Distance_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatExtensions>.NativeClassPtr, 100680772);
		NativeMethodInfoPtr_RelativePositionBetweenAngles_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatExtensions>.NativeClassPtr, 100680773);
		NativeMethodInfoPtr_Round_Public_Static_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatExtensions>.NativeClassPtr, 100680774);
	}

	public FloatExtensions(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
