using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.UI.Animations;

public class SlideWithFade : Animation
{
	private static readonly System.IntPtr NativeFieldInfoPtr_FadeTo;

	private static readonly System.IntPtr NativeFieldInfoPtr_FadeTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlideValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlideTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlideDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_CanvasGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_RectTransform;

	private static readonly System.IntPtr NativeFieldInfoPtr_EaseType;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AnimationDirection_CanvasGroup_RectTransform_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AnimationDirection_CanvasGroup_RectTransform_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AnimationDirection_Single_Single_Single_Single_CanvasGroup_RectTransform_LeanTweenType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Animate_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Animate_b__12_0_Private_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SlideWithFade>.NativeClassPtr));

	public unsafe float FadeTo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeTo);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeTo)) = num;
		}
	}

	public unsafe float FadeTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeTime)) = num;
		}
	}

	public unsafe float SlideValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SlideValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SlideValue)) = num;
		}
	}

	public unsafe float SlideTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SlideTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SlideTime)) = num;
		}
	}

	public unsafe AnimationDirection SlideDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SlideDirection);
			return *(AnimationDirection*)num;
		}
		set
		{
			*(AnimationDirection*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SlideDirection)) = animationDirection;
		}
	}

	public unsafe CanvasGroup CanvasGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanvasGroup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CanvasGroup(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RectTransform RectTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RectTransform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RectTransform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RectTransform), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe LeanTweenType EaseType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EaseType);
			return *(LeanTweenType*)num;
		}
		set
		{
			*(LeanTweenType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EaseType)) = leanTweenType;
		}
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe SlideWithFade()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlideWithFade>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 211961, RefRangeEnd = 211962, XrefRangeStart = 211961, XrefRangeEnd = 211961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SlideWithFade(AnimationDirection slideDirection, CanvasGroup canvasGroup, RectTransform rectTransform, float slideValue)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlideWithFade>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&slideDirection);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(canvasGroup);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &slideValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_AnimationDirection_CanvasGroup_RectTransform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe SlideWithFade(AnimationDirection slideDirection, CanvasGroup canvasGroup, RectTransform rectTransform, float slideValue, float fadeTime)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlideWithFade>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&slideDirection);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(canvasGroup);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &slideValue;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fadeTime;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_AnimationDirection_CanvasGroup_RectTransform_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe SlideWithFade(AnimationDirection slideDirection, float fadeTo, float fadeTime, float slideValue, float slideTime, CanvasGroup canvasGroup, RectTransform rectTransform, LeanTweenType easeType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlideWithFade>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&slideDirection);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fadeTo;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fadeTime;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &slideValue;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &slideTime;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(canvasGroup);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
		*(LeanTweenType**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &easeType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_AnimationDirection_Single_Single_Single_Single_CanvasGroup_RectTransform_LeanTweenType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211962, XrefRangeEnd = 212003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Animate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Animate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212003, XrefRangeEnd = 212016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Animate_b__12_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Animate_b__12_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SlideWithFade()
	{
		Il2CppClassPointerStore<SlideWithFade>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Animations", "SlideWithFade");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlideWithFade>.NativeClassPtr);
		NativeFieldInfoPtr_FadeTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlideWithFade>.NativeClassPtr, "FadeTo");
		NativeFieldInfoPtr_FadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlideWithFade>.NativeClassPtr, "FadeTime");
		NativeFieldInfoPtr_SlideValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlideWithFade>.NativeClassPtr, "SlideValue");
		NativeFieldInfoPtr_SlideTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlideWithFade>.NativeClassPtr, "SlideTime");
		NativeFieldInfoPtr_SlideDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlideWithFade>.NativeClassPtr, "SlideDirection");
		NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlideWithFade>.NativeClassPtr, "CanvasGroup");
		NativeFieldInfoPtr_RectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlideWithFade>.NativeClassPtr, "RectTransform");
		NativeFieldInfoPtr_EaseType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlideWithFade>.NativeClassPtr, "EaseType");
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlideWithFade>.NativeClassPtr, 100679200);
		NativeMethodInfoPtr__ctor_Public_Void_AnimationDirection_CanvasGroup_RectTransform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlideWithFade>.NativeClassPtr, 100679201);
		NativeMethodInfoPtr__ctor_Public_Void_AnimationDirection_CanvasGroup_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlideWithFade>.NativeClassPtr, 100679202);
		NativeMethodInfoPtr__ctor_Public_Void_AnimationDirection_Single_Single_Single_Single_CanvasGroup_RectTransform_LeanTweenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlideWithFade>.NativeClassPtr, 100679203);
		NativeMethodInfoPtr_Animate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlideWithFade>.NativeClassPtr, 100679204);
		NativeMethodInfoPtr__Animate_b__12_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlideWithFade>.NativeClassPtr, 100679205);
	}

	public SlideWithFade(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
