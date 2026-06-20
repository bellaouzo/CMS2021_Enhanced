using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnhollowerRuntimeLib;
using UnityEngine;

public static class CommonTools : Il2CppSystem.Object
{
	public sealed class Func<T1, TResult> : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T1_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T1_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_TResult_IAsyncResult_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Func<T1, TResult>>.NativeClassPtr));

		[CallerCount(70)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe Func(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Func<T1, TResult>>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 107196, RefRangeEnd = 107206, XrefRangeStart = 107184, XrefRangeEnd = 107196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TResult Invoke(T1 arg1)
		{
			//IL_0070->IL0075: Incompatible stack types: I vs Ref
			//IL_004c->IL0075: Incompatible stack types: I vs Ref
			//IL_0059->IL0075: Incompatible stack types: I vs Ref
			//IL_0063->IL0075: Incompatible stack types: I vs Ref
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			ref T1 reference;
			if (!typeof(T1).IsValueType)
			{
				object obj = arg1;
				if (obj is string)
				{
					reference = ref *(_003F*)IL2CPP.ManagedStringToIl2Cpp(obj as string);
				}
				else
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(obj as Il2CppObjectBase);
					reference = ref *(_003F*)intPtr;
					if (intPtr != (System.IntPtr)0)
					{
						reference = ref *(_003F*)intPtr;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr)))
						{
							reference = ref *(_003F*)IL2CPP.il2cpp_object_unbox(intPtr);
						}
					}
				}
			}
			else
			{
				reference = ref arg1;
			}
			*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return IL2CPP.PointerToValueGeneric<TResult>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107206, XrefRangeEnd = 107207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppSystem.IAsyncResult BeginInvoke(T1 arg1, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
		{
			//IL_0070->IL0075: Incompatible stack types: I vs Ref
			//IL_004c->IL0075: Incompatible stack types: I vs Ref
			//IL_0059->IL0075: Incompatible stack types: I vs Ref
			//IL_0063->IL0075: Incompatible stack types: I vs Ref
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			ref T1 reference;
			if (!typeof(T1).IsValueType)
			{
				object obj = arg1;
				if (obj is string)
				{
					reference = ref *(_003F*)IL2CPP.ManagedStringToIl2Cpp(obj as string);
				}
				else
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(obj as Il2CppObjectBase);
					reference = ref *(_003F*)intPtr;
					if (intPtr != (System.IntPtr)0)
					{
						reference = ref *(_003F*)intPtr;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr)))
						{
							reference = ref *(_003F*)IL2CPP.il2cpp_object_unbox(intPtr);
						}
					}
				}
			}
			else
			{
				reference = ref arg1;
			}
			*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(@object);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T1_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr2 != (System.IntPtr)0) ? new Il2CppSystem.IAsyncResult(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe TResult EndInvoke(Il2CppSystem.IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_TResult_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return IL2CPP.PointerToValueGeneric<TResult>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
		}

		static Func()
		{
			Il2CppClassPointerStore<Func<T1, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, "Func`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			})).TypeHandle.value);
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func<T1, TResult>>.NativeClassPtr, 100669886);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func<T1, TResult>>.NativeClassPtr, 100669887);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T1_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func<T1, TResult>>.NativeClassPtr, 100669888);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_TResult_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func<T1, TResult>>.NativeClassPtr, 100669889);
		}

		public Func(System.IntPtr P_0)
			: base(P_0)
		{
		}

		public static implicit operator Func<T1, TResult>(System.Func<T1, TResult> P_0)
		{
			return DelegateSupport.ConvertDelegate<Func<T1, TResult>>(P_0);
		}

		public static Func<T1, TResult> operator +(Func<T1, TResult> P_0, Func<T1, TResult> P_1)
		{
			return Il2CppSystem.Delegate.Combine(P_0, P_1).Cast<Func<T1, TResult>>();
		}

		public static Func<T1, TResult> operator -(Func<T1, TResult> P_0, Func<T1, TResult> P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<Func<T1, TResult>>();
			}
			return (Func<T1, TResult>)obj;
		}
	}

	public class BiasLerpContext : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_lastBias;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastExponent;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BiasLerpContext>.NativeClassPtr));

		public unsafe float lastBias
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastBias);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastBias)) = num;
			}
		}

		public unsafe float lastExponent
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastExponent);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastExponent)) = num;
			}
		}

		[CallerCount(0)]
		public unsafe BiasLerpContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BiasLerpContext>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static BiasLerpContext()
		{
			Il2CppClassPointerStore<BiasLerpContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, "BiasLerpContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BiasLerpContext>.NativeClassPtr);
			NativeFieldInfoPtr_lastBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BiasLerpContext>.NativeClassPtr, "lastBias");
			NativeFieldInfoPtr_lastExponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BiasLerpContext>.NativeClassPtr, "lastExponent");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BiasLerpContext>.NativeClassPtr, 100669890);
		}

		public BiasLerpContext(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_CloneObject_Public_Static_T_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_CloneObject_Public_Static_T_T_0, Il2CppClassPointerStore<CommonTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_CloneObjectFast_Public_Static_T_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_CloneObjectFast_Public_Static_T_T_0, Il2CppClassPointerStore<CommonTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_CopyObjectOverwrite_Public_Static_Void_T_byref_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_CopyObjectOverwrite_Public_Static_Void_T_byref_T_0, Il2CppClassPointerStore<CommonTools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_colors;

	private static readonly System.IntPtr NativeFieldInfoPtr__cachedIL;

	private static readonly System.IntPtr NativeMethodInfoPtr_HexToDecimal_Public_Static_Int32_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseColor_Public_Static_Color_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClampAngle_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClampAngle360_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FastAbs_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Vector3Equals_Public_Static_Boolean_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MaxAbs_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MinAbs_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawCrossMark_Public_Static_Void_Vector3_Transform_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawCrossMark_Public_Static_Void_Vector3_Vector3_Vector3_Vector3_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Lin2Log_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Lin2Log_Public_Static_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CloneObject_Public_Static_T_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CloneObjectFast_Public_Static_T_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyObjectOverwrite_Public_Static_Void_T_byref_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FastLerp_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LinearLerp_Public_Static_Single_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LinearLerp_Public_Static_Single_Vector2_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CubicLerp_Public_Static_Single_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CubicLerp_Public_Static_Single_Vector2_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TangentLerp_Public_Static_Single_Single_Single_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TangentLerp_Public_Static_Single_Vector2_Vector2_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SmoothStep_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SmootherStep_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HermiteLerp_Public_Static_Single_Single_Single_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Bezier_Public_Static_Vector3_ArrayOf_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BezierTangent_Public_Static_Vector3_ArrayOf_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BezierNormal_Public_Static_Vector3_ArrayOf_Vector3_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BiasWithContext_Private_Static_Single_Single_Single_BiasLerpContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BiasRaw_Private_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BiasedLerp_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BiasedLerp_Public_Static_Single_Single_Single_BiasLerpContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMultiplier_Private_Static_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FloorDecimals_Public_Static_Single_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FloorDecimals_Public_Static_Vector3_Vector3_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RoundDecimals_Public_Static_Single_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RoundDecimals_Public_Static_Vector3_Vector3_Int32_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CommonTools>.NativeClassPtr));

	public unsafe static Dictionary<string, Color> m_colors
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_colors, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Dictionary<string, Color>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_colors, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Dictionary<Il2CppSystem.Type, Il2CppSystem.Delegate> _cachedIL
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__cachedIL, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Dictionary<Il2CppSystem.Type, Il2CppSystem.Delegate>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__cachedIL, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 107207, RefRangeEnd = 107215, XrefRangeStart = 107207, XrefRangeEnd = 107207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int HexToDecimal(char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HexToDecimal_Public_Static_Int32_Char_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107215, XrefRangeEnd = 107236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color ParseColor(string col)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(col);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseColor_Public_Static_Color_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107236, XrefRangeEnd = 107237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ClampAngle(float angle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&angle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClampAngle_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107237, XrefRangeEnd = 107238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ClampAngle360(float angle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&angle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClampAngle360_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float FastAbs(float x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FastAbs_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static bool Vector3Equals(Vector3 a, Vector3 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Vector3Equals_Public_Static_Boolean_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107238, XrefRangeEnd = 107241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float MaxAbs(float a, float b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MaxAbs_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107241, XrefRangeEnd = 107244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float MinAbs(float a, float b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MinAbs_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 107251, RefRangeEnd = 107254, XrefRangeStart = 107244, XrefRangeEnd = 107251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawCrossMark(Vector3 pos, Transform trans, Color col, [Optional] float length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&pos);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(trans);
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawCrossMark_Public_Static_Void_Vector3_Transform_Color_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 107285, RefRangeEnd = 107287, XrefRangeStart = 107254, XrefRangeEnd = 107285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawCrossMark(Vector3 pos, Vector3 forward, Vector3 right, Vector3 up, Color col, [Optional] float length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&pos);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &forward;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &up;
		*(Color**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawCrossMark_Public_Static_Void_Vector3_Vector3_Vector3_Vector3_Color_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 107291, RefRangeEnd = 107300, XrefRangeStart = 107287, XrefRangeEnd = 107291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Lin2Log(float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Lin2Log_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107300, XrefRangeEnd = 107306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 Lin2Log(Vector3 val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Lin2Log_Public_Static_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107306, XrefRangeEnd = 107330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T CloneObject<T>(T source)
	{
		//IL_0069->IL006e: Incompatible stack types: I vs Ref
		//IL_0045->IL006e: Incompatible stack types: I vs Ref
		//IL_0052->IL006e: Incompatible stack types: I vs Ref
		//IL_005c->IL006e: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = source;
			if (obj is string)
			{
				reference = ref *(_003F*)IL2CPP.ManagedStringToIl2Cpp(obj as string);
			}
			else
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(obj as Il2CppObjectBase);
				reference = ref *(_003F*)intPtr;
				if (intPtr != (System.IntPtr)0)
				{
					reference = ref *(_003F*)intPtr;
					if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr)))
					{
						reference = ref *(_003F*)IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}
			}
		}
		else
		{
			reference = ref source;
		}
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_CloneObject_Public_Static_T_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.PointerToValueGeneric<T>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107330, XrefRangeEnd = 107351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T CloneObjectFast<T>(T myObject)
	{
		//IL_0069->IL006e: Incompatible stack types: I vs Ref
		//IL_0045->IL006e: Incompatible stack types: I vs Ref
		//IL_0052->IL006e: Incompatible stack types: I vs Ref
		//IL_005c->IL006e: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = myObject;
			if (obj is string)
			{
				reference = ref *(_003F*)IL2CPP.ManagedStringToIl2Cpp(obj as string);
			}
			else
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(obj as Il2CppObjectBase);
				reference = ref *(_003F*)intPtr;
				if (intPtr != (System.IntPtr)0)
				{
					reference = ref *(_003F*)intPtr;
					if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr)))
					{
						reference = ref *(_003F*)IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}
			}
		}
		else
		{
			reference = ref myObject;
		}
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_CloneObjectFast_Public_Static_T_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.PointerToValueGeneric<T>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
	}

	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 107353, RefRangeEnd = 107382, XrefRangeStart = 107351, XrefRangeEnd = 107353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyObjectOverwrite<T>(T source, ref T target)
	{
		//IL_0069->IL006e: Incompatible stack types: I vs Ref
		//IL_0045->IL006e: Incompatible stack types: I vs Ref
		//IL_0052->IL006e: Incompatible stack types: I vs Ref
		//IL_005c->IL006e: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = source;
			if (obj is string)
			{
				reference = ref *(_003F*)IL2CPP.ManagedStringToIl2Cpp(obj as string);
			}
			else
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(obj as Il2CppObjectBase);
				reference = ref *(_003F*)intPtr;
				if (intPtr != (System.IntPtr)0)
				{
					reference = ref *(_003F*)intPtr;
					if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr)))
					{
						reference = ref *(_003F*)IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}
			}
		}
		else
		{
			reference = ref source;
		}
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(System.Runtime.CompilerServices.Unsafe.As<T, Il2CppObjectBase>(ref target));
		*(System.IntPtr**)num = &intPtr2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_CopyObjectOverwrite_Public_Static_Void_T_byref_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr4 = intPtr2;
		System.Runtime.CompilerServices.Unsafe.As<T, object>(ref target) = ((intPtr4 == (System.IntPtr)0) ? ((T)null) : new T(intPtr4));
	}

	[CallerCount(0)]
	public unsafe static float FastLerp(float from, float to, float t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&from);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FastLerp_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float LinearLerp(float x0, float y0, float x1, float y1, float x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&x0);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y0;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y1;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LinearLerp_Public_Static_Single_Single_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107382, XrefRangeEnd = 107385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float LinearLerp(Vector2 from, Vector2 to, float t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&from);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LinearLerp_Public_Static_Single_Vector2_Vector2_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float CubicLerp(float x0, float y0, float x1, float y1, float x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&x0);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y0;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y1;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CubicLerp_Public_Static_Single_Single_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107385, XrefRangeEnd = 107388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CubicLerp(Vector2 from, Vector2 to, float t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&from);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CubicLerp_Public_Static_Single_Vector2_Vector2_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 107388, RefRangeEnd = 107390, XrefRangeStart = 107388, XrefRangeEnd = 107388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float TangentLerp(float x0, float y0, float x1, float y1, float a, float b, float x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&x0);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y0;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y1;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &a;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TangentLerp_Public_Static_Single_Single_Single_Single_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107390, XrefRangeEnd = 107394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float TangentLerp(Vector2 from, Vector2 to, float a, float b, float t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&from);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &a;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TangentLerp_Public_Static_Single_Vector2_Vector2_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107394, XrefRangeEnd = 107395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float SmoothStep(float from, float to, float t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&from);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SmoothStep_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107395, XrefRangeEnd = 107396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float SmootherStep(float from, float to, float t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&from);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SmootherStep_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float HermiteLerp(float x0, float y0, float x1, float y1, float outTangent, float inTangent, float x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&x0);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y0;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y1;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &outTangent;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &inTangent;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HermiteLerp_Public_Static_Single_Single_Single_Single_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static Vector3 Bezier(Il2CppStructArray<Vector3> points, float t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(points);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Bezier_Public_Static_Vector3_ArrayOf_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 107400, RefRangeEnd = 107401, XrefRangeStart = 107396, XrefRangeEnd = 107400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 BezierTangent(Il2CppStructArray<Vector3> points, float t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(points);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BezierTangent_Public_Static_Vector3_ArrayOf_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107401, XrefRangeEnd = 107409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 BezierNormal(Il2CppStructArray<Vector3> points, float t, Vector3 up)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(points);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &up;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BezierNormal_Public_Static_Vector3_ArrayOf_Vector3_Single_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 107409, RefRangeEnd = 107411, XrefRangeStart = 107409, XrefRangeEnd = 107409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float BiasWithContext(float x, float bias, BiasLerpContext context)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bias;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(context);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BiasWithContext_Private_Static_Single_Single_Single_BiasLerpContext_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 107411, RefRangeEnd = 107413, XrefRangeStart = 107411, XrefRangeEnd = 107411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float BiasRaw(float x, float bias)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bias;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BiasRaw_Private_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 107420, RefRangeEnd = 107423, XrefRangeStart = 107413, XrefRangeEnd = 107420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float BiasedLerp(float x, float bias)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bias;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BiasedLerp_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 107430, RefRangeEnd = 107433, XrefRangeStart = 107423, XrefRangeEnd = 107430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float BiasedLerp(float x, float bias, BiasLerpContext context)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bias;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(context);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BiasedLerp_Public_Static_Single_Single_Single_BiasLerpContext_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107433, XrefRangeEnd = 107434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetMultiplier(int decimals)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&decimals);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMultiplier_Private_Static_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107434, XrefRangeEnd = 107444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float FloorDecimals(float value, int decimals)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &decimals;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FloorDecimals_Public_Static_Single_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107444, XrefRangeEnd = 107456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 FloorDecimals(Vector3 value, int decimals)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &decimals;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FloorDecimals_Public_Static_Vector3_Vector3_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107456, XrefRangeEnd = 107466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float RoundDecimals(float value, int decimals)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &decimals;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RoundDecimals_Public_Static_Single_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107466, XrefRangeEnd = 107478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 RoundDecimals(Vector3 value, int decimals)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &decimals;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RoundDecimals_Public_Static_Vector3_Vector3_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static CommonTools()
	{
		Il2CppClassPointerStore<CommonTools>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CommonTools");
		NativeFieldInfoPtr_m_colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, "m_colors");
		NativeFieldInfoPtr__cachedIL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, "_cachedIL");
		NativeMethodInfoPtr_HexToDecimal_Public_Static_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669849);
		NativeMethodInfoPtr_ParseColor_Public_Static_Color_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669850);
		NativeMethodInfoPtr_ClampAngle_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669851);
		NativeMethodInfoPtr_ClampAngle360_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669852);
		NativeMethodInfoPtr_FastAbs_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669853);
		NativeMethodInfoPtr_Vector3Equals_Public_Static_Boolean_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669854);
		NativeMethodInfoPtr_MaxAbs_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669855);
		NativeMethodInfoPtr_MinAbs_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669856);
		NativeMethodInfoPtr_DrawCrossMark_Public_Static_Void_Vector3_Transform_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669857);
		NativeMethodInfoPtr_DrawCrossMark_Public_Static_Void_Vector3_Vector3_Vector3_Vector3_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669858);
		NativeMethodInfoPtr_Lin2Log_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669859);
		NativeMethodInfoPtr_Lin2Log_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669860);
		NativeMethodInfoPtr_CloneObject_Public_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669861);
		NativeMethodInfoPtr_CloneObjectFast_Public_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669862);
		NativeMethodInfoPtr_CopyObjectOverwrite_Public_Static_Void_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669863);
		NativeMethodInfoPtr_FastLerp_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669864);
		NativeMethodInfoPtr_LinearLerp_Public_Static_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669865);
		NativeMethodInfoPtr_LinearLerp_Public_Static_Single_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669866);
		NativeMethodInfoPtr_CubicLerp_Public_Static_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669867);
		NativeMethodInfoPtr_CubicLerp_Public_Static_Single_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669868);
		NativeMethodInfoPtr_TangentLerp_Public_Static_Single_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669869);
		NativeMethodInfoPtr_TangentLerp_Public_Static_Single_Vector2_Vector2_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669870);
		NativeMethodInfoPtr_SmoothStep_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669871);
		NativeMethodInfoPtr_SmootherStep_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669872);
		NativeMethodInfoPtr_HermiteLerp_Public_Static_Single_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669873);
		NativeMethodInfoPtr_Bezier_Public_Static_Vector3_ArrayOf_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669874);
		NativeMethodInfoPtr_BezierTangent_Public_Static_Vector3_ArrayOf_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669875);
		NativeMethodInfoPtr_BezierNormal_Public_Static_Vector3_ArrayOf_Vector3_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669876);
		NativeMethodInfoPtr_BiasWithContext_Private_Static_Single_Single_Single_BiasLerpContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669877);
		NativeMethodInfoPtr_BiasRaw_Private_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669878);
		NativeMethodInfoPtr_BiasedLerp_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669879);
		NativeMethodInfoPtr_BiasedLerp_Public_Static_Single_Single_Single_BiasLerpContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669880);
		NativeMethodInfoPtr_GetMultiplier_Private_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669881);
		NativeMethodInfoPtr_FloorDecimals_Public_Static_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669882);
		NativeMethodInfoPtr_FloorDecimals_Public_Static_Vector3_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669883);
		NativeMethodInfoPtr_RoundDecimals_Public_Static_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669884);
		NativeMethodInfoPtr_RoundDecimals_Public_Static_Vector3_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonTools>.NativeClassPtr, 100669885);
	}

	public CommonTools(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
