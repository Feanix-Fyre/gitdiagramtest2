namespace System.Drawing;

internal static class ClientUtils
{
	public static bool IsCriticalException(Exception ex)
	{
		return false;
	}

	public static bool IsSecurityOrCriticalException(Exception ex)
	{
		return false;
	}
}
