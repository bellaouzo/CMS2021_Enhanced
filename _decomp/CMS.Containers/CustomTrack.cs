using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.Containers;

public class CustomTrack : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_Description;

	private static readonly System.IntPtr NativeFieldInfoPtr_Author;

	private static readonly System.IntPtr NativeFieldInfoPtr_Length;

	private static readonly System.IntPtr NativeFieldInfoPtr_Path;

	private static readonly System.IntPtr NativeFieldInfoPtr_PreviewPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_Type;

	private static readonly System.IntPtr NativeFieldInfoPtr_Gravity;

	private static readonly System.IntPtr NativeFieldInfoPtr_RenderingDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_DirectionalLightTemperature;

	private static readonly System.IntPtr NativeFieldInfoPtr_DirectionalLightIntensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_DirectionalLightColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_DirectionalLightAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_SkyboxFile;

	private static readonly System.IntPtr NativeFieldInfoPtr_DisablePostProcessing;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnableGlobalDensityVolume;

	private static readonly System.IntPtr NativeFieldInfoPtr_DensityVolumeColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_DensityVolumeFogDistance;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CustomTrack>.NativeClassPtr));

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

	public unsafe string Description
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Description);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(str));
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

	public unsafe string Length
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Length);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Length), IL2CPP.ManagedStringToIl2Cpp(str));
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

	public unsafe string PreviewPath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PreviewPath);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PreviewPath), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string Type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe Vector3 Gravity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Gravity);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Gravity)) = vector;
		}
	}

	public unsafe int RenderingDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RenderingDistance);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RenderingDistance)) = num;
		}
	}

	public unsafe uint DirectionalLightTemperature
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DirectionalLightTemperature);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DirectionalLightTemperature)) = num;
		}
	}

	public unsafe uint DirectionalLightIntensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DirectionalLightIntensity);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DirectionalLightIntensity)) = num;
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

	public unsafe string SkyboxFile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkyboxFile);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkyboxFile), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe bool DisablePostProcessing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisablePostProcessing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisablePostProcessing)) = flag;
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 218357, RefRangeEnd = 218358, XrefRangeStart = 218353, XrefRangeEnd = 218357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CustomTrack()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomTrack>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CustomTrack()
	{
		Il2CppClassPointerStore<CustomTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers", "CustomTrack");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomTrack>.NativeClassPtr);
		NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomTrack>.NativeClassPtr, "Name");
		NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomTrack>.NativeClassPtr, "Description");
		NativeFieldInfoPtr_Author = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomTrack>.NativeClassPtr, "Author");
		NativeFieldInfoPtr_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomTrack>.NativeClassPtr, "Length");
		NativeFieldInfoPtr_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomTrack>.NativeClassPtr, "Path");
		NativeFieldInfoPtr_PreviewPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomTrack>.NativeClassPtr, "PreviewPath");
		NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomTrack>.NativeClassPtr, "Type");
		NativeFieldInfoPtr_Gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomTrack>.NativeClassPtr, "Gravity");
		NativeFieldInfoPtr_RenderingDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomTrack>.NativeClassPtr, "RenderingDistance");
		NativeFieldInfoPtr_DirectionalLightTemperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomTrack>.NativeClassPtr, "DirectionalLightTemperature");
		NativeFieldInfoPtr_DirectionalLightIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomTrack>.NativeClassPtr, "DirectionalLightIntensity");
		NativeFieldInfoPtr_DirectionalLightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomTrack>.NativeClassPtr, "DirectionalLightColor");
		NativeFieldInfoPtr_DirectionalLightAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomTrack>.NativeClassPtr, "DirectionalLightAngle");
		NativeFieldInfoPtr_SkyboxFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomTrack>.NativeClassPtr, "SkyboxFile");
		NativeFieldInfoPtr_DisablePostProcessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomTrack>.NativeClassPtr, "DisablePostProcessing");
		NativeFieldInfoPtr_EnableGlobalDensityVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomTrack>.NativeClassPtr, "EnableGlobalDensityVolume");
		NativeFieldInfoPtr_DensityVolumeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomTrack>.NativeClassPtr, "DensityVolumeColor");
		NativeFieldInfoPtr_DensityVolumeFogDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomTrack>.NativeClassPtr, "DensityVolumeFogDistance");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomTrack>.NativeClassPtr, 100679764);
	}

	public CustomTrack(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
