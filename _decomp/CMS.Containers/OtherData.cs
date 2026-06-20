using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace CMS.Containers;

[StructLayout(LayoutKind.Sequential)]
public sealed class OtherData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Year;

	private static readonly System.IntPtr NativeFieldInfoPtr_TransmissionType;

	private static readonly System.IntPtr NativeFieldInfoPtr_Weight;

	private static readonly System.IntPtr NativeFieldInfoPtr_BrakeMod;

	private static readonly System.IntPtr NativeFieldInfoPtr_Cx;

	private static readonly System.IntPtr NativeFieldInfoPtr_LifterArmsAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_LifterArmsRise;

	private static readonly System.IntPtr NativeFieldInfoPtr_SuspTravel;

	private static readonly System.IntPtr NativeFieldInfoPtr_DoorAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_EngineTorqueMod;

	private static readonly System.IntPtr NativeFieldInfoPtr_EngineRpmMod;

	private static readonly System.IntPtr NativeFieldInfoPtr_GearsFinalRatioMod;

	private static readonly System.IntPtr NativeFieldInfoPtr_RightHandDrive;

	private static readonly System.IntPtr NativeFieldInfoPtr_AllowedPlaces;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShowSuspensionOnTrack;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<OtherData>.NativeClassPtr));

	public unsafe int Year
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Year);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Year)) = num;
		}
	}

	public unsafe string TransmissionType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TransmissionType);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TransmissionType), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe float Weight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Weight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Weight)) = num;
		}
	}

	public unsafe float BrakeMod
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BrakeMod);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BrakeMod)) = num;
		}
	}

	public unsafe float Cx
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Cx);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Cx)) = num;
		}
	}

	public unsafe float LifterArmsAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LifterArmsAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LifterArmsAngle)) = num;
		}
	}

	public unsafe float LifterArmsRise
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LifterArmsRise);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LifterArmsRise)) = num;
		}
	}

	public unsafe float SuspTravel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SuspTravel);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SuspTravel)) = num;
		}
	}

	public unsafe float DoorAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DoorAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DoorAngle)) = num;
		}
	}

	public unsafe float EngineTorqueMod
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EngineTorqueMod);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EngineTorqueMod)) = num;
		}
	}

	public unsafe float EngineRpmMod
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EngineRpmMod);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EngineRpmMod)) = num;
		}
	}

	public unsafe float GearsFinalRatioMod
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GearsFinalRatioMod);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GearsFinalRatioMod)) = num;
		}
	}

	public unsafe bool RightHandDrive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RightHandDrive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RightHandDrive)) = flag;
		}
	}

	public unsafe Il2CppStringArray AllowedPlaces
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AllowedPlaces);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStringArray(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AllowedPlaces), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool ShowSuspensionOnTrack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowSuspensionOnTrack);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShowSuspensionOnTrack)) = flag;
		}
	}

	static OtherData()
	{
		Il2CppClassPointerStore<OtherData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers", "OtherData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OtherData>.NativeClassPtr);
		NativeFieldInfoPtr_Year = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OtherData>.NativeClassPtr, "Year");
		NativeFieldInfoPtr_TransmissionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OtherData>.NativeClassPtr, "TransmissionType");
		NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OtherData>.NativeClassPtr, "Weight");
		NativeFieldInfoPtr_BrakeMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OtherData>.NativeClassPtr, "BrakeMod");
		NativeFieldInfoPtr_Cx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OtherData>.NativeClassPtr, "Cx");
		NativeFieldInfoPtr_LifterArmsAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OtherData>.NativeClassPtr, "LifterArmsAngle");
		NativeFieldInfoPtr_LifterArmsRise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OtherData>.NativeClassPtr, "LifterArmsRise");
		NativeFieldInfoPtr_SuspTravel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OtherData>.NativeClassPtr, "SuspTravel");
		NativeFieldInfoPtr_DoorAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OtherData>.NativeClassPtr, "DoorAngle");
		NativeFieldInfoPtr_EngineTorqueMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OtherData>.NativeClassPtr, "EngineTorqueMod");
		NativeFieldInfoPtr_EngineRpmMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OtherData>.NativeClassPtr, "EngineRpmMod");
		NativeFieldInfoPtr_GearsFinalRatioMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OtherData>.NativeClassPtr, "GearsFinalRatioMod");
		NativeFieldInfoPtr_RightHandDrive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OtherData>.NativeClassPtr, "RightHandDrive");
		NativeFieldInfoPtr_AllowedPlaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OtherData>.NativeClassPtr, "AllowedPlaces");
		NativeFieldInfoPtr_ShowSuspensionOnTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OtherData>.NativeClassPtr, "ShowSuspensionOnTrack");
	}

	public OtherData(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe OtherData()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<OtherData>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<OtherData>.NativeClassPtr))
	{
	}
}
