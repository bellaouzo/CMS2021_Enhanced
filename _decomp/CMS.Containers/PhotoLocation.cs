using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnityEngine;

namespace CMS.Containers;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class PhotoLocation : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_Author;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsMod;

	private static readonly System.IntPtr NativeFieldInfoPtr_Path;

	private static readonly System.IntPtr NativeFieldInfoPtr_ThumbnailPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_DirectionalLightColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_DirectionalLightTemperature;

	private static readonly System.IntPtr NativeFieldInfoPtr_DirectionalLightIntensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_DirectionalLightAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnableGlobalDensityVolume;

	private static readonly System.IntPtr NativeFieldInfoPtr_DensityVolumeColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_DensityVolumeFogDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_Skybox;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PhotoLocation>.NativeClassPtr));

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

	public unsafe string Author
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Author);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Author), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe bool IsMod
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsMod);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsMod)) = flag;
		}
	}

	public unsafe string Path
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Path);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Path), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string ThumbnailPath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ThumbnailPath);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ThumbnailPath), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe Vector3 DirectionalLightColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DirectionalLightColor);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DirectionalLightColor)) = vector;
		}
	}

	public unsafe float DirectionalLightTemperature
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DirectionalLightTemperature);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DirectionalLightTemperature)) = num;
		}
	}

	public unsafe float DirectionalLightIntensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DirectionalLightIntensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DirectionalLightIntensity)) = num;
		}
	}

	public unsafe Vector3 DirectionalLightAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DirectionalLightAngle);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DirectionalLightAngle)) = vector;
		}
	}

	public unsafe bool EnableGlobalDensityVolume
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnableGlobalDensityVolume);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnableGlobalDensityVolume)) = flag;
		}
	}

	public unsafe Color DensityVolumeColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DensityVolumeColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DensityVolumeColor)) = color;
		}
	}

	public unsafe float DensityVolumeFogDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DensityVolumeFogDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DensityVolumeFogDistance)) = num;
		}
	}

	public unsafe string Skybox
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Skybox);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Skybox), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	static PhotoLocation()
	{
		Il2CppClassPointerStore<PhotoLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers", "PhotoLocation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhotoLocation>.NativeClassPtr);
		NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoLocation>.NativeClassPtr, "Name");
		NativeFieldInfoPtr_Author = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoLocation>.NativeClassPtr, "Author");
		NativeFieldInfoPtr_IsMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoLocation>.NativeClassPtr, "IsMod");
		NativeFieldInfoPtr_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoLocation>.NativeClassPtr, "Path");
		NativeFieldInfoPtr_ThumbnailPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoLocation>.NativeClassPtr, "ThumbnailPath");
		NativeFieldInfoPtr_DirectionalLightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoLocation>.NativeClassPtr, "DirectionalLightColor");
		NativeFieldInfoPtr_DirectionalLightTemperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoLocation>.NativeClassPtr, "DirectionalLightTemperature");
		NativeFieldInfoPtr_DirectionalLightIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoLocation>.NativeClassPtr, "DirectionalLightIntensity");
		NativeFieldInfoPtr_DirectionalLightAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoLocation>.NativeClassPtr, "DirectionalLightAngle");
		NativeFieldInfoPtr_EnableGlobalDensityVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoLocation>.NativeClassPtr, "EnableGlobalDensityVolume");
		NativeFieldInfoPtr_DensityVolumeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoLocation>.NativeClassPtr, "DensityVolumeColor");
		NativeFieldInfoPtr_DensityVolumeFogDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoLocation>.NativeClassPtr, "DensityVolumeFogDistance");
		NativeFieldInfoPtr_Skybox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoLocation>.NativeClassPtr, "Skybox");
	}

	public PhotoLocation(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe PhotoLocation()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PhotoLocation>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<PhotoLocation>.NativeClassPtr))
	{
	}
}
