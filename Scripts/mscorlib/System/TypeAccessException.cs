using System.Runtime.Serialization;

namespace System;

/// <summary>The exception that is thrown when a method attempts to use a type that it does not have access to.</summary>
[Serializable]
public class TypeAccessException : TypeLoadException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.TypeAccessException" /> class with a system-supplied message that describes the error.</summary>
	public TypeAccessException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.TypeAccessException" /> class with serialized data.</summary>
	/// <param name="info">The object that holds the serialized data.</param>
	/// <param name="context">The contextual information about the source or destination.</param>
	protected TypeAccessException(SerializationInfo info, StreamingContext context)
	{
	}
}
