using System.Collections.Generic;

namespace System.Net.Http.Headers;

/// <summary>Represents a value which can either be a product or a comment in a User-Agent header.</summary>
public class ProductInfoHeaderValue : ICloneable
{
	/// <summary>Gets the comment from the <see cref="T:System.Net.Http.Headers.ProductInfoHeaderValue" /> object.</summary>
	/// <returns>The comment value this <see cref="T:System.Net.Http.Headers.ProductInfoHeaderValue" />.</returns>
	public string Comment { get; private set; }

	/// <summary>Gets the product from the <see cref="T:System.Net.Http.Headers.ProductInfoHeaderValue" /> object.</summary>
	/// <returns>The product value from this <see cref="T:System.Net.Http.Headers.ProductInfoHeaderValue" />.</returns>
	public ProductHeaderValue Product { get; private set; }

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.Headers.ProductInfoHeaderValue" /> class.</summary>
	/// <param name="product">A <see cref="T:System.Net.Http.Headers.ProductInfoHeaderValue" /> object used to initialize the new instance.</param>
	public ProductInfoHeaderValue(ProductHeaderValue product)
	{
	}

	private ProductInfoHeaderValue()
	{
	}

	/// <summary>Creates a new object that is a copy of the current <see cref="T:System.Net.Http.Headers.ProductInfoHeaderValue" /> instance.</summary>
	/// <returns>A copy of the current instance.</returns>
	object ICloneable.Clone()
	{
		return null;
	}

	/// <summary>Determines whether the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Net.Http.Headers.ProductInfoHeaderValue" /> object.</summary>
	/// <param name="obj">The object to compare with the current object.</param>
	/// <returns>
	///   <see langword="true" /> if the specified <see cref="T:System.Object" /> is equal to the current object; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Serves as a hash function for an <see cref="T:System.Net.Http.Headers.ProductInfoHeaderValue" /> object.</summary>
	/// <returns>A hash code for the current object.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	internal static bool TryParse(string input, int minimalCount, out List<ProductInfoHeaderValue> result)
	{
		result = null;
		return false;
	}

	private static bool TryParseElement(Lexer lexer, out ProductInfoHeaderValue parsedValue)
	{
		parsedValue = null;
		return false;
	}

	/// <summary>Returns a string that represents the current <see cref="T:System.Net.Http.Headers.ProductInfoHeaderValue" /> object.</summary>
	/// <returns>A string that represents the current object.</returns>
	public override string ToString()
	{
		return null;
	}
}
