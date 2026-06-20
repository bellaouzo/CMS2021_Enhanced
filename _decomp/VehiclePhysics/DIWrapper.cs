using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace VehiclePhysics;

public static class DIWrapper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_DllName;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNumDevices_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDeviceInfo_Public_Static_Boolean_Int32_byref_DIDEVICEINSTANCE_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectDevice_Public_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenDevice_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CloseDevice_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AcquireExclusive_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnacquireExclusive_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNumButtons_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNumAxis_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNumFFBAxis_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonInfo_Public_Static_Boolean_Int32_byref_DIDEVICEOBJECTINSTANCE_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAxisInfo_Public_Static_Boolean_Int32_byref_DIDEVICEOBJECTINSTANCE_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFFAxisInfo_Public_Static_Boolean_Int32_byref_DIDEVICEOBJECTINSTANCE_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectFFBAxis_Public_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayConstant_Public_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopConstant_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlaySpring_Public_Static_Boolean_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopSpring_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayDamper_Public_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopDamper_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayFriction_Public_Static_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopFriction_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Poll_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetState_Public_Static_Boolean_byref_DIJOYSTATE2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLastResult_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLog_Public_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearLog_Public_Static_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr));

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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126821, XrefRangeEnd = 126823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Initialize()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Static_Boolean_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 126825, RefRangeEnd = 126827, XrefRangeStart = 126823, XrefRangeEnd = 126825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Release()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Release_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126827, XrefRangeEnd = 126829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetNumDevices()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNumDevices_Public_Static_Int32_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126829, XrefRangeEnd = 126833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetDeviceInfo(int n, out DIDEVICEINSTANCE device)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&n);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull(device);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDeviceInfo_Public_Static_Boolean_Int32_byref_DIDEVICEINSTANCE_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126833, XrefRangeEnd = 126835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SelectDevice(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectDevice_Public_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126835, XrefRangeEnd = 126837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool OpenDevice()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenDevice_Public_Static_Boolean_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126837, XrefRangeEnd = 126839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CloseDevice()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CloseDevice_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126839, XrefRangeEnd = 126841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool AcquireExclusive()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AcquireExclusive_Public_Static_Boolean_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126841, XrefRangeEnd = 126843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnacquireExclusive()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnacquireExclusive_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126843, XrefRangeEnd = 126845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetNumButtons()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNumButtons_Public_Static_Int32_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126845, XrefRangeEnd = 126847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetNumAxis()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNumAxis_Public_Static_Int32_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126847, XrefRangeEnd = 126849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetNumFFBAxis()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNumFFBAxis_Public_Static_Int32_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126849, XrefRangeEnd = 126853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetButtonInfo(int n, out DIDEVICEOBJECTINSTANCE button)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&n);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull(button);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetButtonInfo_Public_Static_Boolean_Int32_byref_DIDEVICEOBJECTINSTANCE_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126853, XrefRangeEnd = 126857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetAxisInfo(int n, out DIDEVICEOBJECTINSTANCE axis)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&n);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull(axis);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAxisInfo_Public_Static_Boolean_Int32_byref_DIDEVICEOBJECTINSTANCE_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126857, XrefRangeEnd = 126861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetFFAxisInfo(int n, out DIDEVICEOBJECTINSTANCE ffaxis)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&n);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull(ffaxis);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFFAxisInfo_Public_Static_Boolean_Int32_byref_DIDEVICEOBJECTINSTANCE_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126861, XrefRangeEnd = 126863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SelectFFBAxis(int n)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&n);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectFFBAxis_Public_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 126865, RefRangeEnd = 126866, XrefRangeStart = 126863, XrefRangeEnd = 126865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool PlayConstant(int magnitude)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&magnitude);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayConstant_Public_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 126868, RefRangeEnd = 126870, XrefRangeStart = 126866, XrefRangeEnd = 126868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool StopConstant()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopConstant_Public_Static_Boolean_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126870, XrefRangeEnd = 126872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool PlaySpring(int offset, int saturation, int coefficient)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&offset);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &saturation;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &coefficient;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaySpring_Public_Static_Boolean_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 126874, RefRangeEnd = 126877, XrefRangeStart = 126872, XrefRangeEnd = 126874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool StopSpring()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopSpring_Public_Static_Boolean_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 126879, RefRangeEnd = 126880, XrefRangeStart = 126877, XrefRangeEnd = 126879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool PlayDamper(int coefficient)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&coefficient);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayDamper_Public_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 126882, RefRangeEnd = 126884, XrefRangeStart = 126880, XrefRangeEnd = 126882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool StopDamper()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopDamper_Public_Static_Boolean_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126884, XrefRangeEnd = 126886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool PlayFriction(int saturation, int coefficient)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&saturation);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &coefficient;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayFriction_Public_Static_Boolean_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 126888, RefRangeEnd = 126891, XrefRangeStart = 126886, XrefRangeEnd = 126888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool StopFriction()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopFriction_Public_Static_Boolean_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 126893, RefRangeEnd = 126894, XrefRangeStart = 126891, XrefRangeEnd = 126893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Poll()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Poll_Public_Static_Boolean_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 126898, RefRangeEnd = 126900, XrefRangeStart = 126894, XrefRangeEnd = 126898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetState(out DIJOYSTATE2 js)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(js);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetState_Public_Static_Boolean_byref_DIJOYSTATE2_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126900, XrefRangeEnd = 126902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetLastResult()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLastResult_Public_Static_Int32_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126902, XrefRangeEnd = 126904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetLog()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLog_Public_Static_IntPtr_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126904, XrefRangeEnd = 126906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearLog()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearLog_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DIWrapper()
	{
		Il2CppClassPointerStore<DIWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "DIWrapper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr);
		NativeFieldInfoPtr_DllName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr, "DllName");
		NativeMethodInfoPtr_Initialize_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr, 100671812);
		NativeMethodInfoPtr_Release_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr, 100671813);
		NativeMethodInfoPtr_GetNumDevices_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr, 100671814);
		NativeMethodInfoPtr_GetDeviceInfo_Public_Static_Boolean_Int32_byref_DIDEVICEINSTANCE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr, 100671815);
		NativeMethodInfoPtr_SelectDevice_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr, 100671816);
		NativeMethodInfoPtr_OpenDevice_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr, 100671817);
		NativeMethodInfoPtr_CloseDevice_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr, 100671818);
		NativeMethodInfoPtr_AcquireExclusive_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr, 100671819);
		NativeMethodInfoPtr_UnacquireExclusive_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr, 100671820);
		NativeMethodInfoPtr_GetNumButtons_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr, 100671821);
		NativeMethodInfoPtr_GetNumAxis_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr, 100671822);
		NativeMethodInfoPtr_GetNumFFBAxis_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr, 100671823);
		NativeMethodInfoPtr_GetButtonInfo_Public_Static_Boolean_Int32_byref_DIDEVICEOBJECTINSTANCE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr, 100671824);
		NativeMethodInfoPtr_GetAxisInfo_Public_Static_Boolean_Int32_byref_DIDEVICEOBJECTINSTANCE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr, 100671825);
		NativeMethodInfoPtr_GetFFAxisInfo_Public_Static_Boolean_Int32_byref_DIDEVICEOBJECTINSTANCE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr, 100671826);
		NativeMethodInfoPtr_SelectFFBAxis_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr, 100671827);
		NativeMethodInfoPtr_PlayConstant_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr, 100671828);
		NativeMethodInfoPtr_StopConstant_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr, 100671829);
		NativeMethodInfoPtr_PlaySpring_Public_Static_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr, 100671830);
		NativeMethodInfoPtr_StopSpring_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr, 100671831);
		NativeMethodInfoPtr_PlayDamper_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr, 100671832);
		NativeMethodInfoPtr_StopDamper_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr, 100671833);
		NativeMethodInfoPtr_PlayFriction_Public_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr, 100671834);
		NativeMethodInfoPtr_StopFriction_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr, 100671835);
		NativeMethodInfoPtr_Poll_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr, 100671836);
		NativeMethodInfoPtr_GetState_Public_Static_Boolean_byref_DIJOYSTATE2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr, 100671837);
		NativeMethodInfoPtr_GetLastResult_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr, 100671838);
		NativeMethodInfoPtr_GetLog_Public_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr, 100671839);
		NativeMethodInfoPtr_ClearLog_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DIWrapper>.NativeClassPtr, 100671840);
	}

	public DIWrapper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
