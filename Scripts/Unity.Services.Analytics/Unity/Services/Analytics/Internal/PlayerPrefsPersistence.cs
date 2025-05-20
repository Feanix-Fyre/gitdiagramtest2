namespace Unity.Services.Analytics.Internal;

internal class PlayerPrefsPersistence : IPersistence
{
	public void SaveValue(string key, int value)
	{
	}

	public void SaveValue(string key, string value)
	{
	}

	public int LoadInt(string key)
	{
		return 0;
	}

	public string LoadString(string key)
	{
		return null;
	}

	public void ClearValue(string key)
	{
	}
}
