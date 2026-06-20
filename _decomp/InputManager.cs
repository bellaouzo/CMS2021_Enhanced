using System;
using System.Runtime.CompilerServices;
using CMS.UI.Logic;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Rewired;
using Rewired.ControllerExtensions;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

[System.Serializable]
public class InputManager : Il2CppSystem.Object
{
	[ObfuscatedName("InputManager/<EnableMouseInputOnMouseMove>d__28")]
	public sealed class _EnableMouseInputOnMouseMove_d__28 : Il2CppSystem.Object
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
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_EnableMouseInputOnMouseMove_d__28>.NativeClassPtr));

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

		public unsafe InputManager __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new InputManager(intPtr) : null;
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
		public unsafe _EnableMouseInputOnMouseMove_d__28(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_EnableMouseInputOnMouseMove_d__28>.NativeClassPtr))
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57829, XrefRangeEnd = 57844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57844, XrefRangeEnd = 57849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _EnableMouseInputOnMouseMove_d__28()
		{
			Il2CppClassPointerStore<_EnableMouseInputOnMouseMove_d__28>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "<EnableMouseInputOnMouseMove>d__28");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_EnableMouseInputOnMouseMove_d__28>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_EnableMouseInputOnMouseMove_d__28>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_EnableMouseInputOnMouseMove_d__28>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_EnableMouseInputOnMouseMove_d__28>.NativeClassPtr, "<>4__this");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_EnableMouseInputOnMouseMove_d__28>.NativeClassPtr, 100666776);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_EnableMouseInputOnMouseMove_d__28>.NativeClassPtr, 100666777);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_EnableMouseInputOnMouseMove_d__28>.NativeClassPtr, 100666778);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_EnableMouseInputOnMouseMove_d__28>.NativeClassPtr, 100666779);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_EnableMouseInputOnMouseMove_d__28>.NativeClassPtr, 100666780);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_EnableMouseInputOnMouseMove_d__28>.NativeClassPtr, 100666781);
		}

		public _EnableMouseInputOnMouseMove_d__28(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__Player_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_LastUsedController;

	private static readonly System.IntPtr NativeFieldInfoPtr_playstationControllerState;

	private static readonly System.IntPtr NativeFieldInfoPtr_isGamepadSupportForced;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasDualShockExtension;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasDualSenseExtension;

	private static readonly System.IntPtr NativeFieldInfoPtr_ps4ControllerExtension;

	private static readonly System.IntPtr NativeFieldInfoPtr_dualSenseExtension;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultPlaystationColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastRequestedColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasRequestedColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_waitingForMouseMove;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Player_Public_get_Player_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Player_Private_set_Void_Player_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlaystationControllerState_Public_get_PlaystationControllerState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsPlaystationControllerUsed_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsXboxControllerUsed_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsControllerUsed_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsMouseUsed_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsGamepadSupportForced_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableMouseInputOnMouseMove_Public_IEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwitchGamepadSupport_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnActiveControllerChanged_Private_Void_Controller_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValidGamepad_Private_Static_Boolean_Controller_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshCursorVisibility_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecognizeController_Public_Void_Controller_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAssignedButton_Public_String_ControllerType_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAssignedButtons_Public_List_1_String_ControllerType_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeInput_Public_Void_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnablePhotoModeInput_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CarInputEnable_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonTimePressed_Public_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayHorizontal_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayVertical_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayRun_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayRunDown_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayMouseX_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayMouseY_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayCrouchUp_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayCrouch_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayActionButtonDown_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayActionButtonUp_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayActionButton_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayInventoryButton_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayOrdersButton_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayTabletButton_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayPieMenuButtonDown_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayCameraZoomAxis_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayMapButton_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayOpenShopListButton_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayMechanicLeftStickX_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayMechanicLeftStickY_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayMechanicRightStickX_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayMechanicRightStickY_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayMechanicRightStickXRaw_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayMechanicRightStickYRaw_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayMechanicLeftShoulder2_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayMechanicRightShoulder2_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayMechanicActionButtonDown_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayMechanicActionButtonUp_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayMechanicActionButton_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayMechanicExitButtonDown_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayMechanicInventoryButton_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayMechanicOrdersButton_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayMechanicTabletButton_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayMechanicPieMenuButtonDown_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GameplayMechanicOpenShopListButton_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UIEnterButtonDown_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UISubmitButtonDown_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UISubmitAltDown_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UICancelButtonDown_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UIMouseHorizontal_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UIMouseVertical_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PieMenuHorizontal_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PieMenuVertical_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UIHorizontalButtonLeftDown_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UIHorizontalButtonRightDown_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UIHorizontalButtonLeft_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UIHorizontalButtonRight_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UIVerticalButtonUpDown_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UIVerticalButtonDownDown_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UIVerticalButtonUp_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UIVerticalButtonDown_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CarHorizontal_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CarHorizontalRaw_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CarVertical_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CarBrakeAxis_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CarThrottleAxis_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CarHandbrake_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GearUp_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GearDown_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CarChangeCamera_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CarLookAtOpponent_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CarThrottle_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CarLights_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeTCSMode_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeECSMode_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetGamepadState_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetDualShockState_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetDualSenseState_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLight_Public_Void_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetLight_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartVibration_Public_Void_Int32_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopVibration_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<InputManager>.NativeClassPtr));

	public unsafe Player _Player_k__BackingField
	{
		get
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Player_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr == (System.IntPtr)0) ? ((Player)null) : new Player(intPtr);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Player_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe ControllerType LastUsedController
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastUsedController);
			return System.Runtime.CompilerServices.Unsafe.Read<ControllerType>((void*)num);
		}
		set
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			System.Runtime.CompilerServices.Unsafe.Write((void*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastUsedController)), val);
		}
	}

	public unsafe PlaystationControllerState playstationControllerState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playstationControllerState);
			return *(PlaystationControllerState*)num;
		}
		set
		{
			*(PlaystationControllerState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playstationControllerState)) = playstationControllerState;
		}
	}

	public unsafe bool isGamepadSupportForced
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isGamepadSupportForced);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isGamepadSupportForced)) = flag;
		}
	}

	public unsafe bool hasDualShockExtension
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasDualShockExtension);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasDualShockExtension)) = flag;
		}
	}

	public unsafe bool hasDualSenseExtension
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasDualSenseExtension);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasDualSenseExtension)) = flag;
		}
	}

	public unsafe DualShock4Extension ps4ControllerExtension
	{
		get
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ps4ControllerExtension);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr == (System.IntPtr)0) ? ((DualShock4Extension)null) : new DualShock4Extension(intPtr);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ps4ControllerExtension), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe DualSenseExtension dualSenseExtension
	{
		get
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dualSenseExtension);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr == (System.IntPtr)0) ? ((DualSenseExtension)null) : new DualSenseExtension(intPtr);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dualSenseExtension), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe Color defaultPlaystationColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultPlaystationColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultPlaystationColor)) = color;
		}
	}

	public unsafe Color32 lastRequestedColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastRequestedColor);
			return *(Color32*)num;
		}
		set
		{
			*(Color32*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastRequestedColor)) = color;
		}
	}

	public unsafe bool hasRequestedColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasRequestedColor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasRequestedColor)) = flag;
		}
	}

	public unsafe bool waitingForMouseMove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waitingForMouseMove);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waitingForMouseMove)) = flag;
		}
	}

	public unsafe Player Player
	{
		[CallerCount(1)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Player_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr == (System.IntPtr)0) ? ((Player)null) : new Player(intPtr);
		}
		[CallerCount(77)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Player_Private_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe PlaystationControllerState PlaystationControllerState
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlaystationControllerState_Public_get_PlaystationControllerState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(PlaystationControllerState*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe bool IsPlaystationControllerUsed
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsPlaystationControllerUsed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe bool IsXboxControllerUsed
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsXboxControllerUsed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe bool IsControllerUsed
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsControllerUsed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe bool IsMouseUsed
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsMouseUsed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe bool IsGamepadSupportForced
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsGamepadSupportForced_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 57869, RefRangeEnd = 57870, XrefRangeStart = 57849, XrefRangeEnd = 57869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 57873, RefRangeEnd = 57877, XrefRangeStart = 57870, XrefRangeEnd = 57873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator EnableMouseInputOnMouseMove()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableMouseInputOnMouseMove_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 57887, RefRangeEnd = 57891, XrefRangeStart = 57877, XrefRangeEnd = 57887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SwitchGamepadSupport(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwitchGamepadSupport_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57891, XrefRangeEnd = 57906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnActiveControllerChanged(Controller controller)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controller);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnActiveControllerChanged_Private_Void_Controller_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 57914, RefRangeEnd = 57916, XrefRangeStart = 57906, XrefRangeEnd = 57914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsValidGamepad(Controller controller)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controller);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValidGamepad_Private_Static_Boolean_Controller_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57916, XrefRangeEnd = 57951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshCursorVisibility()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshCursorVisibility_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 57968, RefRangeEnd = 57972, XrefRangeStart = 57951, XrefRangeEnd = 57968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RecognizeController(Controller controller)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controller);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecognizeController_Public_Void_Controller_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 57990, RefRangeEnd = 57991, XrefRangeStart = 57972, XrefRangeEnd = 57990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetAssignedButton(ControllerType controller, string actionName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&controller);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(actionName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAssignedButton_Public_String_ControllerType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 58019, RefRangeEnd = 58020, XrefRangeStart = 57991, XrefRangeEnd = 58019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<string> GetAssignedButtons(ControllerType controller, string actionName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&controller);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(actionName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAssignedButtons_Public_List_1_String_ControllerType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
	}

	[CallerCount(87)]
	[CachedScanResults(RefRangeStart = 58030, RefRangeEnd = 58117, XrefRangeStart = 58020, XrefRangeEnd = 58030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeInput(bool gameplay, bool gameplayMechanic, bool UI)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&gameplay);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &gameplayMechanic;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &UI;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeInput_Public_Void_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 58121, RefRangeEnd = 58122, XrefRangeStart = 58117, XrefRangeEnd = 58121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnablePhotoModeInput(bool enable = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnablePhotoModeInput_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 58126, RefRangeEnd = 58138, XrefRangeStart = 58122, XrefRangeEnd = 58126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CarInputEnable(bool enable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CarInputEnable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58138, XrefRangeEnd = 58139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetButtonTimePressed(string buttonID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(buttonID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetButtonTimePressed_Public_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58139, XrefRangeEnd = 58143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GameplayHorizontal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayHorizontal_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58143, XrefRangeEnd = 58147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GameplayVertical()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayVertical_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58147, XrefRangeEnd = 58151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GameplayRun()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayRun_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58151, XrefRangeEnd = 58155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GameplayRunDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayRunDown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 58159, RefRangeEnd = 58160, XrefRangeStart = 58155, XrefRangeEnd = 58159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GameplayMouseX()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayMouseX_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 58164, RefRangeEnd = 58165, XrefRangeStart = 58160, XrefRangeEnd = 58164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GameplayMouseY()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayMouseY_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58165, XrefRangeEnd = 58169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GameplayCrouchUp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayCrouchUp_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58169, XrefRangeEnd = 58173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GameplayCrouch()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayCrouch_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 58177, RefRangeEnd = 58180, XrefRangeStart = 58173, XrefRangeEnd = 58177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GameplayActionButtonDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayActionButtonDown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 58184, RefRangeEnd = 58188, XrefRangeStart = 58180, XrefRangeEnd = 58184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GameplayActionButtonUp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayActionButtonUp_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 58192, RefRangeEnd = 58195, XrefRangeStart = 58188, XrefRangeEnd = 58192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GameplayActionButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayActionButton_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58195, XrefRangeEnd = 58199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GameplayInventoryButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayInventoryButton_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58199, XrefRangeEnd = 58203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GameplayOrdersButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayOrdersButton_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58203, XrefRangeEnd = 58207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GameplayTabletButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayTabletButton_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58207, XrefRangeEnd = 58211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GameplayPieMenuButtonDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayPieMenuButtonDown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 58215, RefRangeEnd = 58216, XrefRangeStart = 58211, XrefRangeEnd = 58215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GameplayCameraZoomAxis()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayCameraZoomAxis_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58216, XrefRangeEnd = 58220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GameplayMapButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayMapButton_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58220, XrefRangeEnd = 58224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GameplayOpenShopListButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayOpenShopListButton_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58224, XrefRangeEnd = 58228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GameplayMechanicLeftStickX()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayMechanicLeftStickX_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58228, XrefRangeEnd = 58232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GameplayMechanicLeftStickY()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayMechanicLeftStickY_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 58236, RefRangeEnd = 58238, XrefRangeStart = 58232, XrefRangeEnd = 58236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GameplayMechanicRightStickX()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayMechanicRightStickX_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 58242, RefRangeEnd = 58243, XrefRangeStart = 58238, XrefRangeEnd = 58242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GameplayMechanicRightStickY()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayMechanicRightStickY_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58243, XrefRangeEnd = 58247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GameplayMechanicRightStickXRaw()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayMechanicRightStickXRaw_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58247, XrefRangeEnd = 58251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GameplayMechanicRightStickYRaw()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayMechanicRightStickYRaw_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58251, XrefRangeEnd = 58255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GameplayMechanicLeftShoulder2()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayMechanicLeftShoulder2_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58255, XrefRangeEnd = 58259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GameplayMechanicRightShoulder2()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayMechanicRightShoulder2_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 58263, RefRangeEnd = 58273, XrefRangeStart = 58259, XrefRangeEnd = 58263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GameplayMechanicActionButtonDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayMechanicActionButtonDown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 58277, RefRangeEnd = 58281, XrefRangeStart = 58273, XrefRangeEnd = 58277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GameplayMechanicActionButtonUp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayMechanicActionButtonUp_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 58285, RefRangeEnd = 58290, XrefRangeStart = 58281, XrefRangeEnd = 58285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GameplayMechanicActionButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayMechanicActionButton_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 58294, RefRangeEnd = 58296, XrefRangeStart = 58290, XrefRangeEnd = 58294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GameplayMechanicExitButtonDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayMechanicExitButtonDown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58296, XrefRangeEnd = 58300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GameplayMechanicInventoryButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayMechanicInventoryButton_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58300, XrefRangeEnd = 58304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GameplayMechanicOrdersButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayMechanicOrdersButton_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58304, XrefRangeEnd = 58308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GameplayMechanicTabletButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayMechanicTabletButton_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58308, XrefRangeEnd = 58312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GameplayMechanicPieMenuButtonDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayMechanicPieMenuButtonDown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58312, XrefRangeEnd = 58316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GameplayMechanicOpenShopListButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameplayMechanicOpenShopListButton_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58316, XrefRangeEnd = 58320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UIEnterButtonDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UIEnterButtonDown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58320, XrefRangeEnd = 58324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UISubmitButtonDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UISubmitButtonDown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58324, XrefRangeEnd = 58328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UISubmitAltDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UISubmitAltDown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58328, XrefRangeEnd = 58332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UICancelButtonDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UICancelButtonDown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 58336, RefRangeEnd = 58338, XrefRangeStart = 58332, XrefRangeEnd = 58336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float UIMouseHorizontal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UIMouseHorizontal_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 58342, RefRangeEnd = 58344, XrefRangeStart = 58338, XrefRangeEnd = 58342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float UIMouseVertical()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UIMouseVertical_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58344, XrefRangeEnd = 58348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float PieMenuHorizontal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PieMenuHorizontal_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58348, XrefRangeEnd = 58352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float PieMenuVertical()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PieMenuVertical_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58352, XrefRangeEnd = 58356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UIHorizontalButtonLeftDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UIHorizontalButtonLeftDown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58356, XrefRangeEnd = 58360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UIHorizontalButtonRightDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UIHorizontalButtonRightDown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58360, XrefRangeEnd = 58364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UIHorizontalButtonLeft()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UIHorizontalButtonLeft_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58364, XrefRangeEnd = 58368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UIHorizontalButtonRight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UIHorizontalButtonRight_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58368, XrefRangeEnd = 58372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UIVerticalButtonUpDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UIVerticalButtonUpDown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58372, XrefRangeEnd = 58376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UIVerticalButtonDownDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UIVerticalButtonDownDown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58376, XrefRangeEnd = 58380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UIVerticalButtonUp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UIVerticalButtonUp_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58380, XrefRangeEnd = 58384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UIVerticalButtonDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UIVerticalButtonDown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58384, XrefRangeEnd = 58388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CarHorizontal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CarHorizontal_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 58392, RefRangeEnd = 58393, XrefRangeStart = 58388, XrefRangeEnd = 58392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CarHorizontalRaw()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CarHorizontalRaw_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 58397, RefRangeEnd = 58399, XrefRangeStart = 58393, XrefRangeEnd = 58397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CarVertical()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CarVertical_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 58403, RefRangeEnd = 58405, XrefRangeStart = 58399, XrefRangeEnd = 58403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CarBrakeAxis()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CarBrakeAxis_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 58409, RefRangeEnd = 58411, XrefRangeStart = 58405, XrefRangeEnd = 58409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CarThrottleAxis()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CarThrottleAxis_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58411, XrefRangeEnd = 58415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CarHandbrake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CarHandbrake_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58415, XrefRangeEnd = 58419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GearUp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GearUp_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58419, XrefRangeEnd = 58423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GearDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GearDown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58423, XrefRangeEnd = 58427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CarChangeCamera()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CarChangeCamera_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58427, XrefRangeEnd = 58431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CarLookAtOpponent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CarLookAtOpponent_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 58431, RefRangeEnd = 58432, XrefRangeStart = 58431, XrefRangeEnd = 58431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CarThrottle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CarThrottle_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58432, XrefRangeEnd = 58436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CarLights()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CarLights_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58436, XrefRangeEnd = 58440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ChangeTCSMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeTCSMode_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58440, XrefRangeEnd = 58444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ChangeECSMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeECSMode_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 58446, RefRangeEnd = 58447, XrefRangeStart = 58444, XrefRangeEnd = 58446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetGamepadState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetGamepadState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58447, XrefRangeEnd = 58448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetDualShockState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetDualShockState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58448, XrefRangeEnd = 58449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetDualSenseState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetDualSenseState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 58452, RefRangeEnd = 58454, XrefRangeStart = 58449, XrefRangeEnd = 58452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLight(Color color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&color);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLight_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 58456, RefRangeEnd = 58458, XrefRangeStart = 58454, XrefRangeEnd = 58456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetLight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetLight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58458, XrefRangeEnd = 58467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartVibration(int index, float motorLevel, float duration)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&index);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &motorLevel;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &duration;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartVibration_Public_Void_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58467, XrefRangeEnd = 58492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopVibration()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopVibration_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe InputManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static InputManager()
	{
		Il2CppClassPointerStore<InputManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "InputManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputManager>.NativeClassPtr);
		NativeFieldInfoPtr__Player_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "<Player>k__BackingField");
		NativeFieldInfoPtr_LastUsedController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "LastUsedController");
		NativeFieldInfoPtr_playstationControllerState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "playstationControllerState");
		NativeFieldInfoPtr_isGamepadSupportForced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "isGamepadSupportForced");
		NativeFieldInfoPtr_hasDualShockExtension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "hasDualShockExtension");
		NativeFieldInfoPtr_hasDualSenseExtension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "hasDualSenseExtension");
		NativeFieldInfoPtr_ps4ControllerExtension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "ps4ControllerExtension");
		NativeFieldInfoPtr_dualSenseExtension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "dualSenseExtension");
		NativeFieldInfoPtr_defaultPlaystationColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "defaultPlaystationColor");
		NativeFieldInfoPtr_lastRequestedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "lastRequestedColor");
		NativeFieldInfoPtr_hasRequestedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "hasRequestedColor");
		NativeFieldInfoPtr_waitingForMouseMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, "waitingForMouseMove");
		NativeMethodInfoPtr_get_Player_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666682);
		NativeMethodInfoPtr_set_Player_Private_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666683);
		NativeMethodInfoPtr_get_PlaystationControllerState_Public_get_PlaystationControllerState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666684);
		NativeMethodInfoPtr_get_IsPlaystationControllerUsed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666685);
		NativeMethodInfoPtr_get_IsXboxControllerUsed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666686);
		NativeMethodInfoPtr_get_IsControllerUsed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666687);
		NativeMethodInfoPtr_get_IsMouseUsed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666688);
		NativeMethodInfoPtr_get_IsGamepadSupportForced_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666689);
		NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666690);
		NativeMethodInfoPtr_EnableMouseInputOnMouseMove_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666691);
		NativeMethodInfoPtr_SwitchGamepadSupport_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666692);
		NativeMethodInfoPtr_OnActiveControllerChanged_Private_Void_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666693);
		NativeMethodInfoPtr_IsValidGamepad_Private_Static_Boolean_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666694);
		NativeMethodInfoPtr_RefreshCursorVisibility_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666695);
		NativeMethodInfoPtr_RecognizeController_Public_Void_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666696);
		NativeMethodInfoPtr_GetAssignedButton_Public_String_ControllerType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666697);
		NativeMethodInfoPtr_GetAssignedButtons_Public_List_1_String_ControllerType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666698);
		NativeMethodInfoPtr_ChangeInput_Public_Void_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666699);
		NativeMethodInfoPtr_EnablePhotoModeInput_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666700);
		NativeMethodInfoPtr_CarInputEnable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666701);
		NativeMethodInfoPtr_GetButtonTimePressed_Public_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666702);
		NativeMethodInfoPtr_GameplayHorizontal_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666703);
		NativeMethodInfoPtr_GameplayVertical_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666704);
		NativeMethodInfoPtr_GameplayRun_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666705);
		NativeMethodInfoPtr_GameplayRunDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666706);
		NativeMethodInfoPtr_GameplayMouseX_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666707);
		NativeMethodInfoPtr_GameplayMouseY_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666708);
		NativeMethodInfoPtr_GameplayCrouchUp_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666709);
		NativeMethodInfoPtr_GameplayCrouch_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666710);
		NativeMethodInfoPtr_GameplayActionButtonDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666711);
		NativeMethodInfoPtr_GameplayActionButtonUp_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666712);
		NativeMethodInfoPtr_GameplayActionButton_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666713);
		NativeMethodInfoPtr_GameplayInventoryButton_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666714);
		NativeMethodInfoPtr_GameplayOrdersButton_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666715);
		NativeMethodInfoPtr_GameplayTabletButton_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666716);
		NativeMethodInfoPtr_GameplayPieMenuButtonDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666717);
		NativeMethodInfoPtr_GameplayCameraZoomAxis_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666718);
		NativeMethodInfoPtr_GameplayMapButton_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666719);
		NativeMethodInfoPtr_GameplayOpenShopListButton_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666720);
		NativeMethodInfoPtr_GameplayMechanicLeftStickX_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666721);
		NativeMethodInfoPtr_GameplayMechanicLeftStickY_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666722);
		NativeMethodInfoPtr_GameplayMechanicRightStickX_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666723);
		NativeMethodInfoPtr_GameplayMechanicRightStickY_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666724);
		NativeMethodInfoPtr_GameplayMechanicRightStickXRaw_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666725);
		NativeMethodInfoPtr_GameplayMechanicRightStickYRaw_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666726);
		NativeMethodInfoPtr_GameplayMechanicLeftShoulder2_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666727);
		NativeMethodInfoPtr_GameplayMechanicRightShoulder2_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666728);
		NativeMethodInfoPtr_GameplayMechanicActionButtonDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666729);
		NativeMethodInfoPtr_GameplayMechanicActionButtonUp_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666730);
		NativeMethodInfoPtr_GameplayMechanicActionButton_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666731);
		NativeMethodInfoPtr_GameplayMechanicExitButtonDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666732);
		NativeMethodInfoPtr_GameplayMechanicInventoryButton_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666733);
		NativeMethodInfoPtr_GameplayMechanicOrdersButton_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666734);
		NativeMethodInfoPtr_GameplayMechanicTabletButton_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666735);
		NativeMethodInfoPtr_GameplayMechanicPieMenuButtonDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666736);
		NativeMethodInfoPtr_GameplayMechanicOpenShopListButton_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666737);
		NativeMethodInfoPtr_UIEnterButtonDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666738);
		NativeMethodInfoPtr_UISubmitButtonDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666739);
		NativeMethodInfoPtr_UISubmitAltDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666740);
		NativeMethodInfoPtr_UICancelButtonDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666741);
		NativeMethodInfoPtr_UIMouseHorizontal_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666742);
		NativeMethodInfoPtr_UIMouseVertical_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666743);
		NativeMethodInfoPtr_PieMenuHorizontal_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666744);
		NativeMethodInfoPtr_PieMenuVertical_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666745);
		NativeMethodInfoPtr_UIHorizontalButtonLeftDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666746);
		NativeMethodInfoPtr_UIHorizontalButtonRightDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666747);
		NativeMethodInfoPtr_UIHorizontalButtonLeft_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666748);
		NativeMethodInfoPtr_UIHorizontalButtonRight_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666749);
		NativeMethodInfoPtr_UIVerticalButtonUpDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666750);
		NativeMethodInfoPtr_UIVerticalButtonDownDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666751);
		NativeMethodInfoPtr_UIVerticalButtonUp_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666752);
		NativeMethodInfoPtr_UIVerticalButtonDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666753);
		NativeMethodInfoPtr_CarHorizontal_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666754);
		NativeMethodInfoPtr_CarHorizontalRaw_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666755);
		NativeMethodInfoPtr_CarVertical_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666756);
		NativeMethodInfoPtr_CarBrakeAxis_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666757);
		NativeMethodInfoPtr_CarThrottleAxis_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666758);
		NativeMethodInfoPtr_CarHandbrake_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666759);
		NativeMethodInfoPtr_GearUp_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666760);
		NativeMethodInfoPtr_GearDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666761);
		NativeMethodInfoPtr_CarChangeCamera_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666762);
		NativeMethodInfoPtr_CarLookAtOpponent_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666763);
		NativeMethodInfoPtr_CarThrottle_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666764);
		NativeMethodInfoPtr_CarLights_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666765);
		NativeMethodInfoPtr_ChangeTCSMode_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666766);
		NativeMethodInfoPtr_ChangeECSMode_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666767);
		NativeMethodInfoPtr_ResetGamepadState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666768);
		NativeMethodInfoPtr_ResetDualShockState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666769);
		NativeMethodInfoPtr_ResetDualSenseState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666770);
		NativeMethodInfoPtr_SetLight_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666771);
		NativeMethodInfoPtr_ResetLight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666772);
		NativeMethodInfoPtr_StartVibration_Public_Void_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666773);
		NativeMethodInfoPtr_StopVibration_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666774);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100666775);
	}

	public InputManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
