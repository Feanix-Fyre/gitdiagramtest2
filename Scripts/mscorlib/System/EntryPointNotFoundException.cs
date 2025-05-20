using System.Runtime.Serialization;

namespace System;

/// <summary>The exception that is thrown when an attempt to load a class fails due to the absence of an entry method.</summary>
[Serializable]
public class EntryPointNotFoundException : TypeLoadException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.EntryPointNotFoundException" /> class.</summary>
	public EntryPointNotFoundException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.EntryPointNotFoundException" /> class with a specified error message.</summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	public EntryPointNotFoundException(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.EntryPointNotFoundException" /> class with serialized data.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination.</param>
	protected EntryPointNotFoundException(SerializationInfo info, StreamingContext context)
	{
	}
}
