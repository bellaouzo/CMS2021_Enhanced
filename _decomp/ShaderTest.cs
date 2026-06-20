using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class ShaderTest : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_xrayOn;

	private static readonly System.IntPtr NativeFieldInfoPtr_applyOn;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadersBackup;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ShaderTest>.NativeClassPtr));

	public unsafe bool xrayOn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xrayOn);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xrayOn)) = flag;
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> applyOn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyOn);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyOn), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ShadersBackup shadersBackup
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadersBackup);
			return new ShadersBackup(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShadersBackup>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadersBackup), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShadersBackup>.NativeClassPtr, ref *(uint*)null));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85613, XrefRangeEnd = 85619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe ShaderTest()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderTest>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ShaderTest()
	{
		Il2CppClassPointerStore<ShaderTest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "ShaderTest");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderTest>.NativeClassPtr);
		NativeFieldInfoPtr_xrayOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderTest>.NativeClassPtr, "xrayOn");
		NativeFieldInfoPtr_applyOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderTest>.NativeClassPtr, "applyOn");
		NativeFieldInfoPtr_shadersBackup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderTest>.NativeClassPtr, "shadersBackup");
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderTest>.NativeClassPtr, 100668161);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderTest>.NativeClassPtr, 100668162);
	}

	public ShaderTest(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
