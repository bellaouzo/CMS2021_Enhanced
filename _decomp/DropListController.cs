using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

public class DropListController : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_rpmDropdownList;

	private static readonly System.IntPtr NativeFieldInfoPtr_gasPedalButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_gasPedalPressingCheckbox;

	private static readonly System.IntPtr NativeFieldInfoPtr_sounds;

	private static readonly System.IntPtr NativeMethodInfoPtr_ControllRPM_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DropListController>.NativeClassPtr));

	public unsafe Dropdown rpmDropdownList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmDropdownList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Dropdown(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rpmDropdownList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject gasPedalButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gasPedalButton);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gasPedalButton), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Toggle gasPedalPressingCheckbox
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gasPedalPressingCheckbox);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Toggle(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gasPedalPressingCheckbox), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> sounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sounds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sounds), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10610, XrefRangeEnd = 10639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ControllRPM()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ControllRPM_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe DropListController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropListController>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DropListController()
	{
		Il2CppClassPointerStore<DropListController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "DropListController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropListController>.NativeClassPtr);
		NativeFieldInfoPtr_rpmDropdownList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropListController>.NativeClassPtr, "rpmDropdownList");
		NativeFieldInfoPtr_gasPedalButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropListController>.NativeClassPtr, "gasPedalButton");
		NativeFieldInfoPtr_gasPedalPressingCheckbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropListController>.NativeClassPtr, "gasPedalPressingCheckbox");
		NativeFieldInfoPtr_sounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropListController>.NativeClassPtr, "sounds");
		NativeMethodInfoPtr_ControllRPM_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropListController>.NativeClassPtr, 100664193);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropListController>.NativeClassPtr, 100664194);
	}

	public DropListController(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
