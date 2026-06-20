using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.IO;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct ToolsData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_WelderIsConnected;

	private static readonly System.IntPtr NativeFieldInfoPtr_InteriorDetailingToolkitIsConnected;

	private static readonly System.IntPtr NativeFieldInfoPtr_OilbinIsConnected;

	private static readonly System.IntPtr NativeFieldInfoPtr_EngineCraneIsConnected;

	private static readonly System.IntPtr NativeFieldInfoPtr_HeadlampAlignmentSystemIsConnected;

	private static readonly System.IntPtr NativeFieldInfoPtr_WindowTintingToolkitIsConnected;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_Byte_0;

	[FieldOffset(0)]
	public bool WelderIsConnected;

	[FieldOffset(1)]
	public bool InteriorDetailingToolkitIsConnected;

	[FieldOffset(2)]
	public bool OilbinIsConnected;

	[FieldOffset(3)]
	public bool EngineCraneIsConnected;

	[FieldOffset(4)]
	public bool HeadlampAlignmentSystemIsConnected;

	[FieldOffset(5)]
	public bool WindowTintingToolkitIsConnected;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ToolsData>.NativeClassPtr));

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 94546, RefRangeEnd = 94547, XrefRangeStart = 94544, XrefRangeEnd = 94546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Serialize(BinaryWriter binaryWriter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 94547, RefRangeEnd = 94548, XrefRangeStart = 94547, XrefRangeEnd = 94547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Deserialize(BinaryReader binaryReader, byte saveVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveVersion;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_Byte_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ToolsData()
	{
		Il2CppClassPointerStore<ToolsData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "ToolsData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToolsData>.NativeClassPtr);
		NativeFieldInfoPtr_WelderIsConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolsData>.NativeClassPtr, "WelderIsConnected");
		NativeFieldInfoPtr_InteriorDetailingToolkitIsConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolsData>.NativeClassPtr, "InteriorDetailingToolkitIsConnected");
		NativeFieldInfoPtr_OilbinIsConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolsData>.NativeClassPtr, "OilbinIsConnected");
		NativeFieldInfoPtr_EngineCraneIsConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolsData>.NativeClassPtr, "EngineCraneIsConnected");
		NativeFieldInfoPtr_HeadlampAlignmentSystemIsConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolsData>.NativeClassPtr, "HeadlampAlignmentSystemIsConnected");
		NativeFieldInfoPtr_WindowTintingToolkitIsConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolsData>.NativeClassPtr, "WindowTintingToolkitIsConnected");
		NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolsData>.NativeClassPtr, 100668770);
		NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolsData>.NativeClassPtr, 100668771);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ToolsData>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
