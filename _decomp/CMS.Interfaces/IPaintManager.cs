using System;
using System.Runtime.CompilerServices;
using CMS.Containers;
using CMS.UI.Logic;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.Events;

namespace CMS.Interfaces;

public class IPaintManager : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_RestoreSelectedColor_Public_Abstract_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddDisableOtherCheckmarkListener_Public_Abstract_Virtual_New_Void_UnityAction_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDisableOtherCheckmarkListener_Public_Abstract_Virtual_New_Void_UnityAction_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeDisableOtherCheckmarkListener_Public_Abstract_Virtual_New_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPaintType_Public_Abstract_Virtual_New_Void_PaintType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateColor_Public_Abstract_Virtual_New_Void_Color32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPaintshopState_Public_Abstract_Virtual_New_PaintshopState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPaintshopState_Public_Abstract_Virtual_New_Void_PaintshopState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPaintshopType_Public_Abstract_Virtual_New_PaintshopType_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<IPaintManager>.NativeClassPtr));

	[CallerCount(0)]
	public unsafe void RestoreSelectedColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_RestoreSelectedColor_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void AddDisableOtherCheckmarkListener(UnityAction<UnityEngine.Object> action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_AddDisableOtherCheckmarkListener_Public_Abstract_Virtual_New_Void_UnityAction_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void RemoveDisableOtherCheckmarkListener(UnityAction<UnityEngine.Object> action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_RemoveDisableOtherCheckmarkListener_Public_Abstract_Virtual_New_Void_UnityAction_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void InvokeDisableOtherCheckmarkListener(UnityEngine.Object obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_InvokeDisableOtherCheckmarkListener_Public_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetPaintType(PaintType paintType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&paintType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SetPaintType_Public_Abstract_Virtual_New_Void_PaintType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void UpdateColor(Color32 color, bool customColor = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&color);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &customColor;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_UpdateColor_Public_Abstract_Virtual_New_Void_Color32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe PaintshopState GetPaintshopState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetPaintshopState_Public_Abstract_Virtual_New_PaintshopState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(PaintshopState*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe void SetPaintshopState(PaintshopState state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&state);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SetPaintshopState_Public_Abstract_Virtual_New_Void_PaintshopState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe PaintshopType GetPaintshopType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetPaintshopType_Public_Abstract_Virtual_New_PaintshopType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(PaintshopType*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static IPaintManager()
	{
		Il2CppClassPointerStore<IPaintManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Interfaces", "IPaintManager");
		NativeMethodInfoPtr_RestoreSelectedColor_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPaintManager>.NativeClassPtr, 100672113);
		NativeMethodInfoPtr_AddDisableOtherCheckmarkListener_Public_Abstract_Virtual_New_Void_UnityAction_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPaintManager>.NativeClassPtr, 100672114);
		NativeMethodInfoPtr_RemoveDisableOtherCheckmarkListener_Public_Abstract_Virtual_New_Void_UnityAction_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPaintManager>.NativeClassPtr, 100672115);
		NativeMethodInfoPtr_InvokeDisableOtherCheckmarkListener_Public_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPaintManager>.NativeClassPtr, 100672116);
		NativeMethodInfoPtr_SetPaintType_Public_Abstract_Virtual_New_Void_PaintType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPaintManager>.NativeClassPtr, 100672117);
		NativeMethodInfoPtr_UpdateColor_Public_Abstract_Virtual_New_Void_Color32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPaintManager>.NativeClassPtr, 100672118);
		NativeMethodInfoPtr_GetPaintshopState_Public_Abstract_Virtual_New_PaintshopState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPaintManager>.NativeClassPtr, 100672119);
		NativeMethodInfoPtr_SetPaintshopState_Public_Abstract_Virtual_New_Void_PaintshopState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPaintManager>.NativeClassPtr, 100672120);
		NativeMethodInfoPtr_GetPaintshopType_Public_Abstract_Virtual_New_PaintshopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPaintManager>.NativeClassPtr, 100672121);
	}

	public IPaintManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
