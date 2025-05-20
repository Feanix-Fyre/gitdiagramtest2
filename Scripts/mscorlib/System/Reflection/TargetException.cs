using System.Runtime.Serialization;

namespace System.Reflection;

/// <summary>Represents the exception that is thrown when an attempt is made to invoke an invalid target.</summary>
[Serializable]
public class TargetException : ApplicationException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.TargetException" /> class with an empty message and the root cause of the exception.</summary>
	public TargetException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.TargetException" /> class with the given message and the root cause exception.</summary>
	/// <param name="message">A <see langword="String" /> describing the reason why the exception occurred.</param>
	public TargetException(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.TargetException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner" /> parameter is not <see langword="null" />, the current exception is raised in a <see langword="catch" /> block that handles the inner exception.</param>
	public TargetException(string message, Exception inner)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.TargetException" /> class with the specified serialization and context information.</summary>
	/// <param name="info">The data for serializing or deserializing the object.</param>
	/// <param name="context">The source of and destination for the object.</param>
	protected TargetException(SerializationInfo info, StreamingContext context)
	{
	}
}
