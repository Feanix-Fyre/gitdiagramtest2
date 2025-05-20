namespace System.Xml;

internal struct XmlCharType
{
	private static object s_Lock;

	private static byte[] s_CharProperties;

	internal byte[] charProperties;

	private static object StaticLock => null;

	public static XmlCharType Instance => default(XmlCharType);

	private static void InitInstance()
	{
	}

	private static void SetProperties(byte[] chProps, string ranges, byte value)
	{
	}

	private XmlCharType(byte[] charProperties)
	{
		this.charProperties = null;
	}

	public bool IsWhiteSpace(char ch)
	{
		return false;
	}

	public bool IsNCNameSingleChar(char ch)
	{
		return false;
	}

	public bool IsStartNCNameSingleChar(char ch)
	{
		return false;
	}

	public bool IsNameSingleChar(char ch)
	{
		return false;
	}

	public bool IsCharData(char ch)
	{
		return false;
	}

	public bool IsPubidChar(char ch)
	{
		return false;
	}

	internal bool IsTextChar(char ch)
	{
		return false;
	}

	public bool IsLetter(char ch)
	{
		return false;
	}

	public bool IsNCNameCharXml4e(char ch)
	{
		return false;
	}

	public bool IsStartNCNameCharXml4e(char ch)
	{
		return false;
	}

	public bool IsNameCharXml4e(char ch)
	{
		return false;
	}

	public static bool IsDigit(char ch)
	{
		return false;
	}

	internal static bool IsHighSurrogate(int ch)
	{
		return false;
	}

	internal static bool IsLowSurrogate(int ch)
	{
		return false;
	}

	internal static bool IsSurrogate(int ch)
	{
		return false;
	}

	internal static int CombineSurrogateChar(int lowChar, int highChar)
	{
		return 0;
	}

	internal static void SplitSurrogateChar(int combinedChar, out char lowChar, out char highChar)
	{
		lowChar = default(char);
		highChar = default(char);
	}

	internal bool IsOnlyWhitespace(string str)
	{
		return false;
	}

	internal int IsOnlyWhitespaceWithPos(string str)
	{
		return 0;
	}

	internal int IsOnlyCharData(string str)
	{
		return 0;
	}

	internal static bool IsOnlyDigits(string str, int startPos, int len)
	{
		return false;
	}

	internal int IsPublicId(string str)
	{
		return 0;
	}

	private static bool InRange(int value, int start, int end)
	{
		return false;
	}
}
