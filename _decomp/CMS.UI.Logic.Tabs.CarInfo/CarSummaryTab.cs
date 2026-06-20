using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine.UI;

namespace CMS.UI.Logic.Tabs.CarInfo;

public class CarSummaryTab : CarInfoTab
{
	private static readonly System.IntPtr NativeFieldInfoPtr_carName;

	private static readonly System.IntPtr NativeFieldInfoPtr_partsValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_bodyValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_tuningValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_restorationBonusValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_buyPrice;

	private static readonly System.IntPtr NativeFieldInfoPtr_profit;

	private static readonly System.IntPtr NativeFieldInfoPtr_commission;

	private static readonly System.IntPtr NativeFieldInfoPtr_commissionValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_sellValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_carValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentCarLoader;

	private static readonly System.IntPtr NativeFieldInfoPtr_price;

	private static readonly System.IntPtr NativeFieldInfoPtr_buyCar;

	private static readonly System.IntPtr NativeFieldInfoPtr_textLocalization;

	private static readonly System.IntPtr NativeFieldInfoPtr_bodyCon;

	private static readonly System.IntPtr NativeFieldInfoPtr_partsCon;

	private static readonly System.IntPtr NativeFieldInfoPtr_carValuee;

	private static readonly System.IntPtr NativeFieldInfoPtr_globalCondition;

	private static readonly System.IntPtr NativeFieldInfoPtr_restorationBonus;

	private static readonly System.IntPtr NativeFieldInfoPtr_sellPrice;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseCarPrice;

	private static readonly System.IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SubmitAction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareDescriptions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDescriptionsActions_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDefaultDescription_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupData_Public_Virtual_Void_CarInfoWindowData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupForBuy_Private_Void_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupForSell_Private_Void_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuyCar_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SellCar_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_Boolean_PDM_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_Boolean_PDM_1;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr));

	public unsafe Text carName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carName);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carName), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text partsValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partsValue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partsValue), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text bodyValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bodyValue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bodyValue), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text tuningValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuningValue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuningValue), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text restorationBonusValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_restorationBonusValue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_restorationBonusValue), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text buyPrice
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buyPrice);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buyPrice), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text profit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_profit);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_profit), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text commission
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commission);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commission), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text commissionValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commissionValue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commissionValue), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text sellValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sellValue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sellValue), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text carValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carValue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carValue), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CarLoader currentCarLoader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentCarLoader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CarLoader(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentCarLoader), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int price
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_price);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_price)) = num;
		}
	}

	public unsafe bool buyCar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buyCar);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buyCar)) = flag;
		}
	}

	public unsafe string textLocalization
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textLocalization);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textLocalization), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe float bodyCon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bodyCon);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bodyCon)) = num;
		}
	}

	public unsafe float partsCon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partsCon);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partsCon)) = num;
		}
	}

	public unsafe int carValuee
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carValuee);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carValuee)) = num;
		}
	}

	public unsafe float globalCondition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_globalCondition);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_globalCondition)) = num;
		}
	}

	public unsafe int restorationBonus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_restorationBonus);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_restorationBonus)) = num;
		}
	}

	public unsafe int sellPrice
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sellPrice);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sellPrice)) = num;
		}
	}

	public unsafe int baseCarPrice
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseCarPrice);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseCarPrice)) = num;
		}
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public new unsafe void Activate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Activate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe void Deactivate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185458, XrefRangeEnd = 185459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SubmitAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SubmitAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 185494, RefRangeEnd = 185495, XrefRangeStart = 185459, XrefRangeEnd = 185494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareDescriptions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareDescriptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185495, XrefRangeEnd = 185510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void RemoveDescriptionsActions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_RemoveDescriptionsActions_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185510, XrefRangeEnd = 185526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDefaultDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDefaultDescription_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185526, XrefRangeEnd = 185607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void SetupData(CarInfoWindowData carInfoWindowData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(carInfoWindowData));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SetupData_Public_Virtual_Void_CarInfoWindowData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 185784, RefRangeEnd = 185785, XrefRangeStart = 185607, XrefRangeEnd = 185784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupForBuy(CarLoader carLoader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupForBuy_Private_Void_CarLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 185842, RefRangeEnd = 185843, XrefRangeStart = 185785, XrefRangeEnd = 185842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupForSell(CarLoader carLoader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupForSell_Private_Void_CarLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 185876, RefRangeEnd = 185877, XrefRangeStart = 185843, XrefRangeEnd = 185876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuyCar()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuyCar_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185877, XrefRangeEnd = 185917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SellCar()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SellCar_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe CarSummaryTab()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185917, XrefRangeEnd = 185945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Method_Private_Void_Boolean_PDM_0(bool wasAccepted)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&wasAccepted);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Private_Void_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185945, XrefRangeEnd = 185969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Method_Private_Void_Boolean_PDM_1(bool wasAccepted)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&wasAccepted);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Private_Void_Boolean_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CarSummaryTab()
	{
		Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Tabs.CarInfo", "CarSummaryTab");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr);
		NativeFieldInfoPtr_carName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, "carName");
		NativeFieldInfoPtr_partsValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, "partsValue");
		NativeFieldInfoPtr_bodyValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, "bodyValue");
		NativeFieldInfoPtr_tuningValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, "tuningValue");
		NativeFieldInfoPtr_restorationBonusValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, "restorationBonusValue");
		NativeFieldInfoPtr_buyPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, "buyPrice");
		NativeFieldInfoPtr_profit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, "profit");
		NativeFieldInfoPtr_commission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, "commission");
		NativeFieldInfoPtr_commissionValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, "commissionValue");
		NativeFieldInfoPtr_sellValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, "sellValue");
		NativeFieldInfoPtr_carValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, "carValue");
		NativeFieldInfoPtr_currentCarLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, "currentCarLoader");
		NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, "price");
		NativeFieldInfoPtr_buyCar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, "buyCar");
		NativeFieldInfoPtr_textLocalization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, "textLocalization");
		NativeFieldInfoPtr_bodyCon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, "bodyCon");
		NativeFieldInfoPtr_partsCon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, "partsCon");
		NativeFieldInfoPtr_carValuee = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, "carValuee");
		NativeFieldInfoPtr_globalCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, "globalCondition");
		NativeFieldInfoPtr_restorationBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, "restorationBonus");
		NativeFieldInfoPtr_sellPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, "sellPrice");
		NativeFieldInfoPtr_baseCarPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, "baseCarPrice");
		NativeMethodInfoPtr_Activate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, 100676911);
		NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, 100676912);
		NativeMethodInfoPtr_SubmitAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, 100676913);
		NativeMethodInfoPtr_PrepareDescriptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, 100676914);
		NativeMethodInfoPtr_RemoveDescriptionsActions_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, 100676915);
		NativeMethodInfoPtr_SetDefaultDescription_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, 100676916);
		NativeMethodInfoPtr_SetupData_Public_Virtual_Void_CarInfoWindowData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, 100676917);
		NativeMethodInfoPtr_SetupForBuy_Private_Void_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, 100676918);
		NativeMethodInfoPtr_SetupForSell_Private_Void_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, 100676919);
		NativeMethodInfoPtr_BuyCar_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, 100676920);
		NativeMethodInfoPtr_SellCar_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, 100676921);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, 100676922);
		NativeMethodInfoPtr_Method_Private_Void_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, 100676923);
		NativeMethodInfoPtr_Method_Private_Void_Boolean_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarSummaryTab>.NativeClassPtr, 100676924);
	}

	public CarSummaryTab(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
