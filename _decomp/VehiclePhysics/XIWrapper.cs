using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace VehiclePhysics;

public static class XIWrapper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_DllName;

	private static readonly System.IntPtr NativeMethodInfoPtr_Enable_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Disable_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDeviceAttached_Public_Static_Boolean_XboxDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectDevice_Public_Static_Boolean_XboxDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetState_Public_Static_Boolean_byref_XINPUT_STATE_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVibration_Public_Static_Boolean_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLastResult_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLog_Public_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearLog_Public_Static_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<XIWrapper>.NativeClassPtr));

	public unsafe static string DllName
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DllName, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DllName, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126906, XrefRangeEnd = 126908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Enable()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Enable_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126908, XrefRangeEnd = 126910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Disable()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Disable_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126910, XrefRangeEnd = 126912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsDeviceAttached(XboxDevice device)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&device);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDeviceAttached_Public_Static_Boolean_XboxDevice_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126912, XrefRangeEnd = 126914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SelectDevice(XboxDevice device)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&device);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectDevice_Public_Static_Boolean_XboxDevice_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 126916, RefRangeEnd = 126918, XrefRangeStart = 126914, XrefRangeEnd = 126916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetState(out XINPUT_STATE xs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref xs);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetState_Public_Static_Boolean_byref_XINPUT_STATE_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126918, XrefRangeEnd = 126920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetVibration(float left, float right)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&left);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVibration_Public_Static_Boolean_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126920, XrefRangeEnd = 126922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetLastResult()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLastResult_Public_Static_Int32_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126922, XrefRangeEnd = 126924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetLog()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLog_Public_Static_IntPtr_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126924, XrefRangeEnd = 126926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearLog()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearLog_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static XIWrapper()
	{
		Il2CppClassPointerStore<XIWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "XIWrapper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XIWrapper>.NativeClassPtr);
		NativeFieldInfoPtr_DllName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XIWrapper>.NativeClassPtr, "DllName");
		NativeMethodInfoPtr_Enable_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XIWrapper>.NativeClassPtr, 100671841);
		NativeMethodInfoPtr_Disable_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XIWrapper>.NativeClassPtr, 100671842);
		NativeMethodInfoPtr_IsDeviceAttached_Public_Static_Boolean_XboxDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XIWrapper>.NativeClassPtr, 100671843);
		NativeMethodInfoPtr_SelectDevice_Public_Static_Boolean_XboxDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XIWrapper>.NativeClassPtr, 100671844);
		NativeMethodInfoPtr_GetState_Public_Static_Boolean_byref_XINPUT_STATE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XIWrapper>.NativeClassPtr, 100671845);
		NativeMethodInfoPtr_SetVibration_Public_Static_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XIWrapper>.NativeClassPtr, 100671846);
		NativeMethodInfoPtr_GetLastResult_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XIWrapper>.NativeClassPtr, 100671847);
		NativeMethodInfoPtr_GetLog_Public_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XIWrapper>.NativeClassPtr, 100671848);
		NativeMethodInfoPtr_ClearLog_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XIWrapper>.NativeClassPtr, 100671849);
	}

	public XIWrapper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
