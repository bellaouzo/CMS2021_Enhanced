using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[System.Serializable]
public class NewJobTaskWrapper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_subtype;

	private static readonly System.IntPtr NativeFieldInfoPtr_IncreaseTuneValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_partsCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_desc;

	private static readonly System.IntPtr NativeFieldInfoPtr_easyMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_moneySpent;

	private static readonly System.IntPtr NativeFieldInfoPtr_Parts;

	private static readonly System.IntPtr NativeFieldInfoPtr__done;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<NewJobTaskWrapper>.NativeClassPtr));

	public unsafe string type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string subtype
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subtype);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subtype), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe int IncreaseTuneValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IncreaseTuneValue);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IncreaseTuneValue)) = num;
		}
	}

	public unsafe int partsCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partsCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partsCount)) = num;
		}
	}

	public unsafe string desc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desc);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desc), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe bool easyMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_easyMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_easyMode)) = flag;
		}
	}

	public unsafe int moneySpent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moneySpent);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moneySpent)) = num;
		}
	}

	public unsafe List<NewJobPart> Parts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Parts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<NewJobPart>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Parts), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool _done
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__done);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__done)) = flag;
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 65377, RefRangeEnd = 65378, XrefRangeStart = 65372, XrefRangeEnd = 65377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Serialize(BinaryWriter binaryWriter)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 65395, RefRangeEnd = 65396, XrefRangeStart = 65378, XrefRangeEnd = 65395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Deserialize(BinaryReader binaryReader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 65398, RefRangeEnd = 65400, XrefRangeStart = 65396, XrefRangeEnd = 65398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NewJobTaskWrapper()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewJobTaskWrapper>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static NewJobTaskWrapper()
	{
		Il2CppClassPointerStore<NewJobTaskWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "NewJobTaskWrapper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewJobTaskWrapper>.NativeClassPtr);
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobTaskWrapper>.NativeClassPtr, "type");
		NativeFieldInfoPtr_subtype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobTaskWrapper>.NativeClassPtr, "subtype");
		NativeFieldInfoPtr_IncreaseTuneValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobTaskWrapper>.NativeClassPtr, "IncreaseTuneValue");
		NativeFieldInfoPtr_partsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobTaskWrapper>.NativeClassPtr, "partsCount");
		NativeFieldInfoPtr_desc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobTaskWrapper>.NativeClassPtr, "desc");
		NativeFieldInfoPtr_easyMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobTaskWrapper>.NativeClassPtr, "easyMode");
		NativeFieldInfoPtr_moneySpent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobTaskWrapper>.NativeClassPtr, "moneySpent");
		NativeFieldInfoPtr_Parts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobTaskWrapper>.NativeClassPtr, "Parts");
		NativeFieldInfoPtr__done = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobTaskWrapper>.NativeClassPtr, "_done");
		NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewJobTaskWrapper>.NativeClassPtr, 100667318);
		NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewJobTaskWrapper>.NativeClassPtr, 100667319);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewJobTaskWrapper>.NativeClassPtr, 100667320);
	}

	public NewJobTaskWrapper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
