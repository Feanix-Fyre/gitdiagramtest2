using System.Runtime.Serialization;

namespace System;

/// <summary>The exception that is thrown when a requested method or operation is not implemented.</summary>
[Serializable]
public class NotImplementedException : SystemException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.NotImplementedException" /> class with default properties.</summary>
	public NotImplementedException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.NotImplementedException" /> class with a specified error message.</summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	public NotImplementedException(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.NotImplementedException" /> class with serialized data.</summary>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
	/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
	protected NotImplementedException(SerializationInfo info, StreamingContext context)
	{
	}
}
