using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class SoundManagerSFXList : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_PitchRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_sfxlist;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SoundManagerSFXList>.NativeClassPtr));

	public unsafe Vector2 PitchRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PitchRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PitchRange)) = vector;
		}
	}

	public unsafe Il2CppReferenceArray<AudioClip> sfxlist
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sfxlist);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<AudioClip>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sfxlist), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84671, XrefRangeEnd = 84674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SoundManagerSFXList()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoundManagerSFXList>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SoundManagerSFXList()
	{
		Il2CppClassPointerStore<SoundManagerSFXList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SoundManagerSFXList");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoundManagerSFXList>.NativeClassPtr);
		NativeFieldInfoPtr_PitchRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundManagerSFXList>.NativeClassPtr, "PitchRange");
		NativeFieldInfoPtr_sfxlist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundManagerSFXList>.NativeClassPtr, "sfxlist");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundManagerSFXList>.NativeClassPtr, 100668108);
	}

	public SoundManagerSFXList(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
