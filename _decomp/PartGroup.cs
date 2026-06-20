using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class PartGroup : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_showPivot;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGameObjectPathWithoutRoot_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PartGroup>.NativeClassPtr));

	public unsafe bool showPivot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showPivot);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showPivot)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70002, XrefRangeEnd = 70058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetGameObjectPathWithoutRoot()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGameObjectPathWithoutRoot_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70058, XrefRangeEnd = 70114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDrawGizmos()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe PartGroup()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartGroup>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PartGroup()
	{
		Il2CppClassPointerStore<PartGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "PartGroup");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartGroup>.NativeClassPtr);
		NativeFieldInfoPtr_showPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartGroup>.NativeClassPtr, "showPivot");
		NativeMethodInfoPtr_GetGameObjectPathWithoutRoot_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartGroup>.NativeClassPtr, 100667483);
		NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartGroup>.NativeClassPtr, 100667484);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartGroup>.NativeClassPtr, 100667485);
	}

	public PartGroup(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
