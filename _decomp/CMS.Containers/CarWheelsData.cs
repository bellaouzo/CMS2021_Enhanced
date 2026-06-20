using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Containers;

[System.Serializable]
public class CarWheelsData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Wheels;

	private static readonly System.IntPtr NativeFieldInfoPtr_OriginalWheels;

	private static readonly System.IntPtr NativeFieldInfoPtr_WheelsColors;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarWheelsData>.NativeClassPtr));

	public unsafe Il2CppReferenceArray<Wheel> Wheels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Wheels);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Wheel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Wheels), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<Wheel> OriginalWheels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OriginalWheels);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Wheel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OriginalWheels), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<WheelColorData> WheelsColors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WheelsColors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<WheelColorData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WheelsColors), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 218348, RefRangeEnd = 218352, XrefRangeStart = 218340, XrefRangeEnd = 218348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CarWheelsData(int wheelsCount)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarWheelsData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&wheelsCount);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CarWheelsData()
	{
		Il2CppClassPointerStore<CarWheelsData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers", "CarWheelsData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarWheelsData>.NativeClassPtr);
		NativeFieldInfoPtr_Wheels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarWheelsData>.NativeClassPtr, "Wheels");
		NativeFieldInfoPtr_OriginalWheels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarWheelsData>.NativeClassPtr, "OriginalWheels");
		NativeFieldInfoPtr_WheelsColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarWheelsData>.NativeClassPtr, "WheelsColors");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarWheelsData>.NativeClassPtr, 100679747);
	}

	public CarWheelsData(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
