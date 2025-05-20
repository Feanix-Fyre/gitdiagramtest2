namespace System.Text;

/// <summary>Represents a UTF-7 encoding of Unicode characters.</summary>
[Serializable]
public class UTF7Encoding : Encoding
{
	[Serializable]
	private sealed class Decoder : DecoderNLS
	{
		internal int bits;

		internal int bitCount;

		internal bool firstByte;

		internal override bool HasState => false;

		public Decoder(UTF7Encoding encoding)
			: base(null)
		{
		}

		public override void Reset()
		{
		}
	}

	[Serializable]
	private sealed class Encoder : EncoderNLS
	{
		internal int bits;

		internal int bitCount;

		internal override bool HasState => false;

		public Encoder(UTF7Encoding encoding)
			: base(null)
		{
		}

		public override void Reset()
		{
		}
	}

	[Serializable]
	private sealed class DecoderUTF7Fallback : DecoderFallback
	{
		public override int MaxCharCount => 0;

		public override DecoderFallbackBuffer CreateFallbackBuffer()
		{
			return null;
		}

		public override bool Equals(object value)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}

	private sealed class DecoderUTF7FallbackBuffer : DecoderFallbackBuffer
	{
		private char cFallback;

		private int iCount;

		private int iSize;

		public override int Remaining => 0;

		public DecoderUTF7FallbackBuffer(DecoderUTF7Fallback fallback)
		{
		}

		public override bool Fallback(byte[] bytesUnknown, int index)
		{
			return false;
		}

		public override char GetNextChar()
		{
			return '\0';
		}

		public override void Reset()
		{
		}

		internal unsafe override int InternalFallback(byte[] bytes, byte* pBytes)
		{
			return 0;
		}
	}

	internal static readonly UTF7Encoding s_default;

	private byte[] _base64Bytes;

	private sbyte[] _base64Values;

	private bool[] _directEncode;

	private bool _allowOptionals;

	/// <summary>Initializes a new instance of the <see cref="T:System.Text.UTF7Encoding" /> class.</summary>
	public UTF7Encoding()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Text.UTF7Encoding" /> class. A parameter specifies whether to allow optional characters.</summary>
	/// <param name="allowOptionals">
	///   <see langword="true" /> to specify that optional characters are allowed; otherwise, <see langword="false" />.</param>
	public UTF7Encoding(bool allowOptionals)
	{
	}

	private void MakeTables()
	{
	}

	internal override void SetDefaultFallbacks()
	{
	}

	/// <summary>Gets a value indicating whether the specified object is equal to the current <see cref="T:System.Text.UTF7Encoding" /> object.</summary>
	/// <param name="value">An object to compare to the current <see cref="T:System.Text.UTF7Encoding" /> object.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value" /> is a <see cref="T:System.Text.UTF7Encoding" /> object and is equal to the current <see cref="T:System.Text.UTF7Encoding" /> object; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object value)
	{
		return false;
	}

	/// <summary>Returns the hash code for the current <see cref="T:System.Text.UTF7Encoding" /> object.</summary>
	/// <returns>A 32-bit signed integer hash code.</returns>
	public override int GetHashCode()
	{
		return 0;
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
	/// The resulting number of bytes is greater than the maximum number that can be returned as an int.</exception>
	/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
	public override int GetByteCount(char[] chars, int index, int count)
	{
		return 0;
	}

	/// <summary>Calculates the number of bytes produced by encoding the characters in the specified <see cref="T:System.String" /> object.</summary>
	/// <param name="s">The <see cref="T:System.String" /> object containing the set of characters to encode.</param>
	/// <returns>The number of bytes produced by encoding the specified characters.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="s" /> is <see langword="null" /> (<see langword="Nothing" />).</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting number of bytes is greater than the maximum number that can be returned as an int.</exception>
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
	///   <paramref name="chars" /> is <see langword="null" /> (<see langword="Nothing" /> in Visual Basic .NET).</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="count" /> is less than zero.  
	/// -or-  
	/// The resulting number of bytes is greater than the maximum number that can be returned as an int.</exception>
	/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.EncoderFallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
	[CLSCompliant(false)]
	public unsafe override int GetByteCount(char* chars, int count)
	{
		return 0;
	}

	/// <summary>Encodes a set of characters from the specified <see cref="T:System.String" /> into the specified byte array.</summary>
	/// <param name="s">The <see cref="T:System.String" /> containing the set of characters to encode.</param>
	/// <param name="charIndex">The index of the first character to encode.</param>
	/// <param name="charCount">The number of characters to encode.</param>
	/// <param name="bytes">The byte array to contain the resulting sequence of bytes.</param>
	/// <param name="byteIndex">The index at which to start writing the resulting sequence of bytes.</param>
	/// <returns>The actual number of bytes written into <paramref name="bytes" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="s" /> is <see langword="null" /> (<see langword="Nothing" />).  
	/// -or-  
	/// <paramref name="bytes" /> is <see langword="null" /> (<see langword="Nothing" />).</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="charIndex" /> or <paramref name="charCount" /> or <paramref name="byteIndex" /> is less than zero.  
	/// -or-  
	/// <paramref name="charIndex" /> and <paramref name="charCount" /> do not denote a valid range in <paramref name="chars" />.  
	/// -or-  
	/// <paramref name="byteIndex" /> is not a valid index in <paramref name="bytes" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="bytes" /> does not have enough capacity from <paramref name="byteIndex" /> to the end of the array to accommodate the resulting bytes.</exception>
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
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="bytes" /> does not have enough capacity from <paramref name="byteIndex" /> to the end of the array to accommodate the resulting bytes.</exception>
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
	/// <returns>The actual number of bytes written at the location indicated by <paramref name="bytes" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="chars" /> is <see langword="null" /> (<see langword="Nothing" />).  
	/// -or-  
	/// <paramref name="bytes" /> is <see langword="null" /> (<see langword="Nothing" />).</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="charCount" /> or <paramref name="byteCount" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="byteCount" /> is less than the resulting number of bytes.</exception>
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
	/// The resulting number of characters is greater than the maximum number that can be returned as an int.</exception>
	/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)  
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
	/// The resulting number of characters is greater than the maximum number that can be returned as an int.</exception>
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
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="chars" /> does not have enough capacity from <paramref name="charIndex" /> to the end of the array to accommodate the resulting characters.</exception>
	/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)  
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
	/// <returns>The actual number of characters written at the location indicated by <paramref name="chars" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="bytes" /> is <see langword="null" /> (<see langword="Nothing" />).  
	/// -or-  
	/// <paramref name="chars" /> is <see langword="null" /> (<see langword="Nothing" />).</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="byteCount" /> or <paramref name="charCount" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="charCount" /> is less than the resulting number of characters.</exception>
	/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)  
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
	/// <returns>A <see cref="T:System.String" /> containing the results of decoding the specified sequence of bytes.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="bytes" /> is <see langword="null" /> (<see langword="Nothing" />).</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> or <paramref name="count" /> is less than zero.  
	/// -or-  
	/// <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="bytes" />.</exception>
	/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
	public override string GetString(byte[] bytes, int index, int count)
	{
		return null;
	}

	internal unsafe override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder)
	{
		return 0;
	}

	internal unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder)
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

	/// <summary>Obtains a decoder that converts a UTF-7 encoded sequence of bytes into a sequence of Unicode characters.</summary>
	/// <returns>A <see cref="T:System.Text.Decoder" /> that converts a UTF-7 encoded sequence of bytes into a sequence of Unicode characters.</returns>
	public override System.Text.Decoder GetDecoder()
	{
		return null;
	}

	/// <summary>Obtains an encoder that converts a sequence of Unicode characters into a UTF-7 encoded sequence of bytes.</summary>
	/// <returns>A <see cref="T:System.Text.Encoder" /> that converts a sequence of Unicode characters into a UTF-7 encoded sequence of bytes.</returns>
	public override System.Text.Encoder GetEncoder()
	{
		return null;
	}

	/// <summary>Calculates the maximum number of bytes produced by encoding the specified number of characters.</summary>
	/// <param name="charCount">The number of characters to encode.</param>
	/// <returns>The maximum number of bytes produced by encoding the specified number of characters.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="charCount" /> is less than zero.  
	/// -or-  
	/// The resulting number of bytes is greater than the maximum number that can be returned as an int.</exception>
	/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)  
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
	/// The resulting number of characters is greater than the maximum number that can be returned as an int.</exception>
	/// <exception cref="T:System.Text.DecoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for complete explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoding.DecoderFallback" /> is set to <see cref="T:System.Text.DecoderExceptionFallback" />.</exception>
	public override int GetMaxCharCount(int byteCount)
	{
		return 0;
	}
}
