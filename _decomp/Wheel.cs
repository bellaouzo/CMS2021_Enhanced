using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[System.Serializable]
public class Wheel : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Tire;

	private static readonly System.IntPtr NativeFieldInfoPtr_Rim;

	private static readonly System.IntPtr NativeFieldInfoPtr_Width;

	private static readonly System.IntPtr NativeFieldInfoPtr_Size;

	private static readonly System.IntPtr NativeFieldInfoPtr_Profile;

	private static readonly System.IntPtr NativeFieldInfoPtr_ET;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Wheel_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Wheel>.NativeClassPtr));

	public unsafe string Tire
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Tire);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Tire), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string Rim
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rim);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rim), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe float Width
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Width);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Width)) = num;
		}
	}

	public unsafe float Size
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Size);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Size)) = num;
		}
	}

	public unsafe float Profile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Profile);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Profile)) = num;
		}
	}

	public unsafe int ET
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ET);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ET)) = num;
		}
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 93419, RefRangeEnd = 93425, XrefRangeStart = 93419, XrefRangeEnd = 93419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Wheel()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Wheel>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 93425, RefRangeEnd = 93428, XrefRangeStart = 93425, XrefRangeEnd = 93425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Wheel(Wheel wheel)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Wheel>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(wheel);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Wheel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Wheel()
	{
		Il2CppClassPointerStore<Wheel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "Wheel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Wheel>.NativeClassPtr);
		NativeFieldInfoPtr_Tire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "Tire");
		NativeFieldInfoPtr_Rim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "Rim");
		NativeFieldInfoPtr_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "Width");
		NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "Size");
		NativeFieldInfoPtr_Profile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "Profile");
		NativeFieldInfoPtr_ET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "ET");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100668689);
		NativeMethodInfoPtr__ctor_Public_Void_Wheel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100668690);
	}

	public Wheel(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
