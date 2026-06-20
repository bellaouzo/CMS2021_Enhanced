using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Difficulty;

[System.Serializable]
public class BaseDifficulty : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_settings;

	private static readonly System.IntPtr NativeFieldInfoPtr_needsGarageRefresh;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Settings_Public_get_DifficultySettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Settings_Public_set_Void_DifficultySettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Public_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Activate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BaseDifficulty>.NativeClassPtr));

	public unsafe DifficultySettings settings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_settings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new DifficultySettings(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool needsGarageRefresh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needsGarageRefresh);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needsGarageRefresh)) = flag;
		}
	}

	public unsafe DifficultySettings Settings
	{
		[CallerCount(1)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Settings_Public_get_DifficultySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new DifficultySettings(intPtr) : null;
		}
		[CallerCount(77)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Settings_Public_set_Void_DifficultySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void Prepare()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Prepare_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218614, XrefRangeEnd = 218616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Activate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Activate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 218619, RefRangeEnd = 218626, XrefRangeStart = 218616, XrefRangeEnd = 218619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BaseDifficulty()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseDifficulty>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static BaseDifficulty()
	{
		Il2CppClassPointerStore<BaseDifficulty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Difficulty", "BaseDifficulty");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseDifficulty>.NativeClassPtr);
		NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseDifficulty>.NativeClassPtr, "settings");
		NativeFieldInfoPtr_needsGarageRefresh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseDifficulty>.NativeClassPtr, "needsGarageRefresh");
		NativeMethodInfoPtr_get_Settings_Public_get_DifficultySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDifficulty>.NativeClassPtr, 100679858);
		NativeMethodInfoPtr_set_Settings_Public_set_Void_DifficultySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDifficulty>.NativeClassPtr, 100679859);
		NativeMethodInfoPtr_Prepare_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDifficulty>.NativeClassPtr, 100679860);
		NativeMethodInfoPtr_Activate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDifficulty>.NativeClassPtr, 100679861);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDifficulty>.NativeClassPtr, 100679862);
	}

	public BaseDifficulty(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
