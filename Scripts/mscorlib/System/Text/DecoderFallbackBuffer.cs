namespace System.Text;

/// <summary>Provides a buffer that allows a fallback handler to return an alternate string to a decoder when it cannot decode an input byte sequence.</summary>
public abstract class DecoderFallbackBuffer
{
	internal unsafe byte* byteStart;

	internal unsafe char* charEnd;

	/// <summary>When overridden in a derived class, gets the number of characters in the current <see cref="T:System.Text.DecoderFallbackBuffer" /> object that remain to be processed.</summary>
	/// <returns>The number of characters in the current fallback buffer that have not yet been processed.</returns>
	public abstract int Remaining { get; }

	/// <summary>When overridden in a derived class, prepares the fallback buffer to handle the specified input byte sequence.</summary>
	/// <param name="bytesUnknown">An input array of bytes.</param>
	/// <param name="index">The index position of a byte in <paramref name="bytesUnknown" />.</param>
	/// <returns>
	///   <see langword="true" /> if the fallback buffer can process <paramref name="bytesUnknown" />; <see langword="false" /> if the fallback buffer ignores <paramref name="bytesUnknown" />.</returns>
	public abstract bool Fallback(byte[] bytesUnknown, int index);

	/// <summary>When overridden in a derived class, retrieves the next character in the fallback buffer.</summary>
	/// <returns>The next character in the fallback buffer.</returns>
	public abstract char GetNextChar();

	/// <summary>Initializes all data and state information pertaining to this fallback buffer.</summary>
	public virtual void Reset()
	{
	}

	internal void InternalReset()
	{
	}

	internal unsafe void InternalInitialize(byte* byteStart, char* charEnd)
	{
	}

	internal unsafe virtual bool InternalFallback(byte[] bytes, byte* pBytes, ref char* chars)
	{
		return false;
	}

	internal unsafe virtual int InternalFallback(byte[] bytes, byte* pBytes)
	{
		return 0;
	}

	internal void ThrowLastBytesRecursive(byte[] bytesUnknown)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Text.DecoderFallbackBuffer" /> class.</summary>
	protected DecoderFallbackBuffer()
	{
	}
}
