using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class ScreenBug : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_hideAtEditor;

	private static readonly System.IntPtr NativeFieldInfoPtr_sideBySide;

	private static readonly System.IntPtr NativeFieldInfoPtr_showText;

	private static readonly System.IntPtr NativeFieldInfoPtr_text;

	private static readonly System.IntPtr NativeFieldInfoPtr_style;

	private static readonly System.IntPtr NativeFieldInfoPtr_showBug;

	private static readonly System.IntPtr NativeFieldInfoPtr_bug;

	private static readonly System.IntPtr NativeFieldInfoPtr_bugSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_borderX;

	private static readonly System.IntPtr NativeFieldInfoPtr_borderY;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ScreenBug>.NativeClassPtr));

	public unsafe bool hideAtEditor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hideAtEditor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hideAtEditor)) = flag;
		}
	}

	public unsafe bool sideBySide
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sideBySide);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sideBySide)) = flag;
		}
	}

	public unsafe bool showText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showText);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showText)) = flag;
		}
	}

	public unsafe Il2CppStringArray text
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_text);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStringArray(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GUIStyle style
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_style);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new GUIStyle(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_style), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool showBug
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showBug);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showBug)) = flag;
		}
	}

	public unsafe Texture2D bug
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bug);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Texture2D(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bug), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float bugSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bugSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bugSize)) = num;
		}
	}

	public unsafe float borderX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_borderX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_borderX)) = num;
		}
	}

	public unsafe float borderY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_borderY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_borderY)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117493, XrefRangeEnd = 117570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117570, XrefRangeEnd = 117577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScreenBug()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenBug>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ScreenBug()
	{
		Il2CppClassPointerStore<ScreenBug>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "ScreenBug");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenBug>.NativeClassPtr);
		NativeFieldInfoPtr_hideAtEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenBug>.NativeClassPtr, "hideAtEditor");
		NativeFieldInfoPtr_sideBySide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenBug>.NativeClassPtr, "sideBySide");
		NativeFieldInfoPtr_showText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenBug>.NativeClassPtr, "showText");
		NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenBug>.NativeClassPtr, "text");
		NativeFieldInfoPtr_style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenBug>.NativeClassPtr, "style");
		NativeFieldInfoPtr_showBug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenBug>.NativeClassPtr, "showBug");
		NativeFieldInfoPtr_bug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenBug>.NativeClassPtr, "bug");
		NativeFieldInfoPtr_bugSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenBug>.NativeClassPtr, "bugSize");
		NativeFieldInfoPtr_borderX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenBug>.NativeClassPtr, "borderX");
		NativeFieldInfoPtr_borderY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenBug>.NativeClassPtr, "borderY");
		NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenBug>.NativeClassPtr, 100670740);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenBug>.NativeClassPtr, 100670741);
	}

	public ScreenBug(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
