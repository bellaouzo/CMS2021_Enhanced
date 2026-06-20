using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Difficulty;

public class Expert : BaseDifficulty
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Expert>.NativeClassPtr));

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218893, XrefRangeEnd = 218914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Prepare()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Prepare_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe Expert()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Expert>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Expert()
	{
		Il2CppClassPointerStore<Expert>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Difficulty", "Expert");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Expert>.NativeClassPtr);
		NativeMethodInfoPtr_Prepare_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expert>.NativeClassPtr, 100679893);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expert>.NativeClassPtr, 100679894);
	}

	public Expert(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
