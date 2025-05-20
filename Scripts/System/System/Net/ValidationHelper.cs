namespace System.Net;

internal static class ValidationHelper
{
	public static string[] EmptyArray;

	internal static readonly char[] InvalidMethodChars;

	internal static readonly char[] InvalidParamChars;

	public static string MakeStringNull(string stringValue)
	{
		return null;
	}

	public static bool IsBlankString(string stringValue)
	{
		return false;
	}

	public static bool ValidateTcpPort(int port)
	{
		return false;
	}
}
