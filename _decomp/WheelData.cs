using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.IO;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct WheelData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_IsBalanced;

	private static readonly System.IntPtr NativeFieldInfoPtr_Size;

	private static readonly System.IntPtr NativeFieldInfoPtr_Width;

	private static readonly System.IntPtr NativeFieldInfoPtr_Profile;

	private static readonly System.IntPtr NativeFieldInfoPtr_ET;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0;

	[FieldOffset(0)]
	public bool IsBalanced;

	[FieldOffset(4)]
	public int Size;

	[FieldOffset(8)]
	public int Width;

	[FieldOffset(12)]
	public int Profile;

	[FieldOffset(16)]
	public int ET;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WheelData>.NativeClassPtr));

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93429, RefRangeEnd = 93430, XrefRangeStart = 93428, XrefRangeEnd = 93429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Serialize(BinaryWriter binaryWriter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93430, RefRangeEnd = 93431, XrefRangeStart = 93430, XrefRangeEnd = 93430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Deserialize(BinaryReader binaryReader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static WheelData()
	{
		Il2CppClassPointerStore<WheelData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "WheelData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WheelData>.NativeClassPtr);
		NativeFieldInfoPtr_IsBalanced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelData>.NativeClassPtr, "IsBalanced");
		NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelData>.NativeClassPtr, "Size");
		NativeFieldInfoPtr_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelData>.NativeClassPtr, "Width");
		NativeFieldInfoPtr_Profile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelData>.NativeClassPtr, "Profile");
		NativeFieldInfoPtr_ET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelData>.NativeClassPtr, "ET");
		NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelData>.NativeClassPtr, 100668691);
		NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelData>.NativeClassPtr, 100668692);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WheelData>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
