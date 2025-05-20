namespace System.Security.Principal;

/// <summary>Defines the basic functionality of an identity object.</summary>
public interface IIdentity
{
	/// <summary>Gets the name of the current user.</summary>
	/// <returns>The name of the user on whose behalf the code is running.</returns>
	string Name { get; }

	/// <summary>Gets the type of authentication used.</summary>
	/// <returns>The type of authentication used to identify the user.</returns>
	string AuthenticationType { get; }
}
