using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.IO;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class GearboxData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_GearRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_FinalDriveRatio;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GearboxData>.NativeClassPtr));

	public unsafe Il2CppStructArray<float> GearRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GearRatio);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<float>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GearRatio), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float FinalDriveRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FinalDriveRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FinalDriveRatio)) = num;
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 92872, RefRangeEnd = 92873, XrefRangeStart = 92868, XrefRangeEnd = 92872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Serialize(BinaryWriter binaryWriter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 92876, RefRangeEnd = 92877, XrefRangeStart = 92873, XrefRangeEnd = 92876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Deserialize(BinaryReader binaryReader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static GearboxData()
	{
		Il2CppClassPointerStore<GearboxData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GearboxData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GearboxData>.NativeClassPtr);
		NativeFieldInfoPtr_GearRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GearboxData>.NativeClassPtr, "GearRatio");
		NativeFieldInfoPtr_FinalDriveRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GearboxData>.NativeClassPtr, "FinalDriveRatio");
		NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GearboxData>.NativeClassPtr, 100668613);
		NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GearboxData>.NativeClassPtr, 100668614);
	}

	public GearboxData(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe GearboxData()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GearboxData>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<GearboxData>.NativeClassPtr))
	{
	}
}
