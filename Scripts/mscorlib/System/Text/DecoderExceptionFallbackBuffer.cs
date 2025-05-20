namespace System.Text;

/// <summary>Throws <see cref="T:System.Text.DecoderFallbackException" /> when an encoded input byte sequence cannot be converted to a decoded output character. This class cannot be inherited.</summary>
public sealed class DecoderExceptionFallbackBuffer : DecoderFallbackBuffer
{
	/// <summary>Gets the number of characters in the current <see cref="T:System.Text.DecoderExceptionFallbackBuffer" /> object that remain to be processed.</summary>
	/// <returns>The return value is always zero.  
	///  A return value is defined, although it is unchanging, because this method implements an abstract method.</returns>
	public override int Remaining => 0;

	/// <summary>Throws <see cref="T:System.Text.DecoderFallbackException" /> when the input byte sequence cannot be decoded. The nominal return value is not used.</summary>
	/// <param name="bytesUnknown">An input array of bytes.</param>
	/// <param name="index">The index position of a byte in the input.</param>
	/// <returns>None. No value is returned because the <see cref="M:System.Text.DecoderExceptionFallbackBuffer.Fallback(System.Byte[],System.Int32)" /> method always throws an exception.  
	///  The nominal return value is <see langword="true" />. A return value is defined, although it is unchanging, because this method implements an abstract method.</returns>
	/// <exception cref="T:System.Text.DecoderFallbackException">This method always throws an exception that reports the value and index position of the input byte that cannot be decoded.</exception>
	public override bool Fallback(byte[] bytesUnknown, int index)
	{
		return false;
	}

	/// <summary>Retrieves the next character in the exception data buffer.</summary>
	/// <returns>The return value is always the Unicode character NULL (U+0000).  
	///  A return value is defined, although it is unchanging, because this method implements an abstract method.</returns>
	public override char GetNextChar()
	{
		return '\0';
	}

	private void Throw(byte[] bytesUnknown, int index)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Text.DecoderExceptionFallbackBuffer" /> class.</summary>
	public DecoderExceptionFallbackBuffer()
	{
	}
}
