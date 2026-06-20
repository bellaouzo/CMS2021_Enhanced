using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Managers;

public static class CarPlaceManager : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_garagePlaces;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFreeGarageIndex_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPlaceIsOccupied_Public_Static_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPlaceByNameIsOccupied_Public_Static_Void_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPlaceIsOccupied_Public_Static_Void_CarLoader_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPlaceIsOccupied_Public_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearAll_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DebugAll_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAmountOfFreePlacesInGarage_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFreeCarLoaderSaveName_Public_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFreeCarLoaderIndex_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFreeCarLoaderIndexWithReservation_Public_Static_Int32_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarPlaceManager>.NativeClassPtr));

	public unsafe static Il2CppStructArray<bool> garagePlaces
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_garagePlaces, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Il2CppStructArray<bool>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_garagePlaces, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 140657, RefRangeEnd = 140659, XrefRangeStart = 140617, XrefRangeEnd = 140657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetFreeGarageIndex(int carLoaderSaveIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&carLoaderSaveIndex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFreeGarageIndex_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 140662, RefRangeEnd = 140669, XrefRangeStart = 140659, XrefRangeEnd = 140662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPlaceIsOccupied(int index, bool isOccupied)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isOccupied;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPlaceIsOccupied_Public_Static_Void_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140669, XrefRangeEnd = 140681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPlaceByNameIsOccupied(string name, bool isOccupied)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isOccupied;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPlaceByNameIsOccupied_Public_Static_Void_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 140697, RefRangeEnd = 140700, XrefRangeStart = 140681, XrefRangeEnd = 140697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPlaceIsOccupied(CarLoader carLoader, bool isOccupied)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isOccupied;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPlaceIsOccupied_Public_Static_Void_CarLoader_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140700, XrefRangeEnd = 140703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetPlaceIsOccupied(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPlaceIsOccupied_Public_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 140712, RefRangeEnd = 140721, XrefRangeStart = 140703, XrefRangeEnd = 140712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Prepare()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Prepare_Private_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 140729, RefRangeEnd = 140730, XrefRangeStart = 140721, XrefRangeEnd = 140729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearAll()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearAll_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140730, XrefRangeEnd = 140753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DebugAll()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DebugAll_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 140771, RefRangeEnd = 140787, XrefRangeStart = 140753, XrefRangeEnd = 140771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetAmountOfFreePlacesInGarage()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAmountOfFreePlacesInGarage_Public_Static_Int32_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140787, XrefRangeEnd = 140799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetFreeCarLoaderSaveName()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFreeCarLoaderSaveName_Public_Static_String_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140799, XrefRangeEnd = 140812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetFreeCarLoaderIndex()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFreeCarLoaderIndex_Public_Static_Int32_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 140826, RefRangeEnd = 140829, XrefRangeStart = 140812, XrefRangeEnd = 140826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetFreeCarLoaderIndexWithReservation()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFreeCarLoaderIndexWithReservation_Public_Static_Int32_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static CarPlaceManager()
	{
		Il2CppClassPointerStore<CarPlaceManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Managers", "CarPlaceManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarPlaceManager>.NativeClassPtr);
		NativeFieldInfoPtr_garagePlaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarPlaceManager>.NativeClassPtr, "garagePlaces");
		NativeMethodInfoPtr_SetFreeGarageIndex_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPlaceManager>.NativeClassPtr, 100672789);
		NativeMethodInfoPtr_SetPlaceIsOccupied_Public_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPlaceManager>.NativeClassPtr, 100672790);
		NativeMethodInfoPtr_SetPlaceByNameIsOccupied_Public_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPlaceManager>.NativeClassPtr, 100672791);
		NativeMethodInfoPtr_SetPlaceIsOccupied_Public_Static_Void_CarLoader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPlaceManager>.NativeClassPtr, 100672792);
		NativeMethodInfoPtr_GetPlaceIsOccupied_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPlaceManager>.NativeClassPtr, 100672793);
		NativeMethodInfoPtr_Prepare_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPlaceManager>.NativeClassPtr, 100672794);
		NativeMethodInfoPtr_ClearAll_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPlaceManager>.NativeClassPtr, 100672795);
		NativeMethodInfoPtr_DebugAll_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPlaceManager>.NativeClassPtr, 100672796);
		NativeMethodInfoPtr_GetAmountOfFreePlacesInGarage_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPlaceManager>.NativeClassPtr, 100672797);
		NativeMethodInfoPtr_GetFreeCarLoaderSaveName_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPlaceManager>.NativeClassPtr, 100672798);
		NativeMethodInfoPtr_GetFreeCarLoaderIndex_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPlaceManager>.NativeClassPtr, 100672799);
		NativeMethodInfoPtr_GetFreeCarLoaderIndexWithReservation_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPlaceManager>.NativeClassPtr, 100672800);
	}

	public CarPlaceManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
