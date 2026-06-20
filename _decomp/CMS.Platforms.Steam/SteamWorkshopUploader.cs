using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Steamworks;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace CMS.Platforms.Steam;

public class SteamWorkshopUploader : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Sequential)]
	public sealed class WorkshopItem : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Title;

		private static readonly System.IntPtr NativeFieldInfoPtr_Description;

		private static readonly System.IntPtr NativeFieldInfoPtr_Language;

		private static readonly System.IntPtr NativeFieldInfoPtr_Metadata;

		private static readonly System.IntPtr NativeFieldInfoPtr_Visibility;

		private static readonly System.IntPtr NativeFieldInfoPtr_Tags;

		private static readonly System.IntPtr NativeFieldInfoPtr_PreviewPath;

		private static readonly System.IntPtr NativeFieldInfoPtr_ContentPath;

		private static readonly System.IntPtr NativeFieldInfoPtr_Changelog;

		private static readonly System.IntPtr NativeFieldInfoPtr_PackageID;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WorkshopItem>.NativeClassPtr));

		public unsafe string Title
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Title);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Title), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe string Description
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Description);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe string Language
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Language);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Language), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe string Metadata
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Metadata);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Metadata), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe ERemoteStoragePublishedFileVisibility Visibility
		{
			get
			{
				//IL_0016: Unknown result type (might be due to invalid IL or missing references)
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Visibility);
				return System.Runtime.CompilerServices.Unsafe.Read<ERemoteStoragePublishedFileVisibility>((void*)num);
			}
			set
			{
				//IL_0015: Unknown result type (might be due to invalid IL or missing references)
				//IL_0019: Unknown result type (might be due to invalid IL or missing references)
				System.Runtime.CompilerServices.Unsafe.Write((void*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Visibility)), val);
			}
		}

		public unsafe Il2CppStringArray Tags
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Tags);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppStringArray(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Tags), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe string PreviewPath
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PreviewPath);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PreviewPath), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe string ContentPath
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ContentPath);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ContentPath), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe string Changelog
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Changelog);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Changelog), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe ulong PackageID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PackageID);
				return *(ulong*)num;
			}
			set
			{
				*(ulong*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PackageID)) = num;
			}
		}

		static WorkshopItem()
		{
			Il2CppClassPointerStore<WorkshopItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamWorkshopUploader>.NativeClassPtr, "WorkshopItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkshopItem>.NativeClassPtr);
			NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopItem>.NativeClassPtr, "Title");
			NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopItem>.NativeClassPtr, "Description");
			NativeFieldInfoPtr_Language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopItem>.NativeClassPtr, "Language");
			NativeFieldInfoPtr_Metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopItem>.NativeClassPtr, "Metadata");
			NativeFieldInfoPtr_Visibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopItem>.NativeClassPtr, "Visibility");
			NativeFieldInfoPtr_Tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopItem>.NativeClassPtr, "Tags");
			NativeFieldInfoPtr_PreviewPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopItem>.NativeClassPtr, "PreviewPath");
			NativeFieldInfoPtr_ContentPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopItem>.NativeClassPtr, "ContentPath");
			NativeFieldInfoPtr_Changelog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopItem>.NativeClassPtr, "Changelog");
			NativeFieldInfoPtr_PackageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopItem>.NativeClassPtr, "PackageID");
		}

		public WorkshopItem(System.IntPtr P_0)
			: base(P_0)
		{
		}

		public unsafe WorkshopItem()
			: base(IL2CPP.il2cpp_value_box(data: (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WorkshopItem>.NativeClassPtr, ref *(uint*)null)], klass: Il2CppClassPointerStore<WorkshopItem>.NativeClassPtr))
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct UploadProgress
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Status;

		private static readonly System.IntPtr NativeFieldInfoPtr_BytesProcessed;

		private static readonly System.IntPtr NativeFieldInfoPtr_BytesTotal;

		[FieldOffset(0)]
		public EItemUpdateStatus Status;

		[FieldOffset(8)]
		public ulong BytesProcessed;

		[FieldOffset(16)]
		public ulong BytesTotal;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UploadProgress>.NativeClassPtr));

		static UploadProgress()
		{
			Il2CppClassPointerStore<UploadProgress>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamWorkshopUploader>.NativeClassPtr, "UploadProgress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UploadProgress>.NativeClassPtr);
			NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UploadProgress>.NativeClassPtr, "Status");
			NativeFieldInfoPtr_BytesProcessed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UploadProgress>.NativeClassPtr, "BytesProcessed");
			NativeFieldInfoPtr_BytesTotal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UploadProgress>.NativeClassPtr, "BytesTotal");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UploadProgress>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
		}
	}

	[ObfuscatedName("CMS.Platforms.Steam.SteamWorkshopUploader/<CreateItem>d__13")]
	public sealed class _CreateItem_d__13 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr_item;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_CreateItem_d__13>.NativeClassPtr));

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
			}
		}

		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe WorkshopItem item
		{
			get
			{
				nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_item);
				return new WorkshopItem(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorkshopItem>.NativeClassPtr, data));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_item), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WorkshopItem>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe SteamWorkshopUploader __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new SteamWorkshopUploader(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Il2CppSystem.Object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
			}
		}

		public unsafe Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
			}
		}

		[CallerCount(0)]
		public unsafe _CreateItem_d__13(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_CreateItem_d__13>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&_003C_003E1__state);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229404, XrefRangeEnd = 229420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229420, XrefRangeEnd = 229425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _CreateItem_d__13()
		{
			Il2CppClassPointerStore<_CreateItem_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamWorkshopUploader>.NativeClassPtr, "<CreateItem>d__13");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_CreateItem_d__13>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_CreateItem_d__13>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_CreateItem_d__13>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_CreateItem_d__13>.NativeClassPtr, "item");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_CreateItem_d__13>.NativeClassPtr, "<>4__this");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_CreateItem_d__13>.NativeClassPtr, 100680572);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_CreateItem_d__13>.NativeClassPtr, 100680573);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_CreateItem_d__13>.NativeClassPtr, 100680574);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_CreateItem_d__13>.NativeClassPtr, 100680575);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_CreateItem_d__13>.NativeClassPtr, 100680576);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_CreateItem_d__13>.NativeClassPtr, 100680577);
		}

		public _CreateItem_d__13(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_submitItemUpdateResult;

	private static readonly System.IntPtr NativeFieldInfoPtr_createItemCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnCreateItemFailed;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnUpdateItemFailed;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnSubmitItemUpdateFailed;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnSubmitItemUpdateFinished;

	private static readonly System.IntPtr NativeFieldInfoPtr_uploadInProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_UploadFailed;

	private static readonly System.IntPtr NativeFieldInfoPtr_Item;

	private static readonly System.IntPtr NativeFieldInfoPtr_updateHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_PackageID;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateItem_Public_IEnumerator_WorkshopItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateItemCallback_Private_Void_CreateItemResult_t_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateItem_Private_Void_PublishedFileId_t_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateItemData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SubmitItemUpdateCallback_Private_Void_SubmitItemUpdateResult_t_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUploadProgress_Public_UploadProgress_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SteamWorkshopUploader>.NativeClassPtr));

	public unsafe CallResult<SubmitItemUpdateResult_t> submitItemUpdateResult
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_submitItemUpdateResult);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CallResult<SubmitItemUpdateResult_t>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_submitItemUpdateResult), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe CallResult<CreateItemResult_t> createItemCallback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createItemCallback);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CallResult<CreateItemResult_t>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createItemCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe Il2CppSystem.Action<EResult> OnCreateItemFailed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnCreateItemFailed);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<EResult>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnCreateItemFailed), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Action<string> OnUpdateItemFailed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnUpdateItemFailed);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<string>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnUpdateItemFailed), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Action<EResult> OnSubmitItemUpdateFailed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnSubmitItemUpdateFailed);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<EResult>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnSubmitItemUpdateFailed), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Action<string> OnSubmitItemUpdateFinished
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnSubmitItemUpdateFinished);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Action<string>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnSubmitItemUpdateFinished), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool uploadInProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uploadInProgress);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uploadInProgress)) = flag;
		}
	}

	public unsafe bool UploadFailed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UploadFailed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UploadFailed)) = flag;
		}
	}

	public unsafe WorkshopItem Item
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Item);
			return new WorkshopItem(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorkshopItem>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Item), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WorkshopItem>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe UGCUpdateHandle_t updateHandle
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateHandle);
			return System.Runtime.CompilerServices.Unsafe.Read<UGCUpdateHandle_t>((void*)num);
		}
		set
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			System.Runtime.CompilerServices.Unsafe.Write((void*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateHandle)), val);
		}
	}

	public unsafe ulong PackageID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PackageID);
			return *(ulong*)num;
		}
		set
		{
			*(ulong*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PackageID)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229425, XrefRangeEnd = 229428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator CreateItem(WorkshopItem item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateItem_Public_IEnumerator_WorkshopItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229428, XrefRangeEnd = 229457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateItemCallback(CreateItemResult_t param, bool ioFailure)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&param);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ioFailure;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateItemCallback_Private_Void_CreateItemResult_t_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 229490, RefRangeEnd = 229492, XrefRangeStart = 229457, XrefRangeEnd = 229490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateItem(PublishedFileId_t publishedFileId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&publishedFileId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateItem_Private_Void_PublishedFileId_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 229623, RefRangeEnd = 229624, XrefRangeStart = 229492, XrefRangeEnd = 229623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateItemData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateItemData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229624, XrefRangeEnd = 229665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SubmitItemUpdateCallback(SubmitItemUpdateResult_t param, bool ioFailure)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&param);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ioFailure;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SubmitItemUpdateCallback_Private_Void_SubmitItemUpdateResult_t_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229665, XrefRangeEnd = 229670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UploadProgress GetUploadProgress()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUploadProgress_Public_UploadProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return System.Runtime.CompilerServices.Unsafe.Read<UploadProgress>((void*)IL2CPP.il2cpp_object_unbox(obj));
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe SteamWorkshopUploader()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamWorkshopUploader>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SteamWorkshopUploader()
	{
		Il2CppClassPointerStore<SteamWorkshopUploader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Platforms.Steam", "SteamWorkshopUploader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamWorkshopUploader>.NativeClassPtr);
		NativeFieldInfoPtr_submitItemUpdateResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopUploader>.NativeClassPtr, "submitItemUpdateResult");
		NativeFieldInfoPtr_createItemCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopUploader>.NativeClassPtr, "createItemCallback");
		NativeFieldInfoPtr_OnCreateItemFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopUploader>.NativeClassPtr, "OnCreateItemFailed");
		NativeFieldInfoPtr_OnUpdateItemFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopUploader>.NativeClassPtr, "OnUpdateItemFailed");
		NativeFieldInfoPtr_OnSubmitItemUpdateFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopUploader>.NativeClassPtr, "OnSubmitItemUpdateFailed");
		NativeFieldInfoPtr_OnSubmitItemUpdateFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopUploader>.NativeClassPtr, "OnSubmitItemUpdateFinished");
		NativeFieldInfoPtr_uploadInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopUploader>.NativeClassPtr, "uploadInProgress");
		NativeFieldInfoPtr_UploadFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopUploader>.NativeClassPtr, "UploadFailed");
		NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopUploader>.NativeClassPtr, "Item");
		NativeFieldInfoPtr_updateHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopUploader>.NativeClassPtr, "updateHandle");
		NativeFieldInfoPtr_PackageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopUploader>.NativeClassPtr, "PackageID");
		NativeMethodInfoPtr_CreateItem_Public_IEnumerator_WorkshopItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshopUploader>.NativeClassPtr, 100680565);
		NativeMethodInfoPtr_CreateItemCallback_Private_Void_CreateItemResult_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshopUploader>.NativeClassPtr, 100680566);
		NativeMethodInfoPtr_UpdateItem_Private_Void_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshopUploader>.NativeClassPtr, 100680567);
		NativeMethodInfoPtr_UpdateItemData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshopUploader>.NativeClassPtr, 100680568);
		NativeMethodInfoPtr_SubmitItemUpdateCallback_Private_Void_SubmitItemUpdateResult_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshopUploader>.NativeClassPtr, 100680569);
		NativeMethodInfoPtr_GetUploadProgress_Public_UploadProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshopUploader>.NativeClassPtr, 100680570);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshopUploader>.NativeClassPtr, 100680571);
	}

	public SteamWorkshopUploader(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
