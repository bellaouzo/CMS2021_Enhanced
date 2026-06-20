using System;
using System.Runtime.CompilerServices;
using CMS.Containers;
using Cysharp.Text;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace CMS.UI.Logic.Drag;

public class DragResultsPanel : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_carBrand;

	private static readonly System.IntPtr NativeFieldInfoPtr_carName;

	private static readonly System.IntPtr NativeFieldInfoPtr_carPreview;

	private static readonly System.IntPtr NativeFieldInfoPtr_dragIndexDisplay;

	private static readonly System.IntPtr NativeFieldInfoPtr_carRibbon;

	private static readonly System.IntPtr NativeFieldInfoPtr_winner;

	private static readonly System.IntPtr NativeFieldInfoPtr_dnf;

	private static readonly System.IntPtr NativeFieldInfoPtr_reactionTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_feets60;

	private static readonly System.IntPtr NativeFieldInfoPtr_feets330;

	private static readonly System.IntPtr NativeFieldInfoPtr_eightMile;

	private static readonly System.IntPtr NativeFieldInfoPtr_feets1000;

	private static readonly System.IntPtr NativeFieldInfoPtr_quarterMile;

	private static readonly System.IntPtr NativeFieldInfoPtr_halfMile;

	private static readonly System.IntPtr NativeFieldInfoPtr_oneMile;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstTitle;

	private static readonly System.IntPtr NativeFieldInfoPtr_secondTitle;

	private static readonly System.IntPtr NativeFieldInfoPtr_thirdTitle;

	private static readonly System.IntPtr NativeFieldInfoPtr_forthTitle;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_secondSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_thirdSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_forthSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_page1;

	private static readonly System.IntPtr NativeFieldInfoPtr_page2;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatTimeString_Protected_String_byref_Utf8ValueStringBuilder_TimeSpan_Boolean_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrefillTimes_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFirstPage_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetNextPage_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInfoWinner_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInfoDNF_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInfoNone_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrefillSpeeds_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupSpeedTitles_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDragSpeed_Protected_Nullable_1_DragSpeed_List_1_DragSpeed_DragSpeedType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetElapsedFromDragSpeed_Protected_Int64_Nullable_1_DragSpeed_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatSpeedString_Protected_String_byref_Utf8ValueStringBuilder_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr));

	public unsafe Image carBrand
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carBrand);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carBrand), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text carName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carName);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carName), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image carPreview
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carPreview);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carPreview), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DragIndexDisplay dragIndexDisplay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dragIndexDisplay);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DragIndexDisplay(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dragIndexDisplay), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CarRibbon carRibbon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carRibbon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CarRibbon(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carRibbon), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject winner
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_winner);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_winner), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject dnf
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dnf);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dnf), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text reactionTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactionTime);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactionTime), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text feets60
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_feets60);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_feets60), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text feets330
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_feets330);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_feets330), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text eightMile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eightMile);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eightMile), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text feets1000
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_feets1000);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_feets1000), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text quarterMile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quarterMile);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quarterMile), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text halfMile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_halfMile);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_halfMile), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text oneMile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oneMile);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oneMile), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text firstTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstTitle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstTitle), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text secondTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondTitle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondTitle), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text thirdTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thirdTitle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thirdTitle), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text forthTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forthTitle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forthTitle), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text firstSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstSpeed);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstSpeed), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text secondSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondSpeed);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondSpeed), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text thirdSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thirdSpeed);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thirdSpeed), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text forthSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forthSpeed);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forthSpeed), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject page1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_page1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_page1), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject page2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_page2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_page2), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 199843, RefRangeEnd = 199847, XrefRangeStart = 199818, XrefRangeEnd = 199843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string FormatTimeString(ref Utf8ValueStringBuilder sb, Il2CppSystem.TimeSpan time, bool withSpeed, float speed, bool addSuffix = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sb);
		*(Il2CppSystem.TimeSpan**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &withSpeed;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &speed;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &addSuffix;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatTimeString_Protected_String_byref_Utf8ValueStringBuilder_TimeSpan_Boolean_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 199857, RefRangeEnd = 199858, XrefRangeStart = 199847, XrefRangeEnd = 199857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrefillTimes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrefillTimes_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 199867, RefRangeEnd = 199875, XrefRangeStart = 199858, XrefRangeEnd = 199867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFirstPage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFirstPage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 199884, RefRangeEnd = 199886, XrefRangeStart = 199875, XrefRangeEnd = 199884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetNextPage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetNextPage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 199895, RefRangeEnd = 199897, XrefRangeStart = 199886, XrefRangeEnd = 199895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInfoWinner()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInfoWinner_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199897, XrefRangeEnd = 199906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInfoDNF()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInfoDNF_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 199915, RefRangeEnd = 199918, XrefRangeStart = 199906, XrefRangeEnd = 199915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInfoNone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInfoNone_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 199924, RefRangeEnd = 199925, XrefRangeStart = 199918, XrefRangeEnd = 199924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrefillSpeeds()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrefillSpeeds_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 199951, RefRangeEnd = 199957, XrefRangeStart = 199925, XrefRangeEnd = 199951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupSpeedTitles()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupSpeedTitles_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199957, XrefRangeEnd = 199961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Nullable<DragSpeed> GetDragSpeed(List<DragSpeed> speeds, DragSpeedType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(speeds);
		*(DragSpeedType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDragSpeed_Protected_Nullable_1_DragSpeed_List_1_DragSpeed_DragSpeedType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return new Il2CppSystem.Nullable<DragSpeed>(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199961, XrefRangeEnd = 199963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe long GetElapsedFromDragSpeed(Il2CppSystem.Nullable<DragSpeed> dragSpeed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dragSpeed));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetElapsedFromDragSpeed_Protected_Int64_Nullable_1_DragSpeed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(long*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 199983, RefRangeEnd = 199990, XrefRangeStart = 199963, XrefRangeEnd = 199983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string FormatSpeedString(ref Utf8ValueStringBuilder sb, Il2CppSystem.TimeSpan time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sb);
		*(Il2CppSystem.TimeSpan**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatSpeedString_Protected_String_byref_Utf8ValueStringBuilder_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe DragResultsPanel()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DragResultsPanel()
	{
		Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Drag", "DragResultsPanel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr);
		NativeFieldInfoPtr_carBrand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, "carBrand");
		NativeFieldInfoPtr_carName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, "carName");
		NativeFieldInfoPtr_carPreview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, "carPreview");
		NativeFieldInfoPtr_dragIndexDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, "dragIndexDisplay");
		NativeFieldInfoPtr_carRibbon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, "carRibbon");
		NativeFieldInfoPtr_winner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, "winner");
		NativeFieldInfoPtr_dnf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, "dnf");
		NativeFieldInfoPtr_reactionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, "reactionTime");
		NativeFieldInfoPtr_feets60 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, "feets60");
		NativeFieldInfoPtr_feets330 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, "feets330");
		NativeFieldInfoPtr_eightMile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, "eightMile");
		NativeFieldInfoPtr_feets1000 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, "feets1000");
		NativeFieldInfoPtr_quarterMile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, "quarterMile");
		NativeFieldInfoPtr_halfMile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, "halfMile");
		NativeFieldInfoPtr_oneMile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, "oneMile");
		NativeFieldInfoPtr_firstTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, "firstTitle");
		NativeFieldInfoPtr_secondTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, "secondTitle");
		NativeFieldInfoPtr_thirdTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, "thirdTitle");
		NativeFieldInfoPtr_forthTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, "forthTitle");
		NativeFieldInfoPtr_firstSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, "firstSpeed");
		NativeFieldInfoPtr_secondSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, "secondSpeed");
		NativeFieldInfoPtr_thirdSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, "thirdSpeed");
		NativeFieldInfoPtr_forthSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, "forthSpeed");
		NativeFieldInfoPtr_page1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, "page1");
		NativeFieldInfoPtr_page2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, "page2");
		NativeMethodInfoPtr_FormatTimeString_Protected_String_byref_Utf8ValueStringBuilder_TimeSpan_Boolean_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, 100678333);
		NativeMethodInfoPtr_PrefillTimes_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, 100678334);
		NativeMethodInfoPtr_SetFirstPage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, 100678335);
		NativeMethodInfoPtr_SetNextPage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, 100678336);
		NativeMethodInfoPtr_SetInfoWinner_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, 100678337);
		NativeMethodInfoPtr_SetInfoDNF_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, 100678338);
		NativeMethodInfoPtr_SetInfoNone_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, 100678339);
		NativeMethodInfoPtr_PrefillSpeeds_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, 100678340);
		NativeMethodInfoPtr_SetupSpeedTitles_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, 100678341);
		NativeMethodInfoPtr_GetDragSpeed_Protected_Nullable_1_DragSpeed_List_1_DragSpeed_DragSpeedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, 100678342);
		NativeMethodInfoPtr_GetElapsedFromDragSpeed_Protected_Int64_Nullable_1_DragSpeed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, 100678343);
		NativeMethodInfoPtr_FormatSpeedString_Protected_String_byref_Utf8ValueStringBuilder_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, 100678344);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragResultsPanel>.NativeClassPtr, 100678345);
	}

	public DragResultsPanel(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
