using System.Runtime.Serialization;

namespace System.Data;

/// <summary>Represents the exception that is thrown when you try to insert a null value into a column where <see cref="P:System.Data.DataColumn.AllowDBNull" /> is set to <see langword="false" />.</summary>
[Serializable]
public class NoNullAllowedException : DataException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Data.NoNullAllowedException" /> class with serialization information.</summary>
	/// <param name="info">The data that is required to serialize or deserialize an object.</param>
	/// <param name="context">Description of the source and destination of the specified serialized stream.</param>
	protected NoNullAllowedException(SerializationInfo info, StreamingContext context)
		: base(null, default(StreamingContext))
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.NoNullAllowedException" /> class.</summary>
	public NoNullAllowedException()
		: base(null, default(StreamingContext))
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.NoNullAllowedException" /> class with the specified string.</summary>
	/// <param name="s">The string to display when the exception is thrown.</param>
	public NoNullAllowedException(string s)
		: base(null, default(StreamingContext))
	{
	}
}
