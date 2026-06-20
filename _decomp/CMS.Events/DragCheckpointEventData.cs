using System;
using System.Runtime.CompilerServices;
using CMS.Containers;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Events;

public class DragCheckpointEventData : EventData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_DragTime;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_DragTime_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DragCheckpointEventData>.NativeClassPtr));

	public unsafe DragTime DragTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DragTime);
			return *(DragTime*)num;
		}
		set
		{
			*(DragTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DragTime)) = dragTime;
		}
	}

	[CallerCount(0)]
	public unsafe DragCheckpointEventData(DragTime time)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragCheckpointEventData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_DragTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DragCheckpointEventData()
	{
		Il2CppClassPointerStore<DragCheckpointEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Events", "DragCheckpointEventData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragCheckpointEventData>.NativeClassPtr);
		NativeFieldInfoPtr_DragTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragCheckpointEventData>.NativeClassPtr, "DragTime");
		NativeMethodInfoPtr__ctor_Public_Void_DragTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCheckpointEventData>.NativeClassPtr, 100679687);
	}

	public DragCheckpointEventData(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
