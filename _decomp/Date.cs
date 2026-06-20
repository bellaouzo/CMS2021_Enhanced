using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[System.Serializable]
public class Date : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_day;

	private static readonly System.IntPtr NativeFieldInfoPtr_month;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Date>.NativeClassPtr));

	public unsafe int day
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_day);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_day)) = num;
		}
	}

	public unsafe int month
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_month);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_month)) = num;
		}
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe Date()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Date>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Date()
	{
		Il2CppClassPointerStore<Date>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "Date");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Date>.NativeClassPtr);
		NativeFieldInfoPtr_day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Date>.NativeClassPtr, "day");
		NativeFieldInfoPtr_month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Date>.NativeClassPtr, "month");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Date>.NativeClassPtr, 100665946);
	}

	public Date(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
