using System;
using System.Runtime.CompilerServices;
using CMS.UI.Logic.Navigation;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.UI.Helpers;

public static class NavigationHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_SelectLastPosIfMouse_Public_Static_Boolean_GridNavigationManager_InputManager_Vector2Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectItemOnNextPage_Public_Static_Void_GridNavigationManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectItemOnPreviousPage_Public_Static_Void_GridNavigationManager_Boolean_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<NavigationHelper>.NativeClassPtr));

	[CallerCount(24)]
	[CachedScanResults(RefRangeStart = 207249, RefRangeEnd = 207273, XrefRangeStart = 207229, XrefRangeEnd = 207249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SelectLastPosIfMouse(GridNavigationManager grid, InputManager inputManager, Vector2Int lastPos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(grid);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(inputManager);
		*(Vector2Int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &lastPos;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectLastPosIfMouse_Public_Static_Boolean_GridNavigationManager_InputManager_Vector2Int_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 207281, RefRangeEnd = 207293, XrefRangeStart = 207273, XrefRangeEnd = 207281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SelectItemOnNextPage(GridNavigationManager grid)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(grid);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectItemOnNextPage_Public_Static_Void_GridNavigationManager_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 207300, RefRangeEnd = 207312, XrefRangeStart = 207293, XrefRangeEnd = 207300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SelectItemOnPreviousPage(GridNavigationManager grid, bool selectFirstItemOnPage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(grid);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &selectFirstItemOnPage;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectItemOnPreviousPage_Public_Static_Void_GridNavigationManager_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static NavigationHelper()
	{
		Il2CppClassPointerStore<NavigationHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Helpers", "NavigationHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationHelper>.NativeClassPtr);
		NativeMethodInfoPtr_SelectLastPosIfMouse_Public_Static_Boolean_GridNavigationManager_InputManager_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationHelper>.NativeClassPtr, 100678769);
		NativeMethodInfoPtr_SelectItemOnNextPage_Public_Static_Void_GridNavigationManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationHelper>.NativeClassPtr, 100678770);
		NativeMethodInfoPtr_SelectItemOnPreviousPage_Public_Static_Void_GridNavigationManager_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationHelper>.NativeClassPtr, 100678771);
	}

	public NavigationHelper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
