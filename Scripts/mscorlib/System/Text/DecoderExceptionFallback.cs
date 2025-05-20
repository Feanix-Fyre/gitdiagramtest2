namespace System.Text;

/// <summary>Provides a failure-handling mechanism, called a fallback, for an encoded input byte sequence that cannot be converted to an input character. The fallback throws an exception instead of decoding the input byte sequence. This class cannot be inherited.</summary>
[Serializable]
public sealed class DecoderExceptionFallback : DecoderFallback
{
	/// <summary>Gets the maximum number of characters this instance can return.</summary>
	/// <returns>The return value is always zero.</returns>
	public override int MaxCharCount => 0;

	/// <summary>Initializes a new instance of the <see cref="T:System.Text.DecoderExceptionFallback" /> class.</summary>
	public DecoderExceptionFallback()
	{
	}

	/// <summary>Returns a decoder fallback buffer that throws an exception if it cannot convert a sequence of bytes to a character.</summary>
	/// <returns>A decoder fallback buffer that throws an exception when it cannot decode a byte sequence.</returns>
	public override DecoderFallbackBuffer CreateFallbackBuffer()
	{
		return null;
	}

	/// <summary>Indicates whether the current <see cref="T:System.Text.DecoderExceptionFallback" /> object and a specified object are equal.</summary>
	/// <param name="value">An object that derives from the <see cref="T:System.Text.DecoderExceptionFallback" /> class.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value" /> is not <see langword="null" /> and is a <see cref="T:System.Text.DecoderExceptionFallback" /> object; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object value)
	{
		return false;
	}

	/// <summary>Retrieves the hash code for this instance.</summary>
	/// <returns>The return value is always the same arbitrary value, and has no special significance.</returns>
	public override int GetHashCode()
	{
		return 0;
	}
}
