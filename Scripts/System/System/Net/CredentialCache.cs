namespace System.Net;

/// <summary>Provides storage for multiple credentials.</summary>
public class CredentialCache
{
	/// <summary>Gets the system credentials of the application.</summary>
	/// <returns>An <see cref="T:System.Net.ICredentials" /> that represents the system credentials of the application.</returns>
	public static ICredentials DefaultCredentials => null;

	/// <summary>Gets the network credentials of the current security context.</summary>
	/// <returns>An <see cref="T:System.Net.NetworkCredential" /> that represents the network credentials of the current user or application.</returns>
	public static NetworkCredential DefaultNetworkCredentials => null;
}
