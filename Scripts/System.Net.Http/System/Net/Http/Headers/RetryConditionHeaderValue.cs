namespace System.Net.Http.Headers;

/// <summary>Represents a Retry-After header value which can either be a date/time or a timespan value.</summary>
public class RetryConditionHeaderValue : ICloneable
{
	/// <summary>Gets the date and time offset from the <see cref="T:System.Net.Http.Headers.RetryConditionHeaderValue" /> object.</summary>
	/// <returns>The date and time offset from the <see cref="T:System.Net.Http.Headers.RetryConditionHeaderValue" /> object.</returns>
	public DateTimeOffset? Date { get; private set; }

	/// <summary>Gets the delta in seconds from the <see cref="T:System.Net.Http.Headers.RetryConditionHeaderValue" /> object.</summary>
	/// <returns>The delta in seconds from the <see cref="T:System.Net.Http.Headers.RetryConditionHeaderValue" /> object.</returns>
	public TimeSpan? Delta { get; private set; }

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.Headers.RetryConditionHeaderValue" /> class.</summary>
	/// <param name="date">The date and time offset used to initialize the new instance.</param>
	public RetryConditionHeaderValue(DateTimeOffset date)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.Headers.RetryConditionHeaderValue" /> class.</summary>
	/// <param name="delta">The delta, in seconds, used to initialize the new instance.</param>
	public RetryConditionHeaderValue(TimeSpan delta)
	{
	}

	/// <summary>Creates a new object that is a copy of the current <see cref="T:System.Net.Http.Headers.RetryConditionHeaderValue" /> instance.</summary>
	/// <returns>A copy of the current instance.</returns>
	object ICloneable.Clone()
	{
		return null;
	}

	/// <summary>Determines whether the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Net.Http.Headers.RetryConditionHeaderValue" /> object.</summary>
	/// <param name="obj">The object to compare with the current object.</param>
	/// <returns>
	///   <see langword="true" /> if the specified <see cref="T:System.Object" /> is equal to the current object; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Serves as a hash function for an <see cref="T:System.Net.Http.Headers.RetryConditionHeaderValue" /> object.</summary>
	/// <returns>A hash code for the current object.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Determines whether a string is valid <see cref="T:System.Net.Http.Headers.RetryConditionHeaderValue" /> information.</summary>
	/// <param name="input">The string to validate.</param>
	/// <param name="parsedValue">The <see cref="T:System.Net.Http.Headers.RetryConditionHeaderValue" /> version of the string.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="input" /> is valid <see cref="T:System.Net.Http.Headers.RetryConditionHeaderValue" /> information; otherwise, <see langword="false" />.</returns>
	public static bool TryParse(string input, out RetryConditionHeaderValue parsedValue)
	{
		parsedValue = null;
		return false;
	}

	/// <summary>Returns a string that represents the current <see cref="T:System.Net.Http.Headers.RetryConditionHeaderValue" /> object.</summary>
	/// <returns>A string that represents the current object.</returns>
	public override string ToString()
	{
		return null;
	}
}
