namespace System.Text;

/// <summary>Provides a buffer that allows a fallback handler to return an alternate string to an encoder when it cannot encode an input character.</summary>
public abstract class EncoderFallbackBuffer
{
	internal unsafe char* charStart;

	internal unsafe char* charEnd;

	internal EncoderNLS encoder;

	internal bool setEncoder;

	internal bool bUsedEncoder;

	internal bool bFallingBack;

	internal int iRecursionCount;

	/// <summary>When overridden in a derived class, gets the number of characters in the current <see cref="T:System.Text.EncoderFallbackBuffer" /> object that remain to be processed.</summary>
	/// <returns>The number of characters in the current fallback buffer that have not yet been processed.</returns>
	public abstract int Remaining { get; }

	/// <summary>When overridden in a derived class, prepares the fallback buffer to handle the specified input character.</summary>
	/// <param name="charUnknown">An input character.</param>
	/// <param name="index">The index position of the character in the input buffer.</param>
	/// <returns>
	///   <see langword="true" /> if the fallback buffer can process <paramref name="charUnknown" />; <see langword="false" /> if the fallback buffer ignores <paramref name="charUnknown" />.</returns>
	public abstract bool Fallback(char charUnknown, int index);

	/// <summary>When overridden in a derived class, prepares the fallback buffer to handle the specified surrogate pair.</summary>
	/// <param name="charUnknownHigh">The high surrogate of the input pair.</param>
	/// <param name="charUnknownLow">The low surrogate of the input pair.</param>
	/// <param name="index">The index position of the surrogate pair in the input buffer.</param>
	/// <returns>
	///   <see langword="true" /> if the fallback buffer can process <paramref name="charUnknownHigh" /> and <paramref name="charUnknownLow" />; <see langword="false" /> if the fallback buffer ignores the surrogate pair.</returns>
	public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index);

	/// <summary>When overridden in a derived class, retrieves the next character in the fallback buffer.</summary>
	/// <returns>The next character in the fallback buffer.</returns>
	public abstract char GetNextChar();

	/// <summary>When overridden in a derived class, causes the next call to the <see cref="M:System.Text.EncoderFallbackBuffer.GetNextChar" /> method to access the data buffer character position that is prior to the current character position.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="M:System.Text.EncoderFallbackBuffer.MovePrevious" /> operation was successful; otherwise, <see langword="false" />.</returns>
	public abstract bool MovePrevious();

	/// <summary>Initializes all data and state information pertaining to this fallback buffer.</summary>
	public virtual void Reset()
	{
	}

	internal void InternalReset()
	{
	}

	internal unsafe void InternalInitialize(char* charStart, char* charEnd, EncoderNLS encoder, bool setEncoder)
	{
	}

	internal char InternalGetNextChar()
	{
		return '\0';
	}

	internal unsafe virtual bool InternalFallback(char ch, ref char* chars)
	{
		return false;
	}

	internal void ThrowLastCharRecursive(int charRecursive)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Text.EncoderFallbackBuffer" /> class.</summary>
	protected EncoderFallbackBuffer()
	{
	}
}
