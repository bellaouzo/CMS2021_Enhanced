using System;
using MelonLoader;
using Steamworks;
using Steamworks.Data;

namespace CMS21Together.Shared;

public static class SteamLobby
{
    private const string ServerIdKey = "serverID";

    public static Lobby? CurrentLobby { get; private set; }

    public static async void CreateLobby(string serverID)
    {
        try
        {
            var result = await SteamMatchmaking.CreateLobbyAsync(MainMod.MAX_PLAYER);
            if (!result.HasValue)
            {
                MelonLogger.Error("[SteamLobby] Failed to create Steam lobby.");
                return;
            }
            CurrentLobby = result.Value;
            result.Value.SetFriendsOnly();
            result.Value.SetJoinable(true);
            result.Value.SetData(ServerIdKey, serverID);
            MelonLogger.Msg($"[SteamLobby] Lobby created: {result.Value.Id}");
        }
        catch (Exception ex)
        {
            MelonLogger.Error($"[SteamLobby] Error creating lobby: {ex.Message}");
        }
    }

    public static void OpenInviteOverlay()
    {
        if (!CurrentLobby.HasValue)
        {
            MelonLogger.Warning("[SteamLobby] No active lobby to invite to.");
            return;
        }
        SteamFriends.OpenGameInviteOverlay(CurrentLobby.Value.Id);
    }

    public static void LeaveLobby()
    {
        if (!CurrentLobby.HasValue) return;
        CurrentLobby.Value.Leave();
        CurrentLobby = null;
        MelonLogger.Msg("[SteamLobby] Left Steam lobby.");
    }

    public static string GetServerID(Lobby lobby)
    {
        return lobby.GetData(ServerIdKey);
    }
}
