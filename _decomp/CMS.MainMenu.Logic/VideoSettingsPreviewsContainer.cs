using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace CMS.MainMenu.Logic;

public class VideoSettingsPreviewsContainer : MonoBehaviour
{
	[System.Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class Previews : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Preview;

		private static readonly System.IntPtr NativeFieldInfoPtr_SettingType;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Previews>.NativeClassPtr));

		public unsafe Sprite Preview
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Preview);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Sprite(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Preview), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe SettingType SettingType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SettingType);
				return *(SettingType*)num;
			}
			set
			{
				*(SettingType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SettingType)) = settingType;
			}
		}

		static Previews()
		{
			Il2CppClassPointerStore<Previews>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoSettingsPreviewsContainer>.NativeClassPtr, "Previews");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Previews>.NativeClassPtr);
			NativeFieldInfoPtr_Preview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Previews>.NativeClassPtr, "Preview");
			NativeFieldInfoPtr_SettingType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Previews>.NativeClassPtr, "SettingType");
		}

		public Previews(System.IntPtr P_0)
			: base(P_0)
		{
		}

		public unsafe Previews()
			: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Previews>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<Previews>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_previews;

	private static readonly System.IntPtr NativeFieldInfoPtr_background;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPreviewForSetting_Public_Void_SettingType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VideoSettingsPreviewsContainer>.NativeClassPtr));

	public unsafe Il2CppReferenceArray<Previews> previews
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previews);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppReferenceArray<Previews>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previews), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image background
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_background);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_background), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150107, XrefRangeEnd = 150123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPreviewForSetting(SettingType settingType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&settingType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPreviewForSetting_Public_Void_SettingType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe VideoSettingsPreviewsContainer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoSettingsPreviewsContainer>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static VideoSettingsPreviewsContainer()
	{
		Il2CppClassPointerStore<VideoSettingsPreviewsContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.MainMenu.Logic", "VideoSettingsPreviewsContainer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VideoSettingsPreviewsContainer>.NativeClassPtr);
		NativeFieldInfoPtr_previews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoSettingsPreviewsContainer>.NativeClassPtr, "previews");
		NativeFieldInfoPtr_background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoSettingsPreviewsContainer>.NativeClassPtr, "background");
		NativeMethodInfoPtr_SetPreviewForSetting_Public_Void_SettingType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoSettingsPreviewsContainer>.NativeClassPtr, 100673657);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoSettingsPreviewsContainer>.NativeClassPtr, 100673658);
	}

	public VideoSettingsPreviewsContainer(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
