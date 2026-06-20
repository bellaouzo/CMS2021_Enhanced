using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.UI.Logic.Navigation;

[System.Serializable]
public class GridItem : ListItem
{
	private static readonly System.IntPtr NativeFieldInfoPtr_X;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnMouseHover;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GridItem>.NativeClassPtr));

	public unsafe int X
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_X);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_X)) = num;
		}
	}

	public new unsafe Il2CppSystem.Action<int, int> OnMouseHover
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnMouseHover);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<int, int>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnMouseHover), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe GridItem()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GridItem>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static GridItem()
	{
		Il2CppClassPointerStore<GridItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Navigation", "GridItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GridItem>.NativeClassPtr);
		NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem>.NativeClassPtr, "X");
		NativeFieldInfoPtr_OnMouseHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem>.NativeClassPtr, "OnMouseHover");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100677853);
	}

	public GridItem(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
