using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.UI.Logic.CarInfo;

public class CarInfoPart : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_Condition;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsUnmounted;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsExamined;

	private static readonly System.IntPtr NativeFieldInfoPtr_CanBeMarked;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsMarked;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsMissingID;

	private static readonly System.IntPtr NativeFieldInfoPtr_MarkAction;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CarInfoPart>.NativeClassPtr));

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

	public unsafe float Condition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Condition);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Condition)) = num;
		}
	}

	public unsafe bool IsUnmounted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsUnmounted);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsUnmounted)) = flag;
		}
	}

	public unsafe bool IsExamined
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsExamined);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsExamined)) = flag;
		}
	}

	public unsafe bool CanBeMarked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanBeMarked);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanBeMarked)) = flag;
		}
	}

	public unsafe bool IsMarked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsMarked);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsMarked)) = flag;
		}
	}

	public unsafe bool IsMissingID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsMissingID);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsMissingID)) = flag;
		}
	}

	public unsafe Il2CppSystem.Action<bool> MarkAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MarkAction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<bool>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MarkAction), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe CarInfoPart()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarInfoPart>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CarInfoPart()
	{
		Il2CppClassPointerStore<CarInfoPart>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.CarInfo", "CarInfoPart");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarInfoPart>.NativeClassPtr);
		NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarInfoPart>.NativeClassPtr, "Name");
		NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarInfoPart>.NativeClassPtr, "Condition");
		NativeFieldInfoPtr_IsUnmounted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarInfoPart>.NativeClassPtr, "IsUnmounted");
		NativeFieldInfoPtr_IsExamined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarInfoPart>.NativeClassPtr, "IsExamined");
		NativeFieldInfoPtr_CanBeMarked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarInfoPart>.NativeClassPtr, "CanBeMarked");
		NativeFieldInfoPtr_IsMarked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarInfoPart>.NativeClassPtr, "IsMarked");
		NativeFieldInfoPtr_IsMissingID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarInfoPart>.NativeClassPtr, "IsMissingID");
		NativeFieldInfoPtr_MarkAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarInfoPart>.NativeClassPtr, "MarkAction");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarInfoPart>.NativeClassPtr, 100678508);
	}

	public CarInfoPart(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
