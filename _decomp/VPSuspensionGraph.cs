using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using VehiclePhysics;

public class VPSuspensionGraph : VehicleBehaviour
{
	public enum Mode
	{
		TotalForce,
		SpringOnly,
		DamperOnly,
		// error: nested types are not permitted in C#.
		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Mode>.NativeClassPtr));
		,
		// error: nested types are not permitted in C#.
		static Mode()
		{
			Il2CppClassPointerStore<Mode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, "Mode");
		}

	}

	private static readonly System.IntPtr NativeFieldInfoPtr_wheel;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_manualForceRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_manualDepthRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_negativeRangeFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_color;

	private static readonly System.IntPtr NativeFieldInfoPtr_clampedColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_mode;

	private static readonly System.IntPtr NativeFieldInfoPtr_width;

	private static readonly System.IntPtr NativeFieldInfoPtr_height;

	private static readonly System.IntPtr NativeFieldInfoPtr_rect;

	private static readonly System.IntPtr NativeFieldInfoPtr_gridX;

	private static readonly System.IntPtr NativeFieldInfoPtr_gridY;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoClearBackground;

	private static readonly System.IntPtr NativeFieldInfoPtr_positionX;

	private static readonly System.IntPtr NativeFieldInfoPtr_positionY;

	private static readonly System.IntPtr NativeFieldInfoPtr_font;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_canvas;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_style;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_text;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_lastGridX;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_lastGridY;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSuspensionLimits_Private_Void_WheelState_byref_Single_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawCanvas_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawCanvasBackground_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_canvas_Public_get_TextureCanvas_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCanvas_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCanvas_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupText_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr));

	public unsafe int wheel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheel)) = num;
		}
	}

	public unsafe bool autoRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoRange);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoRange)) = flag;
		}
	}

	public unsafe float manualForceRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_manualForceRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_manualForceRange)) = num;
		}
	}

	public unsafe float manualDepthRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_manualDepthRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_manualDepthRange)) = num;
		}
	}

	public unsafe float negativeRangeFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_negativeRangeFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_negativeRangeFactor)) = num;
		}
	}

	public unsafe Color color
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color)) = color;
		}
	}

	public unsafe Color clampedColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clampedColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clampedColor)) = color;
		}
	}

	public unsafe Mode mode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode);
			return *(Mode*)num;
		}
		set
		{
			*(Mode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode)) = mode;
		}
	}

	public unsafe int width
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_width);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_width)) = num;
		}
	}

	public unsafe int height
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_height);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_height)) = num;
		}
	}

	public unsafe Rect rect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rect);
			return *(Rect*)num;
		}
		set
		{
			*(Rect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rect)) = rect;
		}
	}

	public unsafe float gridX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gridX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gridX)) = num;
		}
	}

	public unsafe float gridY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gridY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gridY)) = num;
		}
	}

	public unsafe bool autoClearBackground
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoClearBackground);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoClearBackground)) = flag;
		}
	}

	public unsafe int positionX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionX);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionX)) = num;
		}
	}

	public unsafe int positionY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionY);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionY)) = num;
		}
	}

	public unsafe Font font
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_font);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Font(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_font), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TextureCanvas m_canvas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_canvas);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new TextureCanvas(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_canvas), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GUIStyle m_style
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_style);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GUIStyle(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_style), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe string m_text
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_text);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_text), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe float m_lastGridX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastGridX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastGridX)) = num;
		}
	}

	public unsafe float m_lastGridY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastGridY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastGridY)) = num;
		}
	}

	public unsafe TextureCanvas canvas
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_canvas_Public_get_TextureCanvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new TextureCanvas(intPtr) : null;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113539, XrefRangeEnd = 113540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnEnableVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113540, XrefRangeEnd = 113546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void FixedUpdateVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void GetSuspensionLimits(VehicleBase.WheelState wheelState, out float maxContactDepth, out float maxForce)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(wheelState);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref maxContactDepth);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref maxForce);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSuspensionLimits_Private_Void_WheelState_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 113556, RefRangeEnd = 113558, XrefRangeStart = 113546, XrefRangeEnd = 113556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDrawCanvas()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDrawCanvas_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113558, XrefRangeEnd = 113567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDrawCanvasBackground()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDrawCanvasBackground_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113567, XrefRangeEnd = 113574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnValidate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void UpdateCanvas()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCanvas_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 113604, RefRangeEnd = 113608, XrefRangeStart = 113574, XrefRangeEnd = 113604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupCanvas()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCanvas_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void SetupText()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113608, XrefRangeEnd = 113621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113621, XrefRangeEnd = 113630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPSuspensionGraph()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPSuspensionGraph()
	{
		Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPSuspensionGraph");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr);
		NativeFieldInfoPtr_wheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, "wheel");
		NativeFieldInfoPtr_autoRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, "autoRange");
		NativeFieldInfoPtr_manualForceRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, "manualForceRange");
		NativeFieldInfoPtr_manualDepthRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, "manualDepthRange");
		NativeFieldInfoPtr_negativeRangeFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, "negativeRangeFactor");
		NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, "color");
		NativeFieldInfoPtr_clampedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, "clampedColor");
		NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, "mode");
		NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, "width");
		NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, "height");
		NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, "rect");
		NativeFieldInfoPtr_gridX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, "gridX");
		NativeFieldInfoPtr_gridY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, "gridY");
		NativeFieldInfoPtr_autoClearBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, "autoClearBackground");
		NativeFieldInfoPtr_positionX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, "positionX");
		NativeFieldInfoPtr_positionY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, "positionY");
		NativeFieldInfoPtr_font = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, "font");
		NativeFieldInfoPtr_m_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, "m_canvas");
		NativeFieldInfoPtr_m_style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, "m_style");
		NativeFieldInfoPtr_m_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, "m_text");
		NativeFieldInfoPtr_m_lastGridX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, "m_lastGridX");
		NativeFieldInfoPtr_m_lastGridY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, "m_lastGridY");
		NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, 100670462);
		NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, 100670463);
		NativeMethodInfoPtr_GetSuspensionLimits_Private_Void_WheelState_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, 100670464);
		NativeMethodInfoPtr_OnDrawCanvas_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, 100670465);
		NativeMethodInfoPtr_OnDrawCanvasBackground_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, 100670466);
		NativeMethodInfoPtr_get_canvas_Public_get_TextureCanvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, 100670467);
		NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, 100670468);
		NativeMethodInfoPtr_UpdateCanvas_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, 100670469);
		NativeMethodInfoPtr_SetupCanvas_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, 100670470);
		NativeMethodInfoPtr_SetupText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, 100670471);
		NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, 100670472);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPSuspensionGraph>.NativeClassPtr, 100670473);
	}

	public VPSuspensionGraph(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
