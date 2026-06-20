using System;
using System.Runtime.CompilerServices;
using CMS.Events;
using CMS.UI.Description;
using Il2CppSystem;
using Rewired;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace CMS.UI.Logic.Drag.Championship;

public class BetLogic : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_leftPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftArrow;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightArrow;

	private static readonly System.IntPtr NativeFieldInfoPtr_betImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_betValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultXPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentBetIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentBet;

	private static readonly System.IntPtr NativeFieldInfoPtr_eventData;

	private static readonly System.IntPtr NativeFieldInfoPtr_uiDescription;

	private static readonly System.IntPtr NativeFieldInfoPtr_moneyToBet;

	private static readonly System.IntPtr NativeFieldInfoPtr_canBet;

	private static readonly System.IntPtr NativeFieldInfoPtr_championshipStage;

	private static readonly System.IntPtr NativeFieldInfoPtr_betValuesForStage;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMoneyToBet_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMoneyToBet_Private_Void_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanBet_Private_Boolean_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableBet_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDisabledColors_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Public_Void_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareDefaultPos_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareArrows_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLeftBid_Public_Void_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRightBid_Public_Void_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBidText_Private_Void_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCannotBid_Private_Void_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateColors_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendEvent_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendResetEvent_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLeftPos_Private_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRightPos_Private_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetPosition_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCurrentPos_Private_Void_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPos_Private_Void_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDescription_Public_Void_UIDescription_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDescription_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareBetValue_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IncreaseBet_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DecreaseBet_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateBetValue_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateBetValue_Private_Boolean_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBetValue_Private_Void_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindBetIndex_Private_Int32_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GoLeft_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GoRight_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GoLeftInternal_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GoRightInternal_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Boolean_Player_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BetLogic>.NativeClassPtr));

	public unsafe Transform leftPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftPos);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftPos), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform rightPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightPos);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightPos), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AdvancedArrow leftArrow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftArrow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AdvancedArrow(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftArrow), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AdvancedArrow rightArrow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightArrow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AdvancedArrow(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightArrow), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image betImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_betImage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_betImage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text betValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_betValue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_betValue), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float defaultXPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultXPos);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultXPos)) = num;
		}
	}

	public unsafe byte currentPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentPos);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentPos)) = b;
		}
	}

	public unsafe int currentBetIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentBetIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentBetIndex)) = num;
		}
	}

	public unsafe ushort currentBet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentBet);
			return *(ushort*)num;
		}
		set
		{
			*(ushort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentBet)) = num;
		}
	}

	public unsafe DragBidEventData eventData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DragBidEventData(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe UIDescription uiDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiDescription);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new UIDescription(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiDescription), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int moneyToBet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moneyToBet);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moneyToBet)) = num;
		}
	}

	public unsafe bool canBet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canBet);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canBet)) = flag;
		}
	}

	public unsafe byte championshipStage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_championshipStage);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_championshipStage)) = b;
		}
	}

	public unsafe Il2CppStructArray<ushort> betValuesForStage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_betValuesForStage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<ushort>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_betValuesForStage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200828, XrefRangeEnd = 200829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMoneyToBet(int money)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&money);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMoneyToBet_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200829, XrefRangeEnd = 200832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateMoneyToBet(ushort value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateMoneyToBet_Private_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool CanBet(ushort value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanBet_Private_Boolean_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 200853, RefRangeEnd = 200855, XrefRangeStart = 200832, XrefRangeEnd = 200853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisableBet()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableBet_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 200859, RefRangeEnd = 200861, XrefRangeStart = 200855, XrefRangeEnd = 200859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDisabledColors()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDisabledColors_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 200893, RefRangeEnd = 200894, XrefRangeStart = 200861, XrefRangeEnd = 200893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Prepare(byte stage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stage);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Prepare_Public_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200894, XrefRangeEnd = 200898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareDefaultPos()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareDefaultPos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 200910, RefRangeEnd = 200911, XrefRangeStart = 200898, XrefRangeEnd = 200910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareArrows()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareArrows_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200911, XrefRangeEnd = 200913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLeftBid(ushort value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLeftBid_Public_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200913, XrefRangeEnd = 200915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRightBid(ushort value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRightBid_Public_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 200929, RefRangeEnd = 200934, XrefRangeStart = 200915, XrefRangeEnd = 200929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBidText(ushort bid)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bid);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBidText_Private_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 200947, RefRangeEnd = 200952, XrefRangeStart = 200934, XrefRangeEnd = 200947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCannotBid(ushort bid)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bid);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCannotBid_Private_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 200959, RefRangeEnd = 200962, XrefRangeStart = 200952, XrefRangeEnd = 200959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateColors(bool hasBet)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hasBet);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateColors_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 200971, RefRangeEnd = 200976, XrefRangeStart = 200962, XrefRangeEnd = 200971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendEvent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendEvent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 200985, RefRangeEnd = 200988, XrefRangeStart = 200976, XrefRangeEnd = 200985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendResetEvent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendResetEvent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 200996, RefRangeEnd = 200999, XrefRangeStart = 200988, XrefRangeEnd = 200996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLeftPos(bool sendEvent = true, bool withAnimation = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&sendEvent);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &withAnimation;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLeftPos_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 201007, RefRangeEnd = 201010, XrefRangeStart = 200999, XrefRangeEnd = 201007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRightPos(bool sendEvent = true, bool withAnimation = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&sendEvent);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &withAnimation;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRightPos_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 201027, RefRangeEnd = 201029, XrefRangeStart = 201010, XrefRangeEnd = 201027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetPosition(bool sendEvent = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sendEvent);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetPosition_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 201035, RefRangeEnd = 201037, XrefRangeStart = 201029, XrefRangeEnd = 201035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCurrentPos(byte pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pos);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCurrentPos_Private_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 201055, RefRangeEnd = 201058, XrefRangeStart = 201037, XrefRangeEnd = 201055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPos(float xPos, bool withAnimation = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&xPos);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &withAnimation;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPos_Private_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(41)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void SetDescription(UIDescription description)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(description);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDescription_Public_Void_UIDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 201062, RefRangeEnd = 201066, XrefRangeStart = 201058, XrefRangeEnd = 201062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateDescription_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201066, XrefRangeEnd = 201083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareBetValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareBetValue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201083, XrefRangeEnd = 201091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IncreaseBet()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IncreaseBet_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201091, XrefRangeEnd = 201099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DecreaseBet()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DecreaseBet_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 201108, RefRangeEnd = 201109, XrefRangeStart = 201099, XrefRangeEnd = 201108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateBetValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateBetValue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201109, XrefRangeEnd = 201110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UpdateBetValue(ushort bet)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bet);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateBetValue_Private_Boolean_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 201115, RefRangeEnd = 201118, XrefRangeStart = 201110, XrefRangeEnd = 201115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBetValue(ushort value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBetValue_Private_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201118, XrefRangeEnd = 201119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindBetIndex(ushort bet)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bet);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindBetIndex_Private_Int32_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201119, XrefRangeEnd = 201120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GoLeft()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GoLeft_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201120, XrefRangeEnd = 201121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GoRight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GoRight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 201123, RefRangeEnd = 201124, XrefRangeStart = 201121, XrefRangeEnd = 201123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GoLeftInternal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GoLeftInternal_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 201126, RefRangeEnd = 201127, XrefRangeStart = 201124, XrefRangeEnd = 201126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GoRightInternal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GoRightInternal_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 201144, RefRangeEnd = 201145, XrefRangeStart = 201127, XrefRangeEnd = 201144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HandleInput(Player player)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleInput_Public_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe BetLogic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BetLogic>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static BetLogic()
	{
		Il2CppClassPointerStore<BetLogic>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Drag.Championship", "BetLogic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BetLogic>.NativeClassPtr);
		NativeFieldInfoPtr_leftPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, "leftPos");
		NativeFieldInfoPtr_rightPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, "rightPos");
		NativeFieldInfoPtr_leftArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, "leftArrow");
		NativeFieldInfoPtr_rightArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, "rightArrow");
		NativeFieldInfoPtr_betImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, "betImage");
		NativeFieldInfoPtr_betValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, "betValue");
		NativeFieldInfoPtr_defaultXPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, "defaultXPos");
		NativeFieldInfoPtr_currentPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, "currentPos");
		NativeFieldInfoPtr_currentBetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, "currentBetIndex");
		NativeFieldInfoPtr_currentBet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, "currentBet");
		NativeFieldInfoPtr_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, "eventData");
		NativeFieldInfoPtr_uiDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, "uiDescription");
		NativeFieldInfoPtr_moneyToBet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, "moneyToBet");
		NativeFieldInfoPtr_canBet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, "canBet");
		NativeFieldInfoPtr_championshipStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, "championshipStage");
		NativeFieldInfoPtr_betValuesForStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, "betValuesForStage");
		NativeMethodInfoPtr_SetMoneyToBet_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678385);
		NativeMethodInfoPtr_UpdateMoneyToBet_Private_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678386);
		NativeMethodInfoPtr_CanBet_Private_Boolean_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678387);
		NativeMethodInfoPtr_DisableBet_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678388);
		NativeMethodInfoPtr_SetDisabledColors_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678389);
		NativeMethodInfoPtr_Prepare_Public_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678390);
		NativeMethodInfoPtr_PrepareDefaultPos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678391);
		NativeMethodInfoPtr_PrepareArrows_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678392);
		NativeMethodInfoPtr_SetLeftBid_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678393);
		NativeMethodInfoPtr_SetRightBid_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678394);
		NativeMethodInfoPtr_SetBidText_Private_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678395);
		NativeMethodInfoPtr_SetCannotBid_Private_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678396);
		NativeMethodInfoPtr_UpdateColors_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678397);
		NativeMethodInfoPtr_SendEvent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678398);
		NativeMethodInfoPtr_SendResetEvent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678399);
		NativeMethodInfoPtr_SetLeftPos_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678400);
		NativeMethodInfoPtr_SetRightPos_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678401);
		NativeMethodInfoPtr_ResetPosition_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678402);
		NativeMethodInfoPtr_SetCurrentPos_Private_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678403);
		NativeMethodInfoPtr_SetPos_Private_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678404);
		NativeMethodInfoPtr_SetDescription_Public_Void_UIDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678405);
		NativeMethodInfoPtr_UpdateDescription_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678406);
		NativeMethodInfoPtr_PrepareBetValue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678407);
		NativeMethodInfoPtr_IncreaseBet_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678408);
		NativeMethodInfoPtr_DecreaseBet_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678409);
		NativeMethodInfoPtr_UpdateBetValue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678410);
		NativeMethodInfoPtr_UpdateBetValue_Private_Boolean_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678411);
		NativeMethodInfoPtr_SetBetValue_Private_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678412);
		NativeMethodInfoPtr_FindBetIndex_Private_Int32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678413);
		NativeMethodInfoPtr_GoLeft_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678414);
		NativeMethodInfoPtr_GoRight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678415);
		NativeMethodInfoPtr_GoLeftInternal_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678416);
		NativeMethodInfoPtr_GoRightInternal_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678417);
		NativeMethodInfoPtr_HandleInput_Public_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678418);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetLogic>.NativeClassPtr, 100678419);
	}

	public BetLogic(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
