namespace System.Net;

/// <summary>Contains an authentication message for an Internet server.</summary>
public class Authorization
{
	private string m_Message;

	private bool m_Complete;

	internal string ModuleAuthenticationType;

	/// <summary>Gets the message returned to the server in response to an authentication challenge.</summary>
	/// <returns>The message that will be returned to the server in response to an authentication challenge.</returns>
	public string Message => null;

	/// <summary>Gets the completion status of the authorization.</summary>
	/// <returns>
	///   <see langword="true" /> if the authentication process is complete; otherwise, <see langword="false" />.</returns>
	public bool Complete => false;

	/// <summary>Creates a new instance of the <see cref="T:System.Net.Authorization" /> class with the specified authorization message.</summary>
	/// <param name="token">The encrypted authorization message expected by the server.</param>
	public Authorization(string token)
	{
	}

	/// <summary>Creates a new instance of the <see cref="T:System.Net.Authorization" /> class with the specified authorization message and completion status.</summary>
	/// <param name="token">The encrypted authorization message expected by the server.</param>
	/// <param name="finished">The completion status of the authorization attempt. <see langword="true" /> if the authorization attempt is complete; otherwise, <see langword="false" />.</param>
	public Authorization(string token, bool finished)
	{
	}
}
