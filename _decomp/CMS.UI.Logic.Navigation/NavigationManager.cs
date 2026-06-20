using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.UI.Logic.Navigation;

public class NavigationManager : MonoBehaviour
{
	public enum Direction
	{
		Up,
		Down,
		Left,
		Right,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Direction>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static Direction()
		{
			Il2CppClassPointerStore<Direction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationManager>.NativeClassPtr, "Direction");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_timeToHold;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentSelectedRow;

	private static readonly System.IntPtr NativeFieldInfoPtr_isEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableNavigation;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentFeatures;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFeatures_Public_NavigationFeatures_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFeatures_Public_Void_NavigationFeatures_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableAllFeatures_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableAllFeatures_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddFeature_Public_Void_NavigationFeatures_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveFeature_Public_Void_NavigationFeatures_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectFirst_Public_Abstract_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectCurrent_Public_Abstract_Virtual_New_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeselectCurrent_Public_Abstract_Virtual_New_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEnabled_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCurrentItemSelected_Public_Abstract_Virtual_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Abstract_Virtual_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<NavigationManager>.NativeClassPtr));

	public unsafe float timeToHold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeToHold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeToHold)) = num;
		}
	}

	public unsafe int currentSelectedRow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSelectedRow);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSelectedRow)) = num;
		}
	}

	public unsafe bool isEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isEnabled)) = flag;
		}
	}

	public unsafe bool disableNavigation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableNavigation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableNavigation)) = flag;
		}
	}

	public unsafe NavigationFeatures currentFeatures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentFeatures);
			return *(NavigationFeatures*)num;
		}
		set
		{
			*(NavigationFeatures*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentFeatures)) = navigationFeatures;
		}
	}

	[CallerCount(0)]
	public unsafe NavigationFeatures GetFeatures()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFeatures_Public_NavigationFeatures_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(NavigationFeatures*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe void SetFeatures(NavigationFeatures newFeatures)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newFeatures);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFeatures_Public_Void_NavigationFeatures_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void EnableAllFeatures()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableAllFeatures_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void DisableAllFeatures()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableAllFeatures_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void AddFeature(NavigationFeatures feature)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&feature);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddFeature_Public_Void_NavigationFeatures_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void RemoveFeature(NavigationFeatures feature)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&feature);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveFeature_Public_Void_NavigationFeatures_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SelectFirst()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SelectFirst_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SelectCurrent(bool force = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&force);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SelectCurrent_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void DeselectCurrent(bool force = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&force);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_DeselectCurrent_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetEnabled(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetEnabled(bool enable, bool changeSelectState)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&enable);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &changeSelectState;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool IsEnabled()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEnabled_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool IsCurrentItemSelected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_IsCurrentItemSelected_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool HandleInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_HandleInput_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe NavigationManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static NavigationManager()
	{
		Il2CppClassPointerStore<NavigationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Navigation", "NavigationManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationManager>.NativeClassPtr);
		NativeFieldInfoPtr_timeToHold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationManager>.NativeClassPtr, "timeToHold");
		NativeFieldInfoPtr_currentSelectedRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationManager>.NativeClassPtr, "currentSelectedRow");
		NativeFieldInfoPtr_isEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationManager>.NativeClassPtr, "isEnabled");
		NativeFieldInfoPtr_disableNavigation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationManager>.NativeClassPtr, "disableNavigation");
		NativeFieldInfoPtr_currentFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationManager>.NativeClassPtr, "currentFeatures");
		NativeMethodInfoPtr_GetFeatures_Public_NavigationFeatures_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationManager>.NativeClassPtr, 100677945);
		NativeMethodInfoPtr_SetFeatures_Public_Void_NavigationFeatures_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationManager>.NativeClassPtr, 100677946);
		NativeMethodInfoPtr_EnableAllFeatures_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationManager>.NativeClassPtr, 100677947);
		NativeMethodInfoPtr_DisableAllFeatures_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationManager>.NativeClassPtr, 100677948);
		NativeMethodInfoPtr_AddFeature_Public_Void_NavigationFeatures_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationManager>.NativeClassPtr, 100677949);
		NativeMethodInfoPtr_RemoveFeature_Public_Void_NavigationFeatures_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationManager>.NativeClassPtr, 100677950);
		NativeMethodInfoPtr_SelectFirst_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationManager>.NativeClassPtr, 100677951);
		NativeMethodInfoPtr_SelectCurrent_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationManager>.NativeClassPtr, 100677952);
		NativeMethodInfoPtr_DeselectCurrent_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationManager>.NativeClassPtr, 100677953);
		NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationManager>.NativeClassPtr, 100677954);
		NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationManager>.NativeClassPtr, 100677955);
		NativeMethodInfoPtr_IsEnabled_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationManager>.NativeClassPtr, 100677956);
		NativeMethodInfoPtr_IsCurrentItemSelected_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationManager>.NativeClassPtr, 100677957);
		NativeMethodInfoPtr_HandleInput_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationManager>.NativeClassPtr, 100677958);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationManager>.NativeClassPtr, 100677959);
	}

	public NavigationManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
