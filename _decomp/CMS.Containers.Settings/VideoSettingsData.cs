using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Containers.Settings;

[StructLayout(LayoutKind.Explicit)]
public struct VideoSettingsData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Quality;

	private static readonly System.IntPtr NativeFieldInfoPtr_ScreenResolutionX;

	private static readonly System.IntPtr NativeFieldInfoPtr_ScreenResolutionY;

	private static readonly System.IntPtr NativeFieldInfoPtr_FullscreenMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_VSync;

	private static readonly System.IntPtr NativeFieldInfoPtr_Antialiasing;

	private static readonly System.IntPtr NativeFieldInfoPtr_Bloom;

	private static readonly System.IntPtr NativeFieldInfoPtr_SSR;

	private static readonly System.IntPtr NativeFieldInfoPtr_SSAO;

	private static readonly System.IntPtr NativeFieldInfoPtr_MotionBlur;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChromaticAberration;

	private static readonly System.IntPtr NativeFieldInfoPtr_Vignette;

	private static readonly System.IntPtr NativeFieldInfoPtr_VolumetricLighting;

	private static readonly System.IntPtr NativeFieldInfoPtr_SubsurfaceScattering;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShadowMapResolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_MeshDetails;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShadowDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_TextureQuality;

	private static readonly System.IntPtr NativeFieldInfoPtr_VegetationDetails;

	private static readonly System.IntPtr NativeFieldInfoPtr_ContactShadows;

	private static readonly System.IntPtr NativeFieldInfoPtr_CloudShadows;

	private static readonly System.IntPtr NativeFieldInfoPtr_HeatHaze;

	private static readonly System.IntPtr NativeFieldInfoPtr_FpsCap;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultSettings_Public_Static_get_VideoSettingsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Low_Public_Static_get_VideoSettingsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Medium_Public_Static_get_VideoSettingsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_High_Public_Static_get_VideoSettingsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Ultra_Public_Static_get_VideoSettingsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Playstation_Public_Static_get_VideoSettingsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlaystationPro_Public_Static_get_VideoSettingsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Playstation5_Public_Static_get_VideoSettingsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Xbox_Public_Static_get_VideoSettingsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_XboxX_Public_Static_get_VideoSettingsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_XboxSeriesS_Public_Static_get_VideoSettingsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_XboxSeriesX_Public_Static_get_VideoSettingsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPresetForQuality_Public_Static_VideoSettingsData_GraphicsQuality_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

	[FieldOffset(0)]
	public GraphicsQuality Quality;

	[FieldOffset(4)]
	public int ScreenResolutionX;

	[FieldOffset(8)]
	public int ScreenResolutionY;

	[FieldOffset(12)]
	public FullscreenMode FullscreenMode;

	[FieldOffset(16)]
	public bool VSync;

	[FieldOffset(20)]
	public int Antialiasing;

	[FieldOffset(24)]
	public bool Bloom;

	[FieldOffset(25)]
	public bool SSR;

	[FieldOffset(26)]
	public bool SSAO;

	[FieldOffset(27)]
	public bool MotionBlur;

	[FieldOffset(28)]
	public bool ChromaticAberration;

	[FieldOffset(29)]
	public bool Vignette;

	[FieldOffset(30)]
	public bool VolumetricLighting;

	[FieldOffset(31)]
	public bool SubsurfaceScattering;

	[FieldOffset(32)]
	public int ShadowMapResolution;

	[FieldOffset(36)]
	public int MeshDetails;

	[FieldOffset(40)]
	public int ShadowDistance;

	[FieldOffset(44)]
	public int TextureQuality;

	[FieldOffset(48)]
	public int VegetationDetails;

	[FieldOffset(52)]
	public bool ContactShadows;

	[FieldOffset(53)]
	public bool CloudShadows;

	[FieldOffset(54)]
	public bool HeatHaze;

	[FieldOffset(56)]
	public int FpsCap;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr));

	public unsafe static VideoSettingsData DefaultSettings
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218466, XrefRangeEnd = 218467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DefaultSettings_Public_Static_get_VideoSettingsData_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(VideoSettingsData*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe static VideoSettingsData Low
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218467, XrefRangeEnd = 218481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Low_Public_Static_get_VideoSettingsData_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(VideoSettingsData*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe static VideoSettingsData Medium
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218481, XrefRangeEnd = 218495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Medium_Public_Static_get_VideoSettingsData_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(VideoSettingsData*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe static VideoSettingsData High
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 218509, RefRangeEnd = 218514, XrefRangeStart = 218495, XrefRangeEnd = 218509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_High_Public_Static_get_VideoSettingsData_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(VideoSettingsData*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe static VideoSettingsData Ultra
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218514, XrefRangeEnd = 218528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Ultra_Public_Static_get_VideoSettingsData_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(VideoSettingsData*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe static VideoSettingsData Playstation
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Playstation_Public_Static_get_VideoSettingsData_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(VideoSettingsData*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe static VideoSettingsData PlaystationPro
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlaystationPro_Public_Static_get_VideoSettingsData_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(VideoSettingsData*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe static VideoSettingsData Playstation5
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Playstation5_Public_Static_get_VideoSettingsData_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(VideoSettingsData*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe static VideoSettingsData Xbox
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Xbox_Public_Static_get_VideoSettingsData_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(VideoSettingsData*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe static VideoSettingsData XboxX
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_XboxX_Public_Static_get_VideoSettingsData_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(VideoSettingsData*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe static VideoSettingsData XboxSeriesS
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_XboxSeriesS_Public_Static_get_VideoSettingsData_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(VideoSettingsData*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe static VideoSettingsData XboxSeriesX
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_XboxSeriesX_Public_Static_get_VideoSettingsData_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(VideoSettingsData*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 218542, RefRangeEnd = 218559, XrefRangeStart = 218528, XrefRangeEnd = 218542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static VideoSettingsData GetPresetForQuality(GraphicsQuality quality)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&quality);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPresetForQuality_Public_Static_VideoSettingsData_GraphicsQuality_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(VideoSettingsData*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218559, XrefRangeEnd = 218560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VideoSettingsData()
	{
		Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers.Settings", "VideoSettingsData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr);
		NativeFieldInfoPtr_Quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, "Quality");
		NativeFieldInfoPtr_ScreenResolutionX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, "ScreenResolutionX");
		NativeFieldInfoPtr_ScreenResolutionY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, "ScreenResolutionY");
		NativeFieldInfoPtr_FullscreenMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, "FullscreenMode");
		NativeFieldInfoPtr_VSync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, "VSync");
		NativeFieldInfoPtr_Antialiasing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, "Antialiasing");
		NativeFieldInfoPtr_Bloom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, "Bloom");
		NativeFieldInfoPtr_SSR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, "SSR");
		NativeFieldInfoPtr_SSAO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, "SSAO");
		NativeFieldInfoPtr_MotionBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, "MotionBlur");
		NativeFieldInfoPtr_ChromaticAberration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, "ChromaticAberration");
		NativeFieldInfoPtr_Vignette = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, "Vignette");
		NativeFieldInfoPtr_VolumetricLighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, "VolumetricLighting");
		NativeFieldInfoPtr_SubsurfaceScattering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, "SubsurfaceScattering");
		NativeFieldInfoPtr_ShadowMapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, "ShadowMapResolution");
		NativeFieldInfoPtr_MeshDetails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, "MeshDetails");
		NativeFieldInfoPtr_ShadowDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, "ShadowDistance");
		NativeFieldInfoPtr_TextureQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, "TextureQuality");
		NativeFieldInfoPtr_VegetationDetails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, "VegetationDetails");
		NativeFieldInfoPtr_ContactShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, "ContactShadows");
		NativeFieldInfoPtr_CloudShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, "CloudShadows");
		NativeFieldInfoPtr_HeatHaze = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, "HeatHaze");
		NativeFieldInfoPtr_FpsCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, "FpsCap");
		NativeMethodInfoPtr_get_DefaultSettings_Public_Static_get_VideoSettingsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, 100679818);
		NativeMethodInfoPtr_get_Low_Public_Static_get_VideoSettingsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, 100679819);
		NativeMethodInfoPtr_get_Medium_Public_Static_get_VideoSettingsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, 100679820);
		NativeMethodInfoPtr_get_High_Public_Static_get_VideoSettingsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, 100679821);
		NativeMethodInfoPtr_get_Ultra_Public_Static_get_VideoSettingsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, 100679822);
		NativeMethodInfoPtr_get_Playstation_Public_Static_get_VideoSettingsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, 100679823);
		NativeMethodInfoPtr_get_PlaystationPro_Public_Static_get_VideoSettingsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, 100679824);
		NativeMethodInfoPtr_get_Playstation5_Public_Static_get_VideoSettingsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, 100679825);
		NativeMethodInfoPtr_get_Xbox_Public_Static_get_VideoSettingsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, 100679826);
		NativeMethodInfoPtr_get_XboxX_Public_Static_get_VideoSettingsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, 100679827);
		NativeMethodInfoPtr_get_XboxSeriesS_Public_Static_get_VideoSettingsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, 100679828);
		NativeMethodInfoPtr_get_XboxSeriesX_Public_Static_get_VideoSettingsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, 100679829);
		NativeMethodInfoPtr_GetPresetForQuality_Public_Static_VideoSettingsData_GraphicsQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, 100679830);
		NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, 100679831);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VideoSettingsData>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
