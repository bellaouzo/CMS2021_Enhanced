using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class DifficultyTest : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_changeDifficulty;

	private static readonly System.IntPtr NativeFieldInfoPtr_newDifficulty;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DifficultyTest>.NativeClassPtr));

	public unsafe bool changeDifficulty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeDifficulty);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeDifficulty)) = flag;
		}
	}

	public unsafe DifficultyLevel newDifficulty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newDifficulty);
			return *(DifficultyLevel*)num;
		}
		set
		{
			*(DifficultyLevel*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newDifficulty)) = difficultyLevel;
		}
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe DifficultyTest()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DifficultyTest>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DifficultyTest()
	{
		Il2CppClassPointerStore<DifficultyTest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "DifficultyTest");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DifficultyTest>.NativeClassPtr);
		NativeFieldInfoPtr_changeDifficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifficultyTest>.NativeClassPtr, "changeDifficulty");
		NativeFieldInfoPtr_newDifficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifficultyTest>.NativeClassPtr, "newDifficulty");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultyTest>.NativeClassPtr, 100665920);
	}

	public DifficultyTest(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
