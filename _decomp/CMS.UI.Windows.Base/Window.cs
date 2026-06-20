using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.UI.Windows.Base;

public class Window : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_id;

	private static readonly System.IntPtr NativeFieldInfoPtr_canBeHiddenFromOutside;

	private static readonly System.IntPtr NativeFieldInfoPtr_isActive;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ID_Public_get_WindowID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ID_Public_set_Void_WindowID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CanBeHiddenFromOutside_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_CanBeHiddenFromOutside_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_Virtual_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_Virtual_New_Boolean_ArrayOf_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Public_Virtual_New_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterItself_Public_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterItself_Public_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAsActive_Protected_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Window>.NativeClassPtr));

	public unsafe WindowID id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
			return *(WindowID*)num;
		}
		set
		{
			*(WindowID*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = windowID;
		}
	}

	public unsafe bool canBeHiddenFromOutside
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canBeHiddenFromOutside);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canBeHiddenFromOutside)) = flag;
		}
	}

	public unsafe bool isActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isActive)) = flag;
		}
	}

	public unsafe WindowID ID
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ID_Public_get_WindowID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(WindowID*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ID_Public_set_Void_WindowID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe bool CanBeHiddenFromOutside
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CanBeHiddenFromOutside_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CanBeHiddenFromOutside_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe bool IsActive
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(0)]
	public unsafe bool Show()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Show_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool Show(Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Show_Public_Virtual_New_Boolean_ArrayOf_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool Hide(bool hiddenFromOutside)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hiddenFromOutside);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Hide_Public_Virtual_New_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void RegisterItself()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_RegisterItself_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void UnregisterItself()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_UnregisterItself_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 178820, RefRangeEnd = 178827, XrefRangeStart = 178816, XrefRangeEnd = 178820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAsActive(bool active = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&active);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAsActive_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe Window()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Window>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Window()
	{
		Il2CppClassPointerStore<Window>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Windows.Base", "Window");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Window>.NativeClassPtr);
		NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window>.NativeClassPtr, "id");
		NativeFieldInfoPtr_canBeHiddenFromOutside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window>.NativeClassPtr, "canBeHiddenFromOutside");
		NativeFieldInfoPtr_isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Window>.NativeClassPtr, "isActive");
		NativeMethodInfoPtr_get_ID_Public_get_WindowID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100676195);
		NativeMethodInfoPtr_set_ID_Public_set_Void_WindowID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100676196);
		NativeMethodInfoPtr_get_CanBeHiddenFromOutside_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100676197);
		NativeMethodInfoPtr_set_CanBeHiddenFromOutside_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100676198);
		NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100676199);
		NativeMethodInfoPtr_Show_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100676200);
		NativeMethodInfoPtr_Show_Public_Virtual_New_Boolean_ArrayOf_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100676201);
		NativeMethodInfoPtr_Hide_Public_Virtual_New_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100676202);
		NativeMethodInfoPtr_RegisterItself_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100676203);
		NativeMethodInfoPtr_UnregisterItself_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100676204);
		NativeMethodInfoPtr_SetAsActive_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100676205);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Window>.NativeClassPtr, 100676206);
	}

	public Window(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
