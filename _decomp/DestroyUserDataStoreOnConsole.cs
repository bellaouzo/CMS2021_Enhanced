using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Rewired.Data;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class DestroyUserDataStoreOnConsole : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_userDataStore;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DestroyUserDataStoreOnConsole>.NativeClassPtr));

	public unsafe UserDataStore userDataStore
	{
		get
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_userDataStore);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr == (System.IntPtr)0) ? ((UserDataStore)null) : new UserDataStore(intPtr);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_userDataStore), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe DestroyUserDataStoreOnConsole()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DestroyUserDataStoreOnConsole>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DestroyUserDataStoreOnConsole()
	{
		Il2CppClassPointerStore<DestroyUserDataStoreOnConsole>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "DestroyUserDataStoreOnConsole");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyUserDataStoreOnConsole>.NativeClassPtr);
		NativeFieldInfoPtr_userDataStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyUserDataStoreOnConsole>.NativeClassPtr, "userDataStore");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyUserDataStoreOnConsole>.NativeClassPtr, 100666681);
	}

	public DestroyUserDataStoreOnConsole(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
