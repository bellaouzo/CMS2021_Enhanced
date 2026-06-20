using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnityEngine;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class InteriorParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_SeatLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_SeatRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_Wheel;

	private static readonly System.IntPtr NativeFieldInfoPtr_Bench;

	private static readonly System.IntPtr NativeFieldInfoPtr_Bench_front;

	private static readonly System.IntPtr NativeFieldInfoPtr_SeatLeftPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_SeatLeftRot;

	private static readonly System.IntPtr NativeFieldInfoPtr_SeatRightPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_SeatRightRot;

	private static readonly System.IntPtr NativeFieldInfoPtr_SeatScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_SeatLeftHeightMod;

	private static readonly System.IntPtr NativeFieldInfoPtr_SeatRightHeightMod;

	private static readonly System.IntPtr NativeFieldInfoPtr_WheelPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_WheelRot;

	private static readonly System.IntPtr NativeFieldInfoPtr_WheelScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_BenchPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_BenchRot;

	private static readonly System.IntPtr NativeFieldInfoPtr_BenchScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_Bench_frontPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_Bench_frontRot;

	private static readonly System.IntPtr NativeFieldInfoPtr_Bench_frontScale;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<InteriorParams>.NativeClassPtr));

	public unsafe string SeatLeft
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SeatLeft);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SeatLeft), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string SeatRight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SeatRight);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SeatRight), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string Wheel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Wheel);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Wheel), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string Bench
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Bench);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Bench), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string Bench_front
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Bench_front);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Bench_front), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe Vector3 SeatLeftPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SeatLeftPos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SeatLeftPos)) = vector;
		}
	}

	public unsafe Vector3 SeatLeftRot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SeatLeftRot);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SeatLeftRot)) = vector;
		}
	}

	public unsafe Vector3 SeatRightPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SeatRightPos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SeatRightPos)) = vector;
		}
	}

	public unsafe Vector3 SeatRightRot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SeatRightRot);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SeatRightRot)) = vector;
		}
	}

	public unsafe float SeatScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SeatScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SeatScale)) = num;
		}
	}

	public unsafe float SeatLeftHeightMod
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SeatLeftHeightMod);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SeatLeftHeightMod)) = num;
		}
	}

	public unsafe float SeatRightHeightMod
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SeatRightHeightMod);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SeatRightHeightMod)) = num;
		}
	}

	public unsafe Vector3 WheelPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WheelPos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WheelPos)) = vector;
		}
	}

	public unsafe Vector3 WheelRot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WheelRot);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WheelRot)) = vector;
		}
	}

	public unsafe float WheelScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WheelScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WheelScale)) = num;
		}
	}

	public unsafe Vector3 BenchPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BenchPos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BenchPos)) = vector;
		}
	}

	public unsafe Vector3 BenchRot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BenchRot);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BenchRot)) = vector;
		}
	}

	public unsafe float BenchScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BenchScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BenchScale)) = num;
		}
	}

	public unsafe Vector3 Bench_frontPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Bench_frontPos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Bench_frontPos)) = vector;
		}
	}

	public unsafe Vector3 Bench_frontRot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Bench_frontRot);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Bench_frontRot)) = vector;
		}
	}

	public unsafe float Bench_frontScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Bench_frontScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Bench_frontScale)) = num;
		}
	}

	static InteriorParams()
	{
		Il2CppClassPointerStore<InteriorParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "InteriorParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteriorParams>.NativeClassPtr);
		NativeFieldInfoPtr_SeatLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorParams>.NativeClassPtr, "SeatLeft");
		NativeFieldInfoPtr_SeatRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorParams>.NativeClassPtr, "SeatRight");
		NativeFieldInfoPtr_Wheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorParams>.NativeClassPtr, "Wheel");
		NativeFieldInfoPtr_Bench = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorParams>.NativeClassPtr, "Bench");
		NativeFieldInfoPtr_Bench_front = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorParams>.NativeClassPtr, "Bench_front");
		NativeFieldInfoPtr_SeatLeftPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorParams>.NativeClassPtr, "SeatLeftPos");
		NativeFieldInfoPtr_SeatLeftRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorParams>.NativeClassPtr, "SeatLeftRot");
		NativeFieldInfoPtr_SeatRightPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorParams>.NativeClassPtr, "SeatRightPos");
		NativeFieldInfoPtr_SeatRightRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorParams>.NativeClassPtr, "SeatRightRot");
		NativeFieldInfoPtr_SeatScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorParams>.NativeClassPtr, "SeatScale");
		NativeFieldInfoPtr_SeatLeftHeightMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorParams>.NativeClassPtr, "SeatLeftHeightMod");
		NativeFieldInfoPtr_SeatRightHeightMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorParams>.NativeClassPtr, "SeatRightHeightMod");
		NativeFieldInfoPtr_WheelPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorParams>.NativeClassPtr, "WheelPos");
		NativeFieldInfoPtr_WheelRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorParams>.NativeClassPtr, "WheelRot");
		NativeFieldInfoPtr_WheelScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorParams>.NativeClassPtr, "WheelScale");
		NativeFieldInfoPtr_BenchPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorParams>.NativeClassPtr, "BenchPos");
		NativeFieldInfoPtr_BenchRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorParams>.NativeClassPtr, "BenchRot");
		NativeFieldInfoPtr_BenchScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorParams>.NativeClassPtr, "BenchScale");
		NativeFieldInfoPtr_Bench_frontPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorParams>.NativeClassPtr, "Bench_frontPos");
		NativeFieldInfoPtr_Bench_frontRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorParams>.NativeClassPtr, "Bench_frontRot");
		NativeFieldInfoPtr_Bench_frontScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorParams>.NativeClassPtr, "Bench_frontScale");
	}

	public InteriorParams(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe InteriorParams()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InteriorParams>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<InteriorParams>.NativeClassPtr))
	{
	}
}
