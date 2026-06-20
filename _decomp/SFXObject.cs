using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

[System.Serializable]
public class SFXObject : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_audioSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_isRandom;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_AudioSource_Boolean_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SFXObject>.NativeClassPtr));

	public unsafe string name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe AudioSource audioSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioSource);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AudioSource(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioSource), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool isRandom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRandom);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRandom)) = flag;
		}
	}

	[CallerCount(32)]
	[CachedScanResults(RefRangeStart = 84639, RefRangeEnd = 84671, XrefRangeStart = 84639, XrefRangeEnd = 84639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SFXObject(string _name, AudioSource _audioSource, bool _isRandom)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SFXObject>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(_name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(_audioSource);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &_isRandom;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_AudioSource_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SFXObject()
	{
		Il2CppClassPointerStore<SFXObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SFXObject");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SFXObject>.NativeClassPtr);
		NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXObject>.NativeClassPtr, "name");
		NativeFieldInfoPtr_audioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXObject>.NativeClassPtr, "audioSource");
		NativeFieldInfoPtr_isRandom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXObject>.NativeClassPtr, "isRandom");
		NativeMethodInfoPtr__ctor_Public_Void_String_AudioSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXObject>.NativeClassPtr, 100668107);
	}

	public SFXObject(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
