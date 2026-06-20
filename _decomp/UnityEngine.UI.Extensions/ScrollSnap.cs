using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnhollowerRuntimeLib;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions;

public class ScrollSnap : MonoBehaviour
{
	public enum ScrollDirection
	{
		Horizontal,
		Vertical,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ScrollDirection>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static ScrollDirection()
		{
			Il2CppClassPointerStore<ScrollDirection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "ScrollDirection");
		}

	}

	public sealed class PageSnapChange : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PageSnapChange>.NativeClassPtr));

		[CallerCount(70)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe PageSnapChange(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PageSnapChange>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(135)]
		[CachedScanResults(RefRangeStart = 119189, RefRangeEnd = 119324, XrefRangeStart = 119186, XrefRangeEnd = 119189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(int page)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&page);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119324, XrefRangeEnd = 119328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppSystem.IAsyncResult BeginInvoke(int page, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&page);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(@object);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.IAsyncResult(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static PageSnapChange()
		{
			Il2CppClassPointerStore<PageSnapChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "PageSnapChange");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageSnapChange>.NativeClassPtr, 100670892);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageSnapChange>.NativeClassPtr, 100670893);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageSnapChange>.NativeClassPtr, 100670894);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageSnapChange>.NativeClassPtr, 100670895);
		}

		public PageSnapChange(System.IntPtr P_0)
			: base(P_0)
		{
		}

		public static implicit operator PageSnapChange(System.Action<int> P_0)
		{
			return DelegateSupport.ConvertDelegate<PageSnapChange>(P_0);
		}

		public static PageSnapChange operator +(PageSnapChange P_0, PageSnapChange P_1)
		{
			return Il2CppSystem.Delegate.Combine(P_0, P_1).Cast<PageSnapChange>();
		}

		public static PageSnapChange operator -(PageSnapChange P_0, PageSnapChange P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<PageSnapChange>();
			}
			return (PageSnapChange)obj;
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_onPageChange;

	private static readonly System.IntPtr NativeFieldInfoPtr_direction;

	private static readonly System.IntPtr NativeFieldInfoPtr_scrollRect;

	private static readonly System.IntPtr NativeFieldInfoPtr_scrollRectTransform;

	private static readonly System.IntPtr NativeFieldInfoPtr_listContainerTransform;

	private static readonly System.IntPtr NativeFieldInfoPtr_rectTransform;

	private static readonly System.IntPtr NativeFieldInfoPtr_pages;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingPage;

	private static readonly System.IntPtr NativeFieldInfoPtr_pageAnchorPositions;

	private static readonly System.IntPtr NativeFieldInfoPtr_lerpTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_lerp;

	private static readonly System.IntPtr NativeFieldInfoPtr_listContainerMinPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_listContainerMaxPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_listContainerSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_listContainerRectTransform;

	private static readonly System.IntPtr NativeFieldInfoPtr_listContainerCachedSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemsCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_nextButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_prevButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemsVisibleAtOnce;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoLayoutItems;

	private static readonly System.IntPtr NativeFieldInfoPtr_linkScrolbarSteps;

	private static readonly System.IntPtr NativeFieldInfoPtr_linkScrolrectScrollSensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_useFastSwipe;

	private static readonly System.IntPtr NativeFieldInfoPtr_fastSwipeThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_startDrag;

	private static readonly System.IntPtr NativeFieldInfoPtr_positionOnDragStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_pageOnDragStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_fastSwipeTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_fastSwipeCounter;

	private static readonly System.IntPtr NativeFieldInfoPtr_fastSwipeTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_fastSwipe;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onPageChange_Public_add_Void_PageSnapChange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onPageChange_Public_rem_Void_PageSnapChange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateListItemsSize_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateListItemPositions_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetPage_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateScrollbar_Protected_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NextScreen_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreviousScreen_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NextScreenCommand_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrevScreenCommand_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CurrentPage_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangePage_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PageChanged_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_Final_New_Void_PointerEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEndDrag_Public_Virtual_Final_New_Void_PointerEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDrag_Public_Virtual_Final_New_Void_PointerEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__36_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__36_1_Private_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr));

	public unsafe PageSnapChange onPageChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onPageChange);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PageSnapChange(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onPageChange), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ScrollDirection direction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_direction);
			return *(ScrollDirection*)num;
		}
		set
		{
			*(ScrollDirection*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_direction)) = scrollDirection;
		}
	}

	public unsafe ScrollRect scrollRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scrollRect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ScrollRect(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scrollRect), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RectTransform scrollRectTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scrollRectTransform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RectTransform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scrollRectTransform), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform listContainerTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listContainerTransform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listContainerTransform), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RectTransform rectTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rectTransform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RectTransform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rectTransform), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int pages
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pages);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pages)) = num;
		}
	}

	public unsafe int startingPage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingPage);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingPage)) = num;
		}
	}

	public unsafe Il2CppStructArray<Vector3> pageAnchorPositions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pageAnchorPositions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Vector3>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pageAnchorPositions), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector3 lerpTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lerpTarget);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lerpTarget)) = vector;
		}
	}

	public unsafe bool lerp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lerp);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lerp)) = flag;
		}
	}

	public unsafe float listContainerMinPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listContainerMinPosition);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listContainerMinPosition)) = num;
		}
	}

	public unsafe float listContainerMaxPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listContainerMaxPosition);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listContainerMaxPosition)) = num;
		}
	}

	public unsafe float listContainerSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listContainerSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listContainerSize)) = num;
		}
	}

	public unsafe RectTransform listContainerRectTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listContainerRectTransform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RectTransform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listContainerRectTransform), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector2 listContainerCachedSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listContainerCachedSize);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listContainerCachedSize)) = vector;
		}
	}

	public unsafe float itemSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemSize)) = num;
		}
	}

	public unsafe int itemsCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemsCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemsCount)) = num;
		}
	}

	public unsafe Button nextButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextButton);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Button(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextButton), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Button prevButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prevButton);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Button(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prevButton), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int itemsVisibleAtOnce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemsVisibleAtOnce);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemsVisibleAtOnce)) = num;
		}
	}

	public unsafe bool autoLayoutItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoLayoutItems);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoLayoutItems)) = flag;
		}
	}

	public unsafe bool linkScrolbarSteps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linkScrolbarSteps);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linkScrolbarSteps)) = flag;
		}
	}

	public unsafe bool linkScrolrectScrollSensitivity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linkScrolrectScrollSensitivity);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linkScrolrectScrollSensitivity)) = flag;
		}
	}

	public unsafe bool useFastSwipe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useFastSwipe);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useFastSwipe)) = flag;
		}
	}

	public unsafe int fastSwipeThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastSwipeThreshold);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastSwipeThreshold)) = num;
		}
	}

	public unsafe bool startDrag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startDrag);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startDrag)) = flag;
		}
	}

	public unsafe Vector3 positionOnDragStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionOnDragStart);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionOnDragStart)) = vector;
		}
	}

	public unsafe int pageOnDragStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pageOnDragStart);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pageOnDragStart)) = num;
		}
	}

	public unsafe bool fastSwipeTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastSwipeTimer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastSwipeTimer)) = flag;
		}
	}

	public unsafe int fastSwipeCounter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastSwipeCounter);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastSwipeCounter)) = num;
		}
	}

	public unsafe int fastSwipeTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastSwipeTarget);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastSwipeTarget)) = num;
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

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119328, XrefRangeEnd = 119331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_onPageChange(PageSnapChange value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onPageChange_Public_add_Void_PageSnapChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119331, XrefRangeEnd = 119334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_onPageChange(PageSnapChange value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onPageChange_Public_rem_Void_PageSnapChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 119378, RefRangeEnd = 119379, XrefRangeStart = 119334, XrefRangeEnd = 119378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119379, XrefRangeEnd = 119380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 119461, RefRangeEnd = 119463, XrefRangeStart = 119380, XrefRangeEnd = 119461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateListItemsSize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateListItemsSize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 119515, RefRangeEnd = 119521, XrefRangeStart = 119463, XrefRangeEnd = 119515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateListItemPositions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateListItemPositions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119521, XrefRangeEnd = 119524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetPage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetPage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 119561, RefRangeEnd = 119566, XrefRangeStart = 119524, XrefRangeEnd = 119561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateScrollbar(bool linkSteps)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&linkSteps);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateScrollbar_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119566, XrefRangeEnd = 119587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119587, XrefRangeEnd = 119592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NextScreen()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextScreen_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119592, XrefRangeEnd = 119597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreviousScreen()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreviousScreen_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119597, XrefRangeEnd = 119598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NextScreenCommand()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextScreenCommand_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119598, XrefRangeEnd = 119599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrevScreenCommand()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrevScreenCommand_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 119609, RefRangeEnd = 119627, XrefRangeStart = 119599, XrefRangeEnd = 119609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int CurrentPage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CurrentPage_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119627, XrefRangeEnd = 119628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangePage(int page)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&page);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangePage_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 119638, RefRangeEnd = 119649, XrefRangeStart = 119628, XrefRangeEnd = 119638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PageChanged(int currentPage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&currentPage);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PageChanged_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119649, XrefRangeEnd = 119651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119651, XrefRangeEnd = 119660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119660, XrefRangeEnd = 119662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119662, XrefRangeEnd = 119665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScrollSnap()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void _Awake_b__36_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Awake_b__36_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void _Awake_b__36_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Awake_b__36_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ScrollSnap()
	{
		Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "UnityEngine.UI.Extensions", "ScrollSnap");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr);
		NativeFieldInfoPtr_onPageChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "onPageChange");
		NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "direction");
		NativeFieldInfoPtr_scrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "scrollRect");
		NativeFieldInfoPtr_scrollRectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "scrollRectTransform");
		NativeFieldInfoPtr_listContainerTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "listContainerTransform");
		NativeFieldInfoPtr_rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "rectTransform");
		NativeFieldInfoPtr_pages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "pages");
		NativeFieldInfoPtr_startingPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "startingPage");
		NativeFieldInfoPtr_pageAnchorPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "pageAnchorPositions");
		NativeFieldInfoPtr_lerpTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "lerpTarget");
		NativeFieldInfoPtr_lerp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "lerp");
		NativeFieldInfoPtr_listContainerMinPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "listContainerMinPosition");
		NativeFieldInfoPtr_listContainerMaxPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "listContainerMaxPosition");
		NativeFieldInfoPtr_listContainerSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "listContainerSize");
		NativeFieldInfoPtr_listContainerRectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "listContainerRectTransform");
		NativeFieldInfoPtr_listContainerCachedSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "listContainerCachedSize");
		NativeFieldInfoPtr_itemSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "itemSize");
		NativeFieldInfoPtr_itemsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "itemsCount");
		NativeFieldInfoPtr_nextButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "nextButton");
		NativeFieldInfoPtr_prevButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "prevButton");
		NativeFieldInfoPtr_itemsVisibleAtOnce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "itemsVisibleAtOnce");
		NativeFieldInfoPtr_autoLayoutItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "autoLayoutItems");
		NativeFieldInfoPtr_linkScrolbarSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "linkScrolbarSteps");
		NativeFieldInfoPtr_linkScrolrectScrollSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "linkScrolrectScrollSensitivity");
		NativeFieldInfoPtr_useFastSwipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "useFastSwipe");
		NativeFieldInfoPtr_fastSwipeThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "fastSwipeThreshold");
		NativeFieldInfoPtr_startDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "startDrag");
		NativeFieldInfoPtr_positionOnDragStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "positionOnDragStart");
		NativeFieldInfoPtr_pageOnDragStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "pageOnDragStart");
		NativeFieldInfoPtr_fastSwipeTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "fastSwipeTimer");
		NativeFieldInfoPtr_fastSwipeCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "fastSwipeCounter");
		NativeFieldInfoPtr_fastSwipeTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "fastSwipeTarget");
		NativeFieldInfoPtr_fastSwipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, "fastSwipe");
		NativeMethodInfoPtr_add_onPageChange_Public_add_Void_PageSnapChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, 100670870);
		NativeMethodInfoPtr_remove_onPageChange_Public_rem_Void_PageSnapChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, 100670871);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, 100670872);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, 100670873);
		NativeMethodInfoPtr_UpdateListItemsSize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, 100670874);
		NativeMethodInfoPtr_UpdateListItemPositions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, 100670875);
		NativeMethodInfoPtr_ResetPage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, 100670876);
		NativeMethodInfoPtr_UpdateScrollbar_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, 100670877);
		NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, 100670878);
		NativeMethodInfoPtr_NextScreen_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, 100670879);
		NativeMethodInfoPtr_PreviousScreen_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, 100670880);
		NativeMethodInfoPtr_NextScreenCommand_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, 100670881);
		NativeMethodInfoPtr_PrevScreenCommand_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, 100670882);
		NativeMethodInfoPtr_CurrentPage_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, 100670883);
		NativeMethodInfoPtr_ChangePage_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, 100670884);
		NativeMethodInfoPtr_PageChanged_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, 100670885);
		NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, 100670886);
		NativeMethodInfoPtr_OnEndDrag_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, 100670887);
		NativeMethodInfoPtr_OnDrag_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, 100670888);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, 100670889);
		NativeMethodInfoPtr__Awake_b__36_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, 100670890);
		NativeMethodInfoPtr__Awake_b__36_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollSnap>.NativeClassPtr, 100670891);
	}

	public ScrollSnap(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
