using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class ScrollingCalendar : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_monthsScrollingPanel;

	private static readonly System.IntPtr NativeFieldInfoPtr_yearsScrollingPanel;

	private static readonly System.IntPtr NativeFieldInfoPtr_daysScrollingPanel;

	private static readonly System.IntPtr NativeFieldInfoPtr_yearsButtonPrefab;

	private static readonly System.IntPtr NativeFieldInfoPtr_monthsButtonPrefab;

	private static readonly System.IntPtr NativeFieldInfoPtr_daysButtonPrefab;

	private static readonly System.IntPtr NativeFieldInfoPtr_monthsButtons;

	private static readonly System.IntPtr NativeFieldInfoPtr_yearsButtons;

	private static readonly System.IntPtr NativeFieldInfoPtr_daysButtons;

	private static readonly System.IntPtr NativeFieldInfoPtr_monthCenter;

	private static readonly System.IntPtr NativeFieldInfoPtr_yearsCenter;

	private static readonly System.IntPtr NativeFieldInfoPtr_daysCenter;

	private static readonly System.IntPtr NativeFieldInfoPtr_yearsVerticalScroller;

	private static readonly System.IntPtr NativeFieldInfoPtr_monthsVerticalScroller;

	private static readonly System.IntPtr NativeFieldInfoPtr_daysVerticalScroller;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputFieldDays;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputFieldMonths;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputFieldYears;

	private static readonly System.IntPtr NativeFieldInfoPtr_dateText;

	private static readonly System.IntPtr NativeFieldInfoPtr_daysSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_monthsSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_yearsSet;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeYears_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeMonths_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeDays_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DaysScrollUp_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DaysScrollDown_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MonthsScrollUp_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MonthsScrollDown_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_YearsScrollUp_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_YearsScrollDown_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr));

	public unsafe RectTransform monthsScrollingPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthsScrollingPanel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RectTransform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthsScrollingPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RectTransform yearsScrollingPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yearsScrollingPanel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RectTransform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yearsScrollingPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RectTransform daysScrollingPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_daysScrollingPanel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RectTransform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_daysScrollingPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject yearsButtonPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yearsButtonPrefab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yearsButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject monthsButtonPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthsButtonPrefab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthsButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject daysButtonPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_daysButtonPrefab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_daysButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> monthsButtons
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthsButtons);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthsButtons), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> yearsButtons
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yearsButtons);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yearsButtons), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> daysButtons
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_daysButtons);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_daysButtons), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RectTransform monthCenter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthCenter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RectTransform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthCenter), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RectTransform yearsCenter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yearsCenter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RectTransform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yearsCenter), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RectTransform daysCenter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_daysCenter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RectTransform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_daysCenter), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe UIVerticalScroller yearsVerticalScroller
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yearsVerticalScroller);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new UIVerticalScroller(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yearsVerticalScroller), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe UIVerticalScroller monthsVerticalScroller
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthsVerticalScroller);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new UIVerticalScroller(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthsVerticalScroller), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe UIVerticalScroller daysVerticalScroller
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_daysVerticalScroller);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new UIVerticalScroller(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_daysVerticalScroller), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InputField inputFieldDays
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputFieldDays);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputField(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputFieldDays), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InputField inputFieldMonths
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputFieldMonths);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputField(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputFieldMonths), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InputField inputFieldYears
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputFieldYears);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputField(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputFieldYears), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text dateText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dateText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dateText), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int daysSet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_daysSet);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_daysSet)) = num;
		}
	}

	public unsafe int monthsSet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthsSet);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monthsSet)) = num;
		}
	}

	public unsafe int yearsSet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yearsSet);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yearsSet)) = num;
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117693, RefRangeEnd = 117694, XrefRangeStart = 117648, XrefRangeEnd = 117693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeYears()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeYears_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117763, RefRangeEnd = 117764, XrefRangeStart = 117694, XrefRangeEnd = 117763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeMonths()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeMonths_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117800, RefRangeEnd = 117801, XrefRangeStart = 117764, XrefRangeEnd = 117800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeDays()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeDays_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117801, XrefRangeEnd = 117818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117818, XrefRangeEnd = 117828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117828, XrefRangeEnd = 117888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117888, XrefRangeEnd = 117890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DaysScrollUp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DaysScrollUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117890, XrefRangeEnd = 117892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DaysScrollDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DaysScrollDown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117892, XrefRangeEnd = 117894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MonthsScrollUp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MonthsScrollUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117894, XrefRangeEnd = 117896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MonthsScrollDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MonthsScrollDown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117896, XrefRangeEnd = 117898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void YearsScrollUp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_YearsScrollUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117898, XrefRangeEnd = 117900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void YearsScrollDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_YearsScrollDown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe ScrollingCalendar()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ScrollingCalendar()
	{
		Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "ScrollingCalendar");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr);
		NativeFieldInfoPtr_monthsScrollingPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, "monthsScrollingPanel");
		NativeFieldInfoPtr_yearsScrollingPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, "yearsScrollingPanel");
		NativeFieldInfoPtr_daysScrollingPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, "daysScrollingPanel");
		NativeFieldInfoPtr_yearsButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, "yearsButtonPrefab");
		NativeFieldInfoPtr_monthsButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, "monthsButtonPrefab");
		NativeFieldInfoPtr_daysButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, "daysButtonPrefab");
		NativeFieldInfoPtr_monthsButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, "monthsButtons");
		NativeFieldInfoPtr_yearsButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, "yearsButtons");
		NativeFieldInfoPtr_daysButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, "daysButtons");
		NativeFieldInfoPtr_monthCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, "monthCenter");
		NativeFieldInfoPtr_yearsCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, "yearsCenter");
		NativeFieldInfoPtr_daysCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, "daysCenter");
		NativeFieldInfoPtr_yearsVerticalScroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, "yearsVerticalScroller");
		NativeFieldInfoPtr_monthsVerticalScroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, "monthsVerticalScroller");
		NativeFieldInfoPtr_daysVerticalScroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, "daysVerticalScroller");
		NativeFieldInfoPtr_inputFieldDays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, "inputFieldDays");
		NativeFieldInfoPtr_inputFieldMonths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, "inputFieldMonths");
		NativeFieldInfoPtr_inputFieldYears = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, "inputFieldYears");
		NativeFieldInfoPtr_dateText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, "dateText");
		NativeFieldInfoPtr_daysSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, "daysSet");
		NativeFieldInfoPtr_monthsSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, "monthsSet");
		NativeFieldInfoPtr_yearsSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, "yearsSet");
		NativeMethodInfoPtr_InitializeYears_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, 100670756);
		NativeMethodInfoPtr_InitializeMonths_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, 100670757);
		NativeMethodInfoPtr_InitializeDays_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, 100670758);
		NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, 100670759);
		NativeMethodInfoPtr_SetDate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, 100670760);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, 100670761);
		NativeMethodInfoPtr_DaysScrollUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, 100670762);
		NativeMethodInfoPtr_DaysScrollDown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, 100670763);
		NativeMethodInfoPtr_MonthsScrollUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, 100670764);
		NativeMethodInfoPtr_MonthsScrollDown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, 100670765);
		NativeMethodInfoPtr_YearsScrollUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, 100670766);
		NativeMethodInfoPtr_YearsScrollDown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, 100670767);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingCalendar>.NativeClassPtr, 100670768);
	}

	public ScrollingCalendar(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
