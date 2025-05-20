namespace System.Text;

/// <summary>Provides the base class for an encoding provider, which supplies encodings that are unavailable on a particular platform.</summary>
public abstract class EncodingProvider
{
	private static object s_InternalSyncObject;

	private static EncodingProvider[] s_providers;

	/// <summary>Returns the encoding with the specified name.</summary>
	/// <param name="name">The name of the requested encoding.</param>
	/// <returns>The encoding that is associated with the specified name, or <see langword="null" /> if this <see cref="T:System.Text.EncodingProvider" /> cannot return a valid encoding that corresponds to <paramref name="name" />.</returns>
	public abstract Encoding GetEncoding(string name);

	/// <summary>Returns the encoding associated with the specified code page identifier.</summary>
	/// <param name="codepage">The code page identifier of the requested encoding.</param>
	/// <returns>The encoding that is associated with the specified code page, or <see langword="null" /> if this <see cref="T:System.Text.EncodingProvider" /> cannot return a valid encoding that corresponds to <paramref name="codepage" />.</returns>
	public abstract Encoding GetEncoding(int codepage);

	/// <summary>Returns the encoding associated with the specified code page identifier. Parameters specify an error handler for characters that cannot be encoded and byte sequences that cannot be decoded.</summary>
	/// <param name="codepage">The code page identifier of the requested encoding.</param>
	/// <param name="encoderFallback">An object that provides an error-handling procedure when a character cannot be encoded with this encoding.</param>
	/// <param name="decoderFallback">An object that provides an error-handling procedure when a byte sequence cannot be decoded with this encoding.</param>
	/// <returns>The encoding that is associated with the specified code page, or <see langword="null" /> if this <see cref="T:System.Text.EncodingProvider" /> cannot return a valid encoding that corresponds to <paramref name="codepage" />.</returns>
	public virtual Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
	{
		return null;
	}

	internal static Encoding GetEncodingFromProvider(int codepage)
	{
		return null;
	}

	internal static Encoding GetEncodingFromProvider(string encodingName)
	{
		return null;
	}

	internal static Encoding GetEncodingFromProvider(int codepage, EncoderFallback enc, DecoderFallback dec)
	{
		return null;
	}
}
