using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.UI.Logic.CarInfo;

public class PartsTabPageManager : CarInfoPageManagerBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareFirstPage_Public_Void_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PartsTabPageManager>.NativeClassPtr));

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202155, XrefRangeEnd = 202156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareFirstPage(CarLoader carLoader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareFirstPage_Public_Void_CarLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe PartsTabPageManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartsTabPageManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PartsTabPageManager()
	{
		Il2CppClassPointerStore<PartsTabPageManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.CarInfo", "PartsTabPageManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartsTabPageManager>.NativeClassPtr);
		NativeMethodInfoPtr_PrepareFirstPage_Public_Void_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartsTabPageManager>.NativeClassPtr, 100678551);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartsTabPageManager>.NativeClassPtr, 100678552);
	}

	public PartsTabPageManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
