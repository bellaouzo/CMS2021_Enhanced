using System;
using Il2CppSystem;
using UnhollowerBaseLib;

public enum LeanTweenType
{
	notUsed,
	linear,
	easeOutQuad,
	easeInQuad,
	easeInOutQuad,
	easeInCubic,
	easeOutCubic,
	easeInOutCubic,
	easeInQuart,
	easeOutQuart,
	easeInOutQuart,
	easeInQuint,
	easeOutQuint,
	easeInOutQuint,
	easeInSine,
	easeOutSine,
	easeInOutSine,
	easeInExpo,
	easeOutExpo,
	easeInOutExpo,
	easeInCirc,
	easeOutCirc,
	easeInOutCirc,
	easeInBounce,
	easeOutBounce,
	easeInOutBounce,
	easeInBack,
	easeOutBack,
	easeInOutBack,
	easeInElastic,
	easeOutElastic,
	easeInOutElastic,
	easeSpring,
	easeShake,
	punch,
	once,
	clamp,
	pingPong,
	animationCurve,
	// error: nested types are not permitted in C#.
	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LeanTweenType>.NativeClassPtr));
	,
	// error: nested types are not permitted in C#.
	static LeanTweenType()
	{
		Il2CppClassPointerStore<LeanTweenType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "LeanTweenType");
	}

}
