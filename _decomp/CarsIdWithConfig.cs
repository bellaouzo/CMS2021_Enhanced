using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

public class CarsIdWithConfig : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_CarID;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConfigVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_DLC;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarsIdWithConfig>.NativeClassPtr));

	public unsafe string CarID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarID), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe int ConfigVersion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigVersion);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfigVersion)) = num;
		}
	}

	public unsafe int DLC
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DLC);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DLC)) = num;
		}
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe CarsIdWithConfig()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarsIdWithConfig>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CarsIdWithConfig()
	{
		Il2CppClassPointerStore<CarsIdWithConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CarsIdWithConfig");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarsIdWithConfig>.NativeClassPtr);
		NativeFieldInfoPtr_CarID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarsIdWithConfig>.NativeClassPtr, "CarID");
		NativeFieldInfoPtr_ConfigVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarsIdWithConfig>.NativeClassPtr, "ConfigVersion");
		NativeFieldInfoPtr_DLC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarsIdWithConfig>.NativeClassPtr, "DLC");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarsIdWithConfig>.NativeClassPtr, 100668655);
	}

	public CarsIdWithConfig(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
