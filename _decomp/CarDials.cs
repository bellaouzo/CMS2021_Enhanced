using System;
using System.Runtime.CompilerServices;
using CMS.FileSupport.INI;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

public class CarDials : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_bg;

	private static readonly System.IntPtr NativeFieldInfoPtr_needleSprite;

	private static readonly System.IntPtr NativeFieldInfoPtr_dialSprite;

	private static readonly System.IntPtr NativeFieldInfoPtr_unitsText;

	private static readonly System.IntPtr NativeFieldInfoPtr_speedoValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_gearValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadOnStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_testProcedure;

	private static readonly System.IntPtr NativeFieldInfoPtr_angles;

	private static readonly System.IntPtr NativeFieldInfoPtr_rpms;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentGear;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_useWithScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_rpmMaxAngleUnderScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_rpmToScale;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupUnits_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadDial_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateSprite_Private_Void_String_Image_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadDialColors_Private_Void_IniData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGear_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSpeed_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRpm_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarDials>.NativeClassPtr));

	public unsafe Image bg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bg);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bg), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image needleSprite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needleSprite);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needleSprite), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image dialSprite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialSprite);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialSprite), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text unitsText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitsText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitsText), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text speedoValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedoValue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedoValue), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text gearValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearValue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gearValue), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe string loadOnStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadOnStart);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadOnStart), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe bool testProcedure
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_testProcedure);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_testProcedure)) = flag;
		}
	}

	public unsafe Vector2 angles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angles);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angles)) = vector;
		}
	}

	public unsafe Vector2 rpms
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpms);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpms)) = vector;
		}
	}

	public unsafe int currentGear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentGear);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentGear)) = num;
		}
	}

	public unsafe float currentSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSpeed)) = num;
		}
	}

	public unsafe bool useWithScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useWithScale);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useWithScale)) = flag;
		}
	}

	public unsafe float rpmMaxAngleUnderScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmMaxAngleUnderScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmMaxAngleUnderScale)) = num;
		}
	}

	public unsafe float rpmToScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmToScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmToScale)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22526, XrefRangeEnd = 22536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupUnits()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupUnits_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 22600, RefRangeEnd = 22601, XrefRangeStart = 22536, XrefRangeEnd = 22600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadDial(string dialName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(dialName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadDial_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 22618, RefRangeEnd = 22620, XrefRangeStart = 22601, XrefRangeEnd = 22618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateSprite(string path, Image image, Vector2 pivot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(image);
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pivot;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSprite_Private_Void_String_Image_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 22670, RefRangeEnd = 22671, XrefRangeStart = 22620, XrefRangeEnd = 22670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadDialColors(IniData ini)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ini);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadDialColors_Private_Void_IniData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22671, XrefRangeEnd = 22679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGear(int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGear_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 22689, RefRangeEnd = 22691, XrefRangeStart = 22679, XrefRangeEnd = 22689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSpeed(float speedKMH)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&speedKMH);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSpeed_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 22703, RefRangeEnd = 22705, XrefRangeStart = 22691, XrefRangeEnd = 22703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRpm(float rpm)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rpm);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRpm_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22705, XrefRangeEnd = 22710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CarDials()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarDials>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CarDials()
	{
		Il2CppClassPointerStore<CarDials>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CarDials");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarDials>.NativeClassPtr);
		NativeFieldInfoPtr_bg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarDials>.NativeClassPtr, "bg");
		NativeFieldInfoPtr_needleSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarDials>.NativeClassPtr, "needleSprite");
		NativeFieldInfoPtr_dialSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarDials>.NativeClassPtr, "dialSprite");
		NativeFieldInfoPtr_unitsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarDials>.NativeClassPtr, "unitsText");
		NativeFieldInfoPtr_speedoValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarDials>.NativeClassPtr, "speedoValue");
		NativeFieldInfoPtr_gearValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarDials>.NativeClassPtr, "gearValue");
		NativeFieldInfoPtr_loadOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarDials>.NativeClassPtr, "loadOnStart");
		NativeFieldInfoPtr_testProcedure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarDials>.NativeClassPtr, "testProcedure");
		NativeFieldInfoPtr_angles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarDials>.NativeClassPtr, "angles");
		NativeFieldInfoPtr_rpms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarDials>.NativeClassPtr, "rpms");
		NativeFieldInfoPtr_currentGear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarDials>.NativeClassPtr, "currentGear");
		NativeFieldInfoPtr_currentSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarDials>.NativeClassPtr, "currentSpeed");
		NativeFieldInfoPtr_useWithScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarDials>.NativeClassPtr, "useWithScale");
		NativeFieldInfoPtr_rpmMaxAngleUnderScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarDials>.NativeClassPtr, "rpmMaxAngleUnderScale");
		NativeFieldInfoPtr_rpmToScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarDials>.NativeClassPtr, "rpmToScale");
		NativeMethodInfoPtr_SetupUnits_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarDials>.NativeClassPtr, 100664918);
		NativeMethodInfoPtr_LoadDial_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarDials>.NativeClassPtr, 100664919);
		NativeMethodInfoPtr_CreateSprite_Private_Void_String_Image_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarDials>.NativeClassPtr, 100664920);
		NativeMethodInfoPtr_LoadDialColors_Private_Void_IniData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarDials>.NativeClassPtr, 100664921);
		NativeMethodInfoPtr_SetGear_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarDials>.NativeClassPtr, 100664922);
		NativeMethodInfoPtr_SetSpeed_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarDials>.NativeClassPtr, 100664923);
		NativeMethodInfoPtr_SetRpm_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarDials>.NativeClassPtr, 100664924);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarDials>.NativeClassPtr, 100664925);
	}

	public CarDials(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
