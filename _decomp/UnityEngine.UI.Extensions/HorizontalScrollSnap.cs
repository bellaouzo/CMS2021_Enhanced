using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions;

public class HorizontalScrollSnap : MonoBehaviour
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

	private static readonly System.IntPtr NativeMethodInfoPtr_DistributePages_Private_Void_0;

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
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr));

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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118886, XrefRangeEnd = 118933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118933, XrefRangeEnd = 118948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118948, XrefRangeEnd = 118950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NextScreen()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextScreen_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118950, XrefRangeEnd = 118952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreviousScreen()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreviousScreen_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118952, XrefRangeEnd = 118954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118954, XrefRangeEnd = 118956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NextScreenCommand()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextScreenCommand_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118956, XrefRangeEnd = 118958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrevScreenCommand()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrevScreenCommand_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 118979, RefRangeEnd = 118981, XrefRangeStart = 118958, XrefRangeEnd = 118979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 118985, RefRangeEnd = 118988, XrefRangeStart = 118981, XrefRangeEnd = 118985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 119005, RefRangeEnd = 119015, XrefRangeStart = 118988, XrefRangeEnd = 119005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 119054, RefRangeEnd = 119057, XrefRangeStart = 119015, XrefRangeEnd = 119054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DistributePages()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DistributePages_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 119060, RefRangeEnd = 119062, XrefRangeStart = 119057, XrefRangeEnd = 119060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119062, XrefRangeEnd = 119069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnValidate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119069, XrefRangeEnd = 119079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119079, XrefRangeEnd = 119105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119105, XrefRangeEnd = 119108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119108, XrefRangeEnd = 119125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119125, XrefRangeEnd = 119128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119128, XrefRangeEnd = 119131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HorizontalScrollSnap()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr))
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

	static HorizontalScrollSnap()
	{
		Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "UnityEngine.UI.Extensions", "HorizontalScrollSnap");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr);
		NativeFieldInfoPtr__screensContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, "_screensContainer");
		NativeFieldInfoPtr__screens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, "_screens");
		NativeFieldInfoPtr__fastSwipeTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, "_fastSwipeTimer");
		NativeFieldInfoPtr__fastSwipeCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, "_fastSwipeCounter");
		NativeFieldInfoPtr__fastSwipeTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, "_fastSwipeTarget");
		NativeFieldInfoPtr__positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, "_positions");
		NativeFieldInfoPtr__scroll_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, "_scroll_rect");
		NativeFieldInfoPtr__lerp_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, "_lerp_target");
		NativeFieldInfoPtr__lerp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, "_lerp");
		NativeFieldInfoPtr_Pagination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, "Pagination");
		NativeFieldInfoPtr_NextButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, "NextButton");
		NativeFieldInfoPtr_PrevButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, "PrevButton");
		NativeFieldInfoPtr_transitionSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, "transitionSpeed");
		NativeFieldInfoPtr_UseFastSwipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, "UseFastSwipe");
		NativeFieldInfoPtr_FastSwipeThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, "FastSwipeThreshold");
		NativeFieldInfoPtr__startDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, "_startDrag");
		NativeFieldInfoPtr__startPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, "_startPosition");
		NativeFieldInfoPtr__currentScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, "_currentScreen");
		NativeFieldInfoPtr_StartingScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, "StartingScreen");
		NativeFieldInfoPtr_PageStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, "PageStep");
		NativeFieldInfoPtr_fastSwipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, "fastSwipe");
		NativeMethodInfoPtr_get_CurrentPage_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, 100670841);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, 100670842);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, 100670843);
		NativeMethodInfoPtr_NextScreen_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, 100670844);
		NativeMethodInfoPtr_PreviousScreen_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, 100670845);
		NativeMethodInfoPtr_GoToScreen_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, 100670846);
		NativeMethodInfoPtr_NextScreenCommand_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, 100670847);
		NativeMethodInfoPtr_PrevScreenCommand_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, 100670848);
		NativeMethodInfoPtr_FindClosestFrom_Private_Vector3_Vector3_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, 100670849);
		NativeMethodInfoPtr_CurrentScreen_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, 100670850);
		NativeMethodInfoPtr_ChangeBulletsInfo_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, 100670851);
		NativeMethodInfoPtr_DistributePages_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, 100670852);
		NativeMethodInfoPtr_GetPageforPosition_Private_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, 100670853);
		NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, 100670854);
		NativeMethodInfoPtr_AddChild_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, 100670855);
		NativeMethodInfoPtr_RemoveChild_Public_Void_Int32_byref_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, 100670856);
		NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, 100670857);
		NativeMethodInfoPtr_OnEndDrag_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, 100670858);
		NativeMethodInfoPtr_OnDrag_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, 100670859);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, 100670860);
		NativeMethodInfoPtr__Start_b__22_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, 100670861);
		NativeMethodInfoPtr__Start_b__22_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalScrollSnap>.NativeClassPtr, 100670862);
	}

	public HorizontalScrollSnap(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
