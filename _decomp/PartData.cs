using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CMS.Containers;
using Il2CppSystem;
using Il2CppSystem.IO;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class PartData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Path;

	private static readonly System.IntPtr NativeFieldInfoPtr_Examined;

	private static readonly System.IntPtr NativeFieldInfoPtr_Condition;

	private static readonly System.IntPtr NativeFieldInfoPtr_Unmounted;

	private static readonly System.IntPtr NativeFieldInfoPtr_Quality;

	private static readonly System.IntPtr NativeFieldInfoPtr_TunedID;

	private static readonly System.IntPtr NativeFieldInfoPtr_Color;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsPainted;

	private static readonly System.IntPtr NativeFieldInfoPtr_PaintType;

	private static readonly System.IntPtr NativeFieldInfoPtr_PaintData;

	private static readonly System.IntPtr NativeFieldInfoPtr_MountObjectData;

	private static readonly System.IntPtr NativeFieldInfoPtr_Dust;

	private static readonly System.IntPtr NativeFieldInfoPtr_TuningData;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_PartScript_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NeedToSaveColor_Private_Boolean_byref_FloatArrayWrapper_Int32_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PartData>.NativeClassPtr));

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

	public unsafe bool Examined
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Examined);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Examined)) = flag;
		}
	}

	public unsafe float Condition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Condition);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Condition)) = num;
		}
	}

	public unsafe bool Unmounted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Unmounted);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Unmounted)) = flag;
		}
	}

	public unsafe int Quality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Quality);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Quality)) = num;
		}
	}

	public unsafe string TunedID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TunedID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TunedID), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe FloatArrayWrapper Color
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Color);
			return new FloatArrayWrapper(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FloatArrayWrapper>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Color), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FloatArrayWrapper>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe bool IsPainted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsPainted);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsPainted)) = flag;
		}
	}

	public unsafe PaintType PaintType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PaintType);
			return *(PaintType*)num;
		}
		set
		{
			*(PaintType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PaintType)) = paintType;
		}
	}

	public unsafe PaintData PaintData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PaintData);
			return *(PaintData*)num;
		}
		set
		{
			*(PaintData*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PaintData)) = paintData;
		}
	}

	public unsafe MountObjectData MountObjectData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MountObjectData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new MountObjectData(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MountObjectData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float Dust
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Dust);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Dust)) = num;
		}
	}

	public unsafe TuningData TuningData
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TuningData);
			return new TuningData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TuningData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TuningData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TuningData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 94077, RefRangeEnd = 94078, XrefRangeStart = 94065, XrefRangeEnd = 94077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PartData(PartScript partScript)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(partScript);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_PartScript_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 94098, RefRangeEnd = 94099, XrefRangeStart = 94078, XrefRangeEnd = 94098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Serialize(BinaryWriter binaryWriter, byte saveVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveVersion;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 94119, RefRangeEnd = 94120, XrefRangeStart = 94099, XrefRangeEnd = 94119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Deserialize(BinaryReader binaryReader, byte saveVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveVersion;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94120, XrefRangeEnd = 94121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool NeedToSaveColor(ref FloatArrayWrapper colorWrapper, int defaultColorValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(colorWrapper);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultColorValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NeedToSaveColor_Private_Boolean_byref_FloatArrayWrapper_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static PartData()
	{
		Il2CppClassPointerStore<PartData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "PartData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartData>.NativeClassPtr);
		NativeFieldInfoPtr_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartData>.NativeClassPtr, "Path");
		NativeFieldInfoPtr_Examined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartData>.NativeClassPtr, "Examined");
		NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartData>.NativeClassPtr, "Condition");
		NativeFieldInfoPtr_Unmounted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartData>.NativeClassPtr, "Unmounted");
		NativeFieldInfoPtr_Quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartData>.NativeClassPtr, "Quality");
		NativeFieldInfoPtr_TunedID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartData>.NativeClassPtr, "TunedID");
		NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartData>.NativeClassPtr, "Color");
		NativeFieldInfoPtr_IsPainted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartData>.NativeClassPtr, "IsPainted");
		NativeFieldInfoPtr_PaintType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartData>.NativeClassPtr, "PaintType");
		NativeFieldInfoPtr_PaintData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartData>.NativeClassPtr, "PaintData");
		NativeFieldInfoPtr_MountObjectData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartData>.NativeClassPtr, "MountObjectData");
		NativeFieldInfoPtr_Dust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartData>.NativeClassPtr, "Dust");
		NativeFieldInfoPtr_TuningData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartData>.NativeClassPtr, "TuningData");
		NativeMethodInfoPtr__ctor_Public_Void_PartScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartData>.NativeClassPtr, 100668733);
		NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartData>.NativeClassPtr, 100668734);
		NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartData>.NativeClassPtr, 100668735);
		NativeMethodInfoPtr_NeedToSaveColor_Private_Boolean_byref_FloatArrayWrapper_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartData>.NativeClassPtr, 100668736);
	}

	public PartData(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe PartData()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PartData>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<PartData>.NativeClassPtr))
	{
	}
}
