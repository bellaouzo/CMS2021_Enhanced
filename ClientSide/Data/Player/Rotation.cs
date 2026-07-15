using CMS21Together.ClientSide.Data.Handle;
using CMS21Together.Shared;
using CMS21Together.Shared.Data;
using UnityEngine;

namespace CMS21Together.ClientSide.Data.Player;

public static class Rotation
{
	private static readonly float minDistance = 0.01f;
	private static Quaternion lastRotation;

	public static void UpdateRotation(int id, QuaternionSerializable rotation)
	{
		if (!ClientData.Instance.connectedClients.ContainsKey(id)) return;
		if (!Movement.CanSyncRemotePlayer()) return;

		var player = ClientData.Instance.connectedClients[id];
		if (player.scene != ClientData.UserData.scene) return;

		if (player.userObject != null)
		{
			player.lastUpdateTime = Time.time;
			player.userObject.transform.rotation = rotation.toQuaternion();
		}
		else
		{
			player.rotation = rotation;
		}
	}

	public static void SendRotation(bool force = false)
	{
		if (GameData.Instance?.localPlayer == null) return;

		var rotation = GameData.Instance.localPlayer.transform.rotation;
		if (!force && Quaternion.Angle(rotation, lastRotation) <= minDistance)
			return;

		lastRotation = rotation;
		ClientSend.RotationPacket(new QuaternionSerializable(rotation));
	}
}