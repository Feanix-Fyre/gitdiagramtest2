namespace System.Net.Http;

internal static class HttpUtilities
{
	internal static bool IsSupportedSecureScheme(string scheme)
	{
		return false;
	}

	internal static bool IsSecureWebSocketScheme(string scheme)
	{
		return false;
	}
}
