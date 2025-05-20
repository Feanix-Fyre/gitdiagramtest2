namespace System.Text;

/// <summary>Represents a UTF-16 encoding of Unicode characters.</summary>
[Serializable]
public class UnicodeEncoding : Encoding
{
	[Serializable]
	private sealed class Decoder : DecoderNLS
	{
		internal int lastByte;

		internal char lastChar;

		internal override bool HasState => false;

		public Decoder(UnicodeEncoding encoding)
			: base(null)
		{
		}

		public override void Reset()
		{
		}
	}

	internal static readonly UnicodeEncoding s_bigEndianDefault;

	internal static readonly UnicodeEncoding s_littleEndianDefault;

	private static readonly byte[] s_bigEndianPreamble;

	private static readonly byte[] s_littleEndianPreamble;

	internal bool isThrowException;

	internal bool bigEndian;

	internal bool byteOrderMark;

	private static readonly ulong highLowPatternMask;

	public override ReadOnlySpan<byte> Preamble => default(ReadOnlySpan<byte>);

	/// <summary>Initializes a new instance of the <see cref="T:System.Text.UnicodeEncoding" /> class.</summary>
	public UnicodeEncoding()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Text.UnicodeEncoding" /> class. Parameters specify whether to use the big endian byte order and whether the <see cref="M:System.Text.UnicodeEncoding.GetPreamble" /> method returns a Unicode byte order mark.</summary>
	/// <param name="bigEndian">
	///   <see langword="true" /> to use the big endian byte order (most significant byte first), or <see langword="false" /> to use the little endian byte order (least significant byte first).</param>
	/// <param name="byteOrderMark">
	///   <see langword="true" /> to specify that the <see cref="M:System.Text.UnicodeEncoding.GetPreamble" /> method returns a Unicode byte order mark; otherwise, <see langword="false" />.</param>
	public UnicodeEncoding(bool bigEndian, bool byteOrderMark)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Text.UnicodeEncoding" /> class. Parameters specify whether to use the big endian byte order, whether to provide a Unicode byte order mark, and whether to throw an exception when an invalid encoding is detected.</summary>
	/// <param name="bigEndian">
	///   <see langword="true" /> to use the big endian byte order (most significant byte first); <see langword="false" /> to use the little endian byte order (least significant byte first).</param>
	/// <param name="byteOrderMark">
	///   <see langword="true" /> to specify that the <see cref="M:System.Text.UnicodeEncoding.GetPreamble" /> method returns a Unicode byte order mark; otherwise, <see langword="false" />.</param>
	/// <param name="throwOnInvalidBytes">
	///   <see langword="true" /> to specify that an exception should be thrown when an invalid encoding is detected; otherwise, <see langword="false" />.</param>
	public UnicodeEncoding(bool bigEndian, bool byteOrderMark, bool throwOnInvalidBytes)
	{
	}

	internal override void SetDefaultFallbacks()
	{
	}

	/// <summary>Calculates the number of bytes produced by encoding a set of characters from the specified character array.</summary>
	/// <param name="chars">The character array containing the set of characters to encode.</param>
	/// <param name="index">The index of the first character to encode.</param>
	/// <param name="count">The number of characters to encode.</param>
	/// <returns>The number of bytes produced by encoding the specified characters.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="chars" /> is <see langword="null" /> (<see langword="Nothing" />).</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> or <paramref name="count" /> is less than zero.  
	/// -or-  
	/// <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="chars" />.  
	/// -or-  
	/// The resulting number of bytes is greater than the maximum number that can be returned as an integer.</exception>
	/// <exception cref="T:System.ArgumentException">Error detection is enabled, and <paramref name="chars" /> contains an invalid sequence of characters.</exception>
	/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
	public override int GetByteCount(char[] chars, int index, int count)
	{
		return 0;
	}

	/// <summary>Calculates the number of bytes produced by encoding the characters in the specified string.</summary>
	/// <param name="s">The string that contains the set of characters to encode.</param>
	/// <returns>The number of bytes produced by encoding the specified characters.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="s" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting number of bytes is greater than the maximum number that can be returned as an integer.</exception>
	/// <exception cref="T:System.ArgumentException">Error detection is enabled, and <paramref name="s" /> contains an invalid sequence of characters.</exception>
	/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
	public override int GetByteCount(string s)
	{
		return 0;
	}

	/// <summary>Calculates the number of bytes produced by encoding a set of characters starting at the specified character pointer.</summary>
	/// <param name="chars">A pointer to the first character to encode.</param>
	/// <param name="count">The number of characters to encode.</param>
	/// <returns>The number of bytes produced by encoding the specified characters.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="chars" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="count" /> is less than zero.  
	/// -or-  
	/// The resulting number of bytes is greater than the maximum number that can be returned as an integer.</exception>
	/// <exception cref="T:System.ArgumentException">Error detection is enabled and <paramref name="chars" /> contains an invalid sequence of characters.</exception>
	/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
	[CLSCompliant(false)]
	public unsafe override int GetByteCount(char* chars, int count)
	{
		return 0;
	}

	/// <summary>Encodes a set of characters from the specified <see cref="T:System.String" /> into the specified byte array.</summary>
	/// <param name="s">The string containing the set of characters to encode.</param>
	/// <param name="charIndex">The index of the first character to encode.</param>
	/// <param name="charCount">The number of characters to encode.</param>
	/// <param name="bytes">The byte array to contain the resulting sequence of bytes.</param>
	/// <param name="byteIndex">The index at which to start writing the resulting sequence of bytes.</param>
	/// <returns>The actual number of bytes written into <paramref name="bytes" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="s" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="bytes" /> is <see langword="null" /> (<see langword="Nothing" />).</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="charIndex" /> or <paramref name="charCount" /> or <paramref name="byteIndex" /> is less than zero.  
	/// -or-  
	/// <paramref name="charIndex" /> and <paramref name="charCount" /> do not denote a valid range in <paramref name="chars" />.  
	/// -or-  
	/// <paramref name="byteIndex" /> is not a valid index in <paramref name="bytes" />.</exception>
	/// <exception cref="T:System.ArgumentException">Error detection is enabled, and <paramref name="s" /> contains an invalid sequence of characters.  
	///  -or-  
	///  <paramref name="bytes" /> does not have enough capacity from <paramref name="byteIndex" /> to the end of the array to accommodate the resulting bytes.</exception>
	/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex)
	{
		return 0;
	}

	/// <summary>Encodes a set of characters from the specified character array into the specified byte array.</summary>
	/// <param name="chars">The character array containing the set of characters to encode.</param>
	/// <param name="charIndex">The index of the first character to encode.</param>
	/// <param name="charCount">The number of characters to encode.</param>
	/// <param name="bytes">The byte array to contain the resulting sequence of bytes.</param>
	/// <param name="byteIndex">The index at which to start writing the resulting sequence of bytes.</param>
	/// <returns>The actual number of bytes written into <paramref name="bytes" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="chars" /> is <see langword="null" /> (<see langword="Nothing" />).  
	/// -or-  
	/// <paramref name="bytes" /> is <see langword="null" /> (<see langword="Nothing" />).</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="charIndex" /> or <paramref name="charCount" /> or <paramref name="byteIndex" /> is less than zero.  
	/// -or-  
	/// <paramref name="charIndex" /> and <paramref name="charCount" /> do not denote a valid range in <paramref name="chars" />.  
	/// -or-  
	/// <paramref name="byteIndex" /> is not a valid index in <paramref name="bytes" />.</exception>
	/// <exception cref="T:System.ArgumentException">Error detection is enabled, and <paramref name="chars" /> contains an invalid sequence of characters.  
	///  -or-  
	///  <paramref name="bytes" /> does not have enough capacity from <paramref name="byteIndex" /> to the end of the array to accommodate the resulting bytes.</exception>
	/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
	{
		return 0;
	}

	/// <summary>Encodes a set of characters starting at the specified character pointer into a sequence of bytes that are stored starting at the specified byte pointer.</summary>
	/// <param name="chars">A pointer to the first character to encode.</param>
	/// <param name="charCount">The number of characters to encode.</param>
	/// <param name="bytes">A pointer to the location at which to start writing the resulting sequence of bytes.</param>
	/// <param name="byteCount">The maximum number of bytes to write.</param>
	/// <returns>The actual number of bytes written at the location indicated by the <paramref name="bytes" /> parameter.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="chars" /> is <see langword="null" /> (<see langword="Nothing" />).  
	/// -or-  
	/// <paramref name="bytes" /> is <see langword="null" /> (<see langword="Nothing" />).</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="charCount" /> or <paramref name="byteCount" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">Error detection is enabled, and <paramref name="chars" /> contains an invalid sequence of characters.  
	///  -or-  
	///  <paramref name="byteCount" /> is less than the resulting number of bytes.</exception>
	/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
	[CLSCompliant(false)]
	public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount)
	{
		return 0;
	}

	/// <summary>Calculates the number of characters produced by decoding a sequence of bytes from the specified byte array.</summary>
	/// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
	/// <param name="index">The index of the first byte to decode.</param>
	/// <param name="count">The number of bytes to decode.</param>
	/// <returns>The number of characters produced by decoding the specified sequence of bytes.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="bytes" /> is <see langword="null" /> (<see langword="Nothing" />).</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> or <paramref name="count" /> is less than zero.  
	/// -or-  
	/// <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="bytes" />.  
	/// -or-  
	/// The resulting number of bytes is greater than the maximum number that can be returned as an integer.</exception>
	/// <exception cref="T:System.ArgumentException">Error detection is enabled, and <paramref name="bytes" /> contains an invalid sequence of bytes.</exception>
	/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
	public override int GetCharCount(byte[] bytes, int index, int count)
	{
		return 0;
	}

	/// <summary>Calculates the number of characters produced by decoding a sequence of bytes starting at the specified byte pointer.</summary>
	/// <param name="bytes">A pointer to the first byte to decode.</param>
	/// <param name="count">The number of bytes to decode.</param>
	/// <returns>The number of characters produced by decoding the specified sequence of bytes.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="bytes" /> is <see langword="null" /> (<see langword="Nothing" />).</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="count" /> is less than zero.  
	/// -or-  
	/// The resulting number of bytes is greater than the maximum number that can be returned as an integer.</exception>
	/// <exception cref="T:System.ArgumentException">Error detection is enabled, and <paramref name="bytes" /> contains an invalid sequence of bytes.</exception>
	/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
	[CLSCompliant(false)]
	public unsafe override int GetCharCount(byte* bytes, int count)
	{
		return 0;
	}

	/// <summary>Decodes a sequence of bytes from the specified byte array into the specified character array.</summary>
	/// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
	/// <param name="byteIndex">The index of the first byte to decode.</param>
	/// <param name="byteCount">The number of bytes to decode.</param>
	/// <param name="chars">The character array to contain the resulting set of characters.</param>
	/// <param name="charIndex">The index at which to start writing the resulting set of characters.</param>
	/// <returns>The actual number of characters written into <paramref name="chars" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="bytes" /> is <see langword="null" /> (<see langword="Nothing" />).  
	/// -or-  
	/// <paramref name="chars" /> is <see langword="null" /> (<see langword="Nothing" />).</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="byteIndex" /> or <paramref name="byteCount" /> or <paramref name="charIndex" /> is less than zero.  
	/// -or-  
	/// <paramref name="byteindex" /> and <paramref name="byteCount" /> do not denote a valid range in <paramref name="bytes" />.  
	/// -or-  
	/// <paramref name="charIndex" /> is not a valid index in <paramref name="chars" />.</exception>
	/// <exception cref="T:System.ArgumentException">Error detection is enabled, and <paramref name="bytes" /> contains an invalid sequence of bytes.  
	///  -or-  
	///  <paramref name="chars" /> does not have enough capacity from <paramref name="charIndex" /> to the end of the array to accommodate the resulting characters.</exception>
	/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
	{
		return 0;
	}

	/// <summary>Decodes a sequence of bytes starting at the specified byte pointer into a set of characters that are stored starting at the specified character pointer.</summary>
	/// <param name="bytes">A pointer to the first byte to decode.</param>
	/// <param name="byteCount">The number of bytes to decode.</param>
	/// <param name="chars">A pointer to the location at which to start writing the resulting set of characters.</param>
	/// <param name="charCount">The maximum number of characters to write.</param>
	/// <returns>The actual number of characters written at the location indicated by the <paramref name="chars" /> parameter.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="bytes" /> is <see langword="null" /> (<see langword="Nothing" />).  
	/// -or-  
	/// <paramref name="chars" /> is <see langword="null" /> (<see langword="Nothing" />).</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="byteCount" /> or <paramref name="charCount" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">Error detection is enabled, and <paramref name="bytes" /> contains an invalid sequence of bytes.  
	///  -or-  
	///  <paramref name="charCount" /> is less than the resulting number of characters.</exception>
	/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
	[CLSCompliant(false)]
	public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount)
	{
		return 0;
	}

	/// <summary>Decodes a range of bytes from a byte array into a string.</summary>
	/// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
	/// <param name="index">The index of the first byte to decode.</param>
	/// <param name="count">The number of bytes to decode.</param>
	/// <returns>A <see cref="T:System.String" /> object containing the results of decoding the specified sequence of bytes.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="bytes" /> is <see langword="null" /> (<see langword="Nothing" />).</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> or <paramref name="count" /> is less than zero.  
	/// -or-  
	/// <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="bytes" />.</exception>
	/// <exception cref="T:System.ArgumentException">Error detection is enabled, and <paramref name="bytes" /> contains an invalid sequence of bytes.</exception>
	/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
	public override string GetString(byte[] bytes, int index, int count)
	{
		return null;
	}

	internal unsafe override int GetByteCount(char* chars, int count, EncoderNLS encoder)
	{
		return 0;
	}

	internal unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder)
	{
		return 0;
	}

	internal unsafe override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder)
	{
		return 0;
	}

	internal unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder)
	{
		return 0;
	}

	/// <summary>Obtains an encoder that converts a sequence of Unicode characters into a UTF-16 encoded sequence of bytes.</summary>
	/// <returns>A <see cref="T:System.Text.Encoder" /> object that converts a sequence of Unicode characters into a UTF-16 encoded sequence of bytes.</returns>
	public override Encoder GetEncoder()
	{
		return null;
	}

	/// <summary>Obtains a decoder that converts a UTF-16 encoded sequence of bytes into a sequence of Unicode characters.</summary>
	/// <returns>A <see cref="T:System.Text.Decoder" /> that converts a UTF-16 encoded sequence of bytes into a sequence of Unicode characters.</returns>
	public override System.Text.Decoder GetDecoder()
	{
		return null;
	}

	/// <summary>Returns a Unicode byte order mark encoded in UTF-16 format, if the constructor for this instance requests a byte order mark.</summary>
	/// <returns>A byte array containing the Unicode byte order mark, if the <see cref="T:System.Text.UnicodeEncoding" /> object is configured to supply one. Otherwise, this method returns a zero-length byte array.</returns>
	public override byte[] GetPreamble()
	{
		return null;
	}

	/// <summary>Calculates the maximum number of bytes produced by encoding the specified number of characters.</summary>
	/// <param name="charCount">The number of characters to encode.</param>
	/// <returns>The maximum number of bytes produced by encoding the specified number of characters.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="charCount" /> is less than zero.  
	/// -or-  
	/// The resulting number of bytes is greater than the maximum number that can be returned as an integer.</exception>
	/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
	public override int GetMaxByteCount(int charCount)
	{
		return 0;
	}

	/// <summary>Calculates the maximum number of characters produced by decoding the specified number of bytes.</summary>
	/// <param name="byteCount">The number of bytes to decode.</param>
	/// <returns>The maximum number of characters produced by decoding the specified number of bytes.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="byteCount" /> is less than zero.  
	/// -or-  
	/// The resulting number of bytes is greater than the maximum number that can be returned as an integer.</exception>
	/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
	public override int GetMaxCharCount(int byteCount)
	{
		return 0;
	}

	/// <summary>Determines whether the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Text.UnicodeEncoding" /> object.</summary>
	/// <param name="value">The object to compare with the current object.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value" /> is an instance of <see cref="T:System.Text.UnicodeEncoding" /> and is equal to the current object; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object value)
	{
		return false;
	}

	/// <summary>Returns the hash code for the current instance.</summary>
	/// <returns>The hash code for the current <see cref="T:System.Text.UnicodeEncoding" /> object.</returns>
	public override int GetHashCode()
	{
		return 0;
	}
}
