using System;
using System.Runtime.CompilerServices;
using CMS.Containers;
using CMS.Salon;
using CMS.UI.Controls;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.Events;

namespace CMS.UI.Logic.Salon;

public class Paint : MonoBehaviour
{
	[System.Serializable]
	public class DisableOtherCheckmarkEvent : UnityEvent<UnityEngine.Object>
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DisableOtherCheckmarkEvent>.NativeClassPtr));

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191145, XrefRangeEnd = 191147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisableOtherCheckmarkEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisableOtherCheckmarkEvent>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static DisableOtherCheckmarkEvent()
		{
			Il2CppClassPointerStore<DisableOtherCheckmarkEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Paint>.NativeClassPtr, "DisableOtherCheckmarkEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisableOtherCheckmarkEvent>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableOtherCheckmarkEvent>.NativeClassPtr, 100677456);
		}

		public DisableOtherCheckmarkEvent(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_colorPalette;

	private static readonly System.IntPtr NativeFieldInfoPtr_configurator;

	private static readonly System.IntPtr NativeFieldInfoPtr_isActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_DisableOtherCheckmark;

	private static readonly System.IntPtr NativeFieldInfoPtr_paintshopState;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_Void_ArrayOf_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectFirstColor_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddDisableOtherCheckmarkListener_Public_Virtual_Final_New_Void_UnityAction_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDisableOtherCheckmarkListener_Public_Virtual_Final_New_Void_UnityAction_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeDisableOtherCheckmarkListener_Public_Virtual_Final_New_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPaintType_Public_Virtual_Final_New_Void_PaintType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RestoreSelectedColor_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateColor_Public_Virtual_Final_New_Void_Color32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SubmitCurrentColor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPaintshopType_Public_Virtual_Final_New_PaintshopType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPaintshopState_Public_Virtual_Final_New_PaintshopState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPaintshopState_Public_Virtual_Final_New_Void_PaintshopState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Paint>.NativeClassPtr));

	public unsafe ColorPalette colorPalette
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorPalette);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ColorPalette(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorPalette), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Configurator configurator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_configurator);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Configurator(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_configurator), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe DisableOtherCheckmarkEvent DisableOtherCheckmark
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableOtherCheckmark);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DisableOtherCheckmarkEvent(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisableOtherCheckmark), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PaintshopState paintshopState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintshopState);
			return *(PaintshopState*)num;
		}
		set
		{
			*(PaintshopState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintshopState)) = paintshopState;
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 191159, RefRangeEnd = 191160, XrefRangeStart = 191147, XrefRangeEnd = 191159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Show(Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Show_Public_Void_ArrayOf_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 191167, RefRangeEnd = 191172, XrefRangeStart = 191160, XrefRangeEnd = 191167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Hide()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191172, XrefRangeEnd = 191173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectFirstColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectFirstColor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191173, XrefRangeEnd = 191178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddDisableOtherCheckmarkListener(UnityAction<UnityEngine.Object> action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddDisableOtherCheckmarkListener_Public_Virtual_Final_New_Void_UnityAction_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191178, XrefRangeEnd = 191181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveDisableOtherCheckmarkListener(UnityAction<UnityEngine.Object> action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveDisableOtherCheckmarkListener_Public_Virtual_Final_New_Void_UnityAction_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191181, XrefRangeEnd = 191184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InvokeDisableOtherCheckmarkListener(UnityEngine.Object obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeDisableOtherCheckmarkListener_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191184, XrefRangeEnd = 191185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPaintType(PaintType paintType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&paintType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPaintType_Public_Virtual_Final_New_Void_PaintType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191185, XrefRangeEnd = 191188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RestoreSelectedColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RestoreSelectedColor_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191188, XrefRangeEnd = 191189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateColor(Color32 color, bool customColor = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&color);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &customColor;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateColor_Public_Virtual_Final_New_Void_Color32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191189, XrefRangeEnd = 191191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SubmitCurrentColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SubmitCurrentColor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe PaintshopType GetPaintshopType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPaintshopType_Public_Virtual_Final_New_PaintshopType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(PaintshopType*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool HandleInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleInput_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe PaintshopState GetPaintshopState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPaintshopState_Public_Virtual_Final_New_PaintshopState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(PaintshopState*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe void SetPaintshopState(PaintshopState state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&state);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPaintshopState_Public_Virtual_Final_New_Void_PaintshopState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191191, XrefRangeEnd = 191199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Paint()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Paint>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Paint()
	{
		Il2CppClassPointerStore<Paint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Salon", "Paint");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Paint>.NativeClassPtr);
		NativeFieldInfoPtr_colorPalette = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paint>.NativeClassPtr, "colorPalette");
		NativeFieldInfoPtr_configurator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paint>.NativeClassPtr, "configurator");
		NativeFieldInfoPtr_isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paint>.NativeClassPtr, "isActive");
		NativeFieldInfoPtr_DisableOtherCheckmark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paint>.NativeClassPtr, "DisableOtherCheckmark");
		NativeFieldInfoPtr_paintshopState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paint>.NativeClassPtr, "paintshopState");
		NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paint>.NativeClassPtr, 100677440);
		NativeMethodInfoPtr_Show_Public_Void_ArrayOf_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paint>.NativeClassPtr, 100677441);
		NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paint>.NativeClassPtr, 100677442);
		NativeMethodInfoPtr_SelectFirstColor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paint>.NativeClassPtr, 100677443);
		NativeMethodInfoPtr_AddDisableOtherCheckmarkListener_Public_Virtual_Final_New_Void_UnityAction_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paint>.NativeClassPtr, 100677444);
		NativeMethodInfoPtr_RemoveDisableOtherCheckmarkListener_Public_Virtual_Final_New_Void_UnityAction_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paint>.NativeClassPtr, 100677445);
		NativeMethodInfoPtr_InvokeDisableOtherCheckmarkListener_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paint>.NativeClassPtr, 100677446);
		NativeMethodInfoPtr_SetPaintType_Public_Virtual_Final_New_Void_PaintType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paint>.NativeClassPtr, 100677447);
		NativeMethodInfoPtr_RestoreSelectedColor_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paint>.NativeClassPtr, 100677448);
		NativeMethodInfoPtr_UpdateColor_Public_Virtual_Final_New_Void_Color32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paint>.NativeClassPtr, 100677449);
		NativeMethodInfoPtr_SubmitCurrentColor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paint>.NativeClassPtr, 100677450);
		NativeMethodInfoPtr_GetPaintshopType_Public_Virtual_Final_New_PaintshopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paint>.NativeClassPtr, 100677451);
		NativeMethodInfoPtr_HandleInput_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paint>.NativeClassPtr, 100677452);
		NativeMethodInfoPtr_GetPaintshopState_Public_Virtual_Final_New_PaintshopState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paint>.NativeClassPtr, 100677453);
		NativeMethodInfoPtr_SetPaintshopState_Public_Virtual_Final_New_Void_PaintshopState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paint>.NativeClassPtr, 100677454);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paint>.NativeClassPtr, 100677455);
	}

	public Paint(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
