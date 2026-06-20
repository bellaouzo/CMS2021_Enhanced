using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.UI.Logic;

public class ScrollToSelected : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_scrollRectTransform;

	private static readonly System.IntPtr NativeFieldInfoPtr_contentPanel;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastSelected;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateScroll_Public_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__UpdateScroll_b__3_0_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__UpdateScroll_b__3_1_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__UpdateScroll_b__3_2_Private_Void_Single_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ScrollToSelected>.NativeClassPtr));

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

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 179680, RefRangeEnd = 179683, XrefRangeStart = 179587, XrefRangeEnd = 179680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateScroll(GameObject selectedGameObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectedGameObject);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateScroll_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe ScrollToSelected()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollToSelected>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179683, XrefRangeEnd = 179687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _UpdateScroll_b__3_0(float val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__UpdateScroll_b__3_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void _UpdateScroll_b__3_1(float val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__UpdateScroll_b__3_1_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void _UpdateScroll_b__3_2(float val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__UpdateScroll_b__3_2_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ScrollToSelected()
	{
		Il2CppClassPointerStore<ScrollToSelected>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic", "ScrollToSelected");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollToSelected>.NativeClassPtr);
		NativeFieldInfoPtr_scrollRectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollToSelected>.NativeClassPtr, "scrollRectTransform");
		NativeFieldInfoPtr_contentPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollToSelected>.NativeClassPtr, "contentPanel");
		NativeFieldInfoPtr_lastSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollToSelected>.NativeClassPtr, "lastSelected");
		NativeMethodInfoPtr_UpdateScroll_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollToSelected>.NativeClassPtr, 100676348);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollToSelected>.NativeClassPtr, 100676349);
		NativeMethodInfoPtr__UpdateScroll_b__3_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollToSelected>.NativeClassPtr, 100676350);
		NativeMethodInfoPtr__UpdateScroll_b__3_1_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollToSelected>.NativeClassPtr, 100676351);
		NativeMethodInfoPtr__UpdateScroll_b__3_2_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollToSelected>.NativeClassPtr, 100676352);
	}

	public ScrollToSelected(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
