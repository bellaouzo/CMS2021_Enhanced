using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

public class UITextTypeWriter : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_txt;

	private static readonly System.IntPtr NativeFieldInfoPtr_story;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UITextTypeWriter>.NativeClassPtr));

	public unsafe Text txt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_txt);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_txt), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe string story
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_story);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_story), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe UITextTypeWriter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UITextTypeWriter>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static UITextTypeWriter()
	{
		Il2CppClassPointerStore<UITextTypeWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "UITextTypeWriter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UITextTypeWriter>.NativeClassPtr);
		NativeFieldInfoPtr_txt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITextTypeWriter>.NativeClassPtr, "txt");
		NativeFieldInfoPtr_story = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITextTypeWriter>.NativeClassPtr, "story");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITextTypeWriter>.NativeClassPtr, 100668344);
	}

	public UITextTypeWriter(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
