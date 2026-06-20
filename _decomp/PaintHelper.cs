using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public static class PaintHelper : Il2CppSystem.Object
{
	[ObfuscatedName("PaintHelper/<>c__DisplayClass5_0")]
	public sealed class __c__DisplayClass5_0 : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_material;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr));

		public unsafe Material material
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_material);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Material(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		static __c__DisplayClass5_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PaintHelper>.NativeClassPtr, "<>c__DisplayClass5_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr);
			NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr, "material");
		}

		public __c__DisplayClass5_0(System.IntPtr P_0)
			: base(P_0)
		{
		}

		public unsafe __c__DisplayClass5_0()
			: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr))
		{
		}
	}

	[ObfuscatedName("PaintHelper/<>c__DisplayClass10_0")]
	public sealed class __c__DisplayClass10_0 : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_material;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr));

		public unsafe Material material
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_material);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Material(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		static __c__DisplayClass10_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PaintHelper>.NativeClassPtr, "<>c__DisplayClass10_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr);
			NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr, "material");
		}

		public __c__DisplayClass10_0(System.IntPtr P_0)
			: base(P_0)
		{
		}

		public unsafe __c__DisplayClass10_0()
			: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDent_Public_Static_Void_ArrayOf_Renderer_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDent_Public_Static_Void_Renderer_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColorAndPaintType_Public_Static_AllowedColor_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetColor_Public_Static_Void_ArrayOf_Renderer_Color_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetColor_Public_Static_Void_Renderer_Color_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetColorAndPaintType_Public_Static_Void_Renderer_Color_PaintType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCarLivery_Public_Static_Void_Renderer_String_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCarAdditionalTexture_Public_Static_Void_Renderer_String_Texture_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPaintType_Public_Static_Void_GameObject_PaintType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPaintType_Public_Static_Void_ArrayOf_Renderer_PaintType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPaintType_Public_Static_Void_Renderer_PaintType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCustomPaintType_Public_Static_Void_GameObject_PaintData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCustomPaintType_Public_Static_Void_ArrayOf_Renderer_PaintData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCustomPaintType_Public_Static_Void_Renderer_PaintData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWindowProperties_Public_Static_Void_GameObject_Int32_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWindowProperties_Public_Static_Void_GameObject_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_PaintData_byref___c__DisplayClass5_0_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_PaintData_byref___c__DisplayClass10_0_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PaintHelper>.NativeClassPtr));

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56818, XrefRangeEnd = 56820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetDent(Il2CppReferenceArray<Renderer> renderers, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderers);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDent_Public_Static_Void_ArrayOf_Renderer_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 56841, RefRangeEnd = 56848, XrefRangeStart = 56820, XrefRangeEnd = 56841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetDent(Renderer renderer, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDent_Public_Static_Void_Renderer_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 56881, RefRangeEnd = 56883, XrefRangeStart = 56848, XrefRangeEnd = 56881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AllowedColor GetColorAndPaintType(string hex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(hex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColorAndPaintType_Public_Static_AllowedColor_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(AllowedColor*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56883, XrefRangeEnd = 56885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetColor(Il2CppReferenceArray<Renderer> renderers, Color c, bool isBodyPart)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderers);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isBodyPart;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColor_Public_Static_Void_ArrayOf_Renderer_Color_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 56924, RefRangeEnd = 56939, XrefRangeStart = 56885, XrefRangeEnd = 56924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetColor(Renderer renderer, Color c, bool isBodyPart)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isBodyPart;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColor_Public_Static_Void_Renderer_Color_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 57018, RefRangeEnd = 57019, XrefRangeStart = 56939, XrefRangeEnd = 57018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetColorAndPaintType(Renderer renderer, Color color, PaintType paintType, bool isBodyPart)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		*(PaintType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &paintType;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isBodyPart;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColorAndPaintType_Public_Static_Void_Renderer_Color_PaintType_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 57080, RefRangeEnd = 57081, XrefRangeStart = 57019, XrefRangeEnd = 57080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetCarLivery(Renderer renderer, string carToLoad, string liveryName, float liveryStrength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(carToLoad);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(liveryName);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &liveryStrength;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCarLivery_Public_Static_Void_Renderer_String_String_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 57115, RefRangeEnd = 57116, XrefRangeStart = 57081, XrefRangeEnd = 57115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetCarAdditionalTexture(Renderer renderer, string carToLoad, Texture texture, [Optional] float textureStrength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(carToLoad);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(texture);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureStrength;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCarAdditionalTexture_Public_Static_Void_Renderer_String_Texture_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 57120, RefRangeEnd = 57128, XrefRangeStart = 57116, XrefRangeEnd = 57120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPaintType(GameObject go, PaintType paintType, bool isBodyPart)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		*(PaintType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &paintType;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isBodyPart;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPaintType_Public_Static_Void_GameObject_PaintType_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57128, XrefRangeEnd = 57130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPaintType(Il2CppReferenceArray<Renderer> renderers, PaintType paintType, bool isBodyPart)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderers);
		*(PaintType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &paintType;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isBodyPart;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPaintType_Public_Static_Void_ArrayOf_Renderer_PaintType_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 57201, RefRangeEnd = 57209, XrefRangeStart = 57130, XrefRangeEnd = 57201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPaintType(Renderer renderer, PaintType paintType, bool isBodyPart)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
		*(PaintType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &paintType;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isBodyPart;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPaintType_Public_Static_Void_Renderer_PaintType_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 57213, RefRangeEnd = 57221, XrefRangeStart = 57209, XrefRangeEnd = 57213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetCustomPaintType(GameObject go, PaintData paintData, bool isBodyPart)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		*(PaintData**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &paintData;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isBodyPart;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCustomPaintType_Public_Static_Void_GameObject_PaintData_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57221, XrefRangeEnd = 57223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetCustomPaintType(Il2CppReferenceArray<Renderer> renderers, PaintData paintData, bool isBodyPart)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderers);
		*(PaintData**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &paintData;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isBodyPart;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCustomPaintType_Public_Static_Void_ArrayOf_Renderer_PaintData_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 57268, RefRangeEnd = 57277, XrefRangeStart = 57223, XrefRangeEnd = 57268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetCustomPaintType(Renderer renderer, PaintData paintData, bool isBodyPart)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
		*(PaintData**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &paintData;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isBodyPart;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCustomPaintType_Public_Static_Void_Renderer_PaintData_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 57300, RefRangeEnd = 57302, XrefRangeStart = 57277, XrefRangeEnd = 57300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetWindowProperties(GameObject windowHandle, int opacity, Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(windowHandle);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &opacity;
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWindowProperties_Public_Static_Void_GameObject_Int32_Color_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57302, XrefRangeEnd = 57326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetWindowProperties(GameObject windowHandle, Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(windowHandle);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWindowProperties_Public_Static_Void_GameObject_Color_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 57355, RefRangeEnd = 57356, XrefRangeStart = 57326, XrefRangeEnd = 57355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Method_Internal_Static_Void_PaintData_byref___c__DisplayClass5_0_0(PaintData paintData, ref __c__DisplayClass5_0 P_1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&paintData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull(P_1);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Void_PaintData_byref___c__DisplayClass5_0_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 57385, RefRangeEnd = 57386, XrefRangeStart = 57356, XrefRangeEnd = 57385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Method_Internal_Static_Void_PaintData_byref___c__DisplayClass10_0_0(PaintData paintData, ref __c__DisplayClass10_0 P_1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&paintData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull(P_1);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Void_PaintData_byref___c__DisplayClass10_0_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PaintHelper()
	{
		Il2CppClassPointerStore<PaintHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "PaintHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PaintHelper>.NativeClassPtr);
		NativeMethodInfoPtr_SetDent_Public_Static_Void_ArrayOf_Renderer_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintHelper>.NativeClassPtr, 100666626);
		NativeMethodInfoPtr_SetDent_Public_Static_Void_Renderer_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintHelper>.NativeClassPtr, 100666627);
		NativeMethodInfoPtr_GetColorAndPaintType_Public_Static_AllowedColor_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintHelper>.NativeClassPtr, 100666628);
		NativeMethodInfoPtr_SetColor_Public_Static_Void_ArrayOf_Renderer_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintHelper>.NativeClassPtr, 100666629);
		NativeMethodInfoPtr_SetColor_Public_Static_Void_Renderer_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintHelper>.NativeClassPtr, 100666630);
		NativeMethodInfoPtr_SetColorAndPaintType_Public_Static_Void_Renderer_Color_PaintType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintHelper>.NativeClassPtr, 100666631);
		NativeMethodInfoPtr_SetCarLivery_Public_Static_Void_Renderer_String_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintHelper>.NativeClassPtr, 100666632);
		NativeMethodInfoPtr_SetCarAdditionalTexture_Public_Static_Void_Renderer_String_Texture_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintHelper>.NativeClassPtr, 100666633);
		NativeMethodInfoPtr_SetPaintType_Public_Static_Void_GameObject_PaintType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintHelper>.NativeClassPtr, 100666634);
		NativeMethodInfoPtr_SetPaintType_Public_Static_Void_ArrayOf_Renderer_PaintType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintHelper>.NativeClassPtr, 100666635);
		NativeMethodInfoPtr_SetPaintType_Public_Static_Void_Renderer_PaintType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintHelper>.NativeClassPtr, 100666636);
		NativeMethodInfoPtr_SetCustomPaintType_Public_Static_Void_GameObject_PaintData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintHelper>.NativeClassPtr, 100666637);
		NativeMethodInfoPtr_SetCustomPaintType_Public_Static_Void_ArrayOf_Renderer_PaintData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintHelper>.NativeClassPtr, 100666638);
		NativeMethodInfoPtr_SetCustomPaintType_Public_Static_Void_Renderer_PaintData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintHelper>.NativeClassPtr, 100666639);
		NativeMethodInfoPtr_SetWindowProperties_Public_Static_Void_GameObject_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintHelper>.NativeClassPtr, 100666640);
		NativeMethodInfoPtr_SetWindowProperties_Public_Static_Void_GameObject_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintHelper>.NativeClassPtr, 100666641);
		NativeMethodInfoPtr_Method_Internal_Static_Void_PaintData_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintHelper>.NativeClassPtr, 100666642);
		NativeMethodInfoPtr_Method_Internal_Static_Void_PaintData_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaintHelper>.NativeClassPtr, 100666643);
	}

	public PaintHelper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
