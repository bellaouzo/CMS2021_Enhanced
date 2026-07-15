using System.Collections;
using CMS21Together.Shared;
using CMS21Together.Shared.Data.Vanilla;
using MelonLoader;
using UnityEngine;

namespace CMS21Together.ClientSide.Data;

public static class CarAppearanceHelper
{
	public static ModColor CaptureColor(CarLoader loader)
	{
		if (loader == null || !loader.IsCarLoaded())
			return null;

		try
		{
			return new ModColor(loader.GetCarColor());
		}
		catch (System.Exception ex)
		{
			MelonLogger.Warning($"[CarAppearanceHelper] Failed to capture color: {ex.Message}");
			return null;
		}
	}

	public static void ApplyColor(CarLoader loader, ModColor modColor)
	{
		if (loader == null || modColor == null || !loader.IsCarLoaded())
			return;

		try
		{
			var color = modColor.ToGame();
			loader.color = color;

			var parts = loader.carParts;
			if (parts == null) return;

			foreach (var part in parts.ToArray())
			{
				if (part == null || part.Unmounted) continue;
				loader.SetCarColor(part, color);
			}

			loader.UpdateCarBodyParts();
		}
		catch (System.Exception ex)
		{
			MelonLogger.Warning($"[CarAppearanceHelper] Failed to apply color: {ex.Message}");
		}
	}

	public static IEnumerator ApplyColorAfterLoad(CarLoader loader, ModColor modColor, float timeout = 30f)
	{
		if (loader == null || modColor == null)
			yield break;

		yield return LoadWait.WaitForPredicate(
			() => loader != null && loader.IsCarLoaded(),
			timeout,
			"car color apply");

		if (LoadWait.LastResult != LoadWaitResult.Success)
			yield break;

		yield return new WaitForEndOfFrame();
		ApplyColor(loader, modColor);
	}
}
