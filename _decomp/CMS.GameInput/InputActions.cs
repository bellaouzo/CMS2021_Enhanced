using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace CMS.GameInput;

public static class InputActions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Action;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIEnter;

	private static readonly System.IntPtr NativeFieldInfoPtr_UICancel;

	private static readonly System.IntPtr NativeFieldInfoPtr_Scroll;

	private static readonly System.IntPtr NativeFieldInfoPtr_Cross;

	private static readonly System.IntPtr NativeFieldInfoPtr_Horizontal;

	private static readonly System.IntPtr NativeFieldInfoPtr_Vertical;

	private static readonly System.IntPtr NativeFieldInfoPtr_ExitFromMechanic;

	private static readonly System.IntPtr NativeFieldInfoPtr_SubmitModifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_Orbit;

	private static readonly System.IntPtr NativeFieldInfoPtr_Flashlight;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIButton1;

	private static readonly System.IntPtr NativeFieldInfoPtr_PreviousPage;

	private static readonly System.IntPtr NativeFieldInfoPtr_NextPage;

	private static readonly System.IntPtr NativeFieldInfoPtr_VerticalUp;

	private static readonly System.IntPtr NativeFieldInfoPtr_VerticalDown;

	private static readonly System.IntPtr NativeFieldInfoPtr_HorizontalLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_HorizontalRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_PreviousTab;

	private static readonly System.IntPtr NativeFieldInfoPtr_NextTab;

	private static readonly System.IntPtr NativeFieldInfoPtr_DeclineOrder;

	private static readonly System.IntPtr NativeFieldInfoPtr_Paint;

	private static readonly System.IntPtr NativeFieldInfoPtr_EditLivery;

	private static readonly System.IntPtr NativeFieldInfoPtr_RestoreColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_SwitchTab;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChangeActiveWarehouse;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChangeWarehouseName;

	private static readonly System.IntPtr NativeFieldInfoPtr_DeleteProfile;

	private static readonly System.IntPtr NativeFieldInfoPtr_StartNewGame;

	private static readonly System.IntPtr NativeFieldInfoPtr_SubmitMiniGame;

	private static readonly System.IntPtr NativeFieldInfoPtr_Changelog;

	private static readonly System.IntPtr NativeFieldInfoPtr_ResetSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_RunBenchmark;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChangeUser;

	private static readonly System.IntPtr NativeFieldInfoPtr_VerticalCar;

	private static readonly System.IntPtr NativeFieldInfoPtr_Throttle;

	private static readonly System.IntPtr NativeFieldInfoPtr_Brake;

	private static readonly System.IntPtr NativeFieldInfoPtr_Back;

	private static readonly System.IntPtr NativeFieldInfoPtr_OpenCloseShopList;

	private static readonly System.IntPtr NativeFieldInfoPtr_RemoveShopListItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_Search;

	private static readonly System.IntPtr NativeFieldInfoPtr_SellParts;

	private static readonly System.IntPtr NativeFieldInfoPtr_Sort;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChangeGarageLookCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_HideSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_PhotoFocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_TakePhoto;

	private static readonly System.IntPtr NativeFieldInfoPtr_HideGUI;

	private static readonly System.IntPtr NativeFieldInfoPtr_ResetPhotoSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_UnlockUpgrade;

	private static readonly System.IntPtr NativeFieldInfoPtr_BuyUpgrade;

	private static readonly System.IntPtr NativeFieldInfoPtr_ResetUpgrade;

	private static readonly System.IntPtr NativeFieldInfoPtr_MoveCarToGarage;

	private static readonly System.IntPtr NativeFieldInfoPtr_SwapCarOnParking;

	private static readonly System.IntPtr NativeFieldInfoPtr_GoToParking;

	private static readonly System.IntPtr NativeFieldInfoPtr_AddToShopList;

	private static readonly System.IntPtr NativeFieldInfoPtr_AddToShopListMechanic;

	private static readonly System.IntPtr NativeFieldInfoPtr_AddToShopListUI;

	private static readonly System.IntPtr NativeFieldInfoPtr_BuyTakenParts;

	private static readonly System.IntPtr NativeFieldInfoPtr_QuitWithoutTakenParts;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShowCarOnParking;

	private static readonly System.IntPtr NativeFieldInfoPtr_ToggleOrbitCameraParking;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChangeWheelsSide;

	private static readonly System.IntPtr NativeFieldInfoPtr_StartAuction;

	private static readonly System.IntPtr NativeFieldInfoPtr_Bid;

	private static readonly System.IntPtr NativeFieldInfoPtr_ReceiveCar;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIMarkUnmarkPart;

	private static readonly System.IntPtr NativeFieldInfoPtr_NextCase;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<InputActions>.NativeClassPtr));

	public unsafe static string Action
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Action, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Action, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string UIEnter
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIEnter, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIEnter, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string UICancel
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UICancel, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UICancel, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string Scroll
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Scroll, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Scroll, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string Cross
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Cross, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Cross, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string Horizontal
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Horizontal, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Horizontal, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string Vertical
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Vertical, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Vertical, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string ExitFromMechanic
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ExitFromMechanic, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ExitFromMechanic, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string SubmitModifier
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SubmitModifier, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SubmitModifier, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string Orbit
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Orbit, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Orbit, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string Flashlight
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Flashlight, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Flashlight, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string UIButton1
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIButton1, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIButton1, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string PreviousPage
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PreviousPage, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PreviousPage, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string NextPage
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NextPage, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NextPage, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string VerticalUp
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_VerticalUp, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_VerticalUp, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string VerticalDown
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_VerticalDown, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_VerticalDown, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string HorizontalLeft
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HorizontalLeft, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HorizontalLeft, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string HorizontalRight
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HorizontalRight, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HorizontalRight, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string PreviousTab
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PreviousTab, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PreviousTab, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string NextTab
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NextTab, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NextTab, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string DeclineOrder
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DeclineOrder, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DeclineOrder, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string Paint
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Paint, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Paint, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string EditLivery
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EditLivery, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EditLivery, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string RestoreColor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RestoreColor, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RestoreColor, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string SwitchTab
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SwitchTab, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SwitchTab, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string ChangeActiveWarehouse
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ChangeActiveWarehouse, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ChangeActiveWarehouse, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string ChangeWarehouseName
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ChangeWarehouseName, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ChangeWarehouseName, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string DeleteProfile
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DeleteProfile, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DeleteProfile, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string StartNewGame
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_StartNewGame, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_StartNewGame, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string SubmitMiniGame
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SubmitMiniGame, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SubmitMiniGame, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string Changelog
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Changelog, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Changelog, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string ResetSettings
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ResetSettings, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ResetSettings, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string RunBenchmark
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RunBenchmark, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RunBenchmark, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string ChangeUser
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ChangeUser, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ChangeUser, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string VerticalCar
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_VerticalCar, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_VerticalCar, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string Throttle
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Throttle, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Throttle, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string Brake
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Brake, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Brake, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string Back
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Back, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Back, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string OpenCloseShopList
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OpenCloseShopList, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OpenCloseShopList, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string RemoveShopListItem
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RemoveShopListItem, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RemoveShopListItem, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string Search
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Search, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Search, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string SellParts
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SellParts, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SellParts, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string Sort
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Sort, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Sort, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string ChangeGarageLookCamera
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ChangeGarageLookCamera, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ChangeGarageLookCamera, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string HideSettings
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HideSettings, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HideSettings, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string PhotoFocus
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PhotoFocus, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PhotoFocus, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string TakePhoto
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TakePhoto, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TakePhoto, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string HideGUI
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HideGUI, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HideGUI, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string ResetPhotoSettings
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ResetPhotoSettings, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ResetPhotoSettings, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string UnlockUpgrade
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UnlockUpgrade, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UnlockUpgrade, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string BuyUpgrade
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BuyUpgrade, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BuyUpgrade, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string ResetUpgrade
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ResetUpgrade, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ResetUpgrade, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string MoveCarToGarage
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MoveCarToGarage, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MoveCarToGarage, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string SwapCarOnParking
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SwapCarOnParking, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SwapCarOnParking, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string GoToParking
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GoToParking, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GoToParking, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string AddToShopList
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AddToShopList, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AddToShopList, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string AddToShopListMechanic
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AddToShopListMechanic, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AddToShopListMechanic, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string AddToShopListUI
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AddToShopListUI, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AddToShopListUI, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string BuyTakenParts
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BuyTakenParts, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BuyTakenParts, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string QuitWithoutTakenParts
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_QuitWithoutTakenParts, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_QuitWithoutTakenParts, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string ShowCarOnParking
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ShowCarOnParking, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ShowCarOnParking, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string ToggleOrbitCameraParking
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ToggleOrbitCameraParking, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ToggleOrbitCameraParking, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string ChangeWheelsSide
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ChangeWheelsSide, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ChangeWheelsSide, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string StartAuction
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_StartAuction, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_StartAuction, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string Bid
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Bid, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Bid, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string ReceiveCar
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ReceiveCar, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ReceiveCar, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string UIMarkUnmarkPart
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UIMarkUnmarkPart, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UIMarkUnmarkPart, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string NextCase
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NextCase, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NextCase, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	static InputActions()
	{
		Il2CppClassPointerStore<InputActions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.GameInput", "InputActions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputActions>.NativeClassPtr);
		NativeFieldInfoPtr_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "Action");
		NativeFieldInfoPtr_UIEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "UIEnter");
		NativeFieldInfoPtr_UICancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "UICancel");
		NativeFieldInfoPtr_Scroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "Scroll");
		NativeFieldInfoPtr_Cross = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "Cross");
		NativeFieldInfoPtr_Horizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "Horizontal");
		NativeFieldInfoPtr_Vertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "Vertical");
		NativeFieldInfoPtr_ExitFromMechanic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "ExitFromMechanic");
		NativeFieldInfoPtr_SubmitModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "SubmitModifier");
		NativeFieldInfoPtr_Orbit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "Orbit");
		NativeFieldInfoPtr_Flashlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "Flashlight");
		NativeFieldInfoPtr_UIButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "UIButton1");
		NativeFieldInfoPtr_PreviousPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "PreviousPage");
		NativeFieldInfoPtr_NextPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "NextPage");
		NativeFieldInfoPtr_VerticalUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "VerticalUp");
		NativeFieldInfoPtr_VerticalDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "VerticalDown");
		NativeFieldInfoPtr_HorizontalLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "HorizontalLeft");
		NativeFieldInfoPtr_HorizontalRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "HorizontalRight");
		NativeFieldInfoPtr_PreviousTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "PreviousTab");
		NativeFieldInfoPtr_NextTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "NextTab");
		NativeFieldInfoPtr_DeclineOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "DeclineOrder");
		NativeFieldInfoPtr_Paint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "Paint");
		NativeFieldInfoPtr_EditLivery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "EditLivery");
		NativeFieldInfoPtr_RestoreColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "RestoreColor");
		NativeFieldInfoPtr_SwitchTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "SwitchTab");
		NativeFieldInfoPtr_ChangeActiveWarehouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "ChangeActiveWarehouse");
		NativeFieldInfoPtr_ChangeWarehouseName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "ChangeWarehouseName");
		NativeFieldInfoPtr_DeleteProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "DeleteProfile");
		NativeFieldInfoPtr_StartNewGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "StartNewGame");
		NativeFieldInfoPtr_SubmitMiniGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "SubmitMiniGame");
		NativeFieldInfoPtr_Changelog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "Changelog");
		NativeFieldInfoPtr_ResetSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "ResetSettings");
		NativeFieldInfoPtr_RunBenchmark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "RunBenchmark");
		NativeFieldInfoPtr_ChangeUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "ChangeUser");
		NativeFieldInfoPtr_VerticalCar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "VerticalCar");
		NativeFieldInfoPtr_Throttle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "Throttle");
		NativeFieldInfoPtr_Brake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "Brake");
		NativeFieldInfoPtr_Back = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "Back");
		NativeFieldInfoPtr_OpenCloseShopList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "OpenCloseShopList");
		NativeFieldInfoPtr_RemoveShopListItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "RemoveShopListItem");
		NativeFieldInfoPtr_Search = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "Search");
		NativeFieldInfoPtr_SellParts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "SellParts");
		NativeFieldInfoPtr_Sort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "Sort");
		NativeFieldInfoPtr_ChangeGarageLookCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "ChangeGarageLookCamera");
		NativeFieldInfoPtr_HideSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "HideSettings");
		NativeFieldInfoPtr_PhotoFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "PhotoFocus");
		NativeFieldInfoPtr_TakePhoto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "TakePhoto");
		NativeFieldInfoPtr_HideGUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "HideGUI");
		NativeFieldInfoPtr_ResetPhotoSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "ResetPhotoSettings");
		NativeFieldInfoPtr_UnlockUpgrade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "UnlockUpgrade");
		NativeFieldInfoPtr_BuyUpgrade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "BuyUpgrade");
		NativeFieldInfoPtr_ResetUpgrade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "ResetUpgrade");
		NativeFieldInfoPtr_MoveCarToGarage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "MoveCarToGarage");
		NativeFieldInfoPtr_SwapCarOnParking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "SwapCarOnParking");
		NativeFieldInfoPtr_GoToParking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "GoToParking");
		NativeFieldInfoPtr_AddToShopList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "AddToShopList");
		NativeFieldInfoPtr_AddToShopListMechanic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "AddToShopListMechanic");
		NativeFieldInfoPtr_AddToShopListUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "AddToShopListUI");
		NativeFieldInfoPtr_BuyTakenParts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "BuyTakenParts");
		NativeFieldInfoPtr_QuitWithoutTakenParts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "QuitWithoutTakenParts");
		NativeFieldInfoPtr_ShowCarOnParking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "ShowCarOnParking");
		NativeFieldInfoPtr_ToggleOrbitCameraParking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "ToggleOrbitCameraParking");
		NativeFieldInfoPtr_ChangeWheelsSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "ChangeWheelsSide");
		NativeFieldInfoPtr_StartAuction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "StartAuction");
		NativeFieldInfoPtr_Bid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "Bid");
		NativeFieldInfoPtr_ReceiveCar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "ReceiveCar");
		NativeFieldInfoPtr_UIMarkUnmarkPart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "UIMarkUnmarkPart");
		NativeFieldInfoPtr_NextCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActions>.NativeClassPtr, "NextCase");
	}

	public InputActions(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
