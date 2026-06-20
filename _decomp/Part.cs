using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

[System.Serializable]
public class Part : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_p_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_p_position;

	private static readonly System.IntPtr NativeFieldInfoPtr_p_rotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_p_scale;

	private static readonly System.IntPtr NativeFieldInfoPtr_p_reflection;

	private static readonly System.IntPtr NativeFieldInfoPtr_p_handle;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Part>.NativeClassPtr));

	public unsafe string p_name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p_name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p_name), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe Vector3 p_position
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p_position);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p_position)) = vector;
		}
	}

	public unsafe Vector3 p_rotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p_rotation);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p_rotation)) = vector;
		}
	}

	public unsafe float p_scale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p_scale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p_scale)) = num;
		}
	}

	public unsafe bool p_reflection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p_reflection);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p_reflection)) = flag;
		}
	}

	public unsafe GameObject p_handle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p_handle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p_handle), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe Part()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Part>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Part()
	{
		Il2CppClassPointerStore<Part>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "Part");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Part>.NativeClassPtr);
		NativeFieldInfoPtr_p_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "p_name");
		NativeFieldInfoPtr_p_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "p_position");
		NativeFieldInfoPtr_p_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "p_rotation");
		NativeFieldInfoPtr_p_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "p_scale");
		NativeFieldInfoPtr_p_reflection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "p_reflection");
		NativeFieldInfoPtr_p_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Part>.NativeClassPtr, "p_handle");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Part>.NativeClassPtr, 100668676);
	}

	public Part(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
