using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

public class DevTools : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_DevMode;

	private static readonly System.IntPtr NativeMethodInfoPtr_Debug_Public_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DevTools>.NativeClassPtr));

	public unsafe static bool DevMode
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DevMode, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DevMode, &flag);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43355, XrefRangeEnd = 43363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Debug(Il2CppSystem.Object message)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Debug_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe DevTools()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DevTools>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DevTools()
	{
		Il2CppClassPointerStore<DevTools>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "DevTools");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DevTools>.NativeClassPtr);
		NativeFieldInfoPtr_DevMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DevTools>.NativeClassPtr, "DevMode");
		NativeMethodInfoPtr_Debug_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DevTools>.NativeClassPtr, 100665913);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DevTools>.NativeClassPtr, 100665914);
	}

	public DevTools(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
