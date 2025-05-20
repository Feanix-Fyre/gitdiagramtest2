namespace System.Net.Cache;

internal sealed class RequestCacheManager
{
	private static RequestCachingSectionInternal s_CacheConfigSettings;

	private static readonly RequestCacheBinding s_BypassCacheBinding;

	private static RequestCacheBinding s_DefaultGlobalBinding;

	private static RequestCacheBinding s_DefaultHttpBinding;

	private static RequestCacheBinding s_DefaultFtpBinding;

	internal static RequestCacheBinding GetBinding(string internedScheme)
	{
		return null;
	}

	private static void LoadConfigSettings()
	{
	}
}
