using System.Runtime.Serialization;

namespace System.IO;

/// <summary>The exception that is thrown when a managed assembly is found but cannot be loaded.</summary>
[Serializable]
public class FileLoadException : IOException
{
	/// <summary>Gets the error message and the name of the file that caused this exception.</summary>
	/// <returns>A string containing the error message and the name of the file that caused this exception.</returns>
	public override string Message => null;

	/// <summary>Gets the name of the file that causes this exception.</summary>
	/// <returns>A <see cref="T:System.String" /> containing the name of the file with the invalid image, or a null reference if no file name was passed to the constructor for the current instance.</returns>
	public string FileName { get; }

	/// <summary>Gets the log file that describes why an assembly load failed.</summary>
	/// <returns>A string containing errors reported by the assembly cache.</returns>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	public string FusionLog { get; }

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileLoadException" /> class, setting the <see cref="P:System.Exception.Message" /> property of the new instance to a system-supplied message that describes the error, such as "Could not load the specified file." This message takes into account the current system culture.</summary>
	public FileLoadException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileLoadException" /> class with the specified error message.</summary>
	/// <param name="message">A <see cref="T:System.String" /> that describes the error. The content of <paramref name="message" /> is intended to be understood by humans. The caller of this constructor is required to ensure that this string has been localized for the current system culture.</param>
	public FileLoadException(string message)
	{
	}

	/// <summary>Returns the fully qualified name of the current exception, and possibly the error message, the name of the inner exception, and the stack trace.</summary>
	/// <returns>A string containing the fully qualified name of this exception, and possibly the error message, the name of the inner exception, and the stack trace, depending on which <see cref="T:System.IO.FileLoadException" /> constructor is used.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileLoadException" /> class with serialized data.</summary>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
	/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
	protected FileLoadException(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the file name and additional exception information.</summary>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
	/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	internal static string FormatFileLoadExceptionMessage(string fileName, int hResult)
	{
		return null;
	}
}
