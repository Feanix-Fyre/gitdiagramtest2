using System.Runtime.Serialization;

namespace System;

/// <summary>The exception that is thrown when the file image of a dynamic link library (DLL) or an executable program is invalid.</summary>
[Serializable]
public class BadImageFormatException : SystemException
{
	private string _fileName;

	private string _fusionLog;

	/// <summary>Gets the error message and the name of the file that caused this exception.</summary>
	/// <returns>A string containing the error message and the name of the file that caused this exception.</returns>
	public override string Message => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.BadImageFormatException" /> class.</summary>
	public BadImageFormatException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.BadImageFormatException" /> class with a specified error message.</summary>
	/// <param name="message">The message that describes the error.</param>
	public BadImageFormatException(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.BadImageFormatException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner" /> parameter is not a null reference, the current exception is raised in a <see langword="catch" /> block that handles the inner exception.</param>
	public BadImageFormatException(string message, Exception inner)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.BadImageFormatException" /> class with a specified error message and file name.</summary>
	/// <param name="message">A message that describes the error.</param>
	/// <param name="fileName">The full name of the file with the invalid image.</param>
	public BadImageFormatException(string message, string fileName)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.BadImageFormatException" /> class with serialized data.</summary>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
	/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
	protected BadImageFormatException(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the file name, assembly cache log, and additional exception information.</summary>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
	/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	private void SetMessageField()
	{
	}

	/// <summary>Returns the fully qualified name of this exception and possibly the error message, the name of the inner exception, and the stack trace.</summary>
	/// <returns>A string containing the fully qualified name of this exception and possibly the error message, the name of the inner exception, and the stack trace.</returns>
	public override string ToString()
	{
		return null;
	}
}
