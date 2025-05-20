using System.Security;

namespace System.Net;

/// <summary>Provides credentials for password-based authentication schemes such as basic, digest, NTLM, and Kerberos authentication.</summary>
public class NetworkCredential : ICredentials
{
	private string m_domain;

	private string m_userName;

	private SecureString m_password;

	/// <summary>Gets or sets the user name associated with the credentials.</summary>
	/// <returns>The user name associated with the credentials.</returns>
	public string UserName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the password for the user name associated with the credentials.</summary>
	/// <returns>The password associated with the credentials. If this <see cref="T:System.Net.NetworkCredential" /> instance was initialized with the <paramref name="password" /> parameter set to <see langword="null" />, then the <see cref="P:System.Net.NetworkCredential.Password" /> property will return an empty string.</returns>
	public string Password
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the domain or computer name that verifies the credentials.</summary>
	/// <returns>The name of the domain associated with the credentials.</returns>
	public string Domain
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.NetworkCredential" /> class.</summary>
	public NetworkCredential()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.NetworkCredential" /> class with the specified user name and password.</summary>
	/// <param name="userName">The user name associated with the credentials.</param>
	/// <param name="password">The password for the user name associated with the credentials.</param>
	public NetworkCredential(string userName, string password)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.NetworkCredential" /> class with the specified user name, password, and domain.</summary>
	/// <param name="userName">The user name associated with the credentials.</param>
	/// <param name="password">The password for the user name associated with the credentials.</param>
	/// <param name="domain">The domain associated with these credentials.</param>
	public NetworkCredential(string userName, string password, string domain)
	{
	}

	internal string InternalGetUserName()
	{
		return null;
	}

	internal string InternalGetPassword()
	{
		return null;
	}

	internal string InternalGetDomain()
	{
		return null;
	}

	/// <summary>Returns an instance of the <see cref="T:System.Net.NetworkCredential" /> class for the specified Uniform Resource Identifier (URI) and authentication type.</summary>
	/// <param name="uri">The URI that the client provides authentication for.</param>
	/// <param name="authType">The type of authentication requested, as defined in the <see cref="P:System.Net.IAuthenticationModule.AuthenticationType" /> property.</param>
	/// <returns>A <see cref="T:System.Net.NetworkCredential" /> object.</returns>
	public NetworkCredential GetCredential(Uri uri, string authType)
	{
		return null;
	}
}
