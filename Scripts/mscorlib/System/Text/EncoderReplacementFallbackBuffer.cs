namespace System.Text;

/// <summary>Represents a substitute input string that is used when the original input character cannot be encoded. This class cannot be inherited.</summary>
public sealed class EncoderReplacementFallbackBuffer : EncoderFallbackBuffer
{
	private string _strDefault;

	private int _fallbackCount;

	private int _fallbackIndex;

	/// <summary>Gets the number of characters in the replacement fallback buffer that remain to be processed.</summary>
	/// <returns>The number of characters in the replacement fallback buffer that have not yet been processed.</returns>
	public override int Remaining => 0;

	/// <summary>Initializes a new instance of the <see cref="T:System.Text.EncoderReplacementFallbackBuffer" /> class using the value of a <see cref="T:System.Text.EncoderReplacementFallback" /> object.</summary>
	/// <param name="fallback">A <see cref="T:System.Text.EncoderReplacementFallback" /> object.</param>
	public EncoderReplacementFallbackBuffer(EncoderReplacementFallback fallback)
	{
	}

	/// <summary>Prepares the replacement fallback buffer to use the current replacement string.</summary>
	/// <param name="charUnknown">An input character. This parameter is ignored in this operation unless an exception is thrown.</param>
	/// <param name="index">The index position of the character in the input buffer. This parameter is ignored in this operation.</param>
	/// <returns>
	///   <see langword="true" /> if the replacement string is not empty; <see langword="false" /> if the replacement string is empty.</returns>
	/// <exception cref="T:System.ArgumentException">This method is called again before the <see cref="M:System.Text.EncoderReplacementFallbackBuffer.GetNextChar" /> method has read all the characters in the replacement fallback buffer.</exception>
	public override bool Fallback(char charUnknown, int index)
	{
		return false;
	}

	/// <summary>Indicates whether a replacement string can be used when an input surrogate pair cannot be encoded, or whether the surrogate pair can be ignored. Parameters specify the surrogate pair and the index position of the pair in the input.</summary>
	/// <param name="charUnknownHigh">The high surrogate of the input pair.</param>
	/// <param name="charUnknownLow">The low surrogate of the input pair.</param>
	/// <param name="index">The index position of the surrogate pair in the input buffer.</param>
	/// <returns>
	///   <see langword="true" /> if the replacement string is not empty; <see langword="false" /> if the replacement string is empty.</returns>
	/// <exception cref="T:System.ArgumentException">This method is called again before the <see cref="M:System.Text.EncoderReplacementFallbackBuffer.GetNextChar" /> method has read all the replacement string characters.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The value of <paramref name="charUnknownHigh" /> is less than U+D800 or greater than U+D8FF.  
	///  -or-  
	///  The value of <paramref name="charUnknownLow" /> is less than U+DC00 or greater than U+DFFF.</exception>
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index)
	{
		return false;
	}

	/// <summary>Retrieves the next character in the replacement fallback buffer.</summary>
	/// <returns>The next Unicode character in the replacement fallback buffer that the application can encode.</returns>
	public override char GetNextChar()
	{
		return '\0';
	}

	/// <summary>Causes the next call to the <see cref="M:System.Text.EncoderReplacementFallbackBuffer.GetNextChar" /> method to access the character position in the replacement fallback buffer prior to the current character position.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="M:System.Text.EncoderReplacementFallbackBuffer.MovePrevious" /> operation was successful; otherwise, <see langword="false" />.</returns>
	public override bool MovePrevious()
	{
		return false;
	}

	/// <summary>Initializes all internal state information and data in this instance of <see cref="T:System.Text.EncoderReplacementFallbackBuffer" />.</summary>
	public override void Reset()
	{
	}
}
