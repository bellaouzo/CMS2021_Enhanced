using System;
using System.Runtime.CompilerServices;
using CMS.Containers;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Events;

public class DragSpeedEventData : EventData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_DragSpeed;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_DragSpeed_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DragSpeedEventData>.NativeClassPtr));

	public unsafe DragSpeed DragSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DragSpeed);
			return *(DragSpeed*)num;
		}
		set
		{
			*(DragSpeed*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DragSpeed)) = dragSpeed;
		}
	}

	[CallerCount(0)]
	public unsafe DragSpeedEventData(DragSpeed speed)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragSpeedEventData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&speed);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_DragSpeed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DragSpeedEventData()
	{
		Il2CppClassPointerStore<DragSpeedEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Events", "DragSpeedEventData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragSpeedEventData>.NativeClassPtr);
		NativeFieldInfoPtr_DragSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragSpeedEventData>.NativeClassPtr, "DragSpeed");
		NativeMethodInfoPtr__ctor_Public_Void_DragSpeed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragSpeedEventData>.NativeClassPtr, 100679689);
	}

	public DragSpeedEventData(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
