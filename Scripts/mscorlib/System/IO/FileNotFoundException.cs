using System.Runtime.Serialization;

namespace System.IO;

/// <summary>The exception that is thrown when an attempt to access a file that does not exist on disk fails.</summary>
[Serializable]
public class FileNotFoundException : IOException
{
	/// <summary>Gets the error message that explains the reason for the exception.</summary>
	/// <returns>The error message.</returns>
	public override string Message => null;

	/// <summary>Gets the name of the file that cannot be found.</summary>
	/// <returns>The name of the file, or <see langword="null" /> if no file name was passed to the constructor for this instance.</returns>
	public string FileName { get; }

	/// <summary>Gets the log file that describes why loading of an assembly failed.</summary>
	/// <returns>The errors reported by the assembly cache.</returns>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	public string FusionLog { get; }

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileNotFoundException" /> class with its message string set to a system-supplied message.</summary>
	public FileNotFoundException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileNotFoundException" /> class with a specified error message.</summary>
	/// <param name="message">A description of the error. The content of <paramref name="message" /> is intended to be understood by humans. The caller of this constructor is required to ensure that this string has been localized for the current system culture.</param>
	public FileNotFoundException(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileNotFoundException" /> class with a specified error message, and the file name that cannot be found.</summary>
	/// <param name="message">A description of the error. The content of <paramref name="message" /> is intended to be understood by humans. The caller of this constructor is required to ensure that this string has been localized for the current system culture.</param>
	/// <param name="fileName">The full name of the file with the invalid image.</param>
	public FileNotFoundException(string message, string fileName)
	{
	}

	private void SetMessageField()
	{
	}

	/// <summary>Returns the fully qualified name of this exception and possibly the error message, the name of the inner exception, and the stack trace.</summary>
	/// <returns>The fully qualified name of this exception and possibly the error message, the name of the inner exception, and the stack trace.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileNotFoundException" /> class with the specified serialization and context information.</summary>
	/// <param name="info">An object that holds the serialized object data about the exception being thrown.</param>
	/// <param name="context">An object that contains contextual information about the source or destination.</param>
	protected FileNotFoundException(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the file name and additional exception information.</summary>
	/// <param name="info">The object that holds the serialized object data about the exception being thrown.</param>
	/// <param name="context">The object that contains contextual information about the source or destination.</param>
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}
