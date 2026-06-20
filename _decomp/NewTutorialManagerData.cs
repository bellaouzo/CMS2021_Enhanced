using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[System.Serializable]
public class NewTutorialManagerData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_tutorials;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<NewTutorialManagerData>.NativeClassPtr));

	public unsafe Il2CppStructArray<bool> tutorials
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tutorials);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<bool>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tutorials), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65243, XrefRangeEnd = 65245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NewTutorialManagerData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewTutorialManagerData>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static NewTutorialManagerData()
	{
		Il2CppClassPointerStore<NewTutorialManagerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "NewTutorialManagerData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewTutorialManagerData>.NativeClassPtr);
		NativeFieldInfoPtr_tutorials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewTutorialManagerData>.NativeClassPtr, "tutorials");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewTutorialManagerData>.NativeClassPtr, 100667299);
	}

	public NewTutorialManagerData(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
