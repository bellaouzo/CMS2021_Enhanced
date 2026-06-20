using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Events;

public class DragSelectRaceRowEventData : EventData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_RaceRow;

	private static readonly System.IntPtr NativeFieldInfoPtr_ListRow;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int16_Int32_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DragSelectRaceRowEventData>.NativeClassPtr));

	public unsafe short RaceRow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RaceRow);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RaceRow)) = num;
		}
	}

	public unsafe int ListRow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListRow);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListRow)) = num;
		}
	}

	[CallerCount(0)]
	public unsafe DragSelectRaceRowEventData(short raceRow, int listRow)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragSelectRaceRowEventData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&raceRow);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &listRow;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int16_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DragSelectRaceRowEventData()
	{
		Il2CppClassPointerStore<DragSelectRaceRowEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Events", "DragSelectRaceRowEventData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragSelectRaceRowEventData>.NativeClassPtr);
		NativeFieldInfoPtr_RaceRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragSelectRaceRowEventData>.NativeClassPtr, "RaceRow");
		NativeFieldInfoPtr_ListRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragSelectRaceRowEventData>.NativeClassPtr, "ListRow");
		NativeMethodInfoPtr__ctor_Public_Void_Int16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragSelectRaceRowEventData>.NativeClassPtr, 100679688);
	}

	public DragSelectRaceRowEventData(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
