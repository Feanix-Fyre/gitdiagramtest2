using System.Runtime.Serialization;

namespace System;

/// <summary>The exception that is thrown when an attempt is made to access an element of an array or collection with an index that is outside its bounds.</summary>
[Serializable]
public sealed class IndexOutOfRangeException : SystemException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.IndexOutOfRangeException" /> class.</summary>
	public IndexOutOfRangeException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IndexOutOfRangeException" /> class with a specified error message.</summary>
	/// <param name="message">The message that describes the error.</param>
	public IndexOutOfRangeException(string message)
	{
	}

	internal IndexOutOfRangeException(SerializationInfo info, StreamingContext context)
	{
	}
}
