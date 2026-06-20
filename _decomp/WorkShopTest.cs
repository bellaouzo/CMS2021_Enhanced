using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Steamworks;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

public class WorkShopTest : MonoBehaviour
{
	public class SteamWorkshopItem : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__FileId_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__Title_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__Description_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__Metadata_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__Visibility_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__Tags_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__KeyValues_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__UpdateLanguage_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__UpdateContentPath_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__UpdatePreviewPath_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_FileId_Public_get_PublishedFileId_t_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_FileId_Public_set_Void_PublishedFileId_t_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Title_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_Title_Public_set_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Description_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_Description_Public_set_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Metadata_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_Metadata_Public_set_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Visibility_Public_get_ERemoteStoragePublishedFileVisibility_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_Visibility_Public_set_Void_ERemoteStoragePublishedFileVisibility_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Tags_Public_get_List_1_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_Tags_Public_set_Void_List_1_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_KeyValues_Public_get_Dictionary_2_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_KeyValues_Public_set_Void_Dictionary_2_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_UpdateLanguage_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_UpdateLanguage_Public_set_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_UpdateContentPath_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_UpdateContentPath_Public_set_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_UpdatePreviewPath_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_UpdatePreviewPath_Public_set_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr));

		public unsafe PublishedFileId_t _FileId_k__BackingField
		{
			get
			{
				//IL_0016: Unknown result type (might be due to invalid IL or missing references)
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FileId_k__BackingField);
				return System.Runtime.CompilerServices.Unsafe.Read<PublishedFileId_t>((void*)num);
			}
			set
			{
				//IL_0015: Unknown result type (might be due to invalid IL or missing references)
				//IL_0019: Unknown result type (might be due to invalid IL or missing references)
				System.Runtime.CompilerServices.Unsafe.Write((void*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FileId_k__BackingField)), val);
			}
		}

		public unsafe string _Title_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Title_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Title_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe string _Description_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Description_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Description_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe string _Metadata_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Metadata_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Metadata_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe ERemoteStoragePublishedFileVisibility _Visibility_k__BackingField
		{
			get
			{
				//IL_0016: Unknown result type (might be due to invalid IL or missing references)
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Visibility_k__BackingField);
				return System.Runtime.CompilerServices.Unsafe.Read<ERemoteStoragePublishedFileVisibility>((void*)num);
			}
			set
			{
				//IL_0015: Unknown result type (might be due to invalid IL or missing references)
				//IL_0019: Unknown result type (might be due to invalid IL or missing references)
				System.Runtime.CompilerServices.Unsafe.Write((void*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Visibility_k__BackingField)), val);
			}
		}

		public unsafe List<string> _Tags_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Tags_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Tags_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Dictionary<string, string> _KeyValues_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__KeyValues_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new Dictionary<string, string>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__KeyValues_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe string _UpdateLanguage_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UpdateLanguage_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UpdateLanguage_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe string _UpdateContentPath_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UpdateContentPath_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UpdateContentPath_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe string _UpdatePreviewPath_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UpdatePreviewPath_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UpdatePreviewPath_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe PublishedFileId_t FileId
		{
			[CallerCount(1)]
			[CachedScanResults(/*Could not decode attribute arguments.*/)]
			get
			{
				//IL_003e: Unknown result type (might be due to invalid IL or missing references)
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FileId_Public_get_PublishedFileId_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return System.Runtime.CompilerServices.Unsafe.Read<PublishedFileId_t>((void*)IL2CPP.il2cpp_object_unbox(obj));
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_FileId_Public_set_Void_PublishedFileId_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe string Title
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Title_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(60)]
			[CachedScanResults(/*Could not decode attribute arguments.*/)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Title_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe string Description
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Description_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(38)]
			[CachedScanResults(/*Could not decode attribute arguments.*/)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Description_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe string Metadata
		{
			[CallerCount(4)]
			[CachedScanResults(/*Could not decode attribute arguments.*/)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Metadata_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(150)]
			[CachedScanResults(/*Could not decode attribute arguments.*/)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Metadata_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe ERemoteStoragePublishedFileVisibility Visibility
		{
			[CallerCount(0)]
			get
			{
				//IL_003e: Unknown result type (might be due to invalid IL or missing references)
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Visibility_Public_get_ERemoteStoragePublishedFileVisibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return System.Runtime.CompilerServices.Unsafe.Read<ERemoteStoragePublishedFileVisibility>((void*)IL2CPP.il2cpp_object_unbox(obj));
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Visibility_Public_set_Void_ERemoteStoragePublishedFileVisibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe List<string> Tags
		{
			[CallerCount(70)]
			[CachedScanResults(/*Could not decode attribute arguments.*/)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Tags_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
			}
			[CallerCount(44)]
			[CachedScanResults(/*Could not decode attribute arguments.*/)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Tags_Public_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe Dictionary<string, string> KeyValues
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_KeyValues_Public_get_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return (intPtr != (System.IntPtr)0) ? new Dictionary<string, string>(intPtr) : null;
			}
			[CallerCount(36)]
			[CachedScanResults(/*Could not decode attribute arguments.*/)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_KeyValues_Public_set_Void_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe string UpdateLanguage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UpdateLanguage_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(20)]
			[CachedScanResults(/*Could not decode attribute arguments.*/)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_UpdateLanguage_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe string UpdateContentPath
		{
			[CallerCount(1)]
			[CachedScanResults(/*Could not decode attribute arguments.*/)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UpdateContentPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(27)]
			[CachedScanResults(/*Could not decode attribute arguments.*/)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_UpdateContentPath_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe string UpdatePreviewPath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UpdatePreviewPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(13)]
			[CachedScanResults(/*Could not decode attribute arguments.*/)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_UpdatePreviewPath_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe SteamWorkshopItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static SteamWorkshopItem()
		{
			Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkShopTest>.NativeClassPtr, "SteamWorkshopItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr);
			NativeFieldInfoPtr__FileId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, "<FileId>k__BackingField");
			NativeFieldInfoPtr__Title_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, "<Title>k__BackingField");
			NativeFieldInfoPtr__Description_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, "<Description>k__BackingField");
			NativeFieldInfoPtr__Metadata_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, "<Metadata>k__BackingField");
			NativeFieldInfoPtr__Visibility_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, "<Visibility>k__BackingField");
			NativeFieldInfoPtr__Tags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, "<Tags>k__BackingField");
			NativeFieldInfoPtr__KeyValues_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, "<KeyValues>k__BackingField");
			NativeFieldInfoPtr__UpdateLanguage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, "<UpdateLanguage>k__BackingField");
			NativeFieldInfoPtr__UpdateContentPath_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, "<UpdateContentPath>k__BackingField");
			NativeFieldInfoPtr__UpdatePreviewPath_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, "<UpdatePreviewPath>k__BackingField");
			NativeMethodInfoPtr_get_FileId_Public_get_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, 100669750);
			NativeMethodInfoPtr_set_FileId_Public_set_Void_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, 100669751);
			NativeMethodInfoPtr_get_Title_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, 100669752);
			NativeMethodInfoPtr_set_Title_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, 100669753);
			NativeMethodInfoPtr_get_Description_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, 100669754);
			NativeMethodInfoPtr_set_Description_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, 100669755);
			NativeMethodInfoPtr_get_Metadata_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, 100669756);
			NativeMethodInfoPtr_set_Metadata_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, 100669757);
			NativeMethodInfoPtr_get_Visibility_Public_get_ERemoteStoragePublishedFileVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, 100669758);
			NativeMethodInfoPtr_set_Visibility_Public_set_Void_ERemoteStoragePublishedFileVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, 100669759);
			NativeMethodInfoPtr_get_Tags_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, 100669760);
			NativeMethodInfoPtr_set_Tags_Public_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, 100669761);
			NativeMethodInfoPtr_get_KeyValues_Public_get_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, 100669762);
			NativeMethodInfoPtr_set_KeyValues_Public_set_Void_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, 100669763);
			NativeMethodInfoPtr_get_UpdateLanguage_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, 100669764);
			NativeMethodInfoPtr_set_UpdateLanguage_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, 100669765);
			NativeMethodInfoPtr_get_UpdateContentPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, 100669766);
			NativeMethodInfoPtr_set_UpdateContentPath_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, 100669767);
			NativeMethodInfoPtr_get_UpdatePreviewPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, 100669768);
			NativeMethodInfoPtr_set_UpdatePreviewPath_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, 100669769);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamWorkshopItem>.NativeClassPtr, 100669770);
		}

		public SteamWorkshopItem(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("WorkShopTest/<>c__DisplayClass12_0")]
	public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_item;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddWorkshopItem_b__0_Internal_Void_CreateItemResult_t_Boolean_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<__c__DisplayClass12_0>.NativeClassPtr));

		public unsafe SteamWorkshopItem item
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_item);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new SteamWorkshopItem(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe WorkShopTest __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new WorkShopTest(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(13)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		public unsafe __c__DisplayClass12_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass12_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106668, XrefRangeEnd = 106671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AddWorkshopItem_b__0(CreateItemResult_t param, bool ioFailure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&param);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ioFailure;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddWorkshopItem_b__0_Internal_Void_CreateItemResult_t_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass12_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkShopTest>.NativeClassPtr, "<>c__DisplayClass12_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass12_0>.NativeClassPtr);
			NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass12_0>.NativeClassPtr, "item");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass12_0>.NativeClassPtr, "<>4__this");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass12_0>.NativeClassPtr, 100669771);
			NativeMethodInfoPtr__AddWorkshopItem_b__0_Internal_Void_CreateItemResult_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass12_0>.NativeClassPtr, 100669772);
		}

		public __c__DisplayClass12_0(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_IsReady;

	private static readonly System.IntPtr NativeFieldInfoPtr_UploadComplete;

	private static readonly System.IntPtr NativeFieldInfoPtr_UploadError;

	private static readonly System.IntPtr NativeFieldInfoPtr_LastItemID;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CreateItemResult_t;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnSubmitItemUpdateResultCallResult;

	private static readonly System.IntPtr NativeFieldInfoPtr_subscribedItemList;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemsPaths;

	private static readonly System.IntPtr NativeFieldInfoPtr_uGCUpdateHandle_t;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateWorkshopItem_Public_SteamWorkshopItem_String_String_List_1_String_String_String_ERemoteStoragePublishedFileVisibility_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddWorkshopItem_Public_Void_SteamWorkshopItem_EWorkshopFileType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateItem_Public_Void_SteamWorkshopItem_byref_UGCUpdateHandle_t_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSubmitItemUpdateResult_Private_Void_SubmitItemUpdateResult_t_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_shouldSubscribeItem_Private_Void_PublishedFileId_t_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getNumSubscribedItems_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUploadProgress_Public_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getItemsInstallInfo_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WorkShopTest>.NativeClassPtr));

	public unsafe bool IsReady
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsReady);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsReady)) = flag;
		}
	}

	public unsafe bool UploadComplete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UploadComplete);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UploadComplete)) = flag;
		}
	}

	public unsafe bool UploadError
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UploadError);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UploadError)) = flag;
		}
	}

	public unsafe ulong LastItemID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastItemID);
			return *(ulong*)num;
		}
		set
		{
			*(ulong*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastItemID)) = num;
		}
	}

	public unsafe CallResult<CreateItemResult_t> m_CreateItemResult_t
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CreateItemResult_t);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CallResult<CreateItemResult_t>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CreateItemResult_t), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe CallResult<SubmitItemUpdateResult_t> OnSubmitItemUpdateResultCallResult
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnSubmitItemUpdateResultCallResult);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new CallResult<SubmitItemUpdateResult_t>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnSubmitItemUpdateResultCallResult), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
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

	public unsafe List<string> itemsPaths
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemsPaths);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemsPaths), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe UGCUpdateHandle_t uGCUpdateHandle_t
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uGCUpdateHandle_t);
			return System.Runtime.CompilerServices.Unsafe.Read<UGCUpdateHandle_t>((void*)num);
		}
		set
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			System.Runtime.CompilerServices.Unsafe.Write((void*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uGCUpdateHandle_t)), val);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106671, XrefRangeEnd = 106696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 106712, RefRangeEnd = 106713, XrefRangeStart = 106696, XrefRangeEnd = 106712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SteamWorkshopItem CreateWorkshopItem(string fileName, string description, List<string> tags, string contentPath, string previewPath, ERemoteStoragePublishedFileVisibility visiblity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(description);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(tags);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(contentPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(previewPath);
		*(ERemoteStoragePublishedFileVisibility**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &visiblity;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateWorkshopItem_Public_SteamWorkshopItem_String_String_List_1_String_String_String_ERemoteStoragePublishedFileVisibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new SteamWorkshopItem(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 106731, RefRangeEnd = 106732, XrefRangeStart = 106713, XrefRangeEnd = 106731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddWorkshopItem(SteamWorkshopItem item, EWorkshopFileType fileType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		*(EWorkshopFileType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddWorkshopItem_Public_Void_SteamWorkshopItem_EWorkshopFileType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 106851, RefRangeEnd = 106853, XrefRangeStart = 106732, XrefRangeEnd = 106851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateItem(SteamWorkshopItem item, out UGCUpdateHandle_t updateHandle, bool isCreatingNewItem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref updateHandle);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isCreatingNewItem;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateItem_Public_Void_SteamWorkshopItem_byref_UGCUpdateHandle_t_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106853, XrefRangeEnd = 106864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSubmitItemUpdateResult(SubmitItemUpdateResult_t pCallback, bool bIOFailure)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pCallback);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bIOFailure;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSubmitItemUpdateResult_Private_Void_SubmitItemUpdateResult_t_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106864, XrefRangeEnd = 106878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void shouldSubscribeItem(PublishedFileId_t id, bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_shouldSubscribeItem_Private_Void_PublishedFileId_t_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106878, XrefRangeEnd = 106888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getNumSubscribedItems()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getNumSubscribedItems_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106888, XrefRangeEnd = 106905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetUploadProgress()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUploadProgress_Public_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 106924, RefRangeEnd = 106925, XrefRangeStart = 106905, XrefRangeEnd = 106924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getItemsInstallInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getItemsInstallInfo_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe WorkShopTest()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkShopTest>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static WorkShopTest()
	{
		Il2CppClassPointerStore<WorkShopTest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "WorkShopTest");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkShopTest>.NativeClassPtr);
		NativeFieldInfoPtr_IsReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkShopTest>.NativeClassPtr, "IsReady");
		NativeFieldInfoPtr_UploadComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkShopTest>.NativeClassPtr, "UploadComplete");
		NativeFieldInfoPtr_UploadError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkShopTest>.NativeClassPtr, "UploadError");
		NativeFieldInfoPtr_LastItemID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkShopTest>.NativeClassPtr, "LastItemID");
		NativeFieldInfoPtr_m_CreateItemResult_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkShopTest>.NativeClassPtr, "m_CreateItemResult_t");
		NativeFieldInfoPtr_OnSubmitItemUpdateResultCallResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkShopTest>.NativeClassPtr, "OnSubmitItemUpdateResultCallResult");
		NativeFieldInfoPtr_subscribedItemList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkShopTest>.NativeClassPtr, "subscribedItemList");
		NativeFieldInfoPtr_itemsPaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkShopTest>.NativeClassPtr, "itemsPaths");
		NativeFieldInfoPtr_uGCUpdateHandle_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkShopTest>.NativeClassPtr, "uGCUpdateHandle_t");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkShopTest>.NativeClassPtr, 100669740);
		NativeMethodInfoPtr_CreateWorkshopItem_Public_SteamWorkshopItem_String_String_List_1_String_String_String_ERemoteStoragePublishedFileVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkShopTest>.NativeClassPtr, 100669741);
		NativeMethodInfoPtr_AddWorkshopItem_Public_Void_SteamWorkshopItem_EWorkshopFileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkShopTest>.NativeClassPtr, 100669742);
		NativeMethodInfoPtr_UpdateItem_Public_Void_SteamWorkshopItem_byref_UGCUpdateHandle_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkShopTest>.NativeClassPtr, 100669743);
		NativeMethodInfoPtr_OnSubmitItemUpdateResult_Private_Void_SubmitItemUpdateResult_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkShopTest>.NativeClassPtr, 100669744);
		NativeMethodInfoPtr_shouldSubscribeItem_Private_Void_PublishedFileId_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkShopTest>.NativeClassPtr, 100669745);
		NativeMethodInfoPtr_getNumSubscribedItems_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkShopTest>.NativeClassPtr, 100669746);
		NativeMethodInfoPtr_GetUploadProgress_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkShopTest>.NativeClassPtr, 100669747);
		NativeMethodInfoPtr_getItemsInstallInfo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkShopTest>.NativeClassPtr, 100669748);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkShopTest>.NativeClassPtr, 100669749);
	}

	public WorkShopTest(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
