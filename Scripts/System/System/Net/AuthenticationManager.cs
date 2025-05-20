using System.Collections;

namespace System.Net;

/// <summary>Manages the authentication modules called during the client authentication process.</summary>
public class AuthenticationManager
{
	private static ArrayList modules;

	private static object locker;

	private static ICredentialPolicy credential_policy;

	private static void EnsureModules()
	{
	}

	/// <summary>Calls each registered authentication module to find the first module that can respond to the authentication request.</summary>
	/// <param name="challenge">The challenge returned by the Internet resource.</param>
	/// <param name="request">The <see cref="T:System.Net.WebRequest" /> that initiated the authentication challenge.</param>
	/// <param name="credentials">The <see cref="T:System.Net.ICredentials" /> associated with this request.</param>
	/// <returns>An instance of the <see cref="T:System.Net.Authorization" /> class containing the result of the authorization attempt. If there is no authentication module to respond to the challenge, this method returns <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="challenge" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="request" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="credentials" /> is <see langword="null" />.</exception>
	public static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials)
	{
		return null;
	}

	private static Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials)
	{
		return null;
	}

	/// <summary>Preauthenticates a request.</summary>
	/// <param name="request">A <see cref="T:System.Net.WebRequest" /> to an Internet resource.</param>
	/// <param name="credentials">The <see cref="T:System.Net.ICredentials" /> associated with the request.</param>
	/// <returns>An instance of the <see cref="T:System.Net.Authorization" /> class if the request can be preauthenticated; otherwise, <see langword="null" />. If <paramref name="credentials" /> is <see langword="null" />, this method returns <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="request" /> is <see langword="null" />.</exception>
	public static Authorization PreAuthenticate(WebRequest request, ICredentials credentials)
	{
		return null;
	}
}
