using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Runtime.Serialization;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace UnityEngine.UI.Extensions;

public static class SaveLoad : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_saveGamePath;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_SaveGame_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_SaveGame_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSurrogates_Private_Static_Void_byref_SurrogateSelector_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckPath_Private_Static_Void_String_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SaveLoad>.NativeClassPtr));

	public unsafe static string saveGamePath
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_saveGamePath, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_saveGamePath, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 120889, RefRangeEnd = 120890, XrefRangeStart = 120861, XrefRangeEnd = 120889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Save(SaveGame saveGame)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveGame);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Static_Void_SaveGame_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 120909, RefRangeEnd = 120910, XrefRangeStart = 120890, XrefRangeEnd = 120909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SaveGame Load(string gameToLoad)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(gameToLoad);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Static_SaveGame_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new SaveGame(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 120943, RefRangeEnd = 120944, XrefRangeStart = 120910, XrefRangeEnd = 120943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddSurrogates(ref SurrogateSelector ss)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(ss);
		*ptr = (nint)(&intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSurrogates_Private_Static_Void_byref_SurrogateSelector_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		ss = ((intPtr3 == (System.IntPtr)0) ? null : new SurrogateSelector(intPtr3));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 120962, RefRangeEnd = 120963, XrefRangeStart = 120944, XrefRangeEnd = 120962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckPath(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckPath_Private_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SaveLoad()
	{
		Il2CppClassPointerStore<SaveLoad>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "UnityEngine.UI.Extensions", "SaveLoad");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveLoad>.NativeClassPtr);
		NativeFieldInfoPtr_saveGamePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveLoad>.NativeClassPtr, "saveGamePath");
		NativeMethodInfoPtr_Save_Public_Static_Void_SaveGame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLoad>.NativeClassPtr, 100671038);
		NativeMethodInfoPtr_Load_Public_Static_SaveGame_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLoad>.NativeClassPtr, 100671039);
		NativeMethodInfoPtr_AddSurrogates_Private_Static_Void_byref_SurrogateSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLoad>.NativeClassPtr, 100671040);
		NativeMethodInfoPtr_CheckPath_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLoad>.NativeClassPtr, 100671041);
	}

	public SaveLoad(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
