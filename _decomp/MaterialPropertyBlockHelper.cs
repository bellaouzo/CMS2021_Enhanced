using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class MaterialPropertyBlockHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__propBlock;

	private static readonly System.IntPtr NativeFieldInfoPtr__renderer;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Renderer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBuffer_Public_Void_String_ComputeBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetColor_Public_Void_String_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFloatArray_Public_Void_String_ArrayOf_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMatrix_Public_Void_String_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMatrixArray_Public_Void_String_ArrayOf_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTexture_Public_Void_String_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVector_Public_Void_String_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVectorArray_Public_Void_Renderer_String_ArrayOf_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPropertyBlock_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MaterialPropertyBlockHelper>.NativeClassPtr));

	public unsafe MaterialPropertyBlock _propBlock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__propBlock);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new MaterialPropertyBlock(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__propBlock), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Renderer _renderer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__renderer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Renderer(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__renderer), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56764, XrefRangeEnd = 56769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MaterialPropertyBlockHelper(Renderer renderer)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialPropertyBlockHelper>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Renderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56769, XrefRangeEnd = 56778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBuffer(string propertyName, ComputeBuffer newValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBuffer_Public_Void_String_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56778, XrefRangeEnd = 56779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetColor(string propertyName, Color newValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColor_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56779, XrefRangeEnd = 56781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFloat(string propertyName, float newValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56781, XrefRangeEnd = 56783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFloatArray(string propertyName, Il2CppStructArray<float> newValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFloatArray_Public_Void_String_ArrayOf_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56783, XrefRangeEnd = 56787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMatrix(string propertyName, Matrix4x4 newValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMatrix_Public_Void_String_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56787, XrefRangeEnd = 56790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMatrixArray(string propertyName, Il2CppStructArray<Matrix4x4> newValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMatrixArray_Public_Void_String_ArrayOf_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56790, XrefRangeEnd = 56792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTexture(string propertyName, Texture newValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTexture_Public_Void_String_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56792, XrefRangeEnd = 56793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetVector(string propertyName, Vector4 newValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
		*(Vector4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVector_Public_Void_String_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56793, XrefRangeEnd = 56808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetVectorArray(Renderer renderer, string propertyName, Il2CppStructArray<Vector4> newValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(propertyName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVectorArray_Public_Void_Renderer_String_ArrayOf_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56808, XrefRangeEnd = 56813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPropertyBlock()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPropertyBlock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56813, XrefRangeEnd = 56818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MaterialPropertyBlockHelper()
	{
		Il2CppClassPointerStore<MaterialPropertyBlockHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "MaterialPropertyBlockHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialPropertyBlockHelper>.NativeClassPtr);
		NativeFieldInfoPtr__propBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertyBlockHelper>.NativeClassPtr, "_propBlock");
		NativeFieldInfoPtr__renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertyBlockHelper>.NativeClassPtr, "_renderer");
		NativeMethodInfoPtr__ctor_Public_Void_Renderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlockHelper>.NativeClassPtr, 100666614);
		NativeMethodInfoPtr_SetBuffer_Public_Void_String_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlockHelper>.NativeClassPtr, 100666615);
		NativeMethodInfoPtr_SetColor_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlockHelper>.NativeClassPtr, 100666616);
		NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlockHelper>.NativeClassPtr, 100666617);
		NativeMethodInfoPtr_SetFloatArray_Public_Void_String_ArrayOf_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlockHelper>.NativeClassPtr, 100666618);
		NativeMethodInfoPtr_SetMatrix_Public_Void_String_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlockHelper>.NativeClassPtr, 100666619);
		NativeMethodInfoPtr_SetMatrixArray_Public_Void_String_ArrayOf_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlockHelper>.NativeClassPtr, 100666620);
		NativeMethodInfoPtr_SetTexture_Public_Void_String_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlockHelper>.NativeClassPtr, 100666621);
		NativeMethodInfoPtr_SetVector_Public_Void_String_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlockHelper>.NativeClassPtr, 100666622);
		NativeMethodInfoPtr_SetVectorArray_Public_Void_Renderer_String_ArrayOf_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlockHelper>.NativeClassPtr, 100666623);
		NativeMethodInfoPtr_SetPropertyBlock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlockHelper>.NativeClassPtr, 100666624);
		NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlockHelper>.NativeClassPtr, 100666625);
	}

	public MaterialPropertyBlockHelper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
