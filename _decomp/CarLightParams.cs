using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

[System.Serializable]
public class CarLightParams : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_Position;

	private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_Handle;

	private static readonly System.IntPtr NativeFieldInfoPtr_Intensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_Range;

	private static readonly System.IntPtr NativeFieldInfoPtr_Angle;

	private static readonly System.IntPtr NativeFieldInfoPtr_LightColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_CookieName;

	private static readonly System.IntPtr NativeFieldInfoPtr_Parent;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarLightParams>.NativeClassPtr));

	public unsafe string Name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe Vector3 Position
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Position);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Position)) = vector;
		}
	}

	public unsafe Vector3 Rotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rotation);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rotation)) = vector;
		}
	}

	public unsafe GameObject Handle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Handle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Handle), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float Intensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Intensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Intensity)) = num;
		}
	}

	public unsafe float Range
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Range);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Range)) = num;
		}
	}

	public unsafe float Angle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Angle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Angle)) = num;
		}
	}

	public unsafe string LightColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LightColor);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LightColor), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string CookieName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CookieName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CookieName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe Transform Parent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Parent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Transform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Parent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 92704, RefRangeEnd = 92706, XrefRangeStart = 92650, XrefRangeEnd = 92704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Create()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 92754, RefRangeEnd = 92767, XrefRangeStart = 92706, XrefRangeEnd = 92754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Set()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Set_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe CarLightParams()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarLightParams>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CarLightParams()
	{
		Il2CppClassPointerStore<CarLightParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CarLightParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarLightParams>.NativeClassPtr);
		NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarLightParams>.NativeClassPtr, "Name");
		NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarLightParams>.NativeClassPtr, "Position");
		NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarLightParams>.NativeClassPtr, "Rotation");
		NativeFieldInfoPtr_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarLightParams>.NativeClassPtr, "Handle");
		NativeFieldInfoPtr_Intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarLightParams>.NativeClassPtr, "Intensity");
		NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarLightParams>.NativeClassPtr, "Range");
		NativeFieldInfoPtr_Angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarLightParams>.NativeClassPtr, "Angle");
		NativeFieldInfoPtr_LightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarLightParams>.NativeClassPtr, "LightColor");
		NativeFieldInfoPtr_CookieName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarLightParams>.NativeClassPtr, "CookieName");
		NativeFieldInfoPtr_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarLightParams>.NativeClassPtr, "Parent");
		NativeMethodInfoPtr_Create_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLightParams>.NativeClassPtr, 100668594);
		NativeMethodInfoPtr_Set_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLightParams>.NativeClassPtr, 100668595);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLightParams>.NativeClassPtr, 100668596);
	}

	public CarLightParams(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
