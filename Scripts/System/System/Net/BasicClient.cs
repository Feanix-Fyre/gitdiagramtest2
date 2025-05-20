namespace System.Net;

internal class BasicClient : IAuthenticationModule
{
	public string AuthenticationType => null;

	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials)
	{
		return null;
	}

	private static byte[] GetBytes(string str)
	{
		return null;
	}

	private static Authorization InternalAuthenticate(WebRequest webRequest, ICredentials credentials)
	{
		return null;
	}

	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials)
	{
		return null;
	}
}
