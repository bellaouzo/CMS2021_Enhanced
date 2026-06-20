using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Managers;

public static class ParkingCarPlaceManager : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_MoveCar_Public_Static_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveCar_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarsFromFloor_Public_Static_List_1_ParkingCarInfo_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarFromFloor_Private_Static_ParkingCarInfo_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetParkingFloorStoredCarsAmount_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetParkingStoredCarsAmount_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CarExistsOnParking_Private_Static_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CarExistsOnParking_Private_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParkingIsFull_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetParkingFreePlaceIndex_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetParkingSave_Public_Static_String_Int32_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ParkingCarPlaceManager>.NativeClassPtr));

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 141943, RefRangeEnd = 141945, XrefRangeStart = 141878, XrefRangeEnd = 141943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MoveCar(int from, int to)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&from);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveCar_Public_Static_Void_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141945, XrefRangeEnd = 141965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveCar(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveCar_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 141988, RefRangeEnd = 141991, XrefRangeStart = 141965, XrefRangeEnd = 141988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<ParkingCarInfo> GetCarsFromFloor(int floor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&floor);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarsFromFloor_Public_Static_List_1_ParkingCarInfo_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<ParkingCarInfo>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141991, XrefRangeEnd = 142002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ParkingCarInfo GetCarFromFloor(int floor, int carIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&floor);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &carIndex;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarFromFloor_Private_Static_ParkingCarInfo_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new ParkingCarInfo(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142002, XrefRangeEnd = 142010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetParkingFloorStoredCarsAmount(int floor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&floor);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetParkingFloorStoredCarsAmount_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142010, XrefRangeEnd = 142018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetParkingStoredCarsAmount()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetParkingStoredCarsAmount_Public_Static_Int32_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142018, XrefRangeEnd = 142026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CarExistsOnParking(int floor, int carIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&floor);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &carIndex;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CarExistsOnParking_Private_Static_Boolean_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 142034, RefRangeEnd = 142037, XrefRangeStart = 142026, XrefRangeEnd = 142034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CarExistsOnParking(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CarExistsOnParking_Private_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 142042, RefRangeEnd = 142048, XrefRangeStart = 142037, XrefRangeEnd = 142042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ParkingIsFull()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParkingIsFull_Public_Static_Boolean_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142048, XrefRangeEnd = 142054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetParkingFreePlaceIndex()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetParkingFreePlaceIndex_Public_Static_Int32_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142054, XrefRangeEnd = 142063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetParkingSave(int no)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&no);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetParkingSave_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	static ParkingCarPlaceManager()
	{
		Il2CppClassPointerStore<ParkingCarPlaceManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Managers", "ParkingCarPlaceManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParkingCarPlaceManager>.NativeClassPtr);
		NativeMethodInfoPtr_MoveCar_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingCarPlaceManager>.NativeClassPtr, 100672907);
		NativeMethodInfoPtr_RemoveCar_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingCarPlaceManager>.NativeClassPtr, 100672908);
		NativeMethodInfoPtr_GetCarsFromFloor_Public_Static_List_1_ParkingCarInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingCarPlaceManager>.NativeClassPtr, 100672909);
		NativeMethodInfoPtr_GetCarFromFloor_Private_Static_ParkingCarInfo_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingCarPlaceManager>.NativeClassPtr, 100672910);
		NativeMethodInfoPtr_GetParkingFloorStoredCarsAmount_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingCarPlaceManager>.NativeClassPtr, 100672911);
		NativeMethodInfoPtr_GetParkingStoredCarsAmount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingCarPlaceManager>.NativeClassPtr, 100672912);
		NativeMethodInfoPtr_CarExistsOnParking_Private_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingCarPlaceManager>.NativeClassPtr, 100672913);
		NativeMethodInfoPtr_CarExistsOnParking_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingCarPlaceManager>.NativeClassPtr, 100672914);
		NativeMethodInfoPtr_ParkingIsFull_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingCarPlaceManager>.NativeClassPtr, 100672915);
		NativeMethodInfoPtr_GetParkingFreePlaceIndex_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingCarPlaceManager>.NativeClassPtr, 100672916);
		NativeMethodInfoPtr_GetParkingSave_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingCarPlaceManager>.NativeClassPtr, 100672917);
	}

	public ParkingCarPlaceManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
