using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Rewired;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace CMS.Containers;

public class RebindButton : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ID;

	private static readonly System.IntPtr NativeFieldInfoPtr_CategoryType;

	private static readonly System.IntPtr NativeFieldInfoPtr_ActionID;

	private static readonly System.IntPtr NativeFieldInfoPtr_ARange;

	private static readonly System.IntPtr NativeFieldInfoPtr_AContribution;

	private static readonly System.IntPtr NativeFieldInfoPtr_KeyToAssign;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<RebindButton>.NativeClassPtr));

	public unsafe string ID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string CategoryType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CategoryType);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CategoryType), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe int ActionID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ActionID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ActionID)) = num;
		}
	}

	public unsafe AxisRange ARange
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ARange);
			return System.Runtime.CompilerServices.Unsafe.Read<AxisRange>((void*)num);
		}
		set
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			System.Runtime.CompilerServices.Unsafe.Write((void*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ARange)), val);
		}
	}

	public unsafe Pole AContribution
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AContribution);
			return System.Runtime.CompilerServices.Unsafe.Read<Pole>((void*)num);
		}
		set
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			System.Runtime.CompilerServices.Unsafe.Write((void*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AContribution)), val);
		}
	}

	public unsafe KeyCode KeyToAssign
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_KeyToAssign);
			return *(KeyCode*)num;
		}
		set
		{
			*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_KeyToAssign)) = keyCode;
		}
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe RebindButton()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RebindButton>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static RebindButton()
	{
		Il2CppClassPointerStore<RebindButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers", "RebindButton");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RebindButton>.NativeClassPtr);
		NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindButton>.NativeClassPtr, "ID");
		NativeFieldInfoPtr_CategoryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindButton>.NativeClassPtr, "CategoryType");
		NativeFieldInfoPtr_ActionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindButton>.NativeClassPtr, "ActionID");
		NativeFieldInfoPtr_ARange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindButton>.NativeClassPtr, "ARange");
		NativeFieldInfoPtr_AContribution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindButton>.NativeClassPtr, "AContribution");
		NativeFieldInfoPtr_KeyToAssign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindButton>.NativeClassPtr, "KeyToAssign");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindButton>.NativeClassPtr, 100679788);
	}

	public RebindButton(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
