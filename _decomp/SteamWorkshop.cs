using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Steamworks;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class SteamWorkshop : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_singleton;

	private static readonly System.IntPtr NativeFieldInfoPtr_RemoteStoragePublishFileResult;

	private static readonly System.IntPtr NativeFieldInfoPtr_RemoteStorageEnumerateUserSubscribedFilesResult;

	private static readonly System.IntPtr NativeFieldInfoPtr_RemoteStorageGetPublishedFileDetailsResult;

	private static readonly System.IntPtr NativeFieldInfoPtr_RemoteStorageDownloadUGCResult;

	private static readonly System.IntPtr NativeFieldInfoPtr_RemoteStorageUnsubscribePublishedFileResult;

	private static readonly System.IntPtr NativeFieldInfoPtr_publishedFileID;

	private static readonly System.IntPtr NativeFieldInfoPtr_UGCHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_subscribedItemList;

	private static readonly System.IntPtr NativeFieldInfoPtr_fetchedContent;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemContent;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastFileName;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getContent_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSubscribedItems_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItemContent_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteFile_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveToWorkshop_Public_Void_String_String_String_ArrayOf_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UploadFile_Private_Boolean_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertZipToData_Public_ArrayOf_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapDataLength_Public_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UploadMap_Private_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UploadToWorkshop_Private_Void_String_String_String_ArrayOf_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unsubscribe_Public_Void_PublishedFileId_t_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnRemoteStorageUnsubscribePublishedFileResult_Private_Void_RemoteStorageUnsubscribePublishedFileResult_t_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnRemoteStoragePublishFileResult_Private_Void_RemoteStoragePublishFileResult_t_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnRemoteStorageEnumerateUserSubscribedFilesResult_Private_Void_RemoteStorageEnumerateUserSubscribedFilesResult_t_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnRemoteStorageGetPublishedFileDetailsResult_Private_Void_RemoteStorageGetPublishedFileDetailsResult_t_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnRemoteStorageDownloadUGCResult_Private_Void_RemoteStorageDownloadUGCResult_t_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr));

	public unsafe static SteamWorkshop singleton
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_singleton, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? new SteamWorkshop(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_singleton, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CallResult<RemoteStoragePublishFileResult_t> RemoteStoragePublishFileResult
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemoteStoragePublishFileResult);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CallResult<RemoteStoragePublishFileResult_t>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemoteStoragePublishFileResult), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe CallResult<RemoteStorageEnumerateUserSubscribedFilesResult_t> RemoteStorageEnumerateUserSubscribedFilesResult
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemoteStorageEnumerateUserSubscribedFilesResult);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CallResult<RemoteStorageEnumerateUserSubscribedFilesResult_t>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemoteStorageEnumerateUserSubscribedFilesResult), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe CallResult<RemoteStorageGetPublishedFileDetailsResult_t> RemoteStorageGetPublishedFileDetailsResult
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemoteStorageGetPublishedFileDetailsResult);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CallResult<RemoteStorageGetPublishedFileDetailsResult_t>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemoteStorageGetPublishedFileDetailsResult), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe CallResult<RemoteStorageDownloadUGCResult_t> RemoteStorageDownloadUGCResult
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemoteStorageDownloadUGCResult);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CallResult<RemoteStorageDownloadUGCResult_t>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemoteStorageDownloadUGCResult), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe CallResult<RemoteStorageUnsubscribePublishedFileResult_t> RemoteStorageUnsubscribePublishedFileResult
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemoteStorageUnsubscribePublishedFileResult);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CallResult<RemoteStorageUnsubscribePublishedFileResult_t>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemoteStorageUnsubscribePublishedFileResult), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe PublishedFileId_t publishedFileID
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_publishedFileID);
			return System.Runtime.CompilerServices.Unsafe.Read<PublishedFileId_t>((void*)num);
		}
		set
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			System.Runtime.CompilerServices.Unsafe.Write((void*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_publishedFileID)), val);
		}
	}

	public unsafe UGCHandle_t UGCHandle
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UGCHandle);
			return System.Runtime.CompilerServices.Unsafe.Read<UGCHandle_t>((void*)num);
		}
		set
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			System.Runtime.CompilerServices.Unsafe.Write((void*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UGCHandle)), val);
		}
	}

	public unsafe List<PublishedFileId_t> subscribedItemList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subscribedItemList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<PublishedFileId_t>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subscribedItemList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool fetchedContent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fetchedContent);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fetchedContent)) = flag;
		}
	}

	public unsafe string itemContent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemContent);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemContent), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string lastFileName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastFileName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastFileName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106369, XrefRangeEnd = 106376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106376, XrefRangeEnd = 106441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe string getContent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getContent_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106441, XrefRangeEnd = 106453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetSubscribedItems()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSubscribedItems_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106453, XrefRangeEnd = 106467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetItemContent(int ItemID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ItemID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemContent_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106467, XrefRangeEnd = 106479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeleteFile(string filename)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteFile_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106479, XrefRangeEnd = 106504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveToWorkshop(string pathToFile, string workshopTitle, string workshopDescription, Il2CppStringArray tags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(pathToFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(workshopTitle);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(workshopDescription);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(tags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveToWorkshop_Public_Void_String_String_String_ArrayOf_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106504, XrefRangeEnd = 106522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UploadFile(string fileName, string fileData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(fileData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UploadFile_Private_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106522, XrefRangeEnd = 106527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<byte> ConvertZipToData(string path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertZipToData_Public_ArrayOf_Byte_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<byte>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 106535, RefRangeEnd = 106540, XrefRangeStart = 106527, XrefRangeEnd = 106535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int MapDataLength(string path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapDataLength_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106540, XrefRangeEnd = 106547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UploadMap(string path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UploadMap_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106547, XrefRangeEnd = 106553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UploadToWorkshop(string fileName, string workshopTitle, string workshopDescription, Il2CppStringArray tags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(workshopTitle);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(workshopDescription);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(tags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UploadToWorkshop_Private_Void_String_String_String_ArrayOf_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106553, XrefRangeEnd = 106565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Unsubscribe(PublishedFileId_t file)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&file);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unsubscribe_Public_Void_PublishedFileId_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106565, XrefRangeEnd = 106614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRemoteStorageUnsubscribePublishedFileResult(RemoteStorageUnsubscribePublishedFileResult_t pCallback, bool bIOFailure)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pCallback);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bIOFailure;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnRemoteStorageUnsubscribePublishedFileResult_Private_Void_RemoteStorageUnsubscribePublishedFileResult_t_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106614, XrefRangeEnd = 106626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRemoteStoragePublishFileResult(RemoteStoragePublishFileResult_t pCallback, bool bIOFailure)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pCallback);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bIOFailure;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnRemoteStoragePublishFileResult_Private_Void_RemoteStoragePublishFileResult_t_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106626, XrefRangeEnd = 106640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRemoteStorageEnumerateUserSubscribedFilesResult(RemoteStorageEnumerateUserSubscribedFilesResult_t pCallback, bool bIOFailure)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)pCallback));
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bIOFailure;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnRemoteStorageEnumerateUserSubscribedFilesResult_Private_Void_RemoteStorageEnumerateUserSubscribedFilesResult_t_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106640, XrefRangeEnd = 106651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRemoteStorageGetPublishedFileDetailsResult(RemoteStorageGetPublishedFileDetailsResult_t pCallback, bool bIOFailure)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)pCallback));
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bIOFailure;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnRemoteStorageGetPublishedFileDetailsResult_Private_Void_RemoteStorageGetPublishedFileDetailsResult_t_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106651, XrefRangeEnd = 106668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRemoteStorageDownloadUGCResult(RemoteStorageDownloadUGCResult_t pCallback, bool bIOFailure)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)pCallback));
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bIOFailure;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnRemoteStorageDownloadUGCResult_Private_Void_RemoteStorageDownloadUGCResult_t_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe SteamWorkshop()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SteamWorkshop()
	{
		Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SteamWorkshop");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr);
		NativeFieldInfoPtr_singleton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr, "singleton");
		NativeFieldInfoPtr_RemoteStoragePublishFileResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr, "RemoteStoragePublishFileResult");
		NativeFieldInfoPtr_RemoteStorageEnumerateUserSubscribedFilesResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr, "RemoteStorageEnumerateUserSubscribedFilesResult");
		NativeFieldInfoPtr_RemoteStorageGetPublishedFileDetailsResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr, "RemoteStorageGetPublishedFileDetailsResult");
		NativeFieldInfoPtr_RemoteStorageDownloadUGCResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr, "RemoteStorageDownloadUGCResult");
		NativeFieldInfoPtr_RemoteStorageUnsubscribePublishedFileResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr, "RemoteStorageUnsubscribePublishedFileResult");
		NativeFieldInfoPtr_publishedFileID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr, "publishedFileID");
		NativeFieldInfoPtr_UGCHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr, "UGCHandle");
		NativeFieldInfoPtr_subscribedItemList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr, "subscribedItemList");
		NativeFieldInfoPtr_fetchedContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr, "fetchedContent");
		NativeFieldInfoPtr_itemContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr, "itemContent");
		NativeFieldInfoPtr_lastFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr, "lastFileName");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr, 100669721);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr, 100669722);
		NativeMethodInfoPtr_getContent_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr, 100669723);
		NativeMethodInfoPtr_GetSubscribedItems_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr, 100669724);
		NativeMethodInfoPtr_GetItemContent_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr, 100669725);
		NativeMethodInfoPtr_DeleteFile_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr, 100669726);
		NativeMethodInfoPtr_SaveToWorkshop_Public_Void_String_String_String_ArrayOf_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr, 100669727);
		NativeMethodInfoPtr_UploadFile_Private_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr, 100669728);
		NativeMethodInfoPtr_ConvertZipToData_Public_ArrayOf_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr, 100669729);
		NativeMethodInfoPtr_MapDataLength_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr, 100669730);
		NativeMethodInfoPtr_UploadMap_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr, 100669731);
		NativeMethodInfoPtr_UploadToWorkshop_Private_Void_String_String_String_ArrayOf_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr, 100669732);
		NativeMethodInfoPtr_Unsubscribe_Public_Void_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr, 100669733);
		NativeMethodInfoPtr_OnRemoteStorageUnsubscribePublishedFileResult_Private_Void_RemoteStorageUnsubscribePublishedFileResult_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr, 100669734);
		NativeMethodInfoPtr_OnRemoteStoragePublishFileResult_Private_Void_RemoteStoragePublishFileResult_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr, 100669735);
		NativeMethodInfoPtr_OnRemoteStorageEnumerateUserSubscribedFilesResult_Private_Void_RemoteStorageEnumerateUserSubscribedFilesResult_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr, 100669736);
		NativeMethodInfoPtr_OnRemoteStorageGetPublishedFileDetailsResult_Private_Void_RemoteStorageGetPublishedFileDetailsResult_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr, 100669737);
		NativeMethodInfoPtr_OnRemoteStorageDownloadUGCResult_Private_Void_RemoteStorageDownloadUGCResult_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr, 100669738);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshop>.NativeClassPtr, 100669739);
	}

	public SteamWorkshop(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
