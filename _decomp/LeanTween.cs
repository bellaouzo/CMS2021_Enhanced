using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeanTween : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_throwErrors;

	private static readonly System.IntPtr NativeFieldInfoPtr_tau;

	private static readonly System.IntPtr NativeFieldInfoPtr_PI_DIV2;

	private static readonly System.IntPtr NativeFieldInfoPtr_tweens;

	private static readonly System.IntPtr NativeFieldInfoPtr_tweensFinished;

	private static readonly System.IntPtr NativeFieldInfoPtr_tween;

	private static readonly System.IntPtr NativeFieldInfoPtr_tweenMaxSearch;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxTweens;

	private static readonly System.IntPtr NativeFieldInfoPtr_frameRendered;

	private static readonly System.IntPtr NativeFieldInfoPtr__tweenEmpty;

	private static readonly System.IntPtr NativeFieldInfoPtr_dtEstimated;

	private static readonly System.IntPtr NativeFieldInfoPtr_dtManual;

	private static readonly System.IntPtr NativeFieldInfoPtr_dtActual;

	private static readonly System.IntPtr NativeFieldInfoPtr_i;

	private static readonly System.IntPtr NativeFieldInfoPtr_j;

	private static readonly System.IntPtr NativeFieldInfoPtr_finishedCnt;

	private static readonly System.IntPtr NativeFieldInfoPtr_punch;

	private static readonly System.IntPtr NativeFieldInfoPtr_shake;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxTweenReached;

	private static readonly System.IntPtr NativeFieldInfoPtr_startSearch;

	private static readonly System.IntPtr NativeFieldInfoPtr_d;

	private static readonly System.IntPtr NativeFieldInfoPtr_eventListeners;

	private static readonly System.IntPtr NativeFieldInfoPtr_goListeners;

	private static readonly System.IntPtr NativeFieldInfoPtr_eventsMaxSearch;

	private static readonly System.IntPtr NativeFieldInfoPtr_EVENTS_MAX;

	private static readonly System.IntPtr NativeFieldInfoPtr_LISTENERS_MAX;

	private static readonly System.IntPtr NativeFieldInfoPtr_INIT_LISTENERS_MAX;

	private static readonly System.IntPtr NativeMethodInfoPtr_init_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maxSearch_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maxSimulataneousTweens_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_tweensRunning_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_init_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_reset_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onLevelWasLoaded54_Private_Static_Void_Scene_LoadSceneMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_internalOnLevelWasLoaded_Private_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_update_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_removeTween_Public_Static_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_removeTween_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_Public_Static_ArrayOf_Vector3_ArrayOf_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_closestRot_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_cancelAll_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_cancelAll_Public_Static_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_cancel_Public_Static_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_cancel_Public_Static_Void_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_cancel_Public_Static_Void_GameObject_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_cancel_Public_Static_Void_LTRect_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_cancel_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_cancel_Public_Static_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_descr_Public_Static_LTDescr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_description_Public_Static_LTDescr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_descriptions_Public_Static_ArrayOf_LTDescr_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_pause_Public_Static_Void_GameObject_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_pause_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_pause_Public_Static_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_pauseAll_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_resumeAll_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_resume_Public_Static_Void_GameObject_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_resume_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_resume_Public_Static_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isTweening_Public_Static_Boolean_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isTweening_Public_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isTweening_Public_Static_Boolean_LTRect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_drawBezierPath_Public_Static_Void_Vector3_Vector3_Vector3_Vector3_Single_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_logError_Public_Static_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_options_Public_Static_LTDescr_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_options_Public_Static_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_tweenEmpty_Public_Static_get_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_pushNewTween_Private_Static_LTDescr_GameObject_Vector3_Single_LTDescr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_play_Public_Static_LTDescr_RectTransform_ArrayOf_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_alpha_Public_Static_LTDescr_GameObject_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_alpha_Public_Static_LTDescr_LTRect_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_textAlpha_Public_Static_LTDescr_RectTransform_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_alphaText_Public_Static_LTDescr_RectTransform_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_alphaCanvas_Public_Static_LTDescr_CanvasGroup_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_alphaVertex_Public_Static_LTDescr_GameObject_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_color_Public_Static_LTDescr_GameObject_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_textColor_Public_Static_LTDescr_RectTransform_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_colorText_Public_Static_LTDescr_RectTransform_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_Single_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_Single_Action_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_GameObject_Single_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_GameObject_Single_Action_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_destroyAfter_Public_Static_LTDescr_LTRect_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_ArrayOf_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_LTBezierPath_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_LTSpline_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveSpline_Public_Static_LTDescr_GameObject_ArrayOf_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveSpline_Public_Static_LTDescr_GameObject_LTSpline_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveSplineLocal_Public_Static_LTDescr_GameObject_ArrayOf_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_move_Public_Static_LTDescr_LTRect_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveMargin_Public_Static_LTDescr_LTRect_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveX_Public_Static_LTDescr_GameObject_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveY_Public_Static_LTDescr_GameObject_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveZ_Public_Static_LTDescr_GameObject_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_ArrayOf_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveLocalX_Public_Static_LTDescr_GameObject_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveLocalY_Public_Static_LTDescr_GameObject_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveLocalZ_Public_Static_LTDescr_GameObject_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_LTBezierPath_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_LTSpline_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Transform_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_rotate_Public_Static_LTDescr_GameObject_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_rotate_Public_Static_LTDescr_LTRect_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_rotateLocal_Public_Static_LTDescr_GameObject_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_rotateX_Public_Static_LTDescr_GameObject_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_rotateY_Public_Static_LTDescr_GameObject_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_rotateZ_Public_Static_LTDescr_GameObject_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_rotateAround_Public_Static_LTDescr_GameObject_Vector3_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_rotateAroundLocal_Public_Static_LTDescr_GameObject_Vector3_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_scale_Public_Static_LTDescr_GameObject_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_scale_Public_Static_LTDescr_LTRect_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_scaleX_Public_Static_LTDescr_GameObject_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_scaleY_Public_Static_LTDescr_GameObject_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_scaleZ_Public_Static_LTDescr_GameObject_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Vector2_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Vector3_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Color_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_2_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Color_Color_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_2_Color_Object_Color_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Vector2_Vector2_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Vector3_Vector3_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_2_Single_Object_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_delayedSound_Public_Static_LTDescr_AudioClip_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_delayedSound_Public_Static_LTDescr_GameObject_AudioClip_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_move_Public_Static_LTDescr_RectTransform_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveX_Public_Static_LTDescr_RectTransform_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveY_Public_Static_LTDescr_RectTransform_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveZ_Public_Static_LTDescr_RectTransform_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_rotate_Public_Static_LTDescr_RectTransform_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_rotateAround_Public_Static_LTDescr_RectTransform_Vector3_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_rotateAroundLocal_Public_Static_LTDescr_RectTransform_Vector3_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_scale_Public_Static_LTDescr_RectTransform_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_size_Public_Static_LTDescr_RectTransform_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_alpha_Public_Static_LTDescr_RectTransform_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_color_Public_Static_LTDescr_RectTransform_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tweenOnCurve_Public_Static_Single_LTDescr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tweenOnCurveVector_Public_Static_Vector3_LTDescr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeOutQuadOpt_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInQuadOpt_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutQuadOpt_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutQuadOpt_Public_Static_Vector3_Vector3_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_linear_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clerp_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_spring_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInQuad_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeOutQuad_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutQuad_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutQuadOpt2_Public_Static_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInCubic_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeOutCubic_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutCubic_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInQuart_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeOutQuart_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutQuart_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInQuint_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeOutQuint_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutQuint_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInSine_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeOutSine_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutSine_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInExpo_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeOutExpo_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutExpo_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInCirc_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeOutCirc_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutCirc_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInBounce_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeOutBounce_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutBounce_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInBack_Public_Static_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeOutBack_Public_Static_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutBack_Public_Static_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInElastic_Public_Static_Single_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeOutElastic_Public_Static_Single_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_easeInOutElastic_Public_Static_Single_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addListener_Public_Static_Void_Int32_Action_1_LTEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addListener_Public_Static_Void_GameObject_Int32_Action_1_LTEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_removeListener_Public_Static_Boolean_Int32_Action_1_LTEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_removeListener_Public_Static_Boolean_GameObject_Int32_Action_1_LTEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_dispatchEvent_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_dispatchEvent_Public_Static_Void_Int32_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LeanTween>.NativeClassPtr));

	public unsafe static bool throwErrors
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_throwErrors, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_throwErrors, &flag);
		}
	}

	public unsafe static float tau
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tau, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tau, &num);
		}
	}

	public unsafe static float PI_DIV2
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PI_DIV2, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PI_DIV2, &num);
		}
	}

	public unsafe static Il2CppReferenceArray<LTDescr> tweens
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tweens, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Il2CppReferenceArray<LTDescr>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tweens, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppStructArray<int> tweensFinished
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tweensFinished, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Il2CppStructArray<int>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tweensFinished, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static LTDescr tween
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tween, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new LTDescr(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tween, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static int tweenMaxSearch
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tweenMaxSearch, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tweenMaxSearch, &num);
		}
	}

	public unsafe static int maxTweens
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_maxTweens, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_maxTweens, &num);
		}
	}

	public unsafe static int frameRendered
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_frameRendered, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_frameRendered, &num);
		}
	}

	public unsafe static GameObject _tweenEmpty
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__tweenEmpty, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__tweenEmpty, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static float dtEstimated
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dtEstimated, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dtEstimated, &num);
		}
	}

	public unsafe static float dtManual
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dtManual, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dtManual, &num);
		}
	}

	public unsafe static float dtActual
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dtActual, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dtActual, &num);
		}
	}

	public unsafe static int i
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_i, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_i, &num);
		}
	}

	public unsafe static int j
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_j, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_j, &num);
		}
	}

	public unsafe static int finishedCnt
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_finishedCnt, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_finishedCnt, &num);
		}
	}

	public unsafe static AnimationCurve punch
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_punch, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new AnimationCurve(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_punch, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static AnimationCurve shake
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_shake, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new AnimationCurve(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_shake, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static int maxTweenReached
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_maxTweenReached, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_maxTweenReached, &num);
		}
	}

	public unsafe static int startSearch
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_startSearch, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_startSearch, &num);
		}
	}

	public unsafe static LTDescr d
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_d, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new LTDescr(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_d, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppSystem.Action<LTEvent>> eventListeners
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_eventListeners, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Il2CppReferenceArray<Il2CppSystem.Action<LTEvent>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_eventListeners, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppReferenceArray<GameObject> goListeners
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_goListeners, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new Il2CppReferenceArray<GameObject>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_goListeners, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static int eventsMaxSearch
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_eventsMaxSearch, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_eventsMaxSearch, &num);
		}
	}

	public unsafe static int EVENTS_MAX
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EVENTS_MAX, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EVENTS_MAX, &num);
		}
	}

	public unsafe static int LISTENERS_MAX
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LISTENERS_MAX, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LISTENERS_MAX, &num);
		}
	}

	public unsafe static int INIT_LISTENERS_MAX
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INIT_LISTENERS_MAX, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INIT_LISTENERS_MAX, &num);
		}
	}

	public unsafe static int maxSearch
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6555, XrefRangeEnd = 6559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxSearch_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe static int maxSimulataneousTweens
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6559, XrefRangeEnd = 6563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxSimulataneousTweens_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe static int tweensRunning
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 6570, RefRangeEnd = 6574, XrefRangeStart = 6563, XrefRangeEnd = 6570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_tweensRunning_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe static GameObject tweenEmpty
	{
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 7809, RefRangeEnd = 7825, XrefRangeStart = 7803, XrefRangeEnd = 7809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_tweenEmpty_Public_Static_get_GameObject_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 6551, RefRangeEnd = 6555, XrefRangeStart = 6546, XrefRangeEnd = 6551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void init()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_init_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 6643, RefRangeEnd = 6653, XrefRangeStart = 6574, XrefRangeEnd = 6643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void init(int maxSimultaneousTweens)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&maxSimultaneousTweens);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_init_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 6677, RefRangeEnd = 6678, XrefRangeStart = 6653, XrefRangeEnd = 6677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void reset()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_reset_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6678, XrefRangeEnd = 6682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6682, XrefRangeEnd = 6693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void onLevelWasLoaded54(Scene scene, LoadSceneMode mode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&scene);
		*(LoadSceneMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onLevelWasLoaded54_Private_Static_Void_Scene_LoadSceneMode_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6693, XrefRangeEnd = 6697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void internalOnLevelWasLoaded(int lvl)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&lvl);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_internalOnLevelWasLoaded_Private_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 6759, RefRangeEnd = 6760, XrefRangeStart = 6697, XrefRangeEnd = 6759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void update()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_update_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6760, XrefRangeEnd = 6766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void removeTween(int i, int uniqueId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&i);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &uniqueId;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removeTween_Public_Static_Void_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 6841, RefRangeEnd = 6849, XrefRangeStart = 6766, XrefRangeEnd = 6841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void removeTween(int i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removeTween_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6849, XrefRangeEnd = 6863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector3> add(Il2CppStructArray<Vector3> a, Vector3 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_Public_Static_ArrayOf_Vector3_ArrayOf_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Vector3>(intPtr) : null;
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 6863, RefRangeEnd = 6872, XrefRangeStart = 6863, XrefRangeEnd = 6863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float closestRot(float from, float to)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&from);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_closestRot_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6872, XrefRangeEnd = 6876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void cancelAll()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_cancelAll_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 6916, RefRangeEnd = 6917, XrefRangeStart = 6876, XrefRangeEnd = 6916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void cancelAll(bool callComplete)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&callComplete);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_cancelAll_Public_Static_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 6921, RefRangeEnd = 6937, XrefRangeStart = 6917, XrefRangeEnd = 6921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void cancel(GameObject gameObject)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_cancel_Public_Static_Void_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(156)]
	[CachedScanResults(RefRangeStart = 6988, RefRangeEnd = 7144, XrefRangeStart = 6937, XrefRangeEnd = 6988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void cancel(GameObject gameObject, bool callOnComplete)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &callOnComplete;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_cancel_Public_Static_Void_GameObject_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7144, XrefRangeEnd = 7191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void cancel(GameObject gameObject, int uniqueId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &uniqueId;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_cancel_Public_Static_Void_GameObject_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7191, XrefRangeEnd = 7200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void cancel(LTRect ltRect, int uniqueId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ltRect);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &uniqueId;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_cancel_Public_Static_Void_LTRect_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 7204, RefRangeEnd = 7206, XrefRangeStart = 7200, XrefRangeEnd = 7204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void cancel(int uniqueId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&uniqueId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_cancel_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7219, RefRangeEnd = 7220, XrefRangeStart = 7206, XrefRangeEnd = 7219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void cancel(int uniqueId, bool callOnComplete)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&uniqueId);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &callOnComplete;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_cancel_Public_Static_Void_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 7230, RefRangeEnd = 7232, XrefRangeStart = 7220, XrefRangeEnd = 7230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr descr(int uniqueId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&uniqueId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_descr_Public_Static_LTDescr_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7236, RefRangeEnd = 7237, XrefRangeStart = 7232, XrefRangeEnd = 7236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr description(int uniqueId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&uniqueId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_description_Public_Static_LTDescr_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7297, RefRangeEnd = 7298, XrefRangeStart = 7237, XrefRangeEnd = 7297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<LTDescr> descriptions(GameObject gameObject = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_descriptions_Public_Static_ArrayOf_LTDescr_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<LTDescr>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7298, XrefRangeEnd = 7302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void pause(GameObject gameObject, int uniqueId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &uniqueId;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_pause_Public_Static_Void_GameObject_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 7308, RefRangeEnd = 7312, XrefRangeStart = 7302, XrefRangeEnd = 7308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void pause(int uniqueId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&uniqueId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_pause_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 7339, RefRangeEnd = 7342, XrefRangeStart = 7312, XrefRangeEnd = 7339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void pause(GameObject gameObject)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_pause_Public_Static_Void_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7342, XrefRangeEnd = 7358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void pauseAll()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_pauseAll_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7358, XrefRangeEnd = 7373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void resumeAll()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_resumeAll_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7373, XrefRangeEnd = 7377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void resume(GameObject gameObject, int uniqueId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &uniqueId;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_resume_Public_Static_Void_GameObject_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 7383, RefRangeEnd = 7387, XrefRangeStart = 7377, XrefRangeEnd = 7383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void resume(int uniqueId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&uniqueId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_resume_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 7422, RefRangeEnd = 7425, XrefRangeStart = 7387, XrefRangeEnd = 7422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void resume(GameObject gameObject)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_resume_Public_Static_Void_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(63)]
	[CachedScanResults(RefRangeStart = 7484, RefRangeEnd = 7547, XrefRangeStart = 7425, XrefRangeEnd = 7484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isTweening(GameObject gameObject = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isTweening_Public_Static_Boolean_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7555, RefRangeEnd = 7556, XrefRangeStart = 7547, XrefRangeEnd = 7555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isTweening(int uniqueId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&uniqueId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isTweening_Public_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7556, XrefRangeEnd = 7565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isTweening(LTRect ltRect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ltRect);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isTweening_Public_Static_Boolean_LTRect_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7565, XrefRangeEnd = 7603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, [Optional] float arrowSize, Transform arrowTransform = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&a);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &d;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &arrowSize;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(arrowTransform);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_drawBezierPath_Public_Static_Void_Vector3_Vector3_Vector3_Vector3_Single_Transform_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 7611, RefRangeEnd = 7614, XrefRangeStart = 7603, XrefRangeEnd = 7611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Object logError(string error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_logError_Public_Static_Object_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7614, XrefRangeEnd = 7620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr options(LTDescr seed)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(seed);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_options_Public_Static_LTDescr_LTDescr_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(142)]
	[CachedScanResults(RefRangeStart = 7661, RefRangeEnd = 7803, XrefRangeStart = 7620, XrefRangeEnd = 7661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr options()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_options_Public_Static_LTDescr_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(142)]
	[CachedScanResults(RefRangeStart = 7846, RefRangeEnd = 7988, XrefRangeStart = 7825, XrefRangeEnd = 7846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr pushNewTween(GameObject gameObject, Vector3 to, float time, LTDescr tween)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(tween);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_pushNewTween_Private_Static_LTDescr_GameObject_Vector3_Single_LTDescr_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7996, RefRangeEnd = 7997, XrefRangeStart = 7988, XrefRangeEnd = 7996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr play(RectTransform rectTransform, Il2CppReferenceArray<Sprite> sprites)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(sprites);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_play_Public_Static_LTDescr_RectTransform_ArrayOf_Sprite_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 8006, RefRangeEnd = 8014, XrefRangeStart = 7997, XrefRangeEnd = 8006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr alpha(GameObject gameObject, float to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_alpha_Public_Static_LTDescr_GameObject_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 8022, RefRangeEnd = 8026, XrefRangeStart = 8014, XrefRangeEnd = 8022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr alpha(LTRect ltRect, float to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ltRect);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_alpha_Public_Static_LTDescr_LTRect_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 8034, RefRangeEnd = 8037, XrefRangeStart = 8026, XrefRangeEnd = 8034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr textAlpha(RectTransform rectTransform, float to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_textAlpha_Public_Static_LTDescr_RectTransform_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8037, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr alphaText(RectTransform rectTransform, float to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_alphaText_Public_Static_LTDescr_RectTransform_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 8053, RefRangeEnd = 8086, XrefRangeStart = 8045, XrefRangeEnd = 8053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr alphaCanvas(CanvasGroup canvasGroup, float to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvasGroup);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_alphaCanvas_Public_Static_LTDescr_CanvasGroup_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8086, XrefRangeEnd = 8092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr alphaVertex(GameObject gameObject, float to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_alphaVertex_Public_Static_LTDescr_GameObject_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 8101, RefRangeEnd = 8108, XrefRangeStart = 8092, XrefRangeEnd = 8101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr color(GameObject gameObject, Color to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_color_Public_Static_LTDescr_GameObject_Color_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8108, XrefRangeEnd = 8116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr textColor(RectTransform rectTransform, Color to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_textColor_Public_Static_LTDescr_RectTransform_Color_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8116, XrefRangeEnd = 8124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr colorText(RectTransform rectTransform, Color to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_colorText_Public_Static_LTDescr_RectTransform_Color_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 8134, RefRangeEnd = 8139, XrefRangeStart = 8124, XrefRangeEnd = 8134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr delayedCall(float delayTime, Il2CppSystem.Action callback)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&delayTime);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(callback);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_Single_Action_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8139, XrefRangeEnd = 8149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr delayedCall(float delayTime, Il2CppSystem.Action<Il2CppSystem.Object> callback)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&delayTime);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(callback);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_Single_Action_1_Object_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 8158, RefRangeEnd = 8176, XrefRangeStart = 8149, XrefRangeEnd = 8158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr delayedCall(GameObject gameObject, float delayTime, Il2CppSystem.Action callback)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delayTime;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(callback);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_GameObject_Single_Action_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8176, XrefRangeEnd = 8185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr delayedCall(GameObject gameObject, float delayTime, Il2CppSystem.Action<Il2CppSystem.Object> callback)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delayTime;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(callback);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_GameObject_Single_Action_1_Object_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8185, XrefRangeEnd = 8195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr destroyAfter(LTRect rect, float delayTime)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delayTime;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_destroyAfter_Public_Static_LTDescr_LTRect_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 8201, RefRangeEnd = 8213, XrefRangeStart = 8195, XrefRangeEnd = 8201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr move(GameObject gameObject, Vector3 to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8213, XrefRangeEnd = 8223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr move(GameObject gameObject, Vector2 to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Vector2_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 8244, RefRangeEnd = 8247, XrefRangeStart = 8223, XrefRangeEnd = 8244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr move(GameObject gameObject, Il2CppStructArray<Vector3> to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(to);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_ArrayOf_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8247, XrefRangeEnd = 8256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr move(GameObject gameObject, LTBezierPath to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(to);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_LTBezierPath_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8256, XrefRangeEnd = 8265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr move(GameObject gameObject, LTSpline to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(to);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_LTSpline_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 8278, RefRangeEnd = 8283, XrefRangeStart = 8265, XrefRangeEnd = 8278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveSpline(GameObject gameObject, Il2CppStructArray<Vector3> to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(to);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_moveSpline_Public_Static_LTDescr_GameObject_ArrayOf_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 8292, RefRangeEnd = 8294, XrefRangeStart = 8283, XrefRangeEnd = 8292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveSpline(GameObject gameObject, LTSpline to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(to);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_moveSpline_Public_Static_LTDescr_GameObject_LTSpline_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 8307, RefRangeEnd = 8308, XrefRangeStart = 8294, XrefRangeEnd = 8307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveSplineLocal(GameObject gameObject, Il2CppStructArray<Vector3> to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(to);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_moveSplineLocal_Public_Static_LTDescr_GameObject_ArrayOf_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 8316, RefRangeEnd = 8321, XrefRangeStart = 8308, XrefRangeEnd = 8316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr move(LTRect ltRect, Vector2 to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ltRect);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_move_Public_Static_LTDescr_LTRect_Vector2_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8321, XrefRangeEnd = 8329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveMargin(LTRect ltRect, Vector2 to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ltRect);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_moveMargin_Public_Static_LTDescr_LTRect_Vector2_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 8335, RefRangeEnd = 8352, XrefRangeStart = 8329, XrefRangeEnd = 8335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveX(GameObject gameObject, float to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_moveX_Public_Static_LTDescr_GameObject_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 8358, RefRangeEnd = 8366, XrefRangeStart = 8352, XrefRangeEnd = 8358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveY(GameObject gameObject, float to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_moveY_Public_Static_LTDescr_GameObject_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 8372, RefRangeEnd = 8373, XrefRangeStart = 8366, XrefRangeEnd = 8372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveZ(GameObject gameObject, float to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_moveZ_Public_Static_LTDescr_GameObject_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8373, XrefRangeEnd = 8379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveLocal(GameObject gameObject, Vector3 to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 8400, RefRangeEnd = 8402, XrefRangeStart = 8379, XrefRangeEnd = 8400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveLocal(GameObject gameObject, Il2CppStructArray<Vector3> to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(to);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_ArrayOf_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 8408, RefRangeEnd = 8419, XrefRangeStart = 8402, XrefRangeEnd = 8408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveLocalX(GameObject gameObject, float to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_moveLocalX_Public_Static_LTDescr_GameObject_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 8425, RefRangeEnd = 8428, XrefRangeStart = 8419, XrefRangeEnd = 8425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveLocalY(GameObject gameObject, float to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_moveLocalY_Public_Static_LTDescr_GameObject_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 8434, RefRangeEnd = 8439, XrefRangeStart = 8428, XrefRangeEnd = 8434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveLocalZ(GameObject gameObject, float to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_moveLocalZ_Public_Static_LTDescr_GameObject_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8439, XrefRangeEnd = 8448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(to);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_LTBezierPath_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8448, XrefRangeEnd = 8457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveLocal(GameObject gameObject, LTSpline to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(to);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_LTSpline_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 8465, RefRangeEnd = 8467, XrefRangeStart = 8457, XrefRangeEnd = 8465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr move(GameObject gameObject, Transform to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(to);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Transform_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 8473, RefRangeEnd = 8480, XrefRangeStart = 8467, XrefRangeEnd = 8473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr rotate(GameObject gameObject, Vector3 to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_rotate_Public_Static_LTDescr_GameObject_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 8488, RefRangeEnd = 8490, XrefRangeStart = 8480, XrefRangeEnd = 8488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr rotate(LTRect ltRect, float to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ltRect);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_rotate_Public_Static_LTDescr_LTRect_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 8496, RefRangeEnd = 8504, XrefRangeStart = 8490, XrefRangeEnd = 8496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_rotateLocal_Public_Static_LTDescr_GameObject_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 8510, RefRangeEnd = 8517, XrefRangeStart = 8504, XrefRangeEnd = 8510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr rotateX(GameObject gameObject, float to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_rotateX_Public_Static_LTDescr_GameObject_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8517, XrefRangeEnd = 8523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr rotateY(GameObject gameObject, float to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_rotateY_Public_Static_LTDescr_GameObject_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 8529, RefRangeEnd = 8531, XrefRangeStart = 8523, XrefRangeEnd = 8529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr rotateZ(GameObject gameObject, float to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_rotateZ_Public_Static_LTDescr_GameObject_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(39)]
	[CachedScanResults(RefRangeStart = 8537, RefRangeEnd = 8576, XrefRangeStart = 8531, XrefRangeEnd = 8537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr rotateAround(GameObject gameObject, Vector3 axis, float add, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &axis;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &add;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_rotateAround_Public_Static_LTDescr_GameObject_Vector3_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 8582, RefRangeEnd = 8585, XrefRangeStart = 8576, XrefRangeEnd = 8582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, float add, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &axis;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &add;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_rotateAroundLocal_Public_Static_LTDescr_GameObject_Vector3_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8594, XrefRangeStart = 8585, XrefRangeEnd = 8591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr scale(GameObject gameObject, Vector3 to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_scale_Public_Static_LTDescr_GameObject_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 8602, RefRangeEnd = 8604, XrefRangeStart = 8594, XrefRangeEnd = 8602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr scale(LTRect ltRect, Vector2 to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ltRect);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_scale_Public_Static_LTDescr_LTRect_Vector2_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 8610, RefRangeEnd = 8612, XrefRangeStart = 8604, XrefRangeEnd = 8610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr scaleX(GameObject gameObject, float to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_scaleX_Public_Static_LTDescr_GameObject_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 8618, RefRangeEnd = 8620, XrefRangeStart = 8612, XrefRangeEnd = 8618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr scaleY(GameObject gameObject, float to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_scaleY_Public_Static_LTDescr_GameObject_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 8626, RefRangeEnd = 8628, XrefRangeStart = 8620, XrefRangeEnd = 8626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr scaleZ(GameObject gameObject, float to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_scaleZ_Public_Static_LTDescr_GameObject_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(76)]
	[CachedScanResults(RefRangeStart = 8635, RefRangeEnd = 8711, XrefRangeStart = 8628, XrefRangeEnd = 8635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr value(GameObject gameObject, float from, float to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8711, XrefRangeEnd = 8719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr value(float from, float to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&from);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_value_Public_Static_LTDescr_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 8726, RefRangeEnd = 8728, XrefRangeStart = 8719, XrefRangeEnd = 8726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Vector2_Vector2_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8728, XrefRangeEnd = 8735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Vector3_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 8744, RefRangeEnd = 8750, XrefRangeStart = 8735, XrefRangeEnd = 8744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr value(GameObject gameObject, Color from, Color to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Color_Color_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 8758, RefRangeEnd = 8760, XrefRangeStart = 8750, XrefRangeEnd = 8758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr value(GameObject gameObject, Il2CppSystem.Action<float> callOnUpdate, float from, float to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(callOnUpdate);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 8767, RefRangeEnd = 8771, XrefRangeStart = 8760, XrefRangeEnd = 8767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr value(GameObject gameObject, Il2CppSystem.Action<float, float> callOnUpdateRatio, float from, float to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(callOnUpdateRatio);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_2_Single_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8771, XrefRangeEnd = 8779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr value(GameObject gameObject, Il2CppSystem.Action<Color> callOnUpdate, Color from, Color to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(callOnUpdate);
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(Color**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Color_Color_Color_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8779, XrefRangeEnd = 8786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr value(GameObject gameObject, Il2CppSystem.Action<Color, Il2CppSystem.Object> callOnUpdate, Color from, Color to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(callOnUpdate);
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(Color**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_2_Color_Object_Color_Color_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8786, XrefRangeEnd = 8793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr value(GameObject gameObject, Il2CppSystem.Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(callOnUpdate);
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(Vector2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Vector2_Vector2_Vector2_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8793, XrefRangeEnd = 8802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr value(GameObject gameObject, Il2CppSystem.Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(callOnUpdate);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Vector3_Vector3_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8802, XrefRangeEnd = 8809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr value(GameObject gameObject, Il2CppSystem.Action<float, Il2CppSystem.Object> callOnUpdate, float from, float to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(callOnUpdate);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_2_Single_Object_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8809, XrefRangeEnd = 8819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(audio);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &volume;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_delayedSound_Public_Static_LTDescr_AudioClip_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8819, XrefRangeEnd = 8828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, float volume)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(audio);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &volume;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_delayedSound_Public_Static_LTDescr_GameObject_AudioClip_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 8836, RefRangeEnd = 8838, XrefRangeStart = 8828, XrefRangeEnd = 8836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr move(RectTransform rectTrans, Vector3 to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_move_Public_Static_LTDescr_RectTransform_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 8846, RefRangeEnd = 8857, XrefRangeStart = 8838, XrefRangeEnd = 8846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveX(RectTransform rectTrans, float to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_moveX_Public_Static_LTDescr_RectTransform_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 8865, RefRangeEnd = 8868, XrefRangeStart = 8857, XrefRangeEnd = 8865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveY(RectTransform rectTrans, float to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_moveY_Public_Static_LTDescr_RectTransform_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8868, XrefRangeEnd = 8876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr moveZ(RectTransform rectTrans, float to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_moveZ_Public_Static_LTDescr_RectTransform_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8876, XrefRangeEnd = 8886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr rotate(RectTransform rectTrans, float to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_rotate_Public_Static_LTDescr_RectTransform_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 8894, RefRangeEnd = 8897, XrefRangeStart = 8886, XrefRangeEnd = 8894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &axis;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_rotateAround_Public_Static_LTDescr_RectTransform_Vector3_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 8905, RefRangeEnd = 8907, XrefRangeStart = 8897, XrefRangeEnd = 8905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &axis;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_rotateAroundLocal_Public_Static_LTDescr_RectTransform_Vector3_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 8915, RefRangeEnd = 8920, XrefRangeStart = 8907, XrefRangeEnd = 8915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr scale(RectTransform rectTrans, Vector3 to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_scale_Public_Static_LTDescr_RectTransform_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8920, XrefRangeEnd = 8928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr size(RectTransform rectTrans, Vector2 to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_size_Public_Static_LTDescr_RectTransform_Vector2_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 8936, RefRangeEnd = 8940, XrefRangeStart = 8928, XrefRangeEnd = 8936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr alpha(RectTransform rectTrans, float to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_alpha_Public_Static_LTDescr_RectTransform_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 8948, RefRangeEnd = 8952, XrefRangeStart = 8940, XrefRangeEnd = 8948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LTDescr color(RectTransform rectTrans, Color to, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTrans);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_color_Public_Static_LTDescr_RectTransform_Color_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new LTDescr(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8952, XrefRangeEnd = 8954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float tweenOnCurve(LTDescr tweenDescr, float ratioPassed)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(tweenDescr);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ratioPassed;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tweenOnCurve_Public_Static_Single_LTDescr_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8954, XrefRangeEnd = 8960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 tweenOnCurveVector(LTDescr tweenDescr, float ratioPassed)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(tweenDescr);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ratioPassed;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tweenOnCurveVector_Public_Static_Vector3_LTDescr_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float easeOutQuadOpt(float start, float diff, float ratioPassed)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &diff;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ratioPassed;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeOutQuadOpt_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float easeInQuadOpt(float start, float diff, float ratioPassed)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &diff;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ratioPassed;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInQuadOpt_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float easeInOutQuadOpt(float start, float diff, float ratioPassed)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &diff;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ratioPassed;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInOutQuadOpt_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8960, XrefRangeEnd = 8961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 easeInOutQuadOpt(Vector3 start, Vector3 diff, float ratioPassed)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &diff;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ratioPassed;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInOutQuadOpt_Public_Static_Vector3_Vector3_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float linear(float start, float end, float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_linear_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float clerp(float start, float end, float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clerp_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8961, XrefRangeEnd = 8964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float spring(float start, float end, float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_spring_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float easeInQuad(float start, float end, float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInQuad_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float easeOutQuad(float start, float end, float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeOutQuad_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float easeInOutQuad(float start, float end, float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInOutQuad_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float easeInOutQuadOpt2(float start, float diffBy2, float val, float val2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &diffBy2;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &val2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInOutQuadOpt2_Public_Static_Single_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float easeInCubic(float start, float end, float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInCubic_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float easeOutCubic(float start, float end, float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeOutCubic_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float easeInOutCubic(float start, float end, float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInOutCubic_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float easeInQuart(float start, float end, float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInQuart_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float easeOutQuart(float start, float end, float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeOutQuart_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float easeInOutQuart(float start, float end, float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInOutQuart_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float easeInQuint(float start, float end, float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInQuint_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float easeOutQuint(float start, float end, float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeOutQuint_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float easeInOutQuint(float start, float end, float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInOutQuint_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8964, XrefRangeEnd = 8965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float easeInSine(float start, float end, float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInSine_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8965, XrefRangeEnd = 8966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float easeOutSine(float start, float end, float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeOutSine_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8966, XrefRangeEnd = 8967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float easeInOutSine(float start, float end, float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInOutSine_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8967, XrefRangeEnd = 8968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float easeInExpo(float start, float end, float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInExpo_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8968, XrefRangeEnd = 8969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float easeOutExpo(float start, float end, float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeOutExpo_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8969, XrefRangeEnd = 8972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float easeInOutExpo(float start, float end, float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInOutExpo_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8972, XrefRangeEnd = 8974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float easeInCirc(float start, float end, float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInCirc_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8974, XrefRangeEnd = 8976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float easeOutCirc(float start, float end, float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeOutCirc_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8976, XrefRangeEnd = 8981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float easeInOutCirc(float start, float end, float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInOutCirc_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 8985, RefRangeEnd = 8989, XrefRangeStart = 8981, XrefRangeEnd = 8985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float easeInBounce(float start, float end, float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInBounce_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 8989, RefRangeEnd = 8997, XrefRangeStart = 8989, XrefRangeEnd = 8989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float easeOutBounce(float start, float end, float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeOutBounce_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8997, XrefRangeEnd = 9004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float easeInOutBounce(float start, float end, float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInOutBounce_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float easeInBack(float start, float end, float val, [Optional] float overshoot)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &overshoot;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInBack_Public_Static_Single_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float easeOutBack(float start, float end, float val, [Optional] float overshoot)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &overshoot;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeOutBack_Public_Static_Single_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float easeInOutBack(float start, float end, float val, [Optional] float overshoot)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &overshoot;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInOutBack_Public_Static_Single_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 9007, RefRangeEnd = 9010, XrefRangeStart = 9004, XrefRangeEnd = 9007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float easeInElastic(float start, float end, float val, [Optional] float overshoot, [Optional] float period)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &overshoot;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &period;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInElastic_Public_Static_Single_Single_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 9013, RefRangeEnd = 9016, XrefRangeStart = 9010, XrefRangeEnd = 9013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float easeOutElastic(float start, float end, float val, [Optional] float overshoot, [Optional] float period)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &overshoot;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &period;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeOutElastic_Public_Static_Single_Single_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 9023, RefRangeEnd = 9026, XrefRangeStart = 9016, XrefRangeEnd = 9023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float easeInOutElastic(float start, float end, float val, [Optional] float overshoot, [Optional] float period)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&start);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &overshoot;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &period;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_easeInOutElastic_Public_Static_Single_Single_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9026, XrefRangeEnd = 9031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void addListener(int eventId, Il2CppSystem.Action<LTEvent> callback)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&eventId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(callback);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addListener_Public_Static_Void_Int32_Action_1_LTEvent_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 9131, RefRangeEnd = 9136, XrefRangeStart = 9031, XrefRangeEnd = 9131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void addListener(GameObject caller, int eventId, Il2CppSystem.Action<LTEvent> callback)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(caller);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventId;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(callback);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addListener_Public_Static_Void_GameObject_Int32_Action_1_LTEvent_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9136, XrefRangeEnd = 9141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool removeListener(int eventId, Il2CppSystem.Action<LTEvent> callback)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&eventId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(callback);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removeListener_Public_Static_Boolean_Int32_Action_1_LTEvent_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 9186, RefRangeEnd = 9190, XrefRangeStart = 9141, XrefRangeEnd = 9186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool removeListener(GameObject caller, int eventId, Il2CppSystem.Action<LTEvent> callback)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(caller);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventId;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(callback);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removeListener_Public_Static_Boolean_GameObject_Int32_Action_1_LTEvent_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9190, XrefRangeEnd = 9194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void dispatchEvent(int eventId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&eventId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_dispatchEvent_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 9223, RefRangeEnd = 9228, XrefRangeStart = 9194, XrefRangeEnd = 9223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void dispatchEvent(int eventId, Il2CppSystem.Object data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&eventId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(data);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_dispatchEvent_Public_Static_Void_Int32_Object_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe LeanTween()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeanTween>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static LeanTween()
	{
		Il2CppClassPointerStore<LeanTween>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LeanTween");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeanTween>.NativeClassPtr);
		NativeFieldInfoPtr_throwErrors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "throwErrors");
		NativeFieldInfoPtr_tau = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "tau");
		NativeFieldInfoPtr_PI_DIV2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "PI_DIV2");
		NativeFieldInfoPtr_tweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "tweens");
		NativeFieldInfoPtr_tweensFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "tweensFinished");
		NativeFieldInfoPtr_tween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "tween");
		NativeFieldInfoPtr_tweenMaxSearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "tweenMaxSearch");
		NativeFieldInfoPtr_maxTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "maxTweens");
		NativeFieldInfoPtr_frameRendered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "frameRendered");
		NativeFieldInfoPtr__tweenEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "_tweenEmpty");
		NativeFieldInfoPtr_dtEstimated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "dtEstimated");
		NativeFieldInfoPtr_dtManual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "dtManual");
		NativeFieldInfoPtr_dtActual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "dtActual");
		NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "i");
		NativeFieldInfoPtr_j = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "j");
		NativeFieldInfoPtr_finishedCnt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "finishedCnt");
		NativeFieldInfoPtr_punch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "punch");
		NativeFieldInfoPtr_shake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "shake");
		NativeFieldInfoPtr_maxTweenReached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "maxTweenReached");
		NativeFieldInfoPtr_startSearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "startSearch");
		NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "d");
		NativeFieldInfoPtr_eventListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "eventListeners");
		NativeFieldInfoPtr_goListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "goListeners");
		NativeFieldInfoPtr_eventsMaxSearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "eventsMaxSearch");
		NativeFieldInfoPtr_EVENTS_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "EVENTS_MAX");
		NativeFieldInfoPtr_LISTENERS_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "LISTENERS_MAX");
		NativeFieldInfoPtr_INIT_LISTENERS_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, "INIT_LISTENERS_MAX");
		NativeMethodInfoPtr_init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663910);
		NativeMethodInfoPtr_get_maxSearch_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663911);
		NativeMethodInfoPtr_get_maxSimulataneousTweens_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663912);
		NativeMethodInfoPtr_get_tweensRunning_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663913);
		NativeMethodInfoPtr_init_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663914);
		NativeMethodInfoPtr_reset_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663915);
		NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663916);
		NativeMethodInfoPtr_onLevelWasLoaded54_Private_Static_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663917);
		NativeMethodInfoPtr_internalOnLevelWasLoaded_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663918);
		NativeMethodInfoPtr_update_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663919);
		NativeMethodInfoPtr_removeTween_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663920);
		NativeMethodInfoPtr_removeTween_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663921);
		NativeMethodInfoPtr_add_Public_Static_ArrayOf_Vector3_ArrayOf_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663922);
		NativeMethodInfoPtr_closestRot_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663923);
		NativeMethodInfoPtr_cancelAll_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663924);
		NativeMethodInfoPtr_cancelAll_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663925);
		NativeMethodInfoPtr_cancel_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663926);
		NativeMethodInfoPtr_cancel_Public_Static_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663927);
		NativeMethodInfoPtr_cancel_Public_Static_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663928);
		NativeMethodInfoPtr_cancel_Public_Static_Void_LTRect_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663929);
		NativeMethodInfoPtr_cancel_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663930);
		NativeMethodInfoPtr_cancel_Public_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663931);
		NativeMethodInfoPtr_descr_Public_Static_LTDescr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663932);
		NativeMethodInfoPtr_description_Public_Static_LTDescr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663933);
		NativeMethodInfoPtr_descriptions_Public_Static_ArrayOf_LTDescr_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663934);
		NativeMethodInfoPtr_pause_Public_Static_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663935);
		NativeMethodInfoPtr_pause_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663936);
		NativeMethodInfoPtr_pause_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663937);
		NativeMethodInfoPtr_pauseAll_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663938);
		NativeMethodInfoPtr_resumeAll_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663939);
		NativeMethodInfoPtr_resume_Public_Static_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663940);
		NativeMethodInfoPtr_resume_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663941);
		NativeMethodInfoPtr_resume_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663942);
		NativeMethodInfoPtr_isTweening_Public_Static_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663943);
		NativeMethodInfoPtr_isTweening_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663944);
		NativeMethodInfoPtr_isTweening_Public_Static_Boolean_LTRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663945);
		NativeMethodInfoPtr_drawBezierPath_Public_Static_Void_Vector3_Vector3_Vector3_Vector3_Single_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663946);
		NativeMethodInfoPtr_logError_Public_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663947);
		NativeMethodInfoPtr_options_Public_Static_LTDescr_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663948);
		NativeMethodInfoPtr_options_Public_Static_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663949);
		NativeMethodInfoPtr_get_tweenEmpty_Public_Static_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663950);
		NativeMethodInfoPtr_pushNewTween_Private_Static_LTDescr_GameObject_Vector3_Single_LTDescr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663951);
		NativeMethodInfoPtr_play_Public_Static_LTDescr_RectTransform_ArrayOf_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663952);
		NativeMethodInfoPtr_alpha_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663953);
		NativeMethodInfoPtr_alpha_Public_Static_LTDescr_LTRect_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663954);
		NativeMethodInfoPtr_textAlpha_Public_Static_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663955);
		NativeMethodInfoPtr_alphaText_Public_Static_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663956);
		NativeMethodInfoPtr_alphaCanvas_Public_Static_LTDescr_CanvasGroup_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663957);
		NativeMethodInfoPtr_alphaVertex_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663958);
		NativeMethodInfoPtr_color_Public_Static_LTDescr_GameObject_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663959);
		NativeMethodInfoPtr_textColor_Public_Static_LTDescr_RectTransform_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663960);
		NativeMethodInfoPtr_colorText_Public_Static_LTDescr_RectTransform_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663961);
		NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663962);
		NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_Single_Action_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663963);
		NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_GameObject_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663964);
		NativeMethodInfoPtr_delayedCall_Public_Static_LTDescr_GameObject_Single_Action_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663965);
		NativeMethodInfoPtr_destroyAfter_Public_Static_LTDescr_LTRect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663966);
		NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663967);
		NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663968);
		NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_ArrayOf_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663969);
		NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_LTBezierPath_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663970);
		NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_LTSpline_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663971);
		NativeMethodInfoPtr_moveSpline_Public_Static_LTDescr_GameObject_ArrayOf_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663972);
		NativeMethodInfoPtr_moveSpline_Public_Static_LTDescr_GameObject_LTSpline_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663973);
		NativeMethodInfoPtr_moveSplineLocal_Public_Static_LTDescr_GameObject_ArrayOf_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663974);
		NativeMethodInfoPtr_move_Public_Static_LTDescr_LTRect_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663975);
		NativeMethodInfoPtr_moveMargin_Public_Static_LTDescr_LTRect_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663976);
		NativeMethodInfoPtr_moveX_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663977);
		NativeMethodInfoPtr_moveY_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663978);
		NativeMethodInfoPtr_moveZ_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663979);
		NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663980);
		NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_ArrayOf_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663981);
		NativeMethodInfoPtr_moveLocalX_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663982);
		NativeMethodInfoPtr_moveLocalY_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663983);
		NativeMethodInfoPtr_moveLocalZ_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663984);
		NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_LTBezierPath_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663985);
		NativeMethodInfoPtr_moveLocal_Public_Static_LTDescr_GameObject_LTSpline_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663986);
		NativeMethodInfoPtr_move_Public_Static_LTDescr_GameObject_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663987);
		NativeMethodInfoPtr_rotate_Public_Static_LTDescr_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663988);
		NativeMethodInfoPtr_rotate_Public_Static_LTDescr_LTRect_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663989);
		NativeMethodInfoPtr_rotateLocal_Public_Static_LTDescr_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663990);
		NativeMethodInfoPtr_rotateX_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663991);
		NativeMethodInfoPtr_rotateY_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663992);
		NativeMethodInfoPtr_rotateZ_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663993);
		NativeMethodInfoPtr_rotateAround_Public_Static_LTDescr_GameObject_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663994);
		NativeMethodInfoPtr_rotateAroundLocal_Public_Static_LTDescr_GameObject_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663995);
		NativeMethodInfoPtr_scale_Public_Static_LTDescr_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663996);
		NativeMethodInfoPtr_scale_Public_Static_LTDescr_LTRect_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663997);
		NativeMethodInfoPtr_scaleX_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663998);
		NativeMethodInfoPtr_scaleY_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100663999);
		NativeMethodInfoPtr_scaleZ_Public_Static_LTDescr_GameObject_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664000);
		NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664001);
		NativeMethodInfoPtr_value_Public_Static_LTDescr_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664002);
		NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664003);
		NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664004);
		NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664005);
		NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664006);
		NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_2_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664007);
		NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Color_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664008);
		NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_2_Color_Object_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664009);
		NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Vector2_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664010);
		NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_1_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664011);
		NativeMethodInfoPtr_value_Public_Static_LTDescr_GameObject_Action_2_Single_Object_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664012);
		NativeMethodInfoPtr_delayedSound_Public_Static_LTDescr_AudioClip_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664013);
		NativeMethodInfoPtr_delayedSound_Public_Static_LTDescr_GameObject_AudioClip_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664014);
		NativeMethodInfoPtr_move_Public_Static_LTDescr_RectTransform_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664015);
		NativeMethodInfoPtr_moveX_Public_Static_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664016);
		NativeMethodInfoPtr_moveY_Public_Static_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664017);
		NativeMethodInfoPtr_moveZ_Public_Static_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664018);
		NativeMethodInfoPtr_rotate_Public_Static_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664019);
		NativeMethodInfoPtr_rotateAround_Public_Static_LTDescr_RectTransform_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664020);
		NativeMethodInfoPtr_rotateAroundLocal_Public_Static_LTDescr_RectTransform_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664021);
		NativeMethodInfoPtr_scale_Public_Static_LTDescr_RectTransform_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664022);
		NativeMethodInfoPtr_size_Public_Static_LTDescr_RectTransform_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664023);
		NativeMethodInfoPtr_alpha_Public_Static_LTDescr_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664024);
		NativeMethodInfoPtr_color_Public_Static_LTDescr_RectTransform_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664025);
		NativeMethodInfoPtr_tweenOnCurve_Public_Static_Single_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664026);
		NativeMethodInfoPtr_tweenOnCurveVector_Public_Static_Vector3_LTDescr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664027);
		NativeMethodInfoPtr_easeOutQuadOpt_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664028);
		NativeMethodInfoPtr_easeInQuadOpt_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664029);
		NativeMethodInfoPtr_easeInOutQuadOpt_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664030);
		NativeMethodInfoPtr_easeInOutQuadOpt_Public_Static_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664031);
		NativeMethodInfoPtr_linear_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664032);
		NativeMethodInfoPtr_clerp_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664033);
		NativeMethodInfoPtr_spring_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664034);
		NativeMethodInfoPtr_easeInQuad_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664035);
		NativeMethodInfoPtr_easeOutQuad_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664036);
		NativeMethodInfoPtr_easeInOutQuad_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664037);
		NativeMethodInfoPtr_easeInOutQuadOpt2_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664038);
		NativeMethodInfoPtr_easeInCubic_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664039);
		NativeMethodInfoPtr_easeOutCubic_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664040);
		NativeMethodInfoPtr_easeInOutCubic_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664041);
		NativeMethodInfoPtr_easeInQuart_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664042);
		NativeMethodInfoPtr_easeOutQuart_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664043);
		NativeMethodInfoPtr_easeInOutQuart_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664044);
		NativeMethodInfoPtr_easeInQuint_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664045);
		NativeMethodInfoPtr_easeOutQuint_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664046);
		NativeMethodInfoPtr_easeInOutQuint_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664047);
		NativeMethodInfoPtr_easeInSine_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664048);
		NativeMethodInfoPtr_easeOutSine_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664049);
		NativeMethodInfoPtr_easeInOutSine_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664050);
		NativeMethodInfoPtr_easeInExpo_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664051);
		NativeMethodInfoPtr_easeOutExpo_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664052);
		NativeMethodInfoPtr_easeInOutExpo_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664053);
		NativeMethodInfoPtr_easeInCirc_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664054);
		NativeMethodInfoPtr_easeOutCirc_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664055);
		NativeMethodInfoPtr_easeInOutCirc_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664056);
		NativeMethodInfoPtr_easeInBounce_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664057);
		NativeMethodInfoPtr_easeOutBounce_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664058);
		NativeMethodInfoPtr_easeInOutBounce_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664059);
		NativeMethodInfoPtr_easeInBack_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664060);
		NativeMethodInfoPtr_easeOutBack_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664061);
		NativeMethodInfoPtr_easeInOutBack_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664062);
		NativeMethodInfoPtr_easeInElastic_Public_Static_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664063);
		NativeMethodInfoPtr_easeOutElastic_Public_Static_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664064);
		NativeMethodInfoPtr_easeInOutElastic_Public_Static_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664065);
		NativeMethodInfoPtr_addListener_Public_Static_Void_Int32_Action_1_LTEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664066);
		NativeMethodInfoPtr_addListener_Public_Static_Void_GameObject_Int32_Action_1_LTEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664067);
		NativeMethodInfoPtr_removeListener_Public_Static_Boolean_Int32_Action_1_LTEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664068);
		NativeMethodInfoPtr_removeListener_Public_Static_Boolean_GameObject_Int32_Action_1_LTEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664069);
		NativeMethodInfoPtr_dispatchEvent_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664070);
		NativeMethodInfoPtr_dispatchEvent_Public_Static_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664071);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanTween>.NativeClassPtr, 100664072);
	}

	public LeanTween(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
