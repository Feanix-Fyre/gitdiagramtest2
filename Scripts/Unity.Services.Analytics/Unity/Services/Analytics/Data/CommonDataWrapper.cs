namespace Unity.Services.Analytics.Data;

internal class CommonDataWrapper : ICommonData
{
	public string Version { get; }

	public string GameBundleId { get; }

	public string ProjectId { get; }

	public string Platform { get; }

	public string BuildGUID { get; }

	public string Idfv { get; }

	public string GameStoreId { get; }

	public bool HasVolume { get; }

	public float Volume => 0f;

	public double BatteryLevel => 0.0;

	public string AnalyticsRegionLanguageCode => null;

	public CommonDataWrapper(string cloudProjectId)
	{
	}

	private static string GetPlatform()
	{
		return null;
	}
}
