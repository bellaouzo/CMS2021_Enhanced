## CMS21 Together (Modified) 1.0.2

Multiplayer sync improvements since 1.0.1 — salon, garage, barn, junkyard, and auctions.

### Changes
- **Salon**: purchased cars disappear for other players; garage cars stay in sync after buy/return
- **Garage**: full catalog resync so peers see cars bought or moved while they were away
- **Barn**: shared layout seed + car IDs; damage/missing parts sync; door/hood/trunk animations; purchased slots remove for peers
- **Junkyard**: host-authoritative car list, damage, and placement (including under-spawned slots)
- **Auctions**: shared car list and selection; part open/close animations; spectator bid UI (view-only) with live bids; return to list when the host wins
- **Scene travel**: wait for host car catalog before clients finish outdoor scene loads
- Hardened inventory load / packet writes to avoid garage init crashes

### Install

1. Install [MelonLoader 0.5.7](https://melonwiki.xyz/) into Car Mechanic Simulator 2021
2. Extract the RAR into your game folder (merge `UserLibs` and `Mods`)
3. Launch the game — **all players must use the same mod version**

See `README.txt` inside the archive for full instructions.
