# CMS2021 Seamless Co-op Completeness Implementation Plan

> **For agentic workers:** REQUIRED SUB-SKILL: Use superpowers:subagent-driven-development (recommended) or superpowers:executing-plans to implement this plan task-by-task. Steps use checkbox (`- [ ]`) syntax for tracking.

**Goal:** Implement all 9 missing co-op sync features so every in-garage player action is visible to all connected clients.

**Architecture:** Every feature follows the established pattern: game-event Harmony hook → `ClientSend` → `ServerHandle` (store in `ServerData`) → `ServerSend` → `ClientHandle` coroutine → apply. A `listen` flag on each hook class prevents the applied change from re-broadcasting.

**Tech Stack:** C# / MelonLoader IL2CPP mod, HarmonyLib Postfix/Prefix patches, custom TCP/UDP/Steam packet layer, `Packet` class for serialization, `MelonCoroutines.Start` for all receive-side game-state changes.

## Global Constraints

- Build: `dotnet build CMS21-Together.csproj -c Release` — output is `bin\Release\CMS21-Together.dll`
- Deploy: close the game first, then overwrite `C:\Program Files (x86)\Steam\steamapps\common\Car Mechanic Simulator 2021\Mods\CMS21-Together.dll`
- Every new packet type must be added to `Shared/PacketTypes.cs` AND registered in `Client.cs` `PacketHandlers` dict
- All hook classes need a `public static bool listen = true;` field with guard `if (!Client.Instance.isConnected || !listen) { listen = true; return; }`
- All receive-side game-state changes go through `MelonCoroutines.Start(...)` — never call game APIs directly from `ClientHandle`
- Sandbox gamemode: money-affecting code already has a `if (ClientData.Instance.gamemode == Gamemode.Sandbox) return;` guard — do not add one to skill upgrades (skills apply in both modes)
- No test framework exists — all "test" steps are manual in-game verification with two connected clients

---

## Task 1: Quick Fixes — Money + Fluid Sync

**Files:**
- Modify: `ServerSide/Data/ServerSend.cs` (line 23 — one character change)
- Modify: `ServerSide/Data/ServerData.cs` (implement `UpdateFluid`)
- Modify: `Shared/Data/Vanilla/Cars/ModFluidsData.cs` (add `UpdateFluid` method)

**Interfaces:**
- Produces: `ModFluidsData.UpdateFluid(ModFluidData fluid)` — updates the matching fluid field in the struct

---

- [ ] **Step 1: Fix the money bug in `ServerSend.cs`**

Open `ServerSide/Data/ServerSend.cs`. Line 23 currently reads:
```csharp
packet.Write(SavesManager.ModSaves[SavesManager.currentSaveIndex].money);
```
Change it to:
```csharp
packet.Write(ServerData.Instance.money);
```
That single field reference is the entire fix. Late-joining clients will now receive the live tracked balance.

- [ ] **Step 2: Add `UpdateFluid` method to `ModFluidsData`**

Open `Shared/Data/Vanilla/Cars/ModFluidsData.cs`. Add this method at the end of the struct body, before the closing `}`:

```csharp
public void UpdateFluid(ModFluidData fluid)
{
    if (fluid?.CarFluid == null) return;
    switch (fluid.CarFluid.FluidType)
    {
        case ModCarFluidType.Oil:
            Oil = fluid;
            break;
        case ModCarFluidType.Brake:
            if (Brake == null) Brake = new System.Collections.Generic.List<ModFluidData>();
            int bi = Brake.FindIndex(f => f?.CarFluid?.ID == fluid.CarFluid.ID);
            if (bi >= 0) Brake[bi] = fluid; else Brake.Add(fluid);
            break;
        case ModCarFluidType.EngineCoolant:
            if (EngineCoolant == null) EngineCoolant = new System.Collections.Generic.List<ModFluidData>();
            int ei = EngineCoolant.FindIndex(f => f?.CarFluid?.ID == fluid.CarFluid.ID);
            if (ei >= 0) EngineCoolant[ei] = fluid; else EngineCoolant.Add(fluid);
            break;
        case ModCarFluidType.PowerSteering:
            if (PowerSteering == null) PowerSteering = new System.Collections.Generic.List<ModFluidData>();
            int pi = PowerSteering.FindIndex(f => f?.CarFluid?.ID == fluid.CarFluid.ID);
            if (pi >= 0) PowerSteering[pi] = fluid; else PowerSteering.Add(fluid);
            break;
        case ModCarFluidType.WindscreenWash:
            if (WindscreenWash == null) WindscreenWash = new System.Collections.Generic.List<ModFluidData>();
            int wi = WindscreenWash.FindIndex(f => f?.CarFluid?.ID == fluid.CarFluid.ID);
            if (wi >= 0) WindscreenWash[wi] = fluid; else WindscreenWash.Add(fluid);
            break;
    }
}
```

- [ ] **Step 3: Implement `UpdateFluid` in `ServerData.cs`**

Open `ServerSide/Data/ServerData.cs`. Find the method:
```csharp
public void UpdateFluid(ModFluidData fluid, int carLoaderID)
{
    \MelonLogger.Msg("Not implemented..."); TODO: Implement this
}
```
Replace its body with:
```csharp
public void UpdateFluid(ModFluidData fluid, int carLoaderID)
{
    if (!CarSpawnDatas.ContainsKey(carLoaderID)) return;
    CarSpawnDatas[carLoaderID].FluidsData.UpdateFluid(fluid);
}
```

- [ ] **Step 4: Build and deploy**

```powershell
dotnet build CMS21-Together.csproj -c Release
if ($?) {
    $proc = Get-Process "Car Mechanic Simulator 2021" -ErrorAction SilentlyContinue
    if ($proc) { Write-Host "Close the game first!"; exit 1 }
    Copy-Item "bin\Release\CMS21-Together.dll" "C:\Program Files (x86)\Steam\steamapps\common\Car Mechanic Simulator 2021\Mods\CMS21-Together.dll" -Force
    Write-Host "Deployed."
}
```

- [ ] **Step 5: Manual test — money**

Start game as host. Note current money. Have second player join. Verify second player's displayed money matches host. Earn or spend money as host. Verify both clients update.

- [ ] **Step 6: Manual test — fluid**

Load a car. Have Player A add engine oil to 100%. Player B closes and re-opens the fluid menu or rejoins. Verify fluid level shows 100% for Player B (it now persists in `CarSpawnDatas`).

- [ ] **Step 7: Commit**

```bash
git add ServerSide/Data/ServerSend.cs ServerSide/Data/ServerData.cs Shared/Data/Vanilla/Cars/ModFluidsData.cs
git commit -m "fix: late-join money uses live balance; implement fluid state tracking on server"
```

---

## Task 2: Outdoor Car Wash Hook

**Files:**
- Modify: `ClientSide/Data/Garage/Tools/CarWashLogic.cs` (add one new `[HarmonyPatch]` method)

**Interfaces:**
- Consumes: `ClientSend.CarWashPacket(int carLoaderID, bool interior = false)` — already exists
- Note on naming: the mod's static class is `CMS21Together.ClientSide.Data.Garage.Tools.CarWashLogic`; the game's MonoBehaviour is the global-namespace `CarWashLogic`. Inside the mod's class file, use `global::CarWashLogic` to reference the game type in the `[HarmonyPatch]` attribute.

---

- [ ] **Step 1: Add the outdoor car wash hook to `CarWashLogic.cs`**

Open `ClientSide/Data/Garage/Tools/CarWashLogic.cs`. After the closing `}` of `DoWorkAnimHook` (around line 77), add:

```csharp
[HarmonyPatch(typeof(global::CarWashLogic), nameof(global::CarWashLogic.DoWorkAnim))]
[HarmonyPrefix]
public static void OutdoorCarWashHook(CarLoader carLoader)
{
    if (!Client.Instance.isConnected || !listen)
    {
        listen = true;
        return;
    }

    if (carLoader == null || carLoader.gameObject == null || carLoader.gameObject.name.Length < 11)
    {
        MelonLogger.Warning("[CarWashLogic->OutdoorCarWashHook] Invalid CarLoader reference.");
        return;
    }

    int carLoaderID = carLoader.gameObject.name[10] - '0' - 1;

    if (carLoaderID < 0 || carLoaderID >= 5)
    {
        MelonLogger.Warning($"[CarWashLogic->OutdoorCarWashHook] Invalid carLoaderID: {carLoaderID}");
        return;
    }

    ClientSend.CarWashPacket(carLoaderID, false);
    MelonLogger.Msg($"[CarWashLogic->OutdoorCarWashHook] Outdoor wash for carLoaderID: {carLoaderID}");
}
```

- [ ] **Step 2: Build and deploy** (same command as Task 1 Step 4)

- [ ] **Step 3: Manual test**

Drive a car into the outdoor car wash tunnel. Activate the car wash. Verify the dust wash animation plays on the second client's screen.

- [ ] **Step 4: Commit**

```bash
git add ClientSide/Data/Garage/Tools/CarWashLogic.cs
git commit -m "feat: sync outdoor car wash tunnel to remote clients"
```

---

## Task 3: Car Paint Position Verification

**Files:**
- Read only: `ClientSide/Data/Garage/Tools/CarPaintLogic.cs`, `ClientSide/Data/Garage/Car/CarSyncHooks.cs`
- Modify: `ClientSide/Data/Garage/Tools/CarPaintLogic.cs` only if the lookup is broken

**Interfaces:**
- Consumes: `ClientData.Instance.loadedCars` — `Dictionary<int, ModCar>` where `ModCar.carPosition` is set from `carLoader.placeNo` (raw `CarPlace` int, 0-indexed; `CarPlace.Paintshop = 5`)

---

- [ ] **Step 1: Read and verify `CarPaintLogic.cs`**

Open `ClientSide/Data/Garage/Tools/CarPaintLogic.cs`. Locate the coroutine that applies paint to the car. Confirm it finds the car using a check like:
```csharp
var car = ClientData.Instance.loadedCars.Values.FirstOrDefault(c => c.carPosition == 5);
```
`CarPlace.Paintshop = 5` (0-indexed game enum). If the lookup uses `== 5` and `ModCar.carPosition` is set from `carLoader.placeNo` (verify in `CarSyncHooks.cs`), the check is correct — no code change needed.

- [ ] **Step 2: Read `CarSyncHooks.cs` to confirm `carPosition` assignment**

Open `ClientSide/Data/Garage/Car/CarSyncHooks.cs`. Search for `carPosition`. Confirm it is set as `car.carPosition = no;` where `no` comes directly from the game's `placeNo` (raw `CarPlace` int). If confirmed correct, skip Step 3.

- [ ] **Step 3 (conditional): Fix position lookup if broken**

Only if the lookup is wrong (e.g., `ModCarPlace` offset is applied incorrectly), update the check to use the raw `CarPlace.Paintshop` value:
```csharp
// If ModCar.carPosition uses ModCarPlace (offset by 1), fix to:
var car = ClientData.Instance.loadedCars.Values.FirstOrDefault(c => c.carPosition == (int)CarPlace.Paintshop);
```

- [ ] **Step 4: Build and deploy**

- [ ] **Step 5: Manual test**

Drive a car to the paintshop bay (outdoor). Player A paints the car. Verify Player B sees the color change.

- [ ] **Step 6: Commit** (only if code changed)

```bash
git add ClientSide/Data/Garage/Tools/CarPaintLogic.cs
git commit -m "fix: correct paintshop position lookup for outdoor bay"
```

---

## Task 4: Dyno (Power Bench) Sync

**Files:**
- Modify: `Shared/PacketTypes.cs` — add `dynoRun`
- Create: `ClientSide/Data/Garage/Tools/DynoLogic.cs`
- Modify: `ServerSide/Data/ServerData.cs` — add `dynoCarLoaderID` field
- Modify: `ServerSide/Data/ServerHandle.cs` — add `DynoRunPacket`
- Modify: `ServerSide/Data/ServerSend.cs` — add `DynoRunPacket`
- Modify: `ClientSide/Data/Handle/ClientSend.cs` — add `DynoRunPacket`
- Modify: `ClientSide/Data/Handle/ClientHandle.cs` — add `DynoRunPacket`
- Modify: `ClientSide/Client.cs` — register `dynoRun` handler

**Interfaces:**
- `DynoManager.m_instance` — the static singleton for DynoManager
- `DynoManager.m_instance.CarLoader` — `CarLoader` currently in the dyno
- `DynoManager.m_instance.RunDyno()` — starts the dyno run (has a `canRunDyno` guard internally)
- Produces: `ClientSend.DynoRunPacket(int carLoaderID)`, `ClientHandle.DynoRunPacket(Packet)`

---

- [ ] **Step 1: Add `dynoRun` to `PacketTypes.cs`**

Open `Shared/PacketTypes.cs`. Add `dynoRun` to the enum, after `carEngineSound`:
```csharp
public enum PacketTypes { connect, handshake, disconnect, userData, readyState, start, spawn, position, rotation, item, groupItem, stat, lifter, loadJobCar, loadCar, bodyPart, partScript, deleteCar, carPosition, garageUpgrade, newJob, jobAction, selectedJob, sceneChange, contentInfo, toolMove, setSpringClamp, clearSpringClamp, setTireChanger, clearTireChanger, wheelBalance, endJob, oilBinUse, engineCrane, skillChange, engineStandAngle, engineStandSetGroup, engineStandTakeOff, carFluid, exp, point, resync, carWash, carPaint, useWelder, repairPart, parkAdd, parkRemove, playerInCar, carEngineSound, dynoRun }
```

- [ ] **Step 2: Create `DynoLogic.cs`**

Create `ClientSide/Data/Garage/Tools/DynoLogic.cs`:

```csharp
using CMS21Together.ClientSide.Data.Handle;
using HarmonyLib;
using MelonLoader;

namespace CMS21Together.ClientSide.Data.Garage.Tools;

[HarmonyPatch]
public static class DynoLogic
{
    public static bool listen = true;

    public static void Reset() => listen = true;

    [HarmonyPatch(typeof(DynoManager), nameof(DynoManager.RunDyno))]
    [HarmonyPostfix]
    public static void RunDynoHook()
    {
        if (!Client.Instance.isConnected || !listen)
        {
            listen = true;
            return;
        }

        var dyno = DynoManager.m_instance;
        if (dyno == null || dyno.CarLoader == null)
        {
            MelonLogger.Warning("[DynoLogic->RunDynoHook] DynoManager or CarLoader is null.");
            return;
        }

        var cl = dyno.CarLoader;
        if (cl.gameObject == null || cl.gameObject.name.Length < 11)
        {
            MelonLogger.Warning("[DynoLogic->RunDynoHook] Invalid CarLoader gameObject name.");
            return;
        }

        int carLoaderID = cl.gameObject.name[10] - '0' - 1;
        if (carLoaderID < 0 || carLoaderID >= 5)
        {
            MelonLogger.Warning($"[DynoLogic->RunDynoHook] Invalid carLoaderID: {carLoaderID}");
            return;
        }

        ClientSend.DynoRunPacket(carLoaderID);
        MelonLogger.Msg($"[DynoLogic->RunDynoHook] Dyno run sent for carLoaderID: {carLoaderID}");
    }

    public static System.Collections.IEnumerator ApplyDynoRun(int carLoaderID)
    {
        while (!ClientData.GameReady)
            yield return new UnityEngine.WaitForSeconds(0.25f);
        yield return new UnityEngine.WaitForEndOfFrame();

        var dyno = DynoManager.m_instance;
        if (dyno == null)
        {
            MelonLogger.Warning("[DynoLogic->ApplyDynoRun] DynoManager is null.");
            yield break;
        }

        listen = false;
        dyno.canRunDyno = true;
        dyno.RunDyno();
        MelonLogger.Msg($"[DynoLogic->ApplyDynoRun] Applied dyno run for carLoaderID: {carLoaderID}");
    }
}
```

- [ ] **Step 3: Add `dynoCarLoaderID` to `ServerData.cs`**

Open `ServerSide/Data/ServerData.cs`. Add to the fields section after `engineStand2Angle`:
```csharp
public int dynoCarLoaderID = -1;
```

- [ ] **Step 4: Add `DynoRunPacket` to `ServerHandle.cs`**

Open `ServerSide/Data/ServerHandle.cs`. Add after the `CarWashPacket` method:
```csharp
public static void DynoRunPacket(int fromClient, Packet packet)
{
    int carLoaderID = packet.ReadInt();
    ServerData.Instance.dynoCarLoaderID = carLoaderID;
    ServerSend.DynoRunPacket(fromClient, carLoaderID);
}
```

- [ ] **Step 5: Add `DynoRunPacket` to `ServerSend.cs`**

Open `ServerSide/Data/ServerSend.cs`. Add after `CarWashPacket`:
```csharp
public static void DynoRunPacket(int fromClient, int carLoaderID)
{
    using (var packet = new Packet((int)PacketTypes.dynoRun))
    {
        packet.Write(carLoaderID);
        SendDataToAll(fromClient, packet);
    }
}
```

- [ ] **Step 6: Add `DynoRunPacket` to `ClientSend.cs`**

Open `ClientSide/Data/Handle/ClientSend.cs`. Add after `CarWashPacket`:
```csharp
public static void DynoRunPacket(int carLoaderID)
{
    using (var packet = new Packet((int)PacketTypes.dynoRun))
    {
        packet.Write(carLoaderID);
        SendData(packet);
    }
}
```

- [ ] **Step 7: Add `DynoRunPacket` to `ClientHandle.cs`**

Open `ClientSide/Data/Handle/ClientHandle.cs`. Add after `CarWashPacket`:
```csharp
public static void DynoRunPacket(Packet _packet)
{
    int carLoaderID = _packet.ReadInt();
    MelonCoroutines.Start(Garage.Tools.DynoLogic.ApplyDynoRun(carLoaderID));
}
```

- [ ] **Step 8: Register handler in `Client.cs`**

Open `ClientSide/Client.cs`. In `InitializeClientData`, add to the `PacketHandlers` dictionary after `carEngineSound`:
```csharp
{ (int)PacketTypes.dynoRun, ClientHandle.DynoRunPacket },
```

- [ ] **Step 9: Build and deploy**

- [ ] **Step 10: Manual test**

Drive a car onto the dyno and start a run as Player A. Verify the dyno animation plays on Player B's screen.

- [ ] **Step 11: Commit**

```bash
git add Shared/PacketTypes.cs ClientSide/Data/Garage/Tools/DynoLogic.cs ServerSide/Data/ServerData.cs ServerSide/Data/ServerHandle.cs ServerSide/Data/ServerSend.cs ClientSide/Data/Handle/ClientSend.cs ClientSide/Data/Handle/ClientHandle.cs ClientSide/Client.cs
git commit -m "feat: sync dyno/power bench runs to remote clients"
```

---

## Task 5: Wheel Alignment Sync

**Files:**
- Modify: `Shared/PacketTypes.cs` — add `wheelAlignment`
- Create: `ClientSide/Data/Garage/Tools/WheelAlignmentLogic.cs`
- Modify: `ServerSide/Data/ServerData.cs` — update `CarSpawnDatas` entry in handler
- Modify: `ServerSide/Data/ServerHandle.cs` — add `WheelAlignmentPacket`
- Modify: `ServerSide/Data/ServerSend.cs` — add `WheelAlignmentPacket`
- Modify: `ClientSide/Data/Handle/ClientSend.cs` — add `WheelAlignmentPacket`
- Modify: `ClientSide/Data/Handle/ClientHandle.cs` — add `WheelAlignmentPacket`
- Modify: `ClientSide/Client.cs` — register `wheelAlignment` handler

**Interfaces:**
- `WheelsAlignmentWindow.carLoader` — `CarLoader` property (accessible as `__instance.carLoader` in Postfix)
- `carLoader.WheelsAlignment` — `WheelsAlignment` struct with properties `FL, FR, RL, RR` (float)
- `ModWheelsAlignmentData` struct — `FL, FR, RL, RR` float fields; `ToGame(ModWheelsAlignmentData)` returns `WheelsAlignmentData`; `WheelsAlignment(WheelsAlignmentData)` constructor converts back to game struct
- Produces: `ClientSend.WheelAlignmentPacket(int, ModWheelsAlignmentData)`, `ClientHandle.WheelAlignmentPacket(Packet)`

---

- [ ] **Step 1: Add `wheelAlignment` to `PacketTypes.cs`**

Append `wheelAlignment` to the enum (after `dynoRun`):
```csharp
... dynoRun, wheelAlignment }
```

- [ ] **Step 2: Create `WheelAlignmentLogic.cs`**

Create `ClientSide/Data/Garage/Tools/WheelAlignmentLogic.cs`:

```csharp
using System.Collections;
using CMS.UI.Windows;
using CMS21Together.ClientSide.Data.Handle;
using CMS21Together.Shared.Data.Vanilla.Cars;
using HarmonyLib;
using MelonLoader;
using UnityEngine;

namespace CMS21Together.ClientSide.Data.Garage.Tools;

[HarmonyPatch]
public static class WheelAlignmentLogic
{
    public static bool listen = true;

    public static void Reset() => listen = true;

    [HarmonyPatch(typeof(WheelsAlignmentWindow), nameof(WheelsAlignmentWindow.UpdateCarWheelAlignment))]
    [HarmonyPostfix]
    public static void UpdateCarWheelAlignmentHook(WheelsAlignmentWindow __instance)
    {
        if (!Client.Instance.isConnected || !listen)
        {
            listen = true;
            return;
        }

        var cl = __instance?.carLoader;
        if (cl == null || cl.gameObject == null || cl.gameObject.name.Length < 11)
        {
            MelonLogger.Warning("[WheelAlignmentLogic] Invalid CarLoader.");
            return;
        }

        int carLoaderID = cl.gameObject.name[10] - '0' - 1;
        if (carLoaderID < 0 || carLoaderID >= 5)
        {
            MelonLogger.Warning($"[WheelAlignmentLogic] Invalid carLoaderID: {carLoaderID}");
            return;
        }

        var wa = cl.WheelsAlignment;
        var modData = new ModWheelsAlignmentData { FL = wa.FL, FR = wa.FR, RL = wa.RL, RR = wa.RR };

        ClientSend.WheelAlignmentPacket(carLoaderID, modData);
        MelonLogger.Msg($"[WheelAlignmentLogic] Alignment sent for carLoaderID: {carLoaderID}");
    }

    public static IEnumerator ApplyWheelAlignment(int carLoaderID, ModWheelsAlignmentData modData)
    {
        while (!ClientData.GameReady)
            yield return new WaitForSeconds(0.25f);
        yield return new WaitForEndOfFrame();

        if (carLoaderID < 0 || carLoaderID >= GameData.Instance.carLoaders.Length)
        {
            MelonLogger.Warning($"[WheelAlignmentLogic] Invalid carLoaderID: {carLoaderID}");
            yield break;
        }

        var cl = GameData.Instance.carLoaders[carLoaderID];
        if (cl == null) yield break;

        listen = false;
        var alignData = modData.ToGame(modData);
        cl.WheelsAlignment = new WheelsAlignment(alignData);

        if (ClientData.Instance.loadedCars.TryGetValue(carLoaderID, out var car))
            car.wheelsAlignmentData = modData;

        MelonLogger.Msg($"[WheelAlignmentLogic] Applied alignment for carLoaderID: {carLoaderID}");
    }
}
```

- [ ] **Step 3: Add `WheelAlignmentPacket` to `ServerHandle.cs`**

```csharp
public static void WheelAlignmentPacket(int fromClient, Packet packet)
{
    int carLoaderID = packet.ReadInt();
    var data = packet.Read<ModWheelsAlignmentData>();

    if (ServerData.Instance.CarSpawnDatas.ContainsKey(carLoaderID))
        ServerData.Instance.CarSpawnDatas[carLoaderID].wheelsAlignmentData = data;

    ServerSend.WheelAlignmentPacket(fromClient, carLoaderID, data);
}
```

- [ ] **Step 4: Add `WheelAlignmentPacket` to `ServerSend.cs`**

```csharp
public static void WheelAlignmentPacket(int fromClient, int carLoaderID, ModWheelsAlignmentData data)
{
    using (var packet = new Packet((int)PacketTypes.wheelAlignment))
    {
        packet.Write(carLoaderID);
        packet.Write(data);
        SendDataToAll(fromClient, packet);
    }
}
```

- [ ] **Step 5: Add `WheelAlignmentPacket` to `ClientSend.cs`**

```csharp
public static void WheelAlignmentPacket(int carLoaderID, ModWheelsAlignmentData data)
{
    using (var packet = new Packet((int)PacketTypes.wheelAlignment))
    {
        packet.Write(carLoaderID);
        packet.Write(data);
        SendData(packet);
    }
}
```

- [ ] **Step 6: Add `WheelAlignmentPacket` to `ClientHandle.cs`**

```csharp
public static void WheelAlignmentPacket(Packet _packet)
{
    int carLoaderID = _packet.ReadInt();
    var data = _packet.Read<ModWheelsAlignmentData>();
    MelonCoroutines.Start(Garage.Tools.WheelAlignmentLogic.ApplyWheelAlignment(carLoaderID, data));
}
```

- [ ] **Step 7: Register handler in `Client.cs`**

Add after the `dynoRun` entry:
```csharp
{ (int)PacketTypes.wheelAlignment, ClientHandle.WheelAlignmentPacket },
```

- [ ] **Step 8: Build and deploy**

- [ ] **Step 9: Manual test**

Drive a car to the wheel alignment rack. Player A adjusts and applies alignment. Verify Player B sees the alignment values change on their screen (open alignment window or inspect car data).

- [ ] **Step 10: Commit**

```bash
git add Shared/PacketTypes.cs ClientSide/Data/Garage/Tools/WheelAlignmentLogic.cs ServerSide/Data/ServerHandle.cs ServerSide/Data/ServerSend.cs ClientSide/Data/Handle/ClientSend.cs ClientSide/Data/Handle/ClientHandle.cs ClientSide/Client.cs
git commit -m "feat: sync wheel alignment changes to remote clients"
```

---

## Task 6: Headlamp Alignment Sync

**Files:**
- Modify: `Shared/PacketTypes.cs` — add `headlampAlignment`
- Create: `ClientSide/Data/Garage/Tools/HeadlampAlignmentLogic.cs`
- Modify: `ServerSide/Data/ServerHandle.cs` — add `HeadlampAlignmentPacket`
- Modify: `ServerSide/Data/ServerSend.cs` — add `HeadlampAlignmentPacket`
- Modify: `ClientSide/Data/Handle/ClientSend.cs` — add `HeadlampAlignmentPacket`
- Modify: `ClientSide/Data/Handle/ClientHandle.cs` — add `HeadlampAlignmentPacket`
- Modify: `ClientSide/Client.cs` — register `headlampAlignment` handler

**Interfaces:**
- `LampAlignmentWindow.carLoader` — `CarLoader` property on `__instance`
- `carLoader.HeadlampLeftAlignment` / `carLoader.HeadlampRightAlignment` — `HeadlampAlignment` struct with `Horizontal`, `Vertical` properties
- `ModHeadLampAlignmentData` struct — `Horizontal`, `Vertical` float fields; `ToGame()` returns `HeadlampAlignmentData`; `HeadlampAlignment(HeadlampAlignmentData)` converts back
- `ModNewCarData.HeadLampLeftAlignmentData` / `ModNewCarData.HeadlampRightAlignmentData` — fields to update in `ModCar` stored data
- Produces: `ClientSend.HeadlampAlignmentPacket(int, ModHeadLampAlignmentData, ModHeadLampAlignmentData)`, `ClientHandle.HeadlampAlignmentPacket(Packet)`

---

- [ ] **Step 1: Add `headlampAlignment` to `PacketTypes.cs`**

Append after `wheelAlignment`:
```csharp
... wheelAlignment, headlampAlignment }
```

- [ ] **Step 2: Create `HeadlampAlignmentLogic.cs`**

Create `ClientSide/Data/Garage/Tools/HeadlampAlignmentLogic.cs`:

```csharp
using System.Collections;
using CMS.UI.Windows;
using CMS21Together.ClientSide.Data.Handle;
using CMS21Together.Shared.Data.Vanilla.Cars;
using HarmonyLib;
using MelonLoader;
using UnityEngine;

namespace CMS21Together.ClientSide.Data.Garage.Tools;

[HarmonyPatch]
public static class HeadlampAlignmentLogic
{
    public static bool listen = true;

    public static void Reset() => listen = true;

    [HarmonyPatch(typeof(LampAlignmentWindow), nameof(LampAlignmentWindow.ChangeLamp))]
    [HarmonyPostfix]
    public static void ChangeLampHook(LampAlignmentWindow __instance)
    {
        if (!Client.Instance.isConnected || !listen)
        {
            listen = true;
            return;
        }

        var cl = __instance?.carLoader;
        if (cl == null || cl.gameObject == null || cl.gameObject.name.Length < 11)
        {
            MelonLogger.Warning("[HeadlampAlignmentLogic] Invalid CarLoader.");
            return;
        }

        int carLoaderID = cl.gameObject.name[10] - '0' - 1;
        if (carLoaderID < 0 || carLoaderID >= 5)
        {
            MelonLogger.Warning($"[HeadlampAlignmentLogic] Invalid carLoaderID: {carLoaderID}");
            return;
        }

        var la = cl.HeadlampLeftAlignment;
        var ra = cl.HeadlampRightAlignment;
        var modLeft  = new ModHeadLampAlignmentData { Horizontal = la.Horizontal, Vertical = la.Vertical };
        var modRight = new ModHeadLampAlignmentData { Horizontal = ra.Horizontal, Vertical = ra.Vertical };

        ClientSend.HeadlampAlignmentPacket(carLoaderID, modLeft, modRight);
        MelonLogger.Msg($"[HeadlampAlignmentLogic] Headlamp alignment sent for carLoaderID: {carLoaderID}");
    }

    public static IEnumerator ApplyHeadlampAlignment(int carLoaderID, ModHeadLampAlignmentData modLeft, ModHeadLampAlignmentData modRight)
    {
        while (!ClientData.GameReady)
            yield return new WaitForSeconds(0.25f);
        yield return new WaitForEndOfFrame();

        if (carLoaderID < 0 || carLoaderID >= GameData.Instance.carLoaders.Length)
        {
            MelonLogger.Warning($"[HeadlampAlignmentLogic] Invalid carLoaderID: {carLoaderID}");
            yield break;
        }

        var cl = GameData.Instance.carLoaders[carLoaderID];
        if (cl == null) yield break;

        listen = false;
        cl.HeadlampLeftAlignment  = new HeadlampAlignment(modLeft.ToGame());
        cl.HeadlampRightAlignment = new HeadlampAlignment(modRight.ToGame());

        if (ClientData.Instance.loadedCars.TryGetValue(carLoaderID, out var car))
        {
            car.HeadLampLeftAlignmentData  = modLeft;
            car.HeadlampRightAlignmentData = modRight;
        }

        MelonLogger.Msg($"[HeadlampAlignmentLogic] Applied headlamp alignment for carLoaderID: {carLoaderID}");
    }
}
```

> **Note:** `ClientData.Instance.loadedCars` holds `ModCar` objects, not `ModNewCarData`. Verify that `ModCar` has `HeadLampLeftAlignmentData` / `HeadlampRightAlignmentData` fields. If `ModCar` stores a `ModNewCarData`, update via `car.carData.HeadLampLeftAlignmentData = modLeft`. Check during implementation and adjust field access accordingly.

- [ ] **Step 3: Add `HeadlampAlignmentPacket` to `ServerHandle.cs`**

```csharp
public static void HeadlampAlignmentPacket(int fromClient, Packet packet)
{
    int carLoaderID = packet.ReadInt();
    var left  = packet.Read<ModHeadLampAlignmentData>();
    var right = packet.Read<ModHeadLampAlignmentData>();

    if (ServerData.Instance.CarSpawnDatas.ContainsKey(carLoaderID))
    {
        ServerData.Instance.CarSpawnDatas[carLoaderID].HeadLampLeftAlignmentData  = left;
        ServerData.Instance.CarSpawnDatas[carLoaderID].HeadlampRightAlignmentData = right;
    }

    ServerSend.HeadlampAlignmentPacket(fromClient, carLoaderID, left, right);
}
```

- [ ] **Step 4: Add `HeadlampAlignmentPacket` to `ServerSend.cs`**

```csharp
public static void HeadlampAlignmentPacket(int fromClient, int carLoaderID, ModHeadLampAlignmentData left, ModHeadLampAlignmentData right)
{
    using (var packet = new Packet((int)PacketTypes.headlampAlignment))
    {
        packet.Write(carLoaderID);
        packet.Write(left);
        packet.Write(right);
        SendDataToAll(fromClient, packet);
    }
}
```

- [ ] **Step 5: Add `HeadlampAlignmentPacket` to `ClientSend.cs`**

```csharp
public static void HeadlampAlignmentPacket(int carLoaderID, ModHeadLampAlignmentData left, ModHeadLampAlignmentData right)
{
    using (var packet = new Packet((int)PacketTypes.headlampAlignment))
    {
        packet.Write(carLoaderID);
        packet.Write(left);
        packet.Write(right);
        SendData(packet);
    }
}
```

- [ ] **Step 6: Add `HeadlampAlignmentPacket` to `ClientHandle.cs`**

```csharp
public static void HeadlampAlignmentPacket(Packet _packet)
{
    int carLoaderID = _packet.ReadInt();
    var left  = _packet.Read<ModHeadLampAlignmentData>();
    var right = _packet.Read<ModHeadLampAlignmentData>();
    MelonCoroutines.Start(Garage.Tools.HeadlampAlignmentLogic.ApplyHeadlampAlignment(carLoaderID, left, right));
}
```

- [ ] **Step 7: Register handler in `Client.cs`**

Add after `wheelAlignment`:
```csharp
{ (int)PacketTypes.headlampAlignment, ClientHandle.HeadlampAlignmentPacket },
```

- [ ] **Step 8: Build and deploy**

- [ ] **Step 9: Manual test**

Load a car, open the headlamp alignment tool, adjust a lamp and confirm. Verify Player B sees the lamp angle change on their screen.

- [ ] **Step 10: Commit**

```bash
git add Shared/PacketTypes.cs ClientSide/Data/Garage/Tools/HeadlampAlignmentLogic.cs ServerSide/Data/ServerHandle.cs ServerSide/Data/ServerSend.cs ClientSide/Data/Handle/ClientSend.cs ClientSide/Data/Handle/ClientHandle.cs ClientSide/Client.cs
git commit -m "feat: sync headlamp alignment changes to remote clients"
```

---

## Task 7: Garage Customization Sync

**Files:**
- Modify: `Shared/PacketTypes.cs` — add `garageCustomization`
- Create: `Shared/Data/Vanilla/ModGarageLook.cs`
- Create: `ClientSide/Data/Garage/GarageCustomizationLogic.cs`
- Modify: `ServerSide/Data/ServerData.cs` — add `garageLook` dictionary
- Modify: `ServerSide/Data/ServerHandle.cs` — add `GarageCustomizationPacket`
- Modify: `ServerSide/Data/ServerSend.cs` — add `GarageCustomizationPacket` (resync and live)
- Modify: `ServerSide/Data/ServerResyncs.cs` — add `ResyncGarageLook`
- Modify: `ServerSide/Data/ServerHandle.cs` — add `garageCustomization` case to `ResyncPacket`
- Modify: `ClientSide/Data/Handle/ClientSend.cs` — add `GarageCustomizationPacket` + `ResyncGarageLook`
- Modify: `ClientSide/Data/Handle/ClientHandle.cs` — add `GarageCustomizationPacket`
- Modify: `ClientSide/Client.cs` — register `garageCustomization` handler
- Modify: `ClientSide/Data/Garage/GarageResync.cs` — call `ResyncGarageLook`

**Interfaces:**
- `GarageLookManager.instance` — static singleton for the garage look manager
- `GarageLookManager.SetMaterialIndexForSection(int sectionIndex, int materialIndex)` — the method to hook and to call on receive
- Produces: `ClientSend.GarageCustomizationPacket(int, int)`, `ClientSend.ResyncGarageLook()`, `ClientHandle.GarageCustomizationPacket(Packet)`

---

- [ ] **Step 1: Add `garageCustomization` to `PacketTypes.cs`**

Append after `headlampAlignment`:
```csharp
... headlampAlignment, garageCustomization }
```

- [ ] **Step 2: Create `Shared/Data/Vanilla/ModGarageLook.cs`**

```csharp
using System;

namespace CMS21Together.Shared.Data.Vanilla;

[Serializable]
public class ModGarageLook
{
    public int sectionIndex;
    public int materialIndex;
}
```

- [ ] **Step 3: Add `garageLook` to `ServerData.cs`**

Add to the fields section after `garageUpgrades`:
```csharp
public Dictionary<int, int> garageLook = new();
```

- [ ] **Step 4: Create `GarageCustomizationLogic.cs`**

Create `ClientSide/Data/Garage/GarageCustomizationLogic.cs`:

```csharp
using System.Collections;
using CMS.Garage.Customization;
using CMS21Together.ClientSide.Data.Handle;
using HarmonyLib;
using MelonLoader;
using UnityEngine;

namespace CMS21Together.ClientSide.Data.Garage;

[HarmonyPatch]
public static class GarageCustomizationLogic
{
    public static bool listen = true;

    public static void Reset() => listen = true;

    [HarmonyPatch(typeof(GarageLookManager), nameof(GarageLookManager.SetMaterialIndexForSection))]
    [HarmonyPostfix]
    public static void SetMaterialIndexForSectionHook(int sectionIndex, int materialIndex)
    {
        if (!Client.Instance.isConnected || !listen)
        {
            listen = true;
            return;
        }

        ClientSend.GarageCustomizationPacket(sectionIndex, materialIndex);
        MelonLogger.Msg($"[GarageCustomizationLogic] Section {sectionIndex} material {materialIndex} sent.");
    }

    public static IEnumerator ApplyGarageLook(int sectionIndex, int materialIndex)
    {
        while (!ClientData.GameReady)
            yield return new WaitForSeconds(0.25f);
        yield return new WaitForEndOfFrame();

        var mgr = GarageLookManager.instance;
        if (mgr == null)
        {
            MelonLogger.Warning("[GarageCustomizationLogic] GarageLookManager.instance is null.");
            yield break;
        }

        listen = false;
        mgr.SetMaterialIndexForSection(sectionIndex, materialIndex);
        MelonLogger.Msg($"[GarageCustomizationLogic] Applied section {sectionIndex} material {materialIndex}.");
    }
}
```

- [ ] **Step 5: Add `GarageCustomizationPacket` to `ServerHandle.cs`**

```csharp
public static void GarageCustomizationPacket(int fromClient, Packet packet)
{
    int sectionIndex  = packet.ReadInt();
    int materialIndex = packet.ReadInt();

    ServerData.Instance.garageLook[sectionIndex] = materialIndex;
    ServerSend.GarageCustomizationPacket(fromClient, sectionIndex, materialIndex);
}
```

Also add to the `ResyncPacket` switch:
```csharp
case PacketTypes.garageCustomization:
    ServerResyncs.ResyncGarageLook(fromClient);
    break;
```

- [ ] **Step 6: Add `GarageCustomizationPacket` and resync to `ServerSend.cs`**

```csharp
public static void GarageCustomizationPacket(int fromClient, int sectionIndex, int materialIndex, bool resync = false)
{
    using (var packet = new Packet((int)PacketTypes.garageCustomization))
    {
        packet.Write(sectionIndex);
        packet.Write(materialIndex);

        if (resync) SendData(fromClient, packet);
        else        SendDataToAll(fromClient, packet);
    }
}
```

- [ ] **Step 7: Add `ResyncGarageLook` to `ServerResyncs.cs`**

```csharp
public static void ResyncGarageLook(int fromClient)
{
    foreach (var kvp in ServerData.Instance.garageLook)
        ServerSend.GarageCustomizationPacket(fromClient, kvp.Key, kvp.Value, resync: true);

    MelonLogger.Msg("[ServerResyncs] Sent garage look resync.");
}
```

- [ ] **Step 8: Add methods to `ClientSend.cs`**

```csharp
public static void GarageCustomizationPacket(int sectionIndex, int materialIndex)
{
    using (var packet = new Packet((int)PacketTypes.garageCustomization))
    {
        packet.Write(sectionIndex);
        packet.Write(materialIndex);
        SendData(packet);
    }
}

public static void ResyncGarageLook()
{
    using (var packet = new Packet((int)PacketTypes.resync))
    {
        packet.Write(PacketTypes.garageCustomization);
        SendData(packet);
    }
}
```

- [ ] **Step 9: Add `GarageCustomizationPacket` to `ClientHandle.cs`**

```csharp
public static void GarageCustomizationPacket(Packet _packet)
{
    int sectionIndex  = _packet.ReadInt();
    int materialIndex = _packet.ReadInt();
    MelonCoroutines.Start(Garage.GarageCustomizationLogic.ApplyGarageLook(sectionIndex, materialIndex));
}
```

- [ ] **Step 10: Register handler in `Client.cs`**

Add after `headlampAlignment`:
```csharp
{ (int)PacketTypes.garageCustomization, ClientHandle.GarageCustomizationPacket },
```

- [ ] **Step 11: Add resync call to `GarageResync.cs`**

Open `ClientSide/Data/Garage/GarageResync.cs`. In `ResyncGarage()`, after `ClientSend.ResyncUpgrade()`:
```csharp
yield return new WaitForEndOfFrame();
ClientSend.ResyncGarageLook();
```

- [ ] **Step 12: Build and deploy**

- [ ] **Step 13: Manual test**

Player A opens garage customization and changes the floor material. Verify Player B's garage floor updates in real-time. Also: Player B disconnects and rejoins — verify the floor material matches Player A's selection.

- [ ] **Step 14: Commit**

```bash
git add Shared/PacketTypes.cs Shared/Data/Vanilla/ModGarageLook.cs ClientSide/Data/Garage/GarageCustomizationLogic.cs ServerSide/Data/ServerData.cs ServerSide/Data/ServerHandle.cs ServerSide/Data/ServerSend.cs ServerSide/Data/ServerResyncs.cs ClientSide/Data/Handle/ClientSend.cs ClientSide/Data/Handle/ClientHandle.cs ClientSide/Client.cs ClientSide/Data/Garage/GarageResync.cs
git commit -m "feat: sync garage customization to remote clients with resync on join"
```

---

## Task 8: Shared Skill Upgrades

**Files:**
- Modify: `ServerSide/Data/ServerData.cs` — add `sharedSkills` dictionary
- Modify: `ServerSide/Data/ServerHandle.cs` — update `SkillChangePacket` to broadcast
- Modify: `ServerSide/Data/ServerSend.cs` — add broadcast `SkillChangePacket`
- Modify: `ServerSide/Data/ServerResyncs.cs` — add `ResyncSkills`
- Modify: `ServerSide/Data/ServerHandle.cs` — add `skillChange` case to `ResyncPacket`
- Modify: `ClientSide/Data/Handle/ClientSend.cs` — add `ResyncSkills`
- Modify: `ClientSide/Data/Handle/ClientHandle.cs` — add `SkillChangePacket`
- Modify: `ClientSide/Client.cs` — register `skillChange` handler
- Modify: `ClientSide/Data/Garage/GarageResync.cs` — call `ResyncSkills`

**Interfaces:**
- `SkillUpgradeHook.listen` — the existing bool flag in `ClientSide/Data/Garage/Campaign/SkillUpgradeHook.cs` (prevents re-broadcast when applying received skills)
- `GameData.Instance.upgradeTools.upgradeSystem` — the `UpgradeSystem` for unlocking skills
- `upgradeSystem.UnlockUpgrade(string id, int level, UpgradeType type)` — call with `UpgradeType.Money` and `listen = false` to apply without re-broadcast or double-charge
- Produces: `ClientHandle.SkillChangePacket(Packet)`, `ClientSend.ResyncSkills()`

---

- [ ] **Step 1: Add `sharedSkills` to `ServerData.cs`**

Add to the fields section after `garageUpgrades`:
```csharp
public Dictionary<string, List<bool>> sharedSkills = new();
```

- [ ] **Step 2: Update `SkillChangePacket` in `ServerHandle.cs`**

Open `ServerSide/Data/ServerHandle.cs`. Replace the existing `SkillChangePacket` method:
```csharp
public static void SkillChangePacket(int fromClient, Packet packet)
{
    string playerID = packet.Read<string>();
    string id       = packet.Read<string>();
    List<bool> skill = packet.Read<List<bool>>();

    SavesManager.ModSaves[SavesManager.currentSaveIndex].playerInfos
        .First(p => playerID == p.id).UpdateSkill(id, skill);

    ServerData.Instance.sharedSkills[id] = skill;
    ServerSend.SkillChangePacket(fromClient, id, skill);
}
```

Also add `skillChange` to the `ResyncPacket` switch:
```csharp
case PacketTypes.skillChange:
    ServerResyncs.ResyncSkills(fromClient);
    break;
```

- [ ] **Step 3: Add broadcast `SkillChangePacket` to `ServerSend.cs`**

```csharp
public static void SkillChangePacket(int fromClient, string id, List<bool> skill)
{
    using (var packet = new Packet((int)PacketTypes.skillChange))
    {
        packet.Write(id);
        packet.Write(skill);
        SendDataToAll(fromClient, packet);
    }
}
```

- [ ] **Step 4: Add `ResyncSkills` to `ServerResyncs.cs`**

```csharp
public static void ResyncSkills(int fromClient)
{
    foreach (var kvp in ServerData.Instance.sharedSkills)
    {
        using (var packet = new Packet((int)PacketTypes.skillChange))
        {
            packet.Write(kvp.Key);
            packet.Write(kvp.Value);
            ServerSend.SendData(fromClient, packet);
        }
    }
    MelonLogger.Msg("[ServerResyncs] Sent skills resync.");
}
```

> **Note:** `ServerSend.SendData` may be `private static`. If so, add a `public static void SendDataDirect(int toClient, Packet packet)` wrapper that calls `SendData(toClient, packet)`, or replicate the pattern used by `ResyncUpgrade` which calls `ServerSend.GarageUpgradePacket(fromClient, upgrade, true)` — use `ServerSend.SkillChangePacket` with a `resync` bool parameter instead:

Alternative if `SendData` is private — add a `resync` overload to `ServerSend.SkillChangePacket`:
```csharp
public static void SkillChangePacket(int toClient, string id, List<bool> skill, bool resync)
{
    using (var packet = new Packet((int)PacketTypes.skillChange))
    {
        packet.Write(id);
        packet.Write(skill);
        if (resync) SendData(toClient, packet);
        else        SendDataToAll(toClient, packet);
    }
}
```
And call from `ResyncSkills` as: `ServerSend.SkillChangePacket(fromClient, kvp.Key, kvp.Value, resync: true);`

- [ ] **Step 5: Add `ResyncSkills` to `ClientSend.cs`**

```csharp
public static void ResyncSkills()
{
    using (var packet = new Packet((int)PacketTypes.resync))
    {
        packet.Write(PacketTypes.skillChange);
        SendData(packet);
    }
}
```

- [ ] **Step 6: Add `SkillChangePacket` to `ClientHandle.cs`**

```csharp
public static void SkillChangePacket(Packet _packet)
{
    string id        = _packet.Read<string>();
    List<bool> skill = _packet.Read<List<bool>>();
    MelonCoroutines.Start(ApplySkillChange(id, skill));
}

private static System.Collections.IEnumerator ApplySkillChange(string id, List<bool> skill)
{
    while (!ClientData.GameReady)
        yield return new UnityEngine.WaitForSeconds(0.25f);
    yield return new UnityEngine.WaitForEndOfFrame();

    if (GameData.Instance?.upgradeTools?.upgradeSystem == null)
    {
        MelonLogger.Warning("[ClientHandle->ApplySkillChange] upgradeSystem is null.");
        yield break;
    }

    CMS21Together.ClientSide.Data.Garage.Campaign.SkillUpgradeHook.listen = false;
    var upgradeSystem = GameData.Instance.upgradeTools.upgradeSystem;

    for (int lvl = 0; lvl < skill.Count; lvl++)
    {
        if (skill[lvl])
            upgradeSystem.UnlockUpgrade(id, lvl, UpgradeType.Money);
    }

    CMS21Together.ClientSide.Data.Garage.Campaign.SkillUpgradeHook.listen = true;
    MelonLogger.Msg($"[ClientHandle->ApplySkillChange] Applied skill: {id}");
}
```

- [ ] **Step 7: Register `skillChange` handler in `Client.cs`**

Add after `carEngineSound`:
```csharp
{ (int)PacketTypes.skillChange, ClientHandle.SkillChangePacket },
```

- [ ] **Step 8: Add resync call to `GarageResync.cs`**

In `ResyncGarage()`, after `ClientSend.ResyncGarageLook()`:
```csharp
yield return new WaitForEndOfFrame();
ClientSend.ResyncSkills();
```

- [ ] **Step 9: Build and deploy**

- [ ] **Step 10: Manual test — live broadcast**

Player A purchases a skill upgrade (e.g., faster drill tier 1). Verify Player B's drill animation speed increases without needing to rejoin.

- [ ] **Step 11: Manual test — resync on join**

Player A purchases a skill. Player B disconnects and rejoins. Verify Player B's skills match Player A's after rejoining.

- [ ] **Step 12: Commit**

```bash
git add ServerSide/Data/ServerData.cs ServerSide/Data/ServerHandle.cs ServerSide/Data/ServerSend.cs ServerSide/Data/ServerResyncs.cs ClientSide/Data/Handle/ClientSend.cs ClientSide/Data/Handle/ClientHandle.cs ClientSide/Client.cs ClientSide/Data/Garage/GarageResync.cs
git commit -m "feat: share skill upgrades across all clients with broadcast and resync"
```

---

## Self-Review

**Spec coverage check:**

| Spec requirement | Task |
|---|---|
| Shared money fix | Task 1 |
| Fluid sync | Task 1 |
| Outdoor car wash | Task 2 |
| Car paint position verify | Task 3 |
| Dyno sync | Task 4 |
| Wheel alignment sync | Task 5 |
| Headlamp alignment sync | Task 6 |
| Garage customization + resync | Task 7 |
| Shared skill upgrades (live + resync) | Task 8 |
| Garage building upgrades | Verified as working — no task |

All 9 actionable spec sections covered. ✓

**Placeholder scan:** None. All steps include complete code. ✓

**Type consistency:**
- `ModWheelsAlignmentData` — created with `{ FL, FR, RL, RR }` initializer; applied via `ToGame(modData)` then `new WheelsAlignment(alignData)`. Consistent across Tasks 5. ✓
- `ModHeadLampAlignmentData` — created with `{ Horizontal, Vertical }` initializer; applied via `ToGame()` then `new HeadlampAlignment(data)`. Consistent across Task 6. ✓
- `DynoManager.m_instance` — used consistently in Task 4 (hook and apply). ✓
- `GarageLookManager.instance` — used consistently in Task 7. ✓
- `PacketTypes` additions: `dynoRun`, `wheelAlignment`, `headlampAlignment`, `garageCustomization` — each added in its own task, all registered in `Client.cs`. ✓
- `skillChange` packet already existed in enum — Task 8 adds the client-side handler and register entry only. ✓

**One open item:** Task 6 notes that `ModCar` may not have `HeadLampLeftAlignmentData` / `HeadlampRightAlignmentData` directly — the implementer must verify the field path during Step 2 and adjust `ApplyHeadlampAlignment` accordingly. This is not a placeholder — it's a runtime verification step with a clear resolution path.
