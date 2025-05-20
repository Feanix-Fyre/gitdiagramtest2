using System.Runtime.Serialization;

namespace System.Data;

/// <summary>Represents the exception that is thrown when a duplicate database object name is encountered during an add operation in a <see cref="T:System.Data.DataSet" /> -related object.</summary>
[Serializable]
public class DuplicateNameException : DataException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Data.DuplicateNameException" /> class with serialization information.</summary>
	/// <param name="info">The data that is required to serialize or deserialize an object.</param>
	/// <param name="context">Description of the source and destination of the specified serialized stream.</param>
	protected DuplicateNameException(SerializationInfo info, StreamingContext context)
		: base(null, default(StreamingContext))
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.DuplicateNameException" /> class.</summary>
	public DuplicateNameException()
		: base(null, default(StreamingContext))
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.DuplicateNameException" /> class with the specified string.</summary>
	/// <param name="s">The string to display when the exception is thrown.</param>
	public DuplicateNameException(string s)
		: base(null, default(StreamingContext))
	{
	}
}
