using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.Serialization;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

public class SerializableDictionaryBase<TKey, TValue, TValueStorage> : Dictionary<TKey, TValue>
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_keys;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_values;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Protected_Abstract_Virtual_New_Void_ArrayOf_TValueStorage_Int32_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Protected_Abstract_Virtual_New_TValue_ArrayOf_TValueStorage_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_IDictionary_2_TKey_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SerializableDictionaryBase<TKey, TValue, TValueStorage>>.NativeClassPtr));

	public Il2CppArrayBase<TKey> m_keys
	{
		get
		{
			nint pointer = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_keys);
			return Il2CppArrayBase<TKey>.WrapNativeGenericArrayPointer(pointer);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_keys), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public Il2CppArrayBase<TValueStorage> m_values
	{
		get
		{
			nint pointer = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_values);
			return Il2CppArrayBase<TValueStorage>.WrapNativeGenericArrayPointer(pointer);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_values), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14957, XrefRangeEnd = 15032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SerializableDictionaryBase()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableDictionaryBase<TKey, TValue, TValueStorage>>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15032, XrefRangeEnd = 15047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SerializableDictionaryBase(IDictionary<TKey, TValue> dict)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableDictionaryBase<TKey, TValue, TValueStorage>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(dict);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe SerializableDictionaryBase(SerializationInfo info, StreamingContext context)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableDictionaryBase<TKey, TValue, TValueStorage>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetValue(Il2CppArrayBase<TValueStorage> storage, int i, TValue value)
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
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SetValue_Protected_Abstract_Virtual_New_Void_ArrayOf_TValueStorage_Int32_TValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe TValue GetValue(Il2CppArrayBase<TValueStorage> storage, int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(storage);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetValue_Protected_Abstract_Virtual_New_TValue_ArrayOf_TValueStorage_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.PointerToValueGeneric<TValue>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 15060, RefRangeEnd = 15070, XrefRangeStart = 15047, XrefRangeEnd = 15060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyFrom(IDictionary<TKey, TValue> dict)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(dict);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyFrom_Public_Void_IDictionary_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void OnAfterDeserialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15070, XrefRangeEnd = 15083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBeforeSerialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SerializableDictionaryBase()
	{
		Il2CppClassPointerStore<SerializableDictionaryBase<TKey, TValue, TValueStorage>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SerializableDictionaryBase`3"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValueStorage>.NativeClassPtr))
		})).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableDictionaryBase<TKey, TValue, TValueStorage>>.NativeClassPtr);
		NativeFieldInfoPtr_m_keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableDictionaryBase<TKey, TValue, TValueStorage>>.NativeClassPtr, "m_keys");
		NativeFieldInfoPtr_m_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableDictionaryBase<TKey, TValue, TValueStorage>>.NativeClassPtr, "m_values");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionaryBase<TKey, TValue, TValueStorage>>.NativeClassPtr, 100664430);
		NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionaryBase<TKey, TValue, TValueStorage>>.NativeClassPtr, 100664431);
		NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionaryBase<TKey, TValue, TValueStorage>>.NativeClassPtr, 100664432);
		NativeMethodInfoPtr_SetValue_Protected_Abstract_Virtual_New_Void_ArrayOf_TValueStorage_Int32_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionaryBase<TKey, TValue, TValueStorage>>.NativeClassPtr, 100664433);
		NativeMethodInfoPtr_GetValue_Protected_Abstract_Virtual_New_TValue_ArrayOf_TValueStorage_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionaryBase<TKey, TValue, TValueStorage>>.NativeClassPtr, 100664434);
		NativeMethodInfoPtr_CopyFrom_Public_Void_IDictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionaryBase<TKey, TValue, TValueStorage>>.NativeClassPtr, 100664435);
		NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionaryBase<TKey, TValue, TValueStorage>>.NativeClassPtr, 100664436);
		NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionaryBase<TKey, TValue, TValueStorage>>.NativeClassPtr, 100664437);
	}

	public SerializableDictionaryBase(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
