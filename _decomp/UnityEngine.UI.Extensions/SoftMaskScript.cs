using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace UnityEngine.UI.Extensions;

public class SoftMaskScript : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_mat;

	private static readonly System.IntPtr NativeFieldInfoPtr_canvas;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaskArea;

	private static readonly System.IntPtr NativeFieldInfoPtr_myRect;

	private static readonly System.IntPtr NativeFieldInfoPtr_maskScalingRect;

	private static readonly System.IntPtr NativeFieldInfoPtr_AlphaMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_CutOff;

	private static readonly System.IntPtr NativeFieldInfoPtr_HardBlend;

	private static readonly System.IntPtr NativeFieldInfoPtr_FlipAlphaMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_DontClipMaskScalingRect;

	private static readonly System.IntPtr NativeFieldInfoPtr_CascadeToALLChildren;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldCorners;

	private static readonly System.IntPtr NativeFieldInfoPtr_AlphaUV;

	private static readonly System.IntPtr NativeFieldInfoPtr_min;

	private static readonly System.IntPtr NativeFieldInfoPtr_max;

	private static readonly System.IntPtr NativeFieldInfoPtr_p;

	private static readonly System.IntPtr NativeFieldInfoPtr_siz;

	private static readonly System.IntPtr NativeFieldInfoPtr_tp;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaterialNotSupported;

	private static readonly System.IntPtr NativeFieldInfoPtr_maskRect;

	private static readonly System.IntPtr NativeFieldInfoPtr_contentRect;

	private static readonly System.IntPtr NativeFieldInfoPtr_centre;

	private static readonly System.IntPtr NativeFieldInfoPtr_isText;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSAM_Private_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCanvas_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMask_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr));

	public unsafe Material mat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mat);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Material(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mat), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Canvas canvas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canvas);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Canvas(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RectTransform MaskArea
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaskArea);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RectTransform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaskArea), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RectTransform myRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_myRect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RectTransform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_myRect), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RectTransform maskScalingRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maskScalingRect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new RectTransform(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maskScalingRect), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Texture AlphaMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AlphaMask);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Texture(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AlphaMask), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float CutOff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CutOff);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CutOff)) = num;
		}
	}

	public unsafe bool HardBlend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HardBlend);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HardBlend)) = flag;
		}
	}

	public unsafe bool FlipAlphaMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FlipAlphaMask);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FlipAlphaMask)) = flag;
		}
	}

	public unsafe bool DontClipMaskScalingRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DontClipMaskScalingRect);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DontClipMaskScalingRect)) = flag;
		}
	}

	public unsafe bool CascadeToALLChildren
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CascadeToALLChildren);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CascadeToALLChildren)) = flag;
		}
	}

	public unsafe Il2CppStructArray<Vector3> worldCorners
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldCorners);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<Vector3>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldCorners), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector2 AlphaUV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AlphaUV);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AlphaUV)) = vector;
		}
	}

	public unsafe Vector2 min
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_min);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_min)) = vector;
		}
	}

	public unsafe Vector2 max
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_max);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_max)) = vector;
		}
	}

	public unsafe Vector2 p
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p)) = vector;
		}
	}

	public unsafe Vector2 siz
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_siz);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_siz)) = vector;
		}
	}

	public unsafe Vector2 tp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tp);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tp)) = vector;
		}
	}

	public unsafe bool MaterialNotSupported
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaterialNotSupported);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaterialNotSupported)) = flag;
		}
	}

	public unsafe Rect maskRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maskRect);
			return *(Rect*)num;
		}
		set
		{
			*(Rect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maskRect)) = rect;
		}
	}

	public unsafe Rect contentRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contentRect);
			return *(Rect*)num;
		}
		set
		{
			*(Rect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contentRect)) = rect;
		}
	}

	public unsafe Vector2 centre
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_centre);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_centre)) = vector;
		}
	}

	public unsafe bool isText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isText);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isText)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118405, XrefRangeEnd = 118541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118563, RefRangeEnd = 118564, XrefRangeStart = 118541, XrefRangeEnd = 118563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSAM(Transform t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSAM_Private_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118599, RefRangeEnd = 118600, XrefRangeStart = 118564, XrefRangeEnd = 118599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetCanvas()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCanvas_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118600, XrefRangeEnd = 118601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118714, RefRangeEnd = 118715, XrefRangeStart = 118601, XrefRangeEnd = 118714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMask()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMask_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118715, XrefRangeEnd = 118720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SoftMaskScript()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SoftMaskScript()
	{
		Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "UnityEngine.UI.Extensions", "SoftMaskScript");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr);
		NativeFieldInfoPtr_mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "mat");
		NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "canvas");
		NativeFieldInfoPtr_MaskArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "MaskArea");
		NativeFieldInfoPtr_myRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "myRect");
		NativeFieldInfoPtr_maskScalingRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "maskScalingRect");
		NativeFieldInfoPtr_AlphaMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "AlphaMask");
		NativeFieldInfoPtr_CutOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "CutOff");
		NativeFieldInfoPtr_HardBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "HardBlend");
		NativeFieldInfoPtr_FlipAlphaMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "FlipAlphaMask");
		NativeFieldInfoPtr_DontClipMaskScalingRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "DontClipMaskScalingRect");
		NativeFieldInfoPtr_CascadeToALLChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "CascadeToALLChildren");
		NativeFieldInfoPtr_worldCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "worldCorners");
		NativeFieldInfoPtr_AlphaUV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "AlphaUV");
		NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "min");
		NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "max");
		NativeFieldInfoPtr_p = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "p");
		NativeFieldInfoPtr_siz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "siz");
		NativeFieldInfoPtr_tp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "tp");
		NativeFieldInfoPtr_MaterialNotSupported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "MaterialNotSupported");
		NativeFieldInfoPtr_maskRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "maskRect");
		NativeFieldInfoPtr_contentRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "contentRect");
		NativeFieldInfoPtr_centre = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "centre");
		NativeFieldInfoPtr_isText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, "isText");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, 100670815);
		NativeMethodInfoPtr_SetSAM_Private_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, 100670816);
		NativeMethodInfoPtr_GetCanvas_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, 100670817);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, 100670818);
		NativeMethodInfoPtr_SetMask_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, 100670819);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoftMaskScript>.NativeClassPtr, 100670820);
	}

	public SoftMaskScript(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
