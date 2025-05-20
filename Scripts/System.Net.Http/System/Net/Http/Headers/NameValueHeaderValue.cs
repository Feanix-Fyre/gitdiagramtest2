using System.Collections.Generic;

namespace System.Net.Http.Headers;

/// <summary>Represents a name/value pair used in various headers as defined in RFC 2616.</summary>
public class NameValueHeaderValue : ICloneable
{
	internal string value;

	/// <summary>Gets the header name.</summary>
	/// <returns>The header name.</returns>
	public string Name { get; internal set; }

	/// <summary>Gets the header value.</summary>
	/// <returns>The header value.</returns>
	public string Value
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.Headers.NameValueHeaderValue" /> class.</summary>
	/// <param name="name">The header name.</param>
	/// <param name="value">The header value.</param>
	public NameValueHeaderValue(string name, string value)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.Headers.NameValueHeaderValue" /> class.</summary>
	/// <param name="source">A <see cref="T:System.Net.Http.Headers.NameValueHeaderValue" /> object used to initialize the new instance.</param>
	protected internal NameValueHeaderValue(NameValueHeaderValue source)
	{
	}

	internal NameValueHeaderValue()
	{
	}

	internal static NameValueHeaderValue Create(string name, string value)
	{
		return null;
	}

	/// <summary>Creates a new object that is a copy of the current <see cref="T:System.Net.Http.Headers.NameValueHeaderValue" /> instance.</summary>
	/// <returns>A copy of the current instance.</returns>
	object ICloneable.Clone()
	{
		return null;
	}

	/// <summary>Serves as a hash function for an <see cref="T:System.Net.Http.Headers.NameValueHeaderValue" /> object.</summary>
	/// <returns>A hash code for the current object.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Determines whether the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Net.Http.Headers.NameValueHeaderValue" /> object.</summary>
	/// <param name="obj">The object to compare with the current object.</param>
	/// <returns>
	///   <see langword="true" /> if the specified <see cref="T:System.Object" /> is equal to the current object; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	internal static bool TryParsePragma(string input, int minimalCount, out List<NameValueHeaderValue> result)
	{
		result = null;
		return false;
	}

	internal static bool TryParseParameters(Lexer lexer, out List<NameValueHeaderValue> result, out Token t)
	{
		result = null;
		t = default(Token);
		return false;
	}

	/// <summary>Returns a string that represents the current <see cref="T:System.Net.Http.Headers.NameValueHeaderValue" /> object.</summary>
	/// <returns>A string that represents the current object.</returns>
	public override string ToString()
	{
		return null;
	}

	private static bool TryParseElement(Lexer lexer, out NameValueHeaderValue parsedValue, out Token t)
	{
		parsedValue = null;
		t = default(Token);
		return false;
	}
}
