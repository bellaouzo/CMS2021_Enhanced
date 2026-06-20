using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnhollowerRuntimeLib;
using UnityEngine;
using UnityEngine.UI;

public class LTDescr : Il2CppSystem.Object
{
	public sealed class EaseTypeDelegate : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Vector3_IAsyncResult_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<EaseTypeDelegate>.NativeClassPtr));

		[CallerCount(70)]
		[CachedScanResults(RefRangeStart = 2108, RefRangeEnd = 2178, XrefRangeStart = 2108, XrefRangeEnd = 2108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EaseTypeDelegate(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EaseTypeDelegate>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 2188, RefRangeEnd = 2238, XrefRangeStart = 2178, XrefRangeEnd = 2188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2238, XrefRangeEnd = 2239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppSystem.IAsyncResult BeginInvoke(Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(@object);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.IAsyncResult(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2239, XrefRangeEnd = 2240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 EndInvoke(Il2CppSystem.IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Vector3_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static EaseTypeDelegate()
		{
			Il2CppClassPointerStore<EaseTypeDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "EaseTypeDelegate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseTypeDelegate>.NativeClassPtr, 100663806);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseTypeDelegate>.NativeClassPtr, 100663807);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseTypeDelegate>.NativeClassPtr, 100663808);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Vector3_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EaseTypeDelegate>.NativeClassPtr, 100663809);
		}

		public EaseTypeDelegate(System.IntPtr P_0)
			: base(P_0)
		{
		}

		public static implicit operator EaseTypeDelegate(System.Func<Vector3> P_0)
		{
			return DelegateSupport.ConvertDelegate<EaseTypeDelegate>(P_0);
		}

		public static EaseTypeDelegate operator +(EaseTypeDelegate P_0, EaseTypeDelegate P_1)
		{
			return Il2CppSystem.Delegate.Combine(P_0, P_1).Cast<EaseTypeDelegate>();
		}

		public static EaseTypeDelegate operator -(EaseTypeDelegate P_0, EaseTypeDelegate P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<EaseTypeDelegate>();
			}
			return (EaseTypeDelegate)obj;
		}
	}

	public sealed class ActionMethodDelegate : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ActionMethodDelegate>.NativeClassPtr));

		[CallerCount(70)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe ActionMethodDelegate(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionMethodDelegate>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(217)]
		[CachedScanResults(RefRangeStart = 2243, RefRangeEnd = 2460, XrefRangeStart = 2240, XrefRangeEnd = 2243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe Il2CppSystem.IAsyncResult BeginInvoke(Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(@object);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.IAsyncResult(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2460, XrefRangeEnd = 2461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static ActionMethodDelegate()
		{
			Il2CppClassPointerStore<ActionMethodDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "ActionMethodDelegate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionMethodDelegate>.NativeClassPtr, 100663810);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionMethodDelegate>.NativeClassPtr, 100663811);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionMethodDelegate>.NativeClassPtr, 100663812);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionMethodDelegate>.NativeClassPtr, 100663813);
		}

		public ActionMethodDelegate(System.IntPtr P_0)
			: base(P_0)
		{
		}

		public static implicit operator ActionMethodDelegate(System.Action P_0)
		{
			return DelegateSupport.ConvertDelegate<ActionMethodDelegate>(P_0);
		}

		public static ActionMethodDelegate operator +(ActionMethodDelegate P_0, ActionMethodDelegate P_1)
		{
			return Il2CppSystem.Delegate.Combine(P_0, P_1).Cast<ActionMethodDelegate>();
		}

		public static ActionMethodDelegate operator -(ActionMethodDelegate P_0, ActionMethodDelegate P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<ActionMethodDelegate>();
			}
			return (ActionMethodDelegate)obj;
		}
	}

	[System.Serializable]
	[ObfuscatedName("LTDescr/<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__109_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__110_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__setCallback_b__109_0_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__setValue3_b__110_0_Internal_Void_0;

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

		public unsafe static ActionMethodDelegate __9__109_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__109_0, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new ActionMethodDelegate(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__109_0, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static ActionMethodDelegate __9__110_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__110_0, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? new ActionMethodDelegate(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__110_0, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
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

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe void _setCallback_b__109_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setCallback_b__109_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe void _setValue3_b__110_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setValue3_b__110_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__109_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__109_0");
			NativeFieldInfoPtr___9__110_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__110_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663815);
			NativeMethodInfoPtr__setCallback_b__109_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663816);
			NativeMethodInfoPtr__setValue3_b__110_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663817);
		}

		public __c(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_toggle;

	private static readonly System.IntPtr NativeFieldInfoPtr_useEstimatedTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_useFrames;

	private static readonly System.IntPtr NativeFieldInfoPtr_useManualTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_usesNormalDt;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasInitiliazed;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasExtraOnCompletes;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasPhysics;

	private static readonly System.IntPtr NativeFieldInfoPtr_onCompleteOnRepeat;

	private static readonly System.IntPtr NativeFieldInfoPtr_onCompleteOnStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_useRecursion;

	private static readonly System.IntPtr NativeFieldInfoPtr_ratioPassed;

	private static readonly System.IntPtr NativeFieldInfoPtr_passed;

	private static readonly System.IntPtr NativeFieldInfoPtr_delay;

	private static readonly System.IntPtr NativeFieldInfoPtr_time;

	private static readonly System.IntPtr NativeFieldInfoPtr_speed;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastVal;

	private static readonly System.IntPtr NativeFieldInfoPtr__id;

	private static readonly System.IntPtr NativeFieldInfoPtr_loopCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_counter;

	private static readonly System.IntPtr NativeFieldInfoPtr_direction;

	private static readonly System.IntPtr NativeFieldInfoPtr_directionLast;

	private static readonly System.IntPtr NativeFieldInfoPtr_overshoot;

	private static readonly System.IntPtr NativeFieldInfoPtr_period;

	private static readonly System.IntPtr NativeFieldInfoPtr_destroyOnComplete;

	private static readonly System.IntPtr NativeFieldInfoPtr_trans;

	private static readonly System.IntPtr NativeFieldInfoPtr_ltRect;

	private static readonly System.IntPtr NativeFieldInfoPtr_fromInternal;

	private static readonly System.IntPtr NativeFieldInfoPtr_toInternal;

	private static readonly System.IntPtr NativeFieldInfoPtr_diff;

	private static readonly System.IntPtr NativeFieldInfoPtr_diffDiv2;

	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_tweenType;

	private static readonly System.IntPtr NativeFieldInfoPtr_loopType;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasUpdateCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_easeMethod;

	private static readonly System.IntPtr NativeFieldInfoPtr__easeInternal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__initInternal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_spriteRen;

	private static readonly System.IntPtr NativeFieldInfoPtr_rectTransform;

	private static readonly System.IntPtr NativeFieldInfoPtr_uiText;

	private static readonly System.IntPtr NativeFieldInfoPtr_uiImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_sprites;

	private static readonly System.IntPtr NativeFieldInfoPtr__optional;

	private static readonly System.IntPtr NativeFieldInfoPtr_global_counter;

	private static readonly System.IntPtr NativeFieldInfoPtr_val;

	private static readonly System.IntPtr NativeFieldInfoPtr_dt;

	private static readonly System.IntPtr NativeFieldInfoPtr_newVect;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_from_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_from_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_to_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_to_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_easeInternal_Public_get_ActionMethodDelegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_easeInternal_Public_set_Void_ActionMethodDelegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_initInternal_Public_get_ActionMethodDelegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_initInternal_Public_set_Void_ActionMethodDelegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_cancel_Public_LTDescr_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_uniqueId_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_optional_Public_get_LTDescrOptional_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_optional_Public_set_Void_LTDescrOptional_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_reset_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setMoveX_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setMoveY_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setMoveZ_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setMoveLocalX_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setMoveLocalY_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setMoveLocalZ_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_initFromInternal_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setMoveCurved_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setMoveCurvedLocal_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setMoveSpline_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setMoveSplineLocal_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setScaleX_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setScaleY_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setScaleZ_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setRotateX_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setRotateY_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setRotateZ_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setRotateAround_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setRotateAroundLocal_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setAlpha_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setTextAlpha_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setAlphaVertex_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setColor_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setCallbackColor_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setTextColor_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setCanvasAlpha_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setCanvasGroupAlpha_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setCanvasColor_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setCanvasMoveX_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setCanvasMoveY_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setCanvasMoveZ_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_initCanvasRotateAround_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setCanvasRotateAround_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setCanvasRotateAroundLocal_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setCanvasPlaySprite_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setCanvasMove_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setCanvasScale_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setCanvasSizeDelta_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_callback_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setCallback_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setValue3_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setMove_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setMoveLocal_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setMoveToTransform_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setRotate_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setRotateLocal_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setScale_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setGUIMove_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setGUIMoveMargin_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setGUIScale_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setGUIAlpha_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setGUIRotate_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setDelayedSound_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_init_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_initSpeed_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateNow_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateInternal_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_callOnCompletes_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setFromColor_Public_LTDescr_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_alphaRecursive_Private_Static_Void_Transform_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_colorRecursive_Private_Static_Void_Transform_Color_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_alphaRecursive_Private_Static_Void_RectTransform_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_alphaRecursiveSprite_Private_Static_Void_Transform_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_colorRecursiveSprite_Private_Static_Void_Transform_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_colorRecursive_Private_Static_Void_RectTransform_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_textAlphaRecursive_Private_Static_Void_Transform_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_textColorRecursive_Private_Static_Void_Transform_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tweenColor_Private_Static_Color_LTDescr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_pause_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_resume_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setAxis_Public_LTDescr_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setDelay_Public_LTDescr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEase_Public_LTDescr_LeanTweenType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseLinear_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseSpring_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInQuad_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseOutQuad_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInOutQuad_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInCubic_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseOutCubic_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInOutCubic_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInQuart_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseOutQuart_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInOutQuart_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInQuint_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseOutQuint_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInOutQuint_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInSine_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseOutSine_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInOutSine_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInExpo_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseOutExpo_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInOutExpo_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInCirc_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseOutCirc_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInOutCirc_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInBounce_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseOutBounce_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInOutBounce_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInBack_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseOutBack_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInOutBack_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInElastic_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseOutElastic_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseInOutElastic_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEasePunch_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEaseShake_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tweenOnCurve_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutQuad_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInQuad_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeOutQuad_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeLinear_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeSpring_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInCubic_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeOutCubic_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutCubic_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInQuart_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeOutQuart_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutQuart_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInQuint_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeOutQuint_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutQuint_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInSine_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeOutSine_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutSine_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInExpo_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeOutExpo_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutExpo_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInCirc_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeOutCirc_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutCirc_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInBounce_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeOutBounce_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutBounce_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInBack_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeOutBack_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutBack_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInElastic_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeOutElastic_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutElastic_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setOvershoot_Public_LTDescr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setPeriod_Public_LTDescr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEase_Public_LTDescr_AnimationCurve_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setTo_Public_LTDescr_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setTo_Public_LTDescr_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setFrom_Public_LTDescr_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setFrom_Public_LTDescr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setDiff_Public_LTDescr_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setHasInitialized_Public_LTDescr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setId_Public_LTDescr_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setTime_Public_LTDescr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setSpeed_Public_LTDescr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setRepeat_Public_LTDescr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setLoopType_Public_LTDescr_LeanTweenType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setUseEstimatedTime_Public_LTDescr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setIgnoreTimeScale_Public_LTDescr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setUseFrames_Public_LTDescr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setUseManualTime_Public_LTDescr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setLoopCount_Public_LTDescr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setLoopOnce_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setLoopClamp_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setLoopClamp_Public_LTDescr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setLoopPingPong_Public_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setLoopPingPong_Public_LTDescr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setOnComplete_Public_LTDescr_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setOnComplete_Public_LTDescr_Action_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setOnComplete_Public_LTDescr_Action_1_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setOnCompleteParam_Public_LTDescr_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setOnUpdateRatio_Public_LTDescr_Action_2_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setOnUpdateObject_Public_LTDescr_Action_2_Single_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setOnUpdateVector2_Public_LTDescr_Action_1_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setOnUpdateVector3_Public_LTDescr_Action_1_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setOnUpdateColor_Public_LTDescr_Action_1_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setOnUpdateColor_Public_LTDescr_Action_2_Color_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_2_Color_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_2_Single_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_2_Vector3_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Vector2_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Vector3_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setOnUpdateParam_Public_LTDescr_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setOrientToPath_Public_LTDescr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setOrientToPath2d_Public_LTDescr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setRect_Public_LTDescr_LTRect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setRect_Public_LTDescr_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setPath_Public_LTDescr_LTBezierPath_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setPoint_Public_LTDescr_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setDestroyOnComplete_Public_LTDescr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setAudio_Public_LTDescr_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setOnCompleteOnRepeat_Public_LTDescr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setOnCompleteOnStart_Public_LTDescr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setRect_Public_LTDescr_RectTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setSprites_Public_LTDescr_ArrayOf_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setFrameRate_Public_LTDescr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setOnStart_Public_LTDescr_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setDirection_Public_LTDescr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setRecursive_Public_LTDescr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setMoveX_b__70_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setMoveX_b__70_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setMoveY_b__71_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setMoveY_b__71_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setMoveZ_b__72_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setMoveZ_b__72_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setMoveLocalX_b__73_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setMoveLocalX_b__73_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setMoveLocalY_b__74_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setMoveLocalY_b__74_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setMoveLocalZ_b__75_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setMoveLocalZ_b__75_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setMoveCurved_b__77_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setMoveCurvedLocal_b__78_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setMoveSpline_b__79_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setMoveSplineLocal_b__80_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setScaleX_b__81_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setScaleX_b__81_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setScaleY_b__82_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setScaleY_b__82_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setScaleZ_b__83_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setScaleZ_b__83_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setRotateX_b__84_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setRotateX_b__84_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setRotateY_b__85_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setRotateY_b__85_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setRotateZ_b__86_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setRotateZ_b__86_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setRotateAround_b__87_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setRotateAround_b__87_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setRotateAroundLocal_b__88_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setRotateAroundLocal_b__88_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setAlpha_b__89_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setAlpha_b__89_2_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setAlpha_b__89_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setTextAlpha_b__90_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setTextAlpha_b__90_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setAlphaVertex_b__91_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setAlphaVertex_b__91_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setColor_b__92_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setColor_b__92_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setCallbackColor_b__93_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setCallbackColor_b__93_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setTextColor_b__94_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setTextColor_b__94_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasAlpha_b__95_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasAlpha_b__95_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasGroupAlpha_b__96_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasGroupAlpha_b__96_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasColor_b__97_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasColor_b__97_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasMoveX_b__98_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasMoveX_b__98_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasMoveY_b__99_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasMoveY_b__99_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasMoveZ_b__100_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasMoveZ_b__100_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasRotateAround_b__102_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasRotateAroundLocal_b__103_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasPlaySprite_b__104_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasPlaySprite_b__104_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasMove_b__105_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasMove_b__105_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasScale_b__106_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasScale_b__106_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasSizeDelta_b__107_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setCanvasSizeDelta_b__107_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setMove_b__111_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setMove_b__111_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setMoveLocal_b__112_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setMoveLocal_b__112_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setMoveToTransform_b__113_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setMoveToTransform_b__113_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setRotate_b__114_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setRotate_b__114_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setRotateLocal_b__115_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setRotateLocal_b__115_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setScale_b__116_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setScale_b__116_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setGUIMove_b__117_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setGUIMove_b__117_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setGUIMoveMargin_b__118_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setGUIMoveMargin_b__118_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setGUIScale_b__119_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setGUIScale_b__119_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setGUIAlpha_b__120_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setGUIAlpha_b__120_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setGUIRotate_b__121_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setGUIRotate_b__121_1_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__setDelayedSound_b__122_0_Private_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LTDescr>.NativeClassPtr));

	public unsafe bool toggle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toggle);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toggle)) = flag;
		}
	}

	public unsafe bool useEstimatedTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useEstimatedTime);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useEstimatedTime)) = flag;
		}
	}

	public unsafe bool useFrames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useFrames);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useFrames)) = flag;
		}
	}

	public unsafe bool useManualTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useManualTime);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useManualTime)) = flag;
		}
	}

	public unsafe bool usesNormalDt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usesNormalDt);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usesNormalDt)) = flag;
		}
	}

	public unsafe bool hasInitiliazed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasInitiliazed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasInitiliazed)) = flag;
		}
	}

	public unsafe bool hasExtraOnCompletes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasExtraOnCompletes);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasExtraOnCompletes)) = flag;
		}
	}

	public unsafe bool hasPhysics
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasPhysics);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasPhysics)) = flag;
		}
	}

	public unsafe bool onCompleteOnRepeat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onCompleteOnRepeat);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onCompleteOnRepeat)) = flag;
		}
	}

	public unsafe bool onCompleteOnStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onCompleteOnStart);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onCompleteOnStart)) = flag;
		}
	}

	public unsafe bool useRecursion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useRecursion);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useRecursion)) = flag;
		}
	}

	public unsafe float ratioPassed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ratioPassed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ratioPassed)) = num;
		}
	}

	public unsafe float passed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passed)) = num;
		}
	}

	public unsafe float delay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delay)) = num;
		}
	}

	public unsafe float time
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_time);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_time)) = num;
		}
	}

	public unsafe float speed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speed)) = num;
		}
	}

	public unsafe float lastVal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastVal);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastVal)) = num;
		}
	}

	public unsafe uint _id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__id);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__id)) = num;
		}
	}

	public unsafe int loopCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loopCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loopCount)) = num;
		}
	}

	public unsafe uint counter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_counter);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_counter)) = num;
		}
	}

	public unsafe float direction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_direction);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_direction)) = num;
		}
	}

	public unsafe float directionLast
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_directionLast);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_directionLast)) = num;
		}
	}

	public unsafe float overshoot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overshoot);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overshoot)) = num;
		}
	}

	public unsafe float period
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_period);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_period)) = num;
		}
	}

	public unsafe bool destroyOnComplete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destroyOnComplete);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destroyOnComplete)) = flag;
		}
	}

	public unsafe Transform trans
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trans);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trans), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe LTRect ltRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ltRect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new LTRect(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ltRect), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector3 fromInternal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fromInternal);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fromInternal)) = vector;
		}
	}

	public unsafe Vector3 toInternal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toInternal);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toInternal)) = vector;
		}
	}

	public unsafe Vector3 diff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diff);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diff)) = vector;
		}
	}

	public unsafe Vector3 diffDiv2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diffDiv2);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diffDiv2)) = vector;
		}
	}

	public unsafe TweenAction type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
			return *(TweenAction*)num;
		}
		set
		{
			*(TweenAction*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = tweenAction;
		}
	}

	public unsafe LeanTweenType tweenType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tweenType);
			return *(LeanTweenType*)num;
		}
		set
		{
			*(LeanTweenType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tweenType)) = leanTweenType;
		}
	}

	public unsafe LeanTweenType loopType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loopType);
			return *(LeanTweenType*)num;
		}
		set
		{
			*(LeanTweenType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loopType)) = leanTweenType;
		}
	}

	public unsafe bool hasUpdateCallback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasUpdateCallback);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasUpdateCallback)) = flag;
		}
	}

	public unsafe EaseTypeDelegate easeMethod
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_easeMethod);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new EaseTypeDelegate(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_easeMethod), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ActionMethodDelegate _easeInternal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__easeInternal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ActionMethodDelegate(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__easeInternal_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ActionMethodDelegate _initInternal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__initInternal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new ActionMethodDelegate(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__initInternal_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SpriteRenderer spriteRen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteRen);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new SpriteRenderer(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteRen), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RectTransform rectTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rectTransform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RectTransform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rectTransform), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text uiText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiText), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image uiImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiImage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiImage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<Sprite> sprites
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sprites);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sprites), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe LTDescrOptional _optional
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__optional);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new LTDescrOptional(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__optional), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static uint global_counter
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_global_counter, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_global_counter, &num);
		}
	}

	public unsafe static float val
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_val, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_val, &num);
		}
	}

	public unsafe static float dt
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dt, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dt, &num);
		}
	}

	public unsafe static Vector3 newVect
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector3 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_newVect, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_newVect, &vector);
		}
	}

	public unsafe Vector3 from
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_from_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_from_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Vector3 to
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_to_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_to_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe ActionMethodDelegate easeInternal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_easeInternal_Public_get_ActionMethodDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new ActionMethodDelegate(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_easeInternal_Public_set_Void_ActionMethodDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe ActionMethodDelegate initInternal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_initInternal_Public_get_ActionMethodDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new ActionMethodDelegate(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_initInternal_Public_set_Void_ActionMethodDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe int uniqueId
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_uniqueId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe int id
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe LTDescrOptional optional
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_optional_Public_get_LTDescrOptional_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new LTDescrOptional(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_optional_Public_set_Void_LTDescrOptional_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2461, XrefRangeEnd = 2663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 2666, RefRangeEnd = 2668, XrefRangeStart = 2663, XrefRangeEnd = 2666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTDescr>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2668, XrefRangeEnd = 2696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr cancel(GameObject gameObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_cancel_Public_LTDescr_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2696, XrefRangeEnd = 2709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2718, RefRangeEnd = 2719, XrefRangeStart = 2709, XrefRangeEnd = 2718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setMoveX()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setMoveX_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2728, RefRangeEnd = 2729, XrefRangeStart = 2719, XrefRangeEnd = 2728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setMoveY()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setMoveY_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2738, RefRangeEnd = 2739, XrefRangeStart = 2729, XrefRangeEnd = 2738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setMoveZ()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setMoveZ_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2748, RefRangeEnd = 2749, XrefRangeStart = 2739, XrefRangeEnd = 2748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setMoveLocalX()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setMoveLocalX_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2758, RefRangeEnd = 2759, XrefRangeStart = 2749, XrefRangeEnd = 2758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setMoveLocalY()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setMoveLocalY_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2768, RefRangeEnd = 2769, XrefRangeStart = 2759, XrefRangeEnd = 2768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setMoveLocalZ()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setMoveLocalZ_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe void initFromInternal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initFromInternal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 2778, RefRangeEnd = 2780, XrefRangeStart = 2769, XrefRangeEnd = 2778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setMoveCurved()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setMoveCurved_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 2789, RefRangeEnd = 2791, XrefRangeStart = 2780, XrefRangeEnd = 2789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setMoveCurvedLocal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setMoveCurvedLocal_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 2800, RefRangeEnd = 2804, XrefRangeStart = 2791, XrefRangeEnd = 2800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setMoveSpline()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setMoveSpline_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 2813, RefRangeEnd = 2815, XrefRangeStart = 2804, XrefRangeEnd = 2813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setMoveSplineLocal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setMoveSplineLocal_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2824, RefRangeEnd = 2825, XrefRangeStart = 2815, XrefRangeEnd = 2824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setScaleX()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setScaleX_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2834, RefRangeEnd = 2835, XrefRangeStart = 2825, XrefRangeEnd = 2834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setScaleY()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setScaleY_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2844, RefRangeEnd = 2845, XrefRangeStart = 2835, XrefRangeEnd = 2844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setScaleZ()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setScaleZ_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2854, RefRangeEnd = 2855, XrefRangeStart = 2845, XrefRangeEnd = 2854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setRotateX()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setRotateX_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2864, RefRangeEnd = 2865, XrefRangeStart = 2855, XrefRangeEnd = 2864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setRotateY()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setRotateY_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2874, RefRangeEnd = 2875, XrefRangeStart = 2865, XrefRangeEnd = 2874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setRotateZ()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setRotateZ_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2884, RefRangeEnd = 2885, XrefRangeStart = 2875, XrefRangeEnd = 2884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setRotateAround()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setRotateAround_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2894, RefRangeEnd = 2895, XrefRangeStart = 2885, XrefRangeEnd = 2894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setRotateAroundLocal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setRotateAroundLocal_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2904, RefRangeEnd = 2905, XrefRangeStart = 2895, XrefRangeEnd = 2904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setAlpha()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setAlpha_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 2914, RefRangeEnd = 2916, XrefRangeStart = 2905, XrefRangeEnd = 2914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setTextAlpha()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setTextAlpha_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2925, RefRangeEnd = 2926, XrefRangeStart = 2916, XrefRangeEnd = 2925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setAlphaVertex()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setAlphaVertex_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2935, RefRangeEnd = 2936, XrefRangeStart = 2926, XrefRangeEnd = 2935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setColor_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 2945, RefRangeEnd = 2949, XrefRangeStart = 2936, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setCallbackColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setCallbackColor_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2961, XrefRangeStart = 2949, XrefRangeEnd = 2958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setTextColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setTextColor_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2970, RefRangeEnd = 2971, XrefRangeStart = 2961, XrefRangeEnd = 2970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setCanvasAlpha()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setCanvasAlpha_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2980, RefRangeEnd = 2981, XrefRangeStart = 2971, XrefRangeEnd = 2980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setCanvasGroupAlpha()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setCanvasGroupAlpha_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2990, RefRangeEnd = 2991, XrefRangeStart = 2981, XrefRangeEnd = 2990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setCanvasColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setCanvasColor_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3000, RefRangeEnd = 3001, XrefRangeStart = 2991, XrefRangeEnd = 3000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setCanvasMoveX()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setCanvasMoveX_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3010, RefRangeEnd = 3011, XrefRangeStart = 3001, XrefRangeEnd = 3010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setCanvasMoveY()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setCanvasMoveY_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 3020, RefRangeEnd = 3022, XrefRangeStart = 3011, XrefRangeEnd = 3020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setCanvasMoveZ()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setCanvasMoveZ_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3022, XrefRangeEnd = 3024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void initCanvasRotateAround()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initCanvasRotateAround_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 3033, RefRangeEnd = 3035, XrefRangeStart = 3024, XrefRangeEnd = 3033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setCanvasRotateAround()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setCanvasRotateAround_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3044, RefRangeEnd = 3045, XrefRangeStart = 3035, XrefRangeEnd = 3044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setCanvasRotateAroundLocal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setCanvasRotateAroundLocal_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3054, RefRangeEnd = 3055, XrefRangeStart = 3045, XrefRangeEnd = 3054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setCanvasPlaySprite()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setCanvasPlaySprite_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3064, RefRangeEnd = 3065, XrefRangeStart = 3055, XrefRangeEnd = 3064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setCanvasMove()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setCanvasMove_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3074, RefRangeEnd = 3075, XrefRangeStart = 3065, XrefRangeEnd = 3074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setCanvasScale()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setCanvasScale_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 3084, RefRangeEnd = 3086, XrefRangeStart = 3075, XrefRangeEnd = 3084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setCanvasSizeDelta()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setCanvasSizeDelta_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3086, XrefRangeEnd = 3091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void callback()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_callback_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 3107, RefRangeEnd = 3120, XrefRangeStart = 3091, XrefRangeEnd = 3107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setCallback()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setCallback_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 3136, RefRangeEnd = 3143, XrefRangeStart = 3120, XrefRangeEnd = 3136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setValue3()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setValue3_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 3152, RefRangeEnd = 3169, XrefRangeStart = 3143, XrefRangeEnd = 3152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setMove()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setMove_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 3178, RefRangeEnd = 3183, XrefRangeStart = 3169, XrefRangeEnd = 3178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setMoveLocal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setMoveLocal_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3192, RefRangeEnd = 3193, XrefRangeStart = 3183, XrefRangeEnd = 3192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setMoveToTransform()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setMoveToTransform_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 3202, RefRangeEnd = 3206, XrefRangeStart = 3193, XrefRangeEnd = 3202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setRotate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setRotate_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 3215, RefRangeEnd = 3228, XrefRangeStart = 3206, XrefRangeEnd = 3215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setRotateLocal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setRotateLocal_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 3237, RefRangeEnd = 3260, XrefRangeStart = 3228, XrefRangeEnd = 3237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setScale()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setScale_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3269, RefRangeEnd = 3270, XrefRangeStart = 3260, XrefRangeEnd = 3269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setGUIMove()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setGUIMove_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3279, RefRangeEnd = 3280, XrefRangeStart = 3270, XrefRangeEnd = 3279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setGUIMoveMargin()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setGUIMoveMargin_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3289, RefRangeEnd = 3290, XrefRangeStart = 3280, XrefRangeEnd = 3289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setGUIScale()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setGUIScale_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3299, RefRangeEnd = 3300, XrefRangeStart = 3290, XrefRangeEnd = 3299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setGUIAlpha()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setGUIAlpha_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3309, RefRangeEnd = 3310, XrefRangeStart = 3300, XrefRangeEnd = 3309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setGUIRotate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setGUIRotate_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 3319, RefRangeEnd = 3322, XrefRangeStart = 3310, XrefRangeEnd = 3319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setDelayedSound()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setDelayedSound_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 3329, RefRangeEnd = 3331, XrefRangeStart = 3322, XrefRangeEnd = 3329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 3332, RefRangeEnd = 3336, XrefRangeStart = 3331, XrefRangeEnd = 3332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void initSpeed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initSpeed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3336, XrefRangeEnd = 3337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr updateNow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateNow_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 3391, RefRangeEnd = 3394, XrefRangeStart = 3337, XrefRangeEnd = 3391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool updateInternal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateInternal_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 3400, RefRangeEnd = 3403, XrefRangeStart = 3394, XrefRangeEnd = 3400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void callOnCompletes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_callOnCompletes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe LTDescr setFromColor(Color col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&col);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setFromColor_Public_LTDescr_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3461, RefRangeEnd = 3462, XrefRangeStart = 3403, XrefRangeEnd = 3461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void alphaRecursive(Transform transform, float val, bool useRecursion = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &useRecursion;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_alphaRecursive_Private_Static_Void_Transform_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 3506, RefRangeEnd = 3509, XrefRangeStart = 3462, XrefRangeEnd = 3506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void colorRecursive(Transform transform, Color toColor, bool useRecursion = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &toColor;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &useRecursion;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_colorRecursive_Private_Static_Void_Transform_Color_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 3545, RefRangeEnd = 3547, XrefRangeStart = 3509, XrefRangeEnd = 3545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void alphaRecursive(RectTransform rectTransform, float val, [Optional] int recursiveLevel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &recursiveLevel;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_alphaRecursive_Private_Static_Void_RectTransform_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 3592, RefRangeEnd = 3595, XrefRangeStart = 3547, XrefRangeEnd = 3592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void alphaRecursiveSprite(Transform transform, float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_alphaRecursiveSprite_Private_Static_Void_Transform_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 3641, RefRangeEnd = 3644, XrefRangeStart = 3595, XrefRangeEnd = 3641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void colorRecursiveSprite(Transform transform, Color toColor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &toColor;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_colorRecursiveSprite_Private_Static_Void_Transform_Color_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 3680, RefRangeEnd = 3682, XrefRangeStart = 3644, XrefRangeEnd = 3680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void colorRecursive(RectTransform rectTransform, Color toColor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &toColor;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_colorRecursive_Private_Static_Void_RectTransform_Color_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 3722, RefRangeEnd = 3725, XrefRangeStart = 3682, XrefRangeEnd = 3722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void textAlphaRecursive(Transform trans, float val, bool useRecursion = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(trans);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &useRecursion;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_textAlphaRecursive_Private_Static_Void_Transform_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 3764, RefRangeEnd = 3766, XrefRangeStart = 3725, XrefRangeEnd = 3764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void textColorRecursive(Transform trans, Color toColor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(trans);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &toColor;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_textColorRecursive_Private_Static_Void_Transform_Color_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 3766, RefRangeEnd = 3770, XrefRangeStart = 3766, XrefRangeEnd = 3766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color tweenColor(LTDescr tween, float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(tween);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tweenColor_Private_Static_Color_LTDescr_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe LTDescr pause()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_pause_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr resume()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_resume_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setAxis(Vector3 axis)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&axis);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setAxis_Public_LTDescr_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 3770, RefRangeEnd = 3777, XrefRangeStart = 3770, XrefRangeEnd = 3770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setDelay(float delay)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&delay);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setDelay_Public_LTDescr_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(218)]
	[CachedScanResults(RefRangeStart = 3782, RefRangeEnd = 4000, XrefRangeStart = 3777, XrefRangeEnd = 3782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEase(LeanTweenType easeType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&easeType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEase_Public_LTDescr_LeanTweenType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4005, RefRangeEnd = 4006, XrefRangeStart = 4000, XrefRangeEnd = 4005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseLinear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseLinear_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4006, XrefRangeEnd = 4011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseSpring()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseSpring_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4011, XrefRangeEnd = 4016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInQuad()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseInQuad_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4016, XrefRangeEnd = 4021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseOutQuad()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseOutQuad_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4021, XrefRangeEnd = 4026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInOutQuad()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseInOutQuad_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4026, XrefRangeEnd = 4031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInCubic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseInCubic_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4031, XrefRangeEnd = 4036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseOutCubic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseOutCubic_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4036, XrefRangeEnd = 4041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInOutCubic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseInOutCubic_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4041, XrefRangeEnd = 4046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInQuart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseInQuart_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4046, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseOutQuart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseOutQuart_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4051, XrefRangeEnd = 4056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInOutQuart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseInOutQuart_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4056, XrefRangeEnd = 4061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInQuint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseInQuint_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4061, XrefRangeEnd = 4066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseOutQuint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseOutQuint_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4066, XrefRangeEnd = 4071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInOutQuint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseInOutQuint_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4071, XrefRangeEnd = 4076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInSine()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseInSine_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4076, XrefRangeEnd = 4081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseOutSine()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseOutSine_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4081, XrefRangeEnd = 4086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInOutSine()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseInOutSine_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4086, XrefRangeEnd = 4091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInExpo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseInExpo_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4091, XrefRangeEnd = 4096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseOutExpo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseOutExpo_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4096, XrefRangeEnd = 4101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInOutExpo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseInOutExpo_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4101, XrefRangeEnd = 4106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInCirc()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseInCirc_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4106, XrefRangeEnd = 4111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseOutCirc()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseOutCirc_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4116, RefRangeEnd = 4117, XrefRangeStart = 4111, XrefRangeEnd = 4116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInOutCirc()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseInOutCirc_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4117, XrefRangeEnd = 4122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInBounce()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseInBounce_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4122, XrefRangeEnd = 4127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseOutBounce()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseOutBounce_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4127, XrefRangeEnd = 4132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInOutBounce()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseInOutBounce_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4132, XrefRangeEnd = 4137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInBack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseInBack_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4137, XrefRangeEnd = 4142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseOutBack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseOutBack_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4142, XrefRangeEnd = 4147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInOutBack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseInOutBack_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4147, XrefRangeEnd = 4152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInElastic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseInElastic_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4152, XrefRangeEnd = 4157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseOutElastic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseOutElastic_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4157, XrefRangeEnd = 4162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseInOutElastic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseInOutElastic_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4162, XrefRangeEnd = 4171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEasePunch()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEasePunch_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4171, XrefRangeEnd = 4180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEaseShake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEaseShake_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4180, XrefRangeEnd = 4186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 tweenOnCurve()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tweenOnCurve_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4186, XrefRangeEnd = 4197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInOutQuad()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInOutQuad_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4197, XrefRangeEnd = 4202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInQuad()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInQuad_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4202, XrefRangeEnd = 4208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeOutQuad()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeOutQuad_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4208, XrefRangeEnd = 4213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeLinear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeLinear_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4213, XrefRangeEnd = 4222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeSpring()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeSpring_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4222, XrefRangeEnd = 4227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInCubic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInCubic_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4227, XrefRangeEnd = 4233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeOutCubic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeOutCubic_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4233, XrefRangeEnd = 4245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInOutCubic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInOutCubic_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4245, XrefRangeEnd = 4250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInQuart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInQuart_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4250, XrefRangeEnd = 4256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeOutQuart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeOutQuart_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4256, XrefRangeEnd = 4269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInOutQuart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInOutQuart_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4269, XrefRangeEnd = 4275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInQuint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInQuint_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4275, XrefRangeEnd = 4281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeOutQuint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeOutQuint_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4281, XrefRangeEnd = 4293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInOutQuint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInOutQuint_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4293, XrefRangeEnd = 4303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInSine()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInSine_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4303, XrefRangeEnd = 4313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeOutSine()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeOutSine_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4313, XrefRangeEnd = 4319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInOutSine()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInOutSine_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4319, XrefRangeEnd = 4325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInExpo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInExpo_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4325, XrefRangeEnd = 4331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeOutExpo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeOutExpo_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4331, XrefRangeEnd = 4346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInOutExpo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInOutExpo_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4346, XrefRangeEnd = 4353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInCirc()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInCirc_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4353, XrefRangeEnd = 4361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeOutCirc()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeOutCirc_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4361, XrefRangeEnd = 4377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInOutCirc()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInOutCirc_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4377, XrefRangeEnd = 4390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInBounce()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInBounce_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4390, XrefRangeEnd = 4415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeOutBounce()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeOutBounce_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4415, XrefRangeEnd = 4440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInOutBounce()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInOutBounce_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4440, XrefRangeEnd = 4445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInBack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInBack_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4445, XrefRangeEnd = 4451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeOutBack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeOutBack_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4451, XrefRangeEnd = 4463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInOutBack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInOutBack_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4463, XrefRangeEnd = 4469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInElastic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInElastic_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4469, XrefRangeEnd = 4475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeOutElastic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeOutElastic_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4475, XrefRangeEnd = 4481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 easeInOutElastic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInOutElastic_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe LTDescr setOvershoot(float overshoot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&overshoot);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setOvershoot_Public_LTDescr_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setPeriod(float period)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&period);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setPeriod_Public_LTDescr_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 4486, RefRangeEnd = 4489, XrefRangeStart = 4481, XrefRangeEnd = 4486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setEase(AnimationCurve easeCurve)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(easeCurve);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEase_Public_LTDescr_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 4489, RefRangeEnd = 4491, XrefRangeStart = 4489, XrefRangeEnd = 4489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setTo(Vector3 to)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&to);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setTo_Public_LTDescr_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setTo(Transform to)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(to);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setTo_Public_LTDescr_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(24)]
	[CachedScanResults(RefRangeStart = 4496, RefRangeEnd = 4520, XrefRangeStart = 4491, XrefRangeEnd = 4496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setFrom(Vector3 from)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&from);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setFrom_Public_LTDescr_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4520, XrefRangeEnd = 4521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setFrom(float from)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&from);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setFrom_Public_LTDescr_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setDiff(Vector3 diff)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&diff);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setDiff_Public_LTDescr_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setHasInitialized(bool has)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&has);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setHasInitialized_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4521, XrefRangeEnd = 4525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setId(uint id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setId_Public_LTDescr_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setTime(float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setTime_Public_LTDescr_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4525, XrefRangeEnd = 4526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setSpeed(float speed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&speed);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setSpeed_Public_LTDescr_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setRepeat(int repeat)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&repeat);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setRepeat_Public_LTDescr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setLoopType(LeanTweenType loopType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&loopType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setLoopType_Public_LTDescr_LeanTweenType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setUseEstimatedTime(bool useEstimatedTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&useEstimatedTime);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setUseEstimatedTime_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setIgnoreTimeScale(bool useUnScaledTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&useUnScaledTime);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setIgnoreTimeScale_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setUseFrames(bool useFrames)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&useFrames);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setUseFrames_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setUseManualTime(bool useManualTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&useManualTime);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setUseManualTime_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setLoopCount(int loopCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&loopCount);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setLoopCount_Public_LTDescr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setLoopOnce()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setLoopOnce_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setLoopClamp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setLoopClamp_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setLoopClamp(int loops)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&loops);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setLoopClamp_Public_LTDescr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setLoopPingPong()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setLoopPingPong_Public_LTDescr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setLoopPingPong(int loops)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&loops);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setLoopPingPong_Public_LTDescr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(117)]
	[CachedScanResults(RefRangeStart = 4526, RefRangeEnd = 4643, XrefRangeStart = 4526, XrefRangeEnd = 4526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setOnComplete(Il2CppSystem.Action onComplete)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(onComplete);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setOnComplete_Public_LTDescr_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 4643, RefRangeEnd = 4658, XrefRangeStart = 4643, XrefRangeEnd = 4643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setOnComplete(Il2CppSystem.Action<Il2CppSystem.Object> onComplete)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(onComplete);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setOnComplete_Public_LTDescr_Action_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setOnComplete(Il2CppSystem.Action<Il2CppSystem.Object> onComplete, Il2CppSystem.Object onCompleteParam)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(onComplete);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(onCompleteParam);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setOnComplete_Public_LTDescr_Action_1_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 4658, RefRangeEnd = 4663, XrefRangeStart = 4658, XrefRangeEnd = 4658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setOnCompleteParam(Il2CppSystem.Object onCompleteParam)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(onCompleteParam);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setOnCompleteParam_Public_LTDescr_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(75)]
	[CachedScanResults(RefRangeStart = 4663, RefRangeEnd = 4738, XrefRangeStart = 4663, XrefRangeEnd = 4663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setOnUpdate(Il2CppSystem.Action<float> onUpdate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(onUpdate);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setOnUpdateRatio(Il2CppSystem.Action<float, float> onUpdate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(onUpdate);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setOnUpdateRatio_Public_LTDescr_Action_2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setOnUpdateObject(Il2CppSystem.Action<float, Il2CppSystem.Object> onUpdate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(onUpdate);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setOnUpdateObject_Public_LTDescr_Action_2_Single_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setOnUpdateVector2(Il2CppSystem.Action<Vector2> onUpdate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(onUpdate);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setOnUpdateVector2_Public_LTDescr_Action_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 4738, RefRangeEnd = 4741, XrefRangeStart = 4738, XrefRangeEnd = 4738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setOnUpdateVector3(Il2CppSystem.Action<Vector3> onUpdate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(onUpdate);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setOnUpdateVector3_Public_LTDescr_Action_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 4741, RefRangeEnd = 4748, XrefRangeStart = 4741, XrefRangeEnd = 4741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setOnUpdateColor(Il2CppSystem.Action<Color> onUpdate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(onUpdate);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setOnUpdateColor_Public_LTDescr_Action_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setOnUpdateColor(Il2CppSystem.Action<Color, Il2CppSystem.Object> onUpdate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(onUpdate);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setOnUpdateColor_Public_LTDescr_Action_2_Color_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe LTDescr setOnUpdate(Il2CppSystem.Action<Color> onUpdate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(onUpdate);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setOnUpdate(Il2CppSystem.Action<Color, Il2CppSystem.Object> onUpdate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(onUpdate);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_2_Color_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setOnUpdate(Il2CppSystem.Action<float, Il2CppSystem.Object> onUpdate, Il2CppSystem.Object onUpdateParam = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(onUpdate);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(onUpdateParam);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_2_Single_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setOnUpdate(Il2CppSystem.Action<Vector3, Il2CppSystem.Object> onUpdate, Il2CppSystem.Object onUpdateParam = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(onUpdate);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(onUpdateParam);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_2_Vector3_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4748, RefRangeEnd = 4749, XrefRangeStart = 4748, XrefRangeEnd = 4748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setOnUpdate(Il2CppSystem.Action<Vector2> onUpdate, Il2CppSystem.Object onUpdateParam = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(onUpdate);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(onUpdateParam);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Vector2_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setOnUpdate(Il2CppSystem.Action<Vector3> onUpdate, Il2CppSystem.Object onUpdateParam = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(onUpdate);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(onUpdateParam);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Vector3_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setOnUpdateParam(Il2CppSystem.Object onUpdateParam)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(onUpdateParam);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setOnUpdateParam_Public_LTDescr_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 4750, RefRangeEnd = 4759, XrefRangeStart = 4749, XrefRangeEnd = 4750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setOrientToPath(bool doesOrient)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&doesOrient);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setOrientToPath_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4759, XrefRangeEnd = 4760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setOrientToPath2d(bool doesOrient2d)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&doesOrient2d);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setOrientToPath2d_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 4760, RefRangeEnd = 4766, XrefRangeStart = 4760, XrefRangeEnd = 4760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setRect(LTRect rect)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setRect_Public_LTDescr_LTRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4766, XrefRangeEnd = 4771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setRect(Rect rect)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rect);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setRect_Public_LTDescr_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setPath(LTBezierPath path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setPath_Public_LTDescr_LTBezierPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 4771, RefRangeEnd = 4777, XrefRangeStart = 4771, XrefRangeEnd = 4771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setPoint(Vector3 point)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&point);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setPoint_Public_LTDescr_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setDestroyOnComplete(bool doesDestroy)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&doesDestroy);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setDestroyOnComplete_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 4777, RefRangeEnd = 4780, XrefRangeStart = 4777, XrefRangeEnd = 4777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setAudio(Il2CppSystem.Object audio)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(audio);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setAudio_Public_LTDescr_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setOnCompleteOnRepeat(bool isOn)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isOn);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setOnCompleteOnRepeat_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setOnCompleteOnStart(bool isOn)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isOn);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setOnCompleteOnStart_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setRect(RectTransform rect)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setRect_Public_LTDescr_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setSprites(Il2CppReferenceArray<Sprite> sprites)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprites);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setSprites_Public_LTDescr_ArrayOf_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setFrameRate(float frameRate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&frameRate);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setFrameRate_Public_LTDescr_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 4780, RefRangeEnd = 4784, XrefRangeStart = 4780, XrefRangeEnd = 4780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setOnStart(Il2CppSystem.Action onStart)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(onStart);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setOnStart_Public_LTDescr_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 4801, RefRangeEnd = 4803, XrefRangeStart = 4784, XrefRangeEnd = 4801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LTDescr setDirection(float direction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&direction);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setDirection_Public_LTDescr_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr setRecursive(bool useRecursion)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&useRecursion);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setRecursive_Public_LTDescr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4803, XrefRangeEnd = 4805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveX_b__70_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setMoveX_b__70_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4805, XrefRangeEnd = 4812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveX_b__70_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setMoveX_b__70_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4812, XrefRangeEnd = 4814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveY_b__71_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setMoveY_b__71_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4814, XrefRangeEnd = 4821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveY_b__71_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setMoveY_b__71_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4821, XrefRangeEnd = 4823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveZ_b__72_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setMoveZ_b__72_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4823, XrefRangeEnd = 4830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveZ_b__72_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setMoveZ_b__72_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4830, XrefRangeEnd = 4832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveLocalX_b__73_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setMoveLocalX_b__73_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4832, XrefRangeEnd = 4839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveLocalX_b__73_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setMoveLocalX_b__73_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4839, XrefRangeEnd = 4841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveLocalY_b__74_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setMoveLocalY_b__74_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4841, XrefRangeEnd = 4848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveLocalY_b__74_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setMoveLocalY_b__74_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4848, XrefRangeEnd = 4850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveLocalZ_b__75_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setMoveLocalZ_b__75_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4850, XrefRangeEnd = 4857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveLocalZ_b__75_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setMoveLocalZ_b__75_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4857, XrefRangeEnd = 4868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveCurved_b__77_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setMoveCurved_b__77_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4868, XrefRangeEnd = 4879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveCurvedLocal_b__78_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setMoveCurvedLocal_b__78_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4879, XrefRangeEnd = 4892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveSpline_b__79_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setMoveSpline_b__79_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4892, XrefRangeEnd = 4905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveSplineLocal_b__80_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setMoveSplineLocal_b__80_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4905, XrefRangeEnd = 4907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setScaleX_b__81_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setScaleX_b__81_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4907, XrefRangeEnd = 4914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setScaleX_b__81_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setScaleX_b__81_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4914, XrefRangeEnd = 4916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setScaleY_b__82_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setScaleY_b__82_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4916, XrefRangeEnd = 4923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setScaleY_b__82_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setScaleY_b__82_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4923, XrefRangeEnd = 4925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setScaleZ_b__83_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setScaleZ_b__83_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4925, XrefRangeEnd = 4932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setScaleZ_b__83_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setScaleZ_b__83_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4932, XrefRangeEnd = 4939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setRotateX_b__84_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setRotateX_b__84_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4939, XrefRangeEnd = 4947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setRotateX_b__84_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setRotateX_b__84_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4947, XrefRangeEnd = 4954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setRotateY_b__85_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setRotateY_b__85_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4954, XrefRangeEnd = 4962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setRotateY_b__85_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setRotateY_b__85_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4962, XrefRangeEnd = 4969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setRotateZ_b__86_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setRotateZ_b__86_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4969, XrefRangeEnd = 4977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setRotateZ_b__86_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setRotateZ_b__86_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4977, XrefRangeEnd = 4981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setRotateAround_b__87_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setRotateAround_b__87_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4981, XrefRangeEnd = 4994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setRotateAround_b__87_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setRotateAround_b__87_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4994, XrefRangeEnd = 4998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setRotateAroundLocal_b__88_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setRotateAroundLocal_b__88_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4998, XrefRangeEnd = 5013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setRotateAroundLocal_b__88_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setRotateAroundLocal_b__88_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5013, XrefRangeEnd = 5137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setAlpha_b__89_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setAlpha_b__89_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5137, XrefRangeEnd = 5167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setAlpha_b__89_2()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setAlpha_b__89_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5167, XrefRangeEnd = 5197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setAlpha_b__89_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setAlpha_b__89_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5197, XrefRangeEnd = 5215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setTextAlpha_b__90_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setTextAlpha_b__90_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5215, XrefRangeEnd = 5221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setTextAlpha_b__90_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setTextAlpha_b__90_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5221, XrefRangeEnd = 5229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setAlphaVertex_b__91_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setAlphaVertex_b__91_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5229, XrefRangeEnd = 5263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setAlphaVertex_b__91_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setAlphaVertex_b__91_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5263, XrefRangeEnd = 5288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setColor_b__92_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setColor_b__92_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5288, XrefRangeEnd = 5323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setColor_b__92_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setColor_b__92_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void _setCallbackColor_b__93_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setCallbackColor_b__93_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5323, XrefRangeEnd = 5358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCallbackColor_b__93_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setCallbackColor_b__93_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5358, XrefRangeEnd = 5376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setTextColor_b__94_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setTextColor_b__94_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5376, XrefRangeEnd = 5392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setTextColor_b__94_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setTextColor_b__94_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5392, XrefRangeEnd = 5410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasAlpha_b__95_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setCanvasAlpha_b__95_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5410, XrefRangeEnd = 5436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasAlpha_b__95_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setCanvasAlpha_b__95_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5436, XrefRangeEnd = 5443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasGroupAlpha_b__96_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setCanvasGroupAlpha_b__96_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5443, XrefRangeEnd = 5449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasGroupAlpha_b__96_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setCanvasGroupAlpha_b__96_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5449, XrefRangeEnd = 5466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasColor_b__97_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setCanvasColor_b__97_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5466, XrefRangeEnd = 5480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasColor_b__97_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setCanvasColor_b__97_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5480, XrefRangeEnd = 5481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasMoveX_b__98_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setCanvasMoveX_b__98_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5481, XrefRangeEnd = 5484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasMoveX_b__98_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setCanvasMoveX_b__98_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5484, XrefRangeEnd = 5485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasMoveY_b__99_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setCanvasMoveY_b__99_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5485, XrefRangeEnd = 5488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasMoveY_b__99_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setCanvasMoveY_b__99_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5488, XrefRangeEnd = 5489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasMoveZ_b__100_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setCanvasMoveZ_b__100_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5489, XrefRangeEnd = 5492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasMoveZ_b__100_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setCanvasMoveZ_b__100_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5492, XrefRangeEnd = 5513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasRotateAround_b__102_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setCanvasRotateAround_b__102_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5513, XrefRangeEnd = 5538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasRotateAroundLocal_b__103_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setCanvasRotateAroundLocal_b__103_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5538, XrefRangeEnd = 5543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasPlaySprite_b__104_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setCanvasPlaySprite_b__104_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5543, XrefRangeEnd = 5554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasPlaySprite_b__104_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setCanvasPlaySprite_b__104_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5554, XrefRangeEnd = 5555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasMove_b__105_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setCanvasMove_b__105_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5555, XrefRangeEnd = 5557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasMove_b__105_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setCanvasMove_b__105_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5557, XrefRangeEnd = 5559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasScale_b__106_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setCanvasScale_b__106_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5559, XrefRangeEnd = 5562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasScale_b__106_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setCanvasScale_b__106_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5562, XrefRangeEnd = 5564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasSizeDelta_b__107_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setCanvasSizeDelta_b__107_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5564, XrefRangeEnd = 5567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setCanvasSizeDelta_b__107_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setCanvasSizeDelta_b__107_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5567, XrefRangeEnd = 5569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMove_b__111_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setMove_b__111_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5569, XrefRangeEnd = 5572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMove_b__111_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setMove_b__111_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5572, XrefRangeEnd = 5574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveLocal_b__112_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setMoveLocal_b__112_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5574, XrefRangeEnd = 5577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveLocal_b__112_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setMoveLocal_b__112_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void _setMoveToTransform_b__113_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setMoveToTransform_b__113_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5577, XrefRangeEnd = 5582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setMoveToTransform_b__113_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setMoveToTransform_b__113_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5582, XrefRangeEnd = 5591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setRotate_b__114_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setRotate_b__114_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5591, XrefRangeEnd = 5593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setRotate_b__114_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setRotate_b__114_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5593, XrefRangeEnd = 5602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setRotateLocal_b__115_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setRotateLocal_b__115_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5602, XrefRangeEnd = 5604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setRotateLocal_b__115_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setRotateLocal_b__115_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5604, XrefRangeEnd = 5606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setScale_b__116_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setScale_b__116_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5606, XrefRangeEnd = 5609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setScale_b__116_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setScale_b__116_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5609, XrefRangeEnd = 5611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setGUIMove_b__117_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setGUIMove_b__117_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5611, XrefRangeEnd = 5614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setGUIMove_b__117_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setGUIMove_b__117_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void _setGUIMoveMargin_b__118_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setGUIMoveMargin_b__118_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5614, XrefRangeEnd = 5615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setGUIMoveMargin_b__118_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setGUIMoveMargin_b__118_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5615, XrefRangeEnd = 5617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setGUIScale_b__119_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setGUIScale_b__119_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5617, XrefRangeEnd = 5620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setGUIScale_b__119_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setGUIScale_b__119_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void _setGUIAlpha_b__120_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setGUIAlpha_b__120_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5620, XrefRangeEnd = 5621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setGUIAlpha_b__120_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setGUIAlpha_b__120_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5621, XrefRangeEnd = 5622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setGUIRotate_b__121_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setGUIRotate_b__121_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5622, XrefRangeEnd = 5623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _setGUIRotate_b__121_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setGUIRotate_b__121_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void _setDelayedSound_b__122_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__setDelayedSound_b__122_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static LTDescr()
	{
		Il2CppClassPointerStore<LTDescr>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LTDescr");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LTDescr>.NativeClassPtr);
		NativeFieldInfoPtr_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "toggle");
		NativeFieldInfoPtr_useEstimatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "useEstimatedTime");
		NativeFieldInfoPtr_useFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "useFrames");
		NativeFieldInfoPtr_useManualTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "useManualTime");
		NativeFieldInfoPtr_usesNormalDt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "usesNormalDt");
		NativeFieldInfoPtr_hasInitiliazed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "hasInitiliazed");
		NativeFieldInfoPtr_hasExtraOnCompletes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "hasExtraOnCompletes");
		NativeFieldInfoPtr_hasPhysics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "hasPhysics");
		NativeFieldInfoPtr_onCompleteOnRepeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "onCompleteOnRepeat");
		NativeFieldInfoPtr_onCompleteOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "onCompleteOnStart");
		NativeFieldInfoPtr_useRecursion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "useRecursion");
		NativeFieldInfoPtr_ratioPassed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "ratioPassed");
		NativeFieldInfoPtr_passed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "passed");
		NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "delay");
		NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "time");
		NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "speed");
		NativeFieldInfoPtr_lastVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "lastVal");
		NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "_id");
		NativeFieldInfoPtr_loopCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "loopCount");
		NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "counter");
		NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "direction");
		NativeFieldInfoPtr_directionLast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "directionLast");
		NativeFieldInfoPtr_overshoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "overshoot");
		NativeFieldInfoPtr_period = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "period");
		NativeFieldInfoPtr_destroyOnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "destroyOnComplete");
		NativeFieldInfoPtr_trans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "trans");
		NativeFieldInfoPtr_ltRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "ltRect");
		NativeFieldInfoPtr_fromInternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "fromInternal");
		NativeFieldInfoPtr_toInternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "toInternal");
		NativeFieldInfoPtr_diff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "diff");
		NativeFieldInfoPtr_diffDiv2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "diffDiv2");
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "type");
		NativeFieldInfoPtr_tweenType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "tweenType");
		NativeFieldInfoPtr_loopType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "loopType");
		NativeFieldInfoPtr_hasUpdateCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "hasUpdateCallback");
		NativeFieldInfoPtr_easeMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "easeMethod");
		NativeFieldInfoPtr__easeInternal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "<easeInternal>k__BackingField");
		NativeFieldInfoPtr__initInternal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "<initInternal>k__BackingField");
		NativeFieldInfoPtr_spriteRen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "spriteRen");
		NativeFieldInfoPtr_rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "rectTransform");
		NativeFieldInfoPtr_uiText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "uiText");
		NativeFieldInfoPtr_uiImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "uiImage");
		NativeFieldInfoPtr_sprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "sprites");
		NativeFieldInfoPtr__optional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "_optional");
		NativeFieldInfoPtr_global_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "global_counter");
		NativeFieldInfoPtr_val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "val");
		NativeFieldInfoPtr_dt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "dt");
		NativeFieldInfoPtr_newVect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, "newVect");
		NativeMethodInfoPtr_get_from_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663501);
		NativeMethodInfoPtr_set_from_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663502);
		NativeMethodInfoPtr_get_to_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663503);
		NativeMethodInfoPtr_set_to_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663504);
		NativeMethodInfoPtr_get_easeInternal_Public_get_ActionMethodDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663505);
		NativeMethodInfoPtr_set_easeInternal_Public_set_Void_ActionMethodDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663506);
		NativeMethodInfoPtr_get_initInternal_Public_get_ActionMethodDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663507);
		NativeMethodInfoPtr_set_initInternal_Public_set_Void_ActionMethodDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663508);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663509);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663510);
		NativeMethodInfoPtr_cancel_Public_LTDescr_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663511);
		NativeMethodInfoPtr_get_uniqueId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663512);
		NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663513);
		NativeMethodInfoPtr_get_optional_Public_get_LTDescrOptional_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663514);
		NativeMethodInfoPtr_set_optional_Public_set_Void_LTDescrOptional_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663515);
		NativeMethodInfoPtr_reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663516);
		NativeMethodInfoPtr_setMoveX_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663517);
		NativeMethodInfoPtr_setMoveY_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663518);
		NativeMethodInfoPtr_setMoveZ_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663519);
		NativeMethodInfoPtr_setMoveLocalX_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663520);
		NativeMethodInfoPtr_setMoveLocalY_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663521);
		NativeMethodInfoPtr_setMoveLocalZ_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663522);
		NativeMethodInfoPtr_initFromInternal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663523);
		NativeMethodInfoPtr_setMoveCurved_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663524);
		NativeMethodInfoPtr_setMoveCurvedLocal_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663525);
		NativeMethodInfoPtr_setMoveSpline_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663526);
		NativeMethodInfoPtr_setMoveSplineLocal_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663527);
		NativeMethodInfoPtr_setScaleX_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663528);
		NativeMethodInfoPtr_setScaleY_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663529);
		NativeMethodInfoPtr_setScaleZ_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663530);
		NativeMethodInfoPtr_setRotateX_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663531);
		NativeMethodInfoPtr_setRotateY_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663532);
		NativeMethodInfoPtr_setRotateZ_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663533);
		NativeMethodInfoPtr_setRotateAround_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663534);
		NativeMethodInfoPtr_setRotateAroundLocal_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663535);
		NativeMethodInfoPtr_setAlpha_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663536);
		NativeMethodInfoPtr_setTextAlpha_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663537);
		NativeMethodInfoPtr_setAlphaVertex_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663538);
		NativeMethodInfoPtr_setColor_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663539);
		NativeMethodInfoPtr_setCallbackColor_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663540);
		NativeMethodInfoPtr_setTextColor_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663541);
		NativeMethodInfoPtr_setCanvasAlpha_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663542);
		NativeMethodInfoPtr_setCanvasGroupAlpha_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663543);
		NativeMethodInfoPtr_setCanvasColor_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663544);
		NativeMethodInfoPtr_setCanvasMoveX_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663545);
		NativeMethodInfoPtr_setCanvasMoveY_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663546);
		NativeMethodInfoPtr_setCanvasMoveZ_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663547);
		NativeMethodInfoPtr_initCanvasRotateAround_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663548);
		NativeMethodInfoPtr_setCanvasRotateAround_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663549);
		NativeMethodInfoPtr_setCanvasRotateAroundLocal_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663550);
		NativeMethodInfoPtr_setCanvasPlaySprite_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663551);
		NativeMethodInfoPtr_setCanvasMove_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663552);
		NativeMethodInfoPtr_setCanvasScale_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663553);
		NativeMethodInfoPtr_setCanvasSizeDelta_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663554);
		NativeMethodInfoPtr_callback_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663555);
		NativeMethodInfoPtr_setCallback_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663556);
		NativeMethodInfoPtr_setValue3_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663557);
		NativeMethodInfoPtr_setMove_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663558);
		NativeMethodInfoPtr_setMoveLocal_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663559);
		NativeMethodInfoPtr_setMoveToTransform_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663560);
		NativeMethodInfoPtr_setRotate_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663561);
		NativeMethodInfoPtr_setRotateLocal_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663562);
		NativeMethodInfoPtr_setScale_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663563);
		NativeMethodInfoPtr_setGUIMove_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663564);
		NativeMethodInfoPtr_setGUIMoveMargin_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663565);
		NativeMethodInfoPtr_setGUIScale_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663566);
		NativeMethodInfoPtr_setGUIAlpha_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663567);
		NativeMethodInfoPtr_setGUIRotate_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663568);
		NativeMethodInfoPtr_setDelayedSound_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663569);
		NativeMethodInfoPtr_init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663570);
		NativeMethodInfoPtr_initSpeed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663571);
		NativeMethodInfoPtr_updateNow_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663572);
		NativeMethodInfoPtr_updateInternal_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663573);
		NativeMethodInfoPtr_callOnCompletes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663574);
		NativeMethodInfoPtr_setFromColor_Public_LTDescr_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663575);
		NativeMethodInfoPtr_alphaRecursive_Private_Static_Void_Transform_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663576);
		NativeMethodInfoPtr_colorRecursive_Private_Static_Void_Transform_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663577);
		NativeMethodInfoPtr_alphaRecursive_Private_Static_Void_RectTransform_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663578);
		NativeMethodInfoPtr_alphaRecursiveSprite_Private_Static_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663579);
		NativeMethodInfoPtr_colorRecursiveSprite_Private_Static_Void_Transform_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663580);
		NativeMethodInfoPtr_colorRecursive_Private_Static_Void_RectTransform_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663581);
		NativeMethodInfoPtr_textAlphaRecursive_Private_Static_Void_Transform_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663582);
		NativeMethodInfoPtr_textColorRecursive_Private_Static_Void_Transform_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663583);
		NativeMethodInfoPtr_tweenColor_Private_Static_Color_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663584);
		NativeMethodInfoPtr_pause_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663585);
		NativeMethodInfoPtr_resume_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663586);
		NativeMethodInfoPtr_setAxis_Public_LTDescr_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663587);
		NativeMethodInfoPtr_setDelay_Public_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663588);
		NativeMethodInfoPtr_setEase_Public_LTDescr_LeanTweenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663589);
		NativeMethodInfoPtr_setEaseLinear_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663590);
		NativeMethodInfoPtr_setEaseSpring_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663591);
		NativeMethodInfoPtr_setEaseInQuad_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663592);
		NativeMethodInfoPtr_setEaseOutQuad_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663593);
		NativeMethodInfoPtr_setEaseInOutQuad_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663594);
		NativeMethodInfoPtr_setEaseInCubic_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663595);
		NativeMethodInfoPtr_setEaseOutCubic_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663596);
		NativeMethodInfoPtr_setEaseInOutCubic_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663597);
		NativeMethodInfoPtr_setEaseInQuart_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663598);
		NativeMethodInfoPtr_setEaseOutQuart_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663599);
		NativeMethodInfoPtr_setEaseInOutQuart_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663600);
		NativeMethodInfoPtr_setEaseInQuint_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663601);
		NativeMethodInfoPtr_setEaseOutQuint_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663602);
		NativeMethodInfoPtr_setEaseInOutQuint_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663603);
		NativeMethodInfoPtr_setEaseInSine_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663604);
		NativeMethodInfoPtr_setEaseOutSine_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663605);
		NativeMethodInfoPtr_setEaseInOutSine_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663606);
		NativeMethodInfoPtr_setEaseInExpo_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663607);
		NativeMethodInfoPtr_setEaseOutExpo_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663608);
		NativeMethodInfoPtr_setEaseInOutExpo_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663609);
		NativeMethodInfoPtr_setEaseInCirc_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663610);
		NativeMethodInfoPtr_setEaseOutCirc_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663611);
		NativeMethodInfoPtr_setEaseInOutCirc_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663612);
		NativeMethodInfoPtr_setEaseInBounce_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663613);
		NativeMethodInfoPtr_setEaseOutBounce_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663614);
		NativeMethodInfoPtr_setEaseInOutBounce_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663615);
		NativeMethodInfoPtr_setEaseInBack_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663616);
		NativeMethodInfoPtr_setEaseOutBack_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663617);
		NativeMethodInfoPtr_setEaseInOutBack_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663618);
		NativeMethodInfoPtr_setEaseInElastic_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663619);
		NativeMethodInfoPtr_setEaseOutElastic_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663620);
		NativeMethodInfoPtr_setEaseInOutElastic_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663621);
		NativeMethodInfoPtr_setEasePunch_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663622);
		NativeMethodInfoPtr_setEaseShake_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663623);
		NativeMethodInfoPtr_tweenOnCurve_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663624);
		NativeMethodInfoPtr_easeInOutQuad_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663625);
		NativeMethodInfoPtr_easeInQuad_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663626);
		NativeMethodInfoPtr_easeOutQuad_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663627);
		NativeMethodInfoPtr_easeLinear_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663628);
		NativeMethodInfoPtr_easeSpring_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663629);
		NativeMethodInfoPtr_easeInCubic_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663630);
		NativeMethodInfoPtr_easeOutCubic_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663631);
		NativeMethodInfoPtr_easeInOutCubic_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663632);
		NativeMethodInfoPtr_easeInQuart_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663633);
		NativeMethodInfoPtr_easeOutQuart_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663634);
		NativeMethodInfoPtr_easeInOutQuart_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663635);
		NativeMethodInfoPtr_easeInQuint_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663636);
		NativeMethodInfoPtr_easeOutQuint_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663637);
		NativeMethodInfoPtr_easeInOutQuint_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663638);
		NativeMethodInfoPtr_easeInSine_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663639);
		NativeMethodInfoPtr_easeOutSine_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663640);
		NativeMethodInfoPtr_easeInOutSine_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663641);
		NativeMethodInfoPtr_easeInExpo_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663642);
		NativeMethodInfoPtr_easeOutExpo_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663643);
		NativeMethodInfoPtr_easeInOutExpo_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663644);
		NativeMethodInfoPtr_easeInCirc_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663645);
		NativeMethodInfoPtr_easeOutCirc_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663646);
		NativeMethodInfoPtr_easeInOutCirc_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663647);
		NativeMethodInfoPtr_easeInBounce_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663648);
		NativeMethodInfoPtr_easeOutBounce_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663649);
		NativeMethodInfoPtr_easeInOutBounce_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663650);
		NativeMethodInfoPtr_easeInBack_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663651);
		NativeMethodInfoPtr_easeOutBack_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663652);
		NativeMethodInfoPtr_easeInOutBack_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663653);
		NativeMethodInfoPtr_easeInElastic_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663654);
		NativeMethodInfoPtr_easeOutElastic_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663655);
		NativeMethodInfoPtr_easeInOutElastic_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663656);
		NativeMethodInfoPtr_setOvershoot_Public_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663657);
		NativeMethodInfoPtr_setPeriod_Public_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663658);
		NativeMethodInfoPtr_setEase_Public_LTDescr_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663659);
		NativeMethodInfoPtr_setTo_Public_LTDescr_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663660);
		NativeMethodInfoPtr_setTo_Public_LTDescr_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663661);
		NativeMethodInfoPtr_setFrom_Public_LTDescr_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663662);
		NativeMethodInfoPtr_setFrom_Public_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663663);
		NativeMethodInfoPtr_setDiff_Public_LTDescr_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663664);
		NativeMethodInfoPtr_setHasInitialized_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663665);
		NativeMethodInfoPtr_setId_Public_LTDescr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663666);
		NativeMethodInfoPtr_setTime_Public_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663667);
		NativeMethodInfoPtr_setSpeed_Public_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663668);
		NativeMethodInfoPtr_setRepeat_Public_LTDescr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663669);
		NativeMethodInfoPtr_setLoopType_Public_LTDescr_LeanTweenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663670);
		NativeMethodInfoPtr_setUseEstimatedTime_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663671);
		NativeMethodInfoPtr_setIgnoreTimeScale_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663672);
		NativeMethodInfoPtr_setUseFrames_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663673);
		NativeMethodInfoPtr_setUseManualTime_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663674);
		NativeMethodInfoPtr_setLoopCount_Public_LTDescr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663675);
		NativeMethodInfoPtr_setLoopOnce_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663676);
		NativeMethodInfoPtr_setLoopClamp_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663677);
		NativeMethodInfoPtr_setLoopClamp_Public_LTDescr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663678);
		NativeMethodInfoPtr_setLoopPingPong_Public_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663679);
		NativeMethodInfoPtr_setLoopPingPong_Public_LTDescr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663680);
		NativeMethodInfoPtr_setOnComplete_Public_LTDescr_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663681);
		NativeMethodInfoPtr_setOnComplete_Public_LTDescr_Action_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663682);
		NativeMethodInfoPtr_setOnComplete_Public_LTDescr_Action_1_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663683);
		NativeMethodInfoPtr_setOnCompleteParam_Public_LTDescr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663684);
		NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663685);
		NativeMethodInfoPtr_setOnUpdateRatio_Public_LTDescr_Action_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663686);
		NativeMethodInfoPtr_setOnUpdateObject_Public_LTDescr_Action_2_Single_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663687);
		NativeMethodInfoPtr_setOnUpdateVector2_Public_LTDescr_Action_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663688);
		NativeMethodInfoPtr_setOnUpdateVector3_Public_LTDescr_Action_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663689);
		NativeMethodInfoPtr_setOnUpdateColor_Public_LTDescr_Action_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663690);
		NativeMethodInfoPtr_setOnUpdateColor_Public_LTDescr_Action_2_Color_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663691);
		NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663692);
		NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_2_Color_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663693);
		NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_2_Single_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663694);
		NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_2_Vector3_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663695);
		NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Vector2_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663696);
		NativeMethodInfoPtr_setOnUpdate_Public_LTDescr_Action_1_Vector3_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663697);
		NativeMethodInfoPtr_setOnUpdateParam_Public_LTDescr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663698);
		NativeMethodInfoPtr_setOrientToPath_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663699);
		NativeMethodInfoPtr_setOrientToPath2d_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663700);
		NativeMethodInfoPtr_setRect_Public_LTDescr_LTRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663701);
		NativeMethodInfoPtr_setRect_Public_LTDescr_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663702);
		NativeMethodInfoPtr_setPath_Public_LTDescr_LTBezierPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663703);
		NativeMethodInfoPtr_setPoint_Public_LTDescr_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663704);
		NativeMethodInfoPtr_setDestroyOnComplete_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663705);
		NativeMethodInfoPtr_setAudio_Public_LTDescr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663706);
		NativeMethodInfoPtr_setOnCompleteOnRepeat_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663707);
		NativeMethodInfoPtr_setOnCompleteOnStart_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663708);
		NativeMethodInfoPtr_setRect_Public_LTDescr_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663709);
		NativeMethodInfoPtr_setSprites_Public_LTDescr_ArrayOf_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663710);
		NativeMethodInfoPtr_setFrameRate_Public_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663711);
		NativeMethodInfoPtr_setOnStart_Public_LTDescr_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663712);
		NativeMethodInfoPtr_setDirection_Public_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663713);
		NativeMethodInfoPtr_setRecursive_Public_LTDescr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663714);
		NativeMethodInfoPtr__setMoveX_b__70_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663716);
		NativeMethodInfoPtr__setMoveX_b__70_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663717);
		NativeMethodInfoPtr__setMoveY_b__71_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663718);
		NativeMethodInfoPtr__setMoveY_b__71_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663719);
		NativeMethodInfoPtr__setMoveZ_b__72_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663720);
		NativeMethodInfoPtr__setMoveZ_b__72_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663721);
		NativeMethodInfoPtr__setMoveLocalX_b__73_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663722);
		NativeMethodInfoPtr__setMoveLocalX_b__73_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663723);
		NativeMethodInfoPtr__setMoveLocalY_b__74_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663724);
		NativeMethodInfoPtr__setMoveLocalY_b__74_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663725);
		NativeMethodInfoPtr__setMoveLocalZ_b__75_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663726);
		NativeMethodInfoPtr__setMoveLocalZ_b__75_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663727);
		NativeMethodInfoPtr__setMoveCurved_b__77_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663728);
		NativeMethodInfoPtr__setMoveCurvedLocal_b__78_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663729);
		NativeMethodInfoPtr__setMoveSpline_b__79_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663730);
		NativeMethodInfoPtr__setMoveSplineLocal_b__80_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663731);
		NativeMethodInfoPtr__setScaleX_b__81_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663732);
		NativeMethodInfoPtr__setScaleX_b__81_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663733);
		NativeMethodInfoPtr__setScaleY_b__82_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663734);
		NativeMethodInfoPtr__setScaleY_b__82_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663735);
		NativeMethodInfoPtr__setScaleZ_b__83_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663736);
		NativeMethodInfoPtr__setScaleZ_b__83_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663737);
		NativeMethodInfoPtr__setRotateX_b__84_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663738);
		NativeMethodInfoPtr__setRotateX_b__84_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663739);
		NativeMethodInfoPtr__setRotateY_b__85_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663740);
		NativeMethodInfoPtr__setRotateY_b__85_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663741);
		NativeMethodInfoPtr__setRotateZ_b__86_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663742);
		NativeMethodInfoPtr__setRotateZ_b__86_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663743);
		NativeMethodInfoPtr__setRotateAround_b__87_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663744);
		NativeMethodInfoPtr__setRotateAround_b__87_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663745);
		NativeMethodInfoPtr__setRotateAroundLocal_b__88_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663746);
		NativeMethodInfoPtr__setRotateAroundLocal_b__88_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663747);
		NativeMethodInfoPtr__setAlpha_b__89_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663748);
		NativeMethodInfoPtr__setAlpha_b__89_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663749);
		NativeMethodInfoPtr__setAlpha_b__89_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663750);
		NativeMethodInfoPtr__setTextAlpha_b__90_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663751);
		NativeMethodInfoPtr__setTextAlpha_b__90_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663752);
		NativeMethodInfoPtr__setAlphaVertex_b__91_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663753);
		NativeMethodInfoPtr__setAlphaVertex_b__91_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663754);
		NativeMethodInfoPtr__setColor_b__92_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663755);
		NativeMethodInfoPtr__setColor_b__92_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663756);
		NativeMethodInfoPtr__setCallbackColor_b__93_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663757);
		NativeMethodInfoPtr__setCallbackColor_b__93_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663758);
		NativeMethodInfoPtr__setTextColor_b__94_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663759);
		NativeMethodInfoPtr__setTextColor_b__94_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663760);
		NativeMethodInfoPtr__setCanvasAlpha_b__95_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663761);
		NativeMethodInfoPtr__setCanvasAlpha_b__95_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663762);
		NativeMethodInfoPtr__setCanvasGroupAlpha_b__96_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663763);
		NativeMethodInfoPtr__setCanvasGroupAlpha_b__96_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663764);
		NativeMethodInfoPtr__setCanvasColor_b__97_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663765);
		NativeMethodInfoPtr__setCanvasColor_b__97_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663766);
		NativeMethodInfoPtr__setCanvasMoveX_b__98_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663767);
		NativeMethodInfoPtr__setCanvasMoveX_b__98_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663768);
		NativeMethodInfoPtr__setCanvasMoveY_b__99_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663769);
		NativeMethodInfoPtr__setCanvasMoveY_b__99_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663770);
		NativeMethodInfoPtr__setCanvasMoveZ_b__100_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663771);
		NativeMethodInfoPtr__setCanvasMoveZ_b__100_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663772);
		NativeMethodInfoPtr__setCanvasRotateAround_b__102_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663773);
		NativeMethodInfoPtr__setCanvasRotateAroundLocal_b__103_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663774);
		NativeMethodInfoPtr__setCanvasPlaySprite_b__104_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663775);
		NativeMethodInfoPtr__setCanvasPlaySprite_b__104_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663776);
		NativeMethodInfoPtr__setCanvasMove_b__105_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663777);
		NativeMethodInfoPtr__setCanvasMove_b__105_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663778);
		NativeMethodInfoPtr__setCanvasScale_b__106_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663779);
		NativeMethodInfoPtr__setCanvasScale_b__106_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663780);
		NativeMethodInfoPtr__setCanvasSizeDelta_b__107_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663781);
		NativeMethodInfoPtr__setCanvasSizeDelta_b__107_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663782);
		NativeMethodInfoPtr__setMove_b__111_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663783);
		NativeMethodInfoPtr__setMove_b__111_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663784);
		NativeMethodInfoPtr__setMoveLocal_b__112_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663785);
		NativeMethodInfoPtr__setMoveLocal_b__112_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663786);
		NativeMethodInfoPtr__setMoveToTransform_b__113_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663787);
		NativeMethodInfoPtr__setMoveToTransform_b__113_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663788);
		NativeMethodInfoPtr__setRotate_b__114_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663789);
		NativeMethodInfoPtr__setRotate_b__114_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663790);
		NativeMethodInfoPtr__setRotateLocal_b__115_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663791);
		NativeMethodInfoPtr__setRotateLocal_b__115_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663792);
		NativeMethodInfoPtr__setScale_b__116_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663793);
		NativeMethodInfoPtr__setScale_b__116_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663794);
		NativeMethodInfoPtr__setGUIMove_b__117_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663795);
		NativeMethodInfoPtr__setGUIMove_b__117_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663796);
		NativeMethodInfoPtr__setGUIMoveMargin_b__118_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663797);
		NativeMethodInfoPtr__setGUIMoveMargin_b__118_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663798);
		NativeMethodInfoPtr__setGUIScale_b__119_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663799);
		NativeMethodInfoPtr__setGUIScale_b__119_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663800);
		NativeMethodInfoPtr__setGUIAlpha_b__120_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663801);
		NativeMethodInfoPtr__setGUIAlpha_b__120_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663802);
		NativeMethodInfoPtr__setGUIRotate_b__121_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663803);
		NativeMethodInfoPtr__setGUIRotate_b__121_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663804);
		NativeMethodInfoPtr__setDelayedSound_b__122_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTDescr>.NativeClassPtr, 100663805);
	}

	public LTDescr(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
