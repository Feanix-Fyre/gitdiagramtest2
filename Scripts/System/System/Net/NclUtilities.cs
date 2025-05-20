namespace System.Net;

internal static class NclUtilities
{
	private static IPAddress[] _LocalAddresses;

	private static object _LocalAddressesLock;

	internal static string _LocalDomainName;

	internal static IPAddress[] LocalAddresses => null;

	private static object LocalAddressesLock => null;

	internal static bool IsFatal(Exception exception)
	{
		return false;
	}

	internal static bool IsAddressLocal(IPAddress ipAddress)
	{
		return false;
	}

	private static IPHostEntry GetLocalHost()
	{
		return null;
	}
}
