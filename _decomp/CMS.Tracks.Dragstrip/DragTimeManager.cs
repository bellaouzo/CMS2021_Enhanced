using System;
using System.Runtime.CompilerServices;
using CMS.Containers;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Diagnostics;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Tracks.Dragstrip;

public class DragTimeManager : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_timer;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerStats;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerSpeeds;

	private static readonly System.IntPtr NativeFieldInfoPtr_opponentStats;

	private static readonly System.IntPtr NativeFieldInfoPtr_opponentSpeeds;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerVehicleController;

	private static readonly System.IntPtr NativeFieldInfoPtr_opponentVehicleController;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnRegisterTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_canRegisterPlayerSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_canRegisterOpponentSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_canRegisterPlayerStats;

	private static readonly System.IntPtr NativeFieldInfoPtr_canRegisterOpponentStats;

	private static readonly System.IntPtr NativeFieldInfoPtr_stage1Speed;

	private static readonly System.IntPtr NativeFieldInfoPtr_stage2Speed;

	private static readonly System.IntPtr NativeFieldInfoPtr_stage3Speed;

	private static readonly System.IntPtr NativeFieldInfoPtr_stage4Speed;

	private static readonly System.IntPtr NativeFieldInfoPtr_metricUnits;

	private static readonly System.IntPtr NativeFieldInfoPtr_instance;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unpause_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pause_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopRegisteringPlayerStats_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopRegisteringOpponentStats_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterReactionTime_Public_Void_Int64_DragMember_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterTime_Public_Void_DragCheckpointType_DragMember_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TimeIsRegistered_Private_Boolean_DragCheckpointType_DragMember_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerStats_Public_List_1_DragTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOpponentStats_Public_List_1_DragTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupForUnits_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVehicleControllers_Public_Void_VPVehicleController_VPVehicleController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpeed_Private_Single_DragMember_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSpeeds_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSpeed_Private_Void_Single_Single_DragSpeedType_DragMember_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpeedIsRegistered_Private_Boolean_DragSpeedType_DragMember_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerSpeeds_Public_List_1_DragSpeed_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOpponentSpeeds_Public_List_1_DragSpeed_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_DragTimeManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr));

	public unsafe Stopwatch timer
	{
		get
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr == (System.IntPtr)0) ? ((Stopwatch)null) : new Stopwatch(intPtr);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe List<DragTime> playerStats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerStats);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<DragTime>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerStats), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<DragSpeed> playerSpeeds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerSpeeds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<DragSpeed>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerSpeeds), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<DragTime> opponentStats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opponentStats);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<DragTime>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opponentStats), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<DragSpeed> opponentSpeeds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opponentSpeeds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<DragSpeed>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opponentSpeeds), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VPVehicleController playerVehicleController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerVehicleController);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPVehicleController(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerVehicleController), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VPVehicleController opponentVehicleController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opponentVehicleController);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPVehicleController(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opponentVehicleController), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Action<DragCheckpointType, DragMember> OnRegisterTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnRegisterTime);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<DragCheckpointType, DragMember>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnRegisterTime), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool canRegisterPlayerSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canRegisterPlayerSpeed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canRegisterPlayerSpeed)) = flag;
		}
	}

	public unsafe bool canRegisterOpponentSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canRegisterOpponentSpeed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canRegisterOpponentSpeed)) = flag;
		}
	}

	public unsafe bool canRegisterPlayerStats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canRegisterPlayerStats);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canRegisterPlayerStats)) = flag;
		}
	}

	public unsafe bool canRegisterOpponentStats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canRegisterOpponentStats);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canRegisterOpponentStats)) = flag;
		}
	}

	public unsafe float stage1Speed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage1Speed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage1Speed)) = num;
		}
	}

	public unsafe float stage2Speed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage2Speed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage2Speed)) = num;
		}
	}

	public unsafe float stage3Speed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage3Speed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage3Speed)) = num;
		}
	}

	public unsafe float stage4Speed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage4Speed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage4Speed)) = num;
		}
	}

	public unsafe bool metricUnits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_metricUnits);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_metricUnits)) = flag;
		}
	}

	public unsafe static DragTimeManager instance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_instance, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new DragTimeManager(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static DragTimeManager Instance
	{
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 134367, RefRangeEnd = 134389, XrefRangeStart = 134363, XrefRangeEnd = 134367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_DragTimeManager_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new DragTimeManager(intPtr) : null;
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 134243, RefRangeEnd = 134245, XrefRangeStart = 134201, XrefRangeEnd = 134243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134245, XrefRangeEnd = 134249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Unpause()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unpause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134249, XrefRangeEnd = 134250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pause()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134250, XrefRangeEnd = 134251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Stop()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void StopRegisteringPlayerStats()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopRegisteringPlayerStats_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void StopRegisteringOpponentStats()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopRegisteringOpponentStats_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134251, XrefRangeEnd = 134257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterReactionTime(long reactionTime, DragMember member)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&reactionTime);
		*(DragMember**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &member;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterReactionTime_Public_Void_Int64_DragMember_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 134281, RefRangeEnd = 134284, XrefRangeStart = 134257, XrefRangeEnd = 134281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterTime(DragCheckpointType type, DragMember member, bool logSpeed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&type);
		*(DragMember**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &member;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &logSpeed;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterTime_Public_Void_DragCheckpointType_DragMember_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134284, XrefRangeEnd = 134287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TimeIsRegistered(DragCheckpointType type, DragMember member)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(DragMember**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &member;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TimeIsRegistered_Private_Boolean_DragCheckpointType_DragMember_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe List<DragTime> GetPlayerStats()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPlayerStats_Public_List_1_DragTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<DragTime>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe List<DragTime> GetOpponentStats()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOpponentStats_Public_List_1_DragTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<DragTime>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134287, XrefRangeEnd = 134291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupForUnits()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupForUnits_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 134317, RefRangeEnd = 134319, XrefRangeStart = 134291, XrefRangeEnd = 134317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetVehicleControllers(VPVehicleController player, VPVehicleController opponent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(opponent);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVehicleControllers_Public_Void_VPVehicleController_VPVehicleController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134319, XrefRangeEnd = 134320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetSpeed(DragMember member)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&member);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpeed_Private_Single_DragMember_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 134333, RefRangeEnd = 134334, XrefRangeStart = 134320, XrefRangeEnd = 134333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSpeeds()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateSpeeds_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 134352, RefRangeEnd = 134360, XrefRangeStart = 134334, XrefRangeEnd = 134352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddSpeed(float speed, float targetSpeed, DragSpeedType speedType, DragMember member)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&speed);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetSpeed;
		*(DragSpeedType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &speedType;
		*(DragMember**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &member;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSpeed_Private_Void_Single_Single_DragSpeedType_DragMember_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134360, XrefRangeEnd = 134363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SpeedIsRegistered(DragSpeedType type, DragMember member)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(DragMember**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &member;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpeedIsRegistered_Private_Boolean_DragSpeedType_DragMember_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe List<DragSpeed> GetPlayerSpeeds()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPlayerSpeeds_Public_List_1_DragSpeed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<DragSpeed>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe List<DragSpeed> GetOpponentSpeeds()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOpponentSpeeds_Public_List_1_DragSpeed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<DragSpeed>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134389, XrefRangeEnd = 134391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Destroy()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Destroy_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe DragTimeManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DragTimeManager()
	{
		Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Tracks.Dragstrip", "DragTimeManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr);
		NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, "timer");
		NativeFieldInfoPtr_playerStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, "playerStats");
		NativeFieldInfoPtr_playerSpeeds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, "playerSpeeds");
		NativeFieldInfoPtr_opponentStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, "opponentStats");
		NativeFieldInfoPtr_opponentSpeeds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, "opponentSpeeds");
		NativeFieldInfoPtr_playerVehicleController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, "playerVehicleController");
		NativeFieldInfoPtr_opponentVehicleController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, "opponentVehicleController");
		NativeFieldInfoPtr_OnRegisterTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, "OnRegisterTime");
		NativeFieldInfoPtr_canRegisterPlayerSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, "canRegisterPlayerSpeed");
		NativeFieldInfoPtr_canRegisterOpponentSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, "canRegisterOpponentSpeed");
		NativeFieldInfoPtr_canRegisterPlayerStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, "canRegisterPlayerStats");
		NativeFieldInfoPtr_canRegisterOpponentStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, "canRegisterOpponentStats");
		NativeFieldInfoPtr_stage1Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, "stage1Speed");
		NativeFieldInfoPtr_stage2Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, "stage2Speed");
		NativeFieldInfoPtr_stage3Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, "stage3Speed");
		NativeFieldInfoPtr_stage4Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, "stage4Speed");
		NativeFieldInfoPtr_metricUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, "metricUnits");
		NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, "instance");
		NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, 100672201);
		NativeMethodInfoPtr_Unpause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, 100672202);
		NativeMethodInfoPtr_Pause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, 100672203);
		NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, 100672204);
		NativeMethodInfoPtr_StopRegisteringPlayerStats_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, 100672205);
		NativeMethodInfoPtr_StopRegisteringOpponentStats_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, 100672206);
		NativeMethodInfoPtr_RegisterReactionTime_Public_Void_Int64_DragMember_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, 100672207);
		NativeMethodInfoPtr_RegisterTime_Public_Void_DragCheckpointType_DragMember_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, 100672208);
		NativeMethodInfoPtr_TimeIsRegistered_Private_Boolean_DragCheckpointType_DragMember_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, 100672209);
		NativeMethodInfoPtr_GetPlayerStats_Public_List_1_DragTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, 100672210);
		NativeMethodInfoPtr_GetOpponentStats_Public_List_1_DragTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, 100672211);
		NativeMethodInfoPtr_SetupForUnits_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, 100672212);
		NativeMethodInfoPtr_SetVehicleControllers_Public_Void_VPVehicleController_VPVehicleController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, 100672213);
		NativeMethodInfoPtr_GetSpeed_Private_Single_DragMember_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, 100672214);
		NativeMethodInfoPtr_UpdateSpeeds_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, 100672215);
		NativeMethodInfoPtr_AddSpeed_Private_Void_Single_Single_DragSpeedType_DragMember_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, 100672216);
		NativeMethodInfoPtr_SpeedIsRegistered_Private_Boolean_DragSpeedType_DragMember_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, 100672217);
		NativeMethodInfoPtr_GetPlayerSpeeds_Public_List_1_DragSpeed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, 100672218);
		NativeMethodInfoPtr_GetOpponentSpeeds_Public_List_1_DragSpeed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, 100672219);
		NativeMethodInfoPtr_get_Instance_Public_Static_get_DragTimeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, 100672220);
		NativeMethodInfoPtr_Destroy_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, 100672221);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTimeManager>.NativeClassPtr, 100672222);
	}

	public DragTimeManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
