using System;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using CMS21Together.Shared;
using MelonLoader;
using UnityEngine;
using UnityEngine.UI;
using System.Net.Http;
using CMS21Together.Shared.Data;

namespace CMS21Together.ClientSide.Data;

//[RegisterTypeInIl2Cpp]
public class ContentManager
{
	public static ContentManager Instance;

	private const string GITHUB_OWNER = "bellaouzo";
	private const string GITHUB_REPO = "CMS2021_Enhanced";
	public static readonly string LatestReleaseUrl =
		$"https://github.com/{GITHUB_OWNER}/{GITHUB_REPO}/releases/latest";

	public string gameVersion { get; private set; }
	public ReadOnlyDictionary<string, bool> ownedContents { get; private set; }

	public void Initialize()
	{
		if (ownedContents != null) return;

		if (Instance == null)
		{
			Instance = this;
		}
		else if (Instance != this)
		{
			MelonLogger.Msg("Instance already exists, destroying object!");
		}

		GetGameVersion();
		CheckContent();
	}

	private void GetGameVersion()
	{
		if (ownedContents != null) return;

		gameVersion = GameObject.Find("GameVersion").GetComponent<Text>().text;
	}

	protected void CheckContent()
	{
		if (ownedContents != null) return;

		ownedContents = new ReadOnlyDictionary<string, bool>(ApiCalls.API_M3());
	}

	public VersionCheckResult CheckForUpdate(string versionName)
	{
		try
		{
			using (var client = new HttpClient())
			{
				client.DefaultRequestHeaders.Add("User-Agent", "CMS21-Together-UpdateChecker");
				client.Timeout = TimeSpan.FromSeconds(5);
				string url = $"https://api.github.com/repos/{GITHUB_OWNER}/{GITHUB_REPO}/releases/latest";

				string json = client.GetStringAsync(url).Result;

				var tagMatch = Regex.Match(json, @"""tag_name""\s*:\s*""([^""]+)""");
				if (!tagMatch.Success)
				{
					MelonLogger.Msg("VersionChecker : could not find 'tag_name' field on response");
					return new VersionCheckResult(VersionStatus.Latest);
				}

				string remoteVersion = tagMatch.Groups[1].Value.Trim().TrimStart('v', 'V');
				string releaseUrl = LatestReleaseUrl;
				var urlMatch = Regex.Match(json, @"""html_url""\s*:\s*""(https://github\.com/[^""]+/releases/[^""]+)""");
				if (urlMatch.Success)
					releaseUrl = urlMatch.Groups[1].Value;

				(Version localVer, int localHF) = ParseVersion(versionName);
				(Version remoteVer, int remoteHF) = ParseVersion(remoteVersion);

				int cmp = localVer.CompareTo(remoteVer);
				if (cmp < 0)
					return new VersionCheckResult(VersionStatus.Outdated, remoteVersion, releaseUrl);
				if (cmp > 0)
					return new VersionCheckResult(VersionStatus.Dev, remoteVersion, releaseUrl);

				if (localHF < remoteHF)
					return new VersionCheckResult(VersionStatus.Outdated, remoteVersion, releaseUrl);
				if (localHF > remoteHF)
					return new VersionCheckResult(VersionStatus.Dev, remoteVersion, releaseUrl);

				return new VersionCheckResult(VersionStatus.Latest, remoteVersion, releaseUrl);
			}
		}
		catch (Exception ex)
		{
			MelonLogger.Msg("VersionChecker exception : " + ex);
			return new VersionCheckResult(VersionStatus.Latest);
		}
	}

	public VersionStatus IsNewVersionAvailable(string versionName)
	{
		return CheckForUpdate(versionName).Status;
	}

	private (Version, int) ParseVersion(string versionStr)
	{
		if (string.IsNullOrWhiteSpace(versionStr))
			return (new Version(0, 0, 0), 0);

		versionStr = versionStr.Trim().TrimStart('v', 'V');
		int hf = 0;
		var m = Regex.Match(versionStr, @"^(?<major>\d+)\.(?<minor>\d+)(?:\.(?<patch>\d+))?(?:hf(?<hf>\d+))?$");
		if (m.Success)
		{
			int major = int.Parse(m.Groups["major"].Value);
			int minor = int.Parse(m.Groups["minor"].Value);
			int patch = m.Groups["patch"].Success ? int.Parse(m.Groups["patch"].Value) : 0;
			if (m.Groups["hf"].Success && int.TryParse(m.Groups["hf"].Value, out int tmp))
				hf = tmp;
			return (new Version(major, minor, patch), hf);
		}

		return (new Version(0, 0, 0), 0);
	}
}