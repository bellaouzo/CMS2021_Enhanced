using System;
using System.Runtime.CompilerServices;
using CMS.DevTools.Components;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class DebugMenu : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_debugMenuConfig;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugFileItems;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPrepared;

	private static readonly System.IntPtr NativeFieldInfoPtr_idIsPrepared;

	private static readonly System.IntPtr NativeFieldInfoPtr_isActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentPage;

	private static readonly System.IntPtr NativeFieldInfoPtr_centeredStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_idPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugMenuID;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastScreenWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_WaitTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_upTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_downTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_memoryProfiler;

	private static readonly System.IntPtr NativeFieldInfoPtr_memoryProfilerActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_fpsDisplay;

	private static readonly System.IntPtr NativeFieldInfoPtr_fpsDisplayActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_rustmapProfiler;

	private static readonly System.IntPtr NativeFieldInfoPtr_rustmapProfilerActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_liveriesProfiler;

	private static readonly System.IntPtr NativeFieldInfoPtr_liveriesProfilerActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_canUseAdvancedFeatures;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawID_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr));

	public unsafe TextAsset debugMenuConfig
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugMenuConfig);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new TextAsset(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugMenuConfig), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<DebugFile> debugFileItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugFileItems);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<DebugFile>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugFileItems), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool isPrepared
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPrepared);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPrepared)) = flag;
		}
	}

	public unsafe bool idIsPrepared
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idIsPrepared);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idIsPrepared)) = flag;
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

	public unsafe MenuPage currentPage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentPage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new MenuPage(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentPage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GUIStyle centeredStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_centeredStyle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GUIStyle(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_centeredStyle), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Rect idPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idPosition);
			return *(Rect*)num;
		}
		set
		{
			*(Rect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idPosition)) = rect;
		}
	}

	public unsafe GUIContent debugMenuID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugMenuID);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GUIContent(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugMenuID), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int lastScreenWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastScreenWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastScreenWidth)) = num;
		}
	}

	public unsafe static float WaitTime
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WaitTime, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WaitTime, &num);
		}
	}

	public unsafe float leftTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftTimer)) = num;
		}
	}

	public unsafe float rightTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightTimer)) = num;
		}
	}

	public unsafe float upTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upTimer)) = num;
		}
	}

	public unsafe float downTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downTimer)) = num;
		}
	}

	public unsafe MemoryProfiler memoryProfiler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_memoryProfiler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new MemoryProfiler(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_memoryProfiler), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool memoryProfilerActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_memoryProfilerActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_memoryProfilerActive)) = flag;
		}
	}

	public unsafe CMS.DevTools.Components.FPSDisplay fpsDisplay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsDisplay);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CMS.DevTools.Components.FPSDisplay(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsDisplay), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool fpsDisplayActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsDisplayActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsDisplayActive)) = flag;
		}
	}

	public unsafe RustmapProfiler rustmapProfiler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rustmapProfiler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RustmapProfiler(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rustmapProfiler), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool rustmapProfilerActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rustmapProfilerActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rustmapProfilerActive)) = flag;
		}
	}

	public unsafe LiveriesProfiler liveriesProfiler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_liveriesProfiler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new LiveriesProfiler(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_liveriesProfiler), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool liveriesProfilerActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_liveriesProfilerActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_liveriesProfilerActive)) = flag;
		}
	}

	public unsafe bool canUseAdvancedFeatures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canUseAdvancedFeatures);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canUseAdvancedFeatures)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95298, XrefRangeEnd = 95303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95303, XrefRangeEnd = 95307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawID_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95307, XrefRangeEnd = 95310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DebugMenu()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DebugMenu()
	{
		Il2CppClassPointerStore<DebugMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "DebugMenu");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr);
		NativeFieldInfoPtr_debugMenuConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, "debugMenuConfig");
		NativeFieldInfoPtr_debugFileItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, "debugFileItems");
		NativeFieldInfoPtr_isPrepared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, "isPrepared");
		NativeFieldInfoPtr_idIsPrepared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, "idIsPrepared");
		NativeFieldInfoPtr_isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, "isActive");
		NativeFieldInfoPtr_currentPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, "currentPage");
		NativeFieldInfoPtr_centeredStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, "centeredStyle");
		NativeFieldInfoPtr_idPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, "idPosition");
		NativeFieldInfoPtr_debugMenuID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, "debugMenuID");
		NativeFieldInfoPtr_lastScreenWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, "lastScreenWidth");
		NativeFieldInfoPtr_WaitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, "WaitTime");
		NativeFieldInfoPtr_leftTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, "leftTimer");
		NativeFieldInfoPtr_rightTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, "rightTimer");
		NativeFieldInfoPtr_upTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, "upTimer");
		NativeFieldInfoPtr_downTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, "downTimer");
		NativeFieldInfoPtr_memoryProfiler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, "memoryProfiler");
		NativeFieldInfoPtr_memoryProfilerActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, "memoryProfilerActive");
		NativeFieldInfoPtr_fpsDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, "fpsDisplay");
		NativeFieldInfoPtr_fpsDisplayActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, "fpsDisplayActive");
		NativeFieldInfoPtr_rustmapProfiler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, "rustmapProfiler");
		NativeFieldInfoPtr_rustmapProfilerActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, "rustmapProfilerActive");
		NativeFieldInfoPtr_liveriesProfiler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, "liveriesProfiler");
		NativeFieldInfoPtr_liveriesProfilerActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, "liveriesProfilerActive");
		NativeFieldInfoPtr_canUseAdvancedFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, "canUseAdvancedFeatures");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, 100668823);
		NativeMethodInfoPtr_DrawID_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, 100668824);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugMenu>.NativeClassPtr, 100668825);
	}

	public DebugMenu(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
