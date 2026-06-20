using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

public class ImageChanger : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Image;

	private static readonly System.IntPtr NativeFieldInfoPtr_TimeToChange;

	private static readonly System.IntPtr NativeFieldInfoPtr_ImageIndex;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetImage_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ImageChanger>.NativeClassPtr));

	public unsafe Image Image
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Image);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Image(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Image), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float TimeToChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TimeToChange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TimeToChange)) = num;
		}
	}

	public unsafe static int ImageIndex
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ImageIndex, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ImageIndex, &num);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105668, XrefRangeEnd = 105694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void SetImage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetImage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105694, XrefRangeEnd = 105698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105698, XrefRangeEnd = 105701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ImageChanger()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageChanger>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ImageChanger()
	{
		Il2CppClassPointerStore<ImageChanger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "ImageChanger");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageChanger>.NativeClassPtr);
		NativeFieldInfoPtr_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageChanger>.NativeClassPtr, "Image");
		NativeFieldInfoPtr_TimeToChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageChanger>.NativeClassPtr, "TimeToChange");
		NativeFieldInfoPtr_ImageIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageChanger>.NativeClassPtr, "ImageIndex");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageChanger>.NativeClassPtr, 100669639);
		NativeMethodInfoPtr_SetImage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageChanger>.NativeClassPtr, 100669640);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageChanger>.NativeClassPtr, 100669641);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageChanger>.NativeClassPtr, 100669642);
	}

	public ImageChanger(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
