using System.Runtime.Serialization;

namespace System.IO;

/// <summary>The exception thrown when the internal buffer overflows.</summary>
[Serializable]
public class InternalBufferOverflowException : SystemException
{
	/// <summary>Initializes a new default instance of the <see cref="T:System.IO.InternalBufferOverflowException" /> class.</summary>
	public InternalBufferOverflowException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.InternalBufferOverflowException" /> class with the error message to be displayed specified.</summary>
	/// <param name="message">The message to be given for the exception.</param>
	public InternalBufferOverflowException(string message)
	{
	}

	/// <summary>Initializes a new, empty instance of the <see cref="T:System.IO.InternalBufferOverflowException" /> class that is serializable using the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> objects.</summary>
	/// <param name="info">The information required to serialize the T:System.IO.InternalBufferOverflowException object.</param>
	/// <param name="context">The source and destination of the serialized stream associated with the T:System.IO.InternalBufferOverflowException object.</param>
	protected InternalBufferOverflowException(SerializationInfo info, StreamingContext context)
	{
	}
}
