using System;
using System.Runtime.CompilerServices;
using CMS.Containers;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Tracks.Dragstrip;

public class ChampionshipManager : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_playerMember;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerCarData;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerPI;

	private static readonly System.IntPtr NativeFieldInfoPtr_stage1MemberGroups;

	private static readonly System.IntPtr NativeFieldInfoPtr_stage2MemberGroups;

	private static readonly System.IntPtr NativeFieldInfoPtr_stage3MemberGroups;

	private static readonly System.IntPtr NativeFieldInfoPtr_stage4MemberGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_opponentsCars;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentStage;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastUID;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastGroupUID;

	private static readonly System.IntPtr NativeFieldInfoPtr_opponentNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_opponentSurnames;

	private static readonly System.IntPtr NativeFieldInfoPtr_allBets;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerPrize;

	private static readonly System.IntPtr NativeFieldInfoPtr_allDragstripCars;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerCarCopy;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentStage_Public_get_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AllBets_Public_get_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerPrize_Public_get_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConnectToUI_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCars_Public_Void_List_1_BasicCarForDragstrip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateWinnerInGroup_Public_Void_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerPrize_Public_Int32_DragClass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddToPlayerPrize_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetStage_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NextStage_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreparePlayerMember_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerCarData_Public_Nullable_1_NewCarData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareOpponents_Public_Void_DragClass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareChampionshipCar_Private_Void_byref_CarForDragstrip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOpponentCar_Public_CarForDragstrip_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareGroups_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInitialGroup_Private_Void_ArrayOf_ChampionshipMember_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillWinnersInNextGroup_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillGroups_Private_Void_byref_ArrayOf_ChampionshipMemberGroup_byref_ArrayOf_ChampionshipMemberGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CurrentGroupsHavePlayer_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GroupsHavePlayer_Private_Boolean_byref_ArrayOf_ChampionshipMemberGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateStage4Group_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGroupsForCurrentStage_Private_ArrayOf_ChampionshipMemberGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGroupsForStage_Private_ArrayOf_ChampionshipMemberGroup_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGroup_Public_ChampionshipMemberGroup_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNextGroup_Public_ChampionshipMemberGroup_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateAllBets_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllBetsInCurrentStage_Public_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWonBets_Public_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWonBetsInCurrentStage_Public_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayerWonInCurrentStage_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBetFromGroups_Private_UInt16_byref_ArrayOf_ChampionshipMemberGroup_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNewMember_Private_ChampionshipMember_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNewMemberGroup_Private_ChampionshipMemberGroup_ChampionshipMember_ChampionshipMember_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNewMemberUID_Private_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNewGroupUID_Private_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareNamesArrays_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearNamesArrays_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateName_Private_String_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr));

	public unsafe ChampionshipMember playerMember
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerMember);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ChampionshipMember(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerMember), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Nullable<NewCarData> playerCarData
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerCarData);
			return new Il2CppSystem.Nullable<NewCarData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<NewCarData>>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerCarData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<NewCarData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe float playerPI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerPI);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerPI)) = num;
		}
	}

	public unsafe Il2CppReferenceArray<ChampionshipMemberGroup> stage1MemberGroups
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage1MemberGroups);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<ChampionshipMemberGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage1MemberGroups), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<ChampionshipMemberGroup> stage2MemberGroups
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage2MemberGroups);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<ChampionshipMemberGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage2MemberGroups), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<ChampionshipMemberGroup> stage3MemberGroups
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage3MemberGroups);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<ChampionshipMemberGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage3MemberGroups), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ChampionshipMemberGroup stage4MemberGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage4MemberGroup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ChampionshipMemberGroup(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage4MemberGroup), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<ushort, CarForDragstrip> opponentsCars
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opponentsCars);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Dictionary<ushort, CarForDragstrip>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opponentsCars), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe byte currentStage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentStage);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentStage)) = b;
		}
	}

	public unsafe ushort lastUID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastUID);
			return *(ushort*)num;
		}
		set
		{
			*(ushort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastUID)) = num;
		}
	}

	public unsafe byte lastGroupUID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastGroupUID);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastGroupUID)) = b;
		}
	}

	public unsafe Il2CppStringArray opponentNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opponentNames);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStringArray(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opponentNames), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStringArray opponentSurnames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opponentSurnames);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStringArray(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opponentSurnames), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ushort allBets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allBets);
			return *(ushort*)num;
		}
		set
		{
			*(ushort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allBets)) = num;
		}
	}

	public unsafe ushort playerPrize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerPrize);
			return *(ushort*)num;
		}
		set
		{
			*(ushort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerPrize)) = num;
		}
	}

	public unsafe List<BasicCarForDragstrip> allDragstripCars
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allDragstripCars);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<BasicCarForDragstrip>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allDragstripCars), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CarForDragstrip playerCarCopy
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerCarCopy);
			return new CarForDragstrip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CarForDragstrip>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerCarCopy), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CarForDragstrip>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe byte CurrentStage
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentStage_Public_get_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(byte*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe ushort AllBets
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AllBets_Public_get_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(ushort*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe ushort PlayerPrize
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerPrize_Public_get_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(ushort*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132009, XrefRangeEnd = 132010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChampionshipManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe void Finalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 132029, RefRangeEnd = 132030, XrefRangeStart = 132010, XrefRangeEnd = 132029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConnectToUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConnectToUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetCars(List<BasicCarForDragstrip> cars)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cars);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCars_Public_Void_List_1_BasicCarForDragstrip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 132054, RefRangeEnd = 132059, XrefRangeStart = 132030, XrefRangeEnd = 132054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateWinnerInGroup(byte groupUID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&groupUID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateWinnerInGroup_Public_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132059, XrefRangeEnd = 132067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetPlayerPrize(DragClass dragClass)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dragClass);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPlayerPrize_Public_Int32_DragClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe void AddToPlayerPrize(int prize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&prize);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddToPlayerPrize_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void ResetStage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetStage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void NextStage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextStage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 132104, RefRangeEnd = 132105, XrefRangeStart = 132067, XrefRangeEnd = 132104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreparePlayerMember()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreparePlayerMember_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132105, XrefRangeEnd = 132111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Nullable<NewCarData> GetPlayerCarData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPlayerCarData_Public_Nullable_1_NewCarData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return new Il2CppSystem.Nullable<NewCarData>(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 132216, RefRangeEnd = 132217, XrefRangeStart = 132111, XrefRangeEnd = 132216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareOpponents(DragClass dragClass)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dragClass);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareOpponents_Public_Void_DragClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 132222, RefRangeEnd = 132223, XrefRangeStart = 132217, XrefRangeEnd = 132222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareChampionshipCar(ref CarForDragstrip randomCar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(randomCar);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareChampionshipCar_Private_Void_byref_CarForDragstrip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 132232, RefRangeEnd = 132237, XrefRangeStart = 132223, XrefRangeEnd = 132232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CarForDragstrip GetOpponentCar(ushort opponentUID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&opponentUID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOpponentCar_Public_CarForDragstrip_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return new CarForDragstrip(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 132247, RefRangeEnd = 132248, XrefRangeStart = 132237, XrefRangeEnd = 132247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareGroups()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareGroups_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 132259, RefRangeEnd = 132260, XrefRangeStart = 132248, XrefRangeEnd = 132259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateInitialGroup(Il2CppReferenceArray<ChampionshipMember> opponents)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(opponents);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInitialGroup_Private_Void_ArrayOf_ChampionshipMember_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 132265, RefRangeEnd = 132266, XrefRangeStart = 132260, XrefRangeEnd = 132265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FillWinnersInNextGroup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillWinnersInNextGroup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132266, XrefRangeEnd = 132277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FillGroups(ref Il2CppReferenceArray<ChampionshipMemberGroup> previousGroups, ref Il2CppReferenceArray<ChampionshipMemberGroup> newGroups)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(previousGroups);
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(newGroups);
		*(System.IntPtr**)num = &intPtr2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillGroups_Private_Void_byref_ArrayOf_ChampionshipMemberGroup_byref_ArrayOf_ChampionshipMemberGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr4 = intPtr;
		previousGroups = (Il2CppReferenceArray<ChampionshipMemberGroup>)(object)((intPtr4 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<T>(intPtr4));
		System.IntPtr intPtr5 = intPtr2;
		newGroups = (Il2CppReferenceArray<ChampionshipMemberGroup>)(object)((intPtr5 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<T>(intPtr5));
	}

	[CallerCount(0)]
	public unsafe bool CurrentGroupsHavePlayer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CurrentGroupsHavePlayer_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 132278, RefRangeEnd = 132279, XrefRangeStart = 132277, XrefRangeEnd = 132278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GroupsHavePlayer(ref Il2CppReferenceArray<ChampionshipMemberGroup> groups)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(groups);
		*ptr = (nint)(&intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GroupsHavePlayer_Private_Boolean_byref_ArrayOf_ChampionshipMemberGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr2 = intPtr;
		groups = (Il2CppReferenceArray<ChampionshipMemberGroup>)(object)((intPtr2 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<T>(intPtr2));
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132279, XrefRangeEnd = 132284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateStage4Group()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateStage4Group_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe Il2CppReferenceArray<ChampionshipMemberGroup> GetGroupsForCurrentStage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGroupsForCurrentStage_Private_ArrayOf_ChampionshipMemberGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<ChampionshipMemberGroup>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe Il2CppReferenceArray<ChampionshipMemberGroup> GetGroupsForStage(byte stage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stage);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGroupsForStage_Private_ArrayOf_ChampionshipMemberGroup_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<ChampionshipMemberGroup>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132284, XrefRangeEnd = 132287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChampionshipMemberGroup GetGroup(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGroup_Public_ChampionshipMemberGroup_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new ChampionshipMemberGroup(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132287, XrefRangeEnd = 132289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChampionshipMemberGroup GetNextGroup(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNextGroup_Public_ChampionshipMemberGroup_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new ChampionshipMemberGroup(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132289, XrefRangeEnd = 132292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalculateAllBets()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateAllBets_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 132295, RefRangeEnd = 132298, XrefRangeStart = 132292, XrefRangeEnd = 132295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ushort GetAllBetsInCurrentStage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllBetsInCurrentStage_Public_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 132308, RefRangeEnd = 132310, XrefRangeStart = 132298, XrefRangeEnd = 132308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ushort GetWonBets()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWonBets_Public_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 132314, RefRangeEnd = 132315, XrefRangeStart = 132310, XrefRangeEnd = 132314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ushort GetWonBetsInCurrentStage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWonBetsInCurrentStage_Public_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool PlayerWonInCurrentStage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayerWonInCurrentStage_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132315, XrefRangeEnd = 132318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ushort GetBetFromGroups(ref Il2CppReferenceArray<ChampionshipMemberGroup> groups, bool onlyWon = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(groups);
		*ptr = (nint)(&intPtr);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &onlyWon;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBetFromGroups_Private_UInt16_byref_ArrayOf_ChampionshipMemberGroup_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr2 = intPtr;
		groups = (Il2CppReferenceArray<ChampionshipMemberGroup>)(object)((intPtr2 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<T>(intPtr2));
		return *(ushort*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 132321, RefRangeEnd = 132325, XrefRangeStart = 132318, XrefRangeEnd = 132321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChampionshipMember GetNewMember(string memberName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(memberName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNewMember_Private_ChampionshipMember_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new ChampionshipMember(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 132329, RefRangeEnd = 132331, XrefRangeStart = 132325, XrefRangeEnd = 132329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChampionshipMemberGroup GetNewMemberGroup(ChampionshipMember member1, ChampionshipMember member2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(member1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(member2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNewMemberGroup_Private_ChampionshipMemberGroup_ChampionshipMember_ChampionshipMember_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new ChampionshipMemberGroup(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe ushort GetNewMemberUID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNewMemberUID_Private_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe byte GetNewGroupUID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNewGroupUID_Private_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(byte*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 134087, RefRangeEnd = 134089, XrefRangeStart = 132331, XrefRangeEnd = 134087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareNamesArrays()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareNamesArrays_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void ClearNamesArrays()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearNamesArrays_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 134108, RefRangeEnd = 134109, XrefRangeStart = 134089, XrefRangeEnd = 134108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GenerateName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateName_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	static ChampionshipManager()
	{
		Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Tracks.Dragstrip", "ChampionshipManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr);
		NativeFieldInfoPtr_playerMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, "playerMember");
		NativeFieldInfoPtr_playerCarData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, "playerCarData");
		NativeFieldInfoPtr_playerPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, "playerPI");
		NativeFieldInfoPtr_stage1MemberGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, "stage1MemberGroups");
		NativeFieldInfoPtr_stage2MemberGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, "stage2MemberGroups");
		NativeFieldInfoPtr_stage3MemberGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, "stage3MemberGroups");
		NativeFieldInfoPtr_stage4MemberGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, "stage4MemberGroup");
		NativeFieldInfoPtr_opponentsCars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, "opponentsCars");
		NativeFieldInfoPtr_currentStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, "currentStage");
		NativeFieldInfoPtr_lastUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, "lastUID");
		NativeFieldInfoPtr_lastGroupUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, "lastGroupUID");
		NativeFieldInfoPtr_opponentNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, "opponentNames");
		NativeFieldInfoPtr_opponentSurnames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, "opponentSurnames");
		NativeFieldInfoPtr_allBets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, "allBets");
		NativeFieldInfoPtr_playerPrize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, "playerPrize");
		NativeFieldInfoPtr_allDragstripCars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, "allDragstripCars");
		NativeFieldInfoPtr_playerCarCopy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, "playerCarCopy");
		NativeMethodInfoPtr_get_CurrentStage_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672151);
		NativeMethodInfoPtr_get_AllBets_Public_get_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672152);
		NativeMethodInfoPtr_get_PlayerPrize_Public_get_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672153);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672154);
		NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672155);
		NativeMethodInfoPtr_ConnectToUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672156);
		NativeMethodInfoPtr_SetCars_Public_Void_List_1_BasicCarForDragstrip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672157);
		NativeMethodInfoPtr_UpdateWinnerInGroup_Public_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672158);
		NativeMethodInfoPtr_GetPlayerPrize_Public_Int32_DragClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672159);
		NativeMethodInfoPtr_AddToPlayerPrize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672160);
		NativeMethodInfoPtr_ResetStage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672161);
		NativeMethodInfoPtr_NextStage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672162);
		NativeMethodInfoPtr_PreparePlayerMember_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672163);
		NativeMethodInfoPtr_GetPlayerCarData_Public_Nullable_1_NewCarData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672164);
		NativeMethodInfoPtr_PrepareOpponents_Public_Void_DragClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672165);
		NativeMethodInfoPtr_PrepareChampionshipCar_Private_Void_byref_CarForDragstrip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672166);
		NativeMethodInfoPtr_GetOpponentCar_Public_CarForDragstrip_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672167);
		NativeMethodInfoPtr_PrepareGroups_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672168);
		NativeMethodInfoPtr_CreateInitialGroup_Private_Void_ArrayOf_ChampionshipMember_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672169);
		NativeMethodInfoPtr_FillWinnersInNextGroup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672170);
		NativeMethodInfoPtr_FillGroups_Private_Void_byref_ArrayOf_ChampionshipMemberGroup_byref_ArrayOf_ChampionshipMemberGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672171);
		NativeMethodInfoPtr_CurrentGroupsHavePlayer_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672172);
		NativeMethodInfoPtr_GroupsHavePlayer_Private_Boolean_byref_ArrayOf_ChampionshipMemberGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672173);
		NativeMethodInfoPtr_CreateStage4Group_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672174);
		NativeMethodInfoPtr_GetGroupsForCurrentStage_Private_ArrayOf_ChampionshipMemberGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672175);
		NativeMethodInfoPtr_GetGroupsForStage_Private_ArrayOf_ChampionshipMemberGroup_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672176);
		NativeMethodInfoPtr_GetGroup_Public_ChampionshipMemberGroup_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672177);
		NativeMethodInfoPtr_GetNextGroup_Public_ChampionshipMemberGroup_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672178);
		NativeMethodInfoPtr_CalculateAllBets_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672179);
		NativeMethodInfoPtr_GetAllBetsInCurrentStage_Public_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672180);
		NativeMethodInfoPtr_GetWonBets_Public_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672181);
		NativeMethodInfoPtr_GetWonBetsInCurrentStage_Public_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672182);
		NativeMethodInfoPtr_PlayerWonInCurrentStage_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672183);
		NativeMethodInfoPtr_GetBetFromGroups_Private_UInt16_byref_ArrayOf_ChampionshipMemberGroup_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672184);
		NativeMethodInfoPtr_GetNewMember_Private_ChampionshipMember_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672185);
		NativeMethodInfoPtr_GetNewMemberGroup_Private_ChampionshipMemberGroup_ChampionshipMember_ChampionshipMember_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672186);
		NativeMethodInfoPtr_GetNewMemberUID_Private_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672187);
		NativeMethodInfoPtr_GetNewGroupUID_Private_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672188);
		NativeMethodInfoPtr_PrepareNamesArrays_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672189);
		NativeMethodInfoPtr_ClearNamesArrays_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672190);
		NativeMethodInfoPtr_GenerateName_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipManager>.NativeClassPtr, 100672191);
	}

	public ChampionshipManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
