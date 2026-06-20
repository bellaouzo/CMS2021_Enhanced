using System;
using System.Runtime.CompilerServices;
using CMS.Tracks.Dragstrip;
using CMS.UI.Controls;
using CMS.UI.Logic.Navigation;
using Il2CppSystem;
using Rewired;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace CMS.UI.Logic.Drag;

public class RightRaceInfoPanel : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_carName;

	private static readonly System.IntPtr NativeFieldInfoPtr_carBrand;

	private static readonly System.IntPtr NativeFieldInfoPtr_carPreview;

	private static readonly System.IntPtr NativeFieldInfoPtr_carVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_carEngine;

	private static readonly System.IntPtr NativeFieldInfoPtr_carTireType;

	private static readonly System.IntPtr NativeFieldInfoPtr_carTuningValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_carDragIndexDisplay;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugText;

	private static readonly System.IntPtr NativeFieldInfoPtr_carRibbon;

	private static readonly System.IntPtr NativeFieldInfoPtr_dragIndexTitle;

	private static readonly System.IntPtr NativeFieldInfoPtr_carVersionSelector;

	private static readonly System.IntPtr NativeFieldInfoPtr_carEngineSelector;

	private static readonly System.IntPtr NativeFieldInfoPtr_tireTypeSelector;

	private static readonly System.IntPtr NativeFieldInfoPtr_tuningSlider;

	private static readonly System.IntPtr NativeFieldInfoPtr_listNavigationManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_configuration;

	private static readonly System.IntPtr NativeFieldInfoPtr_isCarSelected;

	private static readonly System.IntPtr NativeFieldInfoPtr_engineScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_carWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_torqueMod;

	private static readonly System.IntPtr NativeFieldInfoPtr_rpmMod;

	private static readonly System.IntPtr NativeFieldInfoPtr_transmissionType;

	private static readonly System.IntPtr NativeFieldInfoPtr_tiresGrip;

	private static readonly System.IntPtr NativeFieldInfoPtr_engines;

	private static readonly System.IntPtr NativeFieldInfoPtr_configuredCar;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareForConfiguration_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareForOpponent_Public_Void_CarForDragstrip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterEvents_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterEvents_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LockConfigurationOptions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetConfiguredCar_Public_CarForDragstrip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareCarVersionSelector_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterCarVersionEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterCarVersionEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnCarVersionChanged_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareCarEngineSelector_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterEngineEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterEngineEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEngineChanged_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareTireTypes_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectTireType_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterWheelTypeEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterWheelTypeEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnTireTypeChange_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareTuningSlider_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterTuningEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterTuningEvents_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnTuningValueChanged_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableConfigurationUI_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupForCar_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Refresh_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDragIndex_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanupConfiguration_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopInput_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableInfoUI_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupBasicInfo_Private_Void_String_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareBasicCarData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTireForType_Private_String_TireType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LockSelector_Private_Void_StringSelector_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleCurrentItemInput_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Boolean_Player_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareDebugText_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareDebugTextForOpponent_Private_Void_CarForDragstrip_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr));

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

	public unsafe Image carBrand
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carBrand);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carBrand), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image carPreview
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carPreview);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carPreview), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text carVersion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carVersion);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carVersion), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text carEngine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carEngine);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carEngine), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text carTireType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carTireType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carTireType), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text carTuningValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carTuningValue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carTuningValue), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DragIndexDisplay carDragIndexDisplay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carDragIndexDisplay);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DragIndexDisplay(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carDragIndexDisplay), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text debugText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugText), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CarRibbon carRibbon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carRibbon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CarRibbon(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carRibbon), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject dragIndexTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dragIndexTitle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dragIndexTitle), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe StringSelector carVersionSelector
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carVersionSelector);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new StringSelector(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carVersionSelector), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe StringSelector carEngineSelector
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carEngineSelector);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new StringSelector(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carEngineSelector), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe StringSelector tireTypeSelector
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tireTypeSelector);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new StringSelector(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tireTypeSelector), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CMS.UI.Controls.Slider tuningSlider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuningSlider);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CMS.UI.Controls.Slider(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuningSlider), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ListNavigationManager listNavigationManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listNavigationManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ListNavigationManager(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listNavigationManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool configuration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_configuration);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_configuration)) = flag;
		}
	}

	public unsafe bool isCarSelected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCarSelected);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCarSelected)) = flag;
		}
	}

	public unsafe float engineScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engineScale)) = num;
		}
	}

	public unsafe float carWeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carWeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carWeight)) = num;
		}
	}

	public unsafe float torqueMod
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_torqueMod);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_torqueMod)) = num;
		}
	}

	public unsafe float rpmMod
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmMod);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmMod)) = num;
		}
	}

	public unsafe string transmissionType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transmissionType);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transmissionType), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe float tiresGrip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tiresGrip);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tiresGrip)) = num;
		}
	}

	public unsafe Il2CppStringArray engines
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engines);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStringArray(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engines), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CarForDragstrip configuredCar
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_configuredCar);
			return new CarForDragstrip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CarForDragstrip>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_configuredCar), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CarForDragstrip>.NativeClassPtr, ref *(uint*)null));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199990, XrefRangeEnd = 199993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareForConfiguration(string carID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareForConfiguration_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 200054, RefRangeEnd = 200060, XrefRangeStart = 199993, XrefRangeEnd = 200054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareForOpponent(CarForDragstrip opponentCar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(opponentCar));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareForOpponent_Public_Void_CarForDragstrip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 200104, RefRangeEnd = 200106, XrefRangeStart = 200060, XrefRangeEnd = 200104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterEvents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 200139, RefRangeEnd = 200141, XrefRangeStart = 200106, XrefRangeEnd = 200139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterEvents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200141, XrefRangeEnd = 200155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LockConfigurationOptions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LockConfigurationOptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe CarForDragstrip GetConfiguredCar()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetConfiguredCar_Public_CarForDragstrip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return new CarForDragstrip(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 200189, RefRangeEnd = 200190, XrefRangeStart = 200155, XrefRangeEnd = 200189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareCarVersionSelector()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareCarVersionSelector_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200190, XrefRangeEnd = 200201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterCarVersionEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterCarVersionEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200201, XrefRangeEnd = 200210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterCarVersionEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterCarVersionEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200210, XrefRangeEnd = 200212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnCarVersionChanged(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnCarVersionChanged_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 200320, RefRangeEnd = 200321, XrefRangeStart = 200212, XrefRangeEnd = 200320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareCarEngineSelector()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareCarEngineSelector_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200321, XrefRangeEnd = 200332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterEngineEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterEngineEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200332, XrefRangeEnd = 200341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterEngineEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterEngineEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200341, XrefRangeEnd = 200345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEngineChanged(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEngineChanged_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 200392, RefRangeEnd = 200393, XrefRangeStart = 200345, XrefRangeEnd = 200392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareTireTypes(string currentTire)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(currentTire);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareTireTypes_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 200415, RefRangeEnd = 200416, XrefRangeStart = 200393, XrefRangeEnd = 200415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectTireType(string currentTire)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(currentTire);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectTireType_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200416, XrefRangeEnd = 200427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterWheelTypeEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterWheelTypeEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200427, XrefRangeEnd = 200436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterWheelTypeEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterWheelTypeEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200436, XrefRangeEnd = 200447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnTireTypeChange(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnTireTypeChange_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200447, XrefRangeEnd = 200461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareTuningSlider()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareTuningSlider_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200461, XrefRangeEnd = 200472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterTuningEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterTuningEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200472, XrefRangeEnd = 200481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterTuningEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterTuningEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200481, XrefRangeEnd = 200482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnTuningValueChanged(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnTuningValueChanged_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 200519, RefRangeEnd = 200525, XrefRangeStart = 200482, XrefRangeEnd = 200519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableConfigurationUI(bool enable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableConfigurationUI_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 200589, RefRangeEnd = 200594, XrefRangeStart = 200525, XrefRangeEnd = 200589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupForCar(string carID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupForCar_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 200610, RefRangeEnd = 200612, XrefRangeStart = 200594, XrefRangeEnd = 200610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Refresh()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Refresh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 200615, RefRangeEnd = 200619, XrefRangeStart = 200612, XrefRangeEnd = 200615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateDragIndex()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateDragIndex_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200619, XrefRangeEnd = 200623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CleanupConfiguration()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanupConfiguration_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void StopInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopInput_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 200688, RefRangeEnd = 200694, XrefRangeStart = 200623, XrefRangeEnd = 200688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableInfoUI(bool enable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableInfoUI_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200694, XrefRangeEnd = 200698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupBasicInfo(string carID, int config, bool withCarVersion)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &config;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &withCarVersion;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupBasicInfo_Private_Void_String_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 200731, RefRangeEnd = 200733, XrefRangeStart = 200698, XrefRangeEnd = 200731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareBasicCarData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareBasicCarData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 200741, RefRangeEnd = 200742, XrefRangeStart = 200733, XrefRangeEnd = 200741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetTireForType(TireType tireType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tireType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTireForType_Private_String_TireType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 200755, RefRangeEnd = 200761, XrefRangeStart = 200742, XrefRangeEnd = 200755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LockSelector(StringSelector selector, string placeholder)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(placeholder);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LockSelector_Private_Void_StringSelector_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 200780, RefRangeEnd = 200782, XrefRangeStart = 200761, XrefRangeEnd = 200780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HandleCurrentItemInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleCurrentItemInput_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200782, XrefRangeEnd = 200784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200784, XrefRangeEnd = 200794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareDebugText()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareDebugText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200794, XrefRangeEnd = 200828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareDebugTextForOpponent(CarForDragstrip opponent, string tire)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(opponent));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(tire);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareDebugTextForOpponent_Private_Void_CarForDragstrip_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe RightRaceInfoPanel()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static RightRaceInfoPanel()
	{
		Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Drag", "RightRaceInfoPanel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr);
		NativeFieldInfoPtr_carName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, "carName");
		NativeFieldInfoPtr_carBrand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, "carBrand");
		NativeFieldInfoPtr_carPreview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, "carPreview");
		NativeFieldInfoPtr_carVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, "carVersion");
		NativeFieldInfoPtr_carEngine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, "carEngine");
		NativeFieldInfoPtr_carTireType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, "carTireType");
		NativeFieldInfoPtr_carTuningValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, "carTuningValue");
		NativeFieldInfoPtr_carDragIndexDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, "carDragIndexDisplay");
		NativeFieldInfoPtr_debugText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, "debugText");
		NativeFieldInfoPtr_carRibbon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, "carRibbon");
		NativeFieldInfoPtr_dragIndexTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, "dragIndexTitle");
		NativeFieldInfoPtr_carVersionSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, "carVersionSelector");
		NativeFieldInfoPtr_carEngineSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, "carEngineSelector");
		NativeFieldInfoPtr_tireTypeSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, "tireTypeSelector");
		NativeFieldInfoPtr_tuningSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, "tuningSlider");
		NativeFieldInfoPtr_listNavigationManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, "listNavigationManager");
		NativeFieldInfoPtr_configuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, "configuration");
		NativeFieldInfoPtr_isCarSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, "isCarSelected");
		NativeFieldInfoPtr_engineScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, "engineScale");
		NativeFieldInfoPtr_carWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, "carWeight");
		NativeFieldInfoPtr_torqueMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, "torqueMod");
		NativeFieldInfoPtr_rpmMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, "rpmMod");
		NativeFieldInfoPtr_transmissionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, "transmissionType");
		NativeFieldInfoPtr_tiresGrip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, "tiresGrip");
		NativeFieldInfoPtr_engines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, "engines");
		NativeFieldInfoPtr_configuredCar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, "configuredCar");
		NativeMethodInfoPtr_PrepareForConfiguration_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678346);
		NativeMethodInfoPtr_PrepareForOpponent_Public_Void_CarForDragstrip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678347);
		NativeMethodInfoPtr_RegisterEvents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678348);
		NativeMethodInfoPtr_UnregisterEvents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678349);
		NativeMethodInfoPtr_LockConfigurationOptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678350);
		NativeMethodInfoPtr_GetConfiguredCar_Public_CarForDragstrip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678351);
		NativeMethodInfoPtr_PrepareCarVersionSelector_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678352);
		NativeMethodInfoPtr_RegisterCarVersionEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678353);
		NativeMethodInfoPtr_UnregisterCarVersionEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678354);
		NativeMethodInfoPtr_OnCarVersionChanged_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678355);
		NativeMethodInfoPtr_PrepareCarEngineSelector_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678356);
		NativeMethodInfoPtr_RegisterEngineEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678357);
		NativeMethodInfoPtr_UnregisterEngineEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678358);
		NativeMethodInfoPtr_OnEngineChanged_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678359);
		NativeMethodInfoPtr_PrepareTireTypes_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678360);
		NativeMethodInfoPtr_SelectTireType_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678361);
		NativeMethodInfoPtr_RegisterWheelTypeEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678362);
		NativeMethodInfoPtr_UnregisterWheelTypeEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678363);
		NativeMethodInfoPtr_OnTireTypeChange_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678364);
		NativeMethodInfoPtr_PrepareTuningSlider_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678365);
		NativeMethodInfoPtr_RegisterTuningEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678366);
		NativeMethodInfoPtr_UnregisterTuningEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678367);
		NativeMethodInfoPtr_OnTuningValueChanged_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678368);
		NativeMethodInfoPtr_EnableConfigurationUI_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678369);
		NativeMethodInfoPtr_SetupForCar_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678370);
		NativeMethodInfoPtr_Refresh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678371);
		NativeMethodInfoPtr_UpdateDragIndex_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678372);
		NativeMethodInfoPtr_CleanupConfiguration_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678373);
		NativeMethodInfoPtr_StopInput_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678374);
		NativeMethodInfoPtr_EnableInfoUI_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678375);
		NativeMethodInfoPtr_SetupBasicInfo_Private_Void_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678376);
		NativeMethodInfoPtr_PrepareBasicCarData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678377);
		NativeMethodInfoPtr_GetTireForType_Private_String_TireType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678378);
		NativeMethodInfoPtr_LockSelector_Private_Void_StringSelector_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678379);
		NativeMethodInfoPtr_HandleCurrentItemInput_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678380);
		NativeMethodInfoPtr_HandleInput_Public_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678381);
		NativeMethodInfoPtr_PrepareDebugText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678382);
		NativeMethodInfoPtr_PrepareDebugTextForOpponent_Private_Void_CarForDragstrip_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678383);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RightRaceInfoPanel>.NativeClassPtr, 100678384);
	}

	public RightRaceInfoPanel(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
