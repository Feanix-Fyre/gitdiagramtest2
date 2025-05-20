namespace System.Net;

internal class NtlmClient : IAuthenticationModule
{
	private IAuthenticationModule authObject;

	public string AuthenticationType => null;

	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials)
	{
		return null;
	}

	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials)
	{
		return null;
	}
}
