using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace CMS.Tracks.Dragstrip;

[StructLayout(LayoutKind.Explicit)]
public struct DragstripRandomOpponentBasicData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Index;

	private static readonly System.IntPtr NativeFieldInfoPtr_PerformanceIndexStock;

	[FieldOffset(0)]
	public int Index;

	[FieldOffset(4)]
	public float PerformanceIndexStock;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DragstripRandomOpponentBasicData>.NativeClassPtr));

	static DragstripRandomOpponentBasicData()
	{
		Il2CppClassPointerStore<DragstripRandomOpponentBasicData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Tracks.Dragstrip", "DragstripRandomOpponentBasicData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragstripRandomOpponentBasicData>.NativeClassPtr);
		NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragstripRandomOpponentBasicData>.NativeClassPtr, "Index");
		NativeFieldInfoPtr_PerformanceIndexStock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragstripRandomOpponentBasicData>.NativeClassPtr, "PerformanceIndexStock");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DragstripRandomOpponentBasicData>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
