using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Events;

public class DragTimeoutTickEventData : EventData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Time;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DragTimeoutTickEventData>.NativeClassPtr));

	public unsafe float Time
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Time);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Time)) = num;
		}
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe DragTimeoutTickEventData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragTimeoutTickEventData>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DragTimeoutTickEventData()
	{
		Il2CppClassPointerStore<DragTimeoutTickEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Events", "DragTimeoutTickEventData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragTimeoutTickEventData>.NativeClassPtr);
		NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTimeoutTickEventData>.NativeClassPtr, "Time");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTimeoutTickEventData>.NativeClassPtr, 100679691);
	}

	public DragTimeoutTickEventData(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
