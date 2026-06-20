using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.Networking;

namespace CMS.Managers;

public class RustmapManager : Il2CppSystem.Object
{
	[ObfuscatedName("CMS.Managers.RustmapManager/<LoadPngRustmap>d__15")]
	public sealed class _LoadPngRustmap_d__15 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_carID;

		private static readonly System.IntPtr NativeFieldInfoPtr_carDirectory;

		private static readonly System.IntPtr NativeFieldInfoPtr_textureName;

		private static readonly System.IntPtr NativeFieldInfoPtr__path_5__2;

		private static readonly System.IntPtr NativeFieldInfoPtr__uwr_5__3;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_LoadPngRustmap_d__15>.NativeClassPtr));

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

		public unsafe RustmapManager __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new RustmapManager(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe string carID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carID);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carID), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe string carDirectory
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carDirectory);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carDirectory), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe string textureName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureName), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe string _path_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__path_5__2);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__path_5__2), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe UnityWebRequest _uwr_5__3
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__uwr_5__3);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new UnityWebRequest(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__uwr_5__3), IL2CPP.Il2CppObjectBaseToPtr(obj));
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
		public unsafe _LoadPngRustmap_d__15(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_LoadPngRustmap_d__15>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&_003C_003E1__state);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142066, RefRangeEnd = 142067, XrefRangeStart = 142063, XrefRangeEnd = 142066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142067, XrefRangeEnd = 142121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142121, XrefRangeEnd = 142124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __m__Finally1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142124, XrefRangeEnd = 142129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _LoadPngRustmap_d__15()
		{
			Il2CppClassPointerStore<_LoadPngRustmap_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RustmapManager>.NativeClassPtr, "<LoadPngRustmap>d__15");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_LoadPngRustmap_d__15>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadPngRustmap_d__15>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadPngRustmap_d__15>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadPngRustmap_d__15>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_carID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadPngRustmap_d__15>.NativeClassPtr, "carID");
			NativeFieldInfoPtr_carDirectory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadPngRustmap_d__15>.NativeClassPtr, "carDirectory");
			NativeFieldInfoPtr_textureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadPngRustmap_d__15>.NativeClassPtr, "textureName");
			NativeFieldInfoPtr__path_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadPngRustmap_d__15>.NativeClassPtr, "<path>5__2");
			NativeFieldInfoPtr__uwr_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadPngRustmap_d__15>.NativeClassPtr, "<uwr>5__3");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_LoadPngRustmap_d__15>.NativeClassPtr, 100672937);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_LoadPngRustmap_d__15>.NativeClassPtr, 100672938);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_LoadPngRustmap_d__15>.NativeClassPtr, 100672939);
			NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_LoadPngRustmap_d__15>.NativeClassPtr, 100672940);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_LoadPngRustmap_d__15>.NativeClassPtr, 100672941);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_LoadPngRustmap_d__15>.NativeClassPtr, 100672942);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_LoadPngRustmap_d__15>.NativeClassPtr, 100672943);
		}

		public _LoadPngRustmap_d__15(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[ObfuscatedName("CMS.Managers.RustmapManager/<LoadPngTuningRustmap>d__16")]
	public sealed class _LoadPngTuningRustmap_d__16 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_carID;

		private static readonly System.IntPtr NativeFieldInfoPtr_carDirectory;

		private static readonly System.IntPtr NativeFieldInfoPtr_textureName;

		private static readonly System.IntPtr NativeFieldInfoPtr__path_5__2;

		private static readonly System.IntPtr NativeFieldInfoPtr__uwr_5__3;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_LoadPngTuningRustmap_d__16>.NativeClassPtr));

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

		public unsafe RustmapManager __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new RustmapManager(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe string carID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carID);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carID), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe string carDirectory
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carDirectory);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carDirectory), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe string textureName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureName), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe string _path_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__path_5__2);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__path_5__2), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		public unsafe UnityWebRequest _uwr_5__3
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__uwr_5__3);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new UnityWebRequest(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__uwr_5__3), IL2CPP.Il2CppObjectBaseToPtr(obj));
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
		public unsafe _LoadPngTuningRustmap_d__16(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_LoadPngTuningRustmap_d__16>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&_003C_003E1__state);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142132, RefRangeEnd = 142133, XrefRangeStart = 142129, XrefRangeEnd = 142132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142133, XrefRangeEnd = 142192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142192, XrefRangeEnd = 142195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __m__Finally1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142195, XrefRangeEnd = 142200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _LoadPngTuningRustmap_d__16()
		{
			Il2CppClassPointerStore<_LoadPngTuningRustmap_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RustmapManager>.NativeClassPtr, "<LoadPngTuningRustmap>d__16");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_LoadPngTuningRustmap_d__16>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadPngTuningRustmap_d__16>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadPngTuningRustmap_d__16>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadPngTuningRustmap_d__16>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_carID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadPngTuningRustmap_d__16>.NativeClassPtr, "carID");
			NativeFieldInfoPtr_carDirectory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadPngTuningRustmap_d__16>.NativeClassPtr, "carDirectory");
			NativeFieldInfoPtr_textureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadPngTuningRustmap_d__16>.NativeClassPtr, "textureName");
			NativeFieldInfoPtr__path_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadPngTuningRustmap_d__16>.NativeClassPtr, "<path>5__2");
			NativeFieldInfoPtr__uwr_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadPngTuningRustmap_d__16>.NativeClassPtr, "<uwr>5__3");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_LoadPngTuningRustmap_d__16>.NativeClassPtr, 100672944);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_LoadPngTuningRustmap_d__16>.NativeClassPtr, 100672945);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_LoadPngTuningRustmap_d__16>.NativeClassPtr, 100672946);
			NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_LoadPngTuningRustmap_d__16>.NativeClassPtr, 100672947);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_LoadPngTuningRustmap_d__16>.NativeClassPtr, 100672948);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_LoadPngTuningRustmap_d__16>.NativeClassPtr, 100672949);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_LoadPngTuningRustmap_d__16>.NativeClassPtr, 100672950);
		}

		public _LoadPngTuningRustmap_d__16(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_rustmaps;

	private static readonly System.IntPtr NativeFieldInfoPtr_rustmapsTuning;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxRustmapsInMemory;

	private static readonly System.IntPtr NativeFieldInfoPtr_RawRustmapSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_buffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_rustmapsToRemove;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRustmap_Public_Boolean_String_byref_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsRustmapLoaded_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTuningRustmap_Public_Boolean_String_byref_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsTuningRustmapLoaded_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnloadUnusedRustmaps_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveRustmapForCar_Public_Void_byref_List_1_CarLoader_String_Guid_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveTuningRustmapForCar_Public_Void_byref_List_1_CarLoader_String_Guid_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadPngRustmap_Public_IEnumerator_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadPngTuningRustmap_Public_IEnumerator_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadRawRustmap_Public_Texture2D_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadRawTuningRustmap_Public_Texture2D_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanRemoveRustmap_Private_Boolean_byref_List_1_CarLoader_String_Guid_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLoadedRustmapsCount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLoadedTuningRustmapsCount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRustmapsMemoryUsage_Public_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTuningRustmapsMemoryUsage_Public_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<RustmapManager>.NativeClassPtr));

	public unsafe Dictionary<string, Texture2D> rustmaps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rustmaps);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Dictionary<string, Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rustmaps), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<string, Texture2D> rustmapsTuning
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rustmapsTuning);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Dictionary<string, Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rustmapsTuning), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static int MaxRustmapsInMemory
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxRustmapsInMemory, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxRustmapsInMemory, &num);
		}
	}

	public unsafe static int RawRustmapSize
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RawRustmapSize, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RawRustmapSize, &num);
		}
	}

	public unsafe Il2CppStructArray<byte> buffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppStructArray<byte>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<string> rustmapsToRemove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rustmapsToRemove);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new List<string>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rustmapsToRemove), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 142219, RefRangeEnd = 142221, XrefRangeStart = 142200, XrefRangeEnd = 142219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142221, XrefRangeEnd = 142243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Finalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 142246, RefRangeEnd = 142249, XrefRangeStart = 142243, XrefRangeEnd = 142246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetRustmap(string carID, out Texture2D rustmap)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(rustmap);
		*(System.IntPtr**)num = &intPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRustmap_Public_Boolean_String_byref_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr2 = intPtr;
		rustmap = ((intPtr2 == (System.IntPtr)0) ? null : new Texture2D(intPtr2));
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142249, XrefRangeEnd = 142251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsRustmapLoaded(string carID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRustmapLoaded_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 142254, RefRangeEnd = 142257, XrefRangeStart = 142251, XrefRangeEnd = 142254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetTuningRustmap(string carID, out Texture2D rustmap)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(rustmap);
		*(System.IntPtr**)num = &intPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTuningRustmap_Public_Boolean_String_byref_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr2 = intPtr;
		rustmap = ((intPtr2 == (System.IntPtr)0) ? null : new Texture2D(intPtr2));
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142257, XrefRangeEnd = 142259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsTuningRustmapLoaded(string carID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsTuningRustmapLoaded_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 142302, RefRangeEnd = 142306, XrefRangeStart = 142259, XrefRangeEnd = 142302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnloadUnusedRustmaps()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnloadUnusedRustmaps_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142306, XrefRangeEnd = 142326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveRustmapForCar(ref List<CarLoader> cars, string carID, Il2CppSystem.Guid guid)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(cars);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(Il2CppSystem.Guid**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &guid;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveRustmapForCar_Public_Void_byref_List_1_CarLoader_String_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		cars = (List<CarLoader>)(object)((intPtr3 == (System.IntPtr)0) ? null : new List<T>(intPtr3));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142326, XrefRangeEnd = 142346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveTuningRustmapForCar(ref List<CarLoader> cars, string carID, Il2CppSystem.Guid guid)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(cars);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(Il2CppSystem.Guid**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &guid;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveTuningRustmapForCar_Public_Void_byref_List_1_CarLoader_String_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr3 = intPtr;
		cars = (List<CarLoader>)(object)((intPtr3 == (System.IntPtr)0) ? null : new List<T>(intPtr3));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142346, XrefRangeEnd = 142349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator LoadPngRustmap(string carID, string textureName, string carDirectory)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(textureName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(carDirectory);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadPngRustmap_Public_IEnumerator_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142349, XrefRangeEnd = 142352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator LoadPngTuningRustmap(string carID, string textureName, string carDirectory)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(textureName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(carDirectory);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadPngTuningRustmap_Public_IEnumerator_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 142387, RefRangeEnd = 142388, XrefRangeStart = 142352, XrefRangeEnd = 142387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture2D LoadRawRustmap(string carID, string textureName, string carDirectory)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(textureName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(carDirectory);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadRawRustmap_Public_Texture2D_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Texture2D(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 142430, RefRangeEnd = 142431, XrefRangeStart = 142388, XrefRangeEnd = 142430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture2D LoadRawTuningRustmap(string carID, string textureName, string carDirectory)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(textureName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(carDirectory);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadRawTuningRustmap_Public_Texture2D_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Texture2D(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 142439, RefRangeEnd = 142443, XrefRangeStart = 142431, XrefRangeEnd = 142439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanRemoveRustmap(ref List<CarLoader> cars, string carID, Il2CppSystem.Guid guid)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(cars);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(carID);
		*(Il2CppSystem.Guid**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &guid;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanRemoveRustmap_Private_Boolean_byref_List_1_CarLoader_String_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		System.IntPtr intPtr2 = intPtr;
		cars = (List<CarLoader>)(object)((intPtr2 == (System.IntPtr)0) ? null : new List<T>(intPtr2));
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142443, XrefRangeEnd = 142444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetLoadedRustmapsCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLoadedRustmapsCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142444, XrefRangeEnd = 142445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetLoadedTuningRustmapsCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLoadedTuningRustmapsCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 142468, RefRangeEnd = 142469, XrefRangeStart = 142445, XrefRangeEnd = 142468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe long GetRustmapsMemoryUsage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRustmapsMemoryUsage_Public_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(long*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 142492, RefRangeEnd = 142493, XrefRangeStart = 142469, XrefRangeEnd = 142492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe long GetTuningRustmapsMemoryUsage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTuningRustmapsMemoryUsage_Public_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(long*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(13)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe RustmapManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RustmapManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static RustmapManager()
	{
		Il2CppClassPointerStore<RustmapManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "CMS.Managers", "RustmapManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RustmapManager>.NativeClassPtr);
		NativeFieldInfoPtr_rustmaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RustmapManager>.NativeClassPtr, "rustmaps");
		NativeFieldInfoPtr_rustmapsTuning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RustmapManager>.NativeClassPtr, "rustmapsTuning");
		NativeFieldInfoPtr_MaxRustmapsInMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RustmapManager>.NativeClassPtr, "MaxRustmapsInMemory");
		NativeFieldInfoPtr_RawRustmapSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RustmapManager>.NativeClassPtr, "RawRustmapSize");
		NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RustmapManager>.NativeClassPtr, "buffer");
		NativeFieldInfoPtr_rustmapsToRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RustmapManager>.NativeClassPtr, "rustmapsToRemove");
		NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RustmapManager>.NativeClassPtr, 100672918);
		NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RustmapManager>.NativeClassPtr, 100672919);
		NativeMethodInfoPtr_GetRustmap_Public_Boolean_String_byref_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RustmapManager>.NativeClassPtr, 100672920);
		NativeMethodInfoPtr_IsRustmapLoaded_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RustmapManager>.NativeClassPtr, 100672921);
		NativeMethodInfoPtr_GetTuningRustmap_Public_Boolean_String_byref_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RustmapManager>.NativeClassPtr, 100672922);
		NativeMethodInfoPtr_IsTuningRustmapLoaded_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RustmapManager>.NativeClassPtr, 100672923);
		NativeMethodInfoPtr_UnloadUnusedRustmaps_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RustmapManager>.NativeClassPtr, 100672924);
		NativeMethodInfoPtr_RemoveRustmapForCar_Public_Void_byref_List_1_CarLoader_String_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RustmapManager>.NativeClassPtr, 100672925);
		NativeMethodInfoPtr_RemoveTuningRustmapForCar_Public_Void_byref_List_1_CarLoader_String_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RustmapManager>.NativeClassPtr, 100672926);
		NativeMethodInfoPtr_LoadPngRustmap_Public_IEnumerator_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RustmapManager>.NativeClassPtr, 100672927);
		NativeMethodInfoPtr_LoadPngTuningRustmap_Public_IEnumerator_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RustmapManager>.NativeClassPtr, 100672928);
		NativeMethodInfoPtr_LoadRawRustmap_Public_Texture2D_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RustmapManager>.NativeClassPtr, 100672929);
		NativeMethodInfoPtr_LoadRawTuningRustmap_Public_Texture2D_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RustmapManager>.NativeClassPtr, 100672930);
		NativeMethodInfoPtr_CanRemoveRustmap_Private_Boolean_byref_List_1_CarLoader_String_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RustmapManager>.NativeClassPtr, 100672931);
		NativeMethodInfoPtr_GetLoadedRustmapsCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RustmapManager>.NativeClassPtr, 100672932);
		NativeMethodInfoPtr_GetLoadedTuningRustmapsCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RustmapManager>.NativeClassPtr, 100672933);
		NativeMethodInfoPtr_GetRustmapsMemoryUsage_Public_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RustmapManager>.NativeClassPtr, 100672934);
		NativeMethodInfoPtr_GetTuningRustmapsMemoryUsage_Public_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RustmapManager>.NativeClassPtr, 100672935);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RustmapManager>.NativeClassPtr, 100672936);
	}

	public RustmapManager(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
