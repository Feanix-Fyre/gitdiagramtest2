using System.Runtime.Serialization;

namespace System;

/// <summary>The exception that is thrown when the time allotted for a process or operation has expired.</summary>
[Serializable]
public class TimeoutException : SystemException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.TimeoutException" /> class.</summary>
	public TimeoutException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.TimeoutException" /> class with the specified error message.</summary>
	/// <param name="message">The message that describes the error.</param>
	public TimeoutException(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.TimeoutException" /> class with serialized data.</summary>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that contains serialized object data about the exception being thrown.</param>
	/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that contains contextual information about the source or destination. The <paramref name="context" /> parameter is reserved for future use, and can be specified as <see langword="null" />.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is <see langword="null" />, or <see cref="P:System.Exception.HResult" /> is zero (0).</exception>
	protected TimeoutException(SerializationInfo info, StreamingContext context)
	{
	}
}
