using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions;

public class VerticalScrollSnap : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr__screensContainer;

	private static readonly System.IntPtr NativeFieldInfoPtr__screens;

	private static readonly System.IntPtr NativeFieldInfoPtr__fastSwipeTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr__fastSwipeCounter;

	private static readonly System.IntPtr NativeFieldInfoPtr__fastSwipeTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr__positions;

	private static readonly System.IntPtr NativeFieldInfoPtr__scroll_rect;

	private static readonly System.IntPtr NativeFieldInfoPtr__lerp_target;

	private static readonly System.IntPtr NativeFieldInfoPtr__lerp;

	private static readonly System.IntPtr NativeFieldInfoPtr_Pagination;

	private static readonly System.IntPtr NativeFieldInfoPtr_NextButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_PrevButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_transitionSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_UseFastSwipe;

	private static readonly System.IntPtr NativeFieldInfoPtr_FastSwipeThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr__startDrag;

	private static readonly System.IntPtr NativeFieldInfoPtr__startPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr__currentScreen;

	private static readonly System.IntPtr NativeFieldInfoPtr_StartingScreen;

	private static readonly System.IntPtr NativeFieldInfoPtr_PageStep;

	private static readonly System.IntPtr NativeFieldInfoPtr_fastSwipe;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentPage_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NextScreen_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreviousScreen_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GoToScreen_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NextScreenCommand_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrevScreenCommand_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindClosestFrom_Private_Vector3_Vector3_List_1_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CurrentScreen_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeBulletsInfo_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DistributePages_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPageforPosition_Private_Int32_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddChild_Public_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveChild_Public_Void_Int32_byref_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_Final_New_Void_PointerEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEndDrag_Public_Virtual_Final_New_Void_PointerEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDrag_Public_Virtual_Final_New_Void_PointerEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__22_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__22_1_Private_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr));

	public unsafe Transform _screensContainer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__screensContainer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__screensContainer), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int _screens
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__screens);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__screens)) = num;
		}
	}

	public unsafe bool _fastSwipeTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fastSwipeTimer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fastSwipeTimer)) = flag;
		}
	}

	public unsafe int _fastSwipeCounter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fastSwipeCounter);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fastSwipeCounter)) = num;
		}
	}

	public unsafe int _fastSwipeTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fastSwipeTarget);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fastSwipeTarget)) = num;
		}
	}

	public unsafe List<Vector3> _positions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__positions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<Vector3>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__positions), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ScrollRect _scroll_rect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__scroll_rect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ScrollRect(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__scroll_rect), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector3 _lerp_target
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lerp_target);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lerp_target)) = vector;
		}
	}

	public unsafe bool _lerp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lerp);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lerp)) = flag;
		}
	}

	public unsafe GameObject Pagination
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Pagination);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Pagination), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject NextButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NextButton);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NextButton), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject PrevButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PrevButton);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PrevButton), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float transitionSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transitionSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transitionSpeed)) = num;
		}
	}

	public unsafe bool UseFastSwipe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseFastSwipe);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseFastSwipe)) = flag;
		}
	}

	public unsafe int FastSwipeThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FastSwipeThreshold);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FastSwipeThreshold)) = num;
		}
	}

	public unsafe bool _startDrag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__startDrag);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__startDrag)) = flag;
		}
	}

	public unsafe Vector3 _startPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__startPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__startPosition)) = vector;
		}
	}

	public unsafe int _currentScreen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentScreen);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentScreen)) = num;
		}
	}

	public unsafe int StartingScreen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartingScreen);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartingScreen)) = num;
		}
	}

	public unsafe int PageStep
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PageStep);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PageStep)) = num;
		}
	}

	public unsafe bool fastSwipe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastSwipe);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastSwipe)) = flag;
		}
	}

	public unsafe int CurrentPage
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentPage_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119981, XrefRangeEnd = 120028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120028, XrefRangeEnd = 120043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120043, XrefRangeEnd = 120045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NextScreen()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextScreen_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120045, XrefRangeEnd = 120047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreviousScreen()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreviousScreen_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120047, XrefRangeEnd = 120049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GoToScreen(int screenIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&screenIndex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GoToScreen_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120049, XrefRangeEnd = 120051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NextScreenCommand()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextScreenCommand_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120051, XrefRangeEnd = 120053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrevScreenCommand()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrevScreenCommand_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 120074, RefRangeEnd = 120076, XrefRangeStart = 120053, XrefRangeEnd = 120074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 FindClosestFrom(Vector3 start, List<Vector3> positions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&start);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(positions);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindClosestFrom_Private_Vector3_Vector3_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 120080, RefRangeEnd = 120083, XrefRangeStart = 120076, XrefRangeEnd = 120080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int CurrentScreen()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CurrentScreen_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 120100, RefRangeEnd = 120110, XrefRangeStart = 120083, XrefRangeEnd = 120100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeBulletsInfo(int currentScreen)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&currentScreen);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeBulletsInfo_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 120149, RefRangeEnd = 120152, XrefRangeStart = 120110, XrefRangeEnd = 120149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DistributePages()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DistributePages_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 120155, RefRangeEnd = 120157, XrefRangeStart = 120152, XrefRangeEnd = 120155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetPageforPosition(Vector3 pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pos);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPageforPosition_Private_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120157, XrefRangeEnd = 120164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnValidate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120164, XrefRangeEnd = 120174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddChild(GameObject GO)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(GO);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddChild_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120174, XrefRangeEnd = 120200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveChild(int index, out GameObject ChildRemoved)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(ChildRemoved);
		*(System.IntPtr**)num = &intPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveChild_Public_Void_Int32_byref_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		ChildRemoved = ((intPtr3 == (System.IntPtr)0) ? null : new GameObject(intPtr3));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120200, XrefRangeEnd = 120203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBeginDrag(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120203, XrefRangeEnd = 120220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEndDrag(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEndDrag_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120220, XrefRangeEnd = 120223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDrag(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDrag_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe VerticalScrollSnap()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void _Start_b__22_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Start_b__22_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void _Start_b__22_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Start_b__22_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VerticalScrollSnap()
	{
		Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "UnityEngine.UI.Extensions", "VerticalScrollSnap");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr);
		NativeFieldInfoPtr__screensContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, "_screensContainer");
		NativeFieldInfoPtr__screens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, "_screens");
		NativeFieldInfoPtr__fastSwipeTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, "_fastSwipeTimer");
		NativeFieldInfoPtr__fastSwipeCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, "_fastSwipeCounter");
		NativeFieldInfoPtr__fastSwipeTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, "_fastSwipeTarget");
		NativeFieldInfoPtr__positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, "_positions");
		NativeFieldInfoPtr__scroll_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, "_scroll_rect");
		NativeFieldInfoPtr__lerp_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, "_lerp_target");
		NativeFieldInfoPtr__lerp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, "_lerp");
		NativeFieldInfoPtr_Pagination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, "Pagination");
		NativeFieldInfoPtr_NextButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, "NextButton");
		NativeFieldInfoPtr_PrevButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, "PrevButton");
		NativeFieldInfoPtr_transitionSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, "transitionSpeed");
		NativeFieldInfoPtr_UseFastSwipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, "UseFastSwipe");
		NativeFieldInfoPtr_FastSwipeThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, "FastSwipeThreshold");
		NativeFieldInfoPtr__startDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, "_startDrag");
		NativeFieldInfoPtr__startPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, "_startPosition");
		NativeFieldInfoPtr__currentScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, "_currentScreen");
		NativeFieldInfoPtr_StartingScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, "StartingScreen");
		NativeFieldInfoPtr_PageStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, "PageStep");
		NativeFieldInfoPtr_fastSwipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, "fastSwipe");
		NativeMethodInfoPtr_get_CurrentPage_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, 100670926);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, 100670927);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, 100670928);
		NativeMethodInfoPtr_NextScreen_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, 100670929);
		NativeMethodInfoPtr_PreviousScreen_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, 100670930);
		NativeMethodInfoPtr_GoToScreen_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, 100670931);
		NativeMethodInfoPtr_NextScreenCommand_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, 100670932);
		NativeMethodInfoPtr_PrevScreenCommand_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, 100670933);
		NativeMethodInfoPtr_FindClosestFrom_Private_Vector3_Vector3_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, 100670934);
		NativeMethodInfoPtr_CurrentScreen_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, 100670935);
		NativeMethodInfoPtr_ChangeBulletsInfo_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, 100670936);
		NativeMethodInfoPtr_DistributePages_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, 100670937);
		NativeMethodInfoPtr_GetPageforPosition_Private_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, 100670938);
		NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, 100670939);
		NativeMethodInfoPtr_AddChild_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, 100670940);
		NativeMethodInfoPtr_RemoveChild_Public_Void_Int32_byref_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, 100670941);
		NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, 100670942);
		NativeMethodInfoPtr_OnEndDrag_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, 100670943);
		NativeMethodInfoPtr_OnDrag_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, 100670944);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, 100670945);
		NativeMethodInfoPtr__Start_b__22_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, 100670946);
		NativeMethodInfoPtr__Start_b__22_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalScrollSnap>.NativeClassPtr, 100670947);
	}

	public VerticalScrollSnap(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
