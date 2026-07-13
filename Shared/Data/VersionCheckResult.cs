namespace CMS21Together.Shared.Data;

public class VersionCheckResult
{
	public VersionStatus Status;
	public string RemoteVersion;
	public string ReleaseUrl;

	public VersionCheckResult(VersionStatus status, string remoteVersion = null, string releaseUrl = null)
	{
		Status = status;
		RemoteVersion = remoteVersion;
		ReleaseUrl = releaseUrl;
	}
}
