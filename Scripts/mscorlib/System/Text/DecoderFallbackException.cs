using System.Runtime.Serialization;

namespace System.Text;

/// <summary>The exception that is thrown when a decoder fallback operation fails. This class cannot be inherited.</summary>
[Serializable]
public sealed class DecoderFallbackException : ArgumentException
{
	private byte[] _bytesUnknown;

	private int _index;

	/// <summary>Initializes a new instance of the <see cref="T:System.Text.DecoderFallbackException" /> class.</summary>
	public DecoderFallbackException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Text.DecoderFallbackException" /> class. Parameters specify the error message, the array of bytes being decoded, and the index of the byte that cannot be decoded.</summary>
	/// <param name="message">An error message.</param>
	/// <param name="bytesUnknown">The input byte array.</param>
	/// <param name="index">The index position in <paramref name="bytesUnknown" /> of the byte that cannot be decoded.</param>
	public DecoderFallbackException(string message, byte[] bytesUnknown, int index)
	{
	}

	private DecoderFallbackException(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}
}
