using System.Runtime.Serialization;

namespace System.Runtime.InteropServices;

/// <summary>The exception thrown when an invalid COM object is used.</summary>
[Serializable]
public class InvalidComObjectException : SystemException
{
	/// <summary>Initializes an instance of the <see langword="InvalidComObjectException" /> with default properties.</summary>
	public InvalidComObjectException()
	{
	}

	/// <summary>Initializes a new instance of the <see langword="COMException" /> class from serialization data.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="info" /> is <see langword="null" />.</exception>
	protected InvalidComObjectException(SerializationInfo info, StreamingContext context)
	{
	}
}
