using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;

[StructLayout(LayoutKind.Sequential)]
public sealed class WorkshopBonusPart : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ID;

	private static readonly System.IntPtr NativeFieldInfoPtr_ItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_PathToBundle;

	private static readonly System.IntPtr NativeFieldInfoPtr_PathToPreview;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WorkshopBonusPart>.NativeClassPtr));

	public unsafe string ID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string ItemName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string PathToBundle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PathToBundle);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PathToBundle), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string PathToPreview
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PathToPreview);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PathToPreview), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	static WorkshopBonusPart()
	{
		Il2CppClassPointerStore<WorkshopBonusPart>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "WorkshopBonusPart");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkshopBonusPart>.NativeClassPtr);
		NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopBonusPart>.NativeClassPtr, "ID");
		NativeFieldInfoPtr_ItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopBonusPart>.NativeClassPtr, "ItemName");
		NativeFieldInfoPtr_PathToBundle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopBonusPart>.NativeClassPtr, "PathToBundle");
		NativeFieldInfoPtr_PathToPreview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopBonusPart>.NativeClassPtr, "PathToPreview");
	}

	public WorkshopBonusPart(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe WorkshopBonusPart()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WorkshopBonusPart>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<WorkshopBonusPart>.NativeClassPtr))
	{
	}
}
