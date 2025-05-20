using System.Collections.Generic;

namespace System.Net.Http.Headers;

/// <summary>Represents authentication information in Authorization, ProxyAuthorization, WWW-Authenticate, and Proxy-Authenticate header values.</summary>
public class AuthenticationHeaderValue : ICloneable
{
	/// <summary>Gets the credentials containing the authentication information of the user agent for the resource being requested.</summary>
	/// <returns>The credentials containing the authentication information.</returns>
	public string Parameter { get; private set; }

	/// <summary>Gets the scheme to use for authorization.</summary>
	/// <returns>The scheme to use for authorization.</returns>
	public string Scheme { get; private set; }

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.Headers.AuthenticationHeaderValue" /> class.</summary>
	/// <param name="scheme">The scheme to use for authorization.</param>
	/// <param name="parameter">The credentials containing the authentication information of the user agent for the resource being requested.</param>
	public AuthenticationHeaderValue(string scheme, string parameter)
	{
	}

	private AuthenticationHeaderValue()
	{
	}

	/// <summary>Creates a new object that is a copy of the current <see cref="T:System.Net.Http.Headers.AuthenticationHeaderValue" /> instance.</summary>
	/// <returns>A copy of the current instance.</returns>
	object ICloneable.Clone()
	{
		return null;
	}

	/// <summary>Determines whether the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Net.Http.Headers.AuthenticationHeaderValue" /> object.</summary>
	/// <param name="obj">The object to compare with the current object.</param>
	/// <returns>
	///   <see langword="true" /> if the specified <see cref="T:System.Object" /> is equal to the current object; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Serves as a hash function for an  <see cref="T:System.Net.Http.Headers.AuthenticationHeaderValue" /> object.</summary>
	/// <returns>A hash code for the current object.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Determines whether a string is valid <see cref="T:System.Net.Http.Headers.AuthenticationHeaderValue" /> information.</summary>
	/// <param name="input">The string to validate.</param>
	/// <param name="parsedValue">The <see cref="T:System.Net.Http.Headers.AuthenticationHeaderValue" /> version of the string.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="input" /> is valid <see cref="T:System.Net.Http.Headers.AuthenticationHeaderValue" /> information; otherwise, <see langword="false" />.</returns>
	public static bool TryParse(string input, out AuthenticationHeaderValue parsedValue)
	{
		parsedValue = null;
		return false;
	}

	internal static bool TryParse(string input, int minimalCount, out List<AuthenticationHeaderValue> result)
	{
		result = null;
		return false;
	}

	private static bool TryParseElement(Lexer lexer, out AuthenticationHeaderValue parsedValue, out Token t)
	{
		parsedValue = null;
		t = default(Token);
		return false;
	}

	/// <summary>Returns a string that represents the current <see cref="T:System.Net.Http.Headers.AuthenticationHeaderValue" /> object.</summary>
	/// <returns>A string that represents the current object.</returns>
	public override string ToString()
	{
		return null;
	}
}
