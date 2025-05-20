using System.Collections;

namespace System.Net;

internal class DigestClient : IAuthenticationModule
{
	private static readonly Hashtable cache;

	private static Hashtable Cache => null;

	public string AuthenticationType => null;

	private static void CheckExpired(int count)
	{
	}

	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials)
	{
		return null;
	}

	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials)
	{
		return null;
	}
}
