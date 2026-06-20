using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace CMS.UI.Logic;

public class SelectableIcon : BasicSelectableIcon
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetPosition_Public_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetImage_Public_Image_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetState_Protected_Virtual_Void_HoverableItemState_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SelectableIcon>.NativeClassPtr));

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 179768, RefRangeEnd = 179771, XrefRangeStart = 179764, XrefRangeEnd = 179768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPosition_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe Image GetImage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetImage_Public_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179771, XrefRangeEnd = 179794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void SetState(HoverableItemState newState, bool instant = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&newState);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &instant;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SetState_Protected_Virtual_Void_HoverableItemState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe SelectableIcon()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectableIcon>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SelectableIcon()
	{
		Il2CppClassPointerStore<SelectableIcon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic", "SelectableIcon");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectableIcon>.NativeClassPtr);
		NativeMethodInfoPtr_GetPosition_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableIcon>.NativeClassPtr, 100676371);
		NativeMethodInfoPtr_GetImage_Public_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableIcon>.NativeClassPtr, 100676372);
		NativeMethodInfoPtr_SetState_Protected_Virtual_Void_HoverableItemState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableIcon>.NativeClassPtr, 100676373);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableIcon>.NativeClassPtr, 100676374);
	}

	public SelectableIcon(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
