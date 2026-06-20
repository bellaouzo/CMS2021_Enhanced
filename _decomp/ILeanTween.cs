using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class ILeanTween : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_removeTween_Public_Abstract_Virtual_New_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_removeTween_Public_Abstract_Virtual_New_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_Public_Abstract_Virtual_New_ArrayOf_Vector3_ArrayOf_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_closestRot_Public_Abstract_Virtual_New_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_cancelAll_Public_Abstract_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_cancelAll_Public_Abstract_Virtual_New_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_cancel_Public_Abstract_Virtual_New_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_cancel_Public_Abstract_Virtual_New_Void_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_cancel_Public_Abstract_Virtual_New_Void_GameObject_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_cancel_Public_Abstract_Virtual_New_Void_LTRect_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_cancel_Public_Abstract_Virtual_New_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_cancel_Public_Abstract_Virtual_New_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_descr_Public_Abstract_Virtual_New_LTDescr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_description_Public_Abstract_Virtual_New_LTDescr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_descriptions_Public_Abstract_Virtual_New_ArrayOf_LTDescr_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_pause_Public_Abstract_Virtual_New_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_pause_Public_Abstract_Virtual_New_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_pauseAll_Public_Abstract_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_resumeAll_Public_Abstract_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_resume_Public_Abstract_Virtual_New_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_resume_Public_Abstract_Virtual_New_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isTweening_Public_Abstract_Virtual_New_Boolean_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isTweening_Public_Abstract_Virtual_New_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isTweening_Public_Abstract_Virtual_New_Boolean_LTRect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_drawBezierPath_Public_Abstract_Virtual_New_Void_Vector3_Vector3_Vector3_Vector3_Single_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_options_Public_Abstract_Virtual_New_LTDescr_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_options_Public_Abstract_Virtual_New_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_tweenEmpty_Public_Abstract_Virtual_New_get_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_alpha_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_alpha_Public_Abstract_Virtual_New_LTDescr_LTRect_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_alphaVertex_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_color_Public_Abstract_Virtual_New_LTDescr_GameObject_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_delayedCall_Public_Abstract_Virtual_New_LTDescr_Single_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_delayedCall_Public_Abstract_Virtual_New_LTDescr_Single_Action_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_delayedCall_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_delayedCall_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Action_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_destroyAfter_Public_Abstract_Virtual_New_LTDescr_LTRect_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_move_Public_Abstract_Virtual_New_LTDescr_GameObject_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_move_Public_Abstract_Virtual_New_LTDescr_GameObject_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_move_Public_Abstract_Virtual_New_LTDescr_GameObject_ArrayOf_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_move_Public_Abstract_Virtual_New_LTDescr_GameObject_LTBezierPath_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_move_Public_Abstract_Virtual_New_LTDescr_GameObject_LTSpline_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveSpline_Public_Abstract_Virtual_New_LTDescr_GameObject_ArrayOf_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveSplineLocal_Public_Abstract_Virtual_New_LTDescr_GameObject_ArrayOf_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_move_Public_Abstract_Virtual_New_LTDescr_LTRect_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveMargin_Public_Abstract_Virtual_New_LTDescr_LTRect_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveX_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveY_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveZ_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveLocal_Public_Abstract_Virtual_New_LTDescr_GameObject_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveLocal_Public_Abstract_Virtual_New_LTDescr_GameObject_ArrayOf_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveLocalX_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveLocalY_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveLocalZ_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveLocal_Public_Abstract_Virtual_New_LTDescr_GameObject_LTBezierPath_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveLocal_Public_Abstract_Virtual_New_LTDescr_GameObject_LTSpline_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_move_Public_Abstract_Virtual_New_LTDescr_GameObject_Transform_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_rotate_Public_Abstract_Virtual_New_LTDescr_GameObject_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_rotate_Public_Abstract_Virtual_New_LTDescr_LTRect_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_rotateLocal_Public_Abstract_Virtual_New_LTDescr_GameObject_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_rotateX_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_rotateY_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_rotateZ_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_rotateAround_Public_Abstract_Virtual_New_LTDescr_GameObject_Vector3_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_rotateAroundLocal_Public_Abstract_Virtual_New_LTDescr_GameObject_Vector3_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_scale_Public_Abstract_Virtual_New_LTDescr_GameObject_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_scale_Public_Abstract_Virtual_New_LTDescr_LTRect_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_scaleX_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_scaleY_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_scaleZ_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Abstract_Virtual_New_LTDescr_GameObject_Vector2_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Abstract_Virtual_New_LTDescr_GameObject_Vector3_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Abstract_Virtual_New_LTDescr_GameObject_Color_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Abstract_Virtual_New_LTDescr_GameObject_Action_1_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Abstract_Virtual_New_LTDescr_GameObject_Action_2_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Abstract_Virtual_New_LTDescr_GameObject_Action_1_Color_Color_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Abstract_Virtual_New_LTDescr_GameObject_Action_1_Vector2_Vector2_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Abstract_Virtual_New_LTDescr_GameObject_Action_1_Vector3_Vector3_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Abstract_Virtual_New_LTDescr_GameObject_Action_2_Single_Object_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_delayedSound_Public_Abstract_Virtual_New_LTDescr_AudioClip_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_delayedSound_Public_Abstract_Virtual_New_LTDescr_GameObject_AudioClip_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_play_Public_Abstract_Virtual_New_LTDescr_RectTransform_ArrayOf_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_textAlpha_Public_Abstract_Virtual_New_LTDescr_RectTransform_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_textColor_Public_Abstract_Virtual_New_LTDescr_RectTransform_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_move_Public_Abstract_Virtual_New_LTDescr_RectTransform_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveX_Public_Abstract_Virtual_New_LTDescr_RectTransform_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveY_Public_Abstract_Virtual_New_LTDescr_RectTransform_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveZ_Public_Abstract_Virtual_New_LTDescr_RectTransform_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_rotate_Public_Abstract_Virtual_New_LTDescr_RectTransform_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_rotateAround_Public_Abstract_Virtual_New_LTDescr_RectTransform_Vector3_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_rotateAroundLocal_Public_Abstract_Virtual_New_LTDescr_RectTransform_Vector3_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_scale_Public_Abstract_Virtual_New_LTDescr_RectTransform_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_alpha_Public_Abstract_Virtual_New_LTDescr_RectTransform_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_color_Public_Abstract_Virtual_New_LTDescr_RectTransform_Color_Single_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr));

	public unsafe GameObject tweenEmpty
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_get_tweenEmpty_Public_Abstract_Virtual_New_get_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
	}

	[CallerCount(0)]
	public unsafe void removeTween(int i, int uniqueId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&i);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &uniqueId;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_removeTween_Public_Abstract_Virtual_New_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void removeTween(int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_removeTween_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe Il2CppStructArray<Vector3> add(Il2CppStructArray<Vector3> a, Vector3 b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_add_Public_Abstract_Virtual_New_ArrayOf_Vector3_ArrayOf_Vector3_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Vector3>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe float closestRot(float from, float to)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&from);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_closestRot_Public_Abstract_Virtual_New_Single_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe void cancelAll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_cancelAll_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void cancelAll(bool callComplete)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&callComplete);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_cancelAll_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void cancel(GameObject gameObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_cancel_Public_Abstract_Virtual_New_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void cancel(GameObject gameObject, bool callOnComplete)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &callOnComplete;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_cancel_Public_Abstract_Virtual_New_Void_GameObject_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void cancel(GameObject gameObject, int uniqueId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &uniqueId;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_cancel_Public_Abstract_Virtual_New_Void_GameObject_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void cancel(LTRect ltRect, int uniqueId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ltRect);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &uniqueId;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_cancel_Public_Abstract_Virtual_New_Void_LTRect_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void cancel(int uniqueId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&uniqueId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_cancel_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void cancel(int uniqueId, bool callOnComplete)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&uniqueId);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &callOnComplete;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_cancel_Public_Abstract_Virtual_New_Void_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe LTDescr descr(int uniqueId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&uniqueId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_descr_Public_Abstract_Virtual_New_LTDescr_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr description(int uniqueId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&uniqueId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_description_Public_Abstract_Virtual_New_LTDescr_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe Il2CppReferenceArray<LTDescr> descriptions(GameObject gameObject = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_descriptions_Public_Abstract_Virtual_New_ArrayOf_LTDescr_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<LTDescr>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe void pause(int uniqueId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&uniqueId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_pause_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void pause(GameObject gameObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_pause_Public_Abstract_Virtual_New_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void pauseAll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_pauseAll_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void resumeAll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_resumeAll_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void resume(int uniqueId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&uniqueId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_resume_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void resume(GameObject gameObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_resume_Public_Abstract_Virtual_New_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool isTweening(GameObject gameObject = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_isTweening_Public_Abstract_Virtual_New_Boolean_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool isTweening(int uniqueId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&uniqueId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_isTweening_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool isTweening(LTRect ltRect)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ltRect);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_isTweening_Public_Abstract_Virtual_New_Boolean_LTRect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, [Optional] float arrowSize, Transform arrowTransform = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&a);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &d;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &arrowSize;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(arrowTransform);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_drawBezierPath_Public_Abstract_Virtual_New_Void_Vector3_Vector3_Vector3_Vector3_Single_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe LTDescr options(LTDescr seed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(seed);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_options_Public_Abstract_Virtual_New_LTDescr_LTDescr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr options()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_options_Public_Abstract_Virtual_New_LTDescr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr alpha(GameObject gameObject, float to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_alpha_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr alpha(LTRect ltRect, float to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ltRect);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_alpha_Public_Abstract_Virtual_New_LTDescr_LTRect_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr alphaVertex(GameObject gameObject, float to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_alphaVertex_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr color(GameObject gameObject, Color to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_color_Public_Abstract_Virtual_New_LTDescr_GameObject_Color_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr delayedCall(float delayTime, Il2CppSystem.Action callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&delayTime);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(callback);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_delayedCall_Public_Abstract_Virtual_New_LTDescr_Single_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr delayedCall(float delayTime, Il2CppSystem.Action<Il2CppSystem.Object> callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&delayTime);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(callback);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_delayedCall_Public_Abstract_Virtual_New_LTDescr_Single_Action_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr delayedCall(GameObject gameObject, float delayTime, Il2CppSystem.Action callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delayTime;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(callback);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_delayedCall_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr delayedCall(GameObject gameObject, float delayTime, Il2CppSystem.Action<Il2CppSystem.Object> callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delayTime;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(callback);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_delayedCall_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Action_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr destroyAfter(LTRect rect, float delayTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delayTime;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_destroyAfter_Public_Abstract_Virtual_New_LTDescr_LTRect_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr move(GameObject gameObject, Vector3 to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_move_Public_Abstract_Virtual_New_LTDescr_GameObject_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr move(GameObject gameObject, Vector2 to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_move_Public_Abstract_Virtual_New_LTDescr_GameObject_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr move(GameObject gameObject, Il2CppStructArray<Vector3> to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(to);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_move_Public_Abstract_Virtual_New_LTDescr_GameObject_ArrayOf_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr move(GameObject gameObject, LTBezierPath to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(to);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_move_Public_Abstract_Virtual_New_LTDescr_GameObject_LTBezierPath_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr move(GameObject gameObject, LTSpline to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(to);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_move_Public_Abstract_Virtual_New_LTDescr_GameObject_LTSpline_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr moveSpline(GameObject gameObject, Il2CppStructArray<Vector3> to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(to);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_moveSpline_Public_Abstract_Virtual_New_LTDescr_GameObject_ArrayOf_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr moveSplineLocal(GameObject gameObject, Il2CppStructArray<Vector3> to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(to);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_moveSplineLocal_Public_Abstract_Virtual_New_LTDescr_GameObject_ArrayOf_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr move(LTRect ltRect, Vector2 to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ltRect);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_move_Public_Abstract_Virtual_New_LTDescr_LTRect_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr moveMargin(LTRect ltRect, Vector2 to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ltRect);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_moveMargin_Public_Abstract_Virtual_New_LTDescr_LTRect_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr moveX(GameObject gameObject, float to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_moveX_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr moveY(GameObject gameObject, float to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_moveY_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr moveZ(GameObject gameObject, float to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_moveZ_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr moveLocal(GameObject gameObject, Vector3 to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_moveLocal_Public_Abstract_Virtual_New_LTDescr_GameObject_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr moveLocal(GameObject gameObject, Il2CppStructArray<Vector3> to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(to);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_moveLocal_Public_Abstract_Virtual_New_LTDescr_GameObject_ArrayOf_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr moveLocalX(GameObject gameObject, float to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_moveLocalX_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr moveLocalY(GameObject gameObject, float to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_moveLocalY_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr moveLocalZ(GameObject gameObject, float to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_moveLocalZ_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(to);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_moveLocal_Public_Abstract_Virtual_New_LTDescr_GameObject_LTBezierPath_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr moveLocal(GameObject gameObject, LTSpline to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(to);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_moveLocal_Public_Abstract_Virtual_New_LTDescr_GameObject_LTSpline_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr move(GameObject gameObject, Transform to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(to);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_move_Public_Abstract_Virtual_New_LTDescr_GameObject_Transform_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr rotate(GameObject gameObject, Vector3 to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_rotate_Public_Abstract_Virtual_New_LTDescr_GameObject_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr rotate(LTRect ltRect, float to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ltRect);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_rotate_Public_Abstract_Virtual_New_LTDescr_LTRect_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_rotateLocal_Public_Abstract_Virtual_New_LTDescr_GameObject_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr rotateX(GameObject gameObject, float to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_rotateX_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr rotateY(GameObject gameObject, float to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_rotateY_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr rotateZ(GameObject gameObject, float to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_rotateZ_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr rotateAround(GameObject gameObject, Vector3 axis, float add, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &axis;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &add;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_rotateAround_Public_Abstract_Virtual_New_LTDescr_GameObject_Vector3_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, float add, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &axis;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &add;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_rotateAroundLocal_Public_Abstract_Virtual_New_LTDescr_GameObject_Vector3_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr scale(GameObject gameObject, Vector3 to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_scale_Public_Abstract_Virtual_New_LTDescr_GameObject_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr scale(LTRect ltRect, Vector2 to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ltRect);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_scale_Public_Abstract_Virtual_New_LTDescr_LTRect_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr scaleX(GameObject gameObject, float to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_scaleX_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr scaleY(GameObject gameObject, float to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_scaleY_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr scaleZ(GameObject gameObject, float to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_scaleZ_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr value(GameObject gameObject, float from, float to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_value_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_value_Public_Abstract_Virtual_New_LTDescr_GameObject_Vector2_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_value_Public_Abstract_Virtual_New_LTDescr_GameObject_Vector3_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr value(GameObject gameObject, Color from, Color to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_value_Public_Abstract_Virtual_New_LTDescr_GameObject_Color_Color_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr value(GameObject gameObject, Il2CppSystem.Action<float> callOnUpdate, float from, float to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(callOnUpdate);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_value_Public_Abstract_Virtual_New_LTDescr_GameObject_Action_1_Single_Single_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr value(GameObject gameObject, Il2CppSystem.Action<float, float> callOnUpdateRatio, float from, float to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(callOnUpdateRatio);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_value_Public_Abstract_Virtual_New_LTDescr_GameObject_Action_2_Single_Single_Single_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr value(GameObject gameObject, Il2CppSystem.Action<Color> callOnUpdate, Color from, Color to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(callOnUpdate);
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(Color**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_value_Public_Abstract_Virtual_New_LTDescr_GameObject_Action_1_Color_Color_Color_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr value(GameObject gameObject, Il2CppSystem.Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(callOnUpdate);
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(Vector2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_value_Public_Abstract_Virtual_New_LTDescr_GameObject_Action_1_Vector2_Vector2_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr value(GameObject gameObject, Il2CppSystem.Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(callOnUpdate);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_value_Public_Abstract_Virtual_New_LTDescr_GameObject_Action_1_Vector3_Vector3_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr value(GameObject gameObject, Il2CppSystem.Action<float, Il2CppSystem.Object> callOnUpdate, float from, float to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(callOnUpdate);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_value_Public_Abstract_Virtual_New_LTDescr_GameObject_Action_2_Single_Object_Single_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(audio);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &volume;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_delayedSound_Public_Abstract_Virtual_New_LTDescr_AudioClip_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, float volume)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(audio);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &volume;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_delayedSound_Public_Abstract_Virtual_New_LTDescr_GameObject_AudioClip_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr play(RectTransform rectTransform, Il2CppReferenceArray<Sprite> sprites)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(sprites);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_play_Public_Abstract_Virtual_New_LTDescr_RectTransform_ArrayOf_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr textAlpha(RectTransform rectTransform, float to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_textAlpha_Public_Abstract_Virtual_New_LTDescr_RectTransform_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr textColor(RectTransform rectTransform, Color to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_textColor_Public_Abstract_Virtual_New_LTDescr_RectTransform_Color_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr move(RectTransform rectTrans, Vector3 to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_move_Public_Abstract_Virtual_New_LTDescr_RectTransform_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr moveX(RectTransform rectTrans, float to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_moveX_Public_Abstract_Virtual_New_LTDescr_RectTransform_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr moveY(RectTransform rectTrans, float to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_moveY_Public_Abstract_Virtual_New_LTDescr_RectTransform_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr moveZ(RectTransform rectTrans, float to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_moveZ_Public_Abstract_Virtual_New_LTDescr_RectTransform_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr rotate(RectTransform rectTrans, float to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_rotate_Public_Abstract_Virtual_New_LTDescr_RectTransform_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &axis;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_rotateAround_Public_Abstract_Virtual_New_LTDescr_RectTransform_Vector3_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &axis;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_rotateAroundLocal_Public_Abstract_Virtual_New_LTDescr_RectTransform_Vector3_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr scale(RectTransform rectTrans, Vector3 to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_scale_Public_Abstract_Virtual_New_LTDescr_RectTransform_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr alpha(RectTransform rectTrans, float to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_alpha_Public_Abstract_Virtual_New_LTDescr_RectTransform_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe LTDescr color(RectTransform rectTrans, Color to, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_color_Public_Abstract_Virtual_New_LTDescr_RectTransform_Color_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	static ILeanTween()
	{
		Il2CppClassPointerStore<ILeanTween>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "ILeanTween");
		NativeMethodInfoPtr_removeTween_Public_Abstract_Virtual_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663406);
		NativeMethodInfoPtr_removeTween_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663407);
		NativeMethodInfoPtr_add_Public_Abstract_Virtual_New_ArrayOf_Vector3_ArrayOf_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663408);
		NativeMethodInfoPtr_closestRot_Public_Abstract_Virtual_New_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663409);
		NativeMethodInfoPtr_cancelAll_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663410);
		NativeMethodInfoPtr_cancelAll_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663411);
		NativeMethodInfoPtr_cancel_Public_Abstract_Virtual_New_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663412);
		NativeMethodInfoPtr_cancel_Public_Abstract_Virtual_New_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663413);
		NativeMethodInfoPtr_cancel_Public_Abstract_Virtual_New_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663414);
		NativeMethodInfoPtr_cancel_Public_Abstract_Virtual_New_Void_LTRect_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663415);
		NativeMethodInfoPtr_cancel_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663416);
		NativeMethodInfoPtr_cancel_Public_Abstract_Virtual_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663417);
		NativeMethodInfoPtr_descr_Public_Abstract_Virtual_New_LTDescr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663418);
		NativeMethodInfoPtr_description_Public_Abstract_Virtual_New_LTDescr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663419);
		NativeMethodInfoPtr_descriptions_Public_Abstract_Virtual_New_ArrayOf_LTDescr_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663420);
		NativeMethodInfoPtr_pause_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663421);
		NativeMethodInfoPtr_pause_Public_Abstract_Virtual_New_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663422);
		NativeMethodInfoPtr_pauseAll_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663423);
		NativeMethodInfoPtr_resumeAll_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663424);
		NativeMethodInfoPtr_resume_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663425);
		NativeMethodInfoPtr_resume_Public_Abstract_Virtual_New_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663426);
		NativeMethodInfoPtr_isTweening_Public_Abstract_Virtual_New_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663427);
		NativeMethodInfoPtr_isTweening_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663428);
		NativeMethodInfoPtr_isTweening_Public_Abstract_Virtual_New_Boolean_LTRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663429);
		NativeMethodInfoPtr_drawBezierPath_Public_Abstract_Virtual_New_Void_Vector3_Vector3_Vector3_Vector3_Single_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663430);
		NativeMethodInfoPtr_options_Public_Abstract_Virtual_New_LTDescr_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663431);
		NativeMethodInfoPtr_options_Public_Abstract_Virtual_New_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663432);
		NativeMethodInfoPtr_get_tweenEmpty_Public_Abstract_Virtual_New_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663433);
		NativeMethodInfoPtr_alpha_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663434);
		NativeMethodInfoPtr_alpha_Public_Abstract_Virtual_New_LTDescr_LTRect_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663435);
		NativeMethodInfoPtr_alphaVertex_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663436);
		NativeMethodInfoPtr_color_Public_Abstract_Virtual_New_LTDescr_GameObject_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663437);
		NativeMethodInfoPtr_delayedCall_Public_Abstract_Virtual_New_LTDescr_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663438);
		NativeMethodInfoPtr_delayedCall_Public_Abstract_Virtual_New_LTDescr_Single_Action_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663439);
		NativeMethodInfoPtr_delayedCall_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663440);
		NativeMethodInfoPtr_delayedCall_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Action_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663441);
		NativeMethodInfoPtr_destroyAfter_Public_Abstract_Virtual_New_LTDescr_LTRect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663442);
		NativeMethodInfoPtr_move_Public_Abstract_Virtual_New_LTDescr_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663443);
		NativeMethodInfoPtr_move_Public_Abstract_Virtual_New_LTDescr_GameObject_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663444);
		NativeMethodInfoPtr_move_Public_Abstract_Virtual_New_LTDescr_GameObject_ArrayOf_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663445);
		NativeMethodInfoPtr_move_Public_Abstract_Virtual_New_LTDescr_GameObject_LTBezierPath_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663446);
		NativeMethodInfoPtr_move_Public_Abstract_Virtual_New_LTDescr_GameObject_LTSpline_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663447);
		NativeMethodInfoPtr_moveSpline_Public_Abstract_Virtual_New_LTDescr_GameObject_ArrayOf_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663448);
		NativeMethodInfoPtr_moveSplineLocal_Public_Abstract_Virtual_New_LTDescr_GameObject_ArrayOf_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663449);
		NativeMethodInfoPtr_move_Public_Abstract_Virtual_New_LTDescr_LTRect_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663450);
		NativeMethodInfoPtr_moveMargin_Public_Abstract_Virtual_New_LTDescr_LTRect_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663451);
		NativeMethodInfoPtr_moveX_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663452);
		NativeMethodInfoPtr_moveY_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663453);
		NativeMethodInfoPtr_moveZ_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663454);
		NativeMethodInfoPtr_moveLocal_Public_Abstract_Virtual_New_LTDescr_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663455);
		NativeMethodInfoPtr_moveLocal_Public_Abstract_Virtual_New_LTDescr_GameObject_ArrayOf_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663456);
		NativeMethodInfoPtr_moveLocalX_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663457);
		NativeMethodInfoPtr_moveLocalY_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663458);
		NativeMethodInfoPtr_moveLocalZ_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663459);
		NativeMethodInfoPtr_moveLocal_Public_Abstract_Virtual_New_LTDescr_GameObject_LTBezierPath_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663460);
		NativeMethodInfoPtr_moveLocal_Public_Abstract_Virtual_New_LTDescr_GameObject_LTSpline_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663461);
		NativeMethodInfoPtr_move_Public_Abstract_Virtual_New_LTDescr_GameObject_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663462);
		NativeMethodInfoPtr_rotate_Public_Abstract_Virtual_New_LTDescr_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663463);
		NativeMethodInfoPtr_rotate_Public_Abstract_Virtual_New_LTDescr_LTRect_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663464);
		NativeMethodInfoPtr_rotateLocal_Public_Abstract_Virtual_New_LTDescr_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663465);
		NativeMethodInfoPtr_rotateX_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663466);
		NativeMethodInfoPtr_rotateY_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663467);
		NativeMethodInfoPtr_rotateZ_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663468);
		NativeMethodInfoPtr_rotateAround_Public_Abstract_Virtual_New_LTDescr_GameObject_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663469);
		NativeMethodInfoPtr_rotateAroundLocal_Public_Abstract_Virtual_New_LTDescr_GameObject_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663470);
		NativeMethodInfoPtr_scale_Public_Abstract_Virtual_New_LTDescr_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663471);
		NativeMethodInfoPtr_scale_Public_Abstract_Virtual_New_LTDescr_LTRect_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663472);
		NativeMethodInfoPtr_scaleX_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663473);
		NativeMethodInfoPtr_scaleY_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663474);
		NativeMethodInfoPtr_scaleZ_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663475);
		NativeMethodInfoPtr_value_Public_Abstract_Virtual_New_LTDescr_GameObject_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663476);
		NativeMethodInfoPtr_value_Public_Abstract_Virtual_New_LTDescr_GameObject_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663477);
		NativeMethodInfoPtr_value_Public_Abstract_Virtual_New_LTDescr_GameObject_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663478);
		NativeMethodInfoPtr_value_Public_Abstract_Virtual_New_LTDescr_GameObject_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663479);
		NativeMethodInfoPtr_value_Public_Abstract_Virtual_New_LTDescr_GameObject_Action_1_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663480);
		NativeMethodInfoPtr_value_Public_Abstract_Virtual_New_LTDescr_GameObject_Action_2_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663481);
		NativeMethodInfoPtr_value_Public_Abstract_Virtual_New_LTDescr_GameObject_Action_1_Color_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663482);
		NativeMethodInfoPtr_value_Public_Abstract_Virtual_New_LTDescr_GameObject_Action_1_Vector2_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663483);
		NativeMethodInfoPtr_value_Public_Abstract_Virtual_New_LTDescr_GameObject_Action_1_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663484);
		NativeMethodInfoPtr_value_Public_Abstract_Virtual_New_LTDescr_GameObject_Action_2_Single_Object_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663485);
		NativeMethodInfoPtr_delayedSound_Public_Abstract_Virtual_New_LTDescr_AudioClip_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663486);
		NativeMethodInfoPtr_delayedSound_Public_Abstract_Virtual_New_LTDescr_GameObject_AudioClip_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663487);
		NativeMethodInfoPtr_play_Public_Abstract_Virtual_New_LTDescr_RectTransform_ArrayOf_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663488);
		NativeMethodInfoPtr_textAlpha_Public_Abstract_Virtual_New_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663489);
		NativeMethodInfoPtr_textColor_Public_Abstract_Virtual_New_LTDescr_RectTransform_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663490);
		NativeMethodInfoPtr_move_Public_Abstract_Virtual_New_LTDescr_RectTransform_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663491);
		NativeMethodInfoPtr_moveX_Public_Abstract_Virtual_New_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663492);
		NativeMethodInfoPtr_moveY_Public_Abstract_Virtual_New_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663493);
		NativeMethodInfoPtr_moveZ_Public_Abstract_Virtual_New_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663494);
		NativeMethodInfoPtr_rotate_Public_Abstract_Virtual_New_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663495);
		NativeMethodInfoPtr_rotateAround_Public_Abstract_Virtual_New_LTDescr_RectTransform_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663496);
		NativeMethodInfoPtr_rotateAroundLocal_Public_Abstract_Virtual_New_LTDescr_RectTransform_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663497);
		NativeMethodInfoPtr_scale_Public_Abstract_Virtual_New_LTDescr_RectTransform_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663498);
		NativeMethodInfoPtr_alpha_Public_Abstract_Virtual_New_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663499);
		NativeMethodInfoPtr_color_Public_Abstract_Virtual_New_LTDescr_RectTransform_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILeanTween>.NativeClassPtr, 100663500);
	}

	public ILeanTween(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
