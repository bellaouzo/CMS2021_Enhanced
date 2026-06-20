using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Extensions;

public static class CarBundleLoaderExtension : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarName_Public_Static_String_CarBundleLoader_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarSuffix_Public_Static_String_CarBundleLoader_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarBrand_Public_Static_String_CarBundleLoader_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarYear_Public_Static_Int32_CarBundleLoader_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarWeight_Public_Static_Single_CarBundleLoader_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarEngine_Public_Static_String_CarBundleLoader_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarValue_Public_Static_Int32_CarBundleLoader_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPerformanceIndexStock_Public_Static_Single_CarBundleLoader_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPerformanceIndexStockMax_Public_Static_Single_CarBundleLoader_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPerformanceIndexPerPercentStock_Public_Static_Single_CarBundleLoader_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxTuning_Public_Static_Single_CarBundleLoader_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTireForWheel_Public_Static_String_CarBundleLoader_String_Int32_WheelType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTireForWheel_Public_Static_String_CarBundleLoader_String_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetConfigUId_Public_Static_Boolean_CarBundleLoader_String_Int32_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetConfigIdFromUId_Public_Static_Boolean_CarBundleLoader_String_String_byref_Int32_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarBundleLoaderExtension>.NativeClassPtr));

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216567, XrefRangeEnd = 216568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetCarName(this CarBundleLoader carBundleLoader, string carID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carBundleLoader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(carID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarName_Public_Static_String_CarBundleLoader_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 216578, RefRangeEnd = 216584, XrefRangeStart = 216568, XrefRangeEnd = 216578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetCarSuffix(this CarBundleLoader carBundleLoader, string carID, int config)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carBundleLoader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &config;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarSuffix_Public_Static_String_CarBundleLoader_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 216594, RefRangeEnd = 216596, XrefRangeStart = 216584, XrefRangeEnd = 216594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetCarBrand(this CarBundleLoader carBundleLoader, string carID, int config)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carBundleLoader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &config;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarBrand_Public_Static_String_CarBundleLoader_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 216602, RefRangeEnd = 216606, XrefRangeStart = 216596, XrefRangeEnd = 216602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetCarYear(this CarBundleLoader carBundleLoader, string carID, int config)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carBundleLoader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &config;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarYear_Public_Static_Int32_CarBundleLoader_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 216612, RefRangeEnd = 216618, XrefRangeStart = 216606, XrefRangeEnd = 216612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetCarWeight(this CarBundleLoader carBundleLoader, string carID, int config)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carBundleLoader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &config;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarWeight_Public_Static_Single_CarBundleLoader_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 216628, RefRangeEnd = 216632, XrefRangeStart = 216618, XrefRangeEnd = 216628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetCarEngine(this CarBundleLoader carBundleLoader, string carID, int config)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carBundleLoader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &config;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarEngine_Public_Static_String_CarBundleLoader_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 216638, RefRangeEnd = 216640, XrefRangeStart = 216632, XrefRangeEnd = 216638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetCarValue(this CarBundleLoader carBundleLoader, string carID, int config)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carBundleLoader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &config;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarValue_Public_Static_Int32_CarBundleLoader_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 216646, RefRangeEnd = 216649, XrefRangeStart = 216640, XrefRangeEnd = 216646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetPerformanceIndexStock(this CarBundleLoader carBundleLoader, string carID, [Optional] int config)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carBundleLoader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &config;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPerformanceIndexStock_Public_Static_Single_CarBundleLoader_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216649, XrefRangeEnd = 216655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetPerformanceIndexStockMax(this CarBundleLoader carBundleLoader, string carID, [Optional] int config)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carBundleLoader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &config;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPerformanceIndexStockMax_Public_Static_Single_CarBundleLoader_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 216661, RefRangeEnd = 216663, XrefRangeStart = 216655, XrefRangeEnd = 216661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetPerformanceIndexPerPercentStock(this CarBundleLoader carBundleLoader, string carID, [Optional] int config)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carBundleLoader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &config;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPerformanceIndexPerPercentStock_Public_Static_Single_CarBundleLoader_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 216669, RefRangeEnd = 216672, XrefRangeStart = 216663, XrefRangeEnd = 216669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetMaxTuning(this CarBundleLoader carBundleLoader, string carID, [Optional] int config)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carBundleLoader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &config;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxTuning_Public_Static_Single_CarBundleLoader_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 216689, RefRangeEnd = 216692, XrefRangeStart = 216672, XrefRangeEnd = 216689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetTireForWheel(this CarBundleLoader carBundleLoader, string carID, int config, WheelType wheelType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carBundleLoader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &config;
		*(WheelType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &wheelType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTireForWheel_Public_Static_String_CarBundleLoader_String_Int32_WheelType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 216703, RefRangeEnd = 216719, XrefRangeStart = 216692, XrefRangeEnd = 216703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetTireForWheel(this CarBundleLoader carBundleLoader, string carID, int config, bool front)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carBundleLoader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &config;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &front;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTireForWheel_Public_Static_String_CarBundleLoader_String_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216719, XrefRangeEnd = 216724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetConfigUId(this CarBundleLoader carBundleLoader, string carID, int config, out string configUId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carBundleLoader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &config;
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr il2CppString = IL2CPP.ManagedStringToIl2Cpp(configUId);
		*(System.IntPtr**)num = &il2CppString;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetConfigUId_Public_Static_Boolean_CarBundleLoader_String_Int32_byref_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		configUId = IL2CPP.Il2CppStringToManaged(il2CppString);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216724, XrefRangeEnd = 216728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetConfigIdFromUId(this CarBundleLoader carBundleLoader, string carID, string configUId, out int configVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carBundleLoader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(configUId);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref configVersion);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetConfigIdFromUId_Public_Static_Boolean_CarBundleLoader_String_String_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static CarBundleLoaderExtension()
	{
		Il2CppClassPointerStore<CarBundleLoaderExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Extensions", "CarBundleLoaderExtension");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarBundleLoaderExtension>.NativeClassPtr);
		NativeMethodInfoPtr_GetCarName_Public_Static_String_CarBundleLoader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoaderExtension>.NativeClassPtr, 100679644);
		NativeMethodInfoPtr_GetCarSuffix_Public_Static_String_CarBundleLoader_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoaderExtension>.NativeClassPtr, 100679645);
		NativeMethodInfoPtr_GetCarBrand_Public_Static_String_CarBundleLoader_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoaderExtension>.NativeClassPtr, 100679646);
		NativeMethodInfoPtr_GetCarYear_Public_Static_Int32_CarBundleLoader_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoaderExtension>.NativeClassPtr, 100679647);
		NativeMethodInfoPtr_GetCarWeight_Public_Static_Single_CarBundleLoader_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoaderExtension>.NativeClassPtr, 100679648);
		NativeMethodInfoPtr_GetCarEngine_Public_Static_String_CarBundleLoader_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoaderExtension>.NativeClassPtr, 100679649);
		NativeMethodInfoPtr_GetCarValue_Public_Static_Int32_CarBundleLoader_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoaderExtension>.NativeClassPtr, 100679650);
		NativeMethodInfoPtr_GetPerformanceIndexStock_Public_Static_Single_CarBundleLoader_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoaderExtension>.NativeClassPtr, 100679651);
		NativeMethodInfoPtr_GetPerformanceIndexStockMax_Public_Static_Single_CarBundleLoader_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoaderExtension>.NativeClassPtr, 100679652);
		NativeMethodInfoPtr_GetPerformanceIndexPerPercentStock_Public_Static_Single_CarBundleLoader_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoaderExtension>.NativeClassPtr, 100679653);
		NativeMethodInfoPtr_GetMaxTuning_Public_Static_Single_CarBundleLoader_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoaderExtension>.NativeClassPtr, 100679654);
		NativeMethodInfoPtr_GetTireForWheel_Public_Static_String_CarBundleLoader_String_Int32_WheelType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoaderExtension>.NativeClassPtr, 100679655);
		NativeMethodInfoPtr_GetTireForWheel_Public_Static_String_CarBundleLoader_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoaderExtension>.NativeClassPtr, 100679656);
		NativeMethodInfoPtr_GetConfigUId_Public_Static_Boolean_CarBundleLoader_String_Int32_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoaderExtension>.NativeClassPtr, 100679657);
		NativeMethodInfoPtr_GetConfigIdFromUId_Public_Static_Boolean_CarBundleLoader_String_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarBundleLoaderExtension>.NativeClassPtr, 100679658);
	}

	public CarBundleLoaderExtension(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
