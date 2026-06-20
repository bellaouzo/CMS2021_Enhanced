using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Net;
using Il2CppSystem.Net.Sockets;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

public class UdpSender : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_client;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_sendPoint;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendSync_Public_Void_ArrayOf_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendAsync_Public_Void_ArrayOf_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MessageSentA_Private_Void_IAsyncResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UdpSender>.NativeClassPtr));

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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108643, XrefRangeEnd = 108659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UdpSender(string server, int port)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UdpSender>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(server);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &port;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108659, XrefRangeEnd = 108660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Finalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108660, XrefRangeEnd = 108661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendSync(Il2CppStructArray<byte> bytesToSend, [Optional] int maxBytes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytesToSend);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxBytes;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendSync_Public_Void_ArrayOf_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108661, XrefRangeEnd = 108667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendAsync(Il2CppStructArray<byte> bytesToSend, [Optional] int maxBytes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytesToSend);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxBytes;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendAsync_Public_Void_ArrayOf_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108667, XrefRangeEnd = 108678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MessageSentA(Il2CppSystem.IAsyncResult ar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ar);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MessageSentA_Private_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108678, XrefRangeEnd = 108679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Close()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static UdpSender()
	{
		Il2CppClassPointerStore<UdpSender>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "UdpSender");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UdpSender>.NativeClassPtr);
		NativeFieldInfoPtr_m_client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UdpSender>.NativeClassPtr, "m_client");
		NativeFieldInfoPtr_m_sendPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UdpSender>.NativeClassPtr, "m_sendPoint");
		NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpSender>.NativeClassPtr, 100670062);
		NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpSender>.NativeClassPtr, 100670063);
		NativeMethodInfoPtr_SendSync_Public_Void_ArrayOf_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpSender>.NativeClassPtr, 100670064);
		NativeMethodInfoPtr_SendAsync_Public_Void_ArrayOf_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpSender>.NativeClassPtr, 100670065);
		NativeMethodInfoPtr_MessageSentA_Private_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpSender>.NativeClassPtr, 100670066);
		NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpSender>.NativeClassPtr, 100670067);
	}

	public UdpSender(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
