using System.Security.Cryptography;

namespace System.Net;

internal class DigestSession
{
	private static RandomNumberGenerator rng;

	private DateTime lastUse;

	private int _nc;

	private HashAlgorithm hash;

	private DigestHeaderParser parser;

	private string _cnonce;

	public string Algorithm => null;

	public string Realm => null;

	public string Nonce => null;

	public string Opaque => null;

	public string QOP => null;

	public string CNonce => null;

	public DateTime LastUse => default(DateTime);

	static DigestSession()
	{
	}

	public bool Parse(string challenge)
	{
		return false;
	}

	private string HashToHexString(string toBeHashed)
	{
		return null;
	}

	private string HA1(string username, string password)
	{
		return null;
	}

	private string HA2(HttpWebRequest webRequest)
	{
		return null;
	}

	private string Response(string username, string password, HttpWebRequest webRequest)
	{
		return null;
	}

	public Authorization Authenticate(WebRequest webRequest, ICredentials credentials)
	{
		return null;
	}
}
