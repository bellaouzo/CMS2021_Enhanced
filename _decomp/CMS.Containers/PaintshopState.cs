using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CMS.UI.Logic;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.Containers;

[StructLayout(LayoutKind.Explicit)]
public struct PaintshopState
{
	private static readonly System.IntPtr NativeFieldInfoPtr_HasColorFromPalette;

	private static readonly System.IntPtr NativeFieldInfoPtr_PaintshopPreset;

	private static readonly System.IntPtr NativeFieldInfoPtr_SelectedPaletteColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_SectionWithCheckmark;

	private static readonly System.IntPtr NativeFieldInfoPtr_Current;

	private static readonly System.IntPtr NativeFieldInfoPtr_Selected;

	private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyCurrentColorToSelected_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopySelectedColorToCurrent_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyCurrentPaintTypeToSelected_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopySelectedPaintTypeToCurrent_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyCurrentPaintDataToSelected_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopySelectedPaintDataToCurrent_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyCurrentToSelected_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopySelectedToCurrent_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCurrentColor_Public_Void_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCurrentPaintType_Public_Void_PaintType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCurrentPaintData_Public_Void_PaintData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSelectedColor_Public_Void_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSelectedPaintType_Public_Void_PaintType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSelectedPaintData_Public_Void_PaintData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrintSelectedState_Public_Void_0;

	[FieldOffset(0)]
	public bool HasColorFromPalette;

	[FieldOffset(4)]
	public PaintshopPreset PaintshopPreset;

	[FieldOffset(8)]
	public Vector2Int SelectedPaletteColor;

	[FieldOffset(16)]
	public int SectionWithCheckmark;

	[FieldOffset(20)]
	public PaintshopColorData Current;

	[FieldOffset(60)]
	public PaintshopColorData Selected;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PaintshopState>.NativeClassPtr));

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218362, XrefRangeEnd = 218364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Prepare()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Prepare_Public_Void_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void CopyCurrentColorToSelected()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyCurrentColorToSelected_Public_Void_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void CopySelectedColorToCurrent()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopySelectedColorToCurrent_Public_Void_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void CopyCurrentPaintTypeToSelected()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyCurrentPaintTypeToSelected_Public_Void_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void CopySelectedPaintTypeToCurrent()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopySelectedPaintTypeToCurrent_Public_Void_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void CopyCurrentPaintDataToSelected()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyCurrentPaintDataToSelected_Public_Void_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void CopySelectedPaintDataToCurrent()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopySelectedPaintDataToCurrent_Public_Void_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void CopyCurrentToSelected()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyCurrentToSelected_Public_Void_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void CopySelectedToCurrent()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopySelectedToCurrent_Public_Void_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetCurrentColor(Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&color);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCurrentColor_Public_Void_Color_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetCurrentPaintType(PaintType paintType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&paintType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCurrentPaintType_Public_Void_PaintType_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetCurrentPaintData(PaintData paintData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&paintData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCurrentPaintData_Public_Void_PaintData_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetSelectedColor(Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&color);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSelectedColor_Public_Void_Color_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetSelectedPaintType(PaintType paintType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&paintType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSelectedPaintType_Public_Void_PaintType_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetSelectedPaintData(PaintData paintData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&paintData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSelectedPaintData_Public_Void_PaintData_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218364, XrefRangeEnd = 218393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrintSelectedState()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrintSelectedState_Public_Void_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PaintshopState()
	{
		Il2CppClassPointerStore<PaintshopState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers", "PaintshopState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PaintshopState>.NativeClassPtr);
		NativeFieldInfoPtr_HasColorFromPalette = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaintshopState>.NativeClassPtr, "HasColorFromPalette");
		NativeFieldInfoPtr_PaintshopPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaintshopState>.NativeClassPtr, "PaintshopPreset");
		NativeFieldInfoPtr_SelectedPaletteColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaintshopState>.NativeClassPtr, "SelectedPaletteColor");
		NativeFieldInfoPtr_SectionWithCheckmark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaintshopState>.NativeClassPtr, "SectionWithCheckmark");
		NativeFieldInfoPtr_Current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaintshopState>.NativeClassPtr, "Current");
		NativeFieldInfoPtr_Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaintshopState>.NativeClassPtr, "Selected");
		NativeMethodInfoPtr_Prepare_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintshopState>.NativeClassPtr, 100679767);
		NativeMethodInfoPtr_CopyCurrentColorToSelected_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintshopState>.NativeClassPtr, 100679768);
		NativeMethodInfoPtr_CopySelectedColorToCurrent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintshopState>.NativeClassPtr, 100679769);
		NativeMethodInfoPtr_CopyCurrentPaintTypeToSelected_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintshopState>.NativeClassPtr, 100679770);
		NativeMethodInfoPtr_CopySelectedPaintTypeToCurrent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintshopState>.NativeClassPtr, 100679771);
		NativeMethodInfoPtr_CopyCurrentPaintDataToSelected_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintshopState>.NativeClassPtr, 100679772);
		NativeMethodInfoPtr_CopySelectedPaintDataToCurrent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintshopState>.NativeClassPtr, 100679773);
		NativeMethodInfoPtr_CopyCurrentToSelected_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintshopState>.NativeClassPtr, 100679774);
		NativeMethodInfoPtr_CopySelectedToCurrent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintshopState>.NativeClassPtr, 100679775);
		NativeMethodInfoPtr_SetCurrentColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintshopState>.NativeClassPtr, 100679776);
		NativeMethodInfoPtr_SetCurrentPaintType_Public_Void_PaintType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintshopState>.NativeClassPtr, 100679777);
		NativeMethodInfoPtr_SetCurrentPaintData_Public_Void_PaintData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintshopState>.NativeClassPtr, 100679778);
		NativeMethodInfoPtr_SetSelectedColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintshopState>.NativeClassPtr, 100679779);
		NativeMethodInfoPtr_SetSelectedPaintType_Public_Void_PaintType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintshopState>.NativeClassPtr, 100679780);
		NativeMethodInfoPtr_SetSelectedPaintData_Public_Void_PaintData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintshopState>.NativeClassPtr, 100679781);
		NativeMethodInfoPtr_PrintSelectedState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintshopState>.NativeClassPtr, 100679782);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PaintshopState>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
