using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[System.Serializable]
public class NewJobsData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_jobs;

	private static readonly System.IntPtr NativeFieldInfoPtr_selectedJobs;

	private static readonly System.IntPtr NativeFieldInfoPtr_nextOrderTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_orderTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_LastUId;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentMissionDone;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeJobsList_Private_Void_BinaryWriter_List_1_NewJobWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeJobsList_Private_Void_BinaryReader_byref_List_1_NewJobWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<NewJobsData>.NativeClassPtr));

	public unsafe List<NewJobWrapper> jobs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<NewJobWrapper>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobs), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<NewJobWrapper> selectedJobs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedJobs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<NewJobWrapper>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedJobs), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float nextOrderTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextOrderTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextOrderTime)) = num;
		}
	}

	public unsafe float orderTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderTimer)) = num;
		}
	}

	public unsafe int LastUId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastUId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastUId)) = num;
		}
	}

	public unsafe bool CurrentMissionDone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentMissionDone);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentMissionDone)) = flag;
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 65411, RefRangeEnd = 65412, XrefRangeStart = 65401, XrefRangeEnd = 65411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Serialize(BinaryWriter binaryWriter)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65412, XrefRangeEnd = 65414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Deserialize(BinaryReader binaryReader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65414, XrefRangeEnd = 65418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SerializeJobsList(BinaryWriter binaryWriter, List<NewJobWrapper> jobsList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(jobsList);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeJobsList_Private_Void_BinaryWriter_List_1_NewJobWrapper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 65433, RefRangeEnd = 65437, XrefRangeStart = 65418, XrefRangeEnd = 65433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeserializeJobsList(BinaryReader binaryReader, out List<NewJobWrapper> jobsList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(jobsList);
		*(System.IntPtr**)num = &intPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeserializeJobsList_Private_Void_BinaryReader_byref_List_1_NewJobWrapper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		jobsList = (List<NewJobWrapper>)(object)((intPtr3 == (System.IntPtr)0) ? null : new List<T>(intPtr3));
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 65447, RefRangeEnd = 65449, XrefRangeStart = 65437, XrefRangeEnd = 65447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NewJobsData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewJobsData>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static NewJobsData()
	{
		Il2CppClassPointerStore<NewJobsData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "NewJobsData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewJobsData>.NativeClassPtr);
		NativeFieldInfoPtr_jobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobsData>.NativeClassPtr, "jobs");
		NativeFieldInfoPtr_selectedJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobsData>.NativeClassPtr, "selectedJobs");
		NativeFieldInfoPtr_nextOrderTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobsData>.NativeClassPtr, "nextOrderTime");
		NativeFieldInfoPtr_orderTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobsData>.NativeClassPtr, "orderTimer");
		NativeFieldInfoPtr_LastUId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobsData>.NativeClassPtr, "LastUId");
		NativeFieldInfoPtr_CurrentMissionDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewJobsData>.NativeClassPtr, "CurrentMissionDone");
		NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewJobsData>.NativeClassPtr, 100667324);
		NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewJobsData>.NativeClassPtr, 100667325);
		NativeMethodInfoPtr_SerializeJobsList_Private_Void_BinaryWriter_List_1_NewJobWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewJobsData>.NativeClassPtr, 100667326);
		NativeMethodInfoPtr_DeserializeJobsList_Private_Void_BinaryReader_byref_List_1_NewJobWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewJobsData>.NativeClassPtr, 100667327);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewJobsData>.NativeClassPtr, 100667328);
	}

	public NewJobsData(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
