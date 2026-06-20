using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class SuspensionParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_FrontAxleStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_WheelBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_FrontTrack;

	private static readonly System.IntPtr NativeFieldInfoPtr_RearTrack;

	private static readonly System.IntPtr NativeFieldInfoPtr_ScaleFront;

	private static readonly System.IntPtr NativeFieldInfoPtr_ScaleRear;

	private static readonly System.IntPtr NativeFieldInfoPtr_ForceScaleFront;

	private static readonly System.IntPtr NativeFieldInfoPtr_ForceScaleRear;

	private static readonly System.IntPtr NativeFieldInfoPtr_Height;

	private static readonly System.IntPtr NativeFieldInfoPtr_HeightRear;

	private static readonly System.IntPtr NativeFieldInfoPtr_FrontSpringLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_FrontStiffness;

	private static readonly System.IntPtr NativeFieldInfoPtr_RearStiffness;

	private static readonly System.IntPtr NativeFieldInfoPtr_SidesFlip;

	private static readonly System.IntPtr NativeFieldInfoPtr_FrontCenterSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_FrontLeftSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_FrontRightSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_RearCenterSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_RearLeftSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_RearRightSet;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SuspensionParams>.NativeClassPtr));

	public unsafe float FrontAxleStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrontAxleStart);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrontAxleStart)) = num;
		}
	}

	public unsafe float WheelBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WheelBase);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WheelBase)) = num;
		}
	}

	public unsafe float FrontTrack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrontTrack);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrontTrack)) = num;
		}
	}

	public unsafe float RearTrack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RearTrack);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RearTrack)) = num;
		}
	}

	public unsafe float ScaleFront
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScaleFront);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScaleFront)) = num;
		}
	}

	public unsafe float ScaleRear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScaleRear);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScaleRear)) = num;
		}
	}

	public unsafe float ForceScaleFront
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForceScaleFront);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForceScaleFront)) = num;
		}
	}

	public unsafe float ForceScaleRear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForceScaleRear);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForceScaleRear)) = num;
		}
	}

	public unsafe float Height
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Height);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Height)) = num;
		}
	}

	public unsafe float HeightRear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HeightRear);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HeightRear)) = num;
		}
	}

	public unsafe float FrontSpringLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrontSpringLength);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrontSpringLength)) = num;
		}
	}

	public unsafe float FrontStiffness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrontStiffness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrontStiffness)) = num;
		}
	}

	public unsafe float RearStiffness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RearStiffness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RearStiffness)) = num;
		}
	}

	public unsafe int SidesFlip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SidesFlip);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SidesFlip)) = num;
		}
	}

	public unsafe string FrontCenterSet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrontCenterSet);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrontCenterSet), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string FrontLeftSet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrontLeftSet);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrontLeftSet), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string FrontRightSet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrontRightSet);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrontRightSet), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string RearCenterSet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RearCenterSet);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RearCenterSet), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string RearLeftSet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RearLeftSet);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RearLeftSet), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string RearRightSet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RearRightSet);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RearRightSet), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	static SuspensionParams()
	{
		Il2CppClassPointerStore<SuspensionParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SuspensionParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SuspensionParams>.NativeClassPtr);
		NativeFieldInfoPtr_FrontAxleStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuspensionParams>.NativeClassPtr, "FrontAxleStart");
		NativeFieldInfoPtr_WheelBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuspensionParams>.NativeClassPtr, "WheelBase");
		NativeFieldInfoPtr_FrontTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuspensionParams>.NativeClassPtr, "FrontTrack");
		NativeFieldInfoPtr_RearTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuspensionParams>.NativeClassPtr, "RearTrack");
		NativeFieldInfoPtr_ScaleFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuspensionParams>.NativeClassPtr, "ScaleFront");
		NativeFieldInfoPtr_ScaleRear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuspensionParams>.NativeClassPtr, "ScaleRear");
		NativeFieldInfoPtr_ForceScaleFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuspensionParams>.NativeClassPtr, "ForceScaleFront");
		NativeFieldInfoPtr_ForceScaleRear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuspensionParams>.NativeClassPtr, "ForceScaleRear");
		NativeFieldInfoPtr_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuspensionParams>.NativeClassPtr, "Height");
		NativeFieldInfoPtr_HeightRear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuspensionParams>.NativeClassPtr, "HeightRear");
		NativeFieldInfoPtr_FrontSpringLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuspensionParams>.NativeClassPtr, "FrontSpringLength");
		NativeFieldInfoPtr_FrontStiffness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuspensionParams>.NativeClassPtr, "FrontStiffness");
		NativeFieldInfoPtr_RearStiffness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuspensionParams>.NativeClassPtr, "RearStiffness");
		NativeFieldInfoPtr_SidesFlip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuspensionParams>.NativeClassPtr, "SidesFlip");
		NativeFieldInfoPtr_FrontCenterSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuspensionParams>.NativeClassPtr, "FrontCenterSet");
		NativeFieldInfoPtr_FrontLeftSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuspensionParams>.NativeClassPtr, "FrontLeftSet");
		NativeFieldInfoPtr_FrontRightSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuspensionParams>.NativeClassPtr, "FrontRightSet");
		NativeFieldInfoPtr_RearCenterSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuspensionParams>.NativeClassPtr, "RearCenterSet");
		NativeFieldInfoPtr_RearLeftSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuspensionParams>.NativeClassPtr, "RearLeftSet");
		NativeFieldInfoPtr_RearRightSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuspensionParams>.NativeClassPtr, "RearRightSet");
	}

	public SuspensionParams(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe SuspensionParams()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SuspensionParams>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<SuspensionParams>.NativeClassPtr))
	{
	}
}
