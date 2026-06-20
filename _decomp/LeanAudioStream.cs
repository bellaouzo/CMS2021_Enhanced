using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class LeanAudioStream : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	private static readonly System.IntPtr NativeFieldInfoPtr_audioClip;

	private static readonly System.IntPtr NativeFieldInfoPtr_audioArr;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ArrayOf_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnAudioRead_Public_Void_ArrayOf_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnAudioSetPosition_Public_Void_Int32_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LeanAudioStream>.NativeClassPtr));

	public unsafe int position
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_position);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_position)) = num;
		}
	}

	public unsafe AudioClip audioClip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioClip);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioClip(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioClip), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<float> audioArr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioArr);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioArr), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(38)]
	[CachedScanResults(RefRangeStart = 5915, RefRangeEnd = 5953, XrefRangeStart = 5915, XrefRangeEnd = 5915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LeanAudioStream(Il2CppStructArray<float> audioArr)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeanAudioStream>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioArr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ArrayOf_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5953, XrefRangeEnd = 5954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAudioRead(Il2CppStructArray<float> data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnAudioRead_Public_Void_ArrayOf_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void OnAudioSetPosition(int newPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newPosition);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnAudioSetPosition_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static LeanAudioStream()
	{
		Il2CppClassPointerStore<LeanAudioStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LeanAudioStream");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeanAudioStream>.NativeClassPtr);
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioStream>.NativeClassPtr, "position");
		NativeFieldInfoPtr_audioClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioStream>.NativeClassPtr, "audioClip");
		NativeFieldInfoPtr_audioArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioStream>.NativeClassPtr, "audioArr");
		NativeMethodInfoPtr__ctor_Public_Void_ArrayOf_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioStream>.NativeClassPtr, 100663863);
		NativeMethodInfoPtr_OnAudioRead_Public_Void_ArrayOf_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioStream>.NativeClassPtr, 100663864);
		NativeMethodInfoPtr_OnAudioSetPosition_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioStream>.NativeClassPtr, 100663865);
	}

	public LeanAudioStream(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
