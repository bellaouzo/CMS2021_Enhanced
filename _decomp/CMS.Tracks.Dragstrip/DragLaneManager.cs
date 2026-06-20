using System;
using System.Runtime.CompilerServices;
using CMS.Tracks.CarPhysics;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.Tracks.Dragstrip;

public class DragLaneManager : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_leftLaneSpawn;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftLaneStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftLaneDestination;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftLaneCheckpoints;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightLaneSpawn;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightLaneStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightLaneDestination;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightLaneCheckpoints;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerCarLoader;

	private static readonly System.IntPtr NativeFieldInfoPtr_opponentCarLoader;

	private static readonly System.IntPtr NativeFieldInfoPtr_prepareCarPhysics;

	private static readonly System.IntPtr NativeFieldInfoPtr_opponentCarPhysics;

	private static readonly System.IntPtr NativeFieldInfoPtr_opponentVPSelfDrive;

	private static readonly System.IntPtr NativeFieldInfoPtr_spaceBetweenTracks;

	private static readonly System.IntPtr NativeFieldInfoPtr_finishLaneMarker;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupPlayerSide_Public_Void_Boolean_DragLength_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupStop_Private_Void_DragLength_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableLeftLaneCheckpoints_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableRightLaneCheckpoints_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SkipCarDrive_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetIsPlayerLane_Private_Void_ArrayOf_DragCheckpoint_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DragLaneManager>.NativeClassPtr));

	public unsafe Transform leftLaneSpawn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftLaneSpawn);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftLaneSpawn), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform leftLaneStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftLaneStart);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftLaneStart), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform leftLaneDestination
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftLaneDestination);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftLaneDestination), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<DragCheckpoint> leftLaneCheckpoints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftLaneCheckpoints);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<DragCheckpoint>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftLaneCheckpoints), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform rightLaneSpawn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightLaneSpawn);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightLaneSpawn), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform rightLaneStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightLaneStart);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightLaneStart), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform rightLaneDestination
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightLaneDestination);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightLaneDestination), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<DragCheckpoint> rightLaneCheckpoints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightLaneCheckpoints);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<DragCheckpoint>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightLaneCheckpoints), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CarLoader playerCarLoader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerCarLoader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CarLoader(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerCarLoader), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CarLoader opponentCarLoader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opponentCarLoader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CarLoader(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opponentCarLoader), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PrepareCarPhysics prepareCarPhysics
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prepareCarPhysics);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PrepareCarPhysics(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prepareCarPhysics), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe OpponentCarPhysics opponentCarPhysics
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opponentCarPhysics);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new OpponentCarPhysics(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opponentCarPhysics), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe OpponentVPSelfDrive opponentVPSelfDrive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opponentVPSelfDrive);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new OpponentVPSelfDrive(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_opponentVPSelfDrive), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SpaceBetweenTracks spaceBetweenTracks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spaceBetweenTracks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new SpaceBetweenTracks(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spaceBetweenTracks), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform finishLaneMarker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finishLaneMarker);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finishLaneMarker), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 134157, RefRangeEnd = 134158, XrefRangeStart = 134134, XrefRangeEnd = 134157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupPlayerSide(bool isRight, DragLength dragLength, bool hasOpponent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&isRight);
		*(DragLength**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dragLength;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasOpponent;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupPlayerSide_Public_Void_Boolean_DragLength_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 134182, RefRangeEnd = 134183, XrefRangeStart = 134158, XrefRangeEnd = 134182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupStop(DragLength dragType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dragType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupStop_Private_Void_DragLength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 134188, RefRangeEnd = 134191, XrefRangeStart = 134183, XrefRangeEnd = 134188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableLeftLaneCheckpoints(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableLeftLaneCheckpoints_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 134196, RefRangeEnd = 134199, XrefRangeStart = 134191, XrefRangeEnd = 134196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableRightLaneCheckpoints(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableRightLaneCheckpoints_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 134199, RefRangeEnd = 134200, XrefRangeStart = 134199, XrefRangeEnd = 134199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SkipCarDrive(bool isRight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isRight);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SkipCarDrive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134200, XrefRangeEnd = 134201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetIsPlayerLane(Il2CppReferenceArray<DragCheckpoint> checkpoints, bool isPlayerLane)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(checkpoints);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isPlayerLane;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetIsPlayerLane_Private_Void_ArrayOf_DragCheckpoint_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe DragLaneManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragLaneManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DragLaneManager()
	{
		Il2CppClassPointerStore<DragLaneManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Tracks.Dragstrip", "DragLaneManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragLaneManager>.NativeClassPtr);
		NativeFieldInfoPtr_leftLaneSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragLaneManager>.NativeClassPtr, "leftLaneSpawn");
		NativeFieldInfoPtr_leftLaneStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragLaneManager>.NativeClassPtr, "leftLaneStart");
		NativeFieldInfoPtr_leftLaneDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragLaneManager>.NativeClassPtr, "leftLaneDestination");
		NativeFieldInfoPtr_leftLaneCheckpoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragLaneManager>.NativeClassPtr, "leftLaneCheckpoints");
		NativeFieldInfoPtr_rightLaneSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragLaneManager>.NativeClassPtr, "rightLaneSpawn");
		NativeFieldInfoPtr_rightLaneStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragLaneManager>.NativeClassPtr, "rightLaneStart");
		NativeFieldInfoPtr_rightLaneDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragLaneManager>.NativeClassPtr, "rightLaneDestination");
		NativeFieldInfoPtr_rightLaneCheckpoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragLaneManager>.NativeClassPtr, "rightLaneCheckpoints");
		NativeFieldInfoPtr_playerCarLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragLaneManager>.NativeClassPtr, "playerCarLoader");
		NativeFieldInfoPtr_opponentCarLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragLaneManager>.NativeClassPtr, "opponentCarLoader");
		NativeFieldInfoPtr_prepareCarPhysics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragLaneManager>.NativeClassPtr, "prepareCarPhysics");
		NativeFieldInfoPtr_opponentCarPhysics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragLaneManager>.NativeClassPtr, "opponentCarPhysics");
		NativeFieldInfoPtr_opponentVPSelfDrive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragLaneManager>.NativeClassPtr, "opponentVPSelfDrive");
		NativeFieldInfoPtr_spaceBetweenTracks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragLaneManager>.NativeClassPtr, "spaceBetweenTracks");
		NativeFieldInfoPtr_finishLaneMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragLaneManager>.NativeClassPtr, "finishLaneMarker");
		NativeMethodInfoPtr_SetupPlayerSide_Public_Void_Boolean_DragLength_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragLaneManager>.NativeClassPtr, 100672194);
		NativeMethodInfoPtr_SetupStop_Private_Void_DragLength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragLaneManager>.NativeClassPtr, 100672195);
		NativeMethodInfoPtr_EnableLeftLaneCheckpoints_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragLaneManager>.NativeClassPtr, 100672196);
		NativeMethodInfoPtr_EnableRightLaneCheckpoints_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragLaneManager>.NativeClassPtr, 100672197);
		NativeMethodInfoPtr_SkipCarDrive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragLaneManager>.NativeClassPtr, 100672198);
		NativeMethodInfoPtr_SetIsPlayerLane_Private_Void_ArrayOf_DragCheckpoint_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragLaneManager>.NativeClassPtr, 100672199);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragLaneManager>.NativeClassPtr, 100672200);
	}

	public DragLaneManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
