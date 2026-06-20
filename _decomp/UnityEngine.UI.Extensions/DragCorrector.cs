using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace UnityEngine.UI.Extensions;

public class DragCorrector : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_baseTH;

	private static readonly System.IntPtr NativeFieldInfoPtr_basePPI;

	private static readonly System.IntPtr NativeFieldInfoPtr_dragTH;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DragCorrector>.NativeClassPtr));

	public unsafe int baseTH
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseTH);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseTH)) = num;
		}
	}

	public unsafe int basePPI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basePPI);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basePPI)) = num;
		}
	}

	public unsafe int dragTH
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dragTH);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dragTH)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120449, XrefRangeEnd = 120458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120458, XrefRangeEnd = 120461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DragCorrector()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragCorrector>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DragCorrector()
	{
		Il2CppClassPointerStore<DragCorrector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "UnityEngine.UI.Extensions", "DragCorrector");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragCorrector>.NativeClassPtr);
		NativeFieldInfoPtr_baseTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragCorrector>.NativeClassPtr, "baseTH");
		NativeFieldInfoPtr_basePPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragCorrector>.NativeClassPtr, "basePPI");
		NativeFieldInfoPtr_dragTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragCorrector>.NativeClassPtr, "dragTH");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCorrector>.NativeClassPtr, 100670966);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragCorrector>.NativeClassPtr, 100670967);
	}

	public DragCorrector(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
