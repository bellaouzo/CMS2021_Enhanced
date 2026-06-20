using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.EventSystems;

namespace CMS.UI.Helpers;

public static class EventHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_eventSystem;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeButtonClick_Public_Static_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeButtonEnter_Public_Static_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeButtonExit_Public_Static_Void_GameObject_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<EventHelper>.NativeClassPtr));

	public unsafe static EventSystem eventSystem
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_eventSystem, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new EventSystem(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_eventSystem, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205327, XrefRangeEnd = 205357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeButtonClick(GameObject button)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(button);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeButtonClick_Public_Static_Void_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205357, XrefRangeEnd = 205388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeButtonEnter(GameObject button)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(button);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeButtonEnter_Public_Static_Void_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205388, XrefRangeEnd = 205419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeButtonExit(GameObject button)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(button);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeButtonExit_Public_Static_Void_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static EventHelper()
	{
		Il2CppClassPointerStore<EventHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Helpers", "EventHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventHelper>.NativeClassPtr);
		NativeFieldInfoPtr_eventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, "eventSystem");
		NativeMethodInfoPtr_InvokeButtonClick_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100678751);
		NativeMethodInfoPtr_InvokeButtonEnter_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100678752);
		NativeMethodInfoPtr_InvokeButtonExit_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHelper>.NativeClassPtr, 100678753);
	}

	public EventHelper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
