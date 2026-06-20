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

public class DragOpponentResultsPanel : DragResultsPanel
{
	private static readonly System.IntPtr NativeFieldInfoPtr_feets60Waiting;

	private static readonly System.IntPtr NativeFieldInfoPtr_feets330Waiting;

	private static readonly System.IntPtr NativeFieldInfoPtr_eightMileWaiting;

	private static readonly System.IntPtr NativeFieldInfoPtr_feets1000Waiting;

	private static readonly System.IntPtr NativeFieldInfoPtr_quarterMileWaiting;

	private static readonly System.IntPtr NativeFieldInfoPtr_halfMileWaiting;

	private static readonly System.IntPtr NativeFieldInfoPtr_oneMileWaiting;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstSpeedWaiting;

	private static readonly System.IntPtr NativeFieldInfoPtr_secondSpeedWaiting;

	private static readonly System.IntPtr NativeFieldInfoPtr_thirdSpeedWaiting;

	private static readonly System.IntPtr NativeFieldInfoPtr_forthSpeedWaiting;

	private static readonly System.IntPtr NativeFieldInfoPtr_dnfText;

	private static readonly System.IntPtr NativeFieldInfoPtr_have60FeetsTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_have330FeetsTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_haveEightMileTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_have1000FeetsTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_haveQuarterMileTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_haveHalfMileTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_haveOneMileTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_haveZero50Time;

	private static readonly System.IntPtr NativeFieldInfoPtr_haveZero100Time;

	private static readonly System.IntPtr NativeFieldInfoPtr_haveZero150Time;

	private static readonly System.IntPtr NativeFieldInfoPtr_haveZero200Time;

	private static readonly System.IntPtr NativeFieldInfoPtr_zero100Time;

	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Public_Single_String_Int32_List_1_DragTime_Single_DragLength_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillTimes_Private_Single_List_1_DragTime_DragLength_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTime_Private_String_DragTime_Boolean_byref_Utf8ValueStringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateOpponentTime_Public_Void_DragTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrefillTimes_Private_Void_DragLength_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopWaitingForTimes_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupSpeeds_Public_Void_List_1_DragSpeed_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillSpeeds_Private_Void_List_1_DragSpeed_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSpeed_Public_Void_DragSpeed_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopWaitingForSpeeds_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrefillSpeedsWaiting_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDNFText_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWaiting_Private_Void_Text_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr));

	public unsafe GameObject feets60Waiting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_feets60Waiting);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_feets60Waiting), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject feets330Waiting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_feets330Waiting);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_feets330Waiting), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject eightMileWaiting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eightMileWaiting);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eightMileWaiting), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject feets1000Waiting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_feets1000Waiting);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_feets1000Waiting), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject quarterMileWaiting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quarterMileWaiting);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quarterMileWaiting), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject halfMileWaiting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_halfMileWaiting);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_halfMileWaiting), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject oneMileWaiting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oneMileWaiting);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oneMileWaiting), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject firstSpeedWaiting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstSpeedWaiting);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstSpeedWaiting), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject secondSpeedWaiting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondSpeedWaiting);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondSpeedWaiting), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject thirdSpeedWaiting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thirdSpeedWaiting);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thirdSpeedWaiting), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject forthSpeedWaiting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forthSpeedWaiting);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forthSpeedWaiting), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text dnfText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dnfText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dnfText), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool have60FeetsTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_have60FeetsTime);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_have60FeetsTime)) = flag;
		}
	}

	public unsafe bool have330FeetsTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_have330FeetsTime);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_have330FeetsTime)) = flag;
		}
	}

	public unsafe bool haveEightMileTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_haveEightMileTime);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_haveEightMileTime)) = flag;
		}
	}

	public unsafe bool have1000FeetsTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_have1000FeetsTime);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_have1000FeetsTime)) = flag;
		}
	}

	public unsafe bool haveQuarterMileTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_haveQuarterMileTime);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_haveQuarterMileTime)) = flag;
		}
	}

	public unsafe bool haveHalfMileTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_haveHalfMileTime);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_haveHalfMileTime)) = flag;
		}
	}

	public unsafe bool haveOneMileTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_haveOneMileTime);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_haveOneMileTime)) = flag;
		}
	}

	public unsafe bool haveZero50Time
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_haveZero50Time);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_haveZero50Time)) = flag;
		}
	}

	public unsafe bool haveZero100Time
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_haveZero100Time);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_haveZero100Time)) = flag;
		}
	}

	public unsafe bool haveZero150Time
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_haveZero150Time);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_haveZero150Time)) = flag;
		}
	}

	public unsafe bool haveZero200Time
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_haveZero200Time);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_haveZero200Time)) = flag;
		}
	}

	public unsafe long zero100Time
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zero100Time);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zero100Time)) = num;
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 199543, RefRangeEnd = 199544, XrefRangeStart = 199520, XrefRangeEnd = 199543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float Setup(string carID, int config, List<DragTime> stats, float dragIndex, DragLength length)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &config;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(stats);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &dragIndex;
		*(DragLength**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Single_String_Int32_List_1_DragTime_Single_DragLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 199564, RefRangeEnd = 199565, XrefRangeStart = 199544, XrefRangeEnd = 199564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float FillTimes(List<DragTime> stats, DragLength length)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(stats);
		*(DragLength**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillTimes_Private_Single_List_1_DragTime_DragLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 199569, RefRangeEnd = 199573, XrefRangeStart = 199565, XrefRangeEnd = 199569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string UpdateTime(DragTime dragTime, bool getTimeAsString, ref Utf8ValueStringBuilder sb)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&dragTime);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &getTimeAsString;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sb);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateTime_Private_String_DragTime_Boolean_byref_Utf8ValueStringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199573, XrefRangeEnd = 199579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateOpponentTime(DragTime dragTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dragTime);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateOpponentTime_Public_Void_DragTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 199591, RefRangeEnd = 199592, XrefRangeStart = 199579, XrefRangeEnd = 199591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrefillTimes(DragLength length)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&length);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrefillTimes_Private_Void_DragLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199592, XrefRangeEnd = 199599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopWaitingForTimes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopWaitingForTimes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199599, XrefRangeEnd = 199601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupSpeeds(List<DragSpeed> speeds, bool opponentFinished)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(speeds);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &opponentFinished;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupSpeeds_Public_Void_List_1_DragSpeed_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 199642, RefRangeEnd = 199644, XrefRangeStart = 199601, XrefRangeEnd = 199642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FillSpeeds(List<DragSpeed> speeds, bool finished)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(speeds);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &finished;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillSpeeds_Private_Void_List_1_DragSpeed_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 199660, RefRangeEnd = 199661, XrefRangeStart = 199644, XrefRangeEnd = 199660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSpeed(DragSpeed dragSpeed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dragSpeed);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateSpeed_Public_Void_DragSpeed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 199665, RefRangeEnd = 199667, XrefRangeStart = 199661, XrefRangeEnd = 199665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopWaitingForSpeeds()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopWaitingForSpeeds_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199667, XrefRangeEnd = 199671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrefillSpeedsWaiting()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrefillSpeedsWaiting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199671, XrefRangeEnd = 199672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDNFText(string text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDNFText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(45)]
	[CachedScanResults(RefRangeStart = 199682, RefRangeEnd = 199727, XrefRangeStart = 199672, XrefRangeEnd = 199682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetWaiting(Text text, GameObject waiting, bool set)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(waiting);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &set;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWaiting_Private_Void_Text_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe DragOpponentResultsPanel()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DragOpponentResultsPanel()
	{
		Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Drag", "DragOpponentResultsPanel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr);
		NativeFieldInfoPtr_feets60Waiting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, "feets60Waiting");
		NativeFieldInfoPtr_feets330Waiting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, "feets330Waiting");
		NativeFieldInfoPtr_eightMileWaiting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, "eightMileWaiting");
		NativeFieldInfoPtr_feets1000Waiting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, "feets1000Waiting");
		NativeFieldInfoPtr_quarterMileWaiting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, "quarterMileWaiting");
		NativeFieldInfoPtr_halfMileWaiting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, "halfMileWaiting");
		NativeFieldInfoPtr_oneMileWaiting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, "oneMileWaiting");
		NativeFieldInfoPtr_firstSpeedWaiting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, "firstSpeedWaiting");
		NativeFieldInfoPtr_secondSpeedWaiting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, "secondSpeedWaiting");
		NativeFieldInfoPtr_thirdSpeedWaiting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, "thirdSpeedWaiting");
		NativeFieldInfoPtr_forthSpeedWaiting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, "forthSpeedWaiting");
		NativeFieldInfoPtr_dnfText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, "dnfText");
		NativeFieldInfoPtr_have60FeetsTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, "have60FeetsTime");
		NativeFieldInfoPtr_have330FeetsTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, "have330FeetsTime");
		NativeFieldInfoPtr_haveEightMileTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, "haveEightMileTime");
		NativeFieldInfoPtr_have1000FeetsTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, "have1000FeetsTime");
		NativeFieldInfoPtr_haveQuarterMileTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, "haveQuarterMileTime");
		NativeFieldInfoPtr_haveHalfMileTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, "haveHalfMileTime");
		NativeFieldInfoPtr_haveOneMileTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, "haveOneMileTime");
		NativeFieldInfoPtr_haveZero50Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, "haveZero50Time");
		NativeFieldInfoPtr_haveZero100Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, "haveZero100Time");
		NativeFieldInfoPtr_haveZero150Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, "haveZero150Time");
		NativeFieldInfoPtr_haveZero200Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, "haveZero200Time");
		NativeFieldInfoPtr_zero100Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, "zero100Time");
		NativeMethodInfoPtr_Setup_Public_Single_String_Int32_List_1_DragTime_Single_DragLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, 100678314);
		NativeMethodInfoPtr_FillTimes_Private_Single_List_1_DragTime_DragLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, 100678315);
		NativeMethodInfoPtr_UpdateTime_Private_String_DragTime_Boolean_byref_Utf8ValueStringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, 100678316);
		NativeMethodInfoPtr_UpdateOpponentTime_Public_Void_DragTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, 100678317);
		NativeMethodInfoPtr_PrefillTimes_Private_Void_DragLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, 100678318);
		NativeMethodInfoPtr_StopWaitingForTimes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, 100678319);
		NativeMethodInfoPtr_SetupSpeeds_Public_Void_List_1_DragSpeed_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, 100678320);
		NativeMethodInfoPtr_FillSpeeds_Private_Void_List_1_DragSpeed_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, 100678321);
		NativeMethodInfoPtr_UpdateSpeed_Public_Void_DragSpeed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, 100678322);
		NativeMethodInfoPtr_StopWaitingForSpeeds_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, 100678323);
		NativeMethodInfoPtr_PrefillSpeedsWaiting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, 100678324);
		NativeMethodInfoPtr_SetDNFText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, 100678325);
		NativeMethodInfoPtr_SetWaiting_Private_Void_Text_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, 100678326);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragOpponentResultsPanel>.NativeClassPtr, 100678327);
	}

	public DragOpponentResultsPanel(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
