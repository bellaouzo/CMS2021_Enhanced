using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace CMS.Containers;

[StructLayout(LayoutKind.Sequential)]
public sealed class SalonCarData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_SalonCar;

	private static readonly System.IntPtr NativeFieldInfoPtr_OriginalFrontRim;

	private static readonly System.IntPtr NativeFieldInfoPtr_OriginalFrontTire;

	private static readonly System.IntPtr NativeFieldInfoPtr_OriginalRearTire;

	private static readonly System.IntPtr NativeFieldInfoPtr_OriginalRearRim;

	private static readonly System.IntPtr NativeFieldInfoPtr_SelectedFrontRim;

	private static readonly System.IntPtr NativeFieldInfoPtr_SelectedFrontTire;

	private static readonly System.IntPtr NativeFieldInfoPtr_SelectedRearTire;

	private static readonly System.IntPtr NativeFieldInfoPtr_SelectedRearRim;

	private static readonly System.IntPtr NativeFieldInfoPtr_BaseCarPrice;

	private static readonly System.IntPtr NativeFieldInfoPtr_FrontTiresCost;

	private static readonly System.IntPtr NativeFieldInfoPtr_RearTiresCost;

	private static readonly System.IntPtr NativeFieldInfoPtr_FrontRimsCost;

	private static readonly System.IntPtr NativeFieldInfoPtr_RearRimsCost;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SalonCarData>.NativeClassPtr));

	public unsafe bool SalonCar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SalonCar);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SalonCar)) = flag;
		}
	}

	public unsafe string OriginalFrontRim
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OriginalFrontRim);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OriginalFrontRim), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string OriginalFrontTire
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OriginalFrontTire);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OriginalFrontTire), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string OriginalRearTire
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OriginalRearTire);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OriginalRearTire), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string OriginalRearRim
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OriginalRearRim);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OriginalRearRim), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string SelectedFrontRim
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectedFrontRim);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectedFrontRim), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string SelectedFrontTire
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectedFrontTire);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectedFrontTire), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string SelectedRearTire
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectedRearTire);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectedRearTire), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string SelectedRearRim
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectedRearRim);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectedRearRim), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe int BaseCarPrice
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BaseCarPrice);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BaseCarPrice)) = num;
		}
	}

	public unsafe int FrontTiresCost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrontTiresCost);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrontTiresCost)) = num;
		}
	}

	public unsafe int RearTiresCost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RearTiresCost);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RearTiresCost)) = num;
		}
	}

	public unsafe int FrontRimsCost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrontRimsCost);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrontRimsCost)) = num;
		}
	}

	public unsafe int RearRimsCost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RearRimsCost);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RearRimsCost)) = num;
		}
	}

	static SalonCarData()
	{
		Il2CppClassPointerStore<SalonCarData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers", "SalonCarData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SalonCarData>.NativeClassPtr);
		NativeFieldInfoPtr_SalonCar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalonCarData>.NativeClassPtr, "SalonCar");
		NativeFieldInfoPtr_OriginalFrontRim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalonCarData>.NativeClassPtr, "OriginalFrontRim");
		NativeFieldInfoPtr_OriginalFrontTire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalonCarData>.NativeClassPtr, "OriginalFrontTire");
		NativeFieldInfoPtr_OriginalRearTire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalonCarData>.NativeClassPtr, "OriginalRearTire");
		NativeFieldInfoPtr_OriginalRearRim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalonCarData>.NativeClassPtr, "OriginalRearRim");
		NativeFieldInfoPtr_SelectedFrontRim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalonCarData>.NativeClassPtr, "SelectedFrontRim");
		NativeFieldInfoPtr_SelectedFrontTire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalonCarData>.NativeClassPtr, "SelectedFrontTire");
		NativeFieldInfoPtr_SelectedRearTire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalonCarData>.NativeClassPtr, "SelectedRearTire");
		NativeFieldInfoPtr_SelectedRearRim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalonCarData>.NativeClassPtr, "SelectedRearRim");
		NativeFieldInfoPtr_BaseCarPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalonCarData>.NativeClassPtr, "BaseCarPrice");
		NativeFieldInfoPtr_FrontTiresCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalonCarData>.NativeClassPtr, "FrontTiresCost");
		NativeFieldInfoPtr_RearTiresCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalonCarData>.NativeClassPtr, "RearTiresCost");
		NativeFieldInfoPtr_FrontRimsCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalonCarData>.NativeClassPtr, "FrontRimsCost");
		NativeFieldInfoPtr_RearRimsCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SalonCarData>.NativeClassPtr, "RearRimsCost");
	}

	public SalonCarData(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe SalonCarData()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SalonCarData>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<SalonCarData>.NativeClassPtr))
	{
	}
}
