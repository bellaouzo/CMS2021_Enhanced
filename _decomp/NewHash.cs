using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[System.Serializable]
public class NewHash : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_hashTable;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ArrayOf_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashTable_Public_Hashtable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHashTable_Public_Void_Hashtable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_NewHash_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContainsKey_Public_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeKeyValue_Public_Void_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFromKey_Public_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DebugContent_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<NewHash>.NativeClassPtr));

	public unsafe Hashtable hashTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hashTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? new Hashtable(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hashTable), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64792, XrefRangeEnd = 64796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NewHash()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewHash>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(25)]
	[CachedScanResults(RefRangeStart = 64807, RefRangeEnd = 64832, XrefRangeStart = 64796, XrefRangeEnd = 64807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NewHash(Il2CppReferenceArray<Il2CppSystem.Object> args)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewHash>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ArrayOf_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe Hashtable GetHashTable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashTable_Public_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Hashtable(intPtr) : null;
	}

	[CallerCount(77)]
	[CachedScanResults(/*Could not decode attribute arguments.*/)]
	public unsafe void SetHashTable(Hashtable newHashTable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(newHashTable);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHashTable_Public_Void_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void Add(Il2CppSystem.Object key, Il2CppSystem.Object keyValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(keyValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64832, XrefRangeEnd = 64849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Add(NewHash hash)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(hash);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Void_NewHash_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool ContainsKey(Il2CppSystem.Object key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContainsKey_Public_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe void ChangeKeyValue(string key, Il2CppSystem.Object value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeKeyValue_Public_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(46)]
	[CachedScanResults(RefRangeStart = 64849, RefRangeEnd = 64895, XrefRangeStart = 64849, XrefRangeEnd = 64849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object GetFromKey(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFromKey_Public_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? new Il2CppSystem.Object(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64895, XrefRangeEnd = 64918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DebugContent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DebugContent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static NewHash()
	{
		Il2CppClassPointerStore<NewHash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "NewHash");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewHash>.NativeClassPtr);
		NativeFieldInfoPtr_hashTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewHash>.NativeClassPtr, "hashTable");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewHash>.NativeClassPtr, 100667221);
		NativeMethodInfoPtr__ctor_Public_Void_ArrayOf_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewHash>.NativeClassPtr, 100667222);
		NativeMethodInfoPtr_GetHashTable_Public_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewHash>.NativeClassPtr, 100667223);
		NativeMethodInfoPtr_SetHashTable_Public_Void_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewHash>.NativeClassPtr, 100667224);
		NativeMethodInfoPtr_Add_Public_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewHash>.NativeClassPtr, 100667225);
		NativeMethodInfoPtr_Add_Public_Void_NewHash_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewHash>.NativeClassPtr, 100667226);
		NativeMethodInfoPtr_ContainsKey_Public_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewHash>.NativeClassPtr, 100667227);
		NativeMethodInfoPtr_ChangeKeyValue_Public_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewHash>.NativeClassPtr, 100667228);
		NativeMethodInfoPtr_GetFromKey_Public_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewHash>.NativeClassPtr, 100667229);
		NativeMethodInfoPtr_DebugContent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewHash>.NativeClassPtr, 100667230);
	}

	public NewHash(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
