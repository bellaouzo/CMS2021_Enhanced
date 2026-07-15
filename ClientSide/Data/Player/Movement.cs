using CMS21Together.ClientSide.Data.Handle;
using CMS21Together.Shared;
using CMS21Together.Shared.Data;
using UnityEngine;

namespace CMS21Together.ClientSide.Data.Player;

public static class Movement
{
	private static readonly float minDistance = 0.01f;
	private static readonly float snapDistance = 1.25f;
	private static readonly float crouchHeightOffset = 0.35f;
	private static readonly float crouchScaleY = 0.72f;
	private static readonly float normalScaleY = 1f;
	private static readonly float playerYOffset = 0.72f;
	private static Vector3 lastPosition;
	private static bool lastSentCrouch;

	public static void UpdatePosition(int id, Vector3Serializable position, bool isCrouching = false)
	{
		if (!ClientData.Instance.connectedClients.ContainsKey(id)) return;
		if (!CanSyncRemotePlayer()) return;

		var player = ClientData.Instance.connectedClients[id];
		player.isCrouching = isCrouching;

		if (player.scene != ClientData.UserData.scene) return;

		if (player.isInCar)
		{
			if (player.userObject != null && player.userObject.activeSelf)
				player.userObject.SetActive(false);
			return;
		}

		if (!player.isInCar && player.userObject != null && !player.userObject.activeSelf)
			player.userObject.SetActive(true);

		if (player.userObject == null)
		{
			player.position = position;
			player.SpawnPlayer();
		}

		if (player.userObject)
		{
			Vector3 targetPos = position.toVector3();
			if (isCrouching)
				targetPos.y -= crouchHeightOffset;

			Vector3 curPos = player.userObject.transform.position;
			float targetScaleY = isCrouching ? crouchScaleY : normalScaleY;
			Vector3 scale = player.userObject.transform.localScale;
			scale.y = Mathf.Lerp(scale.y, player.baseScaleY * targetScaleY, Time.deltaTime * 12f);
			player.userObject.transform.localScale = scale;

			float dist = Vector3.Distance(curPos, targetPos);
			bool shouldSnap = player.lastPosition == null || dist > snapDistance;

			if (!shouldSnap)
			{
				var direction = (targetPos - player.lastPosition.toVector3()).normalized;
				var speed = (targetPos - player.lastPosition.toVector3()).magnitude / Time.deltaTime;
				speed = Mathf.Clamp(speed, 0f, 20f);

				UpdateAnimations(player.userAnimator, direction, speed);
				player.lastUpdateTime = Time.time;
				player.userObject.transform.position = Vector3.Lerp(curPos, targetPos, Time.deltaTime * 18f);
			}
			else
			{
				player.userObject.transform.position = targetPos;
				player.lastUpdateTime = Time.time;
			}

			player.lastPosition = position;
			player.position = position;
		}
	}

	public static bool CanSyncRemotePlayer()
	{
		if (SceneManager.IsPlayerSyncScene())
		{
			if (SceneManager.CurrentScene() == GameScene.garage)
				return GameData.isReady;
			return GameData.Instance?.localPlayer != null;
		}

		return GameData.isReady;
	}

	private static void UpdateAnimations(Animator animator, Vector3 direction, float speed)
	{
		if (animator == null) return;

		var horizontalSpeed = direction.x * speed;
		var verticalSpeed = direction.z * speed;

		animator.SetFloat("Vertical", Mathf.Lerp(animator.GetFloat("Vertical"), verticalSpeed, Time.deltaTime * 10f));
		animator.SetFloat("Horizontal", Mathf.Lerp(animator.GetFloat("Horizontal"), horizontalSpeed, Time.deltaTime * 10f));
	}

	public static void CheckForInactivity()
	{
		foreach (var client in ClientData.Instance.connectedClients.Values)
		{
			if (client == null || client.userObject == null) continue;

			float targetScaleY = client.isCrouching ? crouchScaleY : normalScaleY;
			float desiredY = client.baseScaleY * targetScaleY;
			var scale = client.userObject.transform.localScale;
			if (Mathf.Abs(scale.y - desiredY) > 0.0001f)
			{
				scale.y = Mathf.Lerp(scale.y, desiredY, Time.deltaTime * 12f);
				client.userObject.transform.localScale = scale;
			}

			if (client.userAnimator == null) continue;

			float elapsedTime = Time.time - client.lastUpdateTime;
			if (elapsedTime > 0.15f)
			{
				client.userAnimator.SetFloat("Vertical", Mathf.Lerp(client.userAnimator.GetFloat("Vertical"), 0, Time.deltaTime * 10f));
				client.userAnimator.SetFloat("Horizontal", Mathf.Lerp(client.userAnimator.GetFloat("Horizontal"), 0, Time.deltaTime * 10f));
			}
		}
	}

	public static void SendPosition(bool force = false)
	{
		if (GameData.Instance?.localPlayer == null) return;

		bool isCrouching = FPSCamera.isCrouching;
		var position = GameData.Instance.localPlayer.transform.position;
		position.y -= playerYOffset;

		bool moved = Vector3.Distance(position, lastPosition) > minDistance;
		bool crouchChanged = isCrouching != lastSentCrouch;

		if (!force && !moved && !crouchChanged) return;

		lastPosition = position;
		lastSentCrouch = isCrouching;
		ClientSend.PositionPacket(new Vector3Serializable(position), isCrouching);
	}
}
