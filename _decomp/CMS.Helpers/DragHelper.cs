using System;
using System.Runtime.CompilerServices;
using CMS.Containers;
using CMS.UI.Logic;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Helpers;

public static class DragHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_SearchCars_Public_Static_Void_String_byref_List_1_String_byref_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasOpponent_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalizedDragText_Public_Static_String_DragButtonType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalizedDragLength_Public_Static_String_DragLength_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalizedDragClass_Public_Static_String_DragClass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTiresFromSave_Public_Static_ArrayOf_TireData_NewCarData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTireFromTireData_Public_Static_String_byref_ArrayOf_TireData_WheelType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWheelTypeFromString_Private_Static_WheelType_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNewTireFromTuning_Public_Static_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TireToID_Public_Static_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IDToTire_Public_Static_String_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDebugString_Public_Static_String_String_Single_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOpponentsRaceWinner_Public_Static_Byte_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDragClass_Public_Static_DragClass_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetClassBounds_Public_Static_Void_DragClass_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEntryFee_Public_Static_Int32_DragClass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWinPrize_Public_Static_Int32_DragClass_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHexColorForClass_Public_Static_String_DragClass_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DragHelper>.NativeClassPtr));

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 212945, RefRangeEnd = 212946, XrefRangeStart = 212893, XrefRangeEnd = 212945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SearchCars(string searchText, ref List<string> cars, out List<string> result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(searchText);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(cars);
		*(System.IntPtr**)num = &intPtr;
		byte* num2 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(result);
		*(System.IntPtr**)num2 = &intPtr2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SearchCars_Public_Static_Void_String_byref_List_1_String_byref_List_1_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr4 = intPtr;
		cars = (List<string>)(object)((intPtr4 == (System.IntPtr)0) ? null : new List<T>(intPtr4));
		System.IntPtr intPtr5 = intPtr2;
		result = (List<string>)(object)((intPtr5 == (System.IntPtr)0) ? null : new List<T>(intPtr5));
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 212948, RefRangeEnd = 212950, XrefRangeStart = 212946, XrefRangeEnd = 212948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasOpponent(string carID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasOpponent_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 212987, RefRangeEnd = 212988, XrefRangeStart = 212950, XrefRangeEnd = 212987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetLocalizedDragText(DragButtonType buttonType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&buttonType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalizedDragText_Public_Static_String_DragButtonType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212988, XrefRangeEnd = 213006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetLocalizedDragLength(DragLength dragLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dragLength);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalizedDragLength_Public_Static_String_DragLength_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213006, XrefRangeEnd = 213019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetLocalizedDragClass(DragClass dragClass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dragClass);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalizedDragClass_Public_Static_String_DragClass_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 213055, RefRangeEnd = 213061, XrefRangeStart = 213019, XrefRangeEnd = 213055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<TireData> GetTiresFromSave(NewCarData carData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(carData));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTiresFromSave_Public_Static_ArrayOf_TireData_NewCarData_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<TireData>(intPtr) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 213063, RefRangeEnd = 213071, XrefRangeStart = 213061, XrefRangeEnd = 213063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetTireFromTireData(ref Il2CppReferenceArray<TireData> data, WheelType wheelType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(data);
		*(WheelType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &wheelType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTireFromTireData_Public_Static_String_byref_ArrayOf_TireData_WheelType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 213083, RefRangeEnd = 213085, XrefRangeStart = 213071, XrefRangeEnd = 213083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static WheelType GetWheelTypeFromString(string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWheelTypeFromString_Private_Static_WheelType_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(WheelType*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213085, XrefRangeEnd = 213090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetNewTireFromTuning(float tuningValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tuningValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNewTireFromTuning_Public_Static_String_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 213105, RefRangeEnd = 213106, XrefRangeStart = 213090, XrefRangeEnd = 213105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte TireToID(string tire)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(tire);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TireToID_Public_Static_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(byte*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213106, XrefRangeEnd = 213115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string IDToTire(byte id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IDToTire_Public_Static_String_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 213176, RefRangeEnd = 213179, XrefRangeStart = 213115, XrefRangeEnd = 213176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetDebugString(string engineID, float engineScale, float torqueMod, float rpmMod, float tuning, float weight, float grip)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(engineID);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &engineScale;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &torqueMod;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &rpmMod;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &tuning;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &weight;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &grip;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDebugString_Public_Static_String_String_Single_Single_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213179, XrefRangeEnd = 213182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte GetOpponentsRaceWinner(float member1PI, float member2PI)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&member1PI);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &member2PI;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOpponentsRaceWinner_Public_Static_Byte_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(byte*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static DragClass GetDragClass(float dragIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dragIndex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDragClass_Public_Static_DragClass_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(DragClass*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static void GetClassBounds(DragClass dragClass, out int min, out int max)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&dragClass);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref min);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref max);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetClassBounds_Public_Static_Void_DragClass_byref_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe static int GetEntryFee(DragClass dragClass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dragClass);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEntryFee_Public_Static_Int32_DragClass_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213182, XrefRangeEnd = 213190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetWinPrize(DragClass dragClass, byte stage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&dragClass);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stage;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWinPrize_Public_Static_Int32_DragClass_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213190, XrefRangeEnd = 213196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetHexColorForClass(DragClass dragClass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dragClass);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHexColorForClass_Public_Static_String_DragClass_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	static DragHelper()
	{
		Il2CppClassPointerStore<DragHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Helpers", "DragHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragHelper>.NativeClassPtr);
		NativeMethodInfoPtr_SearchCars_Public_Static_Void_String_byref_List_1_String_byref_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragHelper>.NativeClassPtr, 100679293);
		NativeMethodInfoPtr_HasOpponent_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragHelper>.NativeClassPtr, 100679294);
		NativeMethodInfoPtr_GetLocalizedDragText_Public_Static_String_DragButtonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragHelper>.NativeClassPtr, 100679295);
		NativeMethodInfoPtr_GetLocalizedDragLength_Public_Static_String_DragLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragHelper>.NativeClassPtr, 100679296);
		NativeMethodInfoPtr_GetLocalizedDragClass_Public_Static_String_DragClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragHelper>.NativeClassPtr, 100679297);
		NativeMethodInfoPtr_GetTiresFromSave_Public_Static_ArrayOf_TireData_NewCarData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragHelper>.NativeClassPtr, 100679298);
		NativeMethodInfoPtr_GetTireFromTireData_Public_Static_String_byref_ArrayOf_TireData_WheelType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragHelper>.NativeClassPtr, 100679299);
		NativeMethodInfoPtr_GetWheelTypeFromString_Private_Static_WheelType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragHelper>.NativeClassPtr, 100679300);
		NativeMethodInfoPtr_GetNewTireFromTuning_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragHelper>.NativeClassPtr, 100679301);
		NativeMethodInfoPtr_TireToID_Public_Static_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragHelper>.NativeClassPtr, 100679302);
		NativeMethodInfoPtr_IDToTire_Public_Static_String_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragHelper>.NativeClassPtr, 100679303);
		NativeMethodInfoPtr_GetDebugString_Public_Static_String_String_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragHelper>.NativeClassPtr, 100679304);
		NativeMethodInfoPtr_GetOpponentsRaceWinner_Public_Static_Byte_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragHelper>.NativeClassPtr, 100679305);
		NativeMethodInfoPtr_GetDragClass_Public_Static_DragClass_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragHelper>.NativeClassPtr, 100679306);
		NativeMethodInfoPtr_GetClassBounds_Public_Static_Void_DragClass_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragHelper>.NativeClassPtr, 100679307);
		NativeMethodInfoPtr_GetEntryFee_Public_Static_Int32_DragClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragHelper>.NativeClassPtr, 100679308);
		NativeMethodInfoPtr_GetWinPrize_Public_Static_Int32_DragClass_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragHelper>.NativeClassPtr, 100679309);
		NativeMethodInfoPtr_GetHexColorForClass_Public_Static_String_DragClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragHelper>.NativeClassPtr, 100679310);
	}

	public DragHelper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
