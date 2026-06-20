using System;
using System.Runtime.CompilerServices;
using CMS.Managers;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class ToolsMoveManager : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Welder;

	private static readonly System.IntPtr NativeFieldInfoPtr_welderDefaultPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_InteriorDetailingToolkit;

	private static readonly System.IntPtr NativeFieldInfoPtr_interiorDetailingToolkitDefaultPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_Oilbin;

	private static readonly System.IntPtr NativeFieldInfoPtr_oilbinDefaultPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_EngineCrane;

	private static readonly System.IntPtr NativeFieldInfoPtr_engineCraneDefaultPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_engineCraneDefaultRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_HeadlampAlignmentSystem;

	private static readonly System.IntPtr NativeFieldInfoPtr_headlampAlignmentSystemDefaultPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_WindowTintingToolkit;

	private static readonly System.IntPtr NativeFieldInfoPtr_windowTintingToolkitDefaultPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_windowTintingToolkitDefaultRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_CarWashLogic;

	private static readonly System.IntPtr NativeFieldInfoPtr_WelderLogic;

	private static readonly System.IntPtr NativeFieldInfoPtr_InteriorDetailingToolkitLogic;

	private static readonly System.IntPtr NativeFieldInfoPtr_WindowTintManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_instance;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTool_Public_Transform_IOSpecialType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetConnectedCarLoader_Public_CarLoader_IOSpecialType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetOnDefaultPosition_Public_Void_IOSpecialType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsOnDefaultPosition_Public_Boolean_IOSpecialType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanMove_Public_Boolean_IOSpecialType_CarPlace_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveTo_Public_Void_IOSpecialType_CarPlace_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanUseEquipment_Public_Boolean_IOSpecialType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Use_Public_Void_IOSpecialType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseInteriorDetailingToolkitStationary_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_ToolsMoveManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr));

	public unsafe Transform Welder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Welder);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Welder), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector3 welderDefaultPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_welderDefaultPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_welderDefaultPosition)) = vector;
		}
	}

	public unsafe Transform InteriorDetailingToolkit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InteriorDetailingToolkit);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InteriorDetailingToolkit), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector3 interiorDetailingToolkitDefaultPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interiorDetailingToolkitDefaultPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interiorDetailingToolkitDefaultPosition)) = vector;
		}
	}

	public unsafe Transform Oilbin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Oilbin);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Oilbin), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector3 oilbinDefaultPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oilbinDefaultPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oilbinDefaultPosition)) = vector;
		}
	}

	public unsafe Transform EngineCrane
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EngineCrane);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EngineCrane), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector3 engineCraneDefaultPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineCraneDefaultPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineCraneDefaultPosition)) = vector;
		}
	}

	public unsafe Vector3 engineCraneDefaultRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineCraneDefaultRotation);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineCraneDefaultRotation)) = vector;
		}
	}

	public unsafe Transform HeadlampAlignmentSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HeadlampAlignmentSystem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HeadlampAlignmentSystem), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector3 headlampAlignmentSystemDefaultPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headlampAlignmentSystemDefaultPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headlampAlignmentSystemDefaultPosition)) = vector;
		}
	}

	public unsafe Transform WindowTintingToolkit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WindowTintingToolkit);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WindowTintingToolkit), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector3 windowTintingToolkitDefaultPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowTintingToolkitDefaultPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowTintingToolkitDefaultPosition)) = vector;
		}
	}

	public unsafe Vector3 windowTintingToolkitDefaultRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowTintingToolkitDefaultRotation);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowTintingToolkitDefaultRotation)) = vector;
		}
	}

	public unsafe CarWashLogic CarWashLogic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarWashLogic);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CarWashLogic(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarWashLogic), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe WelderLogic WelderLogic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WelderLogic);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new WelderLogic(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WelderLogic), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InteriorDetailingToolkitLogic InteriorDetailingToolkitLogic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InteriorDetailingToolkitLogic);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InteriorDetailingToolkitLogic(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InteriorDetailingToolkitLogic), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe WindowTintManager WindowTintManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WindowTintManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new WindowTintManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WindowTintManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static ToolsMoveManager m_instance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_instance, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new ToolsMoveManager(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63638, XrefRangeEnd = 63668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe Transform GetTool(IOSpecialType tool)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tool);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTool_Public_Transform_IOSpecialType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 63682, RefRangeEnd = 63687, XrefRangeStart = 63668, XrefRangeEnd = 63682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CarLoader GetConnectedCarLoader(IOSpecialType tool)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tool);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetConnectedCarLoader_Public_CarLoader_IOSpecialType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new CarLoader(intPtr) : null;
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 63720, RefRangeEnd = 63733, XrefRangeStart = 63687, XrefRangeEnd = 63720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetOnDefaultPosition(IOSpecialType tool)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tool);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetOnDefaultPosition_Public_Void_IOSpecialType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63733, XrefRangeEnd = 63747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsOnDefaultPosition(IOSpecialType tool)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tool);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsOnDefaultPosition_Public_Boolean_IOSpecialType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 63752, RefRangeEnd = 63754, XrefRangeStart = 63747, XrefRangeEnd = 63752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanMove(IOSpecialType tool, CarPlace place)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&tool);
		*(CarPlace**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &place;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanMove_Public_Boolean_IOSpecialType_CarPlace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 63974, RefRangeEnd = 63984, XrefRangeStart = 63754, XrefRangeEnd = 63974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveTo(IOSpecialType tool, CarPlace place, bool playSound = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&tool);
		*(CarPlace**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &place;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &playSound;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveTo_Public_Void_IOSpecialType_CarPlace_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 63996, RefRangeEnd = 63999, XrefRangeStart = 63984, XrefRangeEnd = 63996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanUseEquipment(IOSpecialType tool)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tool);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanUseEquipment_Public_Boolean_IOSpecialType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 64019, RefRangeEnd = 64022, XrefRangeStart = 63999, XrefRangeEnd = 64019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Use(IOSpecialType tool)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tool);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Use_Public_Void_IOSpecialType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 64052, RefRangeEnd = 64053, XrefRangeStart = 64022, XrefRangeEnd = 64052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UseInteriorDetailingToolkitStationary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseInteriorDetailingToolkitStationary_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(34)]
	[CachedScanResults(RefRangeStart = 64081, RefRangeEnd = 64115, XrefRangeStart = 64053, XrefRangeEnd = 64081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ToolsMoveManager Get()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Static_ToolsMoveManager_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new ToolsMoveManager(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64115, XrefRangeEnd = 64138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe ToolsMoveManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ToolsMoveManager()
	{
		Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "ToolsMoveManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr);
		NativeFieldInfoPtr_Welder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, "Welder");
		NativeFieldInfoPtr_welderDefaultPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, "welderDefaultPosition");
		NativeFieldInfoPtr_InteriorDetailingToolkit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, "InteriorDetailingToolkit");
		NativeFieldInfoPtr_interiorDetailingToolkitDefaultPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, "interiorDetailingToolkitDefaultPosition");
		NativeFieldInfoPtr_Oilbin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, "Oilbin");
		NativeFieldInfoPtr_oilbinDefaultPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, "oilbinDefaultPosition");
		NativeFieldInfoPtr_EngineCrane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, "EngineCrane");
		NativeFieldInfoPtr_engineCraneDefaultPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, "engineCraneDefaultPosition");
		NativeFieldInfoPtr_engineCraneDefaultRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, "engineCraneDefaultRotation");
		NativeFieldInfoPtr_HeadlampAlignmentSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, "HeadlampAlignmentSystem");
		NativeFieldInfoPtr_headlampAlignmentSystemDefaultPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, "headlampAlignmentSystemDefaultPosition");
		NativeFieldInfoPtr_WindowTintingToolkit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, "WindowTintingToolkit");
		NativeFieldInfoPtr_windowTintingToolkitDefaultPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, "windowTintingToolkitDefaultPosition");
		NativeFieldInfoPtr_windowTintingToolkitDefaultRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, "windowTintingToolkitDefaultRotation");
		NativeFieldInfoPtr_CarWashLogic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, "CarWashLogic");
		NativeFieldInfoPtr_WelderLogic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, "WelderLogic");
		NativeFieldInfoPtr_InteriorDetailingToolkitLogic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, "InteriorDetailingToolkitLogic");
		NativeFieldInfoPtr_WindowTintManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, "WindowTintManager");
		NativeFieldInfoPtr_m_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, "m_instance");
		NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, 100667145);
		NativeMethodInfoPtr_GetTool_Public_Transform_IOSpecialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, 100667146);
		NativeMethodInfoPtr_GetConnectedCarLoader_Public_CarLoader_IOSpecialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, 100667147);
		NativeMethodInfoPtr_SetOnDefaultPosition_Public_Void_IOSpecialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, 100667148);
		NativeMethodInfoPtr_IsOnDefaultPosition_Public_Boolean_IOSpecialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, 100667149);
		NativeMethodInfoPtr_CanMove_Public_Boolean_IOSpecialType_CarPlace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, 100667150);
		NativeMethodInfoPtr_MoveTo_Public_Void_IOSpecialType_CarPlace_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, 100667151);
		NativeMethodInfoPtr_CanUseEquipment_Public_Boolean_IOSpecialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, 100667152);
		NativeMethodInfoPtr_Use_Public_Void_IOSpecialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, 100667153);
		NativeMethodInfoPtr_UseInteriorDetailingToolkitStationary_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, 100667154);
		NativeMethodInfoPtr_Get_Public_Static_ToolsMoveManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, 100667155);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, 100667156);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolsMoveManager>.NativeClassPtr, 100667157);
	}

	public ToolsMoveManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
