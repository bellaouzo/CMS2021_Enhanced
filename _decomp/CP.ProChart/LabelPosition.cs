using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CP.ProChart;

public class LabelPosition : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	private static readonly System.IntPtr NativeFieldInfoPtr_value;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LabelPosition>.NativeClassPtr));

	public unsafe Vector2 position
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_position);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_position)) = vector;
		}
	}

	public unsafe float value
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_value);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_value)) = num;
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 237808, RefRangeEnd = 237810, XrefRangeStart = 237806, XrefRangeEnd = 237808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LabelPosition()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabelPosition>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static LabelPosition()
	{
		Il2CppClassPointerStore<LabelPosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CP.ProChart", "LabelPosition");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabelPosition>.NativeClassPtr);
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelPosition>.NativeClassPtr, "position");
		NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelPosition>.NativeClassPtr, "value");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelPosition>.NativeClassPtr, 100681176);
	}

	public LabelPosition(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
