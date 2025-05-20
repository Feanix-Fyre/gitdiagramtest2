using System.Collections.Generic;

namespace System.Net.Http.Headers;

/// <summary>Represents a product token value in a User-Agent header.</summary>
public class ProductHeaderValue : ICloneable
{
	/// <summary>Gets the name of the product token.</summary>
	/// <returns>The name of the product token.</returns>
	public string Name { get; internal set; }

	/// <summary>Gets the version of the product token.</summary>
	/// <returns>The version of the product token.</returns>
	public string Version { get; internal set; }

	internal ProductHeaderValue()
	{
	}

	/// <summary>Creates a new object that is a copy of the current <see cref="T:System.Net.Http.Headers.ProductHeaderValue" /> instance.</summary>
	/// <returns>A copy of the current instance.</returns>
	object ICloneable.Clone()
	{
		return null;
	}

	/// <summary>Determines whether the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Net.Http.Headers.ProductHeaderValue" /> object.</summary>
	/// <param name="obj">The object to compare with the current object.</param>
	/// <returns>
	///   <see langword="true" /> if the specified <see cref="T:System.Object" /> is equal to the current object; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Serves as a hash function for an <see cref="T:System.Net.Http.Headers.ProductHeaderValue" /> object.</summary>
	/// <returns>A hash code for the current object.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	internal static bool TryParse(string input, int minimalCount, out List<ProductHeaderValue> result)
	{
		result = null;
		return false;
	}

	private static bool TryParseElement(Lexer lexer, out ProductHeaderValue parsedValue, out Token t)
	{
		parsedValue = null;
		t = default(Token);
		return false;
	}

	/// <summary>Returns a string that represents the current <see cref="T:System.Net.Http.Headers.ProductHeaderValue" /> object.</summary>
	/// <returns>A string that represents the current object.</returns>
	public override string ToString()
	{
		return null;
	}
}
