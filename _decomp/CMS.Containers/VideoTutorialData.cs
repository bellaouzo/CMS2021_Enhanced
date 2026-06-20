using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Containers;

[StructLayout(LayoutKind.Sequential)]
public sealed class VideoTutorialData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_subtitles;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSubtitle_Public_Void_Double_Double_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSubtitleForTime_Public_Boolean_Double_byref_String_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VideoTutorialData>.NativeClassPtr));

	public unsafe List<TutorialSubtitle> subtitles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subtitles);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<TutorialSubtitle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subtitles), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 218452, RefRangeEnd = 218454, XrefRangeStart = 218438, XrefRangeEnd = 218452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddSubtitle(double from, double to, string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&from);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(key);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSubtitle_Public_Void_Double_Double_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 218458, RefRangeEnd = 218459, XrefRangeStart = 218454, XrefRangeEnd = 218458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetSubtitleForTime(double time, out string subtitle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&time);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr il2CppString = IL2CPP.ManagedStringToIl2Cpp(subtitle);
		*(System.IntPtr**)num = &il2CppString;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSubtitleForTime_Public_Boolean_Double_byref_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		subtitle = IL2CPP.Il2CppStringToManaged(il2CppString);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static VideoTutorialData()
	{
		Il2CppClassPointerStore<VideoTutorialData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers", "VideoTutorialData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VideoTutorialData>.NativeClassPtr);
		NativeFieldInfoPtr_subtitles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoTutorialData>.NativeClassPtr, "subtitles");
		NativeMethodInfoPtr_AddSubtitle_Public_Void_Double_Double_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoTutorialData>.NativeClassPtr, 100679801);
		NativeMethodInfoPtr_GetSubtitleForTime_Public_Boolean_Double_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoTutorialData>.NativeClassPtr, 100679802);
	}

	public VideoTutorialData(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe VideoTutorialData()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VideoTutorialData>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<VideoTutorialData>.NativeClassPtr))
	{
	}
}
