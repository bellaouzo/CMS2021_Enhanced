using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CMS.Tracks.Dragstrip;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace CMS.Containers;

[StructLayout(LayoutKind.Sequential)]
public sealed class DragResultsData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Opponent;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerCarID;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerCarConfig;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerPI;

	private static readonly System.IntPtr NativeFieldInfoPtr_DragSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_OpponentFinished;

	private static readonly System.IntPtr NativeFieldInfoPtr_Winner;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DragResultsData>.NativeClassPtr));

	public unsafe CarForDragstrip Opponent
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Opponent);
			return new CarForDragstrip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CarForDragstrip>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Opponent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CarForDragstrip>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe string PlayerCarID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerCarID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerCarID), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe int PlayerCarConfig
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerCarConfig);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerCarConfig)) = num;
		}
	}

	public unsafe float PlayerPI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerPI);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerPI)) = num;
		}
	}

	public unsafe DragSettings DragSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DragSettings);
			return *(DragSettings*)num;
		}
		set
		{
			*(DragSettings*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DragSettings)) = dragSettings;
		}
	}

	public unsafe bool OpponentFinished
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OpponentFinished);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OpponentFinished)) = flag;
		}
	}

	public unsafe DragMember Winner
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Winner);
			return *(DragMember*)num;
		}
		set
		{
			*(DragMember*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Winner)) = dragMember;
		}
	}

	static DragResultsData()
	{
		Il2CppClassPointerStore<DragResultsData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers", "DragResultsData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragResultsData>.NativeClassPtr);
		NativeFieldInfoPtr_Opponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsData>.NativeClassPtr, "Opponent");
		NativeFieldInfoPtr_PlayerCarID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsData>.NativeClassPtr, "PlayerCarID");
		NativeFieldInfoPtr_PlayerCarConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsData>.NativeClassPtr, "PlayerCarConfig");
		NativeFieldInfoPtr_PlayerPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsData>.NativeClassPtr, "PlayerPI");
		NativeFieldInfoPtr_DragSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsData>.NativeClassPtr, "DragSettings");
		NativeFieldInfoPtr_OpponentFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsData>.NativeClassPtr, "OpponentFinished");
		NativeFieldInfoPtr_Winner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragResultsData>.NativeClassPtr, "Winner");
	}

	public DragResultsData(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe DragResultsData()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DragResultsData>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<DragResultsData>.NativeClassPtr))
	{
	}
}
