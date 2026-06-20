using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[System.Serializable]
public class JobTask : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_subtype;

	private static readonly System.IntPtr NativeFieldInfoPtr_IncreaseTuneValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_partsCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_desc;

	private static readonly System.IntPtr NativeFieldInfoPtr_easyMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_moneySpent;

	private static readonly System.IntPtr NativeFieldInfoPtr_Parts;

	private static readonly System.IntPtr NativeFieldInfoPtr_Done;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<JobTask>.NativeClassPtr));

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

	public unsafe List<JobPart> Parts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Parts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<JobPart>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Parts), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool Done
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Done);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Done)) = flag;
		}
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 93210, RefRangeEnd = 93219, XrefRangeStart = 93208, XrefRangeEnd = 93210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe JobTask()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JobTask>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static JobTask()
	{
		Il2CppClassPointerStore<JobTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "JobTask");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobTask>.NativeClassPtr);
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobTask>.NativeClassPtr, "type");
		NativeFieldInfoPtr_subtype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobTask>.NativeClassPtr, "subtype");
		NativeFieldInfoPtr_IncreaseTuneValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobTask>.NativeClassPtr, "IncreaseTuneValue");
		NativeFieldInfoPtr_partsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobTask>.NativeClassPtr, "partsCount");
		NativeFieldInfoPtr_desc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobTask>.NativeClassPtr, "desc");
		NativeFieldInfoPtr_easyMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobTask>.NativeClassPtr, "easyMode");
		NativeFieldInfoPtr_moneySpent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobTask>.NativeClassPtr, "moneySpent");
		NativeFieldInfoPtr_Parts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobTask>.NativeClassPtr, "Parts");
		NativeFieldInfoPtr_Done = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobTask>.NativeClassPtr, "Done");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobTask>.NativeClassPtr, 100668652);
	}

	public JobTask(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
