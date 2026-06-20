using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class CarLoaderPlaces : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_places;

	private static readonly System.IntPtr NativeFieldInfoPtr_carLoaders;

	private static readonly System.IntPtr NativeFieldInfoPtr_carLoaderGroundPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_instance;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveUnusedPositionsFromCarLoaders_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableLoadOnStartOnAllCarLoaders_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareWithoutLoad_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOccupied_Public_Boolean_CarPlace_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarLoaderForPlace_Public_CarLoader_CarPlace_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarLoaderIndex_Public_Int32_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarLoaderByIndex_Public_CarLoader_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeGroundPosition_Public_Void_CarLoader_Int32_CarPlace_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GarageIsFull_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPlaceForLoadCar_Public_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFreePlace_Public_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransformToCarPlace_Public_CarPlace_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPlaceTransform_Public_Transform_CarPlace_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarLoaderId_Public_Int32_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCarLoadersCount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_CarLoaderPlaces_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarLoaderPlaces>.NativeClassPtr));

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

	public unsafe Il2CppReferenceArray<CarLoader> carLoaders
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carLoaders);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<CarLoader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carLoaders), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<int> carLoaderGroundPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carLoaderGroundPosition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<int>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carLoaderGroundPosition), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static CarLoaderPlaces m_instance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_instance, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new CarLoaderPlaces(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41251, RefRangeEnd = 41252, XrefRangeStart = 41227, XrefRangeEnd = 41251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveUnusedPositionsFromCarLoaders()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveUnusedPositionsFromCarLoaders_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41252, XrefRangeEnd = 41255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisableLoadOnStartOnAllCarLoaders()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableLoadOnStartOnAllCarLoaders_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41255, XrefRangeEnd = 41267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareWithoutLoad()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareWithoutLoad_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 41288, RefRangeEnd = 41301, XrefRangeStart = 41267, XrefRangeEnd = 41288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetOccupied(CarPlace carPlace)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&carPlace);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOccupied_Public_Boolean_CarPlace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(39)]
	[CachedScanResults(RefRangeStart = 41322, RefRangeEnd = 41361, XrefRangeStart = 41301, XrefRangeEnd = 41322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CarLoader GetCarLoaderForPlace(CarPlace carPlace)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&carPlace);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarLoaderForPlace_Public_CarLoader_CarPlace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new CarLoader(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41361, XrefRangeEnd = 41363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetCarLoaderIndex(CarLoader carLoader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarLoaderIndex_Public_Int32_CarLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 41363, RefRangeEnd = 41365, XrefRangeStart = 41363, XrefRangeEnd = 41363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CarLoader GetCarLoaderByIndex(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarLoaderByIndex_Public_CarLoader_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new CarLoader(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 41378, RefRangeEnd = 41380, XrefRangeStart = 41365, XrefRangeEnd = 41378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeGroundPosition(CarLoader carLoader, int From, CarPlace carPlace)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &From;
		*(CarPlace**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &carPlace;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeGroundPosition_Public_Void_CarLoader_Int32_CarPlace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41380, XrefRangeEnd = 41381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GarageIsFull()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GarageIsFull_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 41508, RefRangeEnd = 41510, XrefRangeStart = 41381, XrefRangeEnd = 41508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CarLoader GetPlaceForLoadCar()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPlaceForLoadCar_Public_CarLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new CarLoader(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 41537, RefRangeEnd = 41539, XrefRangeStart = 41510, XrefRangeEnd = 41537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Transform GetFreePlace()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFreePlace_Public_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41539, XrefRangeEnd = 41541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CarPlace TransformToCarPlace(Transform t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransformToCarPlace_Public_CarPlace_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(CarPlace*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe Transform GetPlaceTransform(CarPlace carPlace)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&carPlace);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPlaceTransform_Public_Transform_CarPlace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 41562, RefRangeEnd = 41565, XrefRangeStart = 41541, XrefRangeEnd = 41562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetCarLoaderId(CarLoader cl)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cl);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarLoaderId_Public_Int32_CarLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe int GetCarLoadersCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCarLoadersCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41565, XrefRangeEnd = 41597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Save()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41597, XrefRangeEnd = 41632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Load()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41632, XrefRangeEnd = 41636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41636, XrefRangeEnd = 41640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CarLoaderPlaces Get()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Static_CarLoaderPlaces_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new CarLoaderPlaces(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41640, XrefRangeEnd = 41663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe CarLoaderPlaces()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarLoaderPlaces>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CarLoaderPlaces()
	{
		Il2CppClassPointerStore<CarLoaderPlaces>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CarLoaderPlaces");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarLoaderPlaces>.NativeClassPtr);
		NativeFieldInfoPtr_places = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarLoaderPlaces>.NativeClassPtr, "places");
		NativeFieldInfoPtr_carLoaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarLoaderPlaces>.NativeClassPtr, "carLoaders");
		NativeFieldInfoPtr_carLoaderGroundPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarLoaderPlaces>.NativeClassPtr, "carLoaderGroundPosition");
		NativeFieldInfoPtr_m_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarLoaderPlaces>.NativeClassPtr, "m_instance");
		NativeMethodInfoPtr_RemoveUnusedPositionsFromCarLoaders_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLoaderPlaces>.NativeClassPtr, 100665756);
		NativeMethodInfoPtr_DisableLoadOnStartOnAllCarLoaders_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLoaderPlaces>.NativeClassPtr, 100665757);
		NativeMethodInfoPtr_PrepareWithoutLoad_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLoaderPlaces>.NativeClassPtr, 100665758);
		NativeMethodInfoPtr_GetOccupied_Public_Boolean_CarPlace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLoaderPlaces>.NativeClassPtr, 100665759);
		NativeMethodInfoPtr_GetCarLoaderForPlace_Public_CarLoader_CarPlace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLoaderPlaces>.NativeClassPtr, 100665760);
		NativeMethodInfoPtr_GetCarLoaderIndex_Public_Int32_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLoaderPlaces>.NativeClassPtr, 100665761);
		NativeMethodInfoPtr_GetCarLoaderByIndex_Public_CarLoader_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLoaderPlaces>.NativeClassPtr, 100665762);
		NativeMethodInfoPtr_ChangeGroundPosition_Public_Void_CarLoader_Int32_CarPlace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLoaderPlaces>.NativeClassPtr, 100665763);
		NativeMethodInfoPtr_GarageIsFull_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLoaderPlaces>.NativeClassPtr, 100665764);
		NativeMethodInfoPtr_GetPlaceForLoadCar_Public_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLoaderPlaces>.NativeClassPtr, 100665765);
		NativeMethodInfoPtr_GetFreePlace_Public_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLoaderPlaces>.NativeClassPtr, 100665766);
		NativeMethodInfoPtr_TransformToCarPlace_Public_CarPlace_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLoaderPlaces>.NativeClassPtr, 100665767);
		NativeMethodInfoPtr_GetPlaceTransform_Public_Transform_CarPlace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLoaderPlaces>.NativeClassPtr, 100665768);
		NativeMethodInfoPtr_GetCarLoaderId_Public_Int32_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLoaderPlaces>.NativeClassPtr, 100665769);
		NativeMethodInfoPtr_GetCarLoadersCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLoaderPlaces>.NativeClassPtr, 100665770);
		NativeMethodInfoPtr_Save_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLoaderPlaces>.NativeClassPtr, 100665771);
		NativeMethodInfoPtr_Load_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLoaderPlaces>.NativeClassPtr, 100665772);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLoaderPlaces>.NativeClassPtr, 100665773);
		NativeMethodInfoPtr_Get_Public_Static_CarLoaderPlaces_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLoaderPlaces>.NativeClassPtr, 100665774);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLoaderPlaces>.NativeClassPtr, 100665775);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLoaderPlaces>.NativeClassPtr, 100665776);
	}

	public CarLoaderPlaces(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
