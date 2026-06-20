using System;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace CMS.UI.Logic;

[System.Flags]
public enum OrderIconType
{
	None = 0,
	Engine = 1,
	Timing = 2,
	Suspension = 4,
	Brakes = 8,
	Exhaust = 0x10,
	Gearbox = 0x20,
	Oil = 0x40,
	Body = 0x80,
	Tuning = 0x100,
	// error: nested types are not permitted in C#.
	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<OrderIconType>.NativeClassPtr));
	,
	// error: nested types are not permitted in C#.
	static OrderIconType()
	{
		Il2CppClassPointerStore<OrderIconType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic", "OrderIconType");
	}

}
