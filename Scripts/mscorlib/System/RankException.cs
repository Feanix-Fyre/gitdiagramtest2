using System.Runtime.Serialization;

namespace System;

/// <summary>The exception that is thrown when an array with the wrong number of dimensions is passed to a method.</summary>
[Serializable]
public class RankException : SystemException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.RankException" /> class.</summary>
	public RankException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.RankException" /> class with a specified error message.</summary>
	/// <param name="message">A <see cref="T:System.String" /> that describes the error.</param>
	public RankException(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.RankException" /> class with serialized data.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination.</param>
	protected RankException(SerializationInfo info, StreamingContext context)
	{
	}
}
