using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.PartModules;

public class EcuModule : PartModule
{
	private static readonly System.IntPtr NativeFieldInfoPtr_stage;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Stage_Public_get_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetStage_Public_Void_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<EcuModule>.NativeClassPtr));

	public unsafe byte stage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stage)) = b;
		}
	}

	public unsafe byte Stage
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Stage_Public_get_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(byte*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(0)]
	public unsafe void SetStage(byte newStage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newStage);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStage_Public_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe EcuModule()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EcuModule>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static EcuModule()
	{
		Il2CppClassPointerStore<EcuModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.PartModules", "EcuModule");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EcuModule>.NativeClassPtr);
		NativeFieldInfoPtr_stage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EcuModule>.NativeClassPtr, "stage");
		NativeMethodInfoPtr_get_Stage_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcuModule>.NativeClassPtr, 100672705);
		NativeMethodInfoPtr_SetStage_Public_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcuModule>.NativeClassPtr, 100672706);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EcuModule>.NativeClassPtr, 100672707);
	}

	public EcuModule(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
