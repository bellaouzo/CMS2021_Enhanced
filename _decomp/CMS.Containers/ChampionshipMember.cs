using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Containers;

public class ChampionshipMember : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_UID;

	private static readonly System.IntPtr NativeFieldInfoPtr_MemberName;

	private static readonly System.IntPtr NativeFieldInfoPtr_CarID;

	private static readonly System.IntPtr NativeFieldInfoPtr_CarConfig;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ChampionshipMember>.NativeClassPtr));

	public unsafe ushort UID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UID);
			return *(ushort*)num;
		}
		set
		{
			*(ushort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UID)) = num;
		}
	}

	public unsafe string MemberName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MemberName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MemberName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

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

	public unsafe int CarConfig
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarConfig);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarConfig)) = num;
		}
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe ChampionshipMember()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChampionshipMember>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ChampionshipMember()
	{
		Il2CppClassPointerStore<ChampionshipMember>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Containers", "ChampionshipMember");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChampionshipMember>.NativeClassPtr);
		NativeFieldInfoPtr_UID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChampionshipMember>.NativeClassPtr, "UID");
		NativeFieldInfoPtr_MemberName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChampionshipMember>.NativeClassPtr, "MemberName");
		NativeFieldInfoPtr_CarID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChampionshipMember>.NativeClassPtr, "CarID");
		NativeFieldInfoPtr_CarConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChampionshipMember>.NativeClassPtr, "CarConfig");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChampionshipMember>.NativeClassPtr, 100679748);
	}

	public ChampionshipMember(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
