using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Threading;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnhollowerRuntimeLib;

public class UdpListenThread : Il2CppSystem.Object
{
	public sealed class OnReceiveData : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<OnReceiveData>.NativeClassPtr));

		[CallerCount(70)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe OnReceiveData(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnReceiveData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(217)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe Il2CppSystem.IAsyncResult BeginInvoke(Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(@object);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.IAsyncResult(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static OnReceiveData()
		{
			Il2CppClassPointerStore<OnReceiveData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UdpListenThread>.NativeClassPtr, "OnReceiveData");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnReceiveData>.NativeClassPtr, 100670058);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnReceiveData>.NativeClassPtr, 100670059);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnReceiveData>.NativeClassPtr, 100670060);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnReceiveData>.NativeClassPtr, 100670061);
		}

		public OnReceiveData(System.IntPtr P_0)
			: base(P_0)
		{
		}

		public static implicit operator OnReceiveData(System.Action P_0)
		{
			return DelegateSupport.ConvertDelegate<OnReceiveData>(P_0);
		}

		public static OnReceiveData operator +(OnReceiveData P_0, OnReceiveData P_1)
		{
			return Il2CppSystem.Delegate.Combine(P_0, P_1).Cast<OnReceiveData>();
		}

		public static OnReceiveData operator -(OnReceiveData P_0, OnReceiveData P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<OnReceiveData>();
			}
			return (OnReceiveData)obj;
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_threadStopTimeoutMs;

	private static readonly System.IntPtr NativeFieldInfoPtr_threadSleepIntervalMs;

	private static readonly System.IntPtr NativeFieldInfoPtr_debug;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_connection;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_onReceiveDataCb;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_thread;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_threadExit;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Void_UdpConnection_OnReceiveData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ListenThread_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UdpListenThread>.NativeClassPtr));

	public unsafe int threadStopTimeoutMs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_threadStopTimeoutMs);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_threadStopTimeoutMs)) = num;
		}
	}

	public unsafe int threadSleepIntervalMs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_threadSleepIntervalMs);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_threadSleepIntervalMs)) = num;
		}
	}

	public unsafe bool debug
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debug);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debug)) = flag;
		}
	}

	public unsafe UdpConnection m_connection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_connection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new UdpConnection(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_connection), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe OnReceiveData m_onReceiveDataCb
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_onReceiveDataCb);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new OnReceiveData(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_onReceiveDataCb), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Thread m_thread
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_thread);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Thread(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_thread), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool m_threadExit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_threadExit);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_threadExit)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108596, XrefRangeEnd = 108598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Finalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108598, XrefRangeEnd = 108616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start(UdpConnection connection, OnReceiveData receiveDataCb)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(receiveDataCb);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Public_Void_UdpConnection_OnReceiveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 108629, RefRangeEnd = 108631, XrefRangeStart = 108616, XrefRangeEnd = 108629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Stop()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108631, XrefRangeEnd = 108643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ListenThread()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ListenThread_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe UdpListenThread()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UdpListenThread>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static UdpListenThread()
	{
		Il2CppClassPointerStore<UdpListenThread>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "UdpListenThread");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UdpListenThread>.NativeClassPtr);
		NativeFieldInfoPtr_threadStopTimeoutMs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UdpListenThread>.NativeClassPtr, "threadStopTimeoutMs");
		NativeFieldInfoPtr_threadSleepIntervalMs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UdpListenThread>.NativeClassPtr, "threadSleepIntervalMs");
		NativeFieldInfoPtr_debug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UdpListenThread>.NativeClassPtr, "debug");
		NativeFieldInfoPtr_m_connection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UdpListenThread>.NativeClassPtr, "m_connection");
		NativeFieldInfoPtr_m_onReceiveDataCb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UdpListenThread>.NativeClassPtr, "m_onReceiveDataCb");
		NativeFieldInfoPtr_m_thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UdpListenThread>.NativeClassPtr, "m_thread");
		NativeFieldInfoPtr_m_threadExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UdpListenThread>.NativeClassPtr, "m_threadExit");
		NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpListenThread>.NativeClassPtr, 100670053);
		NativeMethodInfoPtr_Start_Public_Void_UdpConnection_OnReceiveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpListenThread>.NativeClassPtr, 100670054);
		NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpListenThread>.NativeClassPtr, 100670055);
		NativeMethodInfoPtr_ListenThread_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpListenThread>.NativeClassPtr, 100670056);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpListenThread>.NativeClassPtr, 100670057);
	}

	public UdpListenThread(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
