using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace CMS.UI.Logic.Auction;

public class CircleOtherInfo : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_info;

	private static readonly System.IntPtr NativeFieldInfoPtr_needTranslation;

	private static readonly System.IntPtr NativeFieldInfoPtr_normalStatus;

	private static readonly System.IntPtr NativeFieldInfoPtr_winningStatus;

	private static readonly System.IntPtr NativeFieldInfoPtr_loosingStatus;

	private static readonly System.IntPtr NativeFieldInfoPtr_winStatus;

	private static readonly System.IntPtr NativeFieldInfoPtr_loseStatus;

	private static readonly System.IntPtr NativeMethodInfoPtr_Localize_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInfo_Public_Void_AuctionStatus_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CircleOtherInfo>.NativeClassPtr));

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

	public unsafe string normalStatus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalStatus);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalStatus), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string winningStatus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_winningStatus);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_winningStatus), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string loosingStatus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loosingStatus);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loosingStatus), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string winStatus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_winStatus);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_winStatus), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string loseStatus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loseStatus);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loseStatus), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 203556, RefRangeEnd = 203558, XrefRangeStart = 203541, XrefRangeEnd = 203556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Localize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Localize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 203559, RefRangeEnd = 203560, XrefRangeStart = 203558, XrefRangeEnd = 203559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInfo(AuctionStatus status)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&status);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInfo_Public_Void_AuctionStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe CircleOtherInfo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CircleOtherInfo>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CircleOtherInfo()
	{
		Il2CppClassPointerStore<CircleOtherInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Auction", "CircleOtherInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CircleOtherInfo>.NativeClassPtr);
		NativeFieldInfoPtr_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircleOtherInfo>.NativeClassPtr, "info");
		NativeFieldInfoPtr_needTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircleOtherInfo>.NativeClassPtr, "needTranslation");
		NativeFieldInfoPtr_normalStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircleOtherInfo>.NativeClassPtr, "normalStatus");
		NativeFieldInfoPtr_winningStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircleOtherInfo>.NativeClassPtr, "winningStatus");
		NativeFieldInfoPtr_loosingStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircleOtherInfo>.NativeClassPtr, "loosingStatus");
		NativeFieldInfoPtr_winStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircleOtherInfo>.NativeClassPtr, "winStatus");
		NativeFieldInfoPtr_loseStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircleOtherInfo>.NativeClassPtr, "loseStatus");
		NativeMethodInfoPtr_Localize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleOtherInfo>.NativeClassPtr, 100678696);
		NativeMethodInfoPtr_SetInfo_Public_Void_AuctionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleOtherInfo>.NativeClassPtr, 100678697);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleOtherInfo>.NativeClassPtr, 100678698);
	}

	public CircleOtherInfo(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
