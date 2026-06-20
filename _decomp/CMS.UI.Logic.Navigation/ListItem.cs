using System;
using System.Runtime.CompilerServices;
using CMS.UI.Controls;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.UI.Logic.Navigation;

[System.Serializable]
public class ListItem : Control
{
	private static readonly System.IntPtr NativeFieldInfoPtr_isSelected;

	private static readonly System.IntPtr NativeFieldInfoPtr_Y;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnMouseHover;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlaySounds;

	private static readonly System.IntPtr NativeMethodInfoPtr_Select_Public_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deselect_Public_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSelected_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanSelect_Public_Virtual_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayClickSound_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ListItem>.NativeClassPtr));

	public unsafe bool isSelected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSelected);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSelected)) = flag;
		}
	}

	public unsafe int Y
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Y);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Y)) = num;
		}
	}

	public unsafe Il2CppSystem.Action<int> OnMouseHover
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnMouseHover);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<int>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnMouseHover), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool PlaySounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlaySounds);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlaySounds)) = flag;
		}
	}

	[CallerCount(41)]
	[CachedScanResults(RefRangeStart = 195633, RefRangeEnd = 195674, XrefRangeStart = 195626, XrefRangeEnd = 195633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Select()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Select_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void Deselect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Deselect_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool IsSelected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSelected_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 195683, RefRangeEnd = 195700, XrefRangeStart = 195674, XrefRangeEnd = 195683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanSelect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_CanSelect_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 195707, RefRangeEnd = 195709, XrefRangeStart = 195700, XrefRangeEnd = 195707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayClickSound()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayClickSound_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe ListItem()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListItem>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ListItem()
	{
		Il2CppClassPointerStore<ListItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Navigation", "ListItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListItem>.NativeClassPtr);
		NativeFieldInfoPtr_isSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListItem>.NativeClassPtr, "isSelected");
		NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListItem>.NativeClassPtr, "Y");
		NativeFieldInfoPtr_OnMouseHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListItem>.NativeClassPtr, "OnMouseHover");
		NativeFieldInfoPtr_PlaySounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListItem>.NativeClassPtr, "PlaySounds");
		NativeMethodInfoPtr_Select_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListItem>.NativeClassPtr, 100677897);
		NativeMethodInfoPtr_Deselect_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListItem>.NativeClassPtr, 100677898);
		NativeMethodInfoPtr_IsSelected_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListItem>.NativeClassPtr, 100677899);
		NativeMethodInfoPtr_CanSelect_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListItem>.NativeClassPtr, 100677900);
		NativeMethodInfoPtr_PlayClickSound_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListItem>.NativeClassPtr, 100677901);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListItem>.NativeClassPtr, 100677902);
	}

	public ListItem(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
