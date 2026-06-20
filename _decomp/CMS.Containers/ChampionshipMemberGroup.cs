using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Containers;

public class ChampionshipMemberGroup : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_UID;

	private static readonly System.IntPtr NativeFieldInfoPtr_Member1;

	private static readonly System.IntPtr NativeFieldInfoPtr_Member2;

	private static readonly System.IntPtr NativeFieldInfoPtr_Member1Bid;

	private static readonly System.IntPtr NativeFieldInfoPtr_Member2Bid;

	private static readonly System.IntPtr NativeFieldInfoPtr_RaceDone;

	private static readonly System.IntPtr NativeFieldInfoPtr_Winner;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasPlayer_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasBid_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Member1UID_Public_get_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Member2UID_Public_get_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BidMember1_Public_Void_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BidMember2_Public_Void_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetBid_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWinner_Public_Void_DragMember_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWinner_Public_Void_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWinnerMember_Public_ChampionshipMember_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBetValue_Public_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BetWon_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ChampionshipMemberGroup>.NativeClassPtr));

	public unsafe byte UID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UID);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UID)) = b;
		}
	}

	public unsafe ChampionshipMember Member1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Member1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ChampionshipMember(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Member1), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ChampionshipMember Member2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Member2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ChampionshipMember(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Member2), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ushort Member1Bid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Member1Bid);
			return *(ushort*)num;
		}
		set
		{
			*(ushort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Member1Bid)) = num;
		}
	}

	public unsafe ushort Member2Bid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Member2Bid);
			return *(ushort*)num;
		}
		set
		{
			*(ushort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Member2Bid)) = num;
		}
	}

	public unsafe bool RaceDone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RaceDone);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RaceDone)) = flag;
		}
	}

	public unsafe byte Winner
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Winner);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Winner)) = b;
		}
	}

	public unsafe ushort Member1UID
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Member1UID_Public_get_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(ushort*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe ushort Member2UID
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Member2UID_Public_get_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(ushort*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 218352, RefRangeEnd = 218353, XrefRangeStart = 218352, XrefRangeEnd = 218352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasPlayer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasPlayer_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool HasBid()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasBid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe void BidMember1(ushort value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BidMember1_Public_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void BidMember2(ushort value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BidMember2_Public_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void ResetBid()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetBid_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetWinner(DragMember member)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&member);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWinner_Public_Void_DragMember_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetWinner(byte memberIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&memberIndex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWinner_Public_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe ChampionshipMember GetWinnerMember()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWinnerMember_Public_ChampionshipMember_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new ChampionshipMember(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe ushort GetBetValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBetValue_Public_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool BetWon()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BetWon_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe ChampionshipMemberGroup()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChampionshipMemberGroup>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ChampionshipMemberGroup()
	{
		Il2CppClassPointerStore<ChampionshipMemberGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers", "ChampionshipMemberGroup");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChampionshipMemberGroup>.NativeClassPtr);
		NativeFieldInfoPtr_UID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChampionshipMemberGroup>.NativeClassPtr, "UID");
		NativeFieldInfoPtr_Member1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChampionshipMemberGroup>.NativeClassPtr, "Member1");
		NativeFieldInfoPtr_Member2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChampionshipMemberGroup>.NativeClassPtr, "Member2");
		NativeFieldInfoPtr_Member1Bid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChampionshipMemberGroup>.NativeClassPtr, "Member1Bid");
		NativeFieldInfoPtr_Member2Bid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChampionshipMemberGroup>.NativeClassPtr, "Member2Bid");
		NativeFieldInfoPtr_RaceDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChampionshipMemberGroup>.NativeClassPtr, "RaceDone");
		NativeFieldInfoPtr_Winner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChampionshipMemberGroup>.NativeClassPtr, "Winner");
		NativeMethodInfoPtr_HasPlayer_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipMemberGroup>.NativeClassPtr, 100679749);
		NativeMethodInfoPtr_HasBid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipMemberGroup>.NativeClassPtr, 100679750);
		NativeMethodInfoPtr_get_Member1UID_Public_get_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipMemberGroup>.NativeClassPtr, 100679751);
		NativeMethodInfoPtr_get_Member2UID_Public_get_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipMemberGroup>.NativeClassPtr, 100679752);
		NativeMethodInfoPtr_BidMember1_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipMemberGroup>.NativeClassPtr, 100679753);
		NativeMethodInfoPtr_BidMember2_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipMemberGroup>.NativeClassPtr, 100679754);
		NativeMethodInfoPtr_ResetBid_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipMemberGroup>.NativeClassPtr, 100679755);
		NativeMethodInfoPtr_SetWinner_Public_Void_DragMember_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipMemberGroup>.NativeClassPtr, 100679756);
		NativeMethodInfoPtr_SetWinner_Public_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipMemberGroup>.NativeClassPtr, 100679757);
		NativeMethodInfoPtr_GetWinnerMember_Public_ChampionshipMember_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipMemberGroup>.NativeClassPtr, 100679758);
		NativeMethodInfoPtr_GetBetValue_Public_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipMemberGroup>.NativeClassPtr, 100679759);
		NativeMethodInfoPtr_BetWon_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipMemberGroup>.NativeClassPtr, 100679760);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipMemberGroup>.NativeClassPtr, 100679761);
	}

	public ChampionshipMemberGroup(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
