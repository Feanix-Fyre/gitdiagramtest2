namespace System.Net;

internal class DigestHeaderParser
{
	private string header;

	private int length;

	private int pos;

	private static string[] keywords;

	private string[] values;

	public string Realm => null;

	public string Opaque => null;

	public string Nonce => null;

	public string Algorithm => null;

	public string QOP => null;

	public DigestHeaderParser(string header)
	{
	}

	public bool Parse()
	{
		return false;
	}

	private void SkipWhitespace()
	{
	}

	private string GetKey()
	{
		return null;
	}

	private bool GetKeywordAndValue(out string key, out string value)
	{
		key = null;
		value = null;
		return false;
	}
}
