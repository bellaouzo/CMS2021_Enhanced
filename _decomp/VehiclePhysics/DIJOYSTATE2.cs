using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace VehiclePhysics;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
public sealed class DIJOYSTATE2 : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_lX;

	private static readonly System.IntPtr NativeFieldInfoPtr_lY;

	private static readonly System.IntPtr NativeFieldInfoPtr_lZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_lRx;

	private static readonly System.IntPtr NativeFieldInfoPtr_lRy;

	private static readonly System.IntPtr NativeFieldInfoPtr_lRz;

	private static readonly System.IntPtr NativeFieldInfoPtr_rglSlider;

	private static readonly System.IntPtr NativeFieldInfoPtr_rgdwPOV;

	private static readonly System.IntPtr NativeFieldInfoPtr_rgbButtons;

	private static readonly System.IntPtr NativeFieldInfoPtr_lVX;

	private static readonly System.IntPtr NativeFieldInfoPtr_lVY;

	private static readonly System.IntPtr NativeFieldInfoPtr_lVZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_lVRx;

	private static readonly System.IntPtr NativeFieldInfoPtr_lVRy;

	private static readonly System.IntPtr NativeFieldInfoPtr_lVRz;

	private static readonly System.IntPtr NativeFieldInfoPtr_rglVSlider;

	private static readonly System.IntPtr NativeFieldInfoPtr_lAX;

	private static readonly System.IntPtr NativeFieldInfoPtr_lAY;

	private static readonly System.IntPtr NativeFieldInfoPtr_lAZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_lARx;

	private static readonly System.IntPtr NativeFieldInfoPtr_lARy;

	private static readonly System.IntPtr NativeFieldInfoPtr_lARz;

	private static readonly System.IntPtr NativeFieldInfoPtr_rglASlider;

	private static readonly System.IntPtr NativeFieldInfoPtr_lFX;

	private static readonly System.IntPtr NativeFieldInfoPtr_lFY;

	private static readonly System.IntPtr NativeFieldInfoPtr_lFZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_lFRx;

	private static readonly System.IntPtr NativeFieldInfoPtr_lFRy;

	private static readonly System.IntPtr NativeFieldInfoPtr_lFRz;

	private static readonly System.IntPtr NativeFieldInfoPtr_rglFSlider;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr));

	public unsafe int lX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lX);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lX)) = num;
		}
	}

	public unsafe int lY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lY);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lY)) = num;
		}
	}

	public unsafe int lZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lZ);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lZ)) = num;
		}
	}

	public unsafe int lRx
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lRx);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lRx)) = num;
		}
	}

	public unsafe int lRy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lRy);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lRy)) = num;
		}
	}

	public unsafe int lRz
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lRz);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lRz)) = num;
		}
	}

	public unsafe Il2CppStructArray<int> rglSlider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rglSlider);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<int>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rglSlider), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<int> rgdwPOV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rgdwPOV);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<int>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rgdwPOV), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<byte> rgbButtons
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rgbButtons);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<byte>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rgbButtons), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int lVX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lVX);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lVX)) = num;
		}
	}

	public unsafe int lVY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lVY);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lVY)) = num;
		}
	}

	public unsafe int lVZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lVZ);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lVZ)) = num;
		}
	}

	public unsafe int lVRx
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lVRx);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lVRx)) = num;
		}
	}

	public unsafe int lVRy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lVRy);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lVRy)) = num;
		}
	}

	public unsafe int lVRz
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lVRz);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lVRz)) = num;
		}
	}

	public unsafe Il2CppStructArray<int> rglVSlider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rglVSlider);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<int>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rglVSlider), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int lAX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lAX);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lAX)) = num;
		}
	}

	public unsafe int lAY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lAY);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lAY)) = num;
		}
	}

	public unsafe int lAZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lAZ);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lAZ)) = num;
		}
	}

	public unsafe int lARx
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lARx);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lARx)) = num;
		}
	}

	public unsafe int lARy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lARy);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lARy)) = num;
		}
	}

	public unsafe int lARz
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lARz);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lARz)) = num;
		}
	}

	public unsafe Il2CppStructArray<int> rglASlider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rglASlider);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<int>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rglASlider), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int lFX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lFX);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lFX)) = num;
		}
	}

	public unsafe int lFY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lFY);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lFY)) = num;
		}
	}

	public unsafe int lFZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lFZ);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lFZ)) = num;
		}
	}

	public unsafe int lFRx
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lFRx);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lFRx)) = num;
		}
	}

	public unsafe int lFRy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lFRy);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lFRy)) = num;
		}
	}

	public unsafe int lFRz
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lFRz);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lFRz)) = num;
		}
	}

	public unsafe Il2CppStructArray<int> rglFSlider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rglFSlider);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<int>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rglFSlider), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	static DIJOYSTATE2()
	{
		Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "VehiclePhysics", "DIJOYSTATE2");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr);
		NativeFieldInfoPtr_lX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, "lX");
		NativeFieldInfoPtr_lY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, "lY");
		NativeFieldInfoPtr_lZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, "lZ");
		NativeFieldInfoPtr_lRx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, "lRx");
		NativeFieldInfoPtr_lRy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, "lRy");
		NativeFieldInfoPtr_lRz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, "lRz");
		NativeFieldInfoPtr_rglSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, "rglSlider");
		NativeFieldInfoPtr_rgdwPOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, "rgdwPOV");
		NativeFieldInfoPtr_rgbButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, "rgbButtons");
		NativeFieldInfoPtr_lVX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, "lVX");
		NativeFieldInfoPtr_lVY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, "lVY");
		NativeFieldInfoPtr_lVZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, "lVZ");
		NativeFieldInfoPtr_lVRx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, "lVRx");
		NativeFieldInfoPtr_lVRy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, "lVRy");
		NativeFieldInfoPtr_lVRz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, "lVRz");
		NativeFieldInfoPtr_rglVSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, "rglVSlider");
		NativeFieldInfoPtr_lAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, "lAX");
		NativeFieldInfoPtr_lAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, "lAY");
		NativeFieldInfoPtr_lAZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, "lAZ");
		NativeFieldInfoPtr_lARx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, "lARx");
		NativeFieldInfoPtr_lARy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, "lARy");
		NativeFieldInfoPtr_lARz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, "lARz");
		NativeFieldInfoPtr_rglASlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, "rglASlider");
		NativeFieldInfoPtr_lFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, "lFX");
		NativeFieldInfoPtr_lFY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, "lFY");
		NativeFieldInfoPtr_lFZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, "lFZ");
		NativeFieldInfoPtr_lFRx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, "lFRx");
		NativeFieldInfoPtr_lFRy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, "lFRy");
		NativeFieldInfoPtr_lFRz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, "lFRz");
		NativeFieldInfoPtr_rglFSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, "rglFSlider");
	}

	public DIJOYSTATE2(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe DIJOYSTATE2()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<DIJOYSTATE2>.NativeClassPtr))
	{
	}
}
