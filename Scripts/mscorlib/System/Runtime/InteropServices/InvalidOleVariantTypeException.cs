using System.Runtime.Serialization;

namespace System.Runtime.InteropServices;

/// <summary>The exception thrown by the marshaler when it encounters an argument of a variant type that can not be marshaled to managed code.</summary>
[Serializable]
public class InvalidOleVariantTypeException : SystemException
{
	/// <summary>Initializes a new instance of the <see langword="InvalidOleVariantTypeException" /> class with default values.</summary>
	public InvalidOleVariantTypeException()
	{
	}

	/// <summary>Initializes a new instance of the <see langword="InvalidOleVariantTypeException" /> class from serialization data.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="info" /> is <see langword="null" />.</exception>
	protected InvalidOleVariantTypeException(SerializationInfo info, StreamingContext context)
	{
	}
}
