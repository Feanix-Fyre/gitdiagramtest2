using System.Runtime.Serialization;

namespace System.Runtime.InteropServices;

/// <summary>The exception thrown when the type of the incoming <see langword="SAFEARRAY" /> does not match the type specified in the managed signature.</summary>
[Serializable]
public class SafeArrayTypeMismatchException : SystemException
{
	/// <summary>Initializes a new instance of the <see langword="SafeArrayTypeMismatchException" /> class with default values.</summary>
	public SafeArrayTypeMismatchException()
	{
	}

	/// <summary>Initializes a new instance of the <see langword="SafeArrayTypeMismatchException" /> class from serialization data.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="info" /> is <see langword="null" />.</exception>
	protected SafeArrayTypeMismatchException(SerializationInfo info, StreamingContext context)
	{
	}
}
