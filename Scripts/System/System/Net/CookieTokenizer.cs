namespace System.Net;

internal class CookieTokenizer
{
	private struct RecognizedAttribute
	{
		private string m_name;

		private CookieToken m_token;

		internal CookieToken Token => default(CookieToken);

		internal RecognizedAttribute(string name, CookieToken token)
		{
			m_name = null;
			m_token = default(CookieToken);
		}

		internal bool IsEqualTo(string value)
		{
			return false;
		}
	}

	private bool m_eofCookie;

	private int m_index;

	private int m_length;

	private string m_name;

	private bool m_quoted;

	private int m_start;

	private CookieToken m_token;

	private int m_tokenLength;

	private string m_tokenStream;

	private string m_value;

	private static RecognizedAttribute[] RecognizedAttributes;

	private static RecognizedAttribute[] RecognizedServerAttributes;

	internal bool EndOfCookie
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool Eof => false;

	internal string Name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal bool Quoted
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal CookieToken Token
	{
		get
		{
			return default(CookieToken);
		}
		set
		{
		}
	}

	internal string Value
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal CookieTokenizer(string tokenStream)
	{
	}

	internal string Extract()
	{
		return null;
	}

	internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals)
	{
		return default(CookieToken);
	}

	internal CookieToken Next(bool first, bool parseResponseCookies)
	{
		return default(CookieToken);
	}

	internal void Reset()
	{
	}

	internal CookieToken TokenFromName(bool parseResponseCookies)
	{
		return default(CookieToken);
	}
}
