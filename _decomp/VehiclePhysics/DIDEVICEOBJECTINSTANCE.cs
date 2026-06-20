using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace VehiclePhysics;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
public sealed class DIDEVICEOBJECTINSTANCE : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_dwSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_guidType;

	private static readonly System.IntPtr NativeFieldInfoPtr_dwOfs;

	private static readonly System.IntPtr NativeFieldInfoPtr_dwType;

	private static readonly System.IntPtr NativeFieldInfoPtr_dwFlags;

	private static readonly System.IntPtr NativeFieldInfoPtr_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_dwFFMaxForce;

	private static readonly System.IntPtr NativeFieldInfoPtr_dwFFForceResolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_wCollectionNumber;

	private static readonly System.IntPtr NativeFieldInfoPtr_wDesignatorIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_wUsagePage;

	private static readonly System.IntPtr NativeFieldInfoPtr_wUsage;

	private static readonly System.IntPtr NativeFieldInfoPtr_dwDimension;

	private static readonly System.IntPtr NativeFieldInfoPtr_wExponent;

	private static readonly System.IntPtr NativeFieldInfoPtr_wReportId;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DIDEVICEOBJECTINSTANCE>.NativeClassPtr));

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

	public unsafe Il2CppSystem.Guid guidType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guidType);
			return *(Il2CppSystem.Guid*)num;
		}
		set
		{
			*(Il2CppSystem.Guid*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guidType)) = guid;
		}
	}

	public unsafe uint dwOfs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwOfs);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwOfs)) = num;
		}
	}

	public unsafe uint dwType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwType);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwType)) = num;
		}
	}

	public unsafe uint dwFlags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwFlags);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwFlags)) = num;
		}
	}

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

	public unsafe uint dwFFMaxForce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwFFMaxForce);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwFFMaxForce)) = num;
		}
	}

	public unsafe uint dwFFForceResolution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwFFForceResolution);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwFFForceResolution)) = num;
		}
	}

	public unsafe ushort wCollectionNumber
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wCollectionNumber);
			return *(ushort*)num;
		}
		set
		{
			*(ushort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wCollectionNumber)) = num;
		}
	}

	public unsafe ushort wDesignatorIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wDesignatorIndex);
			return *(ushort*)num;
		}
		set
		{
			*(ushort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wDesignatorIndex)) = num;
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

	public unsafe uint dwDimension
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwDimension);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwDimension)) = num;
		}
	}

	public unsafe ushort wExponent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wExponent);
			return *(ushort*)num;
		}
		set
		{
			*(ushort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wExponent)) = num;
		}
	}

	public unsafe ushort wReportId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wReportId);
			return *(ushort*)num;
		}
		set
		{
			*(ushort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wReportId)) = num;
		}
	}

	static DIDEVICEOBJECTINSTANCE()
	{
		Il2CppClassPointerStore<DIDEVICEOBJECTINSTANCE>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "DIDEVICEOBJECTINSTANCE");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DIDEVICEOBJECTINSTANCE>.NativeClassPtr);
		NativeFieldInfoPtr_dwSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIDEVICEOBJECTINSTANCE>.NativeClassPtr, "dwSize");
		NativeFieldInfoPtr_guidType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIDEVICEOBJECTINSTANCE>.NativeClassPtr, "guidType");
		NativeFieldInfoPtr_dwOfs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIDEVICEOBJECTINSTANCE>.NativeClassPtr, "dwOfs");
		NativeFieldInfoPtr_dwType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIDEVICEOBJECTINSTANCE>.NativeClassPtr, "dwType");
		NativeFieldInfoPtr_dwFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIDEVICEOBJECTINSTANCE>.NativeClassPtr, "dwFlags");
		NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIDEVICEOBJECTINSTANCE>.NativeClassPtr, "name");
		NativeFieldInfoPtr_dwFFMaxForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIDEVICEOBJECTINSTANCE>.NativeClassPtr, "dwFFMaxForce");
		NativeFieldInfoPtr_dwFFForceResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIDEVICEOBJECTINSTANCE>.NativeClassPtr, "dwFFForceResolution");
		NativeFieldInfoPtr_wCollectionNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIDEVICEOBJECTINSTANCE>.NativeClassPtr, "wCollectionNumber");
		NativeFieldInfoPtr_wDesignatorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIDEVICEOBJECTINSTANCE>.NativeClassPtr, "wDesignatorIndex");
		NativeFieldInfoPtr_wUsagePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIDEVICEOBJECTINSTANCE>.NativeClassPtr, "wUsagePage");
		NativeFieldInfoPtr_wUsage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIDEVICEOBJECTINSTANCE>.NativeClassPtr, "wUsage");
		NativeFieldInfoPtr_dwDimension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIDEVICEOBJECTINSTANCE>.NativeClassPtr, "dwDimension");
		NativeFieldInfoPtr_wExponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIDEVICEOBJECTINSTANCE>.NativeClassPtr, "wExponent");
		NativeFieldInfoPtr_wReportId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIDEVICEOBJECTINSTANCE>.NativeClassPtr, "wReportId");
	}

	public DIDEVICEOBJECTINSTANCE(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe DIDEVICEOBJECTINSTANCE()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DIDEVICEOBJECTINSTANCE>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<DIDEVICEOBJECTINSTANCE>.NativeClassPtr))
	{
	}
}
