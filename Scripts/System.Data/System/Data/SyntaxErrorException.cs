using System.Runtime.Serialization;

namespace System.Data;

/// <summary>Represents the exception that is thrown when the <see cref="P:System.Data.DataColumn.Expression" /> property of a <see cref="T:System.Data.DataColumn" /> contains a syntax error.</summary>
[Serializable]
public class SyntaxErrorException : InvalidExpressionException
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Data.SyntaxErrorException" /> class with the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and the <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
	/// <param name="info">The data needed to serialize or deserialize an object.</param>
	/// <param name="context">The source and destination of a specific serialized stream.</param>
	protected SyntaxErrorException(SerializationInfo info, StreamingContext context)
		: base(null, default(StreamingContext))
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.SyntaxErrorException" /> class.</summary>
	public SyntaxErrorException()
		: base(null, default(StreamingContext))
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.SyntaxErrorException" /> class with the specified string.</summary>
	/// <param name="s">The string to display when the exception is thrown.</param>
	public SyntaxErrorException(string s)
		: base(null, default(StreamingContext))
	{
	}
}
