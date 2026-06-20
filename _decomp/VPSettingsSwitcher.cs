using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using VehiclePhysics;

public class VPSettingsSwitcher : VehicleBehaviour
{
	[System.Serializable]
	public class SettingsGroup : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_setSteeringAids;

		private static readonly System.IntPtr NativeFieldInfoPtr_setTractionControl;

		private static readonly System.IntPtr NativeFieldInfoPtr_setStabilityControl;

		private static readonly System.IntPtr NativeFieldInfoPtr_setAntiSpin;

		private static readonly System.IntPtr NativeFieldInfoPtr_setDifferential;

		private static readonly System.IntPtr NativeFieldInfoPtr_steeringAids;

		private static readonly System.IntPtr NativeFieldInfoPtr_tractionControl;

		private static readonly System.IntPtr NativeFieldInfoPtr_stabilityControl;

		private static readonly System.IntPtr NativeFieldInfoPtr_antiSpin;

		private static readonly System.IntPtr NativeFieldInfoPtr_differential;

		private static readonly System.IntPtr NativeMethodInfoPtr_LoadFromVehicle_Public_Void_VPVehicleController_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SaveToVehicle_Public_Void_VPVehicleController_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SettingsGroup>.NativeClassPtr));

		public unsafe string name
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe bool setSteeringAids
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setSteeringAids);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setSteeringAids)) = flag;
			}
		}

		public unsafe bool setTractionControl
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setTractionControl);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setTractionControl)) = flag;
			}
		}

		public unsafe bool setStabilityControl
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setStabilityControl);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setStabilityControl)) = flag;
			}
		}

		public unsafe bool setAntiSpin
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setAntiSpin);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setAntiSpin)) = flag;
			}
		}

		public unsafe bool setDifferential
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setDifferential);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setDifferential)) = flag;
			}
		}

		public unsafe SteeringAids.Settings steeringAids
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steeringAids);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new SteeringAids.Settings(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steeringAids), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe TractionControl.Settings tractionControl
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tractionControl);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new TractionControl.Settings(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tractionControl), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe StabilityControl.Settings stabilityControl
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stabilityControl);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new StabilityControl.Settings(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stabilityControl), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe AntiSpin.Settings antiSpin
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_antiSpin);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new AntiSpin.Settings(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_antiSpin), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Differential.Settings differential
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_differential);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Differential.Settings(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_differential), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110610, XrefRangeEnd = 110629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadFromVehicle(VPVehicleController vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFromVehicle_Public_Void_VPVehicleController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110629, XrefRangeEnd = 110655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveToVehicle(VPVehicleController vehicle, bool force = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &force;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveToVehicle_Public_Void_VPVehicleController_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110672, RefRangeEnd = 110673, XrefRangeStart = 110655, XrefRangeEnd = 110672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingsGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsGroup>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static SettingsGroup()
		{
			Il2CppClassPointerStore<SettingsGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VPSettingsSwitcher>.NativeClassPtr, "SettingsGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsGroup>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsGroup>.NativeClassPtr, "name");
			NativeFieldInfoPtr_setSteeringAids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsGroup>.NativeClassPtr, "setSteeringAids");
			NativeFieldInfoPtr_setTractionControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsGroup>.NativeClassPtr, "setTractionControl");
			NativeFieldInfoPtr_setStabilityControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsGroup>.NativeClassPtr, "setStabilityControl");
			NativeFieldInfoPtr_setAntiSpin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsGroup>.NativeClassPtr, "setAntiSpin");
			NativeFieldInfoPtr_setDifferential = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsGroup>.NativeClassPtr, "setDifferential");
			NativeFieldInfoPtr_steeringAids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsGroup>.NativeClassPtr, "steeringAids");
			NativeFieldInfoPtr_tractionControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsGroup>.NativeClassPtr, "tractionControl");
			NativeFieldInfoPtr_stabilityControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsGroup>.NativeClassPtr, "stabilityControl");
			NativeFieldInfoPtr_antiSpin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsGroup>.NativeClassPtr, "antiSpin");
			NativeFieldInfoPtr_differential = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsGroup>.NativeClassPtr, "differential");
			NativeMethodInfoPtr_LoadFromVehicle_Public_Void_VPVehicleController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsGroup>.NativeClassPtr, 100670284);
			NativeMethodInfoPtr_SaveToVehicle_Public_Void_VPVehicleController_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsGroup>.NativeClassPtr, 100670285);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsGroup>.NativeClassPtr, 100670286);
		}

		public SettingsGroup(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_selectedGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_settingsGroups;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_vehicle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_currentGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_originalSettings;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisableVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VPSettingsSwitcher>.NativeClassPtr));

	public unsafe int selectedGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedGroup);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedGroup)) = num;
		}
	}

	public unsafe Il2CppReferenceArray<SettingsGroup> settingsGroups
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_settingsGroups);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<SettingsGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_settingsGroups), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VPVehicleController m_vehicle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_vehicle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new VPVehicleController(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_vehicle), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SettingsGroup m_currentGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_currentGroup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new SettingsGroup(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_currentGroup), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SettingsGroup m_originalSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_originalSettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new SettingsGroup(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_originalSettings), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110673, XrefRangeEnd = 110697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnEnableVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110697, XrefRangeEnd = 110723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnDisableVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnDisableVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110723, XrefRangeEnd = 110792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void FixedUpdateVehicle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110792, XrefRangeEnd = 110802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VPSettingsSwitcher()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VPSettingsSwitcher>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VPSettingsSwitcher()
	{
		Il2CppClassPointerStore<VPSettingsSwitcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "VPSettingsSwitcher");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VPSettingsSwitcher>.NativeClassPtr);
		NativeFieldInfoPtr_selectedGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSettingsSwitcher>.NativeClassPtr, "selectedGroup");
		NativeFieldInfoPtr_settingsGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSettingsSwitcher>.NativeClassPtr, "settingsGroups");
		NativeFieldInfoPtr_m_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSettingsSwitcher>.NativeClassPtr, "m_vehicle");
		NativeFieldInfoPtr_m_currentGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSettingsSwitcher>.NativeClassPtr, "m_currentGroup");
		NativeFieldInfoPtr_m_originalSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VPSettingsSwitcher>.NativeClassPtr, "m_originalSettings");
		NativeMethodInfoPtr_OnEnableVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPSettingsSwitcher>.NativeClassPtr, 100670280);
		NativeMethodInfoPtr_OnDisableVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPSettingsSwitcher>.NativeClassPtr, 100670281);
		NativeMethodInfoPtr_FixedUpdateVehicle_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPSettingsSwitcher>.NativeClassPtr, 100670282);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VPSettingsSwitcher>.NativeClassPtr, 100670283);
	}

	public VPSettingsSwitcher(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
