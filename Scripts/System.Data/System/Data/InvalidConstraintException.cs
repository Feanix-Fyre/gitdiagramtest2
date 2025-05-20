using System.Runtime.Serialization;

namespace System.Data;

/// <summary>Represents the exception that is thrown when incorrectly trying to create or access a relation.</summary>
[Serializable]
public class InvalidConstraintException : DataException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Data.InvalidConstraintException" /> class with serialization information.</summary>
	/// <param name="info">The data that is required to serialize or deserialize an object.</param>
	/// <param name="context">Description of the source and destination of the specified serialized stream.</param>
	protected InvalidConstraintException(SerializationInfo info, StreamingContext context)
		: base(null, default(StreamingContext))
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.InvalidConstraintException" /> class.</summary>
	public InvalidConstraintException()
		: base(null, default(StreamingContext))
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.InvalidConstraintException" /> class with the specified string.</summary>
	/// <param name="s">The string to display when the exception is thrown.</param>
	public InvalidConstraintException(string s)
		: base(null, default(StreamingContext))
	{
	}
}
