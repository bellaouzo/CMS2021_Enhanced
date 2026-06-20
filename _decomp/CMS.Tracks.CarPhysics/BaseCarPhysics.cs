using System;
using System.Runtime.CompilerServices;
using EVP;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using VehiclePhysics;

namespace CMS.Tracks.CarPhysics;

public class BaseCarPhysics : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_carLoader;

	private static readonly System.IntPtr NativeFieldInfoPtr_carModel;

	private static readonly System.IntPtr NativeFieldInfoPtr_model;

	private static readonly System.IntPtr NativeFieldInfoPtr_rigidBody;

	private static readonly System.IntPtr NativeFieldInfoPtr_carModelParent;

	private static readonly System.IntPtr NativeFieldInfoPtr_vpVehicleController;

	private static readonly System.IntPtr NativeFieldInfoPtr_bodyMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_headInside;

	private static readonly System.IntPtr NativeFieldInfoPtr_dashboard;

	private static readonly System.IntPtr NativeFieldInfoPtr_frontLeftCaliper;

	private static readonly System.IntPtr NativeFieldInfoPtr_frontRightCaliper;

	private static readonly System.IntPtr NativeFieldInfoPtr_rearLeftCaliper;

	private static readonly System.IntPtr NativeFieldInfoPtr_rearRightCaliper;

	private static readonly System.IntPtr NativeFieldInfoPtr_steeringWheelHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_wheelFLPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_wheelFRPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_wheelRLPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_wheelRRPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_wheelFLDefaultSusDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_wheelFRDefaultSusDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_wheelRLDefaultSusDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_wheelRRDefaultSusDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_gearboxFromEddy;

	private static readonly System.IntPtr NativeFieldInfoPtr_gearboxHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_res;

	private static readonly System.IntPtr NativeFieldInfoPtr_edysToRes;

	private static readonly System.IntPtr NativeFieldInfoPtr_vpaudio;

	private static readonly System.IntPtr NativeFieldInfoPtr_turboCharger;

	private static readonly System.IntPtr NativeFieldInfoPtr_superCharger;

	private static readonly System.IntPtr NativeFieldInfoPtr_isOffroadTrack;

	private static readonly System.IntPtr NativeFieldInfoPtr_forDragstrip;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAutomatic;

	private static readonly System.IntPtr NativeFieldInfoPtr_isElectric;

	private static readonly System.IntPtr NativeFieldInfoPtr_addGears;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CarLoader_Public_get_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_VehicleController_Public_get_VPVehicleController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareDefaultSuspensionDistance_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pause_Protected_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearCar_Protected_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReparentParts_Protected_Boolean_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableSystems_Protected_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupWheelsAndSuspension_Protected_Void_Transform_GameInventory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupSuspension_Private_Void_String_Transform_VPWheelCollider_Transform_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWheelsParents_Private_Void_Transform_Transform_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableMotionVectorsOnWheels_Private_Static_Void_Transform_Transform_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupDashboard_Protected_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCollider_Protected_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableUnusedColliders_Protected_Static_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupDownforce_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPosition_Protected_Static_Void_Transform_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCoMAndAckerman_Private_Void_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupInput_Protected_Void_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupEngine_Protected_Void_GameInventory_Boolean_byref_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupEngineSounds_Private_Boolean_GameInventory_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupInterior_Protected_Void_Transform_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupGauges_Protected_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupDials_Protected_Void_CarDials_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupHeadPosition_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupSuspensionParams_Private_Void_VPWheelCollider_VPWheelCollider_VPWheelCollider_VPWheelCollider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTiresFriction_Private_Void_GameInventory_Transform_Transform_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupTransmission_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeight_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupBrakes_Protected_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateBrakeLightsMaterials_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyPartScripts_Protected_Static_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupGearbox_Protected_Void_GameObject_GameInventory_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupAutomaticGearRatios_Protected_Virtual_New_Void_byref_ArrayOf_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAddGears_Protected_Void_byref_ArrayOf_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupGearsNormally_Protected_Void_byref_ArrayOf_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr));

	public unsafe CarLoader carLoader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carLoader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CarLoader(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carLoader), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform carModel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carModel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carModel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject model
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_model);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_model), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Rigidbody rigidBody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rigidBody);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Rigidbody(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rigidBody), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform carModelParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carModelParent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carModelParent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VPVehicleController vpVehicleController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vpVehicleController);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPVehicleController(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vpVehicleController), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PhysicMaterial bodyMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bodyMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new PhysicMaterial(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bodyMaterial), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform headInside
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headInside);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headInside), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VPVisualEffects2 dashboard
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dashboard);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPVisualEffects2(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dashboard), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform frontLeftCaliper
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frontLeftCaliper);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frontLeftCaliper), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform frontRightCaliper
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frontRightCaliper);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frontRightCaliper), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform rearLeftCaliper
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rearLeftCaliper);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rearLeftCaliper), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform rearRightCaliper
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rearRightCaliper);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rearRightCaliper), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject steeringWheelHandle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steeringWheelHandle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steeringWheelHandle), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform wheelFLPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelFLPos);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelFLPos), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform wheelFRPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelFRPos);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelFRPos), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform wheelRLPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelRLPos);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelRLPos), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform wheelRRPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelRRPos);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelRRPos), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float wheelFLDefaultSusDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelFLDefaultSusDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelFLDefaultSusDistance)) = num;
		}
	}

	public unsafe float wheelFRDefaultSusDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelFRDefaultSusDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelFRDefaultSusDistance)) = num;
		}
	}

	public unsafe float wheelRLDefaultSusDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelRLDefaultSusDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelRLDefaultSusDistance)) = num;
		}
	}

	public unsafe float wheelRRDefaultSusDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelRRDefaultSusDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wheelRRDefaultSusDistance)) = num;
		}
	}

	public unsafe Gearbox.Settings gearboxFromEddy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearboxFromEddy);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Gearbox.Settings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearboxFromEddy), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GearboxHandle gearboxHandle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearboxHandle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GearboxHandle(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearboxHandle), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RealisticEngineSound res
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_res);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RealisticEngineSound(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_res), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe EdysToRes edysToRes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_edysToRes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new EdysToRes(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_edysToRes), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VPAudio2 vpaudio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vpaudio);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPAudio2(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vpaudio), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TurboCharger turboCharger
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turboCharger);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new TurboCharger(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turboCharger), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SuperCharger superCharger
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_superCharger);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new SuperCharger(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_superCharger), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool isOffroadTrack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOffroadTrack);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOffroadTrack)) = flag;
		}
	}

	public unsafe bool forDragstrip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forDragstrip);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forDragstrip)) = flag;
		}
	}

	public unsafe bool isAutomatic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAutomatic);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAutomatic)) = flag;
		}
	}

	public unsafe bool isElectric
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isElectric);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isElectric)) = flag;
		}
	}

	public unsafe bool addGears
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addGears);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addGears)) = flag;
		}
	}

	public unsafe CarLoader CarLoader
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CarLoader_Public_get_CarLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new CarLoader(intPtr) : null;
		}
	}

	public unsafe VPVehicleController VehicleController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_VehicleController_Public_get_VPVehicleController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new VPVehicleController(intPtr) : null;
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 134903, RefRangeEnd = 134905, XrefRangeStart = 134819, XrefRangeEnd = 134903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 134930, RefRangeEnd = 134932, XrefRangeStart = 134905, XrefRangeEnd = 134930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareDefaultSuspensionDistance()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareDefaultSuspensionDistance_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 134947, RefRangeEnd = 134962, XrefRangeStart = 134932, XrefRangeEnd = 134947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pause(bool pause)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pause);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pause_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 135088, RefRangeEnd = 135092, XrefRangeStart = 134962, XrefRangeEnd = 135088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearCar(bool pause)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pause);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearCar_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 135183, RefRangeEnd = 135184, XrefRangeStart = 135092, XrefRangeEnd = 135183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ReparentParts(Transform rootTransform)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootTransform);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReparentParts_Protected_Boolean_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 135184, RefRangeEnd = 135185, XrefRangeStart = 135184, XrefRangeEnd = 135184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableSystems(bool hasABS)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hasABS);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableSystems_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 135313, RefRangeEnd = 135314, XrefRangeStart = 135185, XrefRangeEnd = 135313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupWheelsAndSuspension(Transform rootTransform, GameInventory gameInventory)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootTransform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(gameInventory);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupWheelsAndSuspension_Protected_Void_Transform_GameInventory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 135327, RefRangeEnd = 135331, XrefRangeStart = 135314, XrefRangeEnd = 135327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupSuspension(string suspensionPath, Transform caliper, VPWheelCollider wheelCollider, Transform rootTransform, bool showSuspension)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(suspensionPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(caliper);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(wheelCollider);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(rootTransform);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &showSuspension;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupSuspension_Private_Void_String_Transform_VPWheelCollider_Transform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135331, XrefRangeEnd = 135348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetWheelsParents(Transform frontLeftWheel, Transform frontRightWheel, Transform rearLeftWheel, Transform rearRightWheel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(frontLeftWheel);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(frontRightWheel);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(rearLeftWheel);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(rearRightWheel);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWheelsParents_Private_Void_Transform_Transform_Transform_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135348, XrefRangeEnd = 135356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DisableMotionVectorsOnWheels(Transform frontLeftWheel, Transform frontRightWheel, Transform rearLeftWheel, Transform rearRightWheel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(frontLeftWheel);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(frontRightWheel);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(rearLeftWheel);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(rearRightWheel);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableMotionVectorsOnWheels_Private_Static_Void_Transform_Transform_Transform_Transform_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 135358, RefRangeEnd = 135359, XrefRangeStart = 135356, XrefRangeEnd = 135358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupDashboard(GameObject steeringWheelHandle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(steeringWheelHandle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupDashboard_Protected_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 135398, RefRangeEnd = 135399, XrefRangeStart = 135359, XrefRangeEnd = 135398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupCollider(Transform rootTransform)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootTransform);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCollider_Protected_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 135404, RefRangeEnd = 135405, XrefRangeStart = 135399, XrefRangeEnd = 135404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DisableUnusedColliders(GameObject carRoot)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carRoot);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableUnusedColliders_Protected_Static_Void_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 135416, RefRangeEnd = 135417, XrefRangeStart = 135405, XrefRangeEnd = 135416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupDownforce()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupDownforce_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135417, XrefRangeEnd = 135419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPosition(Transform t, Vector3 newPos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newPos;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPosition_Protected_Static_Void_Transform_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 135439, RefRangeEnd = 135440, XrefRangeStart = 135419, XrefRangeEnd = 135439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupCoMAndAckerman(Vector3 frontLeftWheelPos, Vector3 rearRightWheelPos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&frontLeftWheelPos);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rearRightWheelPos;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCoMAndAckerman_Private_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135440, XrefRangeEnd = 135449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupInput(GameObject steeringWheelHandle, bool loadCustomCar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(steeringWheelHandle);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &loadCustomCar;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupInput_Protected_Void_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 135480, RefRangeEnd = 135481, XrefRangeStart = 135449, XrefRangeEnd = 135480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupEngine(GameInventory gameInventory, bool dragOpponent, out GameObject engine)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameInventory);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dragOpponent;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(engine);
		*(System.IntPtr**)num = &intPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupEngine_Protected_Void_GameInventory_Boolean_byref_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		engine = ((intPtr3 == (System.IntPtr)0) ? null : new GameObject(intPtr3));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 135596, RefRangeEnd = 135597, XrefRangeStart = 135481, XrefRangeEnd = 135596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SetupEngineSounds(GameInventory gameInventory, GameObject engine, bool dragOpponent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameInventory);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(engine);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dragOpponent;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupEngineSounds_Private_Boolean_GameInventory_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 135694, RefRangeEnd = 135695, XrefRangeStart = 135597, XrefRangeEnd = 135694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupInterior(Transform rootTransform, GameObject steeringWheelHandle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootTransform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(steeringWheelHandle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupInterior_Protected_Void_Transform_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 135748, RefRangeEnd = 135749, XrefRangeStart = 135695, XrefRangeEnd = 135748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupGauges(GameObject steeringWheelHandle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(steeringWheelHandle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupGauges_Protected_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 135783, RefRangeEnd = 135784, XrefRangeStart = 135749, XrefRangeEnd = 135783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupDials(CarDials carDials)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carDials);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupDials_Protected_Void_CarDials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 135884, RefRangeEnd = 135885, XrefRangeStart = 135784, XrefRangeEnd = 135884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupHeadPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupHeadPosition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 135909, RefRangeEnd = 135910, XrefRangeStart = 135885, XrefRangeEnd = 135909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupSuspensionParams(VPWheelCollider vpWheelColliderFL, VPWheelCollider vpWheelColliderFR, VPWheelCollider vpWheelColliderRL, VPWheelCollider vpWheelColliderRR)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(vpWheelColliderFL);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(vpWheelColliderFR);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(vpWheelColliderRL);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(vpWheelColliderRR);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupSuspensionParams_Private_Void_VPWheelCollider_VPWheelCollider_VPWheelCollider_VPWheelCollider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 135953, RefRangeEnd = 135954, XrefRangeStart = 135910, XrefRangeEnd = 135953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTiresFriction(GameInventory gameInventory, Transform wheelColliderFL, Transform wheelColliderFR, Transform wheelColliderRL, Transform wheelColliderRR)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameInventory);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(wheelColliderFL);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(wheelColliderFR);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(wheelColliderRL);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(wheelColliderRR);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTiresFriction_Private_Void_GameInventory_Transform_Transform_Transform_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 135960, RefRangeEnd = 135961, XrefRangeStart = 135954, XrefRangeEnd = 135960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupTransmission()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupTransmission_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 135969, RefRangeEnd = 135970, XrefRangeStart = 135961, XrefRangeEnd = 135969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupWeight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupWeight_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 135982, RefRangeEnd = 135983, XrefRangeStart = 135970, XrefRangeEnd = 135982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupBrakes(float brakeTuningValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&brakeTuningValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupBrakes_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135983, XrefRangeEnd = 135985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateBrakeLightsMaterials()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateBrakeLightsMaterials_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 135992, RefRangeEnd = 135994, XrefRangeStart = 135985, XrefRangeEnd = 135992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestroyPartScripts(GameObject carRoot)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carRoot);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyPartScripts_Protected_Static_Void_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 136060, RefRangeEnd = 136061, XrefRangeStart = 135994, XrefRangeEnd = 136060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupGearbox(GameObject engine, GameInventory gameInventory, bool dragOpponent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(engine);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(gameInventory);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dragOpponent;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupGearbox_Protected_Void_GameObject_GameInventory_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136061, XrefRangeEnd = 136073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupAutomaticGearRatios(ref Il2CppStructArray<float> gearRatios)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(gearRatios);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SetupAutomaticGearRatios_Protected_Virtual_New_Void_byref_ArrayOf_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 136078, RefRangeEnd = 136079, XrefRangeStart = 136073, XrefRangeEnd = 136078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TryAddGears(ref Il2CppStructArray<float> gearRatios)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(gearRatios);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryAddGears_Protected_Void_byref_ArrayOf_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 136083, RefRangeEnd = 136084, XrefRangeStart = 136079, XrefRangeEnd = 136083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupGearsNormally(ref Il2CppStructArray<float> gearRatios)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(gearRatios);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupGearsNormally_Protected_Void_byref_ArrayOf_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136084, XrefRangeEnd = 136087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BaseCarPhysics()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static BaseCarPhysics()
	{
		Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Tracks.CarPhysics", "BaseCarPhysics");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr);
		NativeFieldInfoPtr_carLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "carLoader");
		NativeFieldInfoPtr_carModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "carModel");
		NativeFieldInfoPtr_model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "model");
		NativeFieldInfoPtr_rigidBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "rigidBody");
		NativeFieldInfoPtr_carModelParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "carModelParent");
		NativeFieldInfoPtr_vpVehicleController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "vpVehicleController");
		NativeFieldInfoPtr_bodyMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "bodyMaterial");
		NativeFieldInfoPtr_headInside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "headInside");
		NativeFieldInfoPtr_dashboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "dashboard");
		NativeFieldInfoPtr_frontLeftCaliper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "frontLeftCaliper");
		NativeFieldInfoPtr_frontRightCaliper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "frontRightCaliper");
		NativeFieldInfoPtr_rearLeftCaliper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "rearLeftCaliper");
		NativeFieldInfoPtr_rearRightCaliper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "rearRightCaliper");
		NativeFieldInfoPtr_steeringWheelHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "steeringWheelHandle");
		NativeFieldInfoPtr_wheelFLPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "wheelFLPos");
		NativeFieldInfoPtr_wheelFRPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "wheelFRPos");
		NativeFieldInfoPtr_wheelRLPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "wheelRLPos");
		NativeFieldInfoPtr_wheelRRPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "wheelRRPos");
		NativeFieldInfoPtr_wheelFLDefaultSusDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "wheelFLDefaultSusDistance");
		NativeFieldInfoPtr_wheelFRDefaultSusDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "wheelFRDefaultSusDistance");
		NativeFieldInfoPtr_wheelRLDefaultSusDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "wheelRLDefaultSusDistance");
		NativeFieldInfoPtr_wheelRRDefaultSusDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "wheelRRDefaultSusDistance");
		NativeFieldInfoPtr_gearboxFromEddy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "gearboxFromEddy");
		NativeFieldInfoPtr_gearboxHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "gearboxHandle");
		NativeFieldInfoPtr_res = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "res");
		NativeFieldInfoPtr_edysToRes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "edysToRes");
		NativeFieldInfoPtr_vpaudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "vpaudio");
		NativeFieldInfoPtr_turboCharger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "turboCharger");
		NativeFieldInfoPtr_superCharger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "superCharger");
		NativeFieldInfoPtr_isOffroadTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "isOffroadTrack");
		NativeFieldInfoPtr_forDragstrip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "forDragstrip");
		NativeFieldInfoPtr_isAutomatic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "isAutomatic");
		NativeFieldInfoPtr_isElectric = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "isElectric");
		NativeFieldInfoPtr_addGears = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, "addGears");
		NativeMethodInfoPtr_get_CarLoader_Public_get_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672272);
		NativeMethodInfoPtr_get_VehicleController_Public_get_VPVehicleController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672273);
		NativeMethodInfoPtr_Setup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672274);
		NativeMethodInfoPtr_PrepareDefaultSuspensionDistance_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672275);
		NativeMethodInfoPtr_Pause_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672276);
		NativeMethodInfoPtr_ClearCar_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672277);
		NativeMethodInfoPtr_ReparentParts_Protected_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672278);
		NativeMethodInfoPtr_EnableSystems_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672279);
		NativeMethodInfoPtr_SetupWheelsAndSuspension_Protected_Void_Transform_GameInventory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672280);
		NativeMethodInfoPtr_SetupSuspension_Private_Void_String_Transform_VPWheelCollider_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672281);
		NativeMethodInfoPtr_SetWheelsParents_Private_Void_Transform_Transform_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672282);
		NativeMethodInfoPtr_DisableMotionVectorsOnWheels_Private_Static_Void_Transform_Transform_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672283);
		NativeMethodInfoPtr_SetupDashboard_Protected_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672284);
		NativeMethodInfoPtr_SetupCollider_Protected_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672285);
		NativeMethodInfoPtr_DisableUnusedColliders_Protected_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672286);
		NativeMethodInfoPtr_SetupDownforce_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672287);
		NativeMethodInfoPtr_SetPosition_Protected_Static_Void_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672288);
		NativeMethodInfoPtr_SetupCoMAndAckerman_Private_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672289);
		NativeMethodInfoPtr_SetupInput_Protected_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672290);
		NativeMethodInfoPtr_SetupEngine_Protected_Void_GameInventory_Boolean_byref_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672291);
		NativeMethodInfoPtr_SetupEngineSounds_Private_Boolean_GameInventory_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672292);
		NativeMethodInfoPtr_SetupInterior_Protected_Void_Transform_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672293);
		NativeMethodInfoPtr_SetupGauges_Protected_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672294);
		NativeMethodInfoPtr_SetupDials_Protected_Void_CarDials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672295);
		NativeMethodInfoPtr_SetupHeadPosition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672296);
		NativeMethodInfoPtr_SetupSuspensionParams_Private_Void_VPWheelCollider_VPWheelCollider_VPWheelCollider_VPWheelCollider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672297);
		NativeMethodInfoPtr_SetTiresFriction_Private_Void_GameInventory_Transform_Transform_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672298);
		NativeMethodInfoPtr_SetupTransmission_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672299);
		NativeMethodInfoPtr_SetupWeight_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672300);
		NativeMethodInfoPtr_SetupBrakes_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672301);
		NativeMethodInfoPtr_UpdateBrakeLightsMaterials_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672302);
		NativeMethodInfoPtr_DestroyPartScripts_Protected_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672303);
		NativeMethodInfoPtr_SetupGearbox_Protected_Void_GameObject_GameInventory_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672304);
		NativeMethodInfoPtr_SetupAutomaticGearRatios_Protected_Virtual_New_Void_byref_ArrayOf_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672305);
		NativeMethodInfoPtr_TryAddGears_Protected_Void_byref_ArrayOf_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672306);
		NativeMethodInfoPtr_SetupGearsNormally_Protected_Void_byref_ArrayOf_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672307);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCarPhysics>.NativeClassPtr, 100672308);
	}

	public BaseCarPhysics(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
