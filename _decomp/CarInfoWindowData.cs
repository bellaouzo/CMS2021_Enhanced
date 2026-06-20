using System;
using System.Runtime.InteropServices;
using CMS.UI.Logic;
using Il2CppSystem;
using UnhollowerBaseLib;

[StructLayout(LayoutKind.Sequential)]
public sealed class CarInfoWindowData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_CarLoader;

	private static readonly System.IntPtr NativeFieldInfoPtr_CarName;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsJob;

	private static readonly System.IntPtr NativeFieldInfoPtr_Job;

	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarInfoWindowData>.NativeClassPtr));

	public unsafe CarLoader CarLoader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarLoader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CarLoader(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarLoader), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe string CarName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe bool IsJob
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsJob);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsJob)) = flag;
		}
	}

	public unsafe Job Job
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Job);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Job(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Job), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CarInfoType type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
			return *(CarInfoType*)num;
		}
		set
		{
			*(CarInfoType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = carInfoType;
		}
	}

	static CarInfoWindowData()
	{
		Il2CppClassPointerStore<CarInfoWindowData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CarInfoWindowData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarInfoWindowData>.NativeClassPtr);
		NativeFieldInfoPtr_CarLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarInfoWindowData>.NativeClassPtr, "CarLoader");
		NativeFieldInfoPtr_CarName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarInfoWindowData>.NativeClassPtr, "CarName");
		NativeFieldInfoPtr_IsJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarInfoWindowData>.NativeClassPtr, "IsJob");
		NativeFieldInfoPtr_Job = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarInfoWindowData>.NativeClassPtr, "Job");
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarInfoWindowData>.NativeClassPtr, "type");
	}

	public CarInfoWindowData(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe CarInfoWindowData()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CarInfoWindowData>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<CarInfoWindowData>.NativeClassPtr))
	{
	}
}
