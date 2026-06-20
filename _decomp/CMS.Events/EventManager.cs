using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine.Events;

namespace CMS.Events;

public class EventManager : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_subscribedEvents;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Subscribe_Public_Void_EventID_UnityAction_1_EventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unsubscribe_Public_Void_EventID_UnityAction_1_EventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TriggerEvent_Public_Void_EventID_EventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveEvent_Public_Void_EventID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<EventManager>.NativeClassPtr));

	public unsafe Dictionary<EventID, UnityEvent<EventData>> subscribedEvents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subscribedEvents);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Dictionary<EventID, UnityEvent<EventData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subscribedEvents), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 217549, RefRangeEnd = 217550, XrefRangeStart = 217543, XrefRangeEnd = 217549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 217565, RefRangeEnd = 217566, XrefRangeStart = 217550, XrefRangeEnd = 217565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Cleanup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cleanup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 217577, RefRangeEnd = 217589, XrefRangeStart = 217566, XrefRangeEnd = 217577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Subscribe(EventID eventID, UnityAction<EventData> listener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&eventID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(listener);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Subscribe_Public_Void_EventID_UnityAction_1_EventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 217593, RefRangeEnd = 217603, XrefRangeStart = 217589, XrefRangeEnd = 217593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Unsubscribe(EventID eventID, UnityAction<EventData> listener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&eventID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(listener);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unsubscribe_Public_Void_EventID_UnityAction_1_EventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 217626, RefRangeEnd = 217633, XrefRangeStart = 217603, XrefRangeEnd = 217626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TriggerEvent(EventID eventID, EventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&eventID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(eventData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TriggerEvent_Public_Void_EventID_EventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 217639, RefRangeEnd = 217645, XrefRangeStart = 217633, XrefRangeEnd = 217639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveEvent(EventID eventID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&eventID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveEvent_Public_Void_EventID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe EventManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static EventManager()
	{
		Il2CppClassPointerStore<EventManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Events", "EventManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventManager>.NativeClassPtr);
		NativeFieldInfoPtr_subscribedEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventManager>.NativeClassPtr, "subscribedEvents");
		NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventManager>.NativeClassPtr, 100679693);
		NativeMethodInfoPtr_Cleanup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventManager>.NativeClassPtr, 100679694);
		NativeMethodInfoPtr_Subscribe_Public_Void_EventID_UnityAction_1_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventManager>.NativeClassPtr, 100679695);
		NativeMethodInfoPtr_Unsubscribe_Public_Void_EventID_UnityAction_1_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventManager>.NativeClassPtr, 100679696);
		NativeMethodInfoPtr_TriggerEvent_Public_Void_EventID_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventManager>.NativeClassPtr, 100679697);
		NativeMethodInfoPtr_RemoveEvent_Public_Void_EventID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventManager>.NativeClassPtr, 100679698);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventManager>.NativeClassPtr, 100679699);
	}

	public EventManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
