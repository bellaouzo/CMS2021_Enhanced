using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS;

public class Highlighter : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_selectionColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_value;

	private static readonly System.IntPtr NativeFieldInfoPtr_renderers;

	private static readonly System.IntPtr NativeFieldInfoPtr_inited;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_flashing;

	private static readonly System.IntPtr NativeFieldInfoPtr_preventFlashing;

	private static readonly System.IntPtr NativeFieldInfoPtr_updateFlashing;

	private static readonly System.IntPtr NativeFieldInfoPtr_flashingFreq;

	private static readonly System.IntPtr NativeFieldInfoPtr_flashingColorMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_flashingColorMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_doublePI;

	private static readonly System.IntPtr NativeFieldInfoPtr_propertyBlock;

	private static readonly System.IntPtr NativeMethodInfoPtr_On_Public_Void_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Off_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FlashingOn_Public_Void_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FlashingOn_Public_Void_Color_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FlashingOff_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFlashing_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReinitMaterials_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetColor_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Die_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Highlighter>.NativeClassPtr));

	public unsafe Color selectionColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectionColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectionColor)) = color;
		}
	}

	public unsafe float value
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_value);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_value)) = num;
		}
	}

	public unsafe Il2CppReferenceArray<Renderer> renderers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Renderer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderers), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool inited
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inited);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inited)) = flag;
		}
	}

	public unsafe bool IsEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsEnabled)) = flag;
		}
	}

	public unsafe bool flashing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flashing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flashing)) = flag;
		}
	}

	public unsafe bool preventFlashing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preventFlashing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preventFlashing)) = flag;
		}
	}

	public unsafe bool updateFlashing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateFlashing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateFlashing)) = flag;
		}
	}

	public unsafe float flashingFreq
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flashingFreq);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flashingFreq)) = num;
		}
	}

	public unsafe Color flashingColorMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flashingColorMin);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flashingColorMin)) = color;
		}
	}

	public unsafe Color flashingColorMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flashingColorMax);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flashingColorMax)) = color;
		}
	}

	public unsafe static float doublePI
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_doublePI, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_doublePI, &num);
		}
	}

	public unsafe MaterialPropertyBlock propertyBlock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propertyBlock);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new MaterialPropertyBlock(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propertyBlock), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 131230, RefRangeEnd = 131235, XrefRangeStart = 131218, XrefRangeEnd = 131230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void On(Color color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&color);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_On_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131235, XrefRangeEnd = 131236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Off()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Off_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131236, XrefRangeEnd = 131246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FlashingOn(Color color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&color);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FlashingOn_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void FlashingOn(Color from, Color to, float freq)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&from);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &freq;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FlashingOn_Public_Void_Color_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(80)]
	[CachedScanResults(RefRangeStart = 131255, RefRangeEnd = 131335, XrefRangeStart = 131246, XrefRangeEnd = 131255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FlashingOff()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FlashingOff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131335, XrefRangeEnd = 131343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131343, XrefRangeEnd = 131348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131348, XrefRangeEnd = 131355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateFlashing()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFlashing_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131355, XrefRangeEnd = 131356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnValidate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 131358, RefRangeEnd = 131366, XrefRangeStart = 131356, XrefRangeEnd = 131358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReinitMaterials()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReinitMaterials_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 131408, RefRangeEnd = 131424, XrefRangeStart = 131366, XrefRangeEnd = 131408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131424, XrefRangeEnd = 131428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Die()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Die_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe Highlighter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Highlighter>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Highlighter()
	{
		Il2CppClassPointerStore<Highlighter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS", "Highlighter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Highlighter>.NativeClassPtr);
		NativeFieldInfoPtr_selectionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Highlighter>.NativeClassPtr, "selectionColor");
		NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Highlighter>.NativeClassPtr, "value");
		NativeFieldInfoPtr_renderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Highlighter>.NativeClassPtr, "renderers");
		NativeFieldInfoPtr_inited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Highlighter>.NativeClassPtr, "inited");
		NativeFieldInfoPtr_IsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Highlighter>.NativeClassPtr, "IsEnabled");
		NativeFieldInfoPtr_flashing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Highlighter>.NativeClassPtr, "flashing");
		NativeFieldInfoPtr_preventFlashing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Highlighter>.NativeClassPtr, "preventFlashing");
		NativeFieldInfoPtr_updateFlashing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Highlighter>.NativeClassPtr, "updateFlashing");
		NativeFieldInfoPtr_flashingFreq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Highlighter>.NativeClassPtr, "flashingFreq");
		NativeFieldInfoPtr_flashingColorMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Highlighter>.NativeClassPtr, "flashingColorMin");
		NativeFieldInfoPtr_flashingColorMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Highlighter>.NativeClassPtr, "flashingColorMax");
		NativeFieldInfoPtr_doublePI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Highlighter>.NativeClassPtr, "doublePI");
		NativeFieldInfoPtr_propertyBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Highlighter>.NativeClassPtr, "propertyBlock");
		NativeMethodInfoPtr_On_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Highlighter>.NativeClassPtr, 100672068);
		NativeMethodInfoPtr_Off_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Highlighter>.NativeClassPtr, 100672069);
		NativeMethodInfoPtr_FlashingOn_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Highlighter>.NativeClassPtr, 100672070);
		NativeMethodInfoPtr_FlashingOn_Public_Void_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Highlighter>.NativeClassPtr, 100672071);
		NativeMethodInfoPtr_FlashingOff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Highlighter>.NativeClassPtr, 100672072);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Highlighter>.NativeClassPtr, 100672073);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Highlighter>.NativeClassPtr, 100672074);
		NativeMethodInfoPtr_UpdateFlashing_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Highlighter>.NativeClassPtr, 100672075);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Highlighter>.NativeClassPtr, 100672076);
		NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Highlighter>.NativeClassPtr, 100672077);
		NativeMethodInfoPtr_ReinitMaterials_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Highlighter>.NativeClassPtr, 100672078);
		NativeMethodInfoPtr_SetColor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Highlighter>.NativeClassPtr, 100672079);
		NativeMethodInfoPtr_Die_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Highlighter>.NativeClassPtr, 100672080);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Highlighter>.NativeClassPtr, 100672081);
	}

	public Highlighter(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
