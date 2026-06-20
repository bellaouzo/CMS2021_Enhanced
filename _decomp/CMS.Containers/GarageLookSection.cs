using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnityEngine;

namespace CMS.Containers;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class GarageLookSection : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_RequiredUpgrade;

	private static readonly System.IntPtr NativeFieldInfoPtr_RequiredUpgrade2;

	private static readonly System.IntPtr NativeFieldInfoPtr_RendererData;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProjectMaterials;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraPoints;

	private static readonly System.IntPtr NativeFieldInfoPtr_SelectedMaterialIndex;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GarageLookSection>.NativeClassPtr));

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

	public unsafe string RequiredUpgrade
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RequiredUpgrade);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RequiredUpgrade), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string RequiredUpgrade2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RequiredUpgrade2);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RequiredUpgrade2), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe Il2CppReferenceArray<GarageLookRenderer> RendererData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RendererData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<GarageLookRenderer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RendererData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStringArray ProjectMaterials
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProjectMaterials);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStringArray(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ProjectMaterials), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<Transform> cameraPoints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraPoints);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraPoints), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int SelectedMaterialIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectedMaterialIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectedMaterialIndex)) = num;
		}
	}

	static GarageLookSection()
	{
		Il2CppClassPointerStore<GarageLookSection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers", "GarageLookSection");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GarageLookSection>.NativeClassPtr);
		NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageLookSection>.NativeClassPtr, "Name");
		NativeFieldInfoPtr_RequiredUpgrade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageLookSection>.NativeClassPtr, "RequiredUpgrade");
		NativeFieldInfoPtr_RequiredUpgrade2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageLookSection>.NativeClassPtr, "RequiredUpgrade2");
		NativeFieldInfoPtr_RendererData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageLookSection>.NativeClassPtr, "RendererData");
		NativeFieldInfoPtr_ProjectMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageLookSection>.NativeClassPtr, "ProjectMaterials");
		NativeFieldInfoPtr_cameraPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageLookSection>.NativeClassPtr, "cameraPoints");
		NativeFieldInfoPtr_SelectedMaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageLookSection>.NativeClassPtr, "SelectedMaterialIndex");
	}

	public GarageLookSection(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe GarageLookSection()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GarageLookSection>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<GarageLookSection>.NativeClassPtr))
	{
	}
}
