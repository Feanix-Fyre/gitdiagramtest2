using System.Runtime.Serialization;

namespace System.Data.SqlTypes;

/// <summary>The base exception class for the <see cref="N:System.Data.SqlTypes" />.</summary>
[Serializable]
public class SqlTypeException : SystemException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlTypeException" /> class.</summary>
	public SqlTypeException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlTypeException" /> class with a specified error message.</summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	public SqlTypeException(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlTypeException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
	/// <param name="message">The message that describes the exception. The caller of this constructor is required to ensure that this string has been localized for the current system culture.</param>
	/// <param name="e">The exception that is the cause of the current exception. If the innerException parameter is not <see langword="null" />, the current exception is raised in a <see langword="catch" /> block that handles the inner exception.</param>
	public SqlTypeException(string message, Exception e)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlTypeException" /> class with serialized data.</summary>
	/// <param name="si">The object that holds the serialized object data.</param>
	/// <param name="sc">The contextual information about the source or destination.</param>
	protected SqlTypeException(SerializationInfo si, StreamingContext sc)
	{
	}

	private static SerializationInfo SqlTypeExceptionSerialization(SerializationInfo si, StreamingContext sc)
	{
		return null;
	}
}
