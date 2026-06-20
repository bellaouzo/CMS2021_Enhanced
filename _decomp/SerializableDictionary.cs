using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.Serialization;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

public class SerializableDictionary<TKey, TValue> : SerializableDictionaryBase<TKey, TValue, TValue>
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Protected_Virtual_TValue_ArrayOf_TValue_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Protected_Virtual_Void_ArrayOf_TValue_Int32_TValue_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr));

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe SerializableDictionary()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15083, XrefRangeEnd = 15084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SerializableDictionary(IDictionary<TKey, TValue> dict)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(dict);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe SerializableDictionary(SerializationInfo info, StreamingContext context)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe TValue GetValue(Il2CppArrayBase<TValue> storage, int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(storage);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetValue_Protected_Virtual_TValue_ArrayOf_TValue_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.PointerToValueGeneric<TValue>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15084, XrefRangeEnd = 15086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void SetValue(Il2CppArrayBase<TValue> storage, int i, TValue value)
	{
		//IL_009b->IL00a0: Incompatible stack types: I vs Ref
		//IL_0077->IL00a0: Incompatible stack types: I vs Ref
		//IL_0084->IL00a0: Incompatible stack types: I vs Ref
		//IL_008e->IL00a0: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(storage);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TValue reference;
		if (!typeof(TValue).IsValueType)
		{
			object obj = value;
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
			reference = ref value;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SetValue_Protected_Virtual_Void_ArrayOf_TValue_Int32_TValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SerializableDictionary()
	{
		Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SerializableDictionary`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
		})).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr, 100664438);
		NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr, 100664439);
		NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr, 100664440);
		NativeMethodInfoPtr_GetValue_Protected_Virtual_TValue_ArrayOf_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr, 100664441);
		NativeMethodInfoPtr_SetValue_Protected_Virtual_Void_ArrayOf_TValue_Int32_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr, 100664442);
	}

	public SerializableDictionary(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
public static class SerializableDictionary : Il2CppSystem.Object
{
	public class Storage<T> : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_data;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Storage<T>>.NativeClassPtr));

		public unsafe T data
		{
			get
			{
				nint objectPointer = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data);
				return IL2CPP.PointerToValueGeneric<T>(objectPointer, isFieldPointer: true, valueTypeWouldBeBoxed: false);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				nint num2 = (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data);
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

		[CallerCount(0)]
		public unsafe Storage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Storage<T>>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static Storage()
		{
			Il2CppClassPointerStore<Storage<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializableDictionary>.NativeClassPtr, "Storage`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Storage<T>>.NativeClassPtr);
			NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Storage<T>>.NativeClassPtr, "data");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Storage<T>>.NativeClassPtr, 100664443);
		}

		public Storage(System.IntPtr P_0)
			: base(P_0)
		{
		}
	}

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SerializableDictionary>.NativeClassPtr));

	static SerializableDictionary()
	{
		Il2CppClassPointerStore<SerializableDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SerializableDictionary");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableDictionary>.NativeClassPtr);
	}

	public SerializableDictionary(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
public class SerializableDictionary<TKey, TValue, TValueStorage> : SerializableDictionaryBase<TKey, TValue, TValueStorage> where TValueStorage : SerializableDictionary.Storage<TValue>, new()
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Protected_Virtual_TValue_ArrayOf_TValueStorage_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Protected_Virtual_Void_ArrayOf_TValueStorage_Int32_TValue_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue, TValueStorage>>.NativeClassPtr));

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe SerializableDictionary()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue, TValueStorage>>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe SerializableDictionary(IDictionary<TKey, TValue> dict)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue, TValueStorage>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(dict);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe SerializableDictionary(SerializationInfo info, StreamingContext context)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue, TValueStorage>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public new unsafe TValue GetValue(Il2CppArrayBase<TValueStorage> storage, int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(storage);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetValue_Protected_Virtual_TValue_ArrayOf_TValueStorage_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.PointerToValueGeneric<TValue>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15086, XrefRangeEnd = 15087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void SetValue(Il2CppArrayBase<TValueStorage> storage, int i, TValue value)
	{
		//IL_009b->IL00a0: Incompatible stack types: I vs Ref
		//IL_0077->IL00a0: Incompatible stack types: I vs Ref
		//IL_0084->IL00a0: Incompatible stack types: I vs Ref
		//IL_008e->IL00a0: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(storage);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TValue reference;
		if (!typeof(TValue).IsValueType)
		{
			object obj = value;
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
			reference = ref value;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SetValue_Protected_Virtual_Void_ArrayOf_TValueStorage_Int32_TValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SerializableDictionary()
	{
		Il2CppClassPointerStore<SerializableDictionary<TKey, TValue, TValueStorage>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SerializableDictionary`3"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValueStorage>.NativeClassPtr))
		})).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue, TValueStorage>>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue, TValueStorage>>.NativeClassPtr, 100664444);
		NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue, TValueStorage>>.NativeClassPtr, 100664445);
		NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue, TValueStorage>>.NativeClassPtr, 100664446);
		NativeMethodInfoPtr_GetValue_Protected_Virtual_TValue_ArrayOf_TValueStorage_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue, TValueStorage>>.NativeClassPtr, 100664447);
		NativeMethodInfoPtr_SetValue_Protected_Virtual_Void_ArrayOf_TValueStorage_Int32_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue, TValueStorage>>.NativeClassPtr, 100664448);
	}

	public SerializableDictionary(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
