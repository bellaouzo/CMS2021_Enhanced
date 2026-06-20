using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Events;

public class DragBidEventData : EventData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Member;

	private static readonly System.IntPtr NativeFieldInfoPtr_BetValue;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DragBidEventData>.NativeClassPtr));

	public unsafe byte Member
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Member);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Member)) = b;
		}
	}

	public unsafe ushort BetValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BetValue);
			return *(ushort*)num;
		}
		set
		{
			*(ushort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BetValue)) = num;
		}
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe DragBidEventData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragBidEventData>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DragBidEventData()
	{
		Il2CppClassPointerStore<DragBidEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Events", "DragBidEventData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragBidEventData>.NativeClassPtr);
		NativeFieldInfoPtr_Member = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragBidEventData>.NativeClassPtr, "Member");
		NativeFieldInfoPtr_BetValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragBidEventData>.NativeClassPtr, "BetValue");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragBidEventData>.NativeClassPtr, 100679686);
	}

	public DragBidEventData(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
