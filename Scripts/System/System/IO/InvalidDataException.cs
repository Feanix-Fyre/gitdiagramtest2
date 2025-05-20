using System.Runtime.Serialization;

namespace System.IO;

/// <summary>The exception that is thrown when a data stream is in an invalid format.</summary>
[Serializable]
public sealed class InvalidDataException : SystemException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.IO.InvalidDataException" /> class.</summary>
	public InvalidDataException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.InvalidDataException" /> class with a specified error message.</summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	public InvalidDataException(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.InvalidDataException" /> class with a reference to the inner exception that is the cause of this exception.</summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not <see langword="null" />, the current exception is raised in a <see langword="catch" /> block that handles the inner exception.</param>
	public InvalidDataException(string message, Exception innerException)
	{
	}

	private InvalidDataException(SerializationInfo info, StreamingContext context)
	{
	}
}
