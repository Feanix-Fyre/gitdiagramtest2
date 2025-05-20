using System.Runtime.Serialization;

namespace System;

/// <summary>The exception that is thrown when an attempt is made to store an element of the wrong type within an array.</summary>
[Serializable]
public class ArrayTypeMismatchException : SystemException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.ArrayTypeMismatchException" /> class.</summary>
	public ArrayTypeMismatchException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ArrayTypeMismatchException" /> class with serialized data.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination.</param>
	protected ArrayTypeMismatchException(SerializationInfo info, StreamingContext context)
	{
	}
}
