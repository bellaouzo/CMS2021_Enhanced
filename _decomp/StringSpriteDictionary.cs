using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

[System.Serializable]
public class StringSpriteDictionary : SerializableDictionary<string, Sprite>
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<StringSpriteDictionary>.NativeClassPtr));

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104446, XrefRangeEnd = 104449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StringSpriteDictionary()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringSpriteDictionary>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static StringSpriteDictionary()
	{
		Il2CppClassPointerStore<StringSpriteDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "StringSpriteDictionary");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringSpriteDictionary>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSpriteDictionary>.NativeClassPtr, 100669540);
	}

	public StringSpriteDictionary(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
