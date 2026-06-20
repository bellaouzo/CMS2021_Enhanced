using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.PhotoLocations;

public class CarPlacesProvider : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_carLoader;

	private static readonly System.IntPtr NativeFieldInfoPtr_places;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentPlace;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAvailablePlaces_Public_Int32_byref_ArrayOf_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentPlace_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPlaces_Public_Void_ArrayOf_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCarLoaderPlace_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarPlacesProvider>.NativeClassPtr));

	public unsafe CarLoader carLoader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carLoader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CarLoader(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carLoader), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<Transform> places
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_places);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_places), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int currentPlace
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentPlace);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentPlace)) = num;
		}
	}

	[CallerCount(0)]
	public unsafe int GetAvailablePlaces(out Il2CppReferenceArray<Transform> availablePlaces)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(availablePlaces);
		*ptr = (nint)(&intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAvailablePlaces_Public_Int32_byref_ArrayOf_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr2 = intPtr;
		availablePlaces = (Il2CppReferenceArray<Transform>)(object)((intPtr2 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<T>(intPtr2));
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe int GetCurrentPlace()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentPlace_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(38)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void SetPlaces(Il2CppReferenceArray<Transform> _places)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(_places);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPlaces_Public_Void_ArrayOf_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 139861, RefRangeEnd = 139863, XrefRangeStart = 139832, XrefRangeEnd = 139861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCarLoaderPlace(int placeIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&placeIndex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCarLoaderPlace_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe CarPlacesProvider()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarPlacesProvider>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CarPlacesProvider()
	{
		Il2CppClassPointerStore<CarPlacesProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.PhotoLocations", "CarPlacesProvider");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarPlacesProvider>.NativeClassPtr);
		NativeFieldInfoPtr_carLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarPlacesProvider>.NativeClassPtr, "carLoader");
		NativeFieldInfoPtr_places = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarPlacesProvider>.NativeClassPtr, "places");
		NativeFieldInfoPtr_currentPlace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarPlacesProvider>.NativeClassPtr, "currentPlace");
		NativeMethodInfoPtr_GetAvailablePlaces_Public_Int32_byref_ArrayOf_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPlacesProvider>.NativeClassPtr, 100672698);
		NativeMethodInfoPtr_GetCurrentPlace_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPlacesProvider>.NativeClassPtr, 100672699);
		NativeMethodInfoPtr_SetPlaces_Public_Void_ArrayOf_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPlacesProvider>.NativeClassPtr, 100672700);
		NativeMethodInfoPtr_SetCarLoaderPlace_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPlacesProvider>.NativeClassPtr, 100672701);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarPlacesProvider>.NativeClassPtr, 100672702);
	}

	public CarPlacesProvider(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
