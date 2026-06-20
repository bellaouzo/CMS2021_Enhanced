# CMS2021 Together — Seamless Co-op Completeness Design

**Date:** 2026-06-20  
**Status:** Approved

---

## Overview

Expand the CMS21Together multiplayer mod from partial co-op coverage to full seamless co-op. All player actions in the garage scene — including outdoor service stations, garage visual customization, shared economy, and shared skill progression — will be synced across clients.

All changes use the established architecture:
```
Hook (Postfix) → ClientSend → ServerHandle [→ ServerData] → ServerSend → ClientHandle → Apply
```

---

## Scope

### 1. Outside Services

These are garage-scene service bays outside the main building: car wash tunnel, paintshop bay, dyno bay, wheel alignment rack. They use different game classes than the indoor tools but live in the same `GameScene.garage` scene.

#### 1a. Outdoor Car Wash

**Problem:** The existing `CarWashLogic.cs` hook patches `InteriorDetailingToolkitLogic.DoWorkAnim` for interior cleaning. The outdoor car wash tunnel uses the game class `CarWashLogic.DoWorkAnim(CarLoader carLoader)` — a completely different class, never hooked.

**Fix:** Add a second `[HarmonyPatch]` to the existing `ClientSide/Data/Garage/Tools/CarWashLogic.cs` targeting `CarWashLogic.DoWorkAnim(CarLoader)`. Reuse the existing `carWash` packet type and `ClientSend.CarWashPacket(carLoaderID, interior: false)` call. No new packet needed.

**Hook target:** `CarWashLogic.DoWorkAnim(CarLoader carLoader)` — extract carLoaderID from `carLoader.gameObject.name[10] - '0' - 1`.

#### 1b. Car Painting

**Problem:** Needs position-check verification. The hook on `PaintshopManager.MakePaintEffects` is correct for all paintshops (same manager regardless of location). However `CarPaintLogic.ChangeColor` looks up the car at `carPosition == 5`. The game's `CarPlace.Paintshop = 5` (0-indexed enum), and the mod stores `car.carPosition` as the raw game int from `carLoader.placeNo`. This is correct — no position offset issue. The fix is verification only; if the lookup fails in practice it is because `ModCar.carPosition` is set from a different source on join — cross-check during implementation.

**No new packet or file needed.**

#### 1c. Power Bench (Dyno)

**Problem:** `DynoManager.RunDyno()` is never hooked. Remote clients don't see the dyno animation and their car's `measuredDragIndex` stays stale.

**New packet:** `dynoRun`

**New file:** `ClientSide/Data/Garage/Tools/DynoLogic.cs`

**Hook:** `DynoManager.RunDyno()` [Postfix]
- Read `GameData.Instance.dynoManager.CarLoader` to get the CarLoader
- Derive carLoaderID from its gameObject name
- Send `ClientSend.DynoRunPacket(carLoaderID)`

**Server:** `ServerHandle.DynoRunPacket` stores `ServerData.Instance.dynoCarLoaderID = carLoaderID`, calls `ServerSend.DynoRunPacket(fromClient, carLoaderID)`.

**Client receive:** `ClientHandle.DynoRunPacket` calls `GameData.Instance.dynoManager.RunDyno()` with a `listen = false` guard. Both clients then run the dyno independently and the result (`measuredDragIndex`) is deterministic from the car state — it will be consistent without extra sync.

**Resync:** Include `dynoCarLoaderID` in `ServerData`. No explicit resync needed since dyno result propagates through existing car-data resync on rejoin.

#### 1d. Wheel Alignment

**Problem:** `WheelsAlignmentWindow.UpdateCarWheelAlignment()` is never hooked. After aligning a car, remote clients still see the old unaligned values. `ModWheelsAlignmentData` already exists in `ModNewCarData` but is never updated live.

**New packet:** `wheelAlignment`

**New file:** `ClientSide/Data/Garage/Tools/WheelAlignmentLogic.cs`

**New shared data:** None — `ModWheelsAlignmentData` already exists in `Shared/Data/Vanilla/Cars/`.

**Hook:** `WheelsAlignmentWindow.UpdateCarWheelAlignment()` [Postfix]
- Read `__instance.carLoader` to get CarLoader
- Derive carLoaderID
- Read `carLoader.WheelsAlignment` (FL/FR/RL/RR floats), wrap as `ModWheelsAlignmentData`
- Send `ClientSend.WheelAlignmentPacket(carLoaderID, data)`

**Server:** `ServerHandle.WheelAlignmentPacket` updates `ServerData.Instance.CarPartInfo[carLoaderID].wheelsAlignmentData = data`, calls `ServerSend.WheelAlignmentPacket(fromClient, carLoaderID, data)`.

**Client receive:** `ClientHandle.WheelAlignmentPacket` — set `GameData.Instance.carLoaders[carLoaderID].WheelsAlignment = data.ToGame()`. Update `ClientData.Instance.loadedCars[carLoaderID]` stored data.

**Resync:** Add `wheelsAlignmentData` field to `ModCarInfo` in `ServerData.cs`. Include in `ServerResyncs.ResyncCar` — send as part of the `LoadCarPacket` (it's already in `ModNewCarData.wheelsAlignmentData`), so this is free once `ServerData.CarSpawnDatas` is updated on alignment change.

**ServerData update:** When `CarSpawnDatas[carLoaderID]` exists, update `CarSpawnDatas[carLoaderID].wheelsAlignmentData = data` in `ServerHandle.WheelAlignmentPacket` so resync sends the correct values.

#### 1e. Headlamp Alignment (bonus — found during audit)

**Problem:** `LampAlignmentWindow.ChangeLamp()` finalises headlamp beam angles. `ModHeadLampAlignmentData` exists in `ModNewCarData` but is never updated live.

**New packet:** `headlampAlignment`

**New file:** `ClientSide/Data/Garage/Tools/HeadlampAlignmentLogic.cs`

**Hook:** `LampAlignmentWindow.ChangeLamp()` [Postfix]
- Read `__instance.carLoader`
- Read `carLoader.HeadlampLeftAlignmentData` and `carLoader.HeadlampRightAlignmentData`
- Wrap as two `ModHeadLampAlignmentData`
- Send `ClientSend.HeadlampAlignmentPacket(carLoaderID, leftData, rightData)`

**Server:** Store in `ServerData.CarSpawnDatas[carLoaderID]` (.HeadLampLeftAlignmentData / .HeadlampRightAlignmentData). Broadcast to all except sender.

**Client receive:** Apply to `carLoader.HeadlampLeftAlignmentData` / `carLoader.HeadlampRightAlignmentData`.

**Resync:** Free — already in `ModNewCarData`, which is sent by `ResyncCar` via `LoadCarPacket`.

---

### 2. Garage Customization

**Problem:** `GarageLookManager.SetMaterialIndexForSection(int sectionIndex, int materialIndex)` is never hooked. When one player changes the garage floor, walls, or ceiling, the other player sees the original look.

**New packet:** `garageCustomization`

**New shared data class:** `ModGarageLook` in `Shared/Data/Vanilla/ModGarageLook.cs`
```csharp
[Serializable]
public class ModGarageLook
{
    public int sectionIndex;
    public int materialIndex;
}
```

**New file:** `ClientSide/Data/Garage/GarageCustomizationLogic.cs`

**Hook:** `GarageLookManager.SetMaterialIndexForSection(int sectionIndex, int materialIndex)` [Postfix]
- Guard with `listen` flag to prevent feedback loop
- Send `ClientSend.GarageCustomizationPacket(sectionIndex, materialIndex)`

**Server:**
- `ServerHandle.GarageCustomizationPacket` updates `ServerData.Instance.garageLook[sectionIndex] = materialIndex`, calls `ServerSend.GarageCustomizationPacket(fromClient, sectionIndex, materialIndex)`
- Add `Dictionary<int, int> garageLook = new()` to `ServerData`

**Client receive:** `ClientHandle.GarageCustomizationPacket`
- Set `GarageCustomizationLogic.listen = false`
- Call `GameData.Instance.garageLookManager.SetMaterialIndexForSection(sectionIndex, materialIndex)`

**Resync:**
- Add `ResyncGarageLook(int fromClient)` to `ServerResyncs.cs` — iterates `ServerData.Instance.garageLook` and sends each entry
- Call from `GarageResync.ResyncGarage()` after the existing resync calls

---

### 3. Shared Money Fix

**Problem:** `ServerSend.PlayerSpawnPacket` (line 23) sends `SavesManager.ModSaves[SavesManager.currentSaveIndex].money` — the save file's stale value. The server tracks the live balance in `ServerData.Instance.money`, but late-joining clients receive the wrong amount.

**Fix:** One-line change in `ServerSide/Data/ServerSend.cs`:
```csharp
// Before:
packet.Write(SavesManager.ModSaves[SavesManager.currentSaveIndex].money);
// After:
packet.Write(ServerData.Instance.money);
```

No new packets or files needed.

---

### 4. Shared Upgrades

#### 4a. Garage Building Upgrades (crane, lifter, etc.)

The existing `GarageUpgradeHooks` → `garageUpgrade` packet → `GarageUpgradeManager.SetUpgrade` chain is functionally correct. The resync path (`ServerResyncs.ResyncUpgrade`) is in place. No code changes needed — verify during testing.

#### 4b. Skill Upgrades (faster drill, better diagnostics, etc.) — Shared Pool

**Problem:** `ServerHandle.SkillChangePacket` currently saves skill state to the unlocking player's `PlayerInfo` but does **not** broadcast to other clients. When Player A unlocks "faster drill", Player B never receives it and continues using slower tool speeds.

**Decision:** Skills are **shared** — one skill pool for the whole garage. When any player unlocks a skill, all players benefit.

**Changes:**

`ServerHandle.SkillChangePacket`:
```csharp
public static void SkillChangePacket(int fromClient, Packet packet)
{
    string playerID = packet.Read<string>();
    string id = packet.Read<string>();
    List<bool> skill = packet.Read<List<bool>>();

    // Save per-player as before
    SavesManager.ModSaves[...].playerInfos.First(p => p.id == playerID).UpdateSkill(id, skill);

    // NEW: broadcast to all other clients
    ServerSend.SkillChangePacket(fromClient, id, skill);
}
```

New `ServerSend.SkillChangePacket(int fromClient, string id, List<bool> skill)`:
- Builds a new packet with type `skillChange`, writes `id` and `skill`
- Calls `SendDataToAll(fromClient, packet)` — sends to everyone except the original sender

`ClientHandle` — add `SkillChangePacket(Packet packet)`:
- Read `id` (string) and `skill` (List<bool>)
- Set `SkillUpgradeHook.listen = false`
- Call the game's `UpgradeSystem.UnlockUpgrade(id, level, UpgradeType.Money)` for each level in the skill array that is `true` (iterate and unlock)
- Reset `SkillUpgradeHook.listen = true`

**Note on level iteration:** `UpgradeSystem.GetUnlocked(id)` returns a `bool[]` where index = upgrade level. When applying remotely, for each index `i` where `skill[i] == true`, call `UnlockUpgrade(id, i, UpgradeType.Free)` (or `UpgradeType.Money` with `listen = false` so no cost is deducted).

**Resync:** Add `ResyncSkills(int fromClient)` to `ServerResyncs.cs`.
- `ServerData` must track current skill states. Add `Dictionary<string, List<bool>> sharedSkills = new()` to `ServerData`.
- Update in `ServerHandle.SkillChangePacket`: `ServerData.Instance.sharedSkills[id] = skill`
- `ResyncSkills` iterates `ServerData.Instance.sharedSkills` and sends each entry to the requesting client.
- Call `ResyncSkills` from `GarageResync.ResyncGarage()`.

**Register handler:** Add `{ (int)PacketTypes.skillChange, ClientHandle.SkillChangePacket }` to the client's packet handler dictionary in `Client.cs`.

---

### 5. Fluid Sync Fix

**Problem:** `ServerData.UpdateFluid()` has a `// TODO: Implement this` comment. Fluid changes are transmitted over the network but never persisted server-side, so late-joining clients see stale fluid levels.

**Fix:** Implement `ServerData.UpdateFluid(ModFluidData fluid, int carLoaderID)`:
```csharp
public void UpdateFluid(ModFluidData fluid, int carLoaderID)
{
    if (!CarSpawnDatas.ContainsKey(carLoaderID)) return;
    // Store in FluidsData for the car — update the matching fluid entry
    CarSpawnDatas[carLoaderID].FluidsData.UpdateFluid(fluid);
}
```

`ModFluidsData` already has a list of fluids — add or update an `UpdateFluid(ModFluidData fluid)` method on it that finds the matching `carFluidType` entry and updates its level. Fluid data is already in `ModNewCarData.FluidsData`, so it will be included automatically in `ResyncCar`'s `LoadCarPacket`.

---

## Files Changed Summary

| File | Change |
|---|---|
| `Shared/PacketTypes.cs` | Add: `dynoRun`, `wheelAlignment`, `headlampAlignment`, `garageCustomization` |
| `Shared/Data/Vanilla/ModGarageLook.cs` | **New** — `ModGarageLook { sectionIndex, materialIndex }` |
| `ClientSide/Data/Garage/Tools/CarWashLogic.cs` | Add hook for `CarWashLogic.DoWorkAnim(CarLoader)` |
| `ClientSide/Data/Garage/Tools/CarPaintLogic.cs` | Verify position check; fix if needed |
| `ClientSide/Data/Garage/Tools/DynoLogic.cs` | **New** — hook + apply for dyno |
| `ClientSide/Data/Garage/Tools/WheelAlignmentLogic.cs` | **New** — hook + apply for wheel alignment |
| `ClientSide/Data/Garage/Tools/HeadlampAlignmentLogic.cs` | **New** — hook + apply for headlamp alignment |
| `ClientSide/Data/Garage/GarageCustomizationLogic.cs` | **New** — hook + apply for garage look |
| `ClientSide/Data/Garage/GarageResync.cs` | Add calls for `ResyncSkills`, `ResyncGarageLook` |
| `ClientSide/Data/Handle/ClientSend.cs` | Add: `DynoRunPacket`, `WheelAlignmentPacket`, `HeadlampAlignmentPacket`, `GarageCustomizationPacket` |
| `ClientSide/Data/Handle/ClientHandle.cs` | Add: `DynoRunPacket`, `WheelAlignmentPacket`, `HeadlampAlignmentPacket`, `GarageCustomizationPacket`, `SkillChangePacket` |
| `ClientSide/Client.cs` | Register new packet handlers in the handler dictionary |
| `ClientSide/Data/Garage/Campaign/SkillUpgradeHook.cs` | No change needed (already sends correctly) |
| `ServerSide/Data/ServerData.cs` | Add: `dynoCarLoaderID`, `garageLook`, `sharedSkills`; implement `UpdateFluid` |
| `ServerSide/Data/ServerHandle.cs` | Add: `DynoRunPacket`, `WheelAlignmentPacket`, `HeadlampAlignmentPacket`, `GarageCustomizationPacket`; update `SkillChangePacket` to broadcast |
| `ServerSide/Data/ServerSend.cs` | Fix money line in `PlayerSpawnPacket`; add: `DynoRunPacket`, `WheelAlignmentPacket`, `HeadlampAlignmentPacket`, `GarageCustomizationPacket`, `SkillChangePacket` |
| `ServerSide/Data/ServerResyncs.cs` | Add: `ResyncGarageLook`, `ResyncSkills` |
| `Shared/Data/Vanilla/Cars/ModFluidsData.cs` | Add `UpdateFluid(ModFluidData)` method |

---

## Implementation Order

1. Shared money fix (one line — quick win, unblocks testing)
2. Fluid sync fix (completes existing TODO)
3. Outdoor car wash hook (small addition to existing file)
4. Car painting position verification
5. Dyno sync (new file, new packet)
6. Wheel alignment sync (new file, new packet)
7. Headlamp alignment sync (new file, new packet)
8. Garage customization sync (new file, new packet, new data class)
9. Shared skill upgrades (broadcast + resync)
10. End-to-end testing of all features together

---

## Out of Scope

- Barn scene sync (separate scene — future work)
- Junkyard scene sync (separate scene — future work)
- Auto salon scene sync (separate scene — future work)
- Licence plate sync (low gameplay impact — future work)
- ECU/tuning data live sync (synced at car load — acceptable for now)
