using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Security;

/// <summary>The exception that is thrown when a security error is detected.</summary>
[Serializable]
[ComVisible(true)]
public class SecurityException : SystemException
{
	private string permissionState;

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.SecurityException" /> class with default properties.</summary>
	public SecurityException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.SecurityException" /> class with a specified error message.</summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	public SecurityException(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.SecurityException" /> class with serialized data.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="info" /> is <see langword="null" />.</exception>
	protected SecurityException(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Security.SecurityException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner" /> parameter is not <see langword="null" />, the current exception is raised in a <see langword="catch" /> block that handles the inner exception.</param>
	public SecurityException(string message, Exception inner)
	{
	}

	/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the <see cref="T:System.Security.SecurityException" />.</summary>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
	/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is <see langword="null" />.</exception>
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Returns a representation of the current <see cref="T:System.Security.SecurityException" />.</summary>
	/// <returns>A string representation of the current <see cref="T:System.Security.SecurityException" />.</returns>
	public override string ToString()
	{
		return null;
	}
}
