using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class MarkPoint : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_pos;

	private static readonly System.IntPtr NativeFieldInfoPtr_normal;

	private static readonly System.IntPtr NativeFieldInfoPtr_tangent;

	private static readonly System.IntPtr NativeFieldInfoPtr_posl;

	private static readonly System.IntPtr NativeFieldInfoPtr_posr;

	private static readonly System.IntPtr NativeFieldInfoPtr_intensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastIndex;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MarkPoint>.NativeClassPtr));

	public unsafe Vector3 pos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos)) = vector;
		}
	}

	public unsafe Vector3 normal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normal);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normal)) = vector;
		}
	}

	public unsafe Vector4 tangent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tangent);
			return *(Vector4*)num;
		}
		set
		{
			*(Vector4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tangent)) = vector;
		}
	}

	public unsafe Vector3 posl
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posl);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posl)) = vector;
		}
	}

	public unsafe Vector3 posr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posr);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posr)) = vector;
		}
	}

	public unsafe float intensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intensity)) = num;
		}
	}

	public unsafe int lastIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastIndex)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110996, XrefRangeEnd = 111006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MarkPoint()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MarkPoint>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MarkPoint()
	{
		Il2CppClassPointerStore<MarkPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "MarkPoint");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MarkPoint>.NativeClassPtr);
		NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkPoint>.NativeClassPtr, "pos");
		NativeFieldInfoPtr_normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkPoint>.NativeClassPtr, "normal");
		NativeFieldInfoPtr_tangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkPoint>.NativeClassPtr, "tangent");
		NativeFieldInfoPtr_posl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkPoint>.NativeClassPtr, "posl");
		NativeFieldInfoPtr_posr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkPoint>.NativeClassPtr, "posr");
		NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkPoint>.NativeClassPtr, "intensity");
		NativeFieldInfoPtr_lastIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkPoint>.NativeClassPtr, "lastIndex");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkPoint>.NativeClassPtr, 100670307);
	}

	public MarkPoint(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
