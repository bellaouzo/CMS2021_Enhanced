using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace CMS.UI.Logic.Drag;

public class DragIndexDisplay : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_letterText;

	private static readonly System.IntPtr NativeFieldInfoPtr_letterImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_dragIndexText;

	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Public_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupEmpty_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupUnknown_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Private_Void_String_Int32_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DragIndexDisplay>.NativeClassPtr));

	public unsafe Text letterText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_letterText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_letterText), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image letterImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_letterImage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_letterImage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text dragIndexText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dragIndexText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dragIndexText), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 199146, RefRangeEnd = 199161, XrefRangeStart = 199108, XrefRangeEnd = 199146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Setup(float dragIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dragIndex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 199165, RefRangeEnd = 199167, XrefRangeStart = 199161, XrefRangeEnd = 199165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupEmpty()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupEmpty_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199167, XrefRangeEnd = 199171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupUnknown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupUnknown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 199176, RefRangeEnd = 199177, XrefRangeStart = 199171, XrefRangeEnd = 199176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetData(string letter, int dragIndex, Color color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(letter);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dragIndex;
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetData_Private_Void_String_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe DragIndexDisplay()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragIndexDisplay>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DragIndexDisplay()
	{
		Il2CppClassPointerStore<DragIndexDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Drag", "DragIndexDisplay");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragIndexDisplay>.NativeClassPtr);
		NativeFieldInfoPtr_letterText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragIndexDisplay>.NativeClassPtr, "letterText");
		NativeFieldInfoPtr_letterImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragIndexDisplay>.NativeClassPtr, "letterImage");
		NativeFieldInfoPtr_dragIndexText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragIndexDisplay>.NativeClassPtr, "dragIndexText");
		NativeMethodInfoPtr_Setup_Public_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragIndexDisplay>.NativeClassPtr, 100678287);
		NativeMethodInfoPtr_SetupEmpty_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragIndexDisplay>.NativeClassPtr, 100678288);
		NativeMethodInfoPtr_SetupUnknown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragIndexDisplay>.NativeClassPtr, 100678289);
		NativeMethodInfoPtr_SetData_Private_Void_String_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragIndexDisplay>.NativeClassPtr, 100678290);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragIndexDisplay>.NativeClassPtr, 100678291);
	}

	public DragIndexDisplay(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
