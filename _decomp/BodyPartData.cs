using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.IO;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class BodyPartData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Id;

	private static readonly System.IntPtr NativeFieldInfoPtr_Switched;

	private static readonly System.IntPtr NativeFieldInfoPtr_Condition;

	private static readonly System.IntPtr NativeFieldInfoPtr_Unmounted;

	private static readonly System.IntPtr NativeFieldInfoPtr_TunedID;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsTinted;

	private static readonly System.IntPtr NativeFieldInfoPtr_TintColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_Color;

	private static readonly System.IntPtr NativeFieldInfoPtr_PaintType;

	private static readonly System.IntPtr NativeFieldInfoPtr_PaintData;

	private static readonly System.IntPtr NativeFieldInfoPtr_Livery;

	private static readonly System.IntPtr NativeFieldInfoPtr_LiveryStrength;

	private static readonly System.IntPtr NativeFieldInfoPtr_OutsaidRustEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_Dent;

	private static readonly System.IntPtr NativeFieldInfoPtr_Quality;

	private static readonly System.IntPtr NativeFieldInfoPtr_Dust;

	private static readonly System.IntPtr NativeFieldInfoPtr_WashFactor;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CarPart_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BodyPartData>.NativeClassPtr));

	public unsafe string Id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Id);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Id), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe bool Switched
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Switched);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Switched)) = flag;
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

	public unsafe bool IsTinted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsTinted);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsTinted)) = flag;
		}
	}

	public unsafe FloatArrayWrapper TintColor
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TintColor);
			return new FloatArrayWrapper(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FloatArrayWrapper>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TintColor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FloatArrayWrapper>.NativeClassPtr, ref *(uint*)null));
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

	public unsafe int PaintType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PaintType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PaintType)) = num;
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

	public unsafe string Livery
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Livery);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Livery), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe float LiveryStrength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LiveryStrength);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LiveryStrength)) = num;
		}
	}

	public unsafe bool OutsaidRustEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutsaidRustEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OutsaidRustEnabled)) = flag;
		}
	}

	public unsafe float Dent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Dent);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Dent)) = num;
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

	public unsafe float WashFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WashFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WashFactor)) = num;
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 93436, RefRangeEnd = 93438, XrefRangeStart = 93431, XrefRangeEnd = 93436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BodyPartData(CarPart carPart)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carPart);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CarPart_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93445, RefRangeEnd = 93446, XrefRangeStart = 93438, XrefRangeEnd = 93445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Serialize(BinaryWriter binaryWriter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93454, RefRangeEnd = 93455, XrefRangeStart = 93446, XrefRangeEnd = 93454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Deserialize(BinaryReader binaryReader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static BodyPartData()
	{
		Il2CppClassPointerStore<BodyPartData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "BodyPartData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BodyPartData>.NativeClassPtr);
		NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPartData>.NativeClassPtr, "Id");
		NativeFieldInfoPtr_Switched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPartData>.NativeClassPtr, "Switched");
		NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPartData>.NativeClassPtr, "Condition");
		NativeFieldInfoPtr_Unmounted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPartData>.NativeClassPtr, "Unmounted");
		NativeFieldInfoPtr_TunedID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPartData>.NativeClassPtr, "TunedID");
		NativeFieldInfoPtr_IsTinted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPartData>.NativeClassPtr, "IsTinted");
		NativeFieldInfoPtr_TintColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPartData>.NativeClassPtr, "TintColor");
		NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPartData>.NativeClassPtr, "Color");
		NativeFieldInfoPtr_PaintType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPartData>.NativeClassPtr, "PaintType");
		NativeFieldInfoPtr_PaintData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPartData>.NativeClassPtr, "PaintData");
		NativeFieldInfoPtr_Livery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPartData>.NativeClassPtr, "Livery");
		NativeFieldInfoPtr_LiveryStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPartData>.NativeClassPtr, "LiveryStrength");
		NativeFieldInfoPtr_OutsaidRustEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPartData>.NativeClassPtr, "OutsaidRustEnabled");
		NativeFieldInfoPtr_Dent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPartData>.NativeClassPtr, "Dent");
		NativeFieldInfoPtr_Quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPartData>.NativeClassPtr, "Quality");
		NativeFieldInfoPtr_Dust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPartData>.NativeClassPtr, "Dust");
		NativeFieldInfoPtr_WashFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPartData>.NativeClassPtr, "WashFactor");
		NativeMethodInfoPtr__ctor_Public_Void_CarPart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodyPartData>.NativeClassPtr, 100668693);
		NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodyPartData>.NativeClassPtr, 100668694);
		NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodyPartData>.NativeClassPtr, 100668695);
	}

	public BodyPartData(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe BodyPartData()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BodyPartData>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<BodyPartData>.NativeClassPtr))
	{
	}
}
