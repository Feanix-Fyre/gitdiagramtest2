using System.Runtime.Serialization;

namespace System.Data;

/// <summary>Represents the exception that is thrown when you try to change the value of a read-only column.</summary>
[Serializable]
public class ReadOnlyException : DataException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Data.ReadOnlyException" /> class with serialization information.</summary>
	/// <param name="info">The data that is required to serialize or deserialize an object.</param>
	/// <param name="context">Description of the source and destination of the specified serialized stream.</param>
	protected ReadOnlyException(SerializationInfo info, StreamingContext context)
		: base(null, default(StreamingContext))
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.ReadOnlyException" /> class.</summary>
	public ReadOnlyException()
		: base(null, default(StreamingContext))
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.ReadOnlyException" /> class with the specified string.</summary>
	/// <param name="s">The string to display when the exception is thrown.</param>
	public ReadOnlyException(string s)
		: base(null, default(StreamingContext))
	{
	}
}
