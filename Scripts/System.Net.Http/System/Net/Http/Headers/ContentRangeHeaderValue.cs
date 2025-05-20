namespace System.Net.Http.Headers;

/// <summary>Represents the value of the Content-Range header.</summary>
public class ContentRangeHeaderValue : ICloneable
{
	private string unit;

	/// <summary>Gets the position at which to start sending data.</summary>
	/// <returns>The position, in bytes, at which to start sending data.</returns>
	public long? From { get; private set; }

	/// <summary>Gets the length of the full entity-body.</summary>
	/// <returns>The length of the full entity-body.</returns>
	public long? Length { get; private set; }

	/// <summary>Gets the position at which to stop sending data.</summary>
	/// <returns>The position at which to stop sending data.</returns>
	public long? To { get; private set; }

	/// <summary>The range units used.</summary>
	/// <returns>A <see cref="T:System.String" /> that contains range units.</returns>
	public string Unit => null;

	private ContentRangeHeaderValue()
	{
	}

	/// <summary>Creates a new object that is a copy of the current <see cref="T:System.Net.Http.Headers.ContentRangeHeaderValue" /> instance.</summary>
	/// <returns>A copy of the current instance.</returns>
	object ICloneable.Clone()
	{
		return null;
	}

	/// <summary>Determines whether the specified Object is equal to the current <see cref="T:System.Net.Http.Headers.ContentRangeHeaderValue" /> object.</summary>
	/// <param name="obj">The object to compare with the current object.</param>
	/// <returns>
	///   <see langword="true" /> if the specified <see cref="T:System.Object" /> is equal to the current object; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Serves as a hash function for an <see cref="T:System.Net.Http.Headers.ContentRangeHeaderValue" /> object.</summary>
	/// <returns>A hash code for the current object.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Determines whether a string is valid <see cref="T:System.Net.Http.Headers.ContentRangeHeaderValue" /> information.</summary>
	/// <param name="input">The string to validate.</param>
	/// <param name="parsedValue">The <see cref="T:System.Net.Http.Headers.ContentRangeHeaderValue" /> version of the string.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="input" /> is valid <see cref="T:System.Net.Http.Headers.ContentRangeHeaderValue" /> information; otherwise, <see langword="false" />.</returns>
	public static bool TryParse(string input, out ContentRangeHeaderValue parsedValue)
	{
		parsedValue = null;
		return false;
	}

	/// <summary>Returns a string that represents the current <see cref="T:System.Net.Http.Headers.ContentRangeHeaderValue" /> object.</summary>
	/// <returns>A string that represents the current object.</returns>
	public override string ToString()
	{
		return null;
	}
}
