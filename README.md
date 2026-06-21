<br/>
<p align="center">
  <a href="https://github.com/bellaouzo/CMS2021">
    <img src="https://cdn.discordapp.com/icons/1076513862897119232/1150ebb5d3f306736e1a1cd080465b82.webp?size=96" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">CMS21 Together (Modified)</h3>

  <p align="center">
    A modified multiplayer mod for Car Mechanic Simulator 2021
    <br/>
    Based on <a href="https://github.com/Fozkais/CMS21-Together">Fozkais/CMS21-Together</a>
  </p>
</p>

![License](https://img.shields.io/github/license/bellaouzo/CMS2021)

## Table Of Contents

* [About the Project](#about-the-project)
* [Modifications](#modifications)
* [Feature Status](#feature-status)
* [Installation](#installation)
* [Building from Source](#building-from-source)
* [Authors](#authors)
* [License](#license)

## About The Project

This repository is a **modified fork** of [CMS21-Together](https://github.com/Fozkais/CMS21-Together) by Fozkais and Meitzi. The original mod adds cooperative multiplayer to Car Mechanic Simulator 2021 via MelonLoader.

This version extends the original with additional synchronization, bug fixes, and quality-of-life improvements. Co-op is **very close to full sync** — garage tools, cars, stats, quests, outdoor work, customization, salon browsing, and player state all sync between clients.

You may still hit occasional bugs or edge cases (especially around late join, scene transitions, or less-tested workflows). It should be playable end-to-end, but treat saves as something worth backing up until you've validated your setup.

For the original mod's overview and demo video, see the [upstream README](https://github.com/Fozkais/CMS21-Together).

## Modifications

Changes in this fork relative to the upstream project:

* **Outdoor interactions** — sync for car wash, dyno/power bench, wheel alignment, and headlamp alignment
* **Garage customization** — sync garage look changes to remote clients with resync on join
* **Skill upgrades** — shared across all clients with broadcast and resync
* **Player state** — door state and crouch state synchronization
* **Salon cars** — improved salon car management and synchronization
* **Server fixes** — fluid state tracking, late-join money uses live balance, and related packet handler fixes
* **General** — improved player synchronization and UI handling

## Feature Status

Gameplay sync is largely complete in this fork. The checklist below reflects the current state — most core systems are implemented, with standalone server support still out of scope:

* Implement Networking System (TCP/UDP) : ✅
* Implement Steam API Networking : ✅
* Create a Lobby system : ✅
* Add a Custom Save System : ✅
* Sync players Position and Rotation : ✅
* Add Animation to players : ✅
* Sync Inventory : ✅
* Sync Cars Spawning and position : ✅
* Sync Garage Interaction : ✅ (Lifter, Wheel Assembler, Wheel Balancer, Spring clamp, etc...)
* Sync OutDoor Interaction : ✅ (Car wash, dyno/power bench, wheel alignment, headlamp alignment; car painting supported)
* Sync Cars : ✅
* Sync Stats (Money, exp, scrap) : ✅
* Sync Quest : ✅
* Sync garage upgrade : ✅
* Sync garage Customization : ✅
* Sync Workshop Car : ✅
* Sync Salon Cars : ✅
* Share skill upgrades : ✅
* Sync player doors & crouch : ✅
* Standalone dedicated server : ⏸️ (not planned for this fork)

**Legend:**
<br/>
✅ Done / Implemented
<br/>
🚧 Work In Progress
<br/>
❌ To Do / Missing
<br/>
⏸️ Paused / not the main focus

## Installation

1. Download the latest build from the [Releases](https://github.com/bellaouzo/CMS2021/releases) page (or build from source below)
2. Download and install [MelonLoader](https://melonwiki.xyz/) version **0.5.7**
3. Extract the mod folder into your game directory
4. Launch the game

Once launched, you should see a new button to access multiplayer features.

## Building from Source

Requires the .NET SDK and the game assemblies referenced in `CMS21-Together.csproj`.

```powershell
.\build.ps1
```

This runs `dotnet build CMS21-Together.sln -c Release`. Copy the built output into your CMS2021 game directory alongside MelonLoader.

## Authors

**Original mod**

* **Fozkais** — *Main dev* — [Fozkais](https://github.com/Fozkais)
* **Meitzi** — *Huge Contributor* — [MetziQ](https://www.nexusmods.com/carmechanicsimulator2021/users/151281813)

**This modified version**

* **bellaouzo** — [bellaouzo](https://github.com/bellaouzo)

## License

Distributed under the MIT License. See [LICENSE](LICENSE) for more information.

The original project is also licensed under MIT. See the [upstream LICENSE](https://github.com/Fozkais/CMS21-Together/blob/MainMod/LICENSE).
