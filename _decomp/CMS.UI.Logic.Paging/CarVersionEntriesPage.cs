using System;
using System.Runtime.CompilerServices;
using CMS.Containers;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.UI.Logic.Paging;

public class CarVersionEntriesPage : Page
{
	private static readonly System.IntPtr NativeFieldInfoPtr_entries;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarVersionEntriesPage>.NativeClassPtr));

	public unsafe Il2CppReferenceArray<CarVersionWindowEntry> entries
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entries);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<CarVersionWindowEntry>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe CarVersionEntriesPage()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarVersionEntriesPage>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CarVersionEntriesPage()
	{
		Il2CppClassPointerStore<CarVersionEntriesPage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Paging", "CarVersionEntriesPage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarVersionEntriesPage>.NativeClassPtr);
		NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarVersionEntriesPage>.NativeClassPtr, "entries");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarVersionEntriesPage>.NativeClassPtr, 100677749);
	}

	public CarVersionEntriesPage(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
