using System;
using System.Runtime.CompilerServices;
using CMS.UI.Description;
using CMS.UI.Logic.CarInfo;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine.UI;

namespace CMS.UI.Logic.Tabs.CarInfo;

public class OrderSummaryTab : CarInfoTab
{
	private static readonly System.IntPtr NativeFieldInfoPtr_orderSummaryPageManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_CarName;

	private static readonly System.IntPtr NativeFieldInfoPtr_TaskBonus;

	private static readonly System.IntPtr NativeFieldInfoPtr_JobBonus;

	private static readonly System.IntPtr NativeFieldInfoPtr_TotalPayout;

	private static readonly System.IntPtr NativeFieldInfoPtr_submitDescription;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentJobIsMission;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentJob;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentCarLoader;

	private static readonly System.IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SubmitAction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareDescriptions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDescriptionsActions_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CacheDescription_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSubmitDescription_Public_ControlDescription_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDescriptionBasedOnType_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetJobDescription_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMissionDescription_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupData_Public_Virtual_Void_CarInfoWindowData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPage_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupJobs_Private_Void_CarLoader_Job_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FinishMission_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FinishJob_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandlePageChangeInput_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_Boolean_PDM_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr));

	public unsafe OrderSummaryPageManager orderSummaryPageManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderSummaryPageManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new OrderSummaryPageManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderSummaryPageManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe Text TaskBonus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TaskBonus);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TaskBonus), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text JobBonus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JobBonus);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JobBonus), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text TotalPayout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TotalPayout);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TotalPayout), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ControlDescription submitDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_submitDescription);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ControlDescription(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_submitDescription), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool currentJobIsMission
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentJobIsMission);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentJobIsMission)) = flag;
		}
	}

	public unsafe Job currentJob
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentJob);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Job(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentJob), IL2CPP.Il2CppObjectBaseToPtr(obj));
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186177, XrefRangeEnd = 186191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Deactivate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186191, XrefRangeEnd = 186198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SubmitAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SubmitAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 186222, RefRangeEnd = 186223, XrefRangeStart = 186198, XrefRangeEnd = 186222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareDescriptions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareDescriptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186223, XrefRangeEnd = 186238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void RemoveDescriptionsActions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_RemoveDescriptionsActions_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186238, XrefRangeEnd = 186241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CacheDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CacheDescription_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe ControlDescription GetSubmitDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSubmitDescription_Public_ControlDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new ControlDescription(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186241, XrefRangeEnd = 186242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDescriptionBasedOnType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDescriptionBasedOnType_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 186266, RefRangeEnd = 186267, XrefRangeStart = 186242, XrefRangeEnd = 186266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetJobDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetJobDescription_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 186291, RefRangeEnd = 186292, XrefRangeStart = 186267, XrefRangeEnd = 186291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMissionDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMissionDescription_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186292, XrefRangeEnd = 186295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void SetupData(CarInfoWindowData carInfoWindowData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(carInfoWindowData));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SetupData_Public_Virtual_Void_CarInfoWindowData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetPage(int pageIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pageIndex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPage_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 186305, RefRangeEnd = 186306, XrefRangeStart = 186295, XrefRangeEnd = 186305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupJobs(CarLoader carLoader, Job job)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(job);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupJobs_Private_Void_CarLoader_Job_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186306, XrefRangeEnd = 186312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FinishMission()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FinishMission_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 186330, RefRangeEnd = 186331, XrefRangeStart = 186312, XrefRangeEnd = 186330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FinishJob()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FinishJob_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186331, XrefRangeEnd = 186349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HandlePageChangeInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandlePageChangeInput_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186349, XrefRangeEnd = 186367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HandleInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe OrderSummaryTab()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186367, XrefRangeEnd = 186372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Method_Private_Void_Boolean_PDM_0(bool wasAccepted)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&wasAccepted);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Private_Void_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static OrderSummaryTab()
	{
		Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Tabs.CarInfo", "OrderSummaryTab");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr);
		NativeFieldInfoPtr_orderSummaryPageManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr, "orderSummaryPageManager");
		NativeFieldInfoPtr_CarName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr, "CarName");
		NativeFieldInfoPtr_TaskBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr, "TaskBonus");
		NativeFieldInfoPtr_JobBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr, "JobBonus");
		NativeFieldInfoPtr_TotalPayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr, "TotalPayout");
		NativeFieldInfoPtr_submitDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr, "submitDescription");
		NativeFieldInfoPtr_currentJobIsMission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr, "currentJobIsMission");
		NativeFieldInfoPtr_currentJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr, "currentJob");
		NativeFieldInfoPtr_currentCarLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr, "currentCarLoader");
		NativeMethodInfoPtr_Activate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr, 100676940);
		NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr, 100676941);
		NativeMethodInfoPtr_SubmitAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr, 100676942);
		NativeMethodInfoPtr_PrepareDescriptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr, 100676943);
		NativeMethodInfoPtr_RemoveDescriptionsActions_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr, 100676944);
		NativeMethodInfoPtr_CacheDescription_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr, 100676945);
		NativeMethodInfoPtr_GetSubmitDescription_Public_ControlDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr, 100676946);
		NativeMethodInfoPtr_SetDescriptionBasedOnType_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr, 100676947);
		NativeMethodInfoPtr_SetJobDescription_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr, 100676948);
		NativeMethodInfoPtr_SetMissionDescription_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr, 100676949);
		NativeMethodInfoPtr_SetupData_Public_Virtual_Void_CarInfoWindowData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr, 100676950);
		NativeMethodInfoPtr_SetPage_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr, 100676951);
		NativeMethodInfoPtr_SetupJobs_Private_Void_CarLoader_Job_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr, 100676952);
		NativeMethodInfoPtr_FinishMission_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr, 100676953);
		NativeMethodInfoPtr_FinishJob_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr, 100676954);
		NativeMethodInfoPtr_HandlePageChangeInput_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr, 100676955);
		NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr, 100676956);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr, 100676957);
		NativeMethodInfoPtr_Method_Private_Void_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderSummaryTab>.NativeClassPtr, 100676958);
	}

	public OrderSummaryTab(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
