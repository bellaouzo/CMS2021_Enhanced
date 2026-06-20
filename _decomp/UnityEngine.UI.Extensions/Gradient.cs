using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace UnityEngine.UI.Extensions;

public class Gradient : BaseMeshEffect
{
	private static readonly System.IntPtr NativeFieldInfoPtr_gradientMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_gradientDir;

	private static readonly System.IntPtr NativeFieldInfoPtr_overwriteAllColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_vertex1;

	private static readonly System.IntPtr NativeFieldInfoPtr_vertex2;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetGraphic;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareCarefully_Private_Boolean_Color_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Gradient>.NativeClassPtr));

	public unsafe GradientMode gradientMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gradientMode);
			return *(GradientMode*)num;
		}
		set
		{
			*(GradientMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gradientMode)) = gradientMode;
		}
	}

	public unsafe GradientDir gradientDir
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gradientDir);
			return *(GradientDir*)num;
		}
		set
		{
			*(GradientDir*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gradientDir)) = gradientDir;
		}
	}

	public unsafe bool overwriteAllColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overwriteAllColor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overwriteAllColor)) = flag;
		}
	}

	public unsafe Color vertex1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertex1);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertex1)) = color;
		}
	}

	public unsafe Color vertex2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertex2);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertex2)) = color;
		}
	}

	public unsafe Graphic targetGraphic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetGraphic);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Graphic(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetGraphic), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117964, XrefRangeEnd = 117967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117967, XrefRangeEnd = 117989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void ModifyMesh(VertexHelper vh)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(vh);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool CompareCarefully(Color col1, Color col2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&col1);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &col2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareCarefully_Private_Boolean_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117989, XrefRangeEnd = 117992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Gradient()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Gradient>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Gradient()
	{
		Il2CppClassPointerStore<Gradient>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "UnityEngine.UI.Extensions", "Gradient");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Gradient>.NativeClassPtr);
		NativeFieldInfoPtr_gradientMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gradient>.NativeClassPtr, "gradientMode");
		NativeFieldInfoPtr_gradientDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gradient>.NativeClassPtr, "gradientDir");
		NativeFieldInfoPtr_overwriteAllColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gradient>.NativeClassPtr, "overwriteAllColor");
		NativeFieldInfoPtr_vertex1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gradient>.NativeClassPtr, "vertex1");
		NativeFieldInfoPtr_vertex2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gradient>.NativeClassPtr, "vertex2");
		NativeFieldInfoPtr_targetGraphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gradient>.NativeClassPtr, "targetGraphic");
		NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100670775);
		NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100670776);
		NativeMethodInfoPtr_CompareCarefully_Private_Boolean_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100670777);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100670778);
	}

	public Gradient(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
