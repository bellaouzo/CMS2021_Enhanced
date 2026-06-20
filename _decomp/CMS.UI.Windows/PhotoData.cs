using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace CMS.UI.Windows;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct PhotoData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Height;

	private static readonly System.IntPtr NativeFieldInfoPtr_Exposition;

	private static readonly System.IntPtr NativeFieldInfoPtr_Fov;

	private static readonly System.IntPtr NativeFieldInfoPtr_Aperture;

	private static readonly System.IntPtr NativeFieldInfoPtr_DofLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_Tilt;

	private static readonly System.IntPtr NativeFieldInfoPtr_FocalPoint;

	[FieldOffset(0)]
	public float Height;

	[FieldOffset(4)]
	public float Exposition;

	[FieldOffset(8)]
	public float Fov;

	[FieldOffset(12)]
	public float Aperture;

	[FieldOffset(16)]
	public float DofLength;

	[FieldOffset(20)]
	public float Tilt;

	[FieldOffset(24)]
	public float FocalPoint;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PhotoData>.NativeClassPtr));

	static PhotoData()
	{
		Il2CppClassPointerStore<PhotoData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Windows", "PhotoData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhotoData>.NativeClassPtr);
		NativeFieldInfoPtr_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoData>.NativeClassPtr, "Height");
		NativeFieldInfoPtr_Exposition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoData>.NativeClassPtr, "Exposition");
		NativeFieldInfoPtr_Fov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoData>.NativeClassPtr, "Fov");
		NativeFieldInfoPtr_Aperture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoData>.NativeClassPtr, "Aperture");
		NativeFieldInfoPtr_DofLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoData>.NativeClassPtr, "DofLength");
		NativeFieldInfoPtr_Tilt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoData>.NativeClassPtr, "Tilt");
		NativeFieldInfoPtr_FocalPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoData>.NativeClassPtr, "FocalPoint");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PhotoData>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
