using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.UI.Logic.Tune.Helpers;

public static class TuningHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateBars_Public_Static_Void_byref_ArrayOf_TuningBar_Random_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckShuffled_Private_Static_Boolean_ArrayOf_TuningBar_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TuningHelper>.NativeClassPtr));

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 185308, RefRangeEnd = 185312, XrefRangeStart = 185296, XrefRangeEnd = 185308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GenerateBars(ref Il2CppReferenceArray<TuningBar> tuningBars, Il2CppSystem.Random random, short maxValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(tuningBars);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(random);
		*(short**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateBars_Public_Static_Void_byref_ArrayOf_TuningBar_Random_Int16_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		tuningBars = (Il2CppReferenceArray<TuningBar>)(object)((intPtr3 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<T>(intPtr3));
	}

	[CallerCount(0)]
	public unsafe static bool CheckShuffled(Il2CppReferenceArray<TuningBar> tuningBars)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(tuningBars);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckShuffled_Private_Static_Boolean_ArrayOf_TuningBar_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static TuningHelper()
	{
		Il2CppClassPointerStore<TuningHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Tune.Helpers", "TuningHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TuningHelper>.NativeClassPtr);
		NativeMethodInfoPtr_GenerateBars_Public_Static_Void_byref_ArrayOf_TuningBar_Random_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningHelper>.NativeClassPtr, 100676878);
		NativeMethodInfoPtr_CheckShuffled_Private_Static_Boolean_ArrayOf_TuningBar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TuningHelper>.NativeClassPtr, 100676879);
	}

	public TuningHelper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
