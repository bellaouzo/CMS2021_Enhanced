using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Platforms.Base;

[System.Serializable]
[StructLayout(LayoutKind.Sequential)]
public sealed class Achievement : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ID;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConsoleID;

	private static readonly System.IntPtr NativeFieldInfoPtr_RelatedStatID;

	private static readonly System.IntPtr NativeFieldInfoPtr_MinProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_isUnlocked;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanBeUnlocked_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unlock_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Lock_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsUnlocked_Public_Boolean_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Achievement>.NativeClassPtr));

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

	public unsafe int ConsoleID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConsoleID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConsoleID)) = num;
		}
	}

	public unsafe string RelatedStatID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RelatedStatID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RelatedStatID), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe int MinProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinProgress);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinProgress)) = num;
		}
	}

	public unsafe int MaxProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxProgress);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxProgress)) = num;
		}
	}

	public unsafe int CurrentProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentProgress);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentProgress)) = num;
		}
	}

	public unsafe bool isUnlocked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isUnlocked);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isUnlocked)) = flag;
		}
	}

	[CallerCount(0)]
	public unsafe Achievement(string id, int consoleID, string relatedStatID, int minProgress, int maxProgress)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &consoleID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(relatedStatID);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &minProgress;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxProgress;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool CanBeUnlocked()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanBeUnlocked_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe void Unlock()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unlock_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void Lock()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Lock_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool IsUnlocked()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsUnlocked_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static Achievement()
	{
		Il2CppClassPointerStore<Achievement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Platforms.Base", "Achievement");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Achievement>.NativeClassPtr);
		NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievement>.NativeClassPtr, "ID");
		NativeFieldInfoPtr_ConsoleID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievement>.NativeClassPtr, "ConsoleID");
		NativeFieldInfoPtr_RelatedStatID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievement>.NativeClassPtr, "RelatedStatID");
		NativeFieldInfoPtr_MinProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievement>.NativeClassPtr, "MinProgress");
		NativeFieldInfoPtr_MaxProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievement>.NativeClassPtr, "MaxProgress");
		NativeFieldInfoPtr_CurrentProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievement>.NativeClassPtr, "CurrentProgress");
		NativeFieldInfoPtr_isUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievement>.NativeClassPtr, "isUnlocked");
		NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement>.NativeClassPtr, 100680594);
		NativeMethodInfoPtr_CanBeUnlocked_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement>.NativeClassPtr, 100680595);
		NativeMethodInfoPtr_Unlock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement>.NativeClassPtr, 100680596);
		NativeMethodInfoPtr_Lock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement>.NativeClassPtr, 100680597);
		NativeMethodInfoPtr_IsUnlocked_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement>.NativeClassPtr, 100680598);
	}

	public Achievement(System.IntPtr P_0)
		: base(P_0)
	{
	}

	public unsafe Achievement()
		: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Achievement>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<Achievement>.NativeClassPtr))
	{
	}
}
