using System.Runtime.Serialization;

namespace System;

/// <summary>The exception that is thrown when an object appears more than once in an array of synchronization objects.</summary>
[Serializable]
public class DuplicateWaitObjectException : ArgumentException
{
	private static string s_duplicateWaitObjectMessage;

	private static string DuplicateWaitObjectMessage => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.DuplicateWaitObjectException" /> class.</summary>
	public DuplicateWaitObjectException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.DuplicateWaitObjectException" /> class with serialized data.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination.</param>
	protected DuplicateWaitObjectException(SerializationInfo info, StreamingContext context)
	{
	}
}
