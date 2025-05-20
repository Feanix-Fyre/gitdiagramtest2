using System.Runtime.Serialization;

namespace System.Text;

/// <summary>The exception that is thrown when an encoder fallback operation fails. This class cannot be inherited.</summary>
[Serializable]
public sealed class EncoderFallbackException : ArgumentException
{
	private char _charUnknown;

	private char _charUnknownHigh;

	private char _charUnknownLow;

	private int _index;

	/// <summary>Initializes a new instance of the <see cref="T:System.Text.EncoderFallbackException" /> class.</summary>
	public EncoderFallbackException()
	{
	}

	internal EncoderFallbackException(string message, char charUnknown, int index)
	{
	}

	internal EncoderFallbackException(string message, char charUnknownHigh, char charUnknownLow, int index)
	{
	}

	private EncoderFallbackException(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}
}
