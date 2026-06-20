using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Events;

public class DragStopCheckpointEventData : EventData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_IsPlayer;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DragStopCheckpointEventData>.NativeClassPtr));

	public unsafe bool IsPlayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsPlayer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsPlayer)) = flag;
		}
	}

	[CallerCount(0)]
	public unsafe DragStopCheckpointEventData(bool isPlayer)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragStopCheckpointEventData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isPlayer);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DragStopCheckpointEventData()
	{
		Il2CppClassPointerStore<DragStopCheckpointEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Events", "DragStopCheckpointEventData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragStopCheckpointEventData>.NativeClassPtr);
		NativeFieldInfoPtr_IsPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragStopCheckpointEventData>.NativeClassPtr, "IsPlayer");
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragStopCheckpointEventData>.NativeClassPtr, 100679690);
	}

	public DragStopCheckpointEventData(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
