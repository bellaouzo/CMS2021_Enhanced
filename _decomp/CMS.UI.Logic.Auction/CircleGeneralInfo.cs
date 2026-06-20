using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace CMS.UI.Logic.Auction;

public class CircleGeneralInfo : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_price;

	private static readonly System.IntPtr NativeFieldInfoPtr_info;

	private static readonly System.IntPtr NativeFieldInfoPtr_bidder;

	private static readonly System.IntPtr NativeFieldInfoPtr_needTranslation;

	private static readonly System.IntPtr NativeFieldInfoPtr_auctionStatusWinning;

	private static readonly System.IntPtr NativeFieldInfoPtr_auctionStatusLoosing;

	private static readonly System.IntPtr NativeMethodInfoPtr_Localize_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillInfo_Public_Void_AuctionStatus_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillPrice_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInfo_Private_Void_AuctionStatus_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CircleGeneralInfo>.NativeClassPtr));

	public unsafe Text price
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_price);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_price), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text info
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_info);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_info), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text bidder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bidder);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bidder), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool needTranslation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needTranslation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needTranslation)) = flag;
		}
	}

	public unsafe string auctionStatusWinning
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_auctionStatusWinning);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_auctionStatusWinning), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string auctionStatusLoosing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_auctionStatusLoosing);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_auctionStatusLoosing), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203514, XrefRangeEnd = 203520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Localize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Localize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 203529, RefRangeEnd = 203531, XrefRangeStart = 203520, XrefRangeEnd = 203529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FillInfo(AuctionStatus status, string bidderName, int priceValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&status);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(bidderName);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &priceValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillInfo_Public_Void_AuctionStatus_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203531, XrefRangeEnd = 203535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FillPrice(int priceValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&priceValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillPrice_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203535, XrefRangeEnd = 203541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInfo(AuctionStatus status)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&status);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInfo_Private_Void_AuctionStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe CircleGeneralInfo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CircleGeneralInfo>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CircleGeneralInfo()
	{
		Il2CppClassPointerStore<CircleGeneralInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Auction", "CircleGeneralInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CircleGeneralInfo>.NativeClassPtr);
		NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircleGeneralInfo>.NativeClassPtr, "price");
		NativeFieldInfoPtr_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircleGeneralInfo>.NativeClassPtr, "info");
		NativeFieldInfoPtr_bidder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircleGeneralInfo>.NativeClassPtr, "bidder");
		NativeFieldInfoPtr_needTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircleGeneralInfo>.NativeClassPtr, "needTranslation");
		NativeFieldInfoPtr_auctionStatusWinning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircleGeneralInfo>.NativeClassPtr, "auctionStatusWinning");
		NativeFieldInfoPtr_auctionStatusLoosing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircleGeneralInfo>.NativeClassPtr, "auctionStatusLoosing");
		NativeMethodInfoPtr_Localize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleGeneralInfo>.NativeClassPtr, 100678691);
		NativeMethodInfoPtr_FillInfo_Public_Void_AuctionStatus_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleGeneralInfo>.NativeClassPtr, 100678692);
		NativeMethodInfoPtr_FillPrice_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleGeneralInfo>.NativeClassPtr, 100678693);
		NativeMethodInfoPtr_SetInfo_Private_Void_AuctionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleGeneralInfo>.NativeClassPtr, 100678694);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleGeneralInfo>.NativeClassPtr, 100678695);
	}

	public CircleGeneralInfo(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
