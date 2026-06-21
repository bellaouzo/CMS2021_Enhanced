using CMS21Together.ClientSide.Data.Handle;
using CMS21Together.Shared.Data;
using MelonLoader;
using UnityEngine;

namespace CMS21Together.ClientSide.Data.Player;

public static class Movement
{
	private static readonly float minDistance = 0.01f;
	private static readonly float crouchHeightOffset = 0.35f;
	private static Vector3 lastPosition;
	private static bool lastSentCrouch;

	public static void UpdatePosition(int id, Vector3Serializable position, bool isCrouching = false)
	{
		if (!ClientData.Instance.connectedClients.ContainsKey(id)) return;
		if (!GameData.isReady) return;

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

		if (player.userObject == null) player.SpawnPlayer();

		if (player.userObject)
		{
			Vector3 targetPos = position.toVector3();
			if (isCrouching)
				targetPos.y -= crouchHeightOffset;

			Vector3 curPos = player.userObject.transform.position;

			if (player.lastPosition != null)
			{
				var direction = (targetPos - player.lastPosition.toVector3()).normalized;
				var speed = (targetPos - player.lastPosition.toVector3()).magnitude / Time.deltaTime;
				speed = Mathf.Clamp(speed, 0f, 20f);

				UpdateAnimations(player.userAnimator, direction, speed, isCrouching);
				player.lastUpdateTime = Time.time;
				player.userObject.transform.position = Vector3.Lerp(curPos, targetPos, Time.deltaTime * 15f);
			}
			else
				player.userObject.transform.position = targetPos;

			player.lastPosition = position;
		}
	}

	private static void UpdateAnimations(Animator animator, Vector3 direction, float speed, bool isCrouching)
	{
		if (animator == null) return;

		var horizontalSpeed = direction.x * speed;
		var verticalSpeed = direction.z * speed;

		animator.SetFloat("Vertical", Mathf.Lerp(animator.GetFloat("Vertical"), verticalSpeed, Time.deltaTime * 10f));
		animator.SetFloat("Horizontal", Mathf.Lerp(animator.GetFloat("Horizontal"), horizontalSpeed, Time.deltaTime * 10f));

		TrySetCrouchBool(animator, isCrouching);
	}

	private static void TrySetCrouchBool(Animator animator, bool isCrouching)
	{
		animator.SetBool("Crouch", isCrouching);
		animator.SetBool("IsCrouching", isCrouching);
		animator.SetBool("crouch", isCrouching);
	}

	public static void CheckForInactivity()
	{
		foreach (var client in ClientData.Instance.connectedClients.Values)
		{
			if (client == null) continue;
			if (client.userObject == null || client.userAnimator == null) continue;

			float elapsedTime = Time.time - client.lastUpdateTime;

			if (elapsedTime > 0.15f)
			{
				client.userAnimator.SetFloat("Vertical", Mathf.Lerp(client.userAnimator.GetFloat("Vertical"), 0, Time.deltaTime * 10f));
				client.userAnimator.SetFloat("Horizontal", Mathf.Lerp(client.userAnimator.GetFloat("Horizontal"), 0, Time.deltaTime * 10f));

				var currentRotation = client.userObject.transform.rotation;
				var targetRotation = client.userObject.transform.rotation;
				client.userObject.transform.rotation = Quaternion.Slerp(currentRotation, targetRotation, Time.deltaTime * 5f);
			}
		}
	}

	public static void SendPosition(bool force = false)
	{
		if (GameData.Instance?.localPlayer == null) return;

		bool isCrouching = FPSCamera.isCrouching;
		var position = GameData.Instance.localPlayer.transform.position;
		position.y -= 0.72f;

		bool moved = Vector3.Distance(position, lastPosition) > minDistance;
		bool crouchChanged = isCrouching != lastSentCrouch;

		if (!force && !moved && !crouchChanged) return;

		lastPosition = position;
		lastSentCrouch = isCrouching;
		ClientSend.PositionPacket(new Vector3Serializable(position), isCrouching);
	}
}
