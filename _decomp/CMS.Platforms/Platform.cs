using System;
using System.Runtime.CompilerServices;
using CMS.Platforms.Base;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.Platforms;

public class Platform : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_AchievementSystem;

	private static readonly System.IntPtr NativeFieldInfoPtr_DLCSystem;

	private static readonly System.IntPtr NativeFieldInfoPtr_ModsSystem;

	private static readonly System.IntPtr NativeFieldInfoPtr_PresenceSystems;

	private static readonly System.IntPtr NativeFieldInfoPtr_SaveSystem;

	private static readonly System.IntPtr NativeFieldInfoPtr_SettingsSystem;

	private static readonly System.IntPtr NativeFieldInfoPtr_Utils;

	private static readonly System.IntPtr NativeFieldInfoPtr_Keyboard;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_IEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Platform>.NativeClassPtr));

	public unsafe BaseAchievements AchievementSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AchievementSystem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new BaseAchievements(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AchievementSystem), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BaseDLC DLCSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DLCSystem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new BaseDLC(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DLCSystem), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BaseMods ModsSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ModsSystem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new BaseMods(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ModsSystem), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<BasePresence> PresenceSystems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PresenceSystems);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<BasePresence>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PresenceSystems), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BaseSave SaveSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SaveSystem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new BaseSave(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SaveSystem), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BaseSettings SettingsSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SettingsSystem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new BaseSettings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SettingsSystem), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BaseUtils Utils
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Utils);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new BaseUtils(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Utils), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BaseKeyboard Keyboard
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Keyboard);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new BaseKeyboard(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Keyboard), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	public unsafe IEnumerator Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe Platform()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Platform>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Platform()
	{
		Il2CppClassPointerStore<Platform>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Platforms", "Platform");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Platform>.NativeClassPtr);
		NativeFieldInfoPtr_AchievementSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Platform>.NativeClassPtr, "AchievementSystem");
		NativeFieldInfoPtr_DLCSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Platform>.NativeClassPtr, "DLCSystem");
		NativeFieldInfoPtr_ModsSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Platform>.NativeClassPtr, "ModsSystem");
		NativeFieldInfoPtr_PresenceSystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Platform>.NativeClassPtr, "PresenceSystems");
		NativeFieldInfoPtr_SaveSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Platform>.NativeClassPtr, "SaveSystem");
		NativeFieldInfoPtr_SettingsSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Platform>.NativeClassPtr, "SettingsSystem");
		NativeFieldInfoPtr_Utils = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Platform>.NativeClassPtr, "Utils");
		NativeFieldInfoPtr_Keyboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Platform>.NativeClassPtr, "Keyboard");
		NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Platform>.NativeClassPtr, 100680297);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Platform>.NativeClassPtr, 100680298);
	}

	public Platform(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
