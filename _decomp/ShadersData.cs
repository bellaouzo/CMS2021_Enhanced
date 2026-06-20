using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnityEngine;
using UnityEngine.Rendering;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class ShadersData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_PartID;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShadowCastingMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_Materials;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ShadersData>.NativeClassPtr));

	public unsafe int PartID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PartID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PartID)) = num;
		}
	}

	public unsafe ShadowCastingMode ShadowCastingMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShadowCastingMode);
			return *(ShadowCastingMode*)num;
		}
		set
		{
			*(ShadowCastingMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShadowCastingMode)) = shadowCastingMode;
		}
	}

	public unsafe Il2CppReferenceArray<Material> Materials
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Materials);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Materials), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	static ShadersData()
	{
		Il2CppClassPointerStore<ShadersData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "ShadersData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadersData>.NativeClassPtr);
		NativeFieldInfoPtr_PartID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadersData>.NativeClassPtr, "PartID");
		NativeFieldInfoPtr_ShadowCastingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadersData>.NativeClassPtr, "ShadowCastingMode");
		NativeFieldInfoPtr_Materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadersData>.NativeClassPtr, "Materials");
	}

	public ShadersData(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe ShadersData()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShadersData>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<ShadersData>.NativeClassPtr))
	{
	}
}
