using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;
using Il2CppSystem.IO;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

[System.Serializable]
public class NewGlobalDataWrapper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerMoney;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerExp;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerScraps;

	private static readonly System.IntPtr NativeFieldInfoPtr_BarnsAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_MissionsFinished;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentMissionDone;

	private static readonly System.IntPtr NativeFieldInfoPtr_UnlockedParkingLevels;

	private static readonly System.IntPtr NativeFieldInfoPtr_StoryMissionInProgress;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[System.Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType => Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<NewGlobalDataWrapper>.NativeClassPtr));

	public unsafe int PlayerMoney
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerMoney);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerMoney)) = num;
		}
	}

	public unsafe int PlayerLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerLevel)) = num;
		}
	}

	public unsafe int PlayerExp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerExp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerExp)) = num;
		}
	}

	public unsafe int PlayerScraps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerScraps);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerScraps)) = num;
		}
	}

	public unsafe int BarnsAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BarnsAmount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BarnsAmount)) = num;
		}
	}

	public unsafe int MissionsFinished
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionsFinished);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionsFinished)) = num;
		}
	}

	public unsafe bool CurrentMissionDone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentMissionDone);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentMissionDone)) = flag;
		}
	}

	public unsafe int UnlockedParkingLevels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UnlockedParkingLevels);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UnlockedParkingLevels)) = num;
		}
	}

	public unsafe bool StoryMissionInProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StoryMissionInProgress);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StoryMissionInProgress)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65449, XrefRangeEnd = 65450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Serialize(BinaryWriter binaryWriter)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void Deserialize(BinaryReader binaryReader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryReader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe NewGlobalDataWrapper()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewGlobalDataWrapper>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static NewGlobalDataWrapper()
	{
		Il2CppClassPointerStore<NewGlobalDataWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "NewGlobalDataWrapper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewGlobalDataWrapper>.NativeClassPtr);
		NativeFieldInfoPtr_PlayerMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGlobalDataWrapper>.NativeClassPtr, "PlayerMoney");
		NativeFieldInfoPtr_PlayerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGlobalDataWrapper>.NativeClassPtr, "PlayerLevel");
		NativeFieldInfoPtr_PlayerExp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGlobalDataWrapper>.NativeClassPtr, "PlayerExp");
		NativeFieldInfoPtr_PlayerScraps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGlobalDataWrapper>.NativeClassPtr, "PlayerScraps");
		NativeFieldInfoPtr_BarnsAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGlobalDataWrapper>.NativeClassPtr, "BarnsAmount");
		NativeFieldInfoPtr_MissionsFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGlobalDataWrapper>.NativeClassPtr, "MissionsFinished");
		NativeFieldInfoPtr_CurrentMissionDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGlobalDataWrapper>.NativeClassPtr, "CurrentMissionDone");
		NativeFieldInfoPtr_UnlockedParkingLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGlobalDataWrapper>.NativeClassPtr, "UnlockedParkingLevels");
		NativeFieldInfoPtr_StoryMissionInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGlobalDataWrapper>.NativeClassPtr, "StoryMissionInProgress");
		NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGlobalDataWrapper>.NativeClassPtr, 100667329);
		NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGlobalDataWrapper>.NativeClassPtr, 100667330);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGlobalDataWrapper>.NativeClassPtr, 100667331);
	}

	public NewGlobalDataWrapper(System.IntPtr P_0)
		: base(P_0)
	{
	}
}
