using System.Runtime.Serialization;

namespace System;

/// <summary>The exception that is thrown when there is an attempt to dynamically access a field that does not exist. If a field in a class library has been removed or renamed, recompile any assemblies that reference that library.</summary>
[Serializable]
public class MissingFieldException : MissingMemberException, ISerializable
{
	/// <summary>Gets the text string showing the signature of the missing field, the class name, and the field name. This property is read-only.</summary>
	/// <returns>The error message string.</returns>
	public override string Message => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.MissingFieldException" /> class.</summary>
	public MissingFieldException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.MissingFieldException" /> class with a specified error message.</summary>
	/// <param name="message">A <see cref="T:System.String" /> that describes the error.</param>
	public MissingFieldException(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.MissingFieldException" /> class with the specified class name and field name.</summary>
	/// <param name="className">The name of the class in which access to a nonexistent field was attempted.</param>
	/// <param name="fieldName">The name of the field that cannot be accessed.</param>
	public MissingFieldException(string className, string fieldName)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.MissingFieldException" /> class with serialized data.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination.</param>
	protected MissingFieldException(SerializationInfo info, StreamingContext context)
	{
	}
}
