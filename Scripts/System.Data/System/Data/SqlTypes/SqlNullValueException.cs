using System.Runtime.Serialization;

namespace System.Data.SqlTypes;

/// <summary>The exception that is thrown when the <see langword="Value" /> property of a <see cref="N:System.Data.SqlTypes" /> structure is set to null.</summary>
[Serializable]
public sealed class SqlNullValueException : SqlTypeException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlNullValueException" /> class with a system-supplied message that describes the error.</summary>
	public SqlNullValueException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlNullValueException" /> class with a specified message that describes the error.</summary>
	/// <param name="message">The message that describes the exception. The caller of this constructor is required to ensure that this string has been localized for the current system culture.</param>
	public SqlNullValueException(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlNullValueException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
	/// <param name="message">The message that describes the exception. The caller of this constructor is required to ensure that this string has been localized for the current system culture.</param>
	/// <param name="e">The exception that is the cause of the current exception. If the innerException parameter is not <see langword="null" />, the current exception is raised in a <see langword="catch" /> block that handles the inner exception.</param>
	public SqlNullValueException(string message, Exception e)
	{
	}

	private SqlNullValueException(SerializationInfo si, StreamingContext sc)
	{
	}

	private static SerializationInfo SqlNullValueExceptionSerialization(SerializationInfo si, StreamingContext sc)
	{
		return null;
	}
}
