using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.DevTools.Components;

public class FPSDisplay : DebugMenuComponent
{
	private static readonly System.IntPtr NativeFieldInfoPtr_updateInterval;

	private static readonly System.IntPtr NativeFieldInfoPtr_style;

	private static readonly System.IntPtr NativeFieldInfoPtr_rect;

	private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedGreen;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedYellow;

	private static readonly System.IntPtr NativeFieldInfoPtr_cachedRed;

	private static readonly System.IntPtr NativeFieldInfoPtr_accumulatedFPS;

	private static readonly System.IntPtr NativeFieldInfoPtr_frames;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentFPS;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentMS;

	private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Draw_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTextColorForFPS_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<FPSDisplay>.NativeClassPtr));

	public unsafe static float updateInterval
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_updateInterval, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_updateInterval, &num);
		}
	}

	public unsafe GUIStyle style
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_style);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GUIStyle(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_style), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe float deltaTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaTime)) = num;
		}
	}

	public unsafe Color cachedGreen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedGreen);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedGreen)) = color;
		}
	}

	public unsafe Color cachedYellow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedYellow);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedYellow)) = color;
		}
	}

	public unsafe Color cachedRed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedRed);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedRed)) = color;
		}
	}

	public unsafe float accumulatedFPS
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accumulatedFPS);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accumulatedFPS)) = num;
		}
	}

	public unsafe int frames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frames);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frames)) = num;
		}
	}

	public unsafe float timeLeft
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeLeft);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeLeft)) = num;
		}
	}

	public unsafe float currentFPS
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentFPS);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentFPS)) = num;
		}
	}

	public unsafe float currentMS
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentMS);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentMS)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217645, XrefRangeEnd = 217660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Prepare()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Prepare_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe void Cleanup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217660, XrefRangeEnd = 217664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217664, XrefRangeEnd = 217688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Draw()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Draw_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217688, XrefRangeEnd = 217699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTextColorForFPS(float fps)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&fps);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTextColorForFPS_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe FPSDisplay()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FPSDisplay>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static FPSDisplay()
	{
		Il2CppClassPointerStore<FPSDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.DevTools.Components", "FPSDisplay");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FPSDisplay>.NativeClassPtr);
		NativeFieldInfoPtr_updateInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSDisplay>.NativeClassPtr, "updateInterval");
		NativeFieldInfoPtr_style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSDisplay>.NativeClassPtr, "style");
		NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSDisplay>.NativeClassPtr, "rect");
		NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSDisplay>.NativeClassPtr, "deltaTime");
		NativeFieldInfoPtr_cachedGreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSDisplay>.NativeClassPtr, "cachedGreen");
		NativeFieldInfoPtr_cachedYellow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSDisplay>.NativeClassPtr, "cachedYellow");
		NativeFieldInfoPtr_cachedRed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSDisplay>.NativeClassPtr, "cachedRed");
		NativeFieldInfoPtr_accumulatedFPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSDisplay>.NativeClassPtr, "accumulatedFPS");
		NativeFieldInfoPtr_frames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSDisplay>.NativeClassPtr, "frames");
		NativeFieldInfoPtr_timeLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSDisplay>.NativeClassPtr, "timeLeft");
		NativeFieldInfoPtr_currentFPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSDisplay>.NativeClassPtr, "currentFPS");
		NativeFieldInfoPtr_currentMS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPSDisplay>.NativeClassPtr, "currentMS");
		NativeMethodInfoPtr_Prepare_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSDisplay>.NativeClassPtr, 100679705);
		NativeMethodInfoPtr_Cleanup_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSDisplay>.NativeClassPtr, 100679706);
		NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSDisplay>.NativeClassPtr, 100679707);
		NativeMethodInfoPtr_Draw_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSDisplay>.NativeClassPtr, 100679708);
		NativeMethodInfoPtr_SetTextColorForFPS_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSDisplay>.NativeClassPtr, 100679709);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPSDisplay>.NativeClassPtr, 100679710);
	}

	public FPSDisplay(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
