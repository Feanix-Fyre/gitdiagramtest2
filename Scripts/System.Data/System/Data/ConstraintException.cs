using System.Runtime.Serialization;

namespace System.Data;

/// <summary>Represents the exception that is thrown when attempting an action that violates a constraint.</summary>
[Serializable]
public class ConstraintException : DataException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Data.ConstraintException" /> class using the specified serialization and stream context.</summary>
	/// <param name="info">The data necessary to serialize or deserialize an object.</param>
	/// <param name="context">Description of the source and destination of the specified serialized stream.</param>
	protected ConstraintException(SerializationInfo info, StreamingContext context)
		: base(null, default(StreamingContext))
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.ConstraintException" /> class. This is the default constructor.</summary>
	public ConstraintException()
		: base(null, default(StreamingContext))
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.ConstraintException" /> class with the specified string.</summary>
	/// <param name="s">The string to display when the exception is thrown.</param>
	public ConstraintException(string s)
		: base(null, default(StreamingContext))
	{
	}
}
