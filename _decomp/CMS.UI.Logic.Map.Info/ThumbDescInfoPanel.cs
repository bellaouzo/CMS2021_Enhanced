using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace CMS.UI.Logic.Map.Info;

public class ThumbDescInfoPanel : MapInfoPanel
{
	private static readonly System.IntPtr NativeFieldInfoPtr_thumbnail;

	private static readonly System.IntPtr NativeFieldInfoPtr_description;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetThumbnail_Public_Void_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDescription_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ThumbDescInfoPanel>.NativeClassPtr));

	public unsafe Image thumbnail
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thumbnail);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thumbnail), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Text description
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_description);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Text(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_description), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 197363, RefRangeEnd = 197369, XrefRangeStart = 197339, XrefRangeEnd = 197363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetThumbnail(Sprite thumb)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(thumb);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetThumbnail_Public_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197369, XrefRangeEnd = 197370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDescription(string desc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(desc);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDescription_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe ThumbDescInfoPanel()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThumbDescInfoPanel>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ThumbDescInfoPanel()
	{
		Il2CppClassPointerStore<ThumbDescInfoPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.UI.Logic.Map.Info", "ThumbDescInfoPanel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThumbDescInfoPanel>.NativeClassPtr);
		NativeFieldInfoPtr_thumbnail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThumbDescInfoPanel>.NativeClassPtr, "thumbnail");
		NativeFieldInfoPtr_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThumbDescInfoPanel>.NativeClassPtr, "description");
		NativeMethodInfoPtr_SetThumbnail_Public_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThumbDescInfoPanel>.NativeClassPtr, 100678076);
		NativeMethodInfoPtr_SetDescription_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThumbDescInfoPanel>.NativeClassPtr, 100678077);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThumbDescInfoPanel>.NativeClassPtr, 100678078);
	}

	public ThumbDescInfoPanel(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
