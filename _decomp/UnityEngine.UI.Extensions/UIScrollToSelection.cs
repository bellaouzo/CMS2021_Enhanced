using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions;

public class UIScrollToSelection : MonoBehaviour
{
	public enum ScrollType
	{
		VERTICAL,
		HORIZONTAL,
		BOTH,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ScrollType>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static ScrollType()
		{
			Il2CppClassPointerStore<ScrollType>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, "ScrollType");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_scrollDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_scrollSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_cancelScrollOnInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_cancelScrollKeycodes;

	private static readonly System.IntPtr NativeFieldInfoPtr__ScrollWindow_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__TargetScrollRect_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__LastCheckedGameObject_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__CurrentTargetRectTransform_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__IsManualScrollingAvailable_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LayoutListGroup_Protected_get_RectTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ScrollDirection_Protected_get_ScrollType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ScrollSpeed_Protected_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CancelScrollOnInput_Protected_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CancelScrollKeycodes_Protected_get_List_1_KeyCode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ScrollWindow_Protected_get_RectTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ScrollWindow_Protected_set_Void_RectTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TargetScrollRect_Protected_get_ScrollRect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetScrollRect_Protected_set_Void_ScrollRect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentEventSystem_Protected_get_EventSystem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LastCheckedGameObject_Protected_get_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_LastCheckedGameObject_Protected_set_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentSelectedGameObject_Protected_get_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentTargetRectTransform_Protected_get_RectTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentTargetRectTransform_Protected_set_Void_RectTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsManualScrollingAvailable_Protected_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_IsManualScrollingAvailable_Protected_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateReferences_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckIfScrollingShouldBeLocked_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScrollRectToLevelSelection_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVerticalScrollPosition_Private_Void_RectTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateHorizontalScrollPosition_Private_Void_RectTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetScrollOffset_Private_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr));

	public unsafe ScrollType scrollDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scrollDirection);
			return *(ScrollType*)num;
		}
		set
		{
			*(ScrollType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scrollDirection)) = scrollType;
		}
	}

	public unsafe float scrollSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scrollSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scrollSpeed)) = num;
		}
	}

	public unsafe bool cancelScrollOnInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cancelScrollOnInput);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cancelScrollOnInput)) = flag;
		}
	}

	public unsafe List<KeyCode> cancelScrollKeycodes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cancelScrollKeycodes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<KeyCode>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cancelScrollKeycodes), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RectTransform _ScrollWindow_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ScrollWindow_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RectTransform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ScrollWindow_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ScrollRect _TargetScrollRect_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TargetScrollRect_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ScrollRect(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TargetScrollRect_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject _LastCheckedGameObject_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__LastCheckedGameObject_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__LastCheckedGameObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RectTransform _CurrentTargetRectTransform_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurrentTargetRectTransform_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RectTransform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurrentTargetRectTransform_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool _IsManualScrollingAvailable_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsManualScrollingAvailable_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsManualScrollingAvailable_k__BackingField)) = flag;
		}
	}

	public unsafe RectTransform LayoutListGroup
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 121806, RefRangeEnd = 121813, XrefRangeStart = 121794, XrefRangeEnd = 121806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LayoutListGroup_Protected_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new RectTransform(intPtr) : null;
		}
	}

	public unsafe ScrollType ScrollDirection
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ScrollDirection_Protected_get_ScrollType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(ScrollType*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe float ScrollSpeed
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ScrollSpeed_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe bool CancelScrollOnInput
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CancelScrollOnInput_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe List<KeyCode> CancelScrollKeycodes
	{
		[CallerCount(4)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CancelScrollKeycodes_Protected_get_List_1_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new List<KeyCode>(intPtr) : null;
		}
	}

	public unsafe RectTransform ScrollWindow
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 121813, RefRangeEnd = 121814, XrefRangeStart = 121813, XrefRangeEnd = 121813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ScrollWindow_Protected_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new RectTransform(intPtr) : null;
		}
		[CallerCount(24)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ScrollWindow_Protected_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe ScrollRect TargetScrollRect
	{
		[CallerCount(70)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TargetScrollRect_Protected_get_ScrollRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new ScrollRect(intPtr) : null;
		}
		[CallerCount(44)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_TargetScrollRect_Protected_set_Void_ScrollRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe EventSystem CurrentEventSystem
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121814, XrefRangeEnd = 121818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentEventSystem_Protected_get_EventSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new EventSystem(intPtr) : null;
		}
	}

	public unsafe GameObject LastCheckedGameObject
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LastCheckedGameObject_Protected_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		[CallerCount(36)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LastCheckedGameObject_Protected_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe GameObject CurrentSelectedGameObject
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 121822, RefRangeEnd = 121824, XrefRangeStart = 121818, XrefRangeEnd = 121822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentSelectedGameObject_Protected_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
	}

	public unsafe RectTransform CurrentTargetRectTransform
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentTargetRectTransform_Protected_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new RectTransform(intPtr) : null;
		}
		[CallerCount(20)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CurrentTargetRectTransform_Protected_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe bool IsManualScrollingAvailable
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsManualScrollingAvailable_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsManualScrollingAvailable_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121824, XrefRangeEnd = 121830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121830, XrefRangeEnd = 121841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 121923, RefRangeEnd = 121924, XrefRangeStart = 121841, XrefRangeEnd = 121923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateReferences()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateReferences_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121924, XrefRangeEnd = 121929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckIfScrollingShouldBeLocked()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckIfScrollingShouldBeLocked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 121999, RefRangeEnd = 122000, XrefRangeStart = 121929, XrefRangeEnd = 121999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ScrollRectToLevelSelection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScrollRectToLevelSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 122030, RefRangeEnd = 122031, XrefRangeStart = 122000, XrefRangeEnd = 122030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateVerticalScrollPosition(RectTransform selection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(selection);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateVerticalScrollPosition_Private_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 122061, RefRangeEnd = 122062, XrefRangeStart = 122031, XrefRangeEnd = 122061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateHorizontalScrollPosition(RectTransform selection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(selection);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateHorizontalScrollPosition_Private_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe float GetScrollOffset(float position, float listAnchorPosition, float targetLength, float maskLength)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&position);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &listAnchorPosition;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetLength;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maskLength;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetScrollOffset_Private_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122062, XrefRangeEnd = 122071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIScrollToSelection()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static UIScrollToSelection()
	{
		Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "UnityEngine.UI.Extensions", "UIScrollToSelection");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr);
		NativeFieldInfoPtr_scrollDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, "scrollDirection");
		NativeFieldInfoPtr_scrollSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, "scrollSpeed");
		NativeFieldInfoPtr_cancelScrollOnInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, "cancelScrollOnInput");
		NativeFieldInfoPtr_cancelScrollKeycodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, "cancelScrollKeycodes");
		NativeFieldInfoPtr__ScrollWindow_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, "<ScrollWindow>k__BackingField");
		NativeFieldInfoPtr__TargetScrollRect_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, "<TargetScrollRect>k__BackingField");
		NativeFieldInfoPtr__LastCheckedGameObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, "<LastCheckedGameObject>k__BackingField");
		NativeFieldInfoPtr__CurrentTargetRectTransform_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, "<CurrentTargetRectTransform>k__BackingField");
		NativeFieldInfoPtr__IsManualScrollingAvailable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, "<IsManualScrollingAvailable>k__BackingField");
		NativeMethodInfoPtr_get_LayoutListGroup_Protected_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, 100671085);
		NativeMethodInfoPtr_get_ScrollDirection_Protected_get_ScrollType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, 100671086);
		NativeMethodInfoPtr_get_ScrollSpeed_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, 100671087);
		NativeMethodInfoPtr_get_CancelScrollOnInput_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, 100671088);
		NativeMethodInfoPtr_get_CancelScrollKeycodes_Protected_get_List_1_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, 100671089);
		NativeMethodInfoPtr_get_ScrollWindow_Protected_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, 100671090);
		NativeMethodInfoPtr_set_ScrollWindow_Protected_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, 100671091);
		NativeMethodInfoPtr_get_TargetScrollRect_Protected_get_ScrollRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, 100671092);
		NativeMethodInfoPtr_set_TargetScrollRect_Protected_set_Void_ScrollRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, 100671093);
		NativeMethodInfoPtr_get_CurrentEventSystem_Protected_get_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, 100671094);
		NativeMethodInfoPtr_get_LastCheckedGameObject_Protected_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, 100671095);
		NativeMethodInfoPtr_set_LastCheckedGameObject_Protected_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, 100671096);
		NativeMethodInfoPtr_get_CurrentSelectedGameObject_Protected_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, 100671097);
		NativeMethodInfoPtr_get_CurrentTargetRectTransform_Protected_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, 100671098);
		NativeMethodInfoPtr_set_CurrentTargetRectTransform_Protected_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, 100671099);
		NativeMethodInfoPtr_get_IsManualScrollingAvailable_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, 100671100);
		NativeMethodInfoPtr_set_IsManualScrollingAvailable_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, 100671101);
		NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, 100671102);
		NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, 100671103);
		NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, 100671104);
		NativeMethodInfoPtr_UpdateReferences_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, 100671105);
		NativeMethodInfoPtr_CheckIfScrollingShouldBeLocked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, 100671106);
		NativeMethodInfoPtr_ScrollRectToLevelSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, 100671107);
		NativeMethodInfoPtr_UpdateVerticalScrollPosition_Private_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, 100671108);
		NativeMethodInfoPtr_UpdateHorizontalScrollPosition_Private_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, 100671109);
		NativeMethodInfoPtr_GetScrollOffset_Private_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, 100671110);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScrollToSelection>.NativeClassPtr, 100671111);
	}

	public UIScrollToSelection(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
