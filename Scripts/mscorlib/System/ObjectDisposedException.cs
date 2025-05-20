using System.Runtime.Serialization;

namespace System;

/// <summary>The exception that is thrown when an operation is performed on a disposed object.</summary>
[Serializable]
public class ObjectDisposedException : InvalidOperationException
{
	private string _objectName;

	/// <summary>Gets the message that describes the error.</summary>
	/// <returns>A string that describes the error.</returns>
	public override string Message => null;

	/// <summary>Gets the name of the disposed object.</summary>
	/// <returns>A string containing the name of the disposed object.</returns>
	public string ObjectName => null;

	private ObjectDisposedException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ObjectDisposedException" /> class with a string containing the name of the disposed object.</summary>
	/// <param name="objectName">A string containing the name of the disposed object.</param>
	public ObjectDisposedException(string objectName)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ObjectDisposedException" /> class with the specified object name and message.</summary>
	/// <param name="objectName">The name of the disposed object.</param>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	public ObjectDisposedException(string objectName, string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ObjectDisposedException" /> class with serialized data.</summary>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
	/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
	protected ObjectDisposedException(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Retrieves the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the parameter name and additional exception information.</summary>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
	/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}
