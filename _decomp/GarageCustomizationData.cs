using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.IO;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class GarageCustomizationData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_MaterialIndexes;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentTexturePack;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GarageCustomizationData>.NativeClassPtr));

	public unsafe Il2CppStructArray<int> MaterialIndexes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaterialIndexes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<int>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaterialIndexes), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe string CurrentTexturePack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentTexturePack);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentTexturePack), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 64936, RefRangeEnd = 64937, XrefRangeStart = 64930, XrefRangeEnd = 64936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Serialize(BinaryWriter binaryWriter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 64940, RefRangeEnd = 64941, XrefRangeStart = 64937, XrefRangeEnd = 64940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Deserialize(BinaryReader binaryReader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static GarageCustomizationData()
	{
		Il2CppClassPointerStore<GarageCustomizationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GarageCustomizationData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GarageCustomizationData>.NativeClassPtr);
		NativeFieldInfoPtr_MaterialIndexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageCustomizationData>.NativeClassPtr, "MaterialIndexes");
		NativeFieldInfoPtr_CurrentTexturePack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GarageCustomizationData>.NativeClassPtr, "CurrentTexturePack");
		NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageCustomizationData>.NativeClassPtr, 100667240);
		NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GarageCustomizationData>.NativeClassPtr, 100667241);
	}

	public GarageCustomizationData(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe GarageCustomizationData()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GarageCustomizationData>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<GarageCustomizationData>.NativeClassPtr))
	{
	}
}
