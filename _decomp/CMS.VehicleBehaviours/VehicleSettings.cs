using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine.UI;
using VehiclePhysics;

namespace CMS.VehicleBehaviours;

public class VehicleSettings : VehicleBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ecsIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_tcsIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_ecsMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_tcsMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_tcsEngaged;

	private static readonly System.IntPtr NativeFieldInfoPtr_ecsEngaged;

	private static readonly System.IntPtr NativeFieldInfoPtr_canChangeTCS;

	private static readonly System.IntPtr NativeFieldInfoPtr_canChangeECS;

	private static readonly System.IntPtr NativeFieldInfoPtr_vehicleController;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputManager;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnableComponent_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableMe_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateState_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetIconEngaged_Private_Void_Image_VehicleSettingMode_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetIconMode_Private_Void_VehicleSettingMode_Image_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVehicleSettingModeFromValue_Private_VehicleSettingMode_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValueFromVehicleSettingMode_Private_Int32_VehicleSettingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetNextMode_Private_Void_byref_VehicleSettingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendValueToDataBus_Private_Void_Int32_VehicleSettingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr));

	public unsafe Image ecsIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ecsIcon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ecsIcon), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image tcsIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tcsIcon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tcsIcon), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VehicleSettingMode ecsMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ecsMode);
			return *(VehicleSettingMode*)num;
		}
		set
		{
			*(VehicleSettingMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ecsMode)) = vehicleSettingMode;
		}
	}

	public unsafe VehicleSettingMode tcsMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tcsMode);
			return *(VehicleSettingMode*)num;
		}
		set
		{
			*(VehicleSettingMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tcsMode)) = vehicleSettingMode;
		}
	}

	public unsafe bool tcsEngaged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tcsEngaged);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tcsEngaged)) = flag;
		}
	}

	public unsafe bool ecsEngaged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ecsEngaged);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ecsEngaged)) = flag;
		}
	}

	public unsafe bool canChangeTCS
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canChangeTCS);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canChangeTCS)) = flag;
		}
	}

	public unsafe bool canChangeECS
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canChangeECS);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canChangeECS)) = flag;
		}
	}

	public unsafe VPVehicleController vehicleController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vehicleController);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPVehicleController(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vehicleController), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131536, XrefRangeEnd = 131562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnEnableComponent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnEnableComponent_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131562, XrefRangeEnd = 131583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisableMe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableMe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131583, XrefRangeEnd = 131606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnEnableVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131606, XrefRangeEnd = 131621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void UpdateVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_UpdateVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131621, XrefRangeEnd = 131631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131631, XrefRangeEnd = 131633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 131635, RefRangeEnd = 131639, XrefRangeStart = 131633, XrefRangeEnd = 131635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetIconEngaged(Image icon, VehicleSettingMode defaultMode, bool engaged)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(icon);
		*(VehicleSettingMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultMode;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &engaged;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetIconEngaged_Private_Void_Image_VehicleSettingMode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 131647, RefRangeEnd = 131653, XrefRangeStart = 131639, XrefRangeEnd = 131647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetIconMode(VehicleSettingMode mode, Image icon)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&mode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(icon);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetIconMode_Private_Void_VehicleSettingMode_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe VehicleSettingMode GetVehicleSettingModeFromValue(int value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVehicleSettingModeFromValue_Private_VehicleSettingMode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(VehicleSettingMode*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe int GetValueFromVehicleSettingMode(VehicleSettingMode mode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mode);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValueFromVehicleSettingMode_Private_Int32_VehicleSettingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe void SetNextMode(ref VehicleSettingMode mode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref mode);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetNextMode_Private_Void_byref_VehicleSettingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 131655, RefRangeEnd = 131659, XrefRangeStart = 131653, XrefRangeEnd = 131655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendValueToDataBus(int idValue, VehicleSettingMode mode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&idValue);
		*(VehicleSettingMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendValueToDataBus_Private_Void_Int32_VehicleSettingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe VehicleSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VehicleSettings()
	{
		Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.VehicleBehaviours", "VehicleSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr);
		NativeFieldInfoPtr_ecsIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr, "ecsIcon");
		NativeFieldInfoPtr_tcsIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr, "tcsIcon");
		NativeFieldInfoPtr_ecsMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr, "ecsMode");
		NativeFieldInfoPtr_tcsMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr, "tcsMode");
		NativeFieldInfoPtr_tcsEngaged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr, "tcsEngaged");
		NativeFieldInfoPtr_ecsEngaged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr, "ecsEngaged");
		NativeFieldInfoPtr_canChangeTCS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr, "canChangeTCS");
		NativeFieldInfoPtr_canChangeECS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr, "canChangeECS");
		NativeFieldInfoPtr_vehicleController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr, "vehicleController");
		NativeFieldInfoPtr_inputManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr, "inputManager");
		NativeMethodInfoPtr_OnEnableComponent_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr, 100672100);
		NativeMethodInfoPtr_DisableMe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr, 100672101);
		NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr, 100672102);
		NativeMethodInfoPtr_UpdateVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr, 100672103);
		NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr, 100672104);
		NativeMethodInfoPtr_UpdateState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr, 100672105);
		NativeMethodInfoPtr_SetIconEngaged_Private_Void_Image_VehicleSettingMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr, 100672106);
		NativeMethodInfoPtr_SetIconMode_Private_Void_VehicleSettingMode_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr, 100672107);
		NativeMethodInfoPtr_GetVehicleSettingModeFromValue_Private_VehicleSettingMode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr, 100672108);
		NativeMethodInfoPtr_GetValueFromVehicleSettingMode_Private_Int32_VehicleSettingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr, 100672109);
		NativeMethodInfoPtr_SetNextMode_Private_Void_byref_VehicleSettingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr, 100672110);
		NativeMethodInfoPtr_SendValueToDataBus_Private_Void_Int32_VehicleSettingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr, 100672111);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr, 100672112);
	}

	public VehicleSettings(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
