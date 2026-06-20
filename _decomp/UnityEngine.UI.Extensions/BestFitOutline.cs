using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace UnityEngine.UI.Extensions;

public class BestFitOutline : Shadow
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_Mesh_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BestFitOutline>.NativeClassPtr));

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117922, XrefRangeEnd = 117925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BestFitOutline()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BestFitOutline>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117925, XrefRangeEnd = 117964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void ModifyMesh(Mesh mesh)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_Mesh_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static BestFitOutline()
	{
		Il2CppClassPointerStore<BestFitOutline>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "UnityEngine.UI.Extensions", "BestFitOutline");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BestFitOutline>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BestFitOutline>.NativeClassPtr, 100670773);
		NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BestFitOutline>.NativeClassPtr, 100670774);
	}

	public BestFitOutline(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
