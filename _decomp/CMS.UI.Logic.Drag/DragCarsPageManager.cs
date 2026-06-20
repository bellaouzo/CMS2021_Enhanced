using System;
using System.Runtime.CompilerServices;
using CMS.UI.Logic.Navigation;
using CMS.UI.Logic.Paging;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Rewired;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.UI.Logic.Drag;

public class DragCarsPageManager : PagedWindowBase
{
	private static readonly System.IntPtr NativeFieldInfoPtr_gridNavigationManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_carItems;

	private static readonly System.IntPtr NativeFieldInfoPtr_cars;

	private static readonly System.IntPtr NativeFieldInfoPtr_carsInGarage;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputManager;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareArrows_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareFirstPage_Public_Void_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCurrentPage_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItems_Public_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetItemsPerPageCount_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareInputManager_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGrid_Public_Void_GridNavigationManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentPageItemsCount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPagesCount_Protected_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPage_Protected_Virtual_Page_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawPage_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckIfCarInGarage_Private_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Refresh_Public_Virtual_New_Void_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPageEvent_Public_Void_Byte_Byte_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NextPage_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreviousPage_Public_Virtual_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleGridInput_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Boolean_Player_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DragCarsPageManager>.NativeClassPtr));

	public unsafe GridNavigationManager gridNavigationManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gridNavigationManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GridNavigationManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gridNavigationManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<ShowroomCarItem> carItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carItems);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<ShowroomCarItem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carItems), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<string> cars
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cars);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cars), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStringArray carsInGarage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carsInGarage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStringArray(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carsInGarage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InputManager inputManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 199041, RefRangeEnd = 199043, XrefRangeStart = 199029, XrefRangeEnd = 199041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareArrows()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareArrows_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 199043, RefRangeEnd = 199045, XrefRangeStart = 199043, XrefRangeEnd = 199043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareFirstPage(List<string> carsList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carsList);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareFirstPage_Public_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetCurrentPage(int page)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&page);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCurrentPage_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe List<string> GetItems()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItems_Public_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe void SetItemsPerPageCount(int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&count);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetItemsPerPageCount_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199045, XrefRangeEnd = 199052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareInputManager()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareInputManager_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(10)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void SetGrid(GridNavigationManager grid)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(grid);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGrid_Public_Void_GridNavigationManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe int GetCurrentPageItemsCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentPageItemsCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199052, XrefRangeEnd = 199058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe int GetPagesCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetPagesCount_Protected_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199058, XrefRangeEnd = 199072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe Page GetPage(int pageIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pageIndex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetPage_Protected_Virtual_Page_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Page(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199072, XrefRangeEnd = 199100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void DrawPage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_DrawPage_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199100, XrefRangeEnd = 199102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckIfCarInGarage(string car)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(car);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckIfCarInGarage_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe void Refresh(List<string> newCars)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(newCars);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Refresh_Public_Virtual_New_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void OnPageEvent(byte eventType, byte column, byte row)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&eventType);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &column;
		*(byte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &row;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPageEvent_Public_Void_Byte_Byte_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public new unsafe void NextPage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_NextPage_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public new unsafe void PreviousPage(bool selectFirstItemOnPage = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&selectFirstItemOnPage);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_PreviousPage_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe bool HandleGridInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleGridInput_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199102, XrefRangeEnd = 199108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HandleInput(Player player)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleInput_Public_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe DragCarsPageManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragCarsPageManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DragCarsPageManager()
	{
		Il2CppClassPointerStore<DragCarsPageManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Drag", "DragCarsPageManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragCarsPageManager>.NativeClassPtr);
		NativeFieldInfoPtr_gridNavigationManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragCarsPageManager>.NativeClassPtr, "gridNavigationManager");
		NativeFieldInfoPtr_carItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragCarsPageManager>.NativeClassPtr, "carItems");
		NativeFieldInfoPtr_cars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragCarsPageManager>.NativeClassPtr, "cars");
		NativeFieldInfoPtr_carsInGarage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragCarsPageManager>.NativeClassPtr, "carsInGarage");
		NativeFieldInfoPtr_inputManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragCarsPageManager>.NativeClassPtr, "inputManager");
		NativeMethodInfoPtr_PrepareArrows_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarsPageManager>.NativeClassPtr, 100678268);
		NativeMethodInfoPtr_PrepareFirstPage_Public_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarsPageManager>.NativeClassPtr, 100678269);
		NativeMethodInfoPtr_SetCurrentPage_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarsPageManager>.NativeClassPtr, 100678270);
		NativeMethodInfoPtr_GetItems_Public_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarsPageManager>.NativeClassPtr, 100678271);
		NativeMethodInfoPtr_SetItemsPerPageCount_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarsPageManager>.NativeClassPtr, 100678272);
		NativeMethodInfoPtr_PrepareInputManager_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarsPageManager>.NativeClassPtr, 100678273);
		NativeMethodInfoPtr_SetGrid_Public_Void_GridNavigationManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarsPageManager>.NativeClassPtr, 100678274);
		NativeMethodInfoPtr_GetCurrentPageItemsCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarsPageManager>.NativeClassPtr, 100678275);
		NativeMethodInfoPtr_GetPagesCount_Protected_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarsPageManager>.NativeClassPtr, 100678276);
		NativeMethodInfoPtr_GetPage_Protected_Virtual_Page_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarsPageManager>.NativeClassPtr, 100678277);
		NativeMethodInfoPtr_DrawPage_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarsPageManager>.NativeClassPtr, 100678278);
		NativeMethodInfoPtr_CheckIfCarInGarage_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarsPageManager>.NativeClassPtr, 100678279);
		NativeMethodInfoPtr_Refresh_Public_Virtual_New_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarsPageManager>.NativeClassPtr, 100678280);
		NativeMethodInfoPtr_OnPageEvent_Public_Void_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarsPageManager>.NativeClassPtr, 100678281);
		NativeMethodInfoPtr_NextPage_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarsPageManager>.NativeClassPtr, 100678282);
		NativeMethodInfoPtr_PreviousPage_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarsPageManager>.NativeClassPtr, 100678283);
		NativeMethodInfoPtr_HandleGridInput_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarsPageManager>.NativeClassPtr, 100678284);
		NativeMethodInfoPtr_HandleInput_Public_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarsPageManager>.NativeClassPtr, 100678285);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCarsPageManager>.NativeClassPtr, 100678286);
	}

	public DragCarsPageManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
