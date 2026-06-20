using System;
using System.Runtime.CompilerServices;
using CMS.Containers;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace CMS.UI.Logic.Drag.Championship;

[System.Serializable]
public class DragPlayerInfo : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerName;

	private static readonly System.IntPtr NativeFieldInfoPtr_CarName;

	private static readonly System.IntPtr NativeFieldInfoPtr_BetInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_BetImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_BetValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_winner;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerBG;

	private static readonly System.IntPtr NativeFieldInfoPtr_ScrollingText;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasBid;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableScrolling_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareForMember_Public_Void_ChampionshipMember_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAsNotAvailable_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAsWinner_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAsLoser_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Bid_Public_Void_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveBid_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBetStatus_Public_Void_DragBetStatus_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DragPlayerInfo>.NativeClassPtr));

	public unsafe Text PlayerName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerName);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerName), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text CarName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarName);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarName), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject BetInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BetInfo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BetInfo), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image BetImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BetImage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BetImage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text BetValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BetValue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BetValue), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject winner
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_winner);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_winner), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject playerBG
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerBG);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerBG), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ScrollingText ScrollingText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScrollingText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ScrollingText(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScrollingText), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool hasBid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasBid);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasBid)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201305, XrefRangeEnd = 201308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableScrolling(bool enable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableScrolling_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 201325, RefRangeEnd = 201327, XrefRangeStart = 201308, XrefRangeEnd = 201325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareForMember(ChampionshipMember member)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareForMember_Public_Void_ChampionshipMember_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 201345, RefRangeEnd = 201349, XrefRangeStart = 201327, XrefRangeEnd = 201345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAsNotAvailable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAsNotAvailable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 201352, RefRangeEnd = 201353, XrefRangeStart = 201349, XrefRangeEnd = 201352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAsWinner()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAsWinner_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201353, XrefRangeEnd = 201354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAsLoser()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAsLoser_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 201367, RefRangeEnd = 201371, XrefRangeStart = 201354, XrefRangeEnd = 201367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Bid(ushort value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Bid_Public_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 201373, RefRangeEnd = 201382, XrefRangeStart = 201371, XrefRangeEnd = 201373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveBid()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveBid_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 201394, RefRangeEnd = 201398, XrefRangeStart = 201382, XrefRangeEnd = 201394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBetStatus(DragBetStatus status)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&status);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBetStatus_Public_Void_DragBetStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe DragPlayerInfo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragPlayerInfo>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DragPlayerInfo()
	{
		Il2CppClassPointerStore<DragPlayerInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Drag.Championship", "DragPlayerInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragPlayerInfo>.NativeClassPtr);
		NativeFieldInfoPtr_PlayerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragPlayerInfo>.NativeClassPtr, "PlayerName");
		NativeFieldInfoPtr_CarName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragPlayerInfo>.NativeClassPtr, "CarName");
		NativeFieldInfoPtr_BetInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragPlayerInfo>.NativeClassPtr, "BetInfo");
		NativeFieldInfoPtr_BetImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragPlayerInfo>.NativeClassPtr, "BetImage");
		NativeFieldInfoPtr_BetValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragPlayerInfo>.NativeClassPtr, "BetValue");
		NativeFieldInfoPtr_winner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragPlayerInfo>.NativeClassPtr, "winner");
		NativeFieldInfoPtr_playerBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragPlayerInfo>.NativeClassPtr, "playerBG");
		NativeFieldInfoPtr_ScrollingText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragPlayerInfo>.NativeClassPtr, "ScrollingText");
		NativeFieldInfoPtr_hasBid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragPlayerInfo>.NativeClassPtr, "hasBid");
		NativeMethodInfoPtr_EnableScrolling_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragPlayerInfo>.NativeClassPtr, 100678444);
		NativeMethodInfoPtr_PrepareForMember_Public_Void_ChampionshipMember_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragPlayerInfo>.NativeClassPtr, 100678445);
		NativeMethodInfoPtr_SetAsNotAvailable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragPlayerInfo>.NativeClassPtr, 100678446);
		NativeMethodInfoPtr_SetAsWinner_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragPlayerInfo>.NativeClassPtr, 100678447);
		NativeMethodInfoPtr_SetAsLoser_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragPlayerInfo>.NativeClassPtr, 100678448);
		NativeMethodInfoPtr_Bid_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragPlayerInfo>.NativeClassPtr, 100678449);
		NativeMethodInfoPtr_RemoveBid_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragPlayerInfo>.NativeClassPtr, 100678450);
		NativeMethodInfoPtr_SetBetStatus_Public_Void_DragBetStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragPlayerInfo>.NativeClassPtr, 100678451);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragPlayerInfo>.NativeClassPtr, 100678452);
	}

	public DragPlayerInfo(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
