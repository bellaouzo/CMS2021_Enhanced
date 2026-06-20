using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class SelectObject : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_action;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAction_Public_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Select_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SelectObject>.NativeClassPtr));

	public unsafe Il2CppSystem.Action action
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_action);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(60)]
	[CachedScanResults(RefRangeStart = 28091, RefRangeEnd = 28151, XrefRangeStart = 28091, XrefRangeEnd = 28091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAction(Il2CppSystem.Action a)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAction_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28151, XrefRangeEnd = 28152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Select()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Select_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe SelectObject()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectObject>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SelectObject()
	{
		Il2CppClassPointerStore<SelectObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SelectObject");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectObject>.NativeClassPtr);
		NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectObject>.NativeClassPtr, "action");
		NativeMethodInfoPtr_SetAction_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectObject>.NativeClassPtr, 100665197);
		NativeMethodInfoPtr_Select_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectObject>.NativeClassPtr, 100665198);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectObject>.NativeClassPtr, 100665199);
	}

	public SelectObject(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
