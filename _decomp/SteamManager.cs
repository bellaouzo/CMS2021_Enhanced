using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Text;
using Steamworks;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class SteamManager : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_EverInitialized;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_bInitialized;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SteamAPIWarningMessageHook;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Initialized_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SteamAPIDebugTextHook_Private_Static_Void_Int32_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SteamManager>.NativeClassPtr));

	public unsafe static bool s_EverInitialized
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_EverInitialized, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_EverInitialized, &flag);
		}
	}

	public unsafe static bool m_bInitialized
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_bInitialized, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_bInitialized, &flag);
		}
	}

	public unsafe SteamAPIWarningMessageHook_t m_SteamAPIWarningMessageHook
	{
		get
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SteamAPIWarningMessageHook);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr == (System.IntPtr)0) ? ((SteamAPIWarningMessageHook_t)null) : new SteamAPIWarningMessageHook_t(intPtr);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SteamAPIWarningMessageHook), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe static bool Initialized
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17078, XrefRangeEnd = 17080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Initialized_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17080, XrefRangeEnd = 17084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&nSeverity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(pchDebugText);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SteamAPIDebugTextHook_Private_Static_Void_Int32_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17084, XrefRangeEnd = 17123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17123, XrefRangeEnd = 17135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17135, XrefRangeEnd = 17174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17174, XrefRangeEnd = 17180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe SteamManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SteamManager()
	{
		Il2CppClassPointerStore<SteamManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SteamManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamManager>.NativeClassPtr);
		NativeFieldInfoPtr_s_EverInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, "s_EverInitialized");
		NativeFieldInfoPtr_m_bInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, "m_bInitialized");
		NativeFieldInfoPtr_m_SteamAPIWarningMessageHook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, "m_SteamAPIWarningMessageHook");
		NativeMethodInfoPtr_get_Initialized_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, 100664534);
		NativeMethodInfoPtr_SteamAPIDebugTextHook_Private_Static_Void_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, 100664535);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, 100664536);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, 100664537);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, 100664538);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, 100664539);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, 100664540);
	}

	public SteamManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
