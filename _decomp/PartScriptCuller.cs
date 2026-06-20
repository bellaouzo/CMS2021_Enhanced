using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

[System.Serializable]
public class PartScriptCuller : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_MAXCULLLEVELS;

	private static readonly System.IntPtr NativeFieldInfoPtr_frameInterval;

	private static readonly System.IntPtr NativeFieldInfoPtr_cullDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_mountsCullDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_cam;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoInitialize;

	private static readonly System.IntPtr NativeFieldInfoPtr_cullableParts;

	private static readonly System.IntPtr NativeFieldInfoPtr_cullableMounts;

	private static readonly System.IntPtr NativeFieldInfoPtr_distance;

	private static readonly System.IntPtr NativeFieldInfoPtr_showState;

	private static readonly System.IntPtr NativeFieldInfoPtr_initialized;

	private static readonly System.IntPtr NativeFieldInfoPtr_frameOffset;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMainCamera_Private_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CollectComponents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reinit_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitAndSetLowestQuality_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSettings_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCullDataBasedOnSettings_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMountsCullingDistance_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMountsLODLevel_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeState_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateDistance_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pause_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CullAll_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Resume_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr));

	public unsafe static int MAXCULLLEVELS
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAXCULLLEVELS, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAXCULLLEVELS, &num);
		}
	}

	public unsafe static int frameInterval
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_frameInterval, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_frameInterval, &num);
		}
	}

	public unsafe Il2CppStructArray<float> cullDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullDistance);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullDistance), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float mountsCullDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mountsCullDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mountsCullDistance)) = num;
		}
	}

	public unsafe Camera cam
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cam);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Camera(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cam), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool autoInitialize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoInitialize);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoInitialize)) = flag;
		}
	}

	public unsafe Il2CppReferenceArray<List<Renderer>> cullableParts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullableParts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<List<Renderer>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullableParts), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<LODSystem> cullableMounts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullableMounts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<LODSystem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullableMounts), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float distance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distance)) = num;
		}
	}

	public unsafe Il2CppStructArray<bool> showState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showState);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<bool>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showState), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool initialized
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initialized);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initialized)) = flag;
		}
	}

	public unsafe int frameOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameOffset);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameOffset)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74149, XrefRangeEnd = 74152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 74166, RefRangeEnd = 74169, XrefRangeStart = 74152, XrefRangeEnd = 74166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Camera GetMainCamera()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMainCamera_Private_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Camera(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 74185, RefRangeEnd = 74186, XrefRangeStart = 74169, XrefRangeEnd = 74185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 74224, RefRangeEnd = 74228, XrefRangeStart = 74186, XrefRangeEnd = 74224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CollectComponents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CollectComponents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74228, XrefRangeEnd = 74230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reinit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reinit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 74250, RefRangeEnd = 74254, XrefRangeStart = 74230, XrefRangeEnd = 74250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 74280, RefRangeEnd = 74282, XrefRangeStart = 74254, XrefRangeEnd = 74280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitAndSetLowestQuality()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitAndSetLowestQuality_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 74289, RefRangeEnd = 74291, XrefRangeStart = 74282, XrefRangeEnd = 74289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 74299, RefRangeEnd = 74301, XrefRangeStart = 74291, XrefRangeEnd = 74299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCullDataBasedOnSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCullDataBasedOnSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 74318, RefRangeEnd = 74320, XrefRangeStart = 74301, XrefRangeEnd = 74318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMountsCullingDistance()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMountsCullingDistance_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 74339, RefRangeEnd = 74345, XrefRangeStart = 74320, XrefRangeEnd = 74339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMountsLODLevel(int newLodLevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newLodLevel);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMountsLODLevel_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 74368, RefRangeEnd = 74372, XrefRangeStart = 74345, XrefRangeEnd = 74368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeState(int no)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&no);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeState_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74372, XrefRangeEnd = 74382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalculateDistance()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateDistance_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74382, XrefRangeEnd = 74395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 74403, RefRangeEnd = 74407, XrefRangeStart = 74395, XrefRangeEnd = 74403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pause()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 74415, RefRangeEnd = 74416, XrefRangeStart = 74407, XrefRangeEnd = 74415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CullAll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CullAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 74420, RefRangeEnd = 74421, XrefRangeStart = 74416, XrefRangeEnd = 74420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Resume()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Resume_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74421, XrefRangeEnd = 74439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PartScriptCuller()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PartScriptCuller()
	{
		Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "PartScriptCuller");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr);
		NativeFieldInfoPtr_MAXCULLLEVELS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr, "MAXCULLLEVELS");
		NativeFieldInfoPtr_frameInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr, "frameInterval");
		NativeFieldInfoPtr_cullDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr, "cullDistance");
		NativeFieldInfoPtr_mountsCullDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr, "mountsCullDistance");
		NativeFieldInfoPtr_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr, "cam");
		NativeFieldInfoPtr_autoInitialize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr, "autoInitialize");
		NativeFieldInfoPtr_cullableParts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr, "cullableParts");
		NativeFieldInfoPtr_cullableMounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr, "cullableMounts");
		NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr, "distance");
		NativeFieldInfoPtr_showState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr, "showState");
		NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr, "initialized");
		NativeFieldInfoPtr_frameOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr, "frameOffset");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr, 100667626);
		NativeMethodInfoPtr_GetMainCamera_Private_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr, 100667627);
		NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr, 100667628);
		NativeMethodInfoPtr_CollectComponents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr, 100667629);
		NativeMethodInfoPtr_Reinit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr, 100667630);
		NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr, 100667631);
		NativeMethodInfoPtr_InitAndSetLowestQuality_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr, 100667632);
		NativeMethodInfoPtr_UpdateSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr, 100667633);
		NativeMethodInfoPtr_SetCullDataBasedOnSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr, 100667634);
		NativeMethodInfoPtr_SetMountsCullingDistance_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr, 100667635);
		NativeMethodInfoPtr_SetMountsLODLevel_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr, 100667636);
		NativeMethodInfoPtr_ChangeState_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr, 100667637);
		NativeMethodInfoPtr_CalculateDistance_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr, 100667638);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr, 100667639);
		NativeMethodInfoPtr_Pause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr, 100667640);
		NativeMethodInfoPtr_CullAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr, 100667641);
		NativeMethodInfoPtr_Resume_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr, 100667642);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartScriptCuller>.NativeClassPtr, 100667643);
	}

	public PartScriptCuller(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
