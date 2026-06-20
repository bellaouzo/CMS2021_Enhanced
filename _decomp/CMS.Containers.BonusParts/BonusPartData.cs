using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnityEngine;

namespace CMS.Containers.BonusParts;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class BonusPartData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_PathToFile;

	private static readonly System.IntPtr NativeFieldInfoPtr_LocalizedName;

	private static readonly System.IntPtr NativeFieldInfoPtr_go;

	private static readonly System.IntPtr NativeFieldInfoPtr_Type;

	private static readonly System.IntPtr NativeFieldInfoPtr_ModelName;

	private static readonly System.IntPtr NativeFieldInfoPtr_Price;

	private static readonly System.IntPtr NativeFieldInfoPtr_CanPaint;

	private static readonly System.IntPtr NativeFieldInfoPtr_PaintType;

	private static readonly System.IntPtr NativeFieldInfoPtr_PaintData;

	private static readonly System.IntPtr NativeFieldInfoPtr_AssetBundle;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BonusPartData>.NativeClassPtr));

	public unsafe string PathToFile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PathToFile);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PathToFile), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string LocalizedName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LocalizedName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LocalizedName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe GameObject go
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_go);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GameObject(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_go), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SpecialGroup Type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type);
			return *(SpecialGroup*)num;
		}
		set
		{
			*(SpecialGroup*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type)) = specialGroup;
		}
	}

	public unsafe string ModelName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ModelName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ModelName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe int Price
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Price);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Price)) = num;
		}
	}

	public unsafe bool CanPaint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanPaint);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanPaint)) = flag;
		}
	}

	public unsafe PaintType PaintType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PaintType);
			return *(PaintType*)num;
		}
		set
		{
			*(PaintType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PaintType)) = paintType;
		}
	}

	public unsafe PaintData PaintData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PaintData);
			return *(PaintData*)num;
		}
		set
		{
			*(PaintData*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PaintData)) = paintData;
		}
	}

	public unsafe AssetBundle AssetBundle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AssetBundle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new AssetBundle(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AssetBundle), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	static BonusPartData()
	{
		Il2CppClassPointerStore<BonusPartData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers.BonusParts", "BonusPartData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BonusPartData>.NativeClassPtr);
		NativeFieldInfoPtr_PathToFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonusPartData>.NativeClassPtr, "PathToFile");
		NativeFieldInfoPtr_LocalizedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonusPartData>.NativeClassPtr, "LocalizedName");
		NativeFieldInfoPtr_go = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonusPartData>.NativeClassPtr, "go");
		NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonusPartData>.NativeClassPtr, "Type");
		NativeFieldInfoPtr_ModelName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonusPartData>.NativeClassPtr, "ModelName");
		NativeFieldInfoPtr_Price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonusPartData>.NativeClassPtr, "Price");
		NativeFieldInfoPtr_CanPaint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonusPartData>.NativeClassPtr, "CanPaint");
		NativeFieldInfoPtr_PaintType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonusPartData>.NativeClassPtr, "PaintType");
		NativeFieldInfoPtr_PaintData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonusPartData>.NativeClassPtr, "PaintData");
		NativeFieldInfoPtr_AssetBundle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonusPartData>.NativeClassPtr, "AssetBundle");
	}

	public BonusPartData(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe BonusPartData()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BonusPartData>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<BonusPartData>.NativeClassPtr))
	{
	}
}
