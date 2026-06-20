using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Rewired;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

public class CameraCarInput : Singleton<CameraCarInput>
{
	private static readonly System.IntPtr NativeFieldInfoPtr_player;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CarInputEnable_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CameraMoveX_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CameraMoveY_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CameraScroll_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CameraCarInput>.NativeClassPtr));

	public unsafe Player player
	{
		get
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_player);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr == (System.IntPtr)0) ? ((Player)null) : new Player(intPtr);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18507, XrefRangeEnd = 18517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18517, XrefRangeEnd = 18521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CarInputEnable(bool enable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CarInputEnable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18521, XrefRangeEnd = 18525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CameraMoveX()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CameraMoveX_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18525, XrefRangeEnd = 18529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CameraMoveY()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CameraMoveY_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 18533, RefRangeEnd = 18534, XrefRangeStart = 18529, XrefRangeEnd = 18533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CameraScroll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CameraScroll_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18534, XrefRangeEnd = 18541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CameraCarInput()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraCarInput>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CameraCarInput()
	{
		Il2CppClassPointerStore<CameraCarInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CameraCarInput");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraCarInput>.NativeClassPtr);
		NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraCarInput>.NativeClassPtr, "player");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraCarInput>.NativeClassPtr, 100664684);
		NativeMethodInfoPtr_CarInputEnable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraCarInput>.NativeClassPtr, 100664685);
		NativeMethodInfoPtr_CameraMoveX_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraCarInput>.NativeClassPtr, 100664686);
		NativeMethodInfoPtr_CameraMoveY_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraCarInput>.NativeClassPtr, 100664687);
		NativeMethodInfoPtr_CameraScroll_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraCarInput>.NativeClassPtr, 100664688);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraCarInput>.NativeClassPtr, 100664689);
	}

	public CameraCarInput(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
