using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Job : Il2CppSystem.Object
{
	[ObfuscatedName("Job/<Timer>d__51")]
	public sealed class _Timer_d__51 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr_seconds;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr__i_5__2;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_Timer_d__51>.NativeClassPtr));

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
			}
		}

		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe float seconds
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seconds);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seconds)) = num;
			}
		}

		public unsafe Job __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Job(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe float _i_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__i_5__2);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__i_5__2)) = num;
			}
		}

		public unsafe Il2CppSystem.Object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
			}
		}

		public unsafe Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
			}
		}

		[CallerCount(0)]
		public unsafe _Timer_d__51(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_Timer_d__51>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&_003C_003E1__state);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93099, XrefRangeEnd = 93110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93110, XrefRangeEnd = 93119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _Timer_d__51()
		{
			Il2CppClassPointerStore<_Timer_d__51>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Job>.NativeClassPtr, "<Timer>d__51");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_Timer_d__51>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Timer_d__51>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Timer_d__51>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr_seconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Timer_d__51>.NativeClassPtr, "seconds");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Timer_d__51>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Timer_d__51>.NativeClassPtr, "<i>5__2");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Timer_d__51>.NativeClassPtr, 100668646);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Timer_d__51>.NativeClassPtr, 100668647);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Timer_d__51>.NativeClassPtr, 100668648);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Timer_d__51>.NativeClassPtr, 100668649);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Timer_d__51>.NativeClassPtr, 100668650);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Timer_d__51>.NativeClassPtr, 100668651);
		}

		public _Timer_d__51(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_id;

	private static readonly System.IntPtr NativeFieldInfoPtr_carLoaderID;

	private static readonly System.IntPtr NativeFieldInfoPtr_forXP;

	private static readonly System.IntPtr NativeFieldInfoPtr_carFile;

	private static readonly System.IntPtr NativeFieldInfoPtr_configVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeToEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_PaintType;

	private static readonly System.IntPtr NativeFieldInfoPtr_carColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_carFactoryColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_carFactoryPaintType;

	private static readonly System.IntPtr NativeFieldInfoPtr_Mileage;

	private static readonly System.IntPtr NativeFieldInfoPtr_oilLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_jobType;

	private static readonly System.IntPtr NativeFieldInfoPtr_jobTasks;

	private static readonly System.IntPtr NativeFieldInfoPtr_jobPartsCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_globalCondition;

	private static readonly System.IntPtr NativeFieldInfoPtr_otherPartsCondition;

	private static readonly System.IntPtr NativeFieldInfoPtr_BonusToExp;

	private static readonly System.IntPtr NativeFieldInfoPtr_BonusToMoney;

	private static readonly System.IntPtr NativeFieldInfoPtr_LocalizationID;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsMission;

	private static readonly System.IntPtr NativeFieldInfoPtr_MissionID;

	private static readonly System.IntPtr NativeFieldInfoPtr_CanDelete;

	private static readonly System.IntPtr NativeFieldInfoPtr_TaskBonus;

	private static readonly System.IntPtr NativeFieldInfoPtr_JobBonus;

	private static readonly System.IntPtr NativeFieldInfoPtr_TotalPayout;

	private static readonly System.IntPtr NativeFieldInfoPtr_MoneySpent;

	private static readonly System.IntPtr NativeFieldInfoPtr_MoneySpentWithDifficultyMod;

	private static readonly System.IntPtr NativeFieldInfoPtr_XP;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsCompleted;

	private static readonly System.IntPtr NativeFieldInfoPtr_IconTypeEngine;

	private static readonly System.IntPtr NativeFieldInfoPtr_IconTypeTiming;

	private static readonly System.IntPtr NativeFieldInfoPtr_IconTypeSuspension;

	private static readonly System.IntPtr NativeFieldInfoPtr_IconTypeBrakes;

	private static readonly System.IntPtr NativeFieldInfoPtr_IconTypeExhaust;

	private static readonly System.IntPtr NativeFieldInfoPtr_IconTypeGearbox;

	private static readonly System.IntPtr NativeFieldInfoPtr_IconTypeOil;

	private static readonly System.IntPtr NativeFieldInfoPtr_IconTypeBody;

	private static readonly System.IntPtr NativeFieldInfoPtr_IconTypeTuning;

	private static readonly System.IntPtr NativeFieldInfoPtr_timerCoroutine;

	private static readonly System.IntPtr NativeFieldInfoPtr_haveToStopTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_canUpdateText;

	private static readonly System.IntPtr NativeFieldInfoPtr_timerText;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveOnPartList_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveSubtype_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartTimer_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopTimer_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTimerText_Public_Void_Text_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearTimerText_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTimerText_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTimerTextIfCan_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Timer_Public_IEnumerator_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Job>.NativeClassPtr));

	public unsafe int id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
		}
	}

	public unsafe int carLoaderID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carLoaderID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carLoaderID)) = num;
		}
	}

	public unsafe int forXP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forXP);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forXP)) = num;
		}
	}

	public unsafe string carFile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carFile);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carFile), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe int configVersion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_configVersion);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_configVersion)) = num;
		}
	}

	public unsafe float timeToEnd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeToEnd);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeToEnd)) = num;
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

	public unsafe Color carColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carColor)) = color;
		}
	}

	public unsafe Color carFactoryColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carFactoryColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carFactoryColor)) = color;
		}
	}

	public unsafe PaintType carFactoryPaintType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carFactoryPaintType);
			return *(PaintType*)num;
		}
		set
		{
			*(PaintType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carFactoryPaintType)) = paintType;
		}
	}

	public unsafe int Mileage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Mileage);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Mileage)) = num;
		}
	}

	public unsafe float oilLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oilLevel);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oilLevel)) = num;
		}
	}

	public unsafe Il2CppStructArray<bool> jobType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<bool>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobType), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<JobTask> jobTasks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobTasks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<JobTask>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobTasks), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int jobPartsCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobPartsCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobPartsCount)) = num;
		}
	}

	public unsafe float globalCondition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_globalCondition);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_globalCondition)) = num;
		}
	}

	public unsafe float otherPartsCondition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_otherPartsCondition);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_otherPartsCondition)) = num;
		}
	}

	public unsafe bool BonusToExp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BonusToExp);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BonusToExp)) = flag;
		}
	}

	public unsafe bool BonusToMoney
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BonusToMoney);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BonusToMoney)) = flag;
		}
	}

	public unsafe string LocalizationID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LocalizationID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LocalizationID), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe bool IsMission
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsMission);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsMission)) = flag;
		}
	}

	public unsafe int MissionID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionID)) = num;
		}
	}

	public unsafe bool CanDelete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanDelete);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanDelete)) = flag;
		}
	}

	public unsafe int TaskBonus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TaskBonus);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TaskBonus)) = num;
		}
	}

	public unsafe int JobBonus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JobBonus);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JobBonus)) = num;
		}
	}

	public unsafe int TotalPayout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TotalPayout);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TotalPayout)) = num;
		}
	}

	public unsafe int MoneySpent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoneySpent);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoneySpent)) = num;
		}
	}

	public unsafe int MoneySpentWithDifficultyMod
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoneySpentWithDifficultyMod);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoneySpentWithDifficultyMod)) = num;
		}
	}

	public unsafe int XP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_XP);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_XP)) = num;
		}
	}

	public unsafe bool IsCompleted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsCompleted);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsCompleted)) = flag;
		}
	}

	public unsafe bool IconTypeEngine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeEngine);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeEngine)) = flag;
		}
	}

	public unsafe bool IconTypeTiming
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeTiming);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeTiming)) = flag;
		}
	}

	public unsafe bool IconTypeSuspension
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeSuspension);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeSuspension)) = flag;
		}
	}

	public unsafe bool IconTypeBrakes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeBrakes);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeBrakes)) = flag;
		}
	}

	public unsafe bool IconTypeExhaust
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeExhaust);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeExhaust)) = flag;
		}
	}

	public unsafe bool IconTypeGearbox
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeGearbox);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeGearbox)) = flag;
		}
	}

	public unsafe bool IconTypeOil
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeOil);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeOil)) = flag;
		}
	}

	public unsafe bool IconTypeBody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeBody);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeBody)) = flag;
		}
	}

	public unsafe bool IconTypeTuning
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeTuning);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IconTypeTuning)) = flag;
		}
	}

	public unsafe Coroutine timerCoroutine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timerCoroutine);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Coroutine(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timerCoroutine), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool haveToStopTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_haveToStopTimer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_haveToStopTimer)) = flag;
		}
	}

	public unsafe bool canUpdateText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canUpdateText);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canUpdateText)) = flag;
		}
	}

	public unsafe Text timerText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timerText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timerText), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 93123, RefRangeEnd = 93131, XrefRangeStart = 93119, XrefRangeEnd = 93123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HaveOnPartList(string jobPartID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(jobPartID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveOnPartList_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 93132, RefRangeEnd = 93134, XrefRangeStart = 93131, XrefRangeEnd = 93132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HaveSubtype(string jobSubTypeId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(jobSubTypeId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HaveSubtype_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 93145, RefRangeEnd = 93147, XrefRangeStart = 93134, XrefRangeEnd = 93145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartTimer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartTimer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 93152, RefRangeEnd = 93154, XrefRangeStart = 93147, XrefRangeEnd = 93152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopTimer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopTimer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 93172, RefRangeEnd = 93174, XrefRangeStart = 93154, XrefRangeEnd = 93172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTimerText(Text text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTimerText_Public_Void_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 93174, RefRangeEnd = 93176, XrefRangeStart = 93174, XrefRangeEnd = 93174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearTimerText()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearTimerText_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 93193, RefRangeEnd = 93195, XrefRangeStart = 93176, XrefRangeEnd = 93193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateTimerText(float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateTimerText_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93195, XrefRangeEnd = 93196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateTimerTextIfCan(float i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateTimerTextIfCan_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93196, XrefRangeEnd = 93199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator Timer(float seconds)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&seconds);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Timer_Public_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 93204, RefRangeEnd = 93208, XrefRangeStart = 93199, XrefRangeEnd = 93204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Job()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Job>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Job()
	{
		Il2CppClassPointerStore<Job>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "Job");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Job>.NativeClassPtr);
		NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "id");
		NativeFieldInfoPtr_carLoaderID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "carLoaderID");
		NativeFieldInfoPtr_forXP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "forXP");
		NativeFieldInfoPtr_carFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "carFile");
		NativeFieldInfoPtr_configVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "configVersion");
		NativeFieldInfoPtr_timeToEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "timeToEnd");
		NativeFieldInfoPtr_PaintType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "PaintType");
		NativeFieldInfoPtr_carColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "carColor");
		NativeFieldInfoPtr_carFactoryColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "carFactoryColor");
		NativeFieldInfoPtr_carFactoryPaintType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "carFactoryPaintType");
		NativeFieldInfoPtr_Mileage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "Mileage");
		NativeFieldInfoPtr_oilLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "oilLevel");
		NativeFieldInfoPtr_jobType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "jobType");
		NativeFieldInfoPtr_jobTasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "jobTasks");
		NativeFieldInfoPtr_jobPartsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "jobPartsCount");
		NativeFieldInfoPtr_globalCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "globalCondition");
		NativeFieldInfoPtr_otherPartsCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "otherPartsCondition");
		NativeFieldInfoPtr_BonusToExp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "BonusToExp");
		NativeFieldInfoPtr_BonusToMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "BonusToMoney");
		NativeFieldInfoPtr_LocalizationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "LocalizationID");
		NativeFieldInfoPtr_IsMission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "IsMission");
		NativeFieldInfoPtr_MissionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "MissionID");
		NativeFieldInfoPtr_CanDelete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "CanDelete");
		NativeFieldInfoPtr_TaskBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "TaskBonus");
		NativeFieldInfoPtr_JobBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "JobBonus");
		NativeFieldInfoPtr_TotalPayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "TotalPayout");
		NativeFieldInfoPtr_MoneySpent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "MoneySpent");
		NativeFieldInfoPtr_MoneySpentWithDifficultyMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "MoneySpentWithDifficultyMod");
		NativeFieldInfoPtr_XP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "XP");
		NativeFieldInfoPtr_IsCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "IsCompleted");
		NativeFieldInfoPtr_IconTypeEngine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "IconTypeEngine");
		NativeFieldInfoPtr_IconTypeTiming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "IconTypeTiming");
		NativeFieldInfoPtr_IconTypeSuspension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "IconTypeSuspension");
		NativeFieldInfoPtr_IconTypeBrakes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "IconTypeBrakes");
		NativeFieldInfoPtr_IconTypeExhaust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "IconTypeExhaust");
		NativeFieldInfoPtr_IconTypeGearbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "IconTypeGearbox");
		NativeFieldInfoPtr_IconTypeOil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "IconTypeOil");
		NativeFieldInfoPtr_IconTypeBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "IconTypeBody");
		NativeFieldInfoPtr_IconTypeTuning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "IconTypeTuning");
		NativeFieldInfoPtr_timerCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "timerCoroutine");
		NativeFieldInfoPtr_haveToStopTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "haveToStopTimer");
		NativeFieldInfoPtr_canUpdateText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "canUpdateText");
		NativeFieldInfoPtr_timerText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Job>.NativeClassPtr, "timerText");
		NativeMethodInfoPtr_HaveOnPartList_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Job>.NativeClassPtr, 100668636);
		NativeMethodInfoPtr_HaveSubtype_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Job>.NativeClassPtr, 100668637);
		NativeMethodInfoPtr_StartTimer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Job>.NativeClassPtr, 100668638);
		NativeMethodInfoPtr_StopTimer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Job>.NativeClassPtr, 100668639);
		NativeMethodInfoPtr_SetTimerText_Public_Void_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Job>.NativeClassPtr, 100668640);
		NativeMethodInfoPtr_ClearTimerText_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Job>.NativeClassPtr, 100668641);
		NativeMethodInfoPtr_UpdateTimerText_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Job>.NativeClassPtr, 100668642);
		NativeMethodInfoPtr_UpdateTimerTextIfCan_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Job>.NativeClassPtr, 100668643);
		NativeMethodInfoPtr_Timer_Public_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Job>.NativeClassPtr, 100668644);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Job>.NativeClassPtr, 100668645);
	}

	public Job(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
