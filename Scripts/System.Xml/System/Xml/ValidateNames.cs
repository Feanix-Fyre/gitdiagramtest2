namespace System.Xml;

internal static class ValidateNames
{
	private static XmlCharType xmlCharType;

	internal static int ParseNmtoken(string s, int offset)
	{
		return 0;
	}

	internal static int ParseNmtokenNoNamespaces(string s, int offset)
	{
		return 0;
	}

	internal static int ParseNameNoNamespaces(string s, int offset)
	{
		return 0;
	}

	internal static bool IsNameNoNamespaces(string s)
	{
		return false;
	}

	internal static int ParseNCName(string s, int offset)
	{
		return 0;
	}

	internal static int ParseNCName(string s)
	{
		return 0;
	}

	internal static int ParseQName(string s, int offset, out int colonOffset)
	{
		colonOffset = default(int);
		return 0;
	}

	internal static void ParseQNameThrow(string s, out string prefix, out string localName)
	{
		prefix = null;
		localName = null;
	}

	internal static void ThrowInvalidName(string s, int offsetStartChar, int offsetBadChar)
	{
	}

	internal static Exception GetInvalidNameException(string s, int offsetStartChar, int offsetBadChar)
	{
		return null;
	}

	internal static void SplitQName(string name, out string prefix, out string lname)
	{
		prefix = null;
		lname = null;
	}
}
