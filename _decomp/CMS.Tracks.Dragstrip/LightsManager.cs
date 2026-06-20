using System;
using System.Runtime.CompilerServices;
using CMS.UI.Logic.Drag;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.Tracks.Dragstrip;

public class LightsManager : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_lights;

	private static readonly System.IntPtr NativeFieldInfoPtr_dragTreeUI;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareDragTreeUI_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowDragTreeUI_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HideDragTreeUI_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLightsState_Public_Void_LightsState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LightsManager>.NativeClassPtr));

	public unsafe Il2CppReferenceArray<Lights> lights
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lights);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Lights>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lights), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DragTree dragTreeUI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dragTreeUI);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DragTree(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dragTreeUI), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134580, XrefRangeEnd = 134589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareDragTreeUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareDragTreeUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134589, XrefRangeEnd = 134598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowDragTreeUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowDragTreeUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 134600, RefRangeEnd = 134602, XrefRangeStart = 134598, XrefRangeEnd = 134600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HideDragTreeUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HideDragTreeUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 134605, RefRangeEnd = 134610, XrefRangeStart = 134602, XrefRangeEnd = 134605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLightsState(LightsState lightsState)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&lightsState);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLightsState_Public_Void_LightsState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe LightsManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightsManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static LightsManager()
	{
		Il2CppClassPointerStore<LightsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Tracks.Dragstrip", "LightsManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightsManager>.NativeClassPtr);
		NativeFieldInfoPtr_lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightsManager>.NativeClassPtr, "lights");
		NativeFieldInfoPtr_dragTreeUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightsManager>.NativeClassPtr, "dragTreeUI");
		NativeMethodInfoPtr_PrepareDragTreeUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightsManager>.NativeClassPtr, 100672243);
		NativeMethodInfoPtr_ShowDragTreeUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightsManager>.NativeClassPtr, 100672244);
		NativeMethodInfoPtr_HideDragTreeUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightsManager>.NativeClassPtr, 100672245);
		NativeMethodInfoPtr_SetLightsState_Public_Void_LightsState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightsManager>.NativeClassPtr, 100672246);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightsManager>.NativeClassPtr, 100672247);
	}

	public LightsManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
