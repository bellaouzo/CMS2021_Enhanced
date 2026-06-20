using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.UI.Animations;

public static class AnimationSystem : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Animate_Public_Static_Void_Animation_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AnimationSystem>.NativeClassPtr));

	[CallerCount(0)]
	public unsafe static void Animate(Animation animation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(animation);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Animate_Public_Static_Void_Animation_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static AnimationSystem()
	{
		Il2CppClassPointerStore<AnimationSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Animations", "AnimationSystem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationSystem>.NativeClassPtr);
		NativeMethodInfoPtr_Animate_Public_Static_Void_Animation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSystem>.NativeClassPtr, 100679185);
	}

	public AnimationSystem(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
