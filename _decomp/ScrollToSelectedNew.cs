using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class ScrollToSelectedNew : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_navigationType;

	private static readonly System.IntPtr NativeFieldInfoPtr_scrollRectTransform;

	private static readonly System.IntPtr NativeFieldInfoPtr_contentPanel;

	private static readonly System.IntPtr NativeFieldInfoPtr_selectedRectTransform;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastSelected;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetSelected_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Update_b__7_0_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Update_b__7_1_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Update_b__7_2_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Update_b__7_3_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Update_b__7_4_Private_Void_Single_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ScrollToSelectedNew>.NativeClassPtr));

	public unsafe UIListNavigationType navigationType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_navigationType);
			return *(UIListNavigationType*)num;
		}
		set
		{
			*(UIListNavigationType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_navigationType)) = uIListNavigationType;
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

	public unsafe RectTransform contentPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contentPanel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RectTransform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contentPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RectTransform selectedRectTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedRectTransform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RectTransform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedRectTransform), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject lastSelected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastSelected);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastSelected), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	public unsafe void ResetSelected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetSelected_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82052, XrefRangeEnd = 82058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82058, XrefRangeEnd = 82219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe ScrollToSelectedNew()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollToSelectedNew>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82219, XrefRangeEnd = 82223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Update_b__7_0(float val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Update_b__7_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void _Update_b__7_1(float val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Update_b__7_1_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void _Update_b__7_2(float val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Update_b__7_2_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82223, XrefRangeEnd = 82227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Update_b__7_3(float val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Update_b__7_3_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void _Update_b__7_4(float val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Update_b__7_4_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ScrollToSelectedNew()
	{
		Il2CppClassPointerStore<ScrollToSelectedNew>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "ScrollToSelectedNew");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollToSelectedNew>.NativeClassPtr);
		NativeFieldInfoPtr_navigationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollToSelectedNew>.NativeClassPtr, "navigationType");
		NativeFieldInfoPtr_scrollRectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollToSelectedNew>.NativeClassPtr, "scrollRectTransform");
		NativeFieldInfoPtr_contentPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollToSelectedNew>.NativeClassPtr, "contentPanel");
		NativeFieldInfoPtr_selectedRectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollToSelectedNew>.NativeClassPtr, "selectedRectTransform");
		NativeFieldInfoPtr_lastSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollToSelectedNew>.NativeClassPtr, "lastSelected");
		NativeMethodInfoPtr_ResetSelected_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollToSelectedNew>.NativeClassPtr, 100668035);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollToSelectedNew>.NativeClassPtr, 100668036);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollToSelectedNew>.NativeClassPtr, 100668037);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollToSelectedNew>.NativeClassPtr, 100668038);
		NativeMethodInfoPtr__Update_b__7_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollToSelectedNew>.NativeClassPtr, 100668039);
		NativeMethodInfoPtr__Update_b__7_1_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollToSelectedNew>.NativeClassPtr, 100668040);
		NativeMethodInfoPtr__Update_b__7_2_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollToSelectedNew>.NativeClassPtr, 100668041);
		NativeMethodInfoPtr__Update_b__7_3_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollToSelectedNew>.NativeClassPtr, 100668042);
		NativeMethodInfoPtr__Update_b__7_4_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollToSelectedNew>.NativeClassPtr, 100668043);
	}

	public ScrollToSelectedNew(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
