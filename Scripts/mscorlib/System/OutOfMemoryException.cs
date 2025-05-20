using System.Runtime.Serialization;

namespace System;

/// <summary>The exception that is thrown when there is not enough memory to continue the execution of a program.</summary>
[Serializable]
public class OutOfMemoryException : SystemException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.OutOfMemoryException" /> class.</summary>
	public OutOfMemoryException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.OutOfMemoryException" /> class with a specified error message.</summary>
	/// <param name="message">The message that describes the error.</param>
	public OutOfMemoryException(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.OutOfMemoryException" /> class with serialized data.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination.</param>
	protected OutOfMemoryException(SerializationInfo info, StreamingContext context)
	{
	}
}
