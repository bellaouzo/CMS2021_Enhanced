using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine.EventSystems;

namespace UnityEngine.UI;

public class ReturnKeyTriggersButton : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr__system;

	private static readonly System.IntPtr NativeFieldInfoPtr_button;

	private static readonly System.IntPtr NativeFieldInfoPtr_highlight;

	private static readonly System.IntPtr NativeFieldInfoPtr_highlightDuration;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveHighlight_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ReturnKeyTriggersButton>.NativeClassPtr));

	public unsafe EventSystem _system
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__system);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new EventSystem(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__system), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Button button
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_button);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Button(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool highlight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highlight);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highlight)) = flag;
		}
	}

	public unsafe float highlightDuration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highlightDuration);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highlightDuration)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117900, XrefRangeEnd = 117904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117904, XrefRangeEnd = 117909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveHighlight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveHighlight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117909, XrefRangeEnd = 117919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSubmit(BaseEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117919, XrefRangeEnd = 117922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReturnKeyTriggersButton()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReturnKeyTriggersButton>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ReturnKeyTriggersButton()
	{
		Il2CppClassPointerStore<ReturnKeyTriggersButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "UnityEngine.UI", "ReturnKeyTriggersButton");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReturnKeyTriggersButton>.NativeClassPtr);
		NativeFieldInfoPtr__system = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReturnKeyTriggersButton>.NativeClassPtr, "_system");
		NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReturnKeyTriggersButton>.NativeClassPtr, "button");
		NativeFieldInfoPtr_highlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReturnKeyTriggersButton>.NativeClassPtr, "highlight");
		NativeFieldInfoPtr_highlightDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReturnKeyTriggersButton>.NativeClassPtr, "highlightDuration");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnKeyTriggersButton>.NativeClassPtr, 100670769);
		NativeMethodInfoPtr_RemoveHighlight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnKeyTriggersButton>.NativeClassPtr, 100670770);
		NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnKeyTriggersButton>.NativeClassPtr, 100670771);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnKeyTriggersButton>.NativeClassPtr, 100670772);
	}

	public ReturnKeyTriggersButton(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
