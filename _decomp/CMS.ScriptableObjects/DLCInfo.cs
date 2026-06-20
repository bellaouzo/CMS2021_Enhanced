using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnityEngine;

namespace CMS.ScriptableObjects;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class DLCInfo : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Visibility;

	private static readonly System.IntPtr NativeFieldInfoPtr_OrderPC;

	private static readonly System.IntPtr NativeFieldInfoPtr_OrderXbox;

	private static readonly System.IntPtr NativeFieldInfoPtr_OrderPlaystation;

	private static readonly System.IntPtr NativeFieldInfoPtr_Icon;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DLCInfo>.NativeClassPtr));

	public unsafe VisibilityFlags Visibility
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Visibility);
			return *(VisibilityFlags*)num;
		}
		set
		{
			*(VisibilityFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Visibility)) = visibilityFlags;
		}
	}

	public unsafe byte OrderPC
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OrderPC);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OrderPC)) = b;
		}
	}

	public unsafe byte OrderXbox
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OrderXbox);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OrderXbox)) = b;
		}
	}

	public unsafe byte OrderPlaystation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OrderPlaystation);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OrderPlaystation)) = b;
		}
	}

	public unsafe Sprite Icon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Icon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	static DLCInfo()
	{
		Il2CppClassPointerStore<DLCInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.ScriptableObjects", "DLCInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLCInfo>.NativeClassPtr);
		NativeFieldInfoPtr_Visibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLCInfo>.NativeClassPtr, "Visibility");
		NativeFieldInfoPtr_OrderPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLCInfo>.NativeClassPtr, "OrderPC");
		NativeFieldInfoPtr_OrderXbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLCInfo>.NativeClassPtr, "OrderXbox");
		NativeFieldInfoPtr_OrderPlaystation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLCInfo>.NativeClassPtr, "OrderPlaystation");
		NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLCInfo>.NativeClassPtr, "Icon");
	}

	public DLCInfo(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe DLCInfo()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLCInfo>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<DLCInfo>.NativeClassPtr))
	{
	}
}
