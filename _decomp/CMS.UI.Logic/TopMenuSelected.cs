using System;
using System.Runtime.CompilerServices;
using CMS.UI.Logic.Themes;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace CMS.UI.Logic;

public class TopMenuSelected : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_gradient;

	private static readonly System.IntPtr NativeFieldInfoPtr_bar;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyTheme_Public_Void_Theme_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TopMenuSelected>.NativeClassPtr));

	public unsafe Image gradient
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gradient);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gradient), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image bar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bar);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bar), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181232, XrefRangeEnd = 181233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyTheme(Theme theme)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&theme);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyTheme_Public_Void_Theme_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe TopMenuSelected()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TopMenuSelected>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static TopMenuSelected()
	{
		Il2CppClassPointerStore<TopMenuSelected>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic", "TopMenuSelected");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TopMenuSelected>.NativeClassPtr);
		NativeFieldInfoPtr_gradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopMenuSelected>.NativeClassPtr, "gradient");
		NativeFieldInfoPtr_bar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TopMenuSelected>.NativeClassPtr, "bar");
		NativeMethodInfoPtr_ApplyTheme_Public_Void_Theme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenuSelected>.NativeClassPtr, 100676492);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TopMenuSelected>.NativeClassPtr, 100676493);
	}

	public TopMenuSelected(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
