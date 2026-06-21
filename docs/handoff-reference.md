# CMS21Together — Full Handoff Reference

**Project:** CMS21Together — multiplayer co-op mod for Car Mechanic Simulator 2021  
**Engine:** Unity 2020.3.49f1 (IL2CPP), MelonLoader v0.5.7  
**Mod version:** 0.4.16hf3  
**Branch:** `feature/seamless-coop` (branched from initial commit `7e08e43`)  
**Build:** `dotnet build CMS21-Together.csproj -c Release` → `bin\Release\CMS21-Together.dll`  
**Deploy:** Copy that DLL to `C:\Program Files (x86)\Steam\steamapps\common\Car Mechanic Simulator 2021\Mods\CMS21-Together.dll` (game must be closed)

---

## Architecture

### Packet flow (all features follow this pattern)
```
Hook (HarmonyPostfix/Prefix on game method)
  → ClientSend.XxxPacket(...)         — writes packet, sends to server
  → ServerHandle.XxxPacket(...)       — reads packet, updates ServerData, calls ServerSend
  → ServerSend.XxxPacket(...)         — broadcasts to all clients except sender
  → ClientHandle.XxxPacket(...)       — reads packet, starts coroutine
  → ApplyXxx coroutine                — waits for GameReady, sets listen=false, calls game method
```

### Key patterns
- **`listen` flag**: every hook class has `public static bool listen = true`. Before calling the game method in an apply coroutine, set `listen = false`. The hook reads this flag and returns early to prevent the feedback loop. Always reset to `true` after.
- **`MelonCoroutines.Start()`**: all receive-side game-state changes MUST go through a coroutine (IL2CPP constraint).
- **`SendDataToAll(fromClient, packet)`**: sends to all connected clients EXCEPT the sender. Used for live sync.
- **`SendData(toClient, packet)`**: sends to one specific client. Used for resync (late-join).
- **Resync system**: client sends a `resync` packet with a sub-type (e.g., `PacketTypes.garageCustomization`). Server handles it in `ServerHandle.ResyncPacket` switch, calls the appropriate `ServerResyncs.*` method, which iterates stored state and sends each entry to the requesting client only.
- **`.csproj` explicit compile list**: the project does NOT auto-discover source files. Every new `.cs` file MUST be added as `<Compile Include="path\to\File.cs" />` in `CMS21-Together.csproj`.

### Key singletons / access paths
| What | How to access |
|------|--------------|
| Dyno manager | `DynoManager.m_instance` |
| Garage look manager | `GarageLookManager.Instance` (capital I) |
| Game data | `GameData.Instance` |
| Car loaders | `GameData.Instance.carLoaders[carLoaderID]` |
| Server data | `ServerData.Instance` |
| Client data | `ClientData.Instance` |
| Upgrade system | `GameData.Instance.upgradeTools.upgradeSystem` |

### CarLoader ID extraction
```csharp
int carLoaderID = carLoader.gameObject.name[10] - '0' - 1;
// gameObject.name is like "CarLoader_1", "CarLoader_2", etc. (1-indexed)
// carLoaderID is 0-indexed (0–4)
// Always guard: if (carLoaderID < 0 || carLoaderID >= 5) return;
```

---

## PacketTypes enum (current state)
```csharp
public enum PacketTypes
{
    connect, handshake, disconnect, userData, readyState, start,
    spawn, position, rotation, item, groupItem, stat, lifter,
    loadJobCar, loadCar, bodyPart, partScript, deleteCar, carPosition,
    garageUpgrade, newJob, jobAction, selectedJob, sceneChange, contentInfo,
    toolMove, setSpringClamp, clearSpringClamp, setTireChanger, clearTireChanger,
    wheelBalance, endJob, oilBinUse, engineCrane, skillChange,
    engineStandAngle, engineStandSetGroup, engineStandTakeOff,
    carFluid, exp, point, resync,
    carWash, carPaint, useWelder, repairPart, parkAdd, parkRemove,
    playerInCar, carEngineSound,
    dynoRun, wheelAlignment, headlampAlignment, garageCustomization
}
```
The last four (`dynoRun`, `wheelAlignment`, `headlampAlignment`, `garageCustomization`) were added in this session.

---

## What was implemented (seamless co-op features)

### Commit history
```
7e08e43  chore: initial commit — existing codebase before seamless co-op features
098dcb1  fix: late-join money uses live balance; implement fluid state tracking on server
9350c7f  feat: sync outdoor car wash tunnel to remote clients
13a6df7  chore: verified car paint position check is correct (carPosition == 5)
7b92359  feat: sync dyno/power bench runs to remote clients
ac83b8c  feat: sync wheel alignment changes to remote clients
2d79604  feat: sync headlamp alignment changes to remote clients
14b4d29  feat: sync garage customization to remote clients with resync on join
189b4d9  feat: share skill upgrades across all clients with broadcast and resync
331a1ce  fix: register server packet handlers for dyno/alignment/garage-look; fix struct mutation in UpdateFluid
```
Plus post-branch save system fixes (not yet committed — see below).

---

### Feature 1 — Shared money fix (commit 098dcb1)
**File:** `ServerSide/Data/ServerSend.cs` line ~23  
**Problem:** `PlayerSpawnPacket` sent `SavesManager.ModSaves[...].money` (stale save value) to late-joining clients instead of the live server balance.  
**Fix:** Changed to `ServerData.Instance.money`.

---

### Feature 2 — Fluid sync fix (commit 098dcb1)
**File:** `Shared/Data/Vanilla/Cars/ModFluidsData.cs` — added `UpdateFluid(ModFluidData fluid)` method  
**File:** `ServerSide/Data/ServerData.cs` — implemented `UpdateFluid(ModFluidData fluid, int carLoaderID)`  
**Problem:** `ServerData.UpdateFluid` had a `// TODO: Implement this` body. Fluid changes were never persisted server-side.  
**Fix:** `ModFluidsData.UpdateFluid` finds the matching fluid by type and updates/adds it. `ServerData.UpdateFluid` calls it.  
**Critical detail:** `ModFluidsData` is a **struct**. The fix uses explicit read-modify-write:
```csharp
var fluids = CarSpawnDatas[carLoaderID].FluidsData;
fluids.UpdateFluid(fluid);
CarSpawnDatas[carLoaderID].FluidsData = fluids;
```
(Direct `CarSpawnDatas[carLoaderID].FluidsData.UpdateFluid(fluid)` silently discards the mutation.)  
**Also note:** The enum value is `ModCarFluidType.EngineOil`, NOT `ModCarFluidType.Oil` (`.Oil` doesn't exist).

---

### Feature 3 — Outdoor car wash sync (commit 9350c7f)
**File:** `ClientSide/Data/Garage/Tools/CarWashLogic.cs` — added second `[HarmonyPatch]`  
**Problem:** Existing hook only patched `InteriorDetailingToolkitLogic.DoWorkAnim` (interior cleaning). The outdoor tunnel uses `CarWashLogic.DoWorkAnim(CarLoader)` — a completely different game class with the same name as the mod's static class.  
**Fix:** Added `[HarmonyPatch(typeof(global::CarWashLogic), nameof(global::CarWashLogic.DoWorkAnim))]` — the `global::` prefix is required because the mod's own class is also named `CarWashLogic` (namespace collision).  
**Reuses:** Existing `carWash` packet type with `interior: false`.

---

### Feature 4 — Car paint position verification (commit 13a6df7)
**No code change.** `CarPaintLogic` already correctly checks `carPosition == 5`. The raw `CarPlace` int for paintshop is 5, and `ClientSide/Data/Garage/Hooks/CarSyncHooks.cs` stores the raw game int without offset. Verified correct.

---

### Feature 5 — Dyno (power bench) sync (commit 7b92359)
**New file:** `ClientSide/Data/Garage/Tools/DynoLogic.cs`  
**New packet:** `dynoRun`  
**Hook:** `[HarmonyPatch(typeof(DynoManager), nameof(DynoManager.RunDyno))]` [Postfix]  
**CarLoader access:** `DynoManager.m_instance.CarLoader` (NOT `GameData.Instance.dynoManager`)  
**Apply coroutine:** Sets `m_instance.canRunDyno = true`, calls `RunDyno()`. Both clients run the dyno independently — result (`measuredDragIndex`) is deterministic from car state.  
**Added to .csproj.**

---

### Feature 6 — Wheel alignment sync (commit ac83b8c)
**New file:** `ClientSide/Data/Garage/Tools/WheelAlignmentLogic.cs`  
**New packet:** `wheelAlignment`  
**Hook:** `[HarmonyPatch(typeof(WheelsAlignmentWindow), nameof(WheelsAlignmentWindow.UpdateCarWheelAlignment))]` [Postfix]  
**Data types:** `WheelsAlignment` is a struct on `CarLoader`. `WheelsAlignmentData` is a class used by `ModWheelsAlignmentData`. Build the `ModWheelsAlignmentData` directly from the struct's FL/FR/RL/RR fields.  
**`ModCar` has no wheelsAlignmentData field** — only `ModNewCarData` (in `ServerData.CarSpawnDatas`) does. Do not try to update `loadedCars[id].wheelsAlignmentData` — it doesn't exist.  
**Added to .csproj.**

---

### Feature 7 — Headlamp alignment sync (commit 2d79604)
**New file:** `ClientSide/Data/Garage/Tools/HeadlampAlignmentLogic.cs`  
**New packet:** `headlampAlignment`  
**Hook:** `[HarmonyPatch(typeof(LampAlignmentWindow), nameof(LampAlignmentWindow.ChangeLamp))]` [Postfix]  
**Data types:** Same pattern as wheel alignment — `HeadlampAlignment` is a struct, `HeadlampAlignmentData` is a class.  
**Field name gotcha:** In `ServerHandle` and `ModNewCarData`, the fields are:
- `HeadLampLeftAlignmentData` (capital L in LampLeft)
- `HeadlampRightAlignmentData` (lowercase l in lampRight)  
**Added to .csproj.**

---

### Feature 8 — Garage customization sync (commit 14b4d29)
**New files:** `ClientSide/Data/Garage/GarageCustomizationLogic.cs`, `Shared/Data/Vanilla/ModGarageLook.cs`  
**New packet:** `garageCustomization`  
**Hook:** `[HarmonyPatch(typeof(GarageLookManager), nameof(GarageLookManager.SetMaterialIndexForSection))]` [Postfix]  
**Singleton:** `GarageLookManager.Instance` (capital I — confirmed from decompiled source)  
**Namespace:** `using CMS.Garage.Customization;`  
**Server state:** `Dictionary<int, int> garageLook` added to `ServerData` — maps sectionIndex → materialIndex  
**Resync:** `ServerResyncs.ResyncGarageLook(fromClient)` iterates `garageLook` dict; called from `GarageResync.ResyncGarage()` and from the `resync` packet switch.  
**Critical guard:** The hook fires on garage load for all ~41 sections with `materialIndex = -1` (game's "unset" default). Guard added:
```csharp
if (materialIndex < 0) return;
```
Without this guard, 41 spurious packets fire every garage load.  
**Added to .csproj.**

---

### Feature 9 — Shared skill upgrades (commit 189b4d9)
**Problem:** `ServerHandle.SkillChangePacket` stored the skill for the sending player but never broadcast it. Other players never received skill unlocks.  
**Decision:** Skills are a **shared pool** — one player unlocks it, all benefit.  
**Changes:**
- `ServerData`: added `Dictionary<string, List<bool>> sharedSkills`
- `ServerHandle.SkillChangePacket`: now also does `sharedSkills[id] = skill` and calls `ServerSend.SkillChangePacket(fromClient, id, skill)`
- `ServerSend.SkillChangePacket(int fromClient, string id, List<bool> skill, bool resync = false)`: new method; `resync=true` → `SendData`, `false` → `SendDataToAll`
- `ClientHandle`: added `SkillChangePacket` handler + `ApplySkillChange` coroutine
- `ApplySkillChange`: waits for GameReady, sets `SkillUpgradeHook.listen = false`, calls `UnlockUpgrade(id, level, UpgradeType.Money)` for each `true` entry, resets listen
- `Client.cs`: registered `skillChange → ClientHandle.SkillChangePacket` in PacketHandlers dict (it was MISSING before — server sent it but client never had a handler)
- `ServerResyncs.ResyncSkills(fromClient)`: iterates `sharedSkills`, sends each entry
- `GarageResync.ResyncGarage()`: calls `ClientSend.ResyncSkills()` after existing resync calls  
**No new files** (all existing files modified). No `.csproj` change needed.

---

### Fix — Server packet handler registrations (commit 331a1ce)
**File:** `ServerSide/Server.cs` — `InitializeServerData()` packet handler dictionary  
**Problem:** Four new packet types had handler methods in `ServerHandle.cs` but were never registered in the server's dispatch dictionary. All four were silently dropped by the server.  
**Fix:** Added entries for `dynoRun`, `wheelAlignment`, `headlampAlignment`, `garageCustomization`.

---

## Post-branch save system fixes (not yet committed)

These are uncommitted changes in the working tree. They fix pre-existing bugs in the custom multi-slot save system.

### Save fix 1 — GarageCustomizationLogic -1 guard
**File:** `ClientSide/Data/Garage/GarageCustomizationLogic.cs`  
Added `if (materialIndex < 0) return;` in `SetMaterialIndexForSectionHook` before sending the packet. (Already described above under Feature 8.)

### Save fix 2 — LoadExistingModSaves rewrite
**File:** `Shared/SavesManager.cs` — `LoadExistingModSaves()` method

**Root cause of the original bug:** `ReloadProfiles` modifies `ProfileData` array slots **in-place** (does not create new objects). The old code:
1. Called `ReloadProfiles(tempSaveArray)` where `tempSaveArray[3]` had the custom save bytes — this wrote custom save data into `ProfileData[3]` in-place
2. Grabbed a reference to `ProfileData[3]` (or called `DataHelper.Copy` on it)
3. Called `ReloadProfiles(vanillaSaveArray)` to restore slot 3 — this overwrote the same in-memory object with vanilla data
4. Result: the stored reference now pointed to vanilla/empty data (if direct reference) or had shallow IL2CPP ref fields that then became dangling (if DataHelper.Copy)

**Fix:** Removed the slot-3 trick from `LoadExistingModSaves` entirely. For `alreadyLoaded` saves, creates a display-only `ProfileData` (just Name + Difficulty from the JSON mod save) to populate the save selection UI. The real save data is loaded fresh in `LoadSave` when the user actually starts the game.

```csharp
private static void LoadExistingModSaves()
{
    if (!Directory.Exists(SAVE_FOLDER_PATH)) return;
    var saveFiles = new DirectoryInfo(SAVE_FOLDER_PATH).GetFiles("save_*.cms21mp");
    for (var i = 0; i < saveFiles.Length; i++)
    {
        ModSaveData modSave = JsonConvert.DeserializeObject<ModSaveData>(File.ReadAllText(saveFiles[i].ToString()));
        ModSaves[modSave.saveIndex] = modSave;
        if (modSave.alreadyLoaded)
        {
            var display = new ProfileData();
            display.Init();
            var bw = new BinaryWriter();
            display.WriteSaveHeader(bw);
            display.WriteSaveVersion(bw);
            display.Name = modSave.Name;
            display.Difficulty = GetDifficultyFromGamemode(modSave.selectedGamemode);
            profileData[modSave.saveIndex] = display;
        }
    }
}
```

### Save fix 3 — LoadSave alreadyLoaded path rewrite
**File:** `Shared/SavesManager.cs` — `LoadSave()` method, `alreadyLoaded == true` branch

**Strategy:** Since `ReloadProfiles` is in-place, we redirect `profileData[3]` to a **fresh** `ProfileData` object before calling it. `ReloadProfiles` writes the real save data into that fresh object. We then move the fresh object to `profileData[index]` and restore the original vanilla slot 3.

```csharp
if (saveData.alreadyLoaded)
{
    var originalSlot3 = profileData[3];
    var freshSlot3 = new ProfileData();
    freshSlot3.Init();
    var bw3 = new BinaryWriter();
    freshSlot3.WriteSaveHeader(bw3);
    freshSlot3.WriteSaveVersion(bw3);
    profileData[3] = freshSlot3;

    var freshSaveArray = new Il2CppReferenceArray<SaveData>(4);
    freshSaveArray[3] = GetSave(index);
    gameManager.GameDataManager.ReloadProfiles(freshSaveArray);

    profileData[index] = profileData[3];  // freshSlot3 now has real save data
    profileData[3] = originalSlot3;        // restore vanilla slot 3

    gameManager.ProfileManager.selectedProfile = index;
    gameManager.RDGPlayerPrefs.SetInt("selectedProfile", index);
    Singleton<GameManager>.Instance.ProfileManager.SetDifficultyForCurrentProfile(level);
    gameManager.ProfileManager.Load();
    // ... rest unchanged
}
```

**Why `freshSaveArray[0-2]` can be null:** `ReloadProfiles` skips slots where `SaveData` is null, but requires the corresponding `ProfileData` slot to be non-null. `profileData[0-2]` are valid (set during `Initialize()`), so no NRE.

**Why we don't restore vanilla slot 3 with another `ReloadProfiles` call:** We use a direct reference swap (`profileData[3] = originalSlot3`). `originalSlot3` was never touched by `ReloadProfiles` (we replaced `profileData[3]` with `freshSlot3` first), so the reference is clean.

---

## Other known bugs (pre-existing, not fixed in this session)

From the memory file and code comments:
- `ModNewCarData..ctor` `List.ToArray()` NRE on incomplete job car data
- `DataHelper.Copy(ProfileData)` is a shallow copy with `// TODO: check this` on many IL2CPP reference fields (`machines`, `inventoryData`, `warehouseData`, `carLiftersData`, `carLoaderData`, `garageCustomizationData`, `globalDataWrapper`, `PaintshopData`, `PlayerData`, `ShopListItemsData`). These are left as shallow references and will dangle if the source object is later reinitialized — **this path is now bypassed for the alreadyLoaded case** (save fix 3 above), but `DataHelper.Copy` is still called in `LoadExistingModSaves` for the NEW save path.
- Client missing packet handlers for ids 53/83/84/86 (`barnsAmount`/`warehouseSync`/`machineSync`/`storyProgress`) — pre-existing, unrelated to this session's work
- `Garage load hook did not fire` logged every garage load (`CoopGarageLoadHooks` not firing) — pre-existing

---

## Files changed in this session (summary)

### New files
| File | Purpose |
|------|---------|
| `ClientSide/Data/Garage/Tools/DynoLogic.cs` | Dyno hook + apply coroutine |
| `ClientSide/Data/Garage/Tools/WheelAlignmentLogic.cs` | Wheel alignment hook + apply |
| `ClientSide/Data/Garage/Tools/HeadlampAlignmentLogic.cs` | Headlamp alignment hook + apply |
| `ClientSide/Data/Garage/GarageCustomizationLogic.cs` | Garage look hook + apply |
| `Shared/Data/Vanilla/ModGarageLook.cs` | `ModGarageLook { int sectionIndex; int materialIndex; }` data class |

### Modified files
| File | What changed |
|------|-------------|
| `Shared/PacketTypes.cs` | Added `dynoRun`, `wheelAlignment`, `headlampAlignment`, `garageCustomization` |
| `Shared/Data/Vanilla/Cars/ModFluidsData.cs` | Added `UpdateFluid(ModFluidData)` method |
| `Shared/SavesManager.cs` | Rewrote `LoadExistingModSaves` and `alreadyLoaded` path of `LoadSave` |
| `ClientSide/Client.cs` | Registered `skillChange` and four new packet handlers in PacketHandlers dict |
| `ClientSide/Data/Garage/Tools/CarWashLogic.cs` | Added outdoor car wash hook |
| `ClientSide/Data/Garage/GarageResync.cs` | Added `ResyncGarageLook` and `ResyncSkills` calls |
| `ClientSide/Data/Handle/ClientSend.cs` | Added `DynoRunPacket`, `WheelAlignmentPacket`, `HeadlampAlignmentPacket`, `GarageCustomizationPacket`, `ResyncGarageLook`, `ResyncSkills` |
| `ClientSide/Data/Handle/ClientHandle.cs` | Added handlers for all new packets + `SkillChangePacket` |
| `ServerSide/Server.cs` | Added 4 missing packet handler registrations |
| `ServerSide/Data/ServerData.cs` | Added `garageLook`, `sharedSkills` dicts; implemented `UpdateFluid` with struct read-modify-write |
| `ServerSide/Data/ServerHandle.cs` | Added handlers for all new packets; updated `SkillChangePacket` to broadcast; added `garageCustomization` and `skillChange` to `ResyncPacket` switch |
| `ServerSide/Data/ServerSend.cs` | Fixed money line in `PlayerSpawnPacket`; added all new send methods |
| `ServerSide/Data/ServerResyncs.cs` | Added `ResyncGarageLook`, `ResyncSkills` |
| `CMS21-Together.csproj` | Added `<Compile Include>` for 5 new files |

---

## Useful decompiled source locations
All decompiled game code is in `_decomp/` at the project root:
- `_decomp/CMS.Garage.Customization/GarageLookManager.cs` — confirmed `Instance` (capital I), confirmed `SetMaterialIndexForSection` signature
- `_decomp/CMS.Managers/BenchmarkManager.cs` — dyno-related
- `_decomp/CMS.UI.Windows/WheelsAlignmentWindow.cs` — wheel alignment window

---

## Build + test checklist
1. `dotnet build CMS21-Together.csproj -c Release` — must be 0 errors, 0 warnings
2. Close game if open
3. Copy `bin\Release\CMS21-Together.dll` → `...\Car Mechanic Simulator 2021\Mods\CMS21-Together.dll`
4. MelonLoader log: `C:\Program Files (x86)\Steam\steamapps\common\Car Mechanic Simulator 2021\MelonLoader\Latest.log`
5. Unity Player log: `%LocalLow%\Red Dot Games\Car Mechanic Simulator 2021\Player.log`
6. Crash dumps: `%LocalAppData%\Temp\Red Dot Games\Car Mechanic Simulator 2021\Crashes`
