using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Runtime.Serialization;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace UnityEngine.UI.Extensions;

public sealed class ColorSurrogate : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_Object_SerializationInfo_StreamingContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetObjectData_Public_Virtual_Final_New_Object_Object_SerializationInfo_StreamingContext_ISurrogateSelector_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ColorSurrogate>.NativeClassPtr));

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121485, XrefRangeEnd = 121501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetObjectData(Il2CppSystem.Object obj, SerializationInfo info, StreamingContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(info);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_Object_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121501, XrefRangeEnd = 121534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object SetObjectData(Il2CppSystem.Object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(info);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(selector);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetObjectData_Public_Virtual_Final_New_Object_Object_SerializationInfo_StreamingContext_ISurrogateSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe ColorSurrogate()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorSurrogate>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ColorSurrogate()
	{
		Il2CppClassPointerStore<ColorSurrogate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "UnityEngine.UI.Extensions", "ColorSurrogate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorSurrogate>.NativeClassPtr);
		NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_Object_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSurrogate>.NativeClassPtr, 100671063);
		NativeMethodInfoPtr_SetObjectData_Public_Virtual_Final_New_Object_Object_SerializationInfo_StreamingContext_ISurrogateSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSurrogate>.NativeClassPtr, 100671064);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSurrogate>.NativeClassPtr, 100671065);
	}

	public ColorSurrogate(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
