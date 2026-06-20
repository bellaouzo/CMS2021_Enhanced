using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

public class DirectionalLightCloudCookie : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_active;

	private static readonly System.IntPtr NativeFieldInfoPtr_customRenderTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_hdlight;

	private static readonly System.IntPtr NativeFieldInfoPtr_cookieSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_cookieScrollSpeed;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCloudsShadows_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DirectionalLightCloudCookie>.NativeClassPtr));

	public unsafe bool active
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_active);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_active)) = flag;
		}
	}

	public unsafe CustomRenderTexture customRenderTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customRenderTexture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CustomRenderTexture(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customRenderTexture), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe HDAdditionalLightData hdlight
	{
		get
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hdlight);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr == (System.IntPtr)0) ? ((HDAdditionalLightData)null) : new HDAdditionalLightData(intPtr);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hdlight), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe float cookieSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookieSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookieSize)) = num;
		}
	}

	public unsafe Vector3 cookieScrollSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookieScrollSpeed);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookieScrollSpeed)) = vector;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43386, XrefRangeEnd = 43392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 43417, RefRangeEnd = 43420, XrefRangeStart = 43392, XrefRangeEnd = 43417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupCloudsShadows(bool activate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&activate);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCloudsShadows_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43420, XrefRangeEnd = 43423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DirectionalLightCloudCookie()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirectionalLightCloudCookie>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DirectionalLightCloudCookie()
	{
		Il2CppClassPointerStore<DirectionalLightCloudCookie>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "DirectionalLightCloudCookie");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirectionalLightCloudCookie>.NativeClassPtr);
		NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightCloudCookie>.NativeClassPtr, "active");
		NativeFieldInfoPtr_customRenderTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightCloudCookie>.NativeClassPtr, "customRenderTexture");
		NativeFieldInfoPtr_hdlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightCloudCookie>.NativeClassPtr, "hdlight");
		NativeFieldInfoPtr_cookieSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightCloudCookie>.NativeClassPtr, "cookieSize");
		NativeFieldInfoPtr_cookieScrollSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLightCloudCookie>.NativeClassPtr, "cookieScrollSpeed");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectionalLightCloudCookie>.NativeClassPtr, 100665921);
		NativeMethodInfoPtr_SetupCloudsShadows_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectionalLightCloudCookie>.NativeClassPtr, 100665922);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectionalLightCloudCookie>.NativeClassPtr, 100665923);
	}

	public DirectionalLightCloudCookie(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
