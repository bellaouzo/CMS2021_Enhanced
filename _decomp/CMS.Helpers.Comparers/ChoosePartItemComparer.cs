using System;
using System.Runtime.CompilerServices;
using CMS.Containers;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Helpers.Comparers;

public class ChoosePartItemComparer : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_ChoosePartDownItem_ChoosePartDownItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ChoosePartItemComparer>.NativeClassPtr));

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215344, XrefRangeEnd = 215350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Compare(ChoosePartDownItem a, ChoosePartDownItem b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_ChoosePartDownItem_ChoosePartDownItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe ChoosePartItemComparer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChoosePartItemComparer>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ChoosePartItemComparer()
	{
		Il2CppClassPointerStore<ChoosePartItemComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Helpers.Comparers", "ChoosePartItemComparer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChoosePartItemComparer>.NativeClassPtr);
		NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_ChoosePartDownItem_ChoosePartDownItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChoosePartItemComparer>.NativeClassPtr, 100679481);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChoosePartItemComparer>.NativeClassPtr, 100679482);
	}

	public ChoosePartItemComparer(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
