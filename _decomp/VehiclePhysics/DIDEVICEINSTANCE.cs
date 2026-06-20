using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace VehiclePhysics;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
public sealed class DIDEVICEINSTANCE : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_dwSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_guidInstance;

	private static readonly System.IntPtr NativeFieldInfoPtr_guidProduct;

	private static readonly System.IntPtr NativeFieldInfoPtr_dwDevType;

	private static readonly System.IntPtr NativeFieldInfoPtr_instanceName;

	private static readonly System.IntPtr NativeFieldInfoPtr_productName;

	private static readonly System.IntPtr NativeFieldInfoPtr_guidFFDriver;

	private static readonly System.IntPtr NativeFieldInfoPtr_wUsagePage;

	private static readonly System.IntPtr NativeFieldInfoPtr_wUsage;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DIDEVICEINSTANCE>.NativeClassPtr));

	public unsafe uint dwSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwSize);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwSize)) = num;
		}
	}

	public unsafe Il2CppSystem.Guid guidInstance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guidInstance);
			return *(Il2CppSystem.Guid*)num;
		}
		set
		{
			*(Il2CppSystem.Guid*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guidInstance)) = guid;
		}
	}

	public unsafe Il2CppSystem.Guid guidProduct
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guidProduct);
			return *(Il2CppSystem.Guid*)num;
		}
		set
		{
			*(Il2CppSystem.Guid*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guidProduct)) = guid;
		}
	}

	public unsafe uint dwDevType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwDevType);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwDevType)) = num;
		}
	}

	public unsafe string instanceName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string productName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_productName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_productName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe Il2CppSystem.Guid guidFFDriver
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guidFFDriver);
			return *(Il2CppSystem.Guid*)num;
		}
		set
		{
			*(Il2CppSystem.Guid*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guidFFDriver)) = guid;
		}
	}

	public unsafe ushort wUsagePage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wUsagePage);
			return *(ushort*)num;
		}
		set
		{
			*(ushort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wUsagePage)) = num;
		}
	}

	public unsafe ushort wUsage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wUsage);
			return *(ushort*)num;
		}
		set
		{
			*(ushort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wUsage)) = num;
		}
	}

	static DIDEVICEINSTANCE()
	{
		Il2CppClassPointerStore<DIDEVICEINSTANCE>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "DIDEVICEINSTANCE");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DIDEVICEINSTANCE>.NativeClassPtr);
		NativeFieldInfoPtr_dwSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIDEVICEINSTANCE>.NativeClassPtr, "dwSize");
		NativeFieldInfoPtr_guidInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIDEVICEINSTANCE>.NativeClassPtr, "guidInstance");
		NativeFieldInfoPtr_guidProduct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIDEVICEINSTANCE>.NativeClassPtr, "guidProduct");
		NativeFieldInfoPtr_dwDevType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIDEVICEINSTANCE>.NativeClassPtr, "dwDevType");
		NativeFieldInfoPtr_instanceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIDEVICEINSTANCE>.NativeClassPtr, "instanceName");
		NativeFieldInfoPtr_productName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIDEVICEINSTANCE>.NativeClassPtr, "productName");
		NativeFieldInfoPtr_guidFFDriver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIDEVICEINSTANCE>.NativeClassPtr, "guidFFDriver");
		NativeFieldInfoPtr_wUsagePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIDEVICEINSTANCE>.NativeClassPtr, "wUsagePage");
		NativeFieldInfoPtr_wUsage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIDEVICEINSTANCE>.NativeClassPtr, "wUsage");
	}

	public DIDEVICEINSTANCE(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe DIDEVICEINSTANCE()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DIDEVICEINSTANCE>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<DIDEVICEINSTANCE>.NativeClassPtr))
	{
	}
}
