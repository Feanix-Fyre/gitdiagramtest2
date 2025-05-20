using System.Runtime.Serialization;

namespace System.Text;

/// <summary>Provides a failure handling mechanism, called a fallback, for an input character that cannot be converted to an output byte sequence. The fallback uses a user-specified replacement string instead of the original input character. This class cannot be inherited.</summary>
[Serializable]
public sealed class EncoderReplacementFallback : EncoderFallback, ISerializable
{
	private string _strDefault;

	/// <summary>Gets the replacement string that is the value of the <see cref="T:System.Text.EncoderReplacementFallback" /> object.</summary>
	/// <returns>A substitute string that is used in place of an input character that cannot be encoded.</returns>
	public string DefaultString => null;

	/// <summary>Gets the number of characters in the replacement string for the <see cref="T:System.Text.EncoderReplacementFallback" /> object.</summary>
	/// <returns>The number of characters in the string used in place of an input character that cannot be encoded.</returns>
	public override int MaxCharCount => 0;

	/// <summary>Initializes a new instance of the <see cref="T:System.Text.EncoderReplacementFallback" /> class.</summary>
	public EncoderReplacementFallback()
	{
	}

	internal EncoderReplacementFallback(SerializationInfo info, StreamingContext context)
	{
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Text.EncoderReplacementFallback" /> class using a specified replacement string.</summary>
	/// <param name="replacement">A string that is converted in an encoding operation in place of an input character that cannot be encoded.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="replacement" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="replacement" /> contains an invalid surrogate pair. In other words, the surrogate does not consist of one high surrogate component followed by one low surrogate component.</exception>
	public EncoderReplacementFallback(string replacement)
	{
	}

	/// <summary>Creates a <see cref="T:System.Text.EncoderFallbackBuffer" /> object that is initialized with the replacement string of this <see cref="T:System.Text.EncoderReplacementFallback" /> object.</summary>
	/// <returns>A <see cref="T:System.Text.EncoderFallbackBuffer" /> object equal to this <see cref="T:System.Text.EncoderReplacementFallback" /> object.</returns>
	public override EncoderFallbackBuffer CreateFallbackBuffer()
	{
		return null;
	}

	/// <summary>Indicates whether the value of a specified object is equal to the <see cref="T:System.Text.EncoderReplacementFallback" /> object.</summary>
	/// <param name="value">A <see cref="T:System.Text.EncoderReplacementFallback" /> object.</param>
	/// <returns>
	///   <see langword="true" /> if the <paramref name="value" /> parameter specifies an <see cref="T:System.Text.EncoderReplacementFallback" /> object and the replacement string of that object is equal to the replacement string of this <see cref="T:System.Text.EncoderReplacementFallback" /> object; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object value)
	{
		return false;
	}

	/// <summary>Retrieves the hash code for the value of the <see cref="T:System.Text.EncoderReplacementFallback" /> object.</summary>
	/// <returns>The hash code of the value of the object.</returns>
	public override int GetHashCode()
	{
		return 0;
	}
}
