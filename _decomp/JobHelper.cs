using System;
using System.Runtime.CompilerServices;
using CMS.UI.Logic;
using CMS.UI.Logic.CarInfo;
using CMS.UI.Logic.Orders;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

public static class JobHelper : Il2CppSystem.Object
{
	[ObfuscatedName("JobHelper/<>c__DisplayClass5_0")]
	public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_partScript;

		private static readonly System.IntPtr NativeFieldInfoPtr_item;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__CheckJobPartAndGetItems_b__0_Internal_Void_Boolean_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr));

		public unsafe PartScript partScript
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partScript);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new PartScript(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partScript), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe CarInfoPart item
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_item);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new CarInfoPart(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass5_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public unsafe void _CheckJobPartAndGetItems_b__0(bool mark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&mark);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__CheckJobPartAndGetItems_b__0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass5_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JobHelper>.NativeClassPtr, "<>c__DisplayClass5_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr);
			NativeFieldInfoPtr_partScript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr, "partScript");
			NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr, "item");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr, 100666612);
			NativeMethodInfoPtr__CheckJobPartAndGetItems_b__0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr, 100666613);
		}

		public __c__DisplayClass5_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckJob_Public_Static_Void_CarLoader_byref_Job_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveTuningJob_Public_Static_Boolean_Job_byref_JobTask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsTuningTaskDone_Public_Static_Boolean_CarLoader_JobTask_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckJobTask_Public_Static_Void_CarLoader_byref_Job_byref_JobTask_byref_ArrayOf_PartScript_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcTuningPartsValue_Private_Static_Int32_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckJobPartAndGetItems_Public_Static_List_1_CarInfoPart_CarLoader_byref_Job_byref_JobTask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetXPFromDifficultyMod_Public_Static_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOrderIcons_Public_Static_OrderIconType_Job_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupIssues_Public_Static_Void_Job_ArrayOf_IIssueObject_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<JobHelper>.NativeClassPtr));

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 56187, RefRangeEnd = 56189, XrefRangeStart = 56177, XrefRangeEnd = 56187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckJob(CarLoader carLoader, ref Job job)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(job);
		*(System.IntPtr**)num = &intPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckJob_Public_Static_Void_CarLoader_byref_Job_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		job = ((intPtr3 == (System.IntPtr)0) ? null : new Job(intPtr3));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56199, RefRangeEnd = 56200, XrefRangeStart = 56189, XrefRangeEnd = 56199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HaveTuningJob(Job job, out JobTask jobTask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(job);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(jobTask);
		*(System.IntPtr**)num = &intPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveTuningJob_Public_Static_Boolean_Job_byref_JobTask_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr2 = intPtr;
		jobTask = ((intPtr2 == (System.IntPtr)0) ? null : new JobTask(intPtr2));
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56200, XrefRangeEnd = 56201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsTuningTaskDone(CarLoader carLoader, JobTask jobTask, out float tuningValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(jobTask);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref tuningValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsTuningTaskDone_Public_Static_Boolean_CarLoader_JobTask_byref_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56423, RefRangeEnd = 56424, XrefRangeStart = 56201, XrefRangeEnd = 56423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckJobTask(CarLoader carLoader, ref Job job, ref JobTask jobTask, ref Il2CppReferenceArray<PartScript> parts)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(job);
		*(System.IntPtr**)num = &intPtr;
		byte* num2 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(jobTask);
		*(System.IntPtr**)num2 = &intPtr2;
		byte* num3 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr(parts);
		*(System.IntPtr**)num3 = &intPtr3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckJobTask_Public_Static_Void_CarLoader_byref_Job_byref_JobTask_byref_ArrayOf_PartScript_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr5 = intPtr;
		job = ((intPtr5 == (System.IntPtr)0) ? null : new Job(intPtr5));
		System.IntPtr intPtr6 = intPtr2;
		jobTask = ((intPtr6 == (System.IntPtr)0) ? null : new JobTask(intPtr6));
		System.IntPtr intPtr7 = intPtr3;
		parts = (Il2CppReferenceArray<PartScript>)(object)((intPtr7 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<T>(intPtr7));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56429, RefRangeEnd = 56430, XrefRangeStart = 56424, XrefRangeEnd = 56429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CalcTuningPartsValue(CarLoader carLoader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcTuningPartsValue_Private_Static_Int32_CarLoader_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56700, RefRangeEnd = 56701, XrefRangeStart = 56430, XrefRangeEnd = 56700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<CarInfoPart> CheckJobPartAndGetItems(CarLoader carLoader, ref Job job, ref JobTask jobTask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(job);
		*(System.IntPtr**)num = &intPtr;
		byte* num2 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(jobTask);
		*(System.IntPtr**)num2 = &intPtr2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckJobPartAndGetItems_Public_Static_List_1_CarInfoPart_CarLoader_byref_Job_byref_JobTask_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr4 = intPtr;
		job = ((intPtr4 == (System.IntPtr)0) ? null : new Job(intPtr4));
		System.IntPtr intPtr5 = intPtr2;
		jobTask = ((intPtr5 == (System.IntPtr)0) ? null : new JobTask(intPtr5));
		return (intPtr3 != (System.IntPtr)0) ? new List<CarInfoPart>(intPtr3) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56701, RefRangeEnd = 56702, XrefRangeStart = 56701, XrefRangeEnd = 56701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetXPFromDifficultyMod(float difficultyMod)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&difficultyMod);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetXPFromDifficultyMod_Public_Static_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 56741, RefRangeEnd = 56744, XrefRangeStart = 56702, XrefRangeEnd = 56741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static OrderIconType GetOrderIcons(Job job)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(job);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOrderIcons_Public_Static_OrderIconType_Job_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(OrderIconType*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 56762, RefRangeEnd = 56764, XrefRangeStart = 56744, XrefRangeEnd = 56762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupIssues(Job job, Il2CppReferenceArray<IIssueObject> issueObjects)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(job);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(issueObjects);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupIssues_Public_Static_Void_Job_ArrayOf_IIssueObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static JobHelper()
	{
		Il2CppClassPointerStore<JobHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "JobHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobHelper>.NativeClassPtr);
		NativeMethodInfoPtr_CheckJob_Public_Static_Void_CarLoader_byref_Job_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHelper>.NativeClassPtr, 100666603);
		NativeMethodInfoPtr_HaveTuningJob_Public_Static_Boolean_Job_byref_JobTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHelper>.NativeClassPtr, 100666604);
		NativeMethodInfoPtr_IsTuningTaskDone_Public_Static_Boolean_CarLoader_JobTask_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHelper>.NativeClassPtr, 100666605);
		NativeMethodInfoPtr_CheckJobTask_Public_Static_Void_CarLoader_byref_Job_byref_JobTask_byref_ArrayOf_PartScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHelper>.NativeClassPtr, 100666606);
		NativeMethodInfoPtr_CalcTuningPartsValue_Private_Static_Int32_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHelper>.NativeClassPtr, 100666607);
		NativeMethodInfoPtr_CheckJobPartAndGetItems_Public_Static_List_1_CarInfoPart_CarLoader_byref_Job_byref_JobTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHelper>.NativeClassPtr, 100666608);
		NativeMethodInfoPtr_GetXPFromDifficultyMod_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHelper>.NativeClassPtr, 100666609);
		NativeMethodInfoPtr_GetOrderIcons_Public_Static_OrderIconType_Job_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHelper>.NativeClassPtr, 100666610);
		NativeMethodInfoPtr_SetupIssues_Public_Static_Void_Job_ArrayOf_IIssueObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHelper>.NativeClassPtr, 100666611);
	}

	public JobHelper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
