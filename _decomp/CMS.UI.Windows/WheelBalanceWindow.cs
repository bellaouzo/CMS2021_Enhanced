using System;
using System.Runtime.CompilerServices;
using CMS.UI.Description;
using CMS.UI.Logic;
using CMS.UI.Logic.WheelBalance;
using CMS.UI.Windows.Base;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.UI.Windows;

public class WheelBalanceWindow : Window
{
	[ObfuscatedName("CMS.UI.Windows.WheelBalanceWindow/<UpdateLightColor>d__23")]
	public sealed class _UpdateLightColor_d__23 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_UpdateLightColor_d__23>.NativeClassPtr));

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

		public unsafe WheelBalanceWindow __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new WheelBalanceWindow(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
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
		public unsafe _UpdateLightColor_d__23(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_UpdateLightColor_d__23>.NativeClassPtr))
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177390, XrefRangeEnd = 177394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177394, XrefRangeEnd = 177399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _UpdateLightColor_d__23()
		{
			Il2CppClassPointerStore<_UpdateLightColor_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, "<UpdateLightColor>d__23");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_UpdateLightColor_d__23>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_UpdateLightColor_d__23>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_UpdateLightColor_d__23>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_UpdateLightColor_d__23>.NativeClassPtr, "<>4__this");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_UpdateLightColor_d__23>.NativeClassPtr, 100676092);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_UpdateLightColor_d__23>.NativeClassPtr, 100676093);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_UpdateLightColor_d__23>.NativeClassPtr, 100676094);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_UpdateLightColor_d__23>.NativeClassPtr, 100676095);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_UpdateLightColor_d__23>.NativeClassPtr, 100676096);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_UpdateLightColor_d__23>.NativeClassPtr, 100676097);
		}

		public _UpdateLightColor_d__23(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CMS.UI.Windows.WheelBalanceWindow/<>c__DisplayClass34_0")]
	public sealed class __c__DisplayClass34_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_destinationAngle;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Rotate_b__0_Internal_Void_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Rotate_b__1_Internal_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass34_0>.NativeClassPtr));

		public unsafe WheelBalanceWindow __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new WheelBalanceWindow(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe int destinationAngle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationAngle);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destinationAngle)) = num;
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass34_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass34_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177399, XrefRangeEnd = 177408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Rotate_b__0(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&val);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Rotate_b__0_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177408, XrefRangeEnd = 177409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Rotate_b__1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Rotate_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass34_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, "<>c__DisplayClass34_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass34_0>.NativeClassPtr);
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass34_0>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_destinationAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass34_0>.NativeClassPtr, "destinationAngle");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass34_0>.NativeClassPtr, 100676098);
			NativeMethodInfoPtr__Rotate_b__0_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass34_0>.NativeClassPtr, 100676099);
			NativeMethodInfoPtr__Rotate_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass34_0>.NativeClassPtr, 100676100);
		}

		public __c__DisplayClass34_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_topMenu;

	private static readonly System.IntPtr NativeFieldInfoPtr_BGMenu;

	private static readonly System.IntPtr NativeFieldInfoPtr_choosePartDownWindow;

	private static readonly System.IntPtr NativeFieldInfoPtr_wheelSlices;

	private static readonly System.IntPtr NativeFieldInfoPtr_wheelTransform;

	private static readonly System.IntPtr NativeFieldInfoPtr_wheelDots;

	private static readonly System.IntPtr NativeFieldInfoPtr_angles;

	private static readonly System.IntPtr NativeFieldInfoPtr_sliceIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentRealIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_successIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_isGameInProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_howMany;

	private static readonly System.IntPtr NativeFieldInfoPtr_done;

	private static readonly System.IntPtr NativeFieldInfoPtr_TimeToHold;

	private static readonly System.IntPtr NativeFieldInfoPtr_holdTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_forTutorial;

	private static readonly System.IntPtr NativeFieldInfoPtr_uiDescription;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterItself_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterItself_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_Virtual_Boolean_ArrayOf_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Public_Virtual_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableUI_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLightColor_Private_IEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareTopMenu_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareDots_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshDots_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareAnglesArray_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NextSlice_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreviousSlice_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentSliceAngle_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateSliceIndex_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareWheelSlices_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FillAllWheelSlices_Private_Void_BarType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rotate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BalanceAction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CancelAction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareDescriptions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDescriptionActions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDefaultDescription_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartMiniGame_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopMiniGame_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetGame_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSuccess_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessGameResult_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_VibrateIfSuccess_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePlaystationControllerColor_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInputManager_Public_Virtual_Final_New_Void_InputManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleRotateLeftInput_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleRotateRightInput_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleSubmitGameInput_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr));

	public unsafe TopMenu topMenu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_topMenu);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new TopMenu(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_topMenu), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject BGMenu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BGMenu);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BGMenu), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ChoosePartDownWindow choosePartDownWindow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_choosePartDownWindow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ChoosePartDownWindow(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_choosePartDownWindow), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<WheelSlice> wheelSlices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelSlices);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<WheelSlice>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelSlices), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform wheelTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelTransform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelTransform), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<WheelDot> wheelDots
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelDots);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<WheelDot>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelDots), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<int> angles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angles);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<int>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angles), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int sliceIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sliceIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sliceIndex)) = num;
		}
	}

	public unsafe int currentRealIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentRealIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentRealIndex)) = num;
		}
	}

	public unsafe int successIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_successIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_successIndex)) = num;
		}
	}

	public unsafe bool isGameInProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isGameInProgress);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isGameInProgress)) = flag;
		}
	}

	public unsafe int howMany
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_howMany);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_howMany)) = num;
		}
	}

	public unsafe int done
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_done);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_done)) = num;
		}
	}

	public unsafe static float TimeToHold
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TimeToHold, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TimeToHold, &num);
		}
	}

	public unsafe float holdTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_holdTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_holdTime)) = num;
		}
	}

	public unsafe InputManager inputManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool forTutorial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forTutorial);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forTutorial)) = flag;
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177409, XrefRangeEnd = 177415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void RegisterItself()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_RegisterItself_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177415, XrefRangeEnd = 177423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void UnregisterItself()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_UnregisterItself_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177423, XrefRangeEnd = 177456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe bool Show(Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Show_Public_Virtual_Boolean_ArrayOf_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177456, XrefRangeEnd = 177494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe bool Hide(bool hiddenFromOutside)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hiddenFromOutside);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Hide_Public_Virtual_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 177504, RefRangeEnd = 177506, XrefRangeStart = 177494, XrefRangeEnd = 177504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableUI(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableUI_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177506, XrefRangeEnd = 177509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator UpdateLightColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateLightColor_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177509, XrefRangeEnd = 177511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareTopMenu()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareTopMenu_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177530, RefRangeEnd = 177531, XrefRangeStart = 177511, XrefRangeEnd = 177530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareDots()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareDots_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177547, RefRangeEnd = 177548, XrefRangeStart = 177531, XrefRangeEnd = 177547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshDots()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshDots_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177562, RefRangeEnd = 177563, XrefRangeStart = 177548, XrefRangeEnd = 177562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareAnglesArray()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareAnglesArray_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177570, RefRangeEnd = 177571, XrefRangeStart = 177563, XrefRangeEnd = 177570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NextSlice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextSlice_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177578, RefRangeEnd = 177579, XrefRangeStart = 177571, XrefRangeEnd = 177578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreviousSlice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreviousSlice_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe int GetCurrentSliceAngle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentSliceAngle_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177579, XrefRangeEnd = 177584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GenerateSliceIndex()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateSliceIndex_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177607, RefRangeEnd = 177608, XrefRangeStart = 177584, XrefRangeEnd = 177607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareWheelSlices()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareWheelSlices_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177608, XrefRangeEnd = 177610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FillAllWheelSlices(BarType barType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&barType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillAllWheelSlices_Private_Void_BarType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 177646, RefRangeEnd = 177648, XrefRangeStart = 177610, XrefRangeEnd = 177646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Rotate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rotate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177648, XrefRangeEnd = 177656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BalanceAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BalanceAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177656, XrefRangeEnd = 177660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CancelAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CancelAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177689, RefRangeEnd = 177690, XrefRangeStart = 177660, XrefRangeEnd = 177689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareDescriptions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareDescriptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177690, XrefRangeEnd = 177708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveDescriptionActions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveDescriptionActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177708, XrefRangeEnd = 177721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDefaultDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDefaultDescription_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177743, RefRangeEnd = 177744, XrefRangeStart = 177721, XrefRangeEnd = 177743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartMiniGame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartMiniGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177744, XrefRangeEnd = 177745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopMiniGame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopMiniGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177770, RefRangeEnd = 177771, XrefRangeStart = 177745, XrefRangeEnd = 177770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetGame(bool fullReset = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&fullReset);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetGame_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool IsSuccess()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSuccess_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 177772, RefRangeEnd = 177775, XrefRangeStart = 177771, XrefRangeEnd = 177772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessGameResult()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessGameResult_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177775, XrefRangeEnd = 177784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void VibrateIfSuccess()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VibrateIfSuccess_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 177794, RefRangeEnd = 177796, XrefRangeStart = 177784, XrefRangeEnd = 177794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePlaystationControllerColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdatePlaystationControllerColor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(23)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void SetInputManager(InputManager manager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(manager);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInputManager_Public_Virtual_Final_New_Void_InputManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177796, XrefRangeEnd = 177803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HandleRotateLeftInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleRotateLeftInput_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177803, XrefRangeEnd = 177810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HandleRotateRightInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleRotateRightInput_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177810, XrefRangeEnd = 177813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HandleSubmitGameInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleSubmitGameInput_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177813, XrefRangeEnd = 177824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HandleInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177824, XrefRangeEnd = 177827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WheelBalanceWindow()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static WheelBalanceWindow()
	{
		Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Windows", "WheelBalanceWindow");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr);
		NativeFieldInfoPtr_topMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, "topMenu");
		NativeFieldInfoPtr_BGMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, "BGMenu");
		NativeFieldInfoPtr_choosePartDownWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, "choosePartDownWindow");
		NativeFieldInfoPtr_wheelSlices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, "wheelSlices");
		NativeFieldInfoPtr_wheelTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, "wheelTransform");
		NativeFieldInfoPtr_wheelDots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, "wheelDots");
		NativeFieldInfoPtr_angles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, "angles");
		NativeFieldInfoPtr_sliceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, "sliceIndex");
		NativeFieldInfoPtr_currentRealIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, "currentRealIndex");
		NativeFieldInfoPtr_successIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, "successIndex");
		NativeFieldInfoPtr_isGameInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, "isGameInProgress");
		NativeFieldInfoPtr_howMany = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, "howMany");
		NativeFieldInfoPtr_done = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, "done");
		NativeFieldInfoPtr_TimeToHold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, "TimeToHold");
		NativeFieldInfoPtr_holdTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, "holdTime");
		NativeFieldInfoPtr_inputManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, "inputManager");
		NativeFieldInfoPtr_forTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, "forTutorial");
		NativeFieldInfoPtr_uiDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, "uiDescription");
		NativeMethodInfoPtr_RegisterItself_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676057);
		NativeMethodInfoPtr_UnregisterItself_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676058);
		NativeMethodInfoPtr_Show_Public_Virtual_Boolean_ArrayOf_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676059);
		NativeMethodInfoPtr_Hide_Public_Virtual_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676060);
		NativeMethodInfoPtr_EnableUI_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676061);
		NativeMethodInfoPtr_UpdateLightColor_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676062);
		NativeMethodInfoPtr_PrepareTopMenu_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676063);
		NativeMethodInfoPtr_PrepareDots_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676064);
		NativeMethodInfoPtr_RefreshDots_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676065);
		NativeMethodInfoPtr_PrepareAnglesArray_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676066);
		NativeMethodInfoPtr_NextSlice_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676067);
		NativeMethodInfoPtr_PreviousSlice_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676068);
		NativeMethodInfoPtr_GetCurrentSliceAngle_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676069);
		NativeMethodInfoPtr_GenerateSliceIndex_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676070);
		NativeMethodInfoPtr_PrepareWheelSlices_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676071);
		NativeMethodInfoPtr_FillAllWheelSlices_Private_Void_BarType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676072);
		NativeMethodInfoPtr_Rotate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676073);
		NativeMethodInfoPtr_BalanceAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676074);
		NativeMethodInfoPtr_CancelAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676075);
		NativeMethodInfoPtr_PrepareDescriptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676076);
		NativeMethodInfoPtr_RemoveDescriptionActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676077);
		NativeMethodInfoPtr_SetDefaultDescription_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676078);
		NativeMethodInfoPtr_StartMiniGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676079);
		NativeMethodInfoPtr_StopMiniGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676080);
		NativeMethodInfoPtr_ResetGame_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676081);
		NativeMethodInfoPtr_IsSuccess_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676082);
		NativeMethodInfoPtr_ProcessGameResult_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676083);
		NativeMethodInfoPtr_VibrateIfSuccess_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676084);
		NativeMethodInfoPtr_UpdatePlaystationControllerColor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676085);
		NativeMethodInfoPtr_SetInputManager_Public_Virtual_Final_New_Void_InputManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676086);
		NativeMethodInfoPtr_HandleRotateLeftInput_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676087);
		NativeMethodInfoPtr_HandleRotateRightInput_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676088);
		NativeMethodInfoPtr_HandleSubmitGameInput_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676089);
		NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676090);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelBalanceWindow>.NativeClassPtr, 100676091);
	}

	public WheelBalanceWindow(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
