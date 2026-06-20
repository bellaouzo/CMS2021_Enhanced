using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.UI.Animations;

public class FadeOut : Animation
{
	[ObfuscatedName("CMS.UI.Animations.FadeOut/<>c__DisplayClass8_0")]
	public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_cachedCanvas;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Animate_b__0_Internal_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr));

		public unsafe FadeOut __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new FadeOut(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe CanvasGroup cachedCanvas
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedCanvas);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new CanvasGroup(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cachedCanvas), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass8_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211911, XrefRangeEnd = 211929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Animate_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Animate_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass8_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FadeOut>.NativeClassPtr, "<>c__DisplayClass8_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr);
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_cachedCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr, "cachedCanvas");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr, 100679198);
			NativeMethodInfoPtr__Animate_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr, 100679199);
		}

		public __c__DisplayClass8_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_CanvasGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_UseCachedCanvas;

	private static readonly System.IntPtr NativeFieldInfoPtr_FadeTo;

	private static readonly System.IntPtr NativeFieldInfoPtr_FadeTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_EaseType;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CanvasGroup_Boolean_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CanvasGroup_Single_Single_LeanTweenType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Animate_Public_Virtual_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<FadeOut>.NativeClassPtr));

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

	public unsafe bool UseCachedCanvas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseCachedCanvas);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseCachedCanvas)) = flag;
		}
	}

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
	public unsafe FadeOut()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FadeOut>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe FadeOut(CanvasGroup canvasGroup, bool useCachedCanvas, float fadeTime)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FadeOut>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvasGroup);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useCachedCanvas;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fadeTime;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CanvasGroup_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe FadeOut(CanvasGroup canvasGroup, float fadeTo, float fadeTime, LeanTweenType easeType, bool useCachedCanvas)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FadeOut>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvasGroup);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fadeTo;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fadeTime;
		*(LeanTweenType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &easeType;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &useCachedCanvas;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CanvasGroup_Single_Single_LeanTweenType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211929, XrefRangeEnd = 211961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Animate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Animate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static FadeOut()
	{
		Il2CppClassPointerStore<FadeOut>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Animations", "FadeOut");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FadeOut>.NativeClassPtr);
		NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeOut>.NativeClassPtr, "CanvasGroup");
		NativeFieldInfoPtr_UseCachedCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeOut>.NativeClassPtr, "UseCachedCanvas");
		NativeFieldInfoPtr_FadeTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeOut>.NativeClassPtr, "FadeTo");
		NativeFieldInfoPtr_FadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeOut>.NativeClassPtr, "FadeTime");
		NativeFieldInfoPtr_EaseType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeOut>.NativeClassPtr, "EaseType");
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FadeOut>.NativeClassPtr, 100679194);
		NativeMethodInfoPtr__ctor_Public_Void_CanvasGroup_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FadeOut>.NativeClassPtr, 100679195);
		NativeMethodInfoPtr__ctor_Public_Void_CanvasGroup_Single_Single_LeanTweenType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FadeOut>.NativeClassPtr, 100679196);
		NativeMethodInfoPtr_Animate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FadeOut>.NativeClassPtr, 100679197);
	}

	public FadeOut(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
