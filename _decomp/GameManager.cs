using System;
using System.Runtime.CompilerServices;
using CMS.Cache;
using CMS.Difficulty;
using CMS.Events;
using CMS.Managers;
using CMS.Platforms;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[System.Serializable]
public class GameManager : Singleton<GameManager>
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Inventory;

	private static readonly System.IntPtr NativeFieldInfoPtr_Warehouse;

	private static readonly System.IntPtr NativeFieldInfoPtr__tempInventory;

	private static readonly System.IntPtr NativeFieldInfoPtr__carBundleLoader;

	private static readonly System.IntPtr NativeFieldInfoPtr_bonusPartsManager;

	private static readonly System.IntPtr NativeFieldInfoPtr__RDGPlayerPrefs;

	private static readonly System.IntPtr NativeFieldInfoPtr__localization;

	private static readonly System.IntPtr NativeFieldInfoPtr__carBundleManager;

	private static readonly System.IntPtr NativeFieldInfoPtr__rustmapManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_liveriesManager;

	private static readonly System.IntPtr NativeFieldInfoPtr__difficultyManager;

	private static readonly System.IntPtr NativeFieldInfoPtr__FPSInputController;

	private static readonly System.IntPtr NativeFieldInfoPtr__inputManager;

	private static readonly System.IntPtr NativeFieldInfoPtr__partScriptCullerManager;

	private static readonly System.IntPtr NativeFieldInfoPtr__profileManager;

	private static readonly System.IntPtr NativeFieldInfoPtr__upgradeSystem;

	private static readonly System.IntPtr NativeFieldInfoPtr__gameDataManager;

	private static readonly System.IntPtr NativeFieldInfoPtr__platformManager;

	private static readonly System.IntPtr NativeFieldInfoPtr__engineAudioController;

	private static readonly System.IntPtr NativeFieldInfoPtr__engineStartAudio;

	private static readonly System.IntPtr NativeFieldInfoPtr_OrderGenerator;

	private static readonly System.IntPtr NativeFieldInfoPtr_CarLoadersInScene;

	private static readonly System.IntPtr NativeFieldInfoPtr_Radio;

	private static readonly System.IntPtr NativeFieldInfoPtr__xboxConnectedStorageManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_screenshotsManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_cacheManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_eventManager;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TempInventory_Public_get_TempInventory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_TempInventory_Private_set_Void_TempInventory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CarBundleLoader_Public_get_CarBundleLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_CarBundleLoader_Private_set_Void_CarBundleLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BonusPartsManager_Public_get_BonusPartsManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_BonusPartsManager_Private_set_Void_BonusPartsManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RDGPlayerPrefs_Public_get_RDGPlayerPrefs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_RDGPlayerPrefs_Private_set_Void_RDGPlayerPrefs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Localization_Public_get_Localization_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Localization_Private_set_Void_Localization_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CarBundleManager_Public_get_CarBundleManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_CarBundleManager_Private_set_Void_CarBundleManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RustmapManager_Public_get_RustmapManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_RustmapManager_Private_set_Void_RustmapManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LiveriesManager_Public_get_LiveriesManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_LiveriesManager_Private_set_Void_LiveriesManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DifficultyManager_Public_get_DifficultyManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_DifficultyManager_Private_set_Void_DifficultyManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_FPSInputController_Public_get_FPSInputController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_FPSInputController_Private_set_Void_FPSInputController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_InputManager_Public_get_InputManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_InputManager_Private_set_Void_InputManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PartScriptCullerManager_Public_get_PartScriptCullerManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_PartScriptCullerManager_Private_set_Void_PartScriptCullerManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ProfileManager_Public_get_ProfileManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ProfileManager_Private_set_Void_ProfileManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UpgradeSystem_Public_get_UpgradeSystem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_UpgradeSystem_Private_set_Void_UpgradeSystem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_GameDataManager_Public_get_GameDataManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_GameDataManager_Private_set_Void_GameDataManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlatformManager_Public_get_PlatformManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_PlatformManager_Private_set_Void_PlatformManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_EngineAudioController_Public_get_EngineAudioController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_EngineAudioController_Private_set_Void_EngineAudioController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_EngineStartAudio_Public_get_EngineStartAudio_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_EngineStartAudio_Private_set_Void_EngineStartAudio_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_XboxConnectedStorageManager_Public_get_XboxConnectedStorageManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_XboxConnectedStorageManager_Private_set_Void_XboxConnectedStorageManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ScreenshotsManager_Public_get_ScreenshotsManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ScreenshotsManager_Private_set_Void_ScreenshotsManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CacheManager_Public_get_CacheManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_CacheManager_Private_set_Void_CacheManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_EventManager_Public_get_EventManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_EventManager_Private_set_Void_EventManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GameManager>.NativeClassPtr));

	public unsafe Inventory Inventory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Inventory);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Inventory(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Inventory), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Warehouse Warehouse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Warehouse);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Warehouse(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Warehouse), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TempInventory _tempInventory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__tempInventory);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new TempInventory(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__tempInventory), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CarBundleLoader _carBundleLoader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__carBundleLoader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CarBundleLoader(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__carBundleLoader), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BonusPartsManager bonusPartsManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bonusPartsManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new BonusPartsManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bonusPartsManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RDGPlayerPrefs _RDGPlayerPrefs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RDGPlayerPrefs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RDGPlayerPrefs(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RDGPlayerPrefs), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Localization _localization
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__localization);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Localization(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__localization), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CarBundleManager _carBundleManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__carBundleManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CarBundleManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__carBundleManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RustmapManager _rustmapManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rustmapManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RustmapManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rustmapManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe LiveriesManager liveriesManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_liveriesManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new LiveriesManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_liveriesManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DifficultyManager _difficultyManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__difficultyManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DifficultyManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__difficultyManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe FPSInputController _FPSInputController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FPSInputController);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new FPSInputController(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FPSInputController), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InputManager _inputManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new InputManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PartScriptCullerManager _partScriptCullerManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__partScriptCullerManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PartScriptCullerManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__partScriptCullerManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ProfileManager _profileManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__profileManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ProfileManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__profileManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe UpgradeSystem _upgradeSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__upgradeSystem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new UpgradeSystem(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__upgradeSystem), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameDataManager _gameDataManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__gameDataManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameDataManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__gameDataManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlatformManager _platformManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__platformManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PlatformManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__platformManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe EngineAudioController _engineAudioController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__engineAudioController);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new EngineAudioController(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__engineAudioController), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe EngineStartAudio _engineStartAudio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__engineStartAudio);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new EngineStartAudio(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__engineStartAudio), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe OrderGenerator OrderGenerator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OrderGenerator);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new OrderGenerator(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OrderGenerator), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<CarLoader> CarLoadersInScene
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarLoadersInScene);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<CarLoader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarLoadersInScene), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Radio Radio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Radio);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Radio(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Radio), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe XboxConnectedStorageManager _xboxConnectedStorageManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__xboxConnectedStorageManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new XboxConnectedStorageManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__xboxConnectedStorageManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ScreenshotsManager screenshotsManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenshotsManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ScreenshotsManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenshotsManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CacheManager cacheManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cacheManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CacheManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cacheManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe EventManager eventManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new EventManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TempInventory TempInventory
	{
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 99067, RefRangeEnd = 99087, XrefRangeStart = 99058, XrefRangeEnd = 99067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TempInventory_Public_get_TempInventory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new TempInventory(intPtr) : null;
		}
		[CallerCount(150)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_TempInventory_Private_set_Void_TempInventory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe CarBundleLoader CarBundleLoader
	{
		[CallerCount(164)]
		[CachedScanResults(RefRangeStart = 99104, RefRangeEnd = 99268, XrefRangeStart = 99087, XrefRangeEnd = 99104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CarBundleLoader_Public_get_CarBundleLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new CarBundleLoader(intPtr) : null;
		}
		[CallerCount(24)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CarBundleLoader_Private_set_Void_CarBundleLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe BonusPartsManager BonusPartsManager
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 99281, RefRangeEnd = 99288, XrefRangeStart = 99268, XrefRangeEnd = 99281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BonusPartsManager_Public_get_BonusPartsManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new BonusPartsManager(intPtr) : null;
		}
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 99288, RefRangeEnd = 99332, XrefRangeStart = 99288, XrefRangeEnd = 99288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_BonusPartsManager_Private_set_Void_BonusPartsManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe RDGPlayerPrefs RDGPlayerPrefs
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 99335, RefRangeEnd = 99345, XrefRangeStart = 99332, XrefRangeEnd = 99335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RDGPlayerPrefs_Public_get_RDGPlayerPrefs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new RDGPlayerPrefs(intPtr) : null;
		}
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 99345, RefRangeEnd = 99381, XrefRangeStart = 99345, XrefRangeEnd = 99345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_RDGPlayerPrefs_Private_set_Void_RDGPlayerPrefs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Localization Localization
	{
		[CallerCount(65)]
		[CachedScanResults(RefRangeStart = 99388, RefRangeEnd = 99453, XrefRangeStart = 99381, XrefRangeEnd = 99388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Localization_Public_get_Localization_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Localization(intPtr) : null;
		}
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 99453, RefRangeEnd = 99473, XrefRangeStart = 99453, XrefRangeEnd = 99453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Localization_Private_set_Void_Localization_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe CarBundleManager CarBundleManager
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 99482, RefRangeEnd = 99488, XrefRangeStart = 99473, XrefRangeEnd = 99482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CarBundleManager_Public_get_CarBundleManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new CarBundleManager(intPtr) : null;
		}
		[CallerCount(27)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CarBundleManager_Private_set_Void_CarBundleManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe RustmapManager RustmapManager
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 99491, RefRangeEnd = 99495, XrefRangeStart = 99488, XrefRangeEnd = 99491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RustmapManager_Public_get_RustmapManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new RustmapManager(intPtr) : null;
		}
		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_RustmapManager_Private_set_Void_RustmapManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe LiveriesManager LiveriesManager
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 99504, RefRangeEnd = 99518, XrefRangeStart = 99495, XrefRangeEnd = 99504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LiveriesManager_Public_get_LiveriesManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new LiveriesManager(intPtr) : null;
		}
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 99518, RefRangeEnd = 99559, XrefRangeStart = 99518, XrefRangeEnd = 99518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LiveriesManager_Private_set_Void_LiveriesManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe DifficultyManager DifficultyManager
	{
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 99576, RefRangeEnd = 99607, XrefRangeStart = 99559, XrefRangeEnd = 99576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DifficultyManager_Public_get_DifficultyManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new DifficultyManager(intPtr) : null;
		}
		[CallerCount(17)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DifficultyManager_Private_set_Void_DifficultyManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe FPSInputController FPSInputController
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 99625, RefRangeEnd = 99629, XrefRangeStart = 99607, XrefRangeEnd = 99625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FPSInputController_Public_get_FPSInputController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new FPSInputController(intPtr) : null;
		}
		[CallerCount(32)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_FPSInputController_Private_set_Void_FPSInputController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe InputManager InputManager
	{
		[CallerCount(251)]
		[CachedScanResults(RefRangeStart = 99633, RefRangeEnd = 99884, XrefRangeStart = 99629, XrefRangeEnd = 99633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InputManager_Public_get_InputManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new InputManager(intPtr) : null;
		}
		[CallerCount(23)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_InputManager_Private_set_Void_InputManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe PartScriptCullerManager PartScriptCullerManager
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 99897, RefRangeEnd = 99906, XrefRangeStart = 99884, XrefRangeEnd = 99897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PartScriptCullerManager_Public_get_PartScriptCullerManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new PartScriptCullerManager(intPtr) : null;
		}
		[CallerCount(10)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_PartScriptCullerManager_Private_set_Void_PartScriptCullerManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe ProfileManager ProfileManager
	{
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 99923, RefRangeEnd = 99948, XrefRangeStart = 99906, XrefRangeEnd = 99923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ProfileManager_Public_get_ProfileManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new ProfileManager(intPtr) : null;
		}
		[CallerCount(8)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ProfileManager_Private_set_Void_ProfileManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe UpgradeSystem UpgradeSystem
	{
		[CallerCount(63)]
		[CachedScanResults(RefRangeStart = 99965, RefRangeEnd = 100028, XrefRangeStart = 99948, XrefRangeEnd = 99965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UpgradeSystem_Public_get_UpgradeSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new UpgradeSystem(intPtr) : null;
		}
		[CallerCount(7)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_UpgradeSystem_Private_set_Void_UpgradeSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe GameDataManager GameDataManager
	{
		[CallerCount(137)]
		[CachedScanResults(RefRangeStart = 100034, RefRangeEnd = 100171, XrefRangeStart = 100028, XrefRangeEnd = 100034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_GameDataManager_Public_get_GameDataManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new GameDataManager(intPtr) : null;
		}
		[CallerCount(8)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_GameDataManager_Private_set_Void_GameDataManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe PlatformManager PlatformManager
	{
		[CallerCount(128)]
		[CachedScanResults(RefRangeStart = 100188, RefRangeEnd = 100316, XrefRangeStart = 100171, XrefRangeEnd = 100188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlatformManager_Public_get_PlatformManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new PlatformManager(intPtr) : null;
		}
		[CallerCount(3)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_PlatformManager_Private_set_Void_PlatformManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe EngineAudioController EngineAudioController
	{
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 100348, RefRangeEnd = 100372, XrefRangeStart = 100316, XrefRangeEnd = 100348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EngineAudioController_Public_get_EngineAudioController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new EngineAudioController(intPtr) : null;
		}
		[CallerCount(2)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_EngineAudioController_Private_set_Void_EngineAudioController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe EngineStartAudio EngineStartAudio
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100399, RefRangeEnd = 100400, XrefRangeStart = 100372, XrefRangeEnd = 100399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EngineStartAudio_Public_get_EngineStartAudio_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new EngineStartAudio(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_EngineStartAudio_Private_set_Void_EngineStartAudio_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe XboxConnectedStorageManager XboxConnectedStorageManager
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100400, XrefRangeEnd = 100417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_XboxConnectedStorageManager_Public_get_XboxConnectedStorageManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new XboxConnectedStorageManager(intPtr) : null;
		}
		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_XboxConnectedStorageManager_Private_set_Void_XboxConnectedStorageManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe ScreenshotsManager ScreenshotsManager
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100417, XrefRangeEnd = 100430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ScreenshotsManager_Public_get_ScreenshotsManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new ScreenshotsManager(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ScreenshotsManager_Private_set_Void_ScreenshotsManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe CacheManager CacheManager
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 100433, RefRangeEnd = 100439, XrefRangeStart = 100430, XrefRangeEnd = 100433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CacheManager_Public_get_CacheManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new CacheManager(intPtr) : null;
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 100439, RefRangeEnd = 100443, XrefRangeStart = 100439, XrefRangeEnd = 100439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CacheManager_Private_set_Void_CacheManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe EventManager EventManager
	{
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 100447, RefRangeEnd = 100477, XrefRangeStart = 100443, XrefRangeEnd = 100447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EventManager_Public_get_EventManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new EventManager(intPtr) : null;
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 100477, RefRangeEnd = 100482, XrefRangeStart = 100477, XrefRangeEnd = 100477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_EventManager_Private_set_Void_EventManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99041, XrefRangeEnd = 99058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100482, XrefRangeEnd = 100495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static GameManager()
	{
		Il2CppClassPointerStore<GameManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GameManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameManager>.NativeClassPtr);
		NativeFieldInfoPtr_Inventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "Inventory");
		NativeFieldInfoPtr_Warehouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "Warehouse");
		NativeFieldInfoPtr__tempInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "_tempInventory");
		NativeFieldInfoPtr__carBundleLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "_carBundleLoader");
		NativeFieldInfoPtr_bonusPartsManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "bonusPartsManager");
		NativeFieldInfoPtr__RDGPlayerPrefs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "_RDGPlayerPrefs");
		NativeFieldInfoPtr__localization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "_localization");
		NativeFieldInfoPtr__carBundleManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "_carBundleManager");
		NativeFieldInfoPtr__rustmapManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "_rustmapManager");
		NativeFieldInfoPtr_liveriesManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "liveriesManager");
		NativeFieldInfoPtr__difficultyManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "_difficultyManager");
		NativeFieldInfoPtr__FPSInputController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "_FPSInputController");
		NativeFieldInfoPtr__inputManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "_inputManager");
		NativeFieldInfoPtr__partScriptCullerManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "_partScriptCullerManager");
		NativeFieldInfoPtr__profileManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "_profileManager");
		NativeFieldInfoPtr__upgradeSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "_upgradeSystem");
		NativeFieldInfoPtr__gameDataManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "_gameDataManager");
		NativeFieldInfoPtr__platformManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "_platformManager");
		NativeFieldInfoPtr__engineAudioController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "_engineAudioController");
		NativeFieldInfoPtr__engineStartAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "_engineStartAudio");
		NativeFieldInfoPtr_OrderGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "OrderGenerator");
		NativeFieldInfoPtr_CarLoadersInScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "CarLoadersInScene");
		NativeFieldInfoPtr_Radio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "Radio");
		NativeFieldInfoPtr__xboxConnectedStorageManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "_xboxConnectedStorageManager");
		NativeFieldInfoPtr_screenshotsManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "screenshotsManager");
		NativeFieldInfoPtr_cacheManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "cacheManager");
		NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "eventManager");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669132);
		NativeMethodInfoPtr_get_TempInventory_Public_get_TempInventory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669133);
		NativeMethodInfoPtr_set_TempInventory_Private_set_Void_TempInventory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669134);
		NativeMethodInfoPtr_get_CarBundleLoader_Public_get_CarBundleLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669135);
		NativeMethodInfoPtr_set_CarBundleLoader_Private_set_Void_CarBundleLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669136);
		NativeMethodInfoPtr_get_BonusPartsManager_Public_get_BonusPartsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669137);
		NativeMethodInfoPtr_set_BonusPartsManager_Private_set_Void_BonusPartsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669138);
		NativeMethodInfoPtr_get_RDGPlayerPrefs_Public_get_RDGPlayerPrefs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669139);
		NativeMethodInfoPtr_set_RDGPlayerPrefs_Private_set_Void_RDGPlayerPrefs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669140);
		NativeMethodInfoPtr_get_Localization_Public_get_Localization_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669141);
		NativeMethodInfoPtr_set_Localization_Private_set_Void_Localization_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669142);
		NativeMethodInfoPtr_get_CarBundleManager_Public_get_CarBundleManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669143);
		NativeMethodInfoPtr_set_CarBundleManager_Private_set_Void_CarBundleManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669144);
		NativeMethodInfoPtr_get_RustmapManager_Public_get_RustmapManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669145);
		NativeMethodInfoPtr_set_RustmapManager_Private_set_Void_RustmapManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669146);
		NativeMethodInfoPtr_get_LiveriesManager_Public_get_LiveriesManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669147);
		NativeMethodInfoPtr_set_LiveriesManager_Private_set_Void_LiveriesManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669148);
		NativeMethodInfoPtr_get_DifficultyManager_Public_get_DifficultyManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669149);
		NativeMethodInfoPtr_set_DifficultyManager_Private_set_Void_DifficultyManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669150);
		NativeMethodInfoPtr_get_FPSInputController_Public_get_FPSInputController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669151);
		NativeMethodInfoPtr_set_FPSInputController_Private_set_Void_FPSInputController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669152);
		NativeMethodInfoPtr_get_InputManager_Public_get_InputManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669153);
		NativeMethodInfoPtr_set_InputManager_Private_set_Void_InputManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669154);
		NativeMethodInfoPtr_get_PartScriptCullerManager_Public_get_PartScriptCullerManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669155);
		NativeMethodInfoPtr_set_PartScriptCullerManager_Private_set_Void_PartScriptCullerManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669156);
		NativeMethodInfoPtr_get_ProfileManager_Public_get_ProfileManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669157);
		NativeMethodInfoPtr_set_ProfileManager_Private_set_Void_ProfileManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669158);
		NativeMethodInfoPtr_get_UpgradeSystem_Public_get_UpgradeSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669159);
		NativeMethodInfoPtr_set_UpgradeSystem_Private_set_Void_UpgradeSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669160);
		NativeMethodInfoPtr_get_GameDataManager_Public_get_GameDataManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669161);
		NativeMethodInfoPtr_set_GameDataManager_Private_set_Void_GameDataManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669162);
		NativeMethodInfoPtr_get_PlatformManager_Public_get_PlatformManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669163);
		NativeMethodInfoPtr_set_PlatformManager_Private_set_Void_PlatformManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669164);
		NativeMethodInfoPtr_get_EngineAudioController_Public_get_EngineAudioController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669165);
		NativeMethodInfoPtr_set_EngineAudioController_Private_set_Void_EngineAudioController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669166);
		NativeMethodInfoPtr_get_EngineStartAudio_Public_get_EngineStartAudio_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669167);
		NativeMethodInfoPtr_set_EngineStartAudio_Private_set_Void_EngineStartAudio_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669168);
		NativeMethodInfoPtr_get_XboxConnectedStorageManager_Public_get_XboxConnectedStorageManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669169);
		NativeMethodInfoPtr_set_XboxConnectedStorageManager_Private_set_Void_XboxConnectedStorageManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669170);
		NativeMethodInfoPtr_get_ScreenshotsManager_Public_get_ScreenshotsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669171);
		NativeMethodInfoPtr_set_ScreenshotsManager_Private_set_Void_ScreenshotsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669172);
		NativeMethodInfoPtr_get_CacheManager_Public_get_CacheManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669173);
		NativeMethodInfoPtr_set_CacheManager_Private_set_Void_CacheManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669174);
		NativeMethodInfoPtr_get_EventManager_Public_get_EventManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669175);
		NativeMethodInfoPtr_set_EventManager_Private_set_Void_EventManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669176);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100669177);
	}

	public GameManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
