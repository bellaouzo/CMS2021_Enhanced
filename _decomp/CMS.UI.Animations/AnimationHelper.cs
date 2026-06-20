using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.UI.Animations;

public static class AnimationHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_MoveBasedOnDirection_Public_Static_Void_AnimationDirection_RectTransform_Single_Single_LeanTweenType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPositionBasedOnDirection_Public_Static_Vector3_Vector3_AnimationDirection_Single_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AnimationHelper>.NativeClassPtr));

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211840, XrefRangeEnd = 211849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MoveBasedOnDirection(AnimationDirection slideDirection, RectTransform rectTransform, float startingPosition, float slideTime, LeanTweenType easeType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&slideDirection);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startingPosition;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &slideTime;
		*(LeanTweenType**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &easeType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveBasedOnDirection_Public_Static_Void_AnimationDirection_RectTransform_Single_Single_LeanTweenType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe static Vector3 SetPositionBasedOnDirection(Vector3 position, AnimationDirection SlideDirection, float slideValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&position);
		*(AnimationDirection**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &SlideDirection;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &slideValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPositionBasedOnDirection_Public_Static_Vector3_Vector3_AnimationDirection_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static AnimationHelper()
	{
		Il2CppClassPointerStore<AnimationHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Animations", "AnimationHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationHelper>.NativeClassPtr);
		NativeMethodInfoPtr_MoveBasedOnDirection_Public_Static_Void_AnimationDirection_RectTransform_Single_Single_LeanTweenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHelper>.NativeClassPtr, 100679183);
		NativeMethodInfoPtr_SetPositionBasedOnDirection_Public_Static_Vector3_Vector3_AnimationDirection_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationHelper>.NativeClassPtr, 100679184);
	}

	public AnimationHelper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
