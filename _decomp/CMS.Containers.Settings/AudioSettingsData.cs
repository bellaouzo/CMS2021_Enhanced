using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Containers.Settings;

[StructLayout(LayoutKind.Explicit)]
public struct AudioSettingsData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_GameVolume;

	private static readonly System.IntPtr NativeFieldInfoPtr_MusicVolume;

	private static readonly System.IntPtr NativeFieldInfoPtr_AmbientSound;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultGameVolume_Public_Static_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultMusicVolume_Public_Static_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultAmbientSound_Public_Static_Boolean_0;

	[FieldOffset(0)]
	public float GameVolume;

	[FieldOffset(4)]
	public float MusicVolume;

	[FieldOffset(8)]
	public bool AmbientSound;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AudioSettingsData>.NativeClassPtr));

	[CallerCount(0)]
	public unsafe void Init()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe static float GetDefaultGameVolume()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultGameVolume_Public_Static_Single_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float GetDefaultMusicVolume()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultMusicVolume_Public_Static_Single_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static bool GetDefaultAmbientSound()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultAmbientSound_Public_Static_Boolean_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static AudioSettingsData()
	{
		Il2CppClassPointerStore<AudioSettingsData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers.Settings", "AudioSettingsData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioSettingsData>.NativeClassPtr);
		NativeFieldInfoPtr_GameVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettingsData>.NativeClassPtr, "GameVolume");
		NativeFieldInfoPtr_MusicVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettingsData>.NativeClassPtr, "MusicVolume");
		NativeFieldInfoPtr_AmbientSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettingsData>.NativeClassPtr, "AmbientSound");
		NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsData>.NativeClassPtr, 100679813);
		NativeMethodInfoPtr_GetDefaultGameVolume_Public_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsData>.NativeClassPtr, 100679814);
		NativeMethodInfoPtr_GetDefaultMusicVolume_Public_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsData>.NativeClassPtr, 100679815);
		NativeMethodInfoPtr_GetDefaultAmbientSound_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsData>.NativeClassPtr, 100679816);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioSettingsData>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
