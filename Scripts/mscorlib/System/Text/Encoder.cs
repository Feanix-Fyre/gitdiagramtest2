namespace System.Text;

/// <summary>Converts a set of characters into a sequence of bytes.</summary>
[Serializable]
public abstract class Encoder
{
	internal EncoderFallback _fallback;

	internal EncoderFallbackBuffer _fallbackBuffer;

	/// <summary>Gets or sets a <see cref="T:System.Text.EncoderFallback" /> object for the current <see cref="T:System.Text.Encoder" /> object.</summary>
	/// <returns>A <see cref="T:System.Text.EncoderFallback" /> object.</returns>
	/// <exception cref="T:System.ArgumentNullException">The value in a set operation is <see langword="null" /> (<see langword="Nothing" />).</exception>
	/// <exception cref="T:System.ArgumentException">A new value cannot be assigned in a set operation because the current <see cref="T:System.Text.EncoderFallbackBuffer" /> object contains data that has not been encoded yet.</exception>
	/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoder.Fallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
	public EncoderFallback Fallback => null;

	/// <summary>Gets the <see cref="T:System.Text.EncoderFallbackBuffer" /> object associated with the current <see cref="T:System.Text.Encoder" /> object.</summary>
	/// <returns>A <see cref="T:System.Text.EncoderFallbackBuffer" /> object.</returns>
	public EncoderFallbackBuffer FallbackBuffer => null;

	internal bool InternalHasFallbackBuffer => false;

	/// <summary>Initializes a new instance of the <see cref="T:System.Text.Encoder" /> class.</summary>
	protected Encoder()
	{
	}

	/// <summary>When overridden in a derived class, sets the encoder back to its initial state.</summary>
	public virtual void Reset()
	{
	}

	/// <summary>When overridden in a derived class, calculates the number of bytes produced by encoding a set of characters from the specified character array. A parameter indicates whether to clear the internal state of the encoder after the calculation.</summary>
	/// <param name="chars">The character array containing the set of characters to encode.</param>
	/// <param name="index">The index of the first character to encode.</param>
	/// <param name="count">The number of characters to encode.</param>
	/// <param name="flush">
	///   <see langword="true" /> to simulate clearing the internal state of the encoder after the calculation; otherwise, <see langword="false" />.</param>
	/// <returns>The number of bytes produced by encoding the specified characters and any characters in the internal buffer.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="chars" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> or <paramref name="count" /> is less than zero.  
	/// -or-  
	/// <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in <paramref name="chars" />.</exception>
	/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoder.Fallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
	public abstract int GetByteCount(char[] chars, int index, int count, bool flush);

	/// <summary>When overridden in a derived class, calculates the number of bytes produced by encoding a set of characters starting at the specified character pointer. A parameter indicates whether to clear the internal state of the encoder after the calculation.</summary>
	/// <param name="chars">A pointer to the first character to encode.</param>
	/// <param name="count">The number of characters to encode.</param>
	/// <param name="flush">
	///   <see langword="true" /> to simulate clearing the internal state of the encoder after the calculation; otherwise, <see langword="false" />.</param>
	/// <returns>The number of bytes produced by encoding the specified characters and any characters in the internal buffer.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="chars" /> is <see langword="null" /> (<see langword="Nothing" /> in Visual Basic .NET).</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="count" /> is less than zero.</exception>
	/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoder.Fallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
	[CLSCompliant(false)]
	public unsafe virtual int GetByteCount(char* chars, int count, bool flush)
	{
		return 0;
	}

	/// <summary>When overridden in a derived class, encodes a set of characters from the specified character array and any characters in the internal buffer into the specified byte array. A parameter indicates whether to clear the internal state of the encoder after the conversion.</summary>
	/// <param name="chars">The character array containing the set of characters to encode.</param>
	/// <param name="charIndex">The index of the first character to encode.</param>
	/// <param name="charCount">The number of characters to encode.</param>
	/// <param name="bytes">The byte array to contain the resulting sequence of bytes.</param>
	/// <param name="byteIndex">The index at which to start writing the resulting sequence of bytes.</param>
	/// <param name="flush">
	///   <see langword="true" /> to clear the internal state of the encoder after the conversion; otherwise, <see langword="false" />.</param>
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
	///  <see cref="P:System.Text.Encoder.Fallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush);

	/// <summary>When overridden in a derived class, encodes a set of characters starting at the specified character pointer and any characters in the internal buffer into a sequence of bytes that are stored starting at the specified byte pointer. A parameter indicates whether to clear the internal state of the encoder after the conversion.</summary>
	/// <param name="chars">A pointer to the first character to encode.</param>
	/// <param name="charCount">The number of characters to encode.</param>
	/// <param name="bytes">A pointer to the location at which to start writing the resulting sequence of bytes.</param>
	/// <param name="byteCount">The maximum number of bytes to write.</param>
	/// <param name="flush">
	///   <see langword="true" /> to clear the internal state of the encoder after the conversion; otherwise, <see langword="false" />.</param>
	/// <returns>The actual number of bytes written at the location indicated by the <paramref name="bytes" /> parameter.</returns>
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
	///  <see cref="P:System.Text.Encoder.Fallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
	[CLSCompliant(false)]
	public unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush)
	{
		return 0;
	}

	/// <summary>Converts an array of Unicode characters to an encoded byte sequence and stores the result in an array of bytes.</summary>
	/// <param name="chars">An array of characters to convert.</param>
	/// <param name="charIndex">The first element of <paramref name="chars" /> to convert.</param>
	/// <param name="charCount">The number of elements of <paramref name="chars" /> to convert.</param>
	/// <param name="bytes">An array where the converted bytes are stored.</param>
	/// <param name="byteIndex">The first element of <paramref name="bytes" /> in which data is stored.</param>
	/// <param name="byteCount">The maximum number of elements of <paramref name="bytes" /> to use in the conversion.</param>
	/// <param name="flush">
	///   <see langword="true" /> to indicate no further data is to be converted; otherwise, <see langword="false" />.</param>
	/// <param name="charsUsed">When this method returns, contains the number of characters from <paramref name="chars" /> that were used in the conversion. This parameter is passed uninitialized.</param>
	/// <param name="bytesUsed">When this method returns, contains the number of bytes that were produced by the conversion. This parameter is passed uninitialized.</param>
	/// <param name="completed">When this method returns, contains <see langword="true" /> if all the characters specified by <paramref name="charCount" /> were converted; otherwise, <see langword="false" />. This parameter is passed uninitialized.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="chars" /> or <paramref name="bytes" /> is <see langword="null" /> (<see langword="Nothing" />).</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="charIndex" />, <paramref name="charCount" />, <paramref name="byteIndex" />, or <paramref name="byteCount" /> is less than zero.  
	/// -or-  
	/// The length of <paramref name="chars" /> - <paramref name="charIndex" /> is less than <paramref name="charCount" />.  
	/// -or-  
	/// The length of <paramref name="bytes" /> - <paramref name="byteIndex" /> is less than <paramref name="byteCount" />.</exception>
	/// <exception cref="T:System.ArgumentException">The output buffer is too small to contain any of the converted input. The output buffer should be greater than or equal to the size indicated by the <see cref="Overload:System.Text.Encoder.GetByteCount" /> method.</exception>
	/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoder.Fallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
	public virtual void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed)
	{
		charsUsed = default(int);
		bytesUsed = default(int);
		completed = default(bool);
	}

	/// <summary>Converts a buffer of Unicode characters to an encoded byte sequence and stores the result in another buffer.</summary>
	/// <param name="chars">The address of a string of UTF-16 encoded characters to convert.</param>
	/// <param name="charCount">The number of characters in <paramref name="chars" /> to convert.</param>
	/// <param name="bytes">The address of a buffer to store the converted bytes.</param>
	/// <param name="byteCount">The maximum number of bytes in <paramref name="bytes" /> to use in the conversion.</param>
	/// <param name="flush">
	///   <see langword="true" /> to indicate no further data is to be converted; otherwise, <see langword="false" />.</param>
	/// <param name="charsUsed">When this method returns, contains the number of characters from <paramref name="chars" /> that were used in the conversion. This parameter is passed uninitialized.</param>
	/// <param name="bytesUsed">When this method returns, contains the number of bytes that were used in the conversion. This parameter is passed uninitialized.</param>
	/// <param name="completed">When this method returns, contains <see langword="true" /> if all the characters specified by <paramref name="charCount" /> were converted; otherwise, <see langword="false" />. This parameter is passed uninitialized.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="chars" /> or <paramref name="bytes" /> is <see langword="null" /> (<see langword="Nothing" />).</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="charCount" /> or <paramref name="byteCount" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">The output buffer is too small to contain any of the converted input. The output buffer should be greater than or equal to the size indicated by the <see cref="Overload:System.Text.Encoder.GetByteCount" /> method.</exception>
	/// <exception cref="T:System.Text.EncoderFallbackException">A fallback occurred (see Character Encoding in the .NET Framework for fuller explanation)  
	///  -and-  
	///  <see cref="P:System.Text.Encoder.Fallback" /> is set to <see cref="T:System.Text.EncoderExceptionFallback" />.</exception>
	[CLSCompliant(false)]
	public unsafe virtual void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed)
	{
		charsUsed = default(int);
		bytesUsed = default(int);
		completed = default(bool);
	}
}
