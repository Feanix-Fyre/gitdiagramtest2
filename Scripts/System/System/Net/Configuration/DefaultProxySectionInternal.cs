namespace System.Net.Configuration;

internal sealed class DefaultProxySectionInternal
{
	private IWebProxy webProxy;

	private static object classSyncObject;

	internal static object ClassSyncObject => null;

	internal IWebProxy WebProxy => null;

	private static IWebProxy GetDefaultProxy_UsingOldMonoCode()
	{
		return null;
	}

	private static IWebProxy GetSystemWebProxy()
	{
		return null;
	}

	internal static DefaultProxySectionInternal GetSection()
	{
		return null;
	}
}
