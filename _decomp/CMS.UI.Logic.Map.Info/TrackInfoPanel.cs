using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine.UI;

namespace CMS.UI.Logic.Map.Info;

public class TrackInfoPanel : ThumbDescInfoPanel
{
	private static readonly System.IntPtr NativeFieldInfoPtr_length;

	private static readonly System.IntPtr NativeFieldInfoPtr_bestTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_title;

	private static readonly System.IntPtr NativeFieldInfoPtr_raceTrackLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_speedTrackLength;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLengthForRaceTrack_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLengthForSpeedTrack_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableLength_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableBestInfo_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEmptyBestInfo_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBestInfoTitle_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBestTime_Public_Void_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTopSpeed_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TrackInfoPanel>.NativeClassPtr));

	public unsafe Text length
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_length);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_length), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text bestTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bestTime);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bestTime), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text title
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_title);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_title), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int raceTrackLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_raceTrackLength);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_raceTrackLength)) = num;
		}
	}

	public unsafe int speedTrackLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedTrackLength);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedTrackLength)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197370, XrefRangeEnd = 197372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLengthForRaceTrack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLengthForRaceTrack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197372, XrefRangeEnd = 197374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLengthForSpeedTrack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLengthForSpeedTrack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197374, XrefRangeEnd = 197391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableLength(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableLength_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197391, XrefRangeEnd = 197408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableBestInfo(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableBestInfo_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197408, XrefRangeEnd = 197411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEmptyBestInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEmptyBestInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197411, XrefRangeEnd = 197417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBestInfoTitle(bool bestTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bestTime);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBestInfoTitle_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197417, XrefRangeEnd = 197445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBestTime(long time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBestTime_Public_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197445, XrefRangeEnd = 197447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTopSpeed(int speed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&speed);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTopSpeed_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe TrackInfoPanel()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackInfoPanel>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static TrackInfoPanel()
	{
		Il2CppClassPointerStore<TrackInfoPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Map.Info", "TrackInfoPanel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackInfoPanel>.NativeClassPtr);
		NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackInfoPanel>.NativeClassPtr, "length");
		NativeFieldInfoPtr_bestTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackInfoPanel>.NativeClassPtr, "bestTime");
		NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackInfoPanel>.NativeClassPtr, "title");
		NativeFieldInfoPtr_raceTrackLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackInfoPanel>.NativeClassPtr, "raceTrackLength");
		NativeFieldInfoPtr_speedTrackLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackInfoPanel>.NativeClassPtr, "speedTrackLength");
		NativeMethodInfoPtr_SetLengthForRaceTrack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackInfoPanel>.NativeClassPtr, 100678079);
		NativeMethodInfoPtr_SetLengthForSpeedTrack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackInfoPanel>.NativeClassPtr, 100678080);
		NativeMethodInfoPtr_EnableLength_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackInfoPanel>.NativeClassPtr, 100678081);
		NativeMethodInfoPtr_EnableBestInfo_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackInfoPanel>.NativeClassPtr, 100678082);
		NativeMethodInfoPtr_SetEmptyBestInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackInfoPanel>.NativeClassPtr, 100678083);
		NativeMethodInfoPtr_SetBestInfoTitle_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackInfoPanel>.NativeClassPtr, 100678084);
		NativeMethodInfoPtr_SetBestTime_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackInfoPanel>.NativeClassPtr, 100678085);
		NativeMethodInfoPtr_SetTopSpeed_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackInfoPanel>.NativeClassPtr, 100678086);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackInfoPanel>.NativeClassPtr, 100678087);
	}

	public TrackInfoPanel(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
