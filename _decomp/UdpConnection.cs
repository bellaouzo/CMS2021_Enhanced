using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Net;
using Il2CppSystem.Net.Sockets;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

public class UdpConnection : Il2CppSystem.Object
{
	public class UdpState : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_client;

		private static readonly System.IntPtr NativeFieldInfoPtr_endPoint;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UdpState>.NativeClassPtr));

		public unsafe UdpClient client
		{
			get
			{
				//IL_0021: Unknown result type (might be due to invalid IL or missing references)
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_client);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr == (System.IntPtr)0) ? ((UdpClient)null) : new UdpClient(intPtr);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_client), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
			}
		}

		public unsafe IPEndPoint endPoint
		{
			get
			{
				//IL_0021: Unknown result type (might be due to invalid IL or missing references)
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endPoint);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr == (System.IntPtr)0) ? ((IPEndPoint)null) : new IPEndPoint(intPtr);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endPoint), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe UdpState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UdpState>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static UdpState()
		{
			Il2CppClassPointerStore<UdpState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, "UdpState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UdpState>.NativeClassPtr);
			NativeFieldInfoPtr_client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UdpState>.NativeClassPtr, "client");
			NativeFieldInfoPtr_endPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UdpState>.NativeClassPtr, "endPoint");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpState>.NativeClassPtr, 100670052);
		}

		public UdpState(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_client;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_listenPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_state;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_receivedBytes;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_received;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_sendPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_sent;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_lastBytesSent;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartConnection_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopConnection_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_connected_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_localDescription_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_remoteDescription_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_messageReceived_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_receivedMessageSize_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMessageString_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMessageBinary_Public_Int32_ArrayOf_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueryNextMessage_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MessageReceived_Private_Void_IAsyncResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDestination_Public_Void_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lastBytesSent_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_canSendMessage_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendMessageBinary_Public_Void_ArrayOf_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendMessageBinary_Public_Void_ArrayOf_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendMessageString_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MessageSent_Private_Void_IAsyncResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendMessageSync_Private_Static_Void_String_Int32_ArrayOf_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendMessageSync_Private_Static_Void_String_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendMessageAsync_Private_Static_Void_String_Int32_ArrayOf_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendMessageAsync_Private_Static_Void_String_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MessageSentA_Private_Static_Void_IAsyncResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr));

	public unsafe UdpClient m_client
	{
		get
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_client);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr == (System.IntPtr)0) ? ((UdpClient)null) : new UdpClient(intPtr);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_client), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe IPEndPoint m_listenPoint
	{
		get
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_listenPoint);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr == (System.IntPtr)0) ? ((IPEndPoint)null) : new IPEndPoint(intPtr);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_listenPoint), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe UdpState m_state
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_state);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new UdpState(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_state), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<byte> m_receivedBytes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_receivedBytes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<byte>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_receivedBytes), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool m_received
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_received);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_received)) = flag;
		}
	}

	public unsafe IPEndPoint m_sendPoint
	{
		get
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sendPoint);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr == (System.IntPtr)0) ? ((IPEndPoint)null) : new IPEndPoint(intPtr);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sendPoint), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe bool m_sent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sent);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_sent)) = flag;
		}
	}

	public unsafe int m_lastBytesSent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastBytesSent);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_lastBytesSent)) = num;
		}
	}

	public unsafe bool connected
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_connected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe string localDescription
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108469, XrefRangeEnd = 108471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_localDescription_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
	}

	public unsafe string remoteDescription
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108471, XrefRangeEnd = 108473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_remoteDescription_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
	}

	public unsafe bool messageReceived
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_messageReceived_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe int receivedMessageSize
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_receivedMessageSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe int lastBytesSent
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lastBytesSent_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe bool canSendMessage
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108509, XrefRangeEnd = 108513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_canSendMessage_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108438, XrefRangeEnd = 108469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartConnection(int listenPort)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&listenPort);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartConnection_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void StopConnection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopConnection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108473, XrefRangeEnd = 108476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetMessageString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMessageString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108476, XrefRangeEnd = 108477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetMessageBinary(Il2CppStructArray<byte> buffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMessageBinary_Public_Int32_ArrayOf_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 108490, RefRangeEnd = 108493, XrefRangeStart = 108477, XrefRangeEnd = 108490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void QueryNextMessage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueryNextMessage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108493, XrefRangeEnd = 108504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MessageReceived(Il2CppSystem.IAsyncResult ar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ar);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MessageReceived_Private_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108504, XrefRangeEnd = 108509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDestination(string dest, int port)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(dest);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &port;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDestination_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108513, XrefRangeEnd = 108523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendMessageBinary(Il2CppStructArray<byte> bytesToSend)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytesToSend);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendMessageBinary_Public_Void_ArrayOf_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108523, XrefRangeEnd = 108533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendMessageBinary(Il2CppStructArray<byte> bytesToSend, int size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytesToSend);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendMessageBinary_Public_Void_ArrayOf_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108533, XrefRangeEnd = 108544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendMessageString(string message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendMessageString_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108544, XrefRangeEnd = 108551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MessageSent(Il2CppSystem.IAsyncResult ar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ar);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MessageSent_Private_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 108564, RefRangeEnd = 108565, XrefRangeStart = 108551, XrefRangeEnd = 108564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendMessageSync(string server, int port, Il2CppStructArray<byte> bytesToSend)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(server);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &port;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bytesToSend);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendMessageSync_Private_Static_Void_String_Int32_ArrayOf_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108565, XrefRangeEnd = 108568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendMessageSync(string server, int port, string message)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(server);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &port;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(message);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendMessageSync_Private_Static_Void_String_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 108583, RefRangeEnd = 108584, XrefRangeStart = 108568, XrefRangeEnd = 108583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendMessageAsync(string server, int port, Il2CppStructArray<byte> bytesToSend)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(server);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &port;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bytesToSend);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendMessageAsync_Private_Static_Void_String_Int32_ArrayOf_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108584, XrefRangeEnd = 108587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendMessageAsync(string server, int port, string message)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(server);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &port;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(message);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendMessageAsync_Private_Static_Void_String_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108587, XrefRangeEnd = 108596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MessageSentA(Il2CppSystem.IAsyncResult ar)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ar);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MessageSentA_Private_Static_Void_IAsyncResult_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe UdpConnection()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static UdpConnection()
	{
		Il2CppClassPointerStore<UdpConnection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "UdpConnection");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr);
		NativeFieldInfoPtr_m_client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, "m_client");
		NativeFieldInfoPtr_m_listenPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, "m_listenPoint");
		NativeFieldInfoPtr_m_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, "m_state");
		NativeFieldInfoPtr_m_receivedBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, "m_receivedBytes");
		NativeFieldInfoPtr_m_received = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, "m_received");
		NativeFieldInfoPtr_m_sendPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, "m_sendPoint");
		NativeFieldInfoPtr_m_sent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, "m_sent");
		NativeFieldInfoPtr_m_lastBytesSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, "m_lastBytesSent");
		NativeMethodInfoPtr_StartConnection_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, 100670028);
		NativeMethodInfoPtr_StopConnection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, 100670029);
		NativeMethodInfoPtr_get_connected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, 100670030);
		NativeMethodInfoPtr_get_localDescription_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, 100670031);
		NativeMethodInfoPtr_get_remoteDescription_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, 100670032);
		NativeMethodInfoPtr_get_messageReceived_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, 100670033);
		NativeMethodInfoPtr_get_receivedMessageSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, 100670034);
		NativeMethodInfoPtr_GetMessageString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, 100670035);
		NativeMethodInfoPtr_GetMessageBinary_Public_Int32_ArrayOf_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, 100670036);
		NativeMethodInfoPtr_QueryNextMessage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, 100670037);
		NativeMethodInfoPtr_MessageReceived_Private_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, 100670038);
		NativeMethodInfoPtr_SetDestination_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, 100670039);
		NativeMethodInfoPtr_get_lastBytesSent_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, 100670040);
		NativeMethodInfoPtr_get_canSendMessage_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, 100670041);
		NativeMethodInfoPtr_SendMessageBinary_Public_Void_ArrayOf_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, 100670042);
		NativeMethodInfoPtr_SendMessageBinary_Public_Void_ArrayOf_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, 100670043);
		NativeMethodInfoPtr_SendMessageString_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, 100670044);
		NativeMethodInfoPtr_MessageSent_Private_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, 100670045);
		NativeMethodInfoPtr_SendMessageSync_Private_Static_Void_String_Int32_ArrayOf_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, 100670046);
		NativeMethodInfoPtr_SendMessageSync_Private_Static_Void_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, 100670047);
		NativeMethodInfoPtr_SendMessageAsync_Private_Static_Void_String_Int32_ArrayOf_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, 100670048);
		NativeMethodInfoPtr_SendMessageAsync_Private_Static_Void_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, 100670049);
		NativeMethodInfoPtr_MessageSentA_Private_Static_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, 100670050);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpConnection>.NativeClassPtr, 100670051);
	}

	public UdpConnection(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
