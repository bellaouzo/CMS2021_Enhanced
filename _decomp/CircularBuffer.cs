using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

public class CircularBuffer<T> : Il2CppSystem.Object
{
	[ObfuscatedName("CircularBuffer`1/<GetEnumerator>d__35")]
	public sealed class _GetEnumerator_d__35 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr__bufferIndex_5__2;

		private static readonly System.IntPtr NativeFieldInfoPtr__i_5__3;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_GetEnumerator_d__35>.NativeClassPtr));

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

		public unsafe T __2__current
		{
			get
			{
				nint objectPointer = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current);
				return IL2CPP.PointerToValueGeneric<T>(objectPointer, isFieldPointer: true, valueTypeWouldBeBoxed: false);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				nint num2 = (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current);
				System.Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(val as Il2CppObjectBase);
						if (intPtr != (System.IntPtr)0 && IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr)))
						{
							System.IntPtr obj = intPtr;
							// IL cpblk instruction
							System.Runtime.CompilerServices.Unsafe.CopyBlock(num2, IL2CPP.il2cpp_object_unbox(intPtr), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(obj), ref *(uint*)null));
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(num, num2, intPtr);
						}
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(num, num2, IL2CPP.ManagedStringToIl2Cpp(val as string));
					}
				}
				else
				{
					System.Runtime.CompilerServices.Unsafe.Write((void*)num2, val);
				}
			}
		}

		public unsafe CircularBuffer<T> __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? new CircularBuffer<T>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe int _bufferIndex_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__bufferIndex_5__2);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__bufferIndex_5__2)) = num;
			}
		}

		public unsafe int _i_5__3
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__i_5__3);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__i_5__3)) = num;
			}
		}

		public unsafe T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return IL2CPP.PointerToValueGeneric<T>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
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
		public unsafe _GetEnumerator_d__35(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_GetEnumerator_d__35>.NativeClassPtr))
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107140, XrefRangeEnd = 107141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107141, XrefRangeEnd = 107146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static _GetEnumerator_d__35()
		{
			Il2CppClassPointerStore<_GetEnumerator_d__35>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, "<GetEnumerator>d__35"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_GetEnumerator_d__35>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetEnumerator_d__35>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetEnumerator_d__35>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetEnumerator_d__35>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr__bufferIndex_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetEnumerator_d__35>.NativeClassPtr, "<bufferIndex>5__2");
			NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GetEnumerator_d__35>.NativeClassPtr, "<i>5__3");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetEnumerator_d__35>.NativeClassPtr, 100669842);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetEnumerator_d__35>.NativeClassPtr, 100669843);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetEnumerator_d__35>.NativeClassPtr, 100669844);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetEnumerator_d__35>.NativeClassPtr, 100669845);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetEnumerator_d__35>.NativeClassPtr, 100669846);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GetEnumerator_d__35>.NativeClassPtr, 100669847);
		}

		public _GetEnumerator_d__35(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_capacity;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_size;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_head;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_tail;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_buffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_syncRoot;

	private static readonly System.IntPtr NativeFieldInfoPtr__allowOverflow_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_allowOverflow_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_allowOverflow_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_capacity_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_capacity_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_size_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Put_Public_Int32_ArrayOf_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Put_Public_Int32_ArrayOf_T_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Put_Public_Void_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Skip_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_ArrayOf_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Int32_ArrayOf_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Int32_ArrayOf_T_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Peek_Public_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Head_Public_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Tail_Public_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_ArrayOf_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_ArrayOf_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Int32_ArrayOf_T_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBuffer_Public_ArrayOf_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToArray_Public_ArrayOf_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_Count_Private_Virtual_Final_New_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Add_Private_Virtual_Final_New_Void_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Remove_Private_Virtual_Final_New_Boolean_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_headIdx_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_tailIdx_Public_get_Int32_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr));

	public unsafe int m_capacity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_capacity);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_capacity)) = num;
		}
	}

	public unsafe int m_size
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_size);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_size)) = num;
		}
	}

	public unsafe int m_head
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_head);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_head)) = num;
		}
	}

	public unsafe int m_tail
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_tail);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_tail)) = num;
		}
	}

	public Il2CppArrayBase<T> m_buffer
	{
		get
		{
			nint pointer = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_buffer);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(pointer);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_buffer), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Object syncRoot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncRoot);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncRoot), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool _allowOverflow_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allowOverflow_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allowOverflow_k__BackingField)) = flag;
		}
	}

	public unsafe bool allowOverflow
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_allowOverflow_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_allowOverflow_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe int capacity
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107156, RefRangeEnd = 107157, XrefRangeStart = 107156, XrefRangeEnd = 107156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_capacity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107157, XrefRangeEnd = 107160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_capacity_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe int size
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_size_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe int System_002ECollections_002EGeneric_002EICollection_003CT_003E_002ECount
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107173, XrefRangeEnd = 107174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_Count_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe bool System_002ECollections_002EGeneric_002EICollection_003CT_003E_002EIsReadOnly
	{
		[CallerCount(1)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe int System_002ECollections_002EICollection_002ECount
	{
		[CallerCount(0)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe bool System_002ECollections_002EICollection_002EIsSynchronized
	{
		[CallerCount(1)]
		[CachedScanResults(/*Could not decode attribute arguments.*/)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe Il2CppSystem.Object System_002ECollections_002EICollection_002ESyncRoot
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107176, XrefRangeEnd = 107179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
		}
	}

	public unsafe int headIdx
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_headIdx_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe int tailIdx
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_tailIdx_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107146, XrefRangeEnd = 107147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CircularBuffer(int m_capacity)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&m_capacity);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107147, XrefRangeEnd = 107156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CircularBuffer(int capacity, bool allowOverflow)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&capacity);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowOverflow;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe int IndexOf(T item)
	{
		//IL_0070->IL0075: Incompatible stack types: I vs Ref
		//IL_004c->IL0075: Incompatible stack types: I vs Ref
		//IL_0059->IL0075: Incompatible stack types: I vs Ref
		//IL_0063->IL0075: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = item;
			if (obj is string)
			{
				reference = ref *(_003F*)IL2CPP.ManagedStringToIl2Cpp(obj as string);
			}
			else
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(obj as Il2CppObjectBase);
				reference = ref *(_003F*)intPtr;
				if (intPtr != (System.IntPtr)0)
				{
					reference = ref *(_003F*)intPtr;
					if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr)))
					{
						reference = ref *(_003F*)IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}
			}
		}
		else
		{
			reference = ref item;
		}
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOf_Public_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107160, XrefRangeEnd = 107161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveAt(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool Contains(T item)
	{
		//IL_0070->IL0075: Incompatible stack types: I vs Ref
		//IL_004c->IL0075: Incompatible stack types: I vs Ref
		//IL_0059->IL0075: Incompatible stack types: I vs Ref
		//IL_0063->IL0075: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = item;
			if (obj is string)
			{
				reference = ref *(_003F*)IL2CPP.ManagedStringToIl2Cpp(obj as string);
			}
			else
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(obj as Il2CppObjectBase);
				reference = ref *(_003F*)intPtr;
				if (intPtr != (System.IntPtr)0)
				{
					reference = ref *(_003F*)intPtr;
					if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr)))
					{
						reference = ref *(_003F*)IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}
			}
		}
		else
		{
			reference = ref item;
		}
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj2);
	}

	[CallerCount(0)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe int Put(Il2CppArrayBase<T> src)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Put_Public_Int32_ArrayOf_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107161, XrefRangeEnd = 107163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Put(Il2CppArrayBase<T> src, int srcOffset, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcOffset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Put_Public_Int32_ArrayOf_T_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107163, XrefRangeEnd = 107164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Put(T item)
	{
		//IL_0070->IL0075: Incompatible stack types: I vs Ref
		//IL_004c->IL0075: Incompatible stack types: I vs Ref
		//IL_0059->IL0075: Incompatible stack types: I vs Ref
		//IL_0063->IL0075: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = item;
			if (obj is string)
			{
				reference = ref *(_003F*)IL2CPP.ManagedStringToIl2Cpp(obj as string);
			}
			else
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(obj as Il2CppObjectBase);
				reference = ref *(_003F*)intPtr;
				if (intPtr != (System.IntPtr)0)
				{
					reference = ref *(_003F*)intPtr;
					if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr)))
					{
						reference = ref *(_003F*)IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}
			}
		}
		else
		{
			reference = ref item;
		}
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Put_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void Skip(int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&count);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Skip_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107164, XrefRangeEnd = 107166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppArrayBase<T> Get(int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&count);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_ArrayOf_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(pointer);
	}

	[CallerCount(0)]
	public unsafe int Get(Il2CppArrayBase<T> dst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(dst);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Int32_ArrayOf_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107166, XrefRangeEnd = 107167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Get(Il2CppArrayBase<T> dst, int dstOffset, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(dst);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dstOffset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Int32_ArrayOf_T_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe T Get()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.PointerToValueGeneric<T>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
	}

	[CallerCount(0)]
	public unsafe T Peek(int offset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&offset);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Peek_Public_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.PointerToValueGeneric<T>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
	}

	[CallerCount(0)]
	public unsafe T Head()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Head_Public_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.PointerToValueGeneric<T>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
	}

	[CallerCount(0)]
	public unsafe T Tail()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Tail_Public_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.PointerToValueGeneric<T>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107167, XrefRangeEnd = 107168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyTo(Il2CppArrayBase<T> array)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyTo_Public_Void_ArrayOf_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void CopyTo(Il2CppArrayBase<T> array, int arrayIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &arrayIndex;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_ArrayOf_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107168, XrefRangeEnd = 107169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyTo(int index, Il2CppArrayBase<T> array, int arrayIndex, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&index);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(array);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &arrayIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyTo_Public_Void_Int32_ArrayOf_T_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107169, XrefRangeEnd = 107171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator<T> GetEnumerator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator<T>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe Il2CppArrayBase<T> GetBuffer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBuffer_Public_ArrayOf_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107171, XrefRangeEnd = 107173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppArrayBase<T> ToArray()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToArray_Public_ArrayOf_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107174, XrefRangeEnd = 107175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void System_Collections_Generic_ICollection_T__Add(T item)
	{
		//IL_0070->IL0075: Incompatible stack types: I vs Ref
		//IL_004c->IL0075: Incompatible stack types: I vs Ref
		//IL_0059->IL0075: Incompatible stack types: I vs Ref
		//IL_0063->IL0075: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = item;
			if (obj is string)
			{
				reference = ref *(_003F*)IL2CPP.ManagedStringToIl2Cpp(obj as string);
			}
			else
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(obj as Il2CppObjectBase);
				reference = ref *(_003F*)intPtr;
				if (intPtr != (System.IntPtr)0)
				{
					reference = ref *(_003F*)intPtr;
					if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr)))
					{
						reference = ref *(_003F*)IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}
			}
		}
		else
		{
			reference = ref item;
		}
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Add_Private_Virtual_Final_New_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool System_Collections_Generic_ICollection_T__Remove(T item)
	{
		//IL_0070->IL0075: Incompatible stack types: I vs Ref
		//IL_004c->IL0075: Incompatible stack types: I vs Ref
		//IL_0059->IL0075: Incompatible stack types: I vs Ref
		//IL_0063->IL0075: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = item;
			if (obj is string)
			{
				reference = ref *(_003F*)IL2CPP.ManagedStringToIl2Cpp(obj as string);
			}
			else
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(obj as Il2CppObjectBase);
				reference = ref *(_003F*)intPtr;
				if (intPtr != (System.IntPtr)0)
				{
					reference = ref *(_003F*)intPtr;
					if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr)))
					{
						reference = ref *(_003F*)IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}
			}
		}
		else
		{
			reference = ref item;
		}
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Remove_Private_Virtual_Final_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107175, XrefRangeEnd = 107176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator<T>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107179, XrefRangeEnd = 107184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void System_Collections_ICollection_CopyTo(Il2CppSystem.Array array, int arrayIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &arrayIndex;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new IEnumerator(intPtr) : null;
	}

	static CircularBuffer()
	{
		Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CircularBuffer`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr);
		NativeFieldInfoPtr_m_capacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, "m_capacity");
		NativeFieldInfoPtr_m_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, "m_size");
		NativeFieldInfoPtr_m_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, "m_head");
		NativeFieldInfoPtr_m_tail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, "m_tail");
		NativeFieldInfoPtr_m_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, "m_buffer");
		NativeFieldInfoPtr_syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, "syncRoot");
		NativeFieldInfoPtr__allowOverflow_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, "<allowOverflow>k__BackingField");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669802);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669803);
		NativeMethodInfoPtr_get_allowOverflow_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669804);
		NativeMethodInfoPtr_set_allowOverflow_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669805);
		NativeMethodInfoPtr_get_capacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669806);
		NativeMethodInfoPtr_set_capacity_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669807);
		NativeMethodInfoPtr_get_size_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669808);
		NativeMethodInfoPtr_IndexOf_Public_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669809);
		NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669810);
		NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669811);
		NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669812);
		NativeMethodInfoPtr_Put_Public_Int32_ArrayOf_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669813);
		NativeMethodInfoPtr_Put_Public_Int32_ArrayOf_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669814);
		NativeMethodInfoPtr_Put_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669815);
		NativeMethodInfoPtr_Skip_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669816);
		NativeMethodInfoPtr_Get_Public_ArrayOf_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669817);
		NativeMethodInfoPtr_Get_Public_Int32_ArrayOf_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669818);
		NativeMethodInfoPtr_Get_Public_Int32_ArrayOf_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669819);
		NativeMethodInfoPtr_Get_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669820);
		NativeMethodInfoPtr_Peek_Public_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669821);
		NativeMethodInfoPtr_Head_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669822);
		NativeMethodInfoPtr_Tail_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669823);
		NativeMethodInfoPtr_CopyTo_Public_Void_ArrayOf_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669824);
		NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_ArrayOf_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669825);
		NativeMethodInfoPtr_CopyTo_Public_Void_Int32_ArrayOf_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669826);
		NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669827);
		NativeMethodInfoPtr_GetBuffer_Public_ArrayOf_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669828);
		NativeMethodInfoPtr_ToArray_Public_ArrayOf_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669829);
		NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_Count_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669830);
		NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669831);
		NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Add_Private_Virtual_Final_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669832);
		NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Remove_Private_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669833);
		NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669834);
		NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669835);
		NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669836);
		NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669837);
		NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669838);
		NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669839);
		NativeMethodInfoPtr_get_headIdx_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669840);
		NativeMethodInfoPtr_get_tailIdx_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularBuffer<T>>.NativeClassPtr, 100669841);
	}

	public CircularBuffer(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
