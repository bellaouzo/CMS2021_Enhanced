using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace CMS.Tracks.Dragstrip;

[StructLayout(LayoutKind.Sequential)]
public sealed class BasicCarForDragstrip : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_CarID;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConfigVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_Tire;

	private static readonly System.IntPtr NativeFieldInfoPtr_PerformanceIndexStock;

	private static readonly System.IntPtr NativeFieldInfoPtr_PerformanceIndexPerPercent;

	private static readonly System.IntPtr NativeFieldInfoPtr_PerformanceIndexMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_CanUseForPlayer;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BasicCarForDragstrip>.NativeClassPtr));

	public unsafe string CarID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarID), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe byte ConfigVersion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigVersion);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigVersion)) = b;
		}
	}

	public unsafe byte Tire
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Tire);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Tire)) = b;
		}
	}

	public unsafe float PerformanceIndexStock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PerformanceIndexStock);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PerformanceIndexStock)) = num;
		}
	}

	public unsafe float PerformanceIndexPerPercent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PerformanceIndexPerPercent);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PerformanceIndexPerPercent)) = num;
		}
	}

	public unsafe float PerformanceIndexMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PerformanceIndexMax);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PerformanceIndexMax)) = num;
		}
	}

	public unsafe bool CanUseForPlayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanUseForPlayer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanUseForPlayer)) = flag;
		}
	}

	static BasicCarForDragstrip()
	{
		Il2CppClassPointerStore<BasicCarForDragstrip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Tracks.Dragstrip", "BasicCarForDragstrip");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicCarForDragstrip>.NativeClassPtr);
		NativeFieldInfoPtr_CarID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicCarForDragstrip>.NativeClassPtr, "CarID");
		NativeFieldInfoPtr_ConfigVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicCarForDragstrip>.NativeClassPtr, "ConfigVersion");
		NativeFieldInfoPtr_Tire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicCarForDragstrip>.NativeClassPtr, "Tire");
		NativeFieldInfoPtr_PerformanceIndexStock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicCarForDragstrip>.NativeClassPtr, "PerformanceIndexStock");
		NativeFieldInfoPtr_PerformanceIndexPerPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicCarForDragstrip>.NativeClassPtr, "PerformanceIndexPerPercent");
		NativeFieldInfoPtr_PerformanceIndexMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicCarForDragstrip>.NativeClassPtr, "PerformanceIndexMax");
		NativeFieldInfoPtr_CanUseForPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicCarForDragstrip>.NativeClassPtr, "CanUseForPlayer");
	}

	public BasicCarForDragstrip(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe BasicCarForDragstrip()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BasicCarForDragstrip>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<BasicCarForDragstrip>.NativeClassPtr))
	{
	}
}
