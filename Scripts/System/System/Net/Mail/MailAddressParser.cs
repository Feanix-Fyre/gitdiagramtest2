namespace System.Net.Mail;

internal static class MailAddressParser
{
	internal static MailAddress ParseAddress(string data)
	{
		return null;
	}

	private static MailAddress ParseAddress(string data, bool expectMultipleAddresses, ref int index)
	{
		return null;
	}

	private static int ReadCfwsAndThrowIfIncomplete(string data, int index)
	{
		return 0;
	}

	private static string ParseDomain(string data, ref int index)
	{
		return null;
	}

	private static string ParseLocalPart(string data, ref int index, bool expectAngleBracket, bool expectMultipleAddresses)
	{
		return null;
	}

	private static string ParseDisplayName(string data, ref int index, bool expectMultipleAddresses)
	{
		return null;
	}

	internal static string NormalizeOrThrow(string input)
	{
		return null;
	}
}
