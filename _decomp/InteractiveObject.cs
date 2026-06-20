using System;
using System.Runtime.CompilerServices;
using CMS;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
	[System.Serializable]
	[ObfuscatedName("InteractiveObject/<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__25_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__25_0_Internal_Boolean_PartScript_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c>.NativeClassPtr));

		public unsafe static __c __9
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new __c(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Func<PartScript, bool> __9__25_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__25_0, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.Func<PartScript, bool>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__25_0, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public unsafe bool _Start_b__25_0(PartScript ps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ps);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Start_b__25_0_Internal_Boolean_PartScript_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__25_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__25_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666822);
			NativeMethodInfoPtr__Start_b__25_0_Internal_Boolean_PartScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666823);
		}

		public __c(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_id;

	private static readonly System.IntPtr NativeFieldInfoPtr_on;

	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_specialType;

	private static readonly System.IntPtr NativeFieldInfoPtr_ho;

	private static readonly System.IntPtr NativeFieldInfoPtr_mouseOver;

	private static readonly System.IntPtr NativeFieldInfoPtr_distanceMod;

	private static readonly System.IntPtr NativeFieldInfoPtr_dummyIO;

	private static readonly System.IntPtr NativeFieldInfoPtr_hh;

	private static readonly System.IntPtr NativeFieldInfoPtr_replacedShader;

	private static readonly System.IntPtr NativeFieldInfoPtr_highlightColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_unMountPartsToUnmountGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_blockedBy;

	private static readonly System.IntPtr NativeFieldInfoPtr_unblockedBy;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShadersBackup;

	private static readonly System.IntPtr NativeFieldInfoPtr_forInventory;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnTakeOffFinished;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnTakeOnStarted;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnTakeOnFinished;

	private static readonly System.IntPtr NativeFieldInfoPtr_flashing;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpecialType_Public_IOSpecialType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSpecialType_Public_Void_IOSpecialType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetForInventory_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reload_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetID_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetID_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddToBlockedBy_Public_Void_CarPart_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddToUnBlockedBy_Public_Void_CarPart_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanMount_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HighlightBlockedBy_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopHighlightBlockedBy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanUnmount_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanHold_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMountedItemsAmount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanMountGroup_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanUnmountGroup_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsComplete_Public_Boolean_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsUnmounted_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAmountOfParts_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAmountOfExaminedParts_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExamineRandomPart_Public_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateForAuction_Public_Void_Int32_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateAllMissing_Public_Void_CarLoader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDummyIO_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMouseOver_Public_Void_Boolean_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMouseOver_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Off_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_On_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HOOff_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLayerRecursively_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReplaceShader_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReinitMaterials_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HighlightAll_Public_Void_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HighlightNone_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Flashing_Public_Void_Boolean_Nullable_1_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr));

	public unsafe string id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe bool on
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_on);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_on)) = flag;
		}
	}

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

	public unsafe IOSpecialType specialType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialType);
			return *(IOSpecialType*)num;
		}
		set
		{
			*(IOSpecialType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialType)) = iOSpecialType;
		}
	}

	public unsafe Highlighter ho
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ho);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Highlighter(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ho), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool mouseOver
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseOver);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseOver)) = flag;
		}
	}

	public unsafe float distanceMod
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceMod);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceMod)) = num;
		}
	}

	public unsafe bool dummyIO
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dummyIO);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dummyIO)) = flag;
		}
	}

	public unsafe Il2CppReferenceArray<Highlighter> hh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hh);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Highlighter>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hh), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool replacedShader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_replacedShader);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_replacedShader)) = flag;
		}
	}

	public unsafe Color highlightColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highlightColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highlightColor)) = color;
		}
	}

	public unsafe Il2CppReferenceArray<Component> unMountPartsToUnmountGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unMountPartsToUnmountGroup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Component>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unMountPartsToUnmountGroup), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<CarPart> blockedBy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockedBy);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<CarPart>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockedBy), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<CarPart> unblockedBy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unblockedBy);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<CarPart>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unblockedBy), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ShadersBackup ShadersBackup
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShadersBackup);
			return new ShadersBackup(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShadersBackup>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShadersBackup), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShadersBackup>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe bool forInventory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forInventory);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forInventory)) = flag;
		}
	}

	public unsafe Il2CppSystem.Action OnTakeOffFinished
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnTakeOffFinished);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnTakeOffFinished), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Action OnTakeOnStarted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnTakeOnStarted);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnTakeOnStarted), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Action OnTakeOnFinished
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnTakeOnFinished);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnTakeOnFinished), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool flashing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flashing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flashing)) = flag;
		}
	}

	[CallerCount(0)]
	public unsafe IOSpecialType GetSpecialType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpecialType_Public_IOSpecialType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(IOSpecialType*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe void SetSpecialType(IOSpecialType ioType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ioType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSpecialType_Public_Void_IOSpecialType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetForInventory(bool b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetForInventory_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58492, XrefRangeEnd = 58500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 58528, RefRangeEnd = 58536, XrefRangeStart = 58500, XrefRangeEnd = 58528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reload()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reload_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58536, XrefRangeEnd = 58542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58542, XrefRangeEnd = 58573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe string GetID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetID_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(60)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void SetID(string newId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(newId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetID_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 58577, RefRangeEnd = 58578, XrefRangeStart = 58573, XrefRangeEnd = 58577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddToBlockedBy(CarPart carPart)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carPart);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddToBlockedBy_Public_Void_CarPart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 58582, RefRangeEnd = 58583, XrefRangeStart = 58578, XrefRangeEnd = 58582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddToUnBlockedBy(CarPart carPart)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carPart);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddToUnBlockedBy_Public_Void_CarPart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 58588, RefRangeEnd = 58590, XrefRangeStart = 58583, XrefRangeEnd = 58588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanMount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanMount_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58590, XrefRangeEnd = 58597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HighlightBlockedBy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HighlightBlockedBy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58597, XrefRangeEnd = 58608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopHighlightBlockedBy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopHighlightBlockedBy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 58613, RefRangeEnd = 58615, XrefRangeStart = 58608, XrefRangeEnd = 58613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanUnmount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanUnmount_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58615, XrefRangeEnd = 58693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanHold()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanHold_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 58698, RefRangeEnd = 58700, XrefRangeStart = 58693, XrefRangeEnd = 58698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetMountedItemsAmount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMountedItemsAmount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 58711, RefRangeEnd = 58712, XrefRangeStart = 58700, XrefRangeEnd = 58711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string CanMountGroup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanMountGroup_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58712, XrefRangeEnd = 58719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string CanUnmountGroup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanUnmountGroup_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58719, XrefRangeEnd = 58726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsComplete(out string missingPart)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr il2CppString = IL2CPP.ManagedStringToIl2Cpp(missingPart);
		*ptr = (nint)(&il2CppString);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsComplete_Public_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		missingPart = IL2CPP.Il2CppStringToManaged(il2CppString);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58726, XrefRangeEnd = 58731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsUnmounted()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsUnmounted_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58731, XrefRangeEnd = 58736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetAmountOfParts()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAmountOfParts_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58736, XrefRangeEnd = 58741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetAmountOfExaminedParts()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAmountOfExaminedParts_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 58792, RefRangeEnd = 58793, XrefRangeStart = 58741, XrefRangeEnd = 58792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ExamineRandomPart(bool showPopup = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&showPopup);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExamineRandomPart_Public_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 58841, RefRangeEnd = 58850, XrefRangeStart = 58793, XrefRangeEnd = 58841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateForAuction(int percUnmounted, CarLoader carLoader = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&percUnmounted);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateForAuction_Public_Void_Int32_CarLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 58855, RefRangeEnd = 58856, XrefRangeStart = 58850, XrefRangeEnd = 58855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateAllMissing(CarLoader carLoader = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(carLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateAllMissing_Public_Void_CarLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetDummyIO(bool b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDummyIO_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58856, XrefRangeEnd = 58857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMouseOver(bool b, Color _highlightColor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&b);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &_highlightColor;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMouseOver_Public_Void_Boolean_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 58862, RefRangeEnd = 58869, XrefRangeStart = 58857, XrefRangeEnd = 58862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMouseOver(bool b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMouseOver_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 58871, RefRangeEnd = 58873, XrefRangeStart = 58869, XrefRangeEnd = 58871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Off()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Off_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void On()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_On_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 58886, RefRangeEnd = 58888, XrefRangeStart = 58873, XrefRangeEnd = 58886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HOOff()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HOOff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 58902, RefRangeEnd = 58916, XrefRangeStart = 58888, XrefRangeEnd = 58902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLayerRecursively(int newLayer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newLayer);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLayerRecursively_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 58949, RefRangeEnd = 58954, XrefRangeStart = 58916, XrefRangeEnd = 58949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReplaceShader(bool unactive)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&unactive);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReplaceShader_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 58959, RefRangeEnd = 58960, XrefRangeStart = 58954, XrefRangeEnd = 58959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReinitMaterials()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReinitMaterials_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 58962, RefRangeEnd = 58964, XrefRangeStart = 58960, XrefRangeEnd = 58962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HighlightAll(Color color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&color);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HighlightAll_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 58966, RefRangeEnd = 58980, XrefRangeStart = 58964, XrefRangeEnd = 58966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HighlightNone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HighlightNone_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(42)]
	[CachedScanResults(RefRangeStart = 58985, RefRangeEnd = 59027, XrefRangeStart = 58980, XrefRangeEnd = 58985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Flashing(bool on, Il2CppSystem.Nullable<Color> color = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&on);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(color));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Flashing_Public_Void_Boolean_Nullable_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59027, XrefRangeEnd = 59040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InteractiveObject()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static InteractiveObject()
	{
		Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "InteractiveObject");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr);
		NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, "id");
		NativeFieldInfoPtr_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, "on");
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, "type");
		NativeFieldInfoPtr_specialType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, "specialType");
		NativeFieldInfoPtr_ho = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, "ho");
		NativeFieldInfoPtr_mouseOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, "mouseOver");
		NativeFieldInfoPtr_distanceMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, "distanceMod");
		NativeFieldInfoPtr_dummyIO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, "dummyIO");
		NativeFieldInfoPtr_hh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, "hh");
		NativeFieldInfoPtr_replacedShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, "replacedShader");
		NativeFieldInfoPtr_highlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, "highlightColor");
		NativeFieldInfoPtr_unMountPartsToUnmountGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, "unMountPartsToUnmountGroup");
		NativeFieldInfoPtr_blockedBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, "blockedBy");
		NativeFieldInfoPtr_unblockedBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, "unblockedBy");
		NativeFieldInfoPtr_ShadersBackup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, "ShadersBackup");
		NativeFieldInfoPtr_forInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, "forInventory");
		NativeFieldInfoPtr_OnTakeOffFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, "OnTakeOffFinished");
		NativeFieldInfoPtr_OnTakeOnStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, "OnTakeOnStarted");
		NativeFieldInfoPtr_OnTakeOnFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, "OnTakeOnFinished");
		NativeFieldInfoPtr_flashing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, "flashing");
		NativeMethodInfoPtr_GetSpecialType_Public_IOSpecialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666782);
		NativeMethodInfoPtr_SetSpecialType_Public_Void_IOSpecialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666783);
		NativeMethodInfoPtr_SetForInventory_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666784);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666785);
		NativeMethodInfoPtr_Reload_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666786);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666787);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666788);
		NativeMethodInfoPtr_GetID_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666789);
		NativeMethodInfoPtr_SetID_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666790);
		NativeMethodInfoPtr_AddToBlockedBy_Public_Void_CarPart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666791);
		NativeMethodInfoPtr_AddToUnBlockedBy_Public_Void_CarPart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666792);
		NativeMethodInfoPtr_CanMount_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666793);
		NativeMethodInfoPtr_HighlightBlockedBy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666794);
		NativeMethodInfoPtr_StopHighlightBlockedBy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666795);
		NativeMethodInfoPtr_CanUnmount_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666796);
		NativeMethodInfoPtr_CanHold_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666797);
		NativeMethodInfoPtr_GetMountedItemsAmount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666798);
		NativeMethodInfoPtr_CanMountGroup_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666799);
		NativeMethodInfoPtr_CanUnmountGroup_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666800);
		NativeMethodInfoPtr_IsComplete_Public_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666801);
		NativeMethodInfoPtr_IsUnmounted_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666802);
		NativeMethodInfoPtr_GetAmountOfParts_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666803);
		NativeMethodInfoPtr_GetAmountOfExaminedParts_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666804);
		NativeMethodInfoPtr_ExamineRandomPart_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666805);
		NativeMethodInfoPtr_GenerateForAuction_Public_Void_Int32_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666806);
		NativeMethodInfoPtr_GenerateAllMissing_Public_Void_CarLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666807);
		NativeMethodInfoPtr_SetDummyIO_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666808);
		NativeMethodInfoPtr_SetMouseOver_Public_Void_Boolean_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666809);
		NativeMethodInfoPtr_SetMouseOver_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666810);
		NativeMethodInfoPtr_Off_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666811);
		NativeMethodInfoPtr_On_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666812);
		NativeMethodInfoPtr_HOOff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666813);
		NativeMethodInfoPtr_SetLayerRecursively_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666814);
		NativeMethodInfoPtr_ReplaceShader_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666815);
		NativeMethodInfoPtr_ReinitMaterials_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666816);
		NativeMethodInfoPtr_HighlightAll_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666817);
		NativeMethodInfoPtr_HighlightNone_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666818);
		NativeMethodInfoPtr_Flashing_Public_Void_Boolean_Nullable_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666819);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractiveObject>.NativeClassPtr, 100666820);
	}

	public InteractiveObject(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
