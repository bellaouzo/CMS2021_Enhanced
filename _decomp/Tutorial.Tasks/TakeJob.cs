using System;
using System.Runtime.CompilerServices;
using CMS.Tutorial;
using CMS.Tutorial.Tasks;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace Tutorial.Tasks;

public class TakeJob : BaseTask
{
	[ObfuscatedName("Tutorial.Tasks.TakeJob/<Init>d__1")]
	public sealed class _Init_d__1 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_sm;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_Init_d__1>.NativeClassPtr));

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
			}
		}

		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe TakeJob __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new TakeJob(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe SceneManager sm
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sm);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new SceneManager(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sm), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Il2CppSystem.Object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
			}
		}

		public unsafe Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
			}
		}

		[CallerCount(0)]
		public unsafe _Init_d__1(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_Init_d__1>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&_003C_003E1__state);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128829, XrefRangeEnd = 128858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128858, XrefRangeEnd = 128863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _Init_d__1()
		{
			Il2CppClassPointerStore<_Init_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, "<Init>d__1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_Init_d__1>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Init_d__1>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Init_d__1>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Init_d__1>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_sm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Init_d__1>.NativeClassPtr, "sm");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Init_d__1>.NativeClassPtr, 100671995);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Init_d__1>.NativeClassPtr, 100671996);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Init_d__1>.NativeClassPtr, 100671997);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Init_d__1>.NativeClassPtr, 100671998);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Init_d__1>.NativeClassPtr, 100671999);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Init_d__1>.NativeClassPtr, 100672000);
		}

		public _Init_d__1(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_currentStage;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Virtual_IEnumerator_SceneManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnTakeMission_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnTakeOffFenderFinished_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnTakeOnFenderStarted_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnTakeOnFenderFinished_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareFluid_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSwitchCarPart_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPartSelectMode_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnZeroFluid_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnHidePart_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnHideTool_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareChangeOil_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnCarLifterUp_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnToolMoveToCarLifter_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnToolUse_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnOilDrainFinished_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEquipmentReturn_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPartSelectMode3_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnHidePartFinished3_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnMountFinished4_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnCarLifterMid_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSwitchCarPart2_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPartSelectMode5_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnHidePart2_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnHideTool2_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareChangeWheel_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPartSelectModeChangeWheel_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSelectToUnMount_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnHidePartFinished_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareTireChanger_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSeparate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSeparateFinished_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnWheelTake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnWheelConnect_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnWheelConnectFinished_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnWheelTakeConnected_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnWheelBalance_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnWheelBalanceFinished_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnWheelTakeFromBalancer_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPartSelectMode2_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnShow_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnMountFinished_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareChangeAbsorber_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPartSelectModeChangeAbsorber_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSelectToUnMountChangeAbsorber_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnHideWheelFinished_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSelectToUnMountSwayBarFrontEndLink_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnHideSwayBarFrontEndLinkFinished_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSelectToUnMountAbsorber_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnHideAbsorberFinished_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareSpringClamp_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSeparateChangeAbsorber_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSeparateFinishedChangeAbsorber_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnTake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnConnect_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnConnectFinished_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnTakeConnected_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPartSelectMode2ChangeAbsorber_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnShowChangeAbsorber_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnMountFinishedChangeAbsorber_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnShowSwayBarFrontEndLink_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnMountSwayBarFrontEndLinkFinished_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnShowRim_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnMountRimFinished_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEndJob_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HighlightPartScripts_Private_Static_Void_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPlaceForLoadCar_Public_Virtual_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TakeJob>.NativeClassPtr));

	public unsafe int currentStage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentStage);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentStage)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128863, XrefRangeEnd = 128866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe IEnumerator Init(SceneManager sm)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(sm);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Init_Public_Virtual_IEnumerator_SceneManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128866, XrefRangeEnd = 128905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnTakeMission()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnTakeMission_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128905, XrefRangeEnd = 128946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnTakeOffFenderFinished()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnTakeOffFenderFinished_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128946, XrefRangeEnd = 128971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnTakeOnFenderStarted()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnTakeOnFenderStarted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128971, XrefRangeEnd = 129005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnTakeOnFenderFinished()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnTakeOnFenderFinished_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 129045, RefRangeEnd = 129046, XrefRangeStart = 129005, XrefRangeEnd = 129045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareFluid()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareFluid_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129046, XrefRangeEnd = 129089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSwitchCarPart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSwitchCarPart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129089, XrefRangeEnd = 129124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPartSelectMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPartSelectMode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129124, XrefRangeEnd = 129183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnZeroFluid()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnZeroFluid_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129183, XrefRangeEnd = 129220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnHidePart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnHidePart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129220, XrefRangeEnd = 129260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnHideTool()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnHideTool_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 129298, RefRangeEnd = 129299, XrefRangeStart = 129260, XrefRangeEnd = 129298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareChangeOil()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareChangeOil_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129299, XrefRangeEnd = 129334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnCarLifterUp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnCarLifterUp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129334, XrefRangeEnd = 129364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnToolMoveToCarLifter()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnToolMoveToCarLifter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129364, XrefRangeEnd = 129392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnToolUse()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnToolUse_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129392, XrefRangeEnd = 129426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnOilDrainFinished()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnOilDrainFinished_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129426, XrefRangeEnd = 129465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEquipmentReturn()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEquipmentReturn_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129465, XrefRangeEnd = 129500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPartSelectMode3()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPartSelectMode3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129500, XrefRangeEnd = 129542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnHidePartFinished3()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnHidePartFinished3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129542, XrefRangeEnd = 129588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnMountFinished4()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnMountFinished4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129588, XrefRangeEnd = 129626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnCarLifterMid()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnCarLifterMid_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 129660, RefRangeEnd = 129661, XrefRangeStart = 129626, XrefRangeEnd = 129660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSwitchCarPart2()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSwitchCarPart2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129661, XrefRangeEnd = 129696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPartSelectMode5()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPartSelectMode5_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129696, XrefRangeEnd = 129726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnHidePart2()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnHidePart2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129726, XrefRangeEnd = 129763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnHideTool2()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnHideTool2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 129794, RefRangeEnd = 129795, XrefRangeStart = 129763, XrefRangeEnd = 129794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareChangeWheel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareChangeWheel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129795, XrefRangeEnd = 129838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPartSelectModeChangeWheel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPartSelectModeChangeWheel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129838, XrefRangeEnd = 129861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSelectToUnMount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSelectToUnMount_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129861, XrefRangeEnd = 129878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnHidePartFinished()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnHidePartFinished_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 129913, RefRangeEnd = 129914, XrefRangeStart = 129878, XrefRangeEnd = 129913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareTireChanger()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareTireChanger_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129914, XrefRangeEnd = 129932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSeparate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSeparate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129932, XrefRangeEnd = 129962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSeparateFinished()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSeparateFinished_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129962, XrefRangeEnd = 130002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnWheelTake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnWheelTake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130002, XrefRangeEnd = 130020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnWheelConnect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnWheelConnect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130020, XrefRangeEnd = 130046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnWheelConnectFinished()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnWheelConnectFinished_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130046, XrefRangeEnd = 130094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnWheelTakeConnected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnWheelTakeConnected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130094, XrefRangeEnd = 130115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnWheelBalance()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnWheelBalance_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130115, XrefRangeEnd = 130142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnWheelBalanceFinished()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnWheelBalanceFinished_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130142, XrefRangeEnd = 130182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnWheelTakeFromBalancer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnWheelTakeFromBalancer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130182, XrefRangeEnd = 130249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPartSelectMode2()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPartSelectMode2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130249, XrefRangeEnd = 130281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnShow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnShow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130281, XrefRangeEnd = 130335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnMountFinished()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnMountFinished_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 130363, RefRangeEnd = 130364, XrefRangeStart = 130335, XrefRangeEnd = 130363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareChangeAbsorber()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareChangeAbsorber_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130364, XrefRangeEnd = 130407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPartSelectModeChangeAbsorber()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPartSelectModeChangeAbsorber_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130407, XrefRangeEnd = 130430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSelectToUnMountChangeAbsorber()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSelectToUnMountChangeAbsorber_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130430, XrefRangeEnd = 130460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnHideWheelFinished()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnHideWheelFinished_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130460, XrefRangeEnd = 130483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSelectToUnMountSwayBarFrontEndLink()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSelectToUnMountSwayBarFrontEndLink_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130483, XrefRangeEnd = 130513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnHideSwayBarFrontEndLinkFinished()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnHideSwayBarFrontEndLinkFinished_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130513, XrefRangeEnd = 130536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSelectToUnMountAbsorber()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSelectToUnMountAbsorber_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130536, XrefRangeEnd = 130562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnHideAbsorberFinished()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnHideAbsorberFinished_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 130582, RefRangeEnd = 130583, XrefRangeStart = 130562, XrefRangeEnd = 130582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareSpringClamp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareSpringClamp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130583, XrefRangeEnd = 130601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSeparateChangeAbsorber()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSeparateChangeAbsorber_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130601, XrefRangeEnd = 130631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSeparateFinishedChangeAbsorber()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSeparateFinishedChangeAbsorber_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130631, XrefRangeEnd = 130671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnTake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnTake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130671, XrefRangeEnd = 130689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnConnect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnConnect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130689, XrefRangeEnd = 130719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnConnectFinished()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnConnectFinished_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130719, XrefRangeEnd = 130770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnTakeConnected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnTakeConnected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130770, XrefRangeEnd = 130819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPartSelectMode2ChangeAbsorber()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPartSelectMode2ChangeAbsorber_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130819, XrefRangeEnd = 130851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnShowChangeAbsorber()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnShowChangeAbsorber_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130851, XrefRangeEnd = 130892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnMountFinishedChangeAbsorber()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnMountFinishedChangeAbsorber_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130892, XrefRangeEnd = 130915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnShowSwayBarFrontEndLink()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnShowSwayBarFrontEndLink_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130915, XrefRangeEnd = 130964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnMountSwayBarFrontEndLinkFinished()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnMountSwayBarFrontEndLinkFinished_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130964, XrefRangeEnd = 130987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnShowRim()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnShowRim_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130987, XrefRangeEnd = 131038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnMountRimFinished()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnMountRimFinished_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131038, XrefRangeEnd = 131067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEndJob()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEndJob_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 131072, RefRangeEnd = 131087, XrefRangeStart = 131067, XrefRangeEnd = 131072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HighlightPartScripts(GameObject go, bool on)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &on;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HighlightPartScripts_Private_Static_Void_GameObject_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131087, XrefRangeEnd = 131091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe CarLoader GetPlaceForLoadCar()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetPlaceForLoadCar_Public_Virtual_CarLoader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new CarLoader(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe TakeJob()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TakeJob>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static TakeJob()
	{
		Il2CppClassPointerStore<TakeJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Tutorial.Tasks", "TakeJob");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TakeJob>.NativeClassPtr);
		NativeFieldInfoPtr_currentStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, "currentStage");
		NativeMethodInfoPtr_Init_Public_Virtual_IEnumerator_SceneManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671927);
		NativeMethodInfoPtr_OnTakeMission_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671928);
		NativeMethodInfoPtr_OnTakeOffFenderFinished_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671929);
		NativeMethodInfoPtr_OnTakeOnFenderStarted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671930);
		NativeMethodInfoPtr_OnTakeOnFenderFinished_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671931);
		NativeMethodInfoPtr_PrepareFluid_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671932);
		NativeMethodInfoPtr_OnSwitchCarPart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671933);
		NativeMethodInfoPtr_OnPartSelectMode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671934);
		NativeMethodInfoPtr_OnZeroFluid_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671935);
		NativeMethodInfoPtr_OnHidePart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671936);
		NativeMethodInfoPtr_OnHideTool_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671937);
		NativeMethodInfoPtr_PrepareChangeOil_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671938);
		NativeMethodInfoPtr_OnCarLifterUp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671939);
		NativeMethodInfoPtr_OnToolMoveToCarLifter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671940);
		NativeMethodInfoPtr_OnToolUse_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671941);
		NativeMethodInfoPtr_OnOilDrainFinished_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671942);
		NativeMethodInfoPtr_OnEquipmentReturn_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671943);
		NativeMethodInfoPtr_OnPartSelectMode3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671944);
		NativeMethodInfoPtr_OnHidePartFinished3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671945);
		NativeMethodInfoPtr_OnMountFinished4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671946);
		NativeMethodInfoPtr_OnCarLifterMid_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671947);
		NativeMethodInfoPtr_OnSwitchCarPart2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671948);
		NativeMethodInfoPtr_OnPartSelectMode5_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671949);
		NativeMethodInfoPtr_OnHidePart2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671950);
		NativeMethodInfoPtr_OnHideTool2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671951);
		NativeMethodInfoPtr_PrepareChangeWheel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671952);
		NativeMethodInfoPtr_OnPartSelectModeChangeWheel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671953);
		NativeMethodInfoPtr_OnSelectToUnMount_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671954);
		NativeMethodInfoPtr_OnHidePartFinished_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671955);
		NativeMethodInfoPtr_PrepareTireChanger_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671956);
		NativeMethodInfoPtr_OnSeparate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671957);
		NativeMethodInfoPtr_OnSeparateFinished_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671958);
		NativeMethodInfoPtr_OnWheelTake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671959);
		NativeMethodInfoPtr_OnWheelConnect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671960);
		NativeMethodInfoPtr_OnWheelConnectFinished_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671961);
		NativeMethodInfoPtr_OnWheelTakeConnected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671962);
		NativeMethodInfoPtr_OnWheelBalance_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671963);
		NativeMethodInfoPtr_OnWheelBalanceFinished_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671964);
		NativeMethodInfoPtr_OnWheelTakeFromBalancer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671965);
		NativeMethodInfoPtr_OnPartSelectMode2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671966);
		NativeMethodInfoPtr_OnShow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671967);
		NativeMethodInfoPtr_OnMountFinished_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671968);
		NativeMethodInfoPtr_PrepareChangeAbsorber_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671969);
		NativeMethodInfoPtr_OnPartSelectModeChangeAbsorber_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671970);
		NativeMethodInfoPtr_OnSelectToUnMountChangeAbsorber_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671971);
		NativeMethodInfoPtr_OnHideWheelFinished_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671972);
		NativeMethodInfoPtr_OnSelectToUnMountSwayBarFrontEndLink_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671973);
		NativeMethodInfoPtr_OnHideSwayBarFrontEndLinkFinished_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671974);
		NativeMethodInfoPtr_OnSelectToUnMountAbsorber_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671975);
		NativeMethodInfoPtr_OnHideAbsorberFinished_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671976);
		NativeMethodInfoPtr_PrepareSpringClamp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671977);
		NativeMethodInfoPtr_OnSeparateChangeAbsorber_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671978);
		NativeMethodInfoPtr_OnSeparateFinishedChangeAbsorber_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671979);
		NativeMethodInfoPtr_OnTake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671980);
		NativeMethodInfoPtr_OnConnect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671981);
		NativeMethodInfoPtr_OnConnectFinished_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671982);
		NativeMethodInfoPtr_OnTakeConnected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671983);
		NativeMethodInfoPtr_OnPartSelectMode2ChangeAbsorber_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671984);
		NativeMethodInfoPtr_OnShowChangeAbsorber_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671985);
		NativeMethodInfoPtr_OnMountFinishedChangeAbsorber_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671986);
		NativeMethodInfoPtr_OnShowSwayBarFrontEndLink_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671987);
		NativeMethodInfoPtr_OnMountSwayBarFrontEndLinkFinished_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671988);
		NativeMethodInfoPtr_OnShowRim_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671989);
		NativeMethodInfoPtr_OnMountRimFinished_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671990);
		NativeMethodInfoPtr_OnEndJob_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671991);
		NativeMethodInfoPtr_HighlightPartScripts_Private_Static_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671992);
		NativeMethodInfoPtr_GetPlaceForLoadCar_Public_Virtual_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671993);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeJob>.NativeClassPtr, 100671994);
	}

	public TakeJob(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
