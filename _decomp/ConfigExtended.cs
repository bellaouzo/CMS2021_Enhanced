using System;
using System.Runtime.CompilerServices;
using INI;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class ConfigExtended : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_configIni;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValueBool_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ConfigExtended>.NativeClassPtr));

	public unsafe static INIUnity configIni
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_configIni, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new INIUnity(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_configIni, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54122, XrefRangeEnd = 54140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetValueBool(string ID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValueBool_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe ConfigExtended()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigExtended>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ConfigExtended()
	{
		Il2CppClassPointerStore<ConfigExtended>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "ConfigExtended");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigExtended>.NativeClassPtr);
		NativeFieldInfoPtr_configIni = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigExtended>.NativeClassPtr, "configIni");
		NativeMethodInfoPtr_GetValueBool_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigExtended>.NativeClassPtr, 100666450);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigExtended>.NativeClassPtr, 100666451);
	}

	public ConfigExtended(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
