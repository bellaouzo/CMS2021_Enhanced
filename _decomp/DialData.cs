using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;

[StructLayout(LayoutKind.Sequential)]
public sealed class DialData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_RpmMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_RpmMaxAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_RpmMinAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_SpeedMaxAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_SpeedMinAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_SpeedMaxKph;

	private static readonly System.IntPtr NativeFieldInfoPtr_RpmMaxAngleUnderScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_RpmToScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_UseWithScale;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DialData>.NativeClassPtr));

	public unsafe string Name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe float RpmMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RpmMax);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RpmMax)) = num;
		}
	}

	public unsafe float RpmMaxAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RpmMaxAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RpmMaxAngle)) = num;
		}
	}

	public unsafe float RpmMinAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RpmMinAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RpmMinAngle)) = num;
		}
	}

	public unsafe float SpeedMaxAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpeedMaxAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpeedMaxAngle)) = num;
		}
	}

	public unsafe float SpeedMinAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpeedMinAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpeedMinAngle)) = num;
		}
	}

	public unsafe float SpeedMaxKph
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpeedMaxKph);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpeedMaxKph)) = num;
		}
	}

	public unsafe float RpmMaxAngleUnderScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RpmMaxAngleUnderScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RpmMaxAngleUnderScale)) = num;
		}
	}

	public unsafe float RpmToScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RpmToScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RpmToScale)) = num;
		}
	}

	public unsafe bool UseWithScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseWithScale);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseWithScale)) = flag;
		}
	}

	static DialData()
	{
		Il2CppClassPointerStore<DialData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "DialData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialData>.NativeClassPtr);
		NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialData>.NativeClassPtr, "Name");
		NativeFieldInfoPtr_RpmMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialData>.NativeClassPtr, "RpmMax");
		NativeFieldInfoPtr_RpmMaxAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialData>.NativeClassPtr, "RpmMaxAngle");
		NativeFieldInfoPtr_RpmMinAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialData>.NativeClassPtr, "RpmMinAngle");
		NativeFieldInfoPtr_SpeedMaxAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialData>.NativeClassPtr, "SpeedMaxAngle");
		NativeFieldInfoPtr_SpeedMinAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialData>.NativeClassPtr, "SpeedMinAngle");
		NativeFieldInfoPtr_SpeedMaxKph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialData>.NativeClassPtr, "SpeedMaxKph");
		NativeFieldInfoPtr_RpmMaxAngleUnderScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialData>.NativeClassPtr, "RpmMaxAngleUnderScale");
		NativeFieldInfoPtr_RpmToScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialData>.NativeClassPtr, "RpmToScale");
		NativeFieldInfoPtr_UseWithScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialData>.NativeClassPtr, "UseWithScale");
	}

	public DialData(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe DialData()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DialData>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<DialData>.NativeClassPtr))
	{
	}
}
