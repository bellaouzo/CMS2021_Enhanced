using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnityEngine;

namespace CMS.Containers;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class GarageLookRenderer : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Renderer;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaterialNo;

	private static readonly System.IntPtr NativeFieldInfoPtr_OriginalMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_Replaced;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GarageLookRenderer>.NativeClassPtr));

	public unsafe Renderer Renderer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Renderer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Renderer(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Renderer), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int MaterialNo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaterialNo);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaterialNo)) = num;
		}
	}

	public unsafe Material OriginalMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OriginalMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Material(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OriginalMaterial), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool Replaced
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Replaced);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Replaced)) = flag;
		}
	}

	static GarageLookRenderer()
	{
		Il2CppClassPointerStore<GarageLookRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers", "GarageLookRenderer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GarageLookRenderer>.NativeClassPtr);
		NativeFieldInfoPtr_Renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageLookRenderer>.NativeClassPtr, "Renderer");
		NativeFieldInfoPtr_MaterialNo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageLookRenderer>.NativeClassPtr, "MaterialNo");
		NativeFieldInfoPtr_OriginalMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageLookRenderer>.NativeClassPtr, "OriginalMaterial");
		NativeFieldInfoPtr_Replaced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageLookRenderer>.NativeClassPtr, "Replaced");
	}

	public GarageLookRenderer(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe GarageLookRenderer()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GarageLookRenderer>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<GarageLookRenderer>.NativeClassPtr))
	{
	}
}
