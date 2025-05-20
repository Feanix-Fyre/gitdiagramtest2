using System.Runtime.Serialization;

namespace System;

/// <summary>The exception that is thrown as a wrapper around the exception thrown by the class initializer. This class cannot be inherited.</summary>
[Serializable]
public sealed class TypeInitializationException : SystemException
{
	private string _typeName;

	/// <summary>Gets the fully qualified name of the type that fails to initialize.</summary>
	/// <returns>The fully qualified name of the type that fails to initialize.</returns>
	public string TypeName => null;

	private TypeInitializationException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.TypeInitializationException" /> class with the default error message, the specified type name, and a reference to the inner exception that is the root cause of this exception.</summary>
	/// <param name="fullTypeName">The fully qualified name of the type that fails to initialize.</param>
	/// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not a null reference (<see langword="Nothing" /> in Visual Basic), the current exception is raised in a <see langword="catch" /> block that handles the inner exception.</param>
	public TypeInitializationException(string fullTypeName, Exception innerException)
	{
	}

	internal TypeInitializationException(string fullTypeName, string message, Exception innerException)
	{
	}

	internal TypeInitializationException(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the type name and additional exception information.</summary>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
	/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}
