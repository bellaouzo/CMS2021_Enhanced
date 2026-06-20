using System;
using Il2CppSystem;
using UnhollowerBaseLib;

public enum TweenAction
{
	MOVE_X,
	MOVE_Y,
	MOVE_Z,
	MOVE_LOCAL_X,
	MOVE_LOCAL_Y,
	MOVE_LOCAL_Z,
	MOVE_CURVED,
	MOVE_CURVED_LOCAL,
	MOVE_SPLINE,
	MOVE_SPLINE_LOCAL,
	SCALE_X,
	SCALE_Y,
	SCALE_Z,
	ROTATE_X,
	ROTATE_Y,
	ROTATE_Z,
	ROTATE_AROUND,
	ROTATE_AROUND_LOCAL,
	CANVAS_ROTATEAROUND,
	CANVAS_ROTATEAROUND_LOCAL,
	CANVAS_PLAYSPRITE,
	ALPHA,
	TEXT_ALPHA,
	CANVAS_ALPHA,
	CANVASGROUP_ALPHA,
	ALPHA_VERTEX,
	COLOR,
	CALLBACK_COLOR,
	TEXT_COLOR,
	CANVAS_COLOR,
	CANVAS_MOVE_X,
	CANVAS_MOVE_Y,
	CANVAS_MOVE_Z,
	CALLBACK,
	MOVE,
	MOVE_LOCAL,
	MOVE_TO_TRANSFORM,
	ROTATE,
	ROTATE_LOCAL,
	SCALE,
	VALUE3,
	GUI_MOVE,
	GUI_MOVE_MARGIN,
	GUI_SCALE,
	GUI_ALPHA,
	GUI_ROTATE,
	DELAYED_SOUND,
	CANVAS_MOVE,
	CANVAS_SCALE,
	CANVAS_SIZEDELTA,
	// error: nested types are not permitted in C#.
	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TweenAction>.NativeClassPtr));
	,
	// error: nested types are not permitted in C#.
	static TweenAction()
	{
		Il2CppClassPointerStore<TweenAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "TweenAction");
	}

}
