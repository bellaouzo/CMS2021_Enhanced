using System;
using Il2CppSystem;
using UnhollowerBaseLib;

public enum PathTestDescType
{
	FrontBrakes,
	RearBrakes,
	HoldBrake,
	FrontSusp,
	RearSusp,
	Wait,
	TestComplete,
	// error: nested types are not permitted in C#.
	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PathTestDescType>.NativeClassPtr));
	,
	// error: nested types are not permitted in C#.
	static PathTestDescType()
	{
		Il2CppClassPointerStore<PathTestDescType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "PathTestDescType");
	}

}
