using System;
using System.Runtime.CompilerServices;
using INI;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class HUD : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_config;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainText;

	private static readonly System.IntPtr NativeFieldInfoPtr_secondaryText;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstNumber;

	private static readonly System.IntPtr NativeFieldInfoPtr_secondNumber;

	private static readonly System.IntPtr NativeFieldInfoPtr_HUDColor;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<HUD>.NativeClassPtr));

	public unsafe INIUnity config
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_config);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new INIUnity(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_config), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe string mainText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainText);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainText), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string secondaryText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondaryText);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondaryText), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe int firstNumber
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstNumber);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstNumber)) = num;
		}
	}

	public unsafe float secondNumber
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondNumber);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondNumber)) = num;
		}
	}

	public unsafe Color HUDColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HUDColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HUDColor)) = color;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1934, XrefRangeEnd = 2010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2010, XrefRangeEnd = 2041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2107, RefRangeEnd = 2108, XrefRangeStart = 2041, XrefRangeEnd = 2107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Save()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe HUD()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HUD>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static HUD()
	{
		Il2CppClassPointerStore<HUD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "HUD");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HUD>.NativeClassPtr);
		NativeFieldInfoPtr_config = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "config");
		NativeFieldInfoPtr_mainText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "mainText");
		NativeFieldInfoPtr_secondaryText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "secondaryText");
		NativeFieldInfoPtr_firstNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "firstNumber");
		NativeFieldInfoPtr_secondNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "secondNumber");
		NativeFieldInfoPtr_HUDColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "HUDColor");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100663402);
		NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100663403);
		NativeMethodInfoPtr_Save_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100663404);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100663405);
	}

	public HUD(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
