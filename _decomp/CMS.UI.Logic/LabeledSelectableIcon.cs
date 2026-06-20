using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.UI.Logic;

public class LabeledSelectableIcon : SelectableIcon
{
	private static readonly System.IntPtr NativeFieldInfoPtr_translationID;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTranslated_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LabeledSelectableIcon>.NativeClassPtr));

	public unsafe string translationID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_translationID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_translationID), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179434, XrefRangeEnd = 179437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetTranslated()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTranslated_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe LabeledSelectableIcon()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabeledSelectableIcon>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static LabeledSelectableIcon()
	{
		Il2CppClassPointerStore<LabeledSelectableIcon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic", "LabeledSelectableIcon");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabeledSelectableIcon>.NativeClassPtr);
		NativeFieldInfoPtr_translationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabeledSelectableIcon>.NativeClassPtr, "translationID");
		NativeMethodInfoPtr_GetTranslated_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabeledSelectableIcon>.NativeClassPtr, 100676322);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabeledSelectableIcon>.NativeClassPtr, 100676323);
	}

	public LabeledSelectableIcon(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
