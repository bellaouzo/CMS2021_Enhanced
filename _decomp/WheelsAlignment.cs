using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct WheelsAlignment
{
	private static readonly System.IntPtr NativeFieldInfoPtr_fl;

	private static readonly System.IntPtr NativeFieldInfoPtr_fr;

	private static readonly System.IntPtr NativeFieldInfoPtr_rl;

	private static readonly System.IntPtr NativeFieldInfoPtr_rr;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_FL_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_FL_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_FR_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_FR_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RL_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_RL_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RR_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_RR_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRandom_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRandom_Public_Void_WheelType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCorrect_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_WheelsAlignmentData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetExternalSteer_Public_Single_0;

	[FieldOffset(0)]
	public float fl;

	[FieldOffset(4)]
	public float fr;

	[FieldOffset(8)]
	public float rl;

	[FieldOffset(12)]
	public float rr;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WheelsAlignment>.NativeClassPtr));

	public unsafe float FL
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FL_Public_get_Single_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_FL_Public_set_Void_Single_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float FR
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FR_Public_get_Single_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_FR_Public_set_Void_Single_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float RL
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RL_Public_get_Single_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_RL_Public_set_Void_Single_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float RR
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RR_Public_get_Single_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_RR_Public_set_Void_Single_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 65086, RefRangeEnd = 65091, XrefRangeStart = 65070, XrefRangeEnd = 65086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRandom()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRandom_Public_Void_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65091, XrefRangeEnd = 65095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRandom(WheelType wheelType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&wheelType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRandom_Public_Void_WheelType_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 65095, RefRangeEnd = 65097, XrefRangeStart = 65095, XrefRangeEnd = 65095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsCorrect()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCorrect_Public_Boolean_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe WheelsAlignment(WheelsAlignmentData wheelsAlignmentData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&wheelsAlignmentData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_WheelsAlignmentData_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe float GetExternalSteer()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExternalSteer_Public_Single_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static WheelsAlignment()
	{
		Il2CppClassPointerStore<WheelsAlignment>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "WheelsAlignment");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WheelsAlignment>.NativeClassPtr);
		NativeFieldInfoPtr_fl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelsAlignment>.NativeClassPtr, "fl");
		NativeFieldInfoPtr_fr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelsAlignment>.NativeClassPtr, "fr");
		NativeFieldInfoPtr_rl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelsAlignment>.NativeClassPtr, "rl");
		NativeFieldInfoPtr_rr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelsAlignment>.NativeClassPtr, "rr");
		NativeMethodInfoPtr_get_FL_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelsAlignment>.NativeClassPtr, 100667263);
		NativeMethodInfoPtr_set_FL_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelsAlignment>.NativeClassPtr, 100667264);
		NativeMethodInfoPtr_get_FR_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelsAlignment>.NativeClassPtr, 100667265);
		NativeMethodInfoPtr_set_FR_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelsAlignment>.NativeClassPtr, 100667266);
		NativeMethodInfoPtr_get_RL_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelsAlignment>.NativeClassPtr, 100667267);
		NativeMethodInfoPtr_set_RL_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelsAlignment>.NativeClassPtr, 100667268);
		NativeMethodInfoPtr_get_RR_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelsAlignment>.NativeClassPtr, 100667269);
		NativeMethodInfoPtr_set_RR_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelsAlignment>.NativeClassPtr, 100667270);
		NativeMethodInfoPtr_SetRandom_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelsAlignment>.NativeClassPtr, 100667271);
		NativeMethodInfoPtr_SetRandom_Public_Void_WheelType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelsAlignment>.NativeClassPtr, 100667272);
		NativeMethodInfoPtr_IsCorrect_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelsAlignment>.NativeClassPtr, 100667273);
		NativeMethodInfoPtr__ctor_Public_Void_WheelsAlignmentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelsAlignment>.NativeClassPtr, 100667274);
		NativeMethodInfoPtr_GetExternalSteer_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelsAlignment>.NativeClassPtr, 100667275);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WheelsAlignment>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
